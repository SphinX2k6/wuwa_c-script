using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C3A RID: 3130
	public struct BulletPreload : IFlatbufferObject
	{
		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06005728 RID: 22312 RVA: 0x0020CD75 File Offset: 0x0020AF75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005729 RID: 22313 RVA: 0x0020CD82 File Offset: 0x0020AF82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600572A RID: 22314 RVA: 0x0020CD8C File Offset: 0x0020AF8C
		public static BulletPreload GetRootAsBulletPreload(ByteBuffer _bb)
		{
			return BulletPreload.GetRootAsBulletPreload(_bb, default(BulletPreload));
		}

		// Token: 0x0600572B RID: 22315 RVA: 0x0020CDA8 File Offset: 0x0020AFA8
		public static BulletPreload GetRootAsBulletPreload(ByteBuffer _bb, BulletPreload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600572C RID: 22316 RVA: 0x0020CDC5 File Offset: 0x0020AFC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600572D RID: 22317 RVA: 0x0020CDD4 File Offset: 0x0020AFD4
		public BulletPreload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x0600572E RID: 22318 RVA: 0x0020CDE4 File Offset: 0x0020AFE4
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

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x0600572F RID: 22319 RVA: 0x0020CE20 File Offset: 0x0020B020
		public long BulletId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06005730 RID: 22320 RVA: 0x0020CE60 File Offset: 0x0020B060
		public string ActorBlueprint
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005731 RID: 22321 RVA: 0x0020CE97 File Offset: 0x0020B097
		public Span<byte> GetActorBlueprintBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005732 RID: 22322 RVA: 0x0020CEA6 File Offset: 0x0020B0A6
		public byte[] GetActorBlueprintArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06005733 RID: 22323 RVA: 0x0020CEC0 File Offset: 0x0020B0C0
		public string ActorClass(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06005734 RID: 22324 RVA: 0x0020CEFC File Offset: 0x0020B0FC
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

		// Token: 0x06005735 RID: 22325 RVA: 0x0020CF28 File Offset: 0x0020B128
		public string Animations(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06005736 RID: 22326 RVA: 0x0020CF64 File Offset: 0x0020B164
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

		// Token: 0x06005737 RID: 22327 RVA: 0x0020CF90 File Offset: 0x0020B190
		public string Effects(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06005738 RID: 22328 RVA: 0x0020CFCC File Offset: 0x0020B1CC
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

		// Token: 0x06005739 RID: 22329 RVA: 0x0020CFF8 File Offset: 0x0020B1F8
		public string Audios(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x0600573A RID: 22330 RVA: 0x0020D034 File Offset: 0x0020B234
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

		// Token: 0x0600573B RID: 22331 RVA: 0x0020D060 File Offset: 0x0020B260
		public string Meshes(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x0600573C RID: 22332 RVA: 0x0020D09C File Offset: 0x0020B29C
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

		// Token: 0x0600573D RID: 22333 RVA: 0x0020D0C8 File Offset: 0x0020B2C8
		public string Materials(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600573E RID: 22334 RVA: 0x0020D104 File Offset: 0x0020B304
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

		// Token: 0x0600573F RID: 22335 RVA: 0x0020D130 File Offset: 0x0020B330
		public string AnimationBlueprints(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06005740 RID: 22336 RVA: 0x0020D16C File Offset: 0x0020B36C
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

		// Token: 0x06005741 RID: 22337 RVA: 0x0020D198 File Offset: 0x0020B398
		public string Others(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06005742 RID: 22338 RVA: 0x0020D1D4 File Offset: 0x0020B3D4
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

		// Token: 0x06005743 RID: 22339 RVA: 0x0020D200 File Offset: 0x0020B400
		[NullableContext(1)]
		public string[] ActorClass()
		{
			return this.ActorClassIter().ToArray<string>();
		}

		// Token: 0x06005744 RID: 22340 RVA: 0x0020D20D File Offset: 0x0020B40D
		[NullableContext(1)]
		public IEnumerable<string> ActorClassIter()
		{
			BulletPreload.<ActorClassIter>d__41 <ActorClassIter>d__ = new BulletPreload.<ActorClassIter>d__41(-2);
			<ActorClassIter>d__.<>3__<>4__this = this;
			return <ActorClassIter>d__;
		}

		// Token: 0x06005745 RID: 22341 RVA: 0x0020D222 File Offset: 0x0020B422
		[NullableContext(1)]
		public string[] AnimationBlueprints()
		{
			return this.AnimationBlueprintsIter().ToArray<string>();
		}

		// Token: 0x06005746 RID: 22342 RVA: 0x0020D22F File Offset: 0x0020B42F
		[NullableContext(1)]
		public IEnumerable<string> AnimationBlueprintsIter()
		{
			BulletPreload.<AnimationBlueprintsIter>d__43 <AnimationBlueprintsIter>d__ = new BulletPreload.<AnimationBlueprintsIter>d__43(-2);
			<AnimationBlueprintsIter>d__.<>3__<>4__this = this;
			return <AnimationBlueprintsIter>d__;
		}

		// Token: 0x06005747 RID: 22343 RVA: 0x0020D244 File Offset: 0x0020B444
		[NullableContext(1)]
		public string[] Animations()
		{
			return this.AnimationsIter().ToArray<string>();
		}

		// Token: 0x06005748 RID: 22344 RVA: 0x0020D251 File Offset: 0x0020B451
		[NullableContext(1)]
		public IEnumerable<string> AnimationsIter()
		{
			BulletPreload.<AnimationsIter>d__45 <AnimationsIter>d__ = new BulletPreload.<AnimationsIter>d__45(-2);
			<AnimationsIter>d__.<>3__<>4__this = this;
			return <AnimationsIter>d__;
		}

		// Token: 0x06005749 RID: 22345 RVA: 0x0020D266 File Offset: 0x0020B466
		[NullableContext(1)]
		public string[] Audios()
		{
			return this.AudiosIter().ToArray<string>();
		}

		// Token: 0x0600574A RID: 22346 RVA: 0x0020D273 File Offset: 0x0020B473
		[NullableContext(1)]
		public IEnumerable<string> AudiosIter()
		{
			BulletPreload.<AudiosIter>d__47 <AudiosIter>d__ = new BulletPreload.<AudiosIter>d__47(-2);
			<AudiosIter>d__.<>3__<>4__this = this;
			return <AudiosIter>d__;
		}

		// Token: 0x0600574B RID: 22347 RVA: 0x0020D288 File Offset: 0x0020B488
		[NullableContext(1)]
		public string[] Effects()
		{
			return this.EffectsIter().ToArray<string>();
		}

		// Token: 0x0600574C RID: 22348 RVA: 0x0020D295 File Offset: 0x0020B495
		[NullableContext(1)]
		public IEnumerable<string> EffectsIter()
		{
			BulletPreload.<EffectsIter>d__49 <EffectsIter>d__ = new BulletPreload.<EffectsIter>d__49(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x0600574D RID: 22349 RVA: 0x0020D2AA File Offset: 0x0020B4AA
		[NullableContext(1)]
		public string[] Materials()
		{
			return this.MaterialsIter().ToArray<string>();
		}

		// Token: 0x0600574E RID: 22350 RVA: 0x0020D2B7 File Offset: 0x0020B4B7
		[NullableContext(1)]
		public IEnumerable<string> MaterialsIter()
		{
			BulletPreload.<MaterialsIter>d__51 <MaterialsIter>d__ = new BulletPreload.<MaterialsIter>d__51(-2);
			<MaterialsIter>d__.<>3__<>4__this = this;
			return <MaterialsIter>d__;
		}

		// Token: 0x0600574F RID: 22351 RVA: 0x0020D2CC File Offset: 0x0020B4CC
		[NullableContext(1)]
		public string[] Meshes()
		{
			return this.MeshesIter().ToArray<string>();
		}

		// Token: 0x06005750 RID: 22352 RVA: 0x0020D2D9 File Offset: 0x0020B4D9
		[NullableContext(1)]
		public IEnumerable<string> MeshesIter()
		{
			BulletPreload.<MeshesIter>d__53 <MeshesIter>d__ = new BulletPreload.<MeshesIter>d__53(-2);
			<MeshesIter>d__.<>3__<>4__this = this;
			return <MeshesIter>d__;
		}

		// Token: 0x06005751 RID: 22353 RVA: 0x0020D2EE File Offset: 0x0020B4EE
		[NullableContext(1)]
		public string[] Others()
		{
			return this.OthersIter().ToArray<string>();
		}

		// Token: 0x06005752 RID: 22354 RVA: 0x0020D2FB File Offset: 0x0020B4FB
		[NullableContext(1)]
		public IEnumerable<string> OthersIter()
		{
			BulletPreload.<OthersIter>d__55 <OthersIter>d__ = new BulletPreload.<OthersIter>d__55(-2);
			<OthersIter>d__.<>3__<>4__this = this;
			return <OthersIter>d__;
		}

		// Token: 0x04005137 RID: 20791
		private Table __p;
	}
}
