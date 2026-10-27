using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B66 RID: 2918
	public struct CharacterPreload : IFlatbufferObject
	{
		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060052D8 RID: 21208 RVA: 0x001F0650 File Offset: 0x001EE850
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060052D9 RID: 21209 RVA: 0x001F065D File Offset: 0x001EE85D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x001F0664 File Offset: 0x001EE864
		public static CharacterPreload GetRootAsCharacterPreload(ByteBuffer _bb)
		{
			return CharacterPreload.GetRootAsCharacterPreload(_bb, default(CharacterPreload));
		}

		// Token: 0x060052DB RID: 21211 RVA: 0x001F0680 File Offset: 0x001EE880
		public static CharacterPreload GetRootAsCharacterPreload(ByteBuffer _bb, CharacterPreload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060052DC RID: 21212 RVA: 0x001F069D File Offset: 0x001EE89D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060052DD RID: 21213 RVA: 0x001F06AC File Offset: 0x001EE8AC
		public CharacterPreload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060052DE RID: 21214 RVA: 0x001F06BC File Offset: 0x001EE8BC
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

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060052DF RID: 21215 RVA: 0x001F06F8 File Offset: 0x001EE8F8
		public int AiId
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

		// Token: 0x060052E0 RID: 21216 RVA: 0x001F0734 File Offset: 0x001EE934
		public string ActorClass(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060052E1 RID: 21217 RVA: 0x001F0770 File Offset: 0x001EE970
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

		// Token: 0x060052E2 RID: 21218 RVA: 0x001F079C File Offset: 0x001EE99C
		public string Animations(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060052E3 RID: 21219 RVA: 0x001F07D8 File Offset: 0x001EE9D8
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

		// Token: 0x060052E4 RID: 21220 RVA: 0x001F0804 File Offset: 0x001EEA04
		public string Effects(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060052E5 RID: 21221 RVA: 0x001F0840 File Offset: 0x001EEA40
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

		// Token: 0x060052E6 RID: 21222 RVA: 0x001F086C File Offset: 0x001EEA6C
		public string Audios(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060052E7 RID: 21223 RVA: 0x001F08A8 File Offset: 0x001EEAA8
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

		// Token: 0x060052E8 RID: 21224 RVA: 0x001F08D4 File Offset: 0x001EEAD4
		public string Meshes(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060052E9 RID: 21225 RVA: 0x001F0910 File Offset: 0x001EEB10
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

		// Token: 0x060052EA RID: 21226 RVA: 0x001F093C File Offset: 0x001EEB3C
		public string Materials(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060052EB RID: 21227 RVA: 0x001F0978 File Offset: 0x001EEB78
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

		// Token: 0x060052EC RID: 21228 RVA: 0x001F09A4 File Offset: 0x001EEBA4
		public string AnimationBlueprints(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060052ED RID: 21229 RVA: 0x001F09E0 File Offset: 0x001EEBE0
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

		// Token: 0x060052EE RID: 21230 RVA: 0x001F0A0C File Offset: 0x001EEC0C
		public string Others(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060052EF RID: 21231 RVA: 0x001F0A48 File Offset: 0x001EEC48
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

		// Token: 0x060052F0 RID: 21232 RVA: 0x001F0A74 File Offset: 0x001EEC74
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ActorClassIter()或GetActorClassBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ActorClass()
		{
			return this.ActorClassIter().ToArray<string>();
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x001F0A81 File Offset: 0x001EEC81
		[NullableContext(1)]
		public readonly IEnumerable<string> ActorClassIter()
		{
			CharacterPreload.<ActorClassIter>d__37 <ActorClassIter>d__ = new CharacterPreload.<ActorClassIter>d__37(-2);
			<ActorClassIter>d__.<>3__<>4__this = this;
			return <ActorClassIter>d__;
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x001F0A96 File Offset: 0x001EEC96
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AnimationBlueprintsIter()或GetAnimationBlueprintsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AnimationBlueprints()
		{
			return this.AnimationBlueprintsIter().ToArray<string>();
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x001F0AA3 File Offset: 0x001EECA3
		[NullableContext(1)]
		public readonly IEnumerable<string> AnimationBlueprintsIter()
		{
			CharacterPreload.<AnimationBlueprintsIter>d__39 <AnimationBlueprintsIter>d__ = new CharacterPreload.<AnimationBlueprintsIter>d__39(-2);
			<AnimationBlueprintsIter>d__.<>3__<>4__this = this;
			return <AnimationBlueprintsIter>d__;
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x001F0AB8 File Offset: 0x001EECB8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AnimationsIter()或GetAnimationsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Animations()
		{
			return this.AnimationsIter().ToArray<string>();
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x001F0AC5 File Offset: 0x001EECC5
		[NullableContext(1)]
		public readonly IEnumerable<string> AnimationsIter()
		{
			CharacterPreload.<AnimationsIter>d__41 <AnimationsIter>d__ = new CharacterPreload.<AnimationsIter>d__41(-2);
			<AnimationsIter>d__.<>3__<>4__this = this;
			return <AnimationsIter>d__;
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x001F0ADA File Offset: 0x001EECDA
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AudiosIter()或GetAudiosBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Audios()
		{
			return this.AudiosIter().ToArray<string>();
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x001F0AE7 File Offset: 0x001EECE7
		[NullableContext(1)]
		public readonly IEnumerable<string> AudiosIter()
		{
			CharacterPreload.<AudiosIter>d__43 <AudiosIter>d__ = new CharacterPreload.<AudiosIter>d__43(-2);
			<AudiosIter>d__.<>3__<>4__this = this;
			return <AudiosIter>d__;
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x001F0AFC File Offset: 0x001EECFC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectsIter()或GetEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Effects()
		{
			return this.EffectsIter().ToArray<string>();
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x001F0B09 File Offset: 0x001EED09
		[NullableContext(1)]
		public readonly IEnumerable<string> EffectsIter()
		{
			CharacterPreload.<EffectsIter>d__45 <EffectsIter>d__ = new CharacterPreload.<EffectsIter>d__45(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x001F0B1E File Offset: 0x001EED1E
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MaterialsIter()或GetMaterialsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Materials()
		{
			return this.MaterialsIter().ToArray<string>();
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x001F0B2B File Offset: 0x001EED2B
		[NullableContext(1)]
		public readonly IEnumerable<string> MaterialsIter()
		{
			CharacterPreload.<MaterialsIter>d__47 <MaterialsIter>d__ = new CharacterPreload.<MaterialsIter>d__47(-2);
			<MaterialsIter>d__.<>3__<>4__this = this;
			return <MaterialsIter>d__;
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x001F0B40 File Offset: 0x001EED40
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MeshesIter()或GetMeshesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Meshes()
		{
			return this.MeshesIter().ToArray<string>();
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x001F0B4D File Offset: 0x001EED4D
		[NullableContext(1)]
		public readonly IEnumerable<string> MeshesIter()
		{
			CharacterPreload.<MeshesIter>d__49 <MeshesIter>d__ = new CharacterPreload.<MeshesIter>d__49(-2);
			<MeshesIter>d__.<>3__<>4__this = this;
			return <MeshesIter>d__;
		}

		// Token: 0x060052FE RID: 21246 RVA: 0x001F0B62 File Offset: 0x001EED62
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OthersIter()或GetOthersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Others()
		{
			return this.OthersIter().ToArray<string>();
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x001F0B6F File Offset: 0x001EED6F
		[NullableContext(1)]
		public readonly IEnumerable<string> OthersIter()
		{
			CharacterPreload.<OthersIter>d__51 <OthersIter>d__ = new CharacterPreload.<OthersIter>d__51(-2);
			<OthersIter>d__.<>3__<>4__this = this;
			return <OthersIter>d__;
		}

		// Token: 0x04004B68 RID: 19304
		private Table __p;
	}
}
