using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001254 RID: 4692
	public struct TemplateDataPreload : IFlatbufferObject
	{
		// Token: 0x17003D4F RID: 15695
		// (get) Token: 0x0600EAC7 RID: 60103 RVA: 0x00355F1C File Offset: 0x0035411C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EAC8 RID: 60104 RVA: 0x00355F29 File Offset: 0x00354129
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EAC9 RID: 60105 RVA: 0x00355F30 File Offset: 0x00354130
		public static TemplateDataPreload GetRootAsTemplateDataPreload(ByteBuffer _bb)
		{
			return TemplateDataPreload.GetRootAsTemplateDataPreload(_bb, default(TemplateDataPreload));
		}

		// Token: 0x0600EACA RID: 60106 RVA: 0x00355F4C File Offset: 0x0035414C
		public static TemplateDataPreload GetRootAsTemplateDataPreload(ByteBuffer _bb, TemplateDataPreload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EACB RID: 60107 RVA: 0x00355F69 File Offset: 0x00354169
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EACC RID: 60108 RVA: 0x00355F78 File Offset: 0x00354178
		public TemplateDataPreload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D50 RID: 15696
		// (get) Token: 0x0600EACD RID: 60109 RVA: 0x00355F88 File Offset: 0x00354188
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EACE RID: 60110 RVA: 0x00355FC4 File Offset: 0x003541C4
		public string ActorClass(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D51 RID: 15697
		// (get) Token: 0x0600EACF RID: 60111 RVA: 0x00356000 File Offset: 0x00354200
		public int ActorClassLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EAD0 RID: 60112 RVA: 0x0035602C File Offset: 0x0035422C
		public string Animations(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D52 RID: 15698
		// (get) Token: 0x0600EAD1 RID: 60113 RVA: 0x00356068 File Offset: 0x00354268
		public int AnimationsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EAD2 RID: 60114 RVA: 0x00356094 File Offset: 0x00354294
		public string Effects(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D53 RID: 15699
		// (get) Token: 0x0600EAD3 RID: 60115 RVA: 0x003560D0 File Offset: 0x003542D0
		public int EffectsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EAD4 RID: 60116 RVA: 0x003560FC File Offset: 0x003542FC
		public string Audios(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D54 RID: 15700
		// (get) Token: 0x0600EAD5 RID: 60117 RVA: 0x00356138 File Offset: 0x00354338
		public int AudiosLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EAD6 RID: 60118 RVA: 0x00356164 File Offset: 0x00354364
		public string Meshes(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D55 RID: 15701
		// (get) Token: 0x0600EAD7 RID: 60119 RVA: 0x003561A0 File Offset: 0x003543A0
		public int MeshesLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EAD8 RID: 60120 RVA: 0x003561CC File Offset: 0x003543CC
		public string Materials(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D56 RID: 15702
		// (get) Token: 0x0600EAD9 RID: 60121 RVA: 0x00356208 File Offset: 0x00354408
		public int MaterialsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EADA RID: 60122 RVA: 0x00356234 File Offset: 0x00354434
		public string AnimationBlueprints(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D57 RID: 15703
		// (get) Token: 0x0600EADB RID: 60123 RVA: 0x00356270 File Offset: 0x00354470
		public int AnimationBlueprintsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EADC RID: 60124 RVA: 0x0035629C File Offset: 0x0035449C
		public string Others(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D58 RID: 15704
		// (get) Token: 0x0600EADD RID: 60125 RVA: 0x003562D8 File Offset: 0x003544D8
		public int OthersLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EADE RID: 60126 RVA: 0x00356304 File Offset: 0x00354504
		[NullableContext(1)]
		public string[] ActorClass()
		{
			return this.ActorClassIter().ToArray<string>();
		}

		// Token: 0x0600EADF RID: 60127 RVA: 0x00356311 File Offset: 0x00354511
		[NullableContext(1)]
		public IEnumerable<string> ActorClassIter()
		{
			TemplateDataPreload.<ActorClassIter>d__35 <ActorClassIter>d__ = new TemplateDataPreload.<ActorClassIter>d__35(-2);
			<ActorClassIter>d__.<>3__<>4__this = this;
			return <ActorClassIter>d__;
		}

		// Token: 0x0600EAE0 RID: 60128 RVA: 0x00356326 File Offset: 0x00354526
		[NullableContext(1)]
		public string[] AnimationBlueprints()
		{
			return this.AnimationBlueprintsIter().ToArray<string>();
		}

		// Token: 0x0600EAE1 RID: 60129 RVA: 0x00356333 File Offset: 0x00354533
		[NullableContext(1)]
		public IEnumerable<string> AnimationBlueprintsIter()
		{
			TemplateDataPreload.<AnimationBlueprintsIter>d__37 <AnimationBlueprintsIter>d__ = new TemplateDataPreload.<AnimationBlueprintsIter>d__37(-2);
			<AnimationBlueprintsIter>d__.<>3__<>4__this = this;
			return <AnimationBlueprintsIter>d__;
		}

		// Token: 0x0600EAE2 RID: 60130 RVA: 0x00356348 File Offset: 0x00354548
		[NullableContext(1)]
		public string[] Animations()
		{
			return this.AnimationsIter().ToArray<string>();
		}

		// Token: 0x0600EAE3 RID: 60131 RVA: 0x00356355 File Offset: 0x00354555
		[NullableContext(1)]
		public IEnumerable<string> AnimationsIter()
		{
			TemplateDataPreload.<AnimationsIter>d__39 <AnimationsIter>d__ = new TemplateDataPreload.<AnimationsIter>d__39(-2);
			<AnimationsIter>d__.<>3__<>4__this = this;
			return <AnimationsIter>d__;
		}

		// Token: 0x0600EAE4 RID: 60132 RVA: 0x0035636A File Offset: 0x0035456A
		[NullableContext(1)]
		public string[] Audios()
		{
			return this.AudiosIter().ToArray<string>();
		}

		// Token: 0x0600EAE5 RID: 60133 RVA: 0x00356377 File Offset: 0x00354577
		[NullableContext(1)]
		public IEnumerable<string> AudiosIter()
		{
			TemplateDataPreload.<AudiosIter>d__41 <AudiosIter>d__ = new TemplateDataPreload.<AudiosIter>d__41(-2);
			<AudiosIter>d__.<>3__<>4__this = this;
			return <AudiosIter>d__;
		}

		// Token: 0x0600EAE6 RID: 60134 RVA: 0x0035638C File Offset: 0x0035458C
		[NullableContext(1)]
		public string[] Effects()
		{
			return this.EffectsIter().ToArray<string>();
		}

		// Token: 0x0600EAE7 RID: 60135 RVA: 0x00356399 File Offset: 0x00354599
		[NullableContext(1)]
		public IEnumerable<string> EffectsIter()
		{
			TemplateDataPreload.<EffectsIter>d__43 <EffectsIter>d__ = new TemplateDataPreload.<EffectsIter>d__43(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x0600EAE8 RID: 60136 RVA: 0x003563AE File Offset: 0x003545AE
		[NullableContext(1)]
		public string[] Materials()
		{
			return this.MaterialsIter().ToArray<string>();
		}

		// Token: 0x0600EAE9 RID: 60137 RVA: 0x003563BB File Offset: 0x003545BB
		[NullableContext(1)]
		public IEnumerable<string> MaterialsIter()
		{
			TemplateDataPreload.<MaterialsIter>d__45 <MaterialsIter>d__ = new TemplateDataPreload.<MaterialsIter>d__45(-2);
			<MaterialsIter>d__.<>3__<>4__this = this;
			return <MaterialsIter>d__;
		}

		// Token: 0x0600EAEA RID: 60138 RVA: 0x003563D0 File Offset: 0x003545D0
		[NullableContext(1)]
		public string[] Meshes()
		{
			return this.MeshesIter().ToArray<string>();
		}

		// Token: 0x0600EAEB RID: 60139 RVA: 0x003563DD File Offset: 0x003545DD
		[NullableContext(1)]
		public IEnumerable<string> MeshesIter()
		{
			TemplateDataPreload.<MeshesIter>d__47 <MeshesIter>d__ = new TemplateDataPreload.<MeshesIter>d__47(-2);
			<MeshesIter>d__.<>3__<>4__this = this;
			return <MeshesIter>d__;
		}

		// Token: 0x0600EAEC RID: 60140 RVA: 0x003563F2 File Offset: 0x003545F2
		[NullableContext(1)]
		public string[] Others()
		{
			return this.OthersIter().ToArray<string>();
		}

		// Token: 0x0600EAED RID: 60141 RVA: 0x003563FF File Offset: 0x003545FF
		[NullableContext(1)]
		public IEnumerable<string> OthersIter()
		{
			TemplateDataPreload.<OthersIter>d__49 <OthersIter>d__ = new TemplateDataPreload.<OthersIter>d__49(-2);
			<OthersIter>d__.<>3__<>4__this = this;
			return <OthersIter>d__;
		}

		// Token: 0x0400589E RID: 22686
		private Table __p;
	}
}
