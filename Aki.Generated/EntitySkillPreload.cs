using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C38 RID: 3128
	public struct EntitySkillPreload : IFlatbufferObject
	{
		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x0600699B RID: 27035 RVA: 0x00224140 File Offset: 0x00222340
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600699C RID: 27036 RVA: 0x0022414D File Offset: 0x0022234D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600699D RID: 27037 RVA: 0x00224154 File Offset: 0x00222354
		public static EntitySkillPreload GetRootAsEntitySkillPreload(ByteBuffer _bb)
		{
			return EntitySkillPreload.GetRootAsEntitySkillPreload(_bb, default(EntitySkillPreload));
		}

		// Token: 0x0600699E RID: 27038 RVA: 0x00224170 File Offset: 0x00222370
		public static EntitySkillPreload GetRootAsEntitySkillPreload(ByteBuffer _bb, EntitySkillPreload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600699F RID: 27039 RVA: 0x0022418D File Offset: 0x0022238D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060069A0 RID: 27040 RVA: 0x0022419C File Offset: 0x0022239C
		public EntitySkillPreload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x060069A1 RID: 27041 RVA: 0x002241AC File Offset: 0x002223AC
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

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x060069A2 RID: 27042 RVA: 0x002241E8 File Offset: 0x002223E8
		public int SkillId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x060069A3 RID: 27043 RVA: 0x00224224 File Offset: 0x00222424
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

		// Token: 0x060069A4 RID: 27044 RVA: 0x0022425B File Offset: 0x0022245B
		public Span<byte> GetActorBlueprintBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060069A5 RID: 27045 RVA: 0x0022426A File Offset: 0x0022246A
		public byte[] GetActorBlueprintArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x060069A6 RID: 27046 RVA: 0x00224284 File Offset: 0x00222484
		public int LoadType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x060069A7 RID: 27047 RVA: 0x002242C4 File Offset: 0x002224C4
		public bool IsCommon
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x060069A8 RID: 27048 RVA: 0x00224304 File Offset: 0x00222504
		public bool HasMontagePath
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060069A9 RID: 27049 RVA: 0x00224344 File Offset: 0x00222544
		public string ActorClass(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x060069AA RID: 27050 RVA: 0x00224380 File Offset: 0x00222580
		public int ActorClassLength
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

		// Token: 0x060069AB RID: 27051 RVA: 0x002243AC File Offset: 0x002225AC
		public string Animations(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x060069AC RID: 27052 RVA: 0x002243E8 File Offset: 0x002225E8
		public int AnimationsLength
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

		// Token: 0x060069AD RID: 27053 RVA: 0x00224414 File Offset: 0x00222614
		public string Effects(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x060069AE RID: 27054 RVA: 0x00224450 File Offset: 0x00222650
		public int EffectsLength
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

		// Token: 0x060069AF RID: 27055 RVA: 0x0022447C File Offset: 0x0022267C
		public string Audios(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x060069B0 RID: 27056 RVA: 0x002244B8 File Offset: 0x002226B8
		public int AudiosLength
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

		// Token: 0x060069B1 RID: 27057 RVA: 0x002244E4 File Offset: 0x002226E4
		public string Meshes(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x060069B2 RID: 27058 RVA: 0x00224520 File Offset: 0x00222720
		public int MeshesLength
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

		// Token: 0x060069B3 RID: 27059 RVA: 0x0022454C File Offset: 0x0022274C
		public string Materials(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x060069B4 RID: 27060 RVA: 0x00224588 File Offset: 0x00222788
		public int MaterialsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060069B5 RID: 27061 RVA: 0x002245B4 File Offset: 0x002227B4
		public string AnimationBlueprints(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x060069B6 RID: 27062 RVA: 0x002245F0 File Offset: 0x002227F0
		public int AnimationBlueprintsLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060069B7 RID: 27063 RVA: 0x0022461C File Offset: 0x0022281C
		public string Others(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x060069B8 RID: 27064 RVA: 0x00224658 File Offset: 0x00222858
		public int OthersLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060069B9 RID: 27065 RVA: 0x00224684 File Offset: 0x00222884
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ActorClassIter()或GetActorClassBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ActorClass()
		{
			return this.ActorClassIter().ToArray<string>();
		}

		// Token: 0x060069BA RID: 27066 RVA: 0x00224691 File Offset: 0x00222891
		[NullableContext(1)]
		public readonly IEnumerable<string> ActorClassIter()
		{
			EntitySkillPreload.<ActorClassIter>d__47 <ActorClassIter>d__ = new EntitySkillPreload.<ActorClassIter>d__47(-2);
			<ActorClassIter>d__.<>3__<>4__this = this;
			return <ActorClassIter>d__;
		}

		// Token: 0x060069BB RID: 27067 RVA: 0x002246A6 File Offset: 0x002228A6
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AnimationBlueprintsIter()或GetAnimationBlueprintsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AnimationBlueprints()
		{
			return this.AnimationBlueprintsIter().ToArray<string>();
		}

		// Token: 0x060069BC RID: 27068 RVA: 0x002246B3 File Offset: 0x002228B3
		[NullableContext(1)]
		public readonly IEnumerable<string> AnimationBlueprintsIter()
		{
			EntitySkillPreload.<AnimationBlueprintsIter>d__49 <AnimationBlueprintsIter>d__ = new EntitySkillPreload.<AnimationBlueprintsIter>d__49(-2);
			<AnimationBlueprintsIter>d__.<>3__<>4__this = this;
			return <AnimationBlueprintsIter>d__;
		}

		// Token: 0x060069BD RID: 27069 RVA: 0x002246C8 File Offset: 0x002228C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AnimationsIter()或GetAnimationsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Animations()
		{
			return this.AnimationsIter().ToArray<string>();
		}

		// Token: 0x060069BE RID: 27070 RVA: 0x002246D5 File Offset: 0x002228D5
		[NullableContext(1)]
		public readonly IEnumerable<string> AnimationsIter()
		{
			EntitySkillPreload.<AnimationsIter>d__51 <AnimationsIter>d__ = new EntitySkillPreload.<AnimationsIter>d__51(-2);
			<AnimationsIter>d__.<>3__<>4__this = this;
			return <AnimationsIter>d__;
		}

		// Token: 0x060069BF RID: 27071 RVA: 0x002246EA File Offset: 0x002228EA
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AudiosIter()或GetAudiosBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Audios()
		{
			return this.AudiosIter().ToArray<string>();
		}

		// Token: 0x060069C0 RID: 27072 RVA: 0x002246F7 File Offset: 0x002228F7
		[NullableContext(1)]
		public readonly IEnumerable<string> AudiosIter()
		{
			EntitySkillPreload.<AudiosIter>d__53 <AudiosIter>d__ = new EntitySkillPreload.<AudiosIter>d__53(-2);
			<AudiosIter>d__.<>3__<>4__this = this;
			return <AudiosIter>d__;
		}

		// Token: 0x060069C1 RID: 27073 RVA: 0x0022470C File Offset: 0x0022290C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectsIter()或GetEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Effects()
		{
			return this.EffectsIter().ToArray<string>();
		}

		// Token: 0x060069C2 RID: 27074 RVA: 0x00224719 File Offset: 0x00222919
		[NullableContext(1)]
		public readonly IEnumerable<string> EffectsIter()
		{
			EntitySkillPreload.<EffectsIter>d__55 <EffectsIter>d__ = new EntitySkillPreload.<EffectsIter>d__55(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x060069C3 RID: 27075 RVA: 0x0022472E File Offset: 0x0022292E
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MaterialsIter()或GetMaterialsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Materials()
		{
			return this.MaterialsIter().ToArray<string>();
		}

		// Token: 0x060069C4 RID: 27076 RVA: 0x0022473B File Offset: 0x0022293B
		[NullableContext(1)]
		public readonly IEnumerable<string> MaterialsIter()
		{
			EntitySkillPreload.<MaterialsIter>d__57 <MaterialsIter>d__ = new EntitySkillPreload.<MaterialsIter>d__57(-2);
			<MaterialsIter>d__.<>3__<>4__this = this;
			return <MaterialsIter>d__;
		}

		// Token: 0x060069C5 RID: 27077 RVA: 0x00224750 File Offset: 0x00222950
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MeshesIter()或GetMeshesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Meshes()
		{
			return this.MeshesIter().ToArray<string>();
		}

		// Token: 0x060069C6 RID: 27078 RVA: 0x0022475D File Offset: 0x0022295D
		[NullableContext(1)]
		public readonly IEnumerable<string> MeshesIter()
		{
			EntitySkillPreload.<MeshesIter>d__59 <MeshesIter>d__ = new EntitySkillPreload.<MeshesIter>d__59(-2);
			<MeshesIter>d__.<>3__<>4__this = this;
			return <MeshesIter>d__;
		}

		// Token: 0x060069C7 RID: 27079 RVA: 0x00224772 File Offset: 0x00222972
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OthersIter()或GetOthersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Others()
		{
			return this.OthersIter().ToArray<string>();
		}

		// Token: 0x060069C8 RID: 27080 RVA: 0x0022477F File Offset: 0x0022297F
		[NullableContext(1)]
		public readonly IEnumerable<string> OthersIter()
		{
			EntitySkillPreload.<OthersIter>d__61 <OthersIter>d__ = new EntitySkillPreload.<OthersIter>d__61(-2);
			<OthersIter>d__.<>3__<>4__this = this;
			return <OthersIter>d__;
		}

		// Token: 0x04004C78 RID: 19576
		private Table __p;
	}
}
