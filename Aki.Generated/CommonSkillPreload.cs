using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B8E RID: 2958
	public struct CommonSkillPreload : IFlatbufferObject
	{
		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x0600576D RID: 22381 RVA: 0x001FAA98 File Offset: 0x001F8C98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600576E RID: 22382 RVA: 0x001FAAA5 File Offset: 0x001F8CA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600576F RID: 22383 RVA: 0x001FAAAC File Offset: 0x001F8CAC
		public static CommonSkillPreload GetRootAsCommonSkillPreload(ByteBuffer _bb)
		{
			return CommonSkillPreload.GetRootAsCommonSkillPreload(_bb, default(CommonSkillPreload));
		}

		// Token: 0x06005770 RID: 22384 RVA: 0x001FAAC8 File Offset: 0x001F8CC8
		public static CommonSkillPreload GetRootAsCommonSkillPreload(ByteBuffer _bb, CommonSkillPreload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005771 RID: 22385 RVA: 0x001FAAE5 File Offset: 0x001F8CE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005772 RID: 22386 RVA: 0x001FAAF4 File Offset: 0x001F8CF4
		public CommonSkillPreload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06005773 RID: 22387 RVA: 0x001FAB04 File Offset: 0x001F8D04
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

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06005774 RID: 22388 RVA: 0x001FAB40 File Offset: 0x001F8D40
		public bool IsCommon
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06005775 RID: 22389 RVA: 0x001FAB80 File Offset: 0x001F8D80
		public bool HasMontagePath
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06005776 RID: 22390 RVA: 0x001FABC0 File Offset: 0x001F8DC0
		public string ActorClass(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06005777 RID: 22391 RVA: 0x001FABFC File Offset: 0x001F8DFC
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

		// Token: 0x06005778 RID: 22392 RVA: 0x001FAC28 File Offset: 0x001F8E28
		public string Animations(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06005779 RID: 22393 RVA: 0x001FAC64 File Offset: 0x001F8E64
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

		// Token: 0x0600577A RID: 22394 RVA: 0x001FAC90 File Offset: 0x001F8E90
		public string Effects(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x0600577B RID: 22395 RVA: 0x001FACCC File Offset: 0x001F8ECC
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

		// Token: 0x0600577C RID: 22396 RVA: 0x001FACF8 File Offset: 0x001F8EF8
		public string Audios(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x0600577D RID: 22397 RVA: 0x001FAD34 File Offset: 0x001F8F34
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

		// Token: 0x0600577E RID: 22398 RVA: 0x001FAD60 File Offset: 0x001F8F60
		public string Meshes(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x0600577F RID: 22399 RVA: 0x001FAD9C File Offset: 0x001F8F9C
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

		// Token: 0x06005780 RID: 22400 RVA: 0x001FADC8 File Offset: 0x001F8FC8
		public string Materials(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06005781 RID: 22401 RVA: 0x001FAE04 File Offset: 0x001F9004
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

		// Token: 0x06005782 RID: 22402 RVA: 0x001FAE30 File Offset: 0x001F9030
		public string AnimationBlueprints(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06005783 RID: 22403 RVA: 0x001FAE6C File Offset: 0x001F906C
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

		// Token: 0x06005784 RID: 22404 RVA: 0x001FAE98 File Offset: 0x001F9098
		public string Others(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06005785 RID: 22405 RVA: 0x001FAED4 File Offset: 0x001F90D4
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

		// Token: 0x06005786 RID: 22406 RVA: 0x001FAF00 File Offset: 0x001F9100
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ActorClassIter()或GetActorClassBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ActorClass()
		{
			return this.ActorClassIter().ToArray<string>();
		}

		// Token: 0x06005787 RID: 22407 RVA: 0x001FAF0D File Offset: 0x001F910D
		[NullableContext(1)]
		public readonly IEnumerable<string> ActorClassIter()
		{
			CommonSkillPreload.<ActorClassIter>d__39 <ActorClassIter>d__ = new CommonSkillPreload.<ActorClassIter>d__39(-2);
			<ActorClassIter>d__.<>3__<>4__this = this;
			return <ActorClassIter>d__;
		}

		// Token: 0x06005788 RID: 22408 RVA: 0x001FAF22 File Offset: 0x001F9122
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AnimationBlueprintsIter()或GetAnimationBlueprintsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AnimationBlueprints()
		{
			return this.AnimationBlueprintsIter().ToArray<string>();
		}

		// Token: 0x06005789 RID: 22409 RVA: 0x001FAF2F File Offset: 0x001F912F
		[NullableContext(1)]
		public readonly IEnumerable<string> AnimationBlueprintsIter()
		{
			CommonSkillPreload.<AnimationBlueprintsIter>d__41 <AnimationBlueprintsIter>d__ = new CommonSkillPreload.<AnimationBlueprintsIter>d__41(-2);
			<AnimationBlueprintsIter>d__.<>3__<>4__this = this;
			return <AnimationBlueprintsIter>d__;
		}

		// Token: 0x0600578A RID: 22410 RVA: 0x001FAF44 File Offset: 0x001F9144
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AnimationsIter()或GetAnimationsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Animations()
		{
			return this.AnimationsIter().ToArray<string>();
		}

		// Token: 0x0600578B RID: 22411 RVA: 0x001FAF51 File Offset: 0x001F9151
		[NullableContext(1)]
		public readonly IEnumerable<string> AnimationsIter()
		{
			CommonSkillPreload.<AnimationsIter>d__43 <AnimationsIter>d__ = new CommonSkillPreload.<AnimationsIter>d__43(-2);
			<AnimationsIter>d__.<>3__<>4__this = this;
			return <AnimationsIter>d__;
		}

		// Token: 0x0600578C RID: 22412 RVA: 0x001FAF66 File Offset: 0x001F9166
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AudiosIter()或GetAudiosBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Audios()
		{
			return this.AudiosIter().ToArray<string>();
		}

		// Token: 0x0600578D RID: 22413 RVA: 0x001FAF73 File Offset: 0x001F9173
		[NullableContext(1)]
		public readonly IEnumerable<string> AudiosIter()
		{
			CommonSkillPreload.<AudiosIter>d__45 <AudiosIter>d__ = new CommonSkillPreload.<AudiosIter>d__45(-2);
			<AudiosIter>d__.<>3__<>4__this = this;
			return <AudiosIter>d__;
		}

		// Token: 0x0600578E RID: 22414 RVA: 0x001FAF88 File Offset: 0x001F9188
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectsIter()或GetEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Effects()
		{
			return this.EffectsIter().ToArray<string>();
		}

		// Token: 0x0600578F RID: 22415 RVA: 0x001FAF95 File Offset: 0x001F9195
		[NullableContext(1)]
		public readonly IEnumerable<string> EffectsIter()
		{
			CommonSkillPreload.<EffectsIter>d__47 <EffectsIter>d__ = new CommonSkillPreload.<EffectsIter>d__47(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x06005790 RID: 22416 RVA: 0x001FAFAA File Offset: 0x001F91AA
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MaterialsIter()或GetMaterialsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Materials()
		{
			return this.MaterialsIter().ToArray<string>();
		}

		// Token: 0x06005791 RID: 22417 RVA: 0x001FAFB7 File Offset: 0x001F91B7
		[NullableContext(1)]
		public readonly IEnumerable<string> MaterialsIter()
		{
			CommonSkillPreload.<MaterialsIter>d__49 <MaterialsIter>d__ = new CommonSkillPreload.<MaterialsIter>d__49(-2);
			<MaterialsIter>d__.<>3__<>4__this = this;
			return <MaterialsIter>d__;
		}

		// Token: 0x06005792 RID: 22418 RVA: 0x001FAFCC File Offset: 0x001F91CC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MeshesIter()或GetMeshesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Meshes()
		{
			return this.MeshesIter().ToArray<string>();
		}

		// Token: 0x06005793 RID: 22419 RVA: 0x001FAFD9 File Offset: 0x001F91D9
		[NullableContext(1)]
		public readonly IEnumerable<string> MeshesIter()
		{
			CommonSkillPreload.<MeshesIter>d__51 <MeshesIter>d__ = new CommonSkillPreload.<MeshesIter>d__51(-2);
			<MeshesIter>d__.<>3__<>4__this = this;
			return <MeshesIter>d__;
		}

		// Token: 0x06005794 RID: 22420 RVA: 0x001FAFEE File Offset: 0x001F91EE
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OthersIter()或GetOthersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Others()
		{
			return this.OthersIter().ToArray<string>();
		}

		// Token: 0x06005795 RID: 22421 RVA: 0x001FAFFB File Offset: 0x001F91FB
		[NullableContext(1)]
		public readonly IEnumerable<string> OthersIter()
		{
			CommonSkillPreload.<OthersIter>d__53 <OthersIter>d__ = new CommonSkillPreload.<OthersIter>d__53(-2);
			<OthersIter>d__.<>3__<>4__this = this;
			return <OthersIter>d__;
		}

		// Token: 0x04004B9D RID: 19357
		private Table __p;
	}
}
