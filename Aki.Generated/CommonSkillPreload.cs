using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C70 RID: 3184
	public struct CommonSkillPreload : IFlatbufferObject
	{
		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06005D46 RID: 23878 RVA: 0x0021A890 File Offset: 0x00218A90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005D47 RID: 23879 RVA: 0x0021A89D File Offset: 0x00218A9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005D48 RID: 23880 RVA: 0x0021A8A4 File Offset: 0x00218AA4
		public static CommonSkillPreload GetRootAsCommonSkillPreload(ByteBuffer _bb)
		{
			return CommonSkillPreload.GetRootAsCommonSkillPreload(_bb, default(CommonSkillPreload));
		}

		// Token: 0x06005D49 RID: 23881 RVA: 0x0021A8C0 File Offset: 0x00218AC0
		public static CommonSkillPreload GetRootAsCommonSkillPreload(ByteBuffer _bb, CommonSkillPreload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005D4A RID: 23882 RVA: 0x0021A8DD File Offset: 0x00218ADD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005D4B RID: 23883 RVA: 0x0021A8EC File Offset: 0x00218AEC
		public CommonSkillPreload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06005D4C RID: 23884 RVA: 0x0021A8FC File Offset: 0x00218AFC
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

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06005D4D RID: 23885 RVA: 0x0021A938 File Offset: 0x00218B38
		public bool IsCommon
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06005D4E RID: 23886 RVA: 0x0021A978 File Offset: 0x00218B78
		public bool HasMontagePath
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06005D4F RID: 23887 RVA: 0x0021A9B8 File Offset: 0x00218BB8
		public string ActorClass(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06005D50 RID: 23888 RVA: 0x0021A9F4 File Offset: 0x00218BF4
		public int ActorClassLength
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

		// Token: 0x06005D51 RID: 23889 RVA: 0x0021AA20 File Offset: 0x00218C20
		public string Animations(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06005D52 RID: 23890 RVA: 0x0021AA5C File Offset: 0x00218C5C
		public int AnimationsLength
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

		// Token: 0x06005D53 RID: 23891 RVA: 0x0021AA88 File Offset: 0x00218C88
		public string Effects(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06005D54 RID: 23892 RVA: 0x0021AAC4 File Offset: 0x00218CC4
		public int EffectsLength
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

		// Token: 0x06005D55 RID: 23893 RVA: 0x0021AAF0 File Offset: 0x00218CF0
		public string Audios(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06005D56 RID: 23894 RVA: 0x0021AB2C File Offset: 0x00218D2C
		public int AudiosLength
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

		// Token: 0x06005D57 RID: 23895 RVA: 0x0021AB58 File Offset: 0x00218D58
		public string Meshes(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06005D58 RID: 23896 RVA: 0x0021AB94 File Offset: 0x00218D94
		public int MeshesLength
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

		// Token: 0x06005D59 RID: 23897 RVA: 0x0021ABC0 File Offset: 0x00218DC0
		public string Materials(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06005D5A RID: 23898 RVA: 0x0021ABFC File Offset: 0x00218DFC
		public int MaterialsLength
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

		// Token: 0x06005D5B RID: 23899 RVA: 0x0021AC28 File Offset: 0x00218E28
		public string AnimationBlueprints(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06005D5C RID: 23900 RVA: 0x0021AC64 File Offset: 0x00218E64
		public int AnimationBlueprintsLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005D5D RID: 23901 RVA: 0x0021AC90 File Offset: 0x00218E90
		public string Others(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06005D5E RID: 23902 RVA: 0x0021ACCC File Offset: 0x00218ECC
		public int OthersLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005D5F RID: 23903 RVA: 0x0021ACF8 File Offset: 0x00218EF8
		[NullableContext(1)]
		public string[] ActorClass()
		{
			return this.ActorClassIter().ToArray<string>();
		}

		// Token: 0x06005D60 RID: 23904 RVA: 0x0021AD05 File Offset: 0x00218F05
		[NullableContext(1)]
		public IEnumerable<string> ActorClassIter()
		{
			CommonSkillPreload.<ActorClassIter>d__39 <ActorClassIter>d__ = new CommonSkillPreload.<ActorClassIter>d__39(-2);
			<ActorClassIter>d__.<>3__<>4__this = this;
			return <ActorClassIter>d__;
		}

		// Token: 0x06005D61 RID: 23905 RVA: 0x0021AD1A File Offset: 0x00218F1A
		[NullableContext(1)]
		public string[] AnimationBlueprints()
		{
			return this.AnimationBlueprintsIter().ToArray<string>();
		}

		// Token: 0x06005D62 RID: 23906 RVA: 0x0021AD27 File Offset: 0x00218F27
		[NullableContext(1)]
		public IEnumerable<string> AnimationBlueprintsIter()
		{
			CommonSkillPreload.<AnimationBlueprintsIter>d__41 <AnimationBlueprintsIter>d__ = new CommonSkillPreload.<AnimationBlueprintsIter>d__41(-2);
			<AnimationBlueprintsIter>d__.<>3__<>4__this = this;
			return <AnimationBlueprintsIter>d__;
		}

		// Token: 0x06005D63 RID: 23907 RVA: 0x0021AD3C File Offset: 0x00218F3C
		[NullableContext(1)]
		public string[] Animations()
		{
			return this.AnimationsIter().ToArray<string>();
		}

		// Token: 0x06005D64 RID: 23908 RVA: 0x0021AD49 File Offset: 0x00218F49
		[NullableContext(1)]
		public IEnumerable<string> AnimationsIter()
		{
			CommonSkillPreload.<AnimationsIter>d__43 <AnimationsIter>d__ = new CommonSkillPreload.<AnimationsIter>d__43(-2);
			<AnimationsIter>d__.<>3__<>4__this = this;
			return <AnimationsIter>d__;
		}

		// Token: 0x06005D65 RID: 23909 RVA: 0x0021AD5E File Offset: 0x00218F5E
		[NullableContext(1)]
		public string[] Audios()
		{
			return this.AudiosIter().ToArray<string>();
		}

		// Token: 0x06005D66 RID: 23910 RVA: 0x0021AD6B File Offset: 0x00218F6B
		[NullableContext(1)]
		public IEnumerable<string> AudiosIter()
		{
			CommonSkillPreload.<AudiosIter>d__45 <AudiosIter>d__ = new CommonSkillPreload.<AudiosIter>d__45(-2);
			<AudiosIter>d__.<>3__<>4__this = this;
			return <AudiosIter>d__;
		}

		// Token: 0x06005D67 RID: 23911 RVA: 0x0021AD80 File Offset: 0x00218F80
		[NullableContext(1)]
		public string[] Effects()
		{
			return this.EffectsIter().ToArray<string>();
		}

		// Token: 0x06005D68 RID: 23912 RVA: 0x0021AD8D File Offset: 0x00218F8D
		[NullableContext(1)]
		public IEnumerable<string> EffectsIter()
		{
			CommonSkillPreload.<EffectsIter>d__47 <EffectsIter>d__ = new CommonSkillPreload.<EffectsIter>d__47(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x06005D69 RID: 23913 RVA: 0x0021ADA2 File Offset: 0x00218FA2
		[NullableContext(1)]
		public string[] Materials()
		{
			return this.MaterialsIter().ToArray<string>();
		}

		// Token: 0x06005D6A RID: 23914 RVA: 0x0021ADAF File Offset: 0x00218FAF
		[NullableContext(1)]
		public IEnumerable<string> MaterialsIter()
		{
			CommonSkillPreload.<MaterialsIter>d__49 <MaterialsIter>d__ = new CommonSkillPreload.<MaterialsIter>d__49(-2);
			<MaterialsIter>d__.<>3__<>4__this = this;
			return <MaterialsIter>d__;
		}

		// Token: 0x06005D6B RID: 23915 RVA: 0x0021ADC4 File Offset: 0x00218FC4
		[NullableContext(1)]
		public string[] Meshes()
		{
			return this.MeshesIter().ToArray<string>();
		}

		// Token: 0x06005D6C RID: 23916 RVA: 0x0021ADD1 File Offset: 0x00218FD1
		[NullableContext(1)]
		public IEnumerable<string> MeshesIter()
		{
			CommonSkillPreload.<MeshesIter>d__51 <MeshesIter>d__ = new CommonSkillPreload.<MeshesIter>d__51(-2);
			<MeshesIter>d__.<>3__<>4__this = this;
			return <MeshesIter>d__;
		}

		// Token: 0x06005D6D RID: 23917 RVA: 0x0021ADE6 File Offset: 0x00218FE6
		[NullableContext(1)]
		public string[] Others()
		{
			return this.OthersIter().ToArray<string>();
		}

		// Token: 0x06005D6E RID: 23918 RVA: 0x0021ADF3 File Offset: 0x00218FF3
		[NullableContext(1)]
		public IEnumerable<string> OthersIter()
		{
			CommonSkillPreload.<OthersIter>d__53 <OthersIter>d__ = new CommonSkillPreload.<OthersIter>d__53(-2);
			<OthersIter>d__.<>3__<>4__this = this;
			return <OthersIter>d__;
		}

		// Token: 0x0400517F RID: 20863
		private Table __p;
	}
}
