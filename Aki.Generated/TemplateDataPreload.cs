using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200111E RID: 4382
	public struct TemplateDataPreload : IFlatbufferObject
	{
		// Token: 0x170039F9 RID: 14841
		// (get) Token: 0x0600DD7C RID: 56700 RVA: 0x0032AE00 File Offset: 0x00329000
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DD7D RID: 56701 RVA: 0x0032AE0D File Offset: 0x0032900D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DD7E RID: 56702 RVA: 0x0032AE14 File Offset: 0x00329014
		public static TemplateDataPreload GetRootAsTemplateDataPreload(ByteBuffer _bb)
		{
			return TemplateDataPreload.GetRootAsTemplateDataPreload(_bb, default(TemplateDataPreload));
		}

		// Token: 0x0600DD7F RID: 56703 RVA: 0x0032AE30 File Offset: 0x00329030
		public static TemplateDataPreload GetRootAsTemplateDataPreload(ByteBuffer _bb, TemplateDataPreload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DD80 RID: 56704 RVA: 0x0032AE4D File Offset: 0x0032904D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DD81 RID: 56705 RVA: 0x0032AE5C File Offset: 0x0032905C
		public TemplateDataPreload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039FA RID: 14842
		// (get) Token: 0x0600DD82 RID: 56706 RVA: 0x0032AE6C File Offset: 0x0032906C
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

		// Token: 0x0600DD83 RID: 56707 RVA: 0x0032AEA8 File Offset: 0x003290A8
		public string ActorClass(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170039FB RID: 14843
		// (get) Token: 0x0600DD84 RID: 56708 RVA: 0x0032AEE4 File Offset: 0x003290E4
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

		// Token: 0x0600DD85 RID: 56709 RVA: 0x0032AF10 File Offset: 0x00329110
		public string Animations(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170039FC RID: 14844
		// (get) Token: 0x0600DD86 RID: 56710 RVA: 0x0032AF4C File Offset: 0x0032914C
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

		// Token: 0x0600DD87 RID: 56711 RVA: 0x0032AF78 File Offset: 0x00329178
		public string Effects(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170039FD RID: 14845
		// (get) Token: 0x0600DD88 RID: 56712 RVA: 0x0032AFB4 File Offset: 0x003291B4
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

		// Token: 0x0600DD89 RID: 56713 RVA: 0x0032AFE0 File Offset: 0x003291E0
		public string Audios(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170039FE RID: 14846
		// (get) Token: 0x0600DD8A RID: 56714 RVA: 0x0032B01C File Offset: 0x0032921C
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

		// Token: 0x0600DD8B RID: 56715 RVA: 0x0032B048 File Offset: 0x00329248
		public string Meshes(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170039FF RID: 14847
		// (get) Token: 0x0600DD8C RID: 56716 RVA: 0x0032B084 File Offset: 0x00329284
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

		// Token: 0x0600DD8D RID: 56717 RVA: 0x0032B0B0 File Offset: 0x003292B0
		public string Materials(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A00 RID: 14848
		// (get) Token: 0x0600DD8E RID: 56718 RVA: 0x0032B0EC File Offset: 0x003292EC
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

		// Token: 0x0600DD8F RID: 56719 RVA: 0x0032B118 File Offset: 0x00329318
		public string AnimationBlueprints(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A01 RID: 14849
		// (get) Token: 0x0600DD90 RID: 56720 RVA: 0x0032B154 File Offset: 0x00329354
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

		// Token: 0x0600DD91 RID: 56721 RVA: 0x0032B180 File Offset: 0x00329380
		public string Others(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A02 RID: 14850
		// (get) Token: 0x0600DD92 RID: 56722 RVA: 0x0032B1BC File Offset: 0x003293BC
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

		// Token: 0x0600DD93 RID: 56723 RVA: 0x0032B1E8 File Offset: 0x003293E8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ActorClassIter()或GetActorClassBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ActorClass()
		{
			return this.ActorClassIter().ToArray<string>();
		}

		// Token: 0x0600DD94 RID: 56724 RVA: 0x0032B1F5 File Offset: 0x003293F5
		[NullableContext(1)]
		public readonly IEnumerable<string> ActorClassIter()
		{
			TemplateDataPreload.<ActorClassIter>d__35 <ActorClassIter>d__ = new TemplateDataPreload.<ActorClassIter>d__35(-2);
			<ActorClassIter>d__.<>3__<>4__this = this;
			return <ActorClassIter>d__;
		}

		// Token: 0x0600DD95 RID: 56725 RVA: 0x0032B20A File Offset: 0x0032940A
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AnimationBlueprintsIter()或GetAnimationBlueprintsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AnimationBlueprints()
		{
			return this.AnimationBlueprintsIter().ToArray<string>();
		}

		// Token: 0x0600DD96 RID: 56726 RVA: 0x0032B217 File Offset: 0x00329417
		[NullableContext(1)]
		public readonly IEnumerable<string> AnimationBlueprintsIter()
		{
			TemplateDataPreload.<AnimationBlueprintsIter>d__37 <AnimationBlueprintsIter>d__ = new TemplateDataPreload.<AnimationBlueprintsIter>d__37(-2);
			<AnimationBlueprintsIter>d__.<>3__<>4__this = this;
			return <AnimationBlueprintsIter>d__;
		}

		// Token: 0x0600DD97 RID: 56727 RVA: 0x0032B22C File Offset: 0x0032942C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AnimationsIter()或GetAnimationsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Animations()
		{
			return this.AnimationsIter().ToArray<string>();
		}

		// Token: 0x0600DD98 RID: 56728 RVA: 0x0032B239 File Offset: 0x00329439
		[NullableContext(1)]
		public readonly IEnumerable<string> AnimationsIter()
		{
			TemplateDataPreload.<AnimationsIter>d__39 <AnimationsIter>d__ = new TemplateDataPreload.<AnimationsIter>d__39(-2);
			<AnimationsIter>d__.<>3__<>4__this = this;
			return <AnimationsIter>d__;
		}

		// Token: 0x0600DD99 RID: 56729 RVA: 0x0032B24E File Offset: 0x0032944E
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AudiosIter()或GetAudiosBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Audios()
		{
			return this.AudiosIter().ToArray<string>();
		}

		// Token: 0x0600DD9A RID: 56730 RVA: 0x0032B25B File Offset: 0x0032945B
		[NullableContext(1)]
		public readonly IEnumerable<string> AudiosIter()
		{
			TemplateDataPreload.<AudiosIter>d__41 <AudiosIter>d__ = new TemplateDataPreload.<AudiosIter>d__41(-2);
			<AudiosIter>d__.<>3__<>4__this = this;
			return <AudiosIter>d__;
		}

		// Token: 0x0600DD9B RID: 56731 RVA: 0x0032B270 File Offset: 0x00329470
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectsIter()或GetEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Effects()
		{
			return this.EffectsIter().ToArray<string>();
		}

		// Token: 0x0600DD9C RID: 56732 RVA: 0x0032B27D File Offset: 0x0032947D
		[NullableContext(1)]
		public readonly IEnumerable<string> EffectsIter()
		{
			TemplateDataPreload.<EffectsIter>d__43 <EffectsIter>d__ = new TemplateDataPreload.<EffectsIter>d__43(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x0600DD9D RID: 56733 RVA: 0x0032B292 File Offset: 0x00329492
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MaterialsIter()或GetMaterialsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Materials()
		{
			return this.MaterialsIter().ToArray<string>();
		}

		// Token: 0x0600DD9E RID: 56734 RVA: 0x0032B29F File Offset: 0x0032949F
		[NullableContext(1)]
		public readonly IEnumerable<string> MaterialsIter()
		{
			TemplateDataPreload.<MaterialsIter>d__45 <MaterialsIter>d__ = new TemplateDataPreload.<MaterialsIter>d__45(-2);
			<MaterialsIter>d__.<>3__<>4__this = this;
			return <MaterialsIter>d__;
		}

		// Token: 0x0600DD9F RID: 56735 RVA: 0x0032B2B4 File Offset: 0x003294B4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MeshesIter()或GetMeshesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Meshes()
		{
			return this.MeshesIter().ToArray<string>();
		}

		// Token: 0x0600DDA0 RID: 56736 RVA: 0x0032B2C1 File Offset: 0x003294C1
		[NullableContext(1)]
		public readonly IEnumerable<string> MeshesIter()
		{
			TemplateDataPreload.<MeshesIter>d__47 <MeshesIter>d__ = new TemplateDataPreload.<MeshesIter>d__47(-2);
			<MeshesIter>d__.<>3__<>4__this = this;
			return <MeshesIter>d__;
		}

		// Token: 0x0600DDA1 RID: 56737 RVA: 0x0032B2D6 File Offset: 0x003294D6
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OthersIter()或GetOthersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Others()
		{
			return this.OthersIter().ToArray<string>();
		}

		// Token: 0x0600DDA2 RID: 56738 RVA: 0x0032B2E3 File Offset: 0x003294E3
		[NullableContext(1)]
		public readonly IEnumerable<string> OthersIter()
		{
			TemplateDataPreload.<OthersIter>d__49 <OthersIter>d__ = new TemplateDataPreload.<OthersIter>d__49(-2);
			<OthersIter>d__.<>3__<>4__this = this;
			return <OthersIter>d__;
		}

		// Token: 0x0400525B RID: 21083
		private Table __p;
	}
}
