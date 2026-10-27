using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B5A RID: 2906
	public struct BulletPreload : IFlatbufferObject
	{
		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06005166 RID: 20838 RVA: 0x001ECF49 File Offset: 0x001EB149
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005167 RID: 20839 RVA: 0x001ECF56 File Offset: 0x001EB156
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005168 RID: 20840 RVA: 0x001ECF60 File Offset: 0x001EB160
		public static BulletPreload GetRootAsBulletPreload(ByteBuffer _bb)
		{
			return BulletPreload.GetRootAsBulletPreload(_bb, default(BulletPreload));
		}

		// Token: 0x06005169 RID: 20841 RVA: 0x001ECF7C File Offset: 0x001EB17C
		public static BulletPreload GetRootAsBulletPreload(ByteBuffer _bb, BulletPreload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600516A RID: 20842 RVA: 0x001ECF99 File Offset: 0x001EB199
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600516B RID: 20843 RVA: 0x001ECFA8 File Offset: 0x001EB1A8
		public BulletPreload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x0600516C RID: 20844 RVA: 0x001ECFB8 File Offset: 0x001EB1B8
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

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x0600516D RID: 20845 RVA: 0x001ECFF4 File Offset: 0x001EB1F4
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

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x0600516E RID: 20846 RVA: 0x001ED034 File Offset: 0x001EB234
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

		// Token: 0x0600516F RID: 20847 RVA: 0x001ED06B File Offset: 0x001EB26B
		public Span<byte> GetActorBlueprintBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005170 RID: 20848 RVA: 0x001ED07A File Offset: 0x001EB27A
		public byte[] GetActorBlueprintArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06005171 RID: 20849 RVA: 0x001ED094 File Offset: 0x001EB294
		public string ActorClass(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06005172 RID: 20850 RVA: 0x001ED0D0 File Offset: 0x001EB2D0
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

		// Token: 0x06005173 RID: 20851 RVA: 0x001ED0FC File Offset: 0x001EB2FC
		public string Animations(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06005174 RID: 20852 RVA: 0x001ED138 File Offset: 0x001EB338
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

		// Token: 0x06005175 RID: 20853 RVA: 0x001ED164 File Offset: 0x001EB364
		public string Effects(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06005176 RID: 20854 RVA: 0x001ED1A0 File Offset: 0x001EB3A0
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

		// Token: 0x06005177 RID: 20855 RVA: 0x001ED1CC File Offset: 0x001EB3CC
		public string Audios(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06005178 RID: 20856 RVA: 0x001ED208 File Offset: 0x001EB408
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

		// Token: 0x06005179 RID: 20857 RVA: 0x001ED234 File Offset: 0x001EB434
		public string Meshes(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x0600517A RID: 20858 RVA: 0x001ED270 File Offset: 0x001EB470
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

		// Token: 0x0600517B RID: 20859 RVA: 0x001ED29C File Offset: 0x001EB49C
		public string Materials(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600517C RID: 20860 RVA: 0x001ED2D8 File Offset: 0x001EB4D8
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

		// Token: 0x0600517D RID: 20861 RVA: 0x001ED304 File Offset: 0x001EB504
		public string AnimationBlueprints(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600517E RID: 20862 RVA: 0x001ED340 File Offset: 0x001EB540
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

		// Token: 0x0600517F RID: 20863 RVA: 0x001ED36C File Offset: 0x001EB56C
		public string Others(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06005180 RID: 20864 RVA: 0x001ED3A8 File Offset: 0x001EB5A8
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

		// Token: 0x06005181 RID: 20865 RVA: 0x001ED3D4 File Offset: 0x001EB5D4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ActorClassIter()或GetActorClassBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ActorClass()
		{
			return this.ActorClassIter().ToArray<string>();
		}

		// Token: 0x06005182 RID: 20866 RVA: 0x001ED3E1 File Offset: 0x001EB5E1
		[NullableContext(1)]
		public readonly IEnumerable<string> ActorClassIter()
		{
			BulletPreload.<ActorClassIter>d__41 <ActorClassIter>d__ = new BulletPreload.<ActorClassIter>d__41(-2);
			<ActorClassIter>d__.<>3__<>4__this = this;
			return <ActorClassIter>d__;
		}

		// Token: 0x06005183 RID: 20867 RVA: 0x001ED3F6 File Offset: 0x001EB5F6
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AnimationBlueprintsIter()或GetAnimationBlueprintsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AnimationBlueprints()
		{
			return this.AnimationBlueprintsIter().ToArray<string>();
		}

		// Token: 0x06005184 RID: 20868 RVA: 0x001ED403 File Offset: 0x001EB603
		[NullableContext(1)]
		public readonly IEnumerable<string> AnimationBlueprintsIter()
		{
			BulletPreload.<AnimationBlueprintsIter>d__43 <AnimationBlueprintsIter>d__ = new BulletPreload.<AnimationBlueprintsIter>d__43(-2);
			<AnimationBlueprintsIter>d__.<>3__<>4__this = this;
			return <AnimationBlueprintsIter>d__;
		}

		// Token: 0x06005185 RID: 20869 RVA: 0x001ED418 File Offset: 0x001EB618
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AnimationsIter()或GetAnimationsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Animations()
		{
			return this.AnimationsIter().ToArray<string>();
		}

		// Token: 0x06005186 RID: 20870 RVA: 0x001ED425 File Offset: 0x001EB625
		[NullableContext(1)]
		public readonly IEnumerable<string> AnimationsIter()
		{
			BulletPreload.<AnimationsIter>d__45 <AnimationsIter>d__ = new BulletPreload.<AnimationsIter>d__45(-2);
			<AnimationsIter>d__.<>3__<>4__this = this;
			return <AnimationsIter>d__;
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x001ED43A File Offset: 0x001EB63A
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AudiosIter()或GetAudiosBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Audios()
		{
			return this.AudiosIter().ToArray<string>();
		}

		// Token: 0x06005188 RID: 20872 RVA: 0x001ED447 File Offset: 0x001EB647
		[NullableContext(1)]
		public readonly IEnumerable<string> AudiosIter()
		{
			BulletPreload.<AudiosIter>d__47 <AudiosIter>d__ = new BulletPreload.<AudiosIter>d__47(-2);
			<AudiosIter>d__.<>3__<>4__this = this;
			return <AudiosIter>d__;
		}

		// Token: 0x06005189 RID: 20873 RVA: 0x001ED45C File Offset: 0x001EB65C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectsIter()或GetEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Effects()
		{
			return this.EffectsIter().ToArray<string>();
		}

		// Token: 0x0600518A RID: 20874 RVA: 0x001ED469 File Offset: 0x001EB669
		[NullableContext(1)]
		public readonly IEnumerable<string> EffectsIter()
		{
			BulletPreload.<EffectsIter>d__49 <EffectsIter>d__ = new BulletPreload.<EffectsIter>d__49(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x0600518B RID: 20875 RVA: 0x001ED47E File Offset: 0x001EB67E
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MaterialsIter()或GetMaterialsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Materials()
		{
			return this.MaterialsIter().ToArray<string>();
		}

		// Token: 0x0600518C RID: 20876 RVA: 0x001ED48B File Offset: 0x001EB68B
		[NullableContext(1)]
		public readonly IEnumerable<string> MaterialsIter()
		{
			BulletPreload.<MaterialsIter>d__51 <MaterialsIter>d__ = new BulletPreload.<MaterialsIter>d__51(-2);
			<MaterialsIter>d__.<>3__<>4__this = this;
			return <MaterialsIter>d__;
		}

		// Token: 0x0600518D RID: 20877 RVA: 0x001ED4A0 File Offset: 0x001EB6A0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MeshesIter()或GetMeshesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Meshes()
		{
			return this.MeshesIter().ToArray<string>();
		}

		// Token: 0x0600518E RID: 20878 RVA: 0x001ED4AD File Offset: 0x001EB6AD
		[NullableContext(1)]
		public readonly IEnumerable<string> MeshesIter()
		{
			BulletPreload.<MeshesIter>d__53 <MeshesIter>d__ = new BulletPreload.<MeshesIter>d__53(-2);
			<MeshesIter>d__.<>3__<>4__this = this;
			return <MeshesIter>d__;
		}

		// Token: 0x0600518F RID: 20879 RVA: 0x001ED4C2 File Offset: 0x001EB6C2
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OthersIter()或GetOthersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Others()
		{
			return this.OthersIter().ToArray<string>();
		}

		// Token: 0x06005190 RID: 20880 RVA: 0x001ED4CF File Offset: 0x001EB6CF
		[NullableContext(1)]
		public readonly IEnumerable<string> OthersIter()
		{
			BulletPreload.<OthersIter>d__55 <OthersIter>d__ = new BulletPreload.<OthersIter>d__55(-2);
			<OthersIter>d__.<>3__<>4__this = this;
			return <OthersIter>d__;
		}

		// Token: 0x04004B57 RID: 19287
		private Table __p;
	}
}
