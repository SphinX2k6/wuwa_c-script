using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E0D RID: 3597
	public struct ModelConfigPreload : IFlatbufferObject
	{
		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x06009446 RID: 37958 RVA: 0x00285E19 File Offset: 0x00284019
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009447 RID: 37959 RVA: 0x00285E26 File Offset: 0x00284026
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009448 RID: 37960 RVA: 0x00285E30 File Offset: 0x00284030
		public static ModelConfigPreload GetRootAsModelConfigPreload(ByteBuffer _bb)
		{
			return ModelConfigPreload.GetRootAsModelConfigPreload(_bb, default(ModelConfigPreload));
		}

		// Token: 0x06009449 RID: 37961 RVA: 0x00285E4C File Offset: 0x0028404C
		public static ModelConfigPreload GetRootAsModelConfigPreload(ByteBuffer _bb, ModelConfigPreload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600944A RID: 37962 RVA: 0x00285E69 File Offset: 0x00284069
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600944B RID: 37963 RVA: 0x00285E78 File Offset: 0x00284078
		public ModelConfigPreload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x0600944C RID: 37964 RVA: 0x00285E88 File Offset: 0x00284088
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

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x0600944D RID: 37965 RVA: 0x00285EC4 File Offset: 0x002840C4
		public string ActorClassPath
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600944E RID: 37966 RVA: 0x00285EFB File Offset: 0x002840FB
		public Span<byte> GetActorClassPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600944F RID: 37967 RVA: 0x00285F0A File Offset: 0x0028410A
		public byte[] GetActorClassPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06009450 RID: 37968 RVA: 0x00285F24 File Offset: 0x00284124
		public string ActorClass(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x06009451 RID: 37969 RVA: 0x00285F60 File Offset: 0x00284160
		public int ActorClassLength
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

		// Token: 0x06009452 RID: 37970 RVA: 0x00285F8C File Offset: 0x0028418C
		public string Animations(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x06009453 RID: 37971 RVA: 0x00285FC8 File Offset: 0x002841C8
		public int AnimationsLength
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

		// Token: 0x06009454 RID: 37972 RVA: 0x00285FF4 File Offset: 0x002841F4
		public string Effects(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x06009455 RID: 37973 RVA: 0x00286030 File Offset: 0x00284230
		public int EffectsLength
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

		// Token: 0x06009456 RID: 37974 RVA: 0x0028605C File Offset: 0x0028425C
		public string Audios(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x06009457 RID: 37975 RVA: 0x00286098 File Offset: 0x00284298
		public int AudiosLength
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

		// Token: 0x06009458 RID: 37976 RVA: 0x002860C4 File Offset: 0x002842C4
		public string Meshes(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x06009459 RID: 37977 RVA: 0x00286100 File Offset: 0x00284300
		public int MeshesLength
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

		// Token: 0x0600945A RID: 37978 RVA: 0x0028612C File Offset: 0x0028432C
		public string Materials(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x0600945B RID: 37979 RVA: 0x00286168 File Offset: 0x00284368
		public int MaterialsLength
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

		// Token: 0x0600945C RID: 37980 RVA: 0x00286194 File Offset: 0x00284394
		public string AnimationBlueprints(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x0600945D RID: 37981 RVA: 0x002861D0 File Offset: 0x002843D0
		public int AnimationBlueprintsLength
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

		// Token: 0x0600945E RID: 37982 RVA: 0x002861FC File Offset: 0x002843FC
		public string Others(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x0600945F RID: 37983 RVA: 0x00286238 File Offset: 0x00284438
		public int OthersLength
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

		// Token: 0x06009460 RID: 37984 RVA: 0x00286264 File Offset: 0x00284464
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ActorClassIter()或GetActorClassBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ActorClass()
		{
			return this.ActorClassIter().ToArray<string>();
		}

		// Token: 0x06009461 RID: 37985 RVA: 0x00286271 File Offset: 0x00284471
		[NullableContext(1)]
		public readonly IEnumerable<string> ActorClassIter()
		{
			ModelConfigPreload.<ActorClassIter>d__39 <ActorClassIter>d__ = new ModelConfigPreload.<ActorClassIter>d__39(-2);
			<ActorClassIter>d__.<>3__<>4__this = this;
			return <ActorClassIter>d__;
		}

		// Token: 0x06009462 RID: 37986 RVA: 0x00286286 File Offset: 0x00284486
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AnimationBlueprintsIter()或GetAnimationBlueprintsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AnimationBlueprints()
		{
			return this.AnimationBlueprintsIter().ToArray<string>();
		}

		// Token: 0x06009463 RID: 37987 RVA: 0x00286293 File Offset: 0x00284493
		[NullableContext(1)]
		public readonly IEnumerable<string> AnimationBlueprintsIter()
		{
			ModelConfigPreload.<AnimationBlueprintsIter>d__41 <AnimationBlueprintsIter>d__ = new ModelConfigPreload.<AnimationBlueprintsIter>d__41(-2);
			<AnimationBlueprintsIter>d__.<>3__<>4__this = this;
			return <AnimationBlueprintsIter>d__;
		}

		// Token: 0x06009464 RID: 37988 RVA: 0x002862A8 File Offset: 0x002844A8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AnimationsIter()或GetAnimationsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Animations()
		{
			return this.AnimationsIter().ToArray<string>();
		}

		// Token: 0x06009465 RID: 37989 RVA: 0x002862B5 File Offset: 0x002844B5
		[NullableContext(1)]
		public readonly IEnumerable<string> AnimationsIter()
		{
			ModelConfigPreload.<AnimationsIter>d__43 <AnimationsIter>d__ = new ModelConfigPreload.<AnimationsIter>d__43(-2);
			<AnimationsIter>d__.<>3__<>4__this = this;
			return <AnimationsIter>d__;
		}

		// Token: 0x06009466 RID: 37990 RVA: 0x002862CA File Offset: 0x002844CA
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AudiosIter()或GetAudiosBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Audios()
		{
			return this.AudiosIter().ToArray<string>();
		}

		// Token: 0x06009467 RID: 37991 RVA: 0x002862D7 File Offset: 0x002844D7
		[NullableContext(1)]
		public readonly IEnumerable<string> AudiosIter()
		{
			ModelConfigPreload.<AudiosIter>d__45 <AudiosIter>d__ = new ModelConfigPreload.<AudiosIter>d__45(-2);
			<AudiosIter>d__.<>3__<>4__this = this;
			return <AudiosIter>d__;
		}

		// Token: 0x06009468 RID: 37992 RVA: 0x002862EC File Offset: 0x002844EC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectsIter()或GetEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Effects()
		{
			return this.EffectsIter().ToArray<string>();
		}

		// Token: 0x06009469 RID: 37993 RVA: 0x002862F9 File Offset: 0x002844F9
		[NullableContext(1)]
		public readonly IEnumerable<string> EffectsIter()
		{
			ModelConfigPreload.<EffectsIter>d__47 <EffectsIter>d__ = new ModelConfigPreload.<EffectsIter>d__47(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x0600946A RID: 37994 RVA: 0x0028630E File Offset: 0x0028450E
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MaterialsIter()或GetMaterialsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Materials()
		{
			return this.MaterialsIter().ToArray<string>();
		}

		// Token: 0x0600946B RID: 37995 RVA: 0x0028631B File Offset: 0x0028451B
		[NullableContext(1)]
		public readonly IEnumerable<string> MaterialsIter()
		{
			ModelConfigPreload.<MaterialsIter>d__49 <MaterialsIter>d__ = new ModelConfigPreload.<MaterialsIter>d__49(-2);
			<MaterialsIter>d__.<>3__<>4__this = this;
			return <MaterialsIter>d__;
		}

		// Token: 0x0600946C RID: 37996 RVA: 0x00286330 File Offset: 0x00284530
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MeshesIter()或GetMeshesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Meshes()
		{
			return this.MeshesIter().ToArray<string>();
		}

		// Token: 0x0600946D RID: 37997 RVA: 0x0028633D File Offset: 0x0028453D
		[NullableContext(1)]
		public readonly IEnumerable<string> MeshesIter()
		{
			ModelConfigPreload.<MeshesIter>d__51 <MeshesIter>d__ = new ModelConfigPreload.<MeshesIter>d__51(-2);
			<MeshesIter>d__.<>3__<>4__this = this;
			return <MeshesIter>d__;
		}

		// Token: 0x0600946E RID: 37998 RVA: 0x00286352 File Offset: 0x00284552
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OthersIter()或GetOthersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Others()
		{
			return this.OthersIter().ToArray<string>();
		}

		// Token: 0x0600946F RID: 37999 RVA: 0x0028635F File Offset: 0x0028455F
		[NullableContext(1)]
		public readonly IEnumerable<string> OthersIter()
		{
			ModelConfigPreload.<OthersIter>d__53 <OthersIter>d__ = new ModelConfigPreload.<OthersIter>d__53(-2);
			<OthersIter>d__.<>3__<>4__this = this;
			return <OthersIter>d__;
		}

		// Token: 0x04004EB2 RID: 20146
		private Table __p;
	}
}
