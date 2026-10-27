using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC2 RID: 4034
	public struct RhythmRole : IFlatbufferObject
	{
		// Token: 0x17002E30 RID: 11824
		// (get) Token: 0x0600BC61 RID: 48225 RVA: 0x002DEF18 File Offset: 0x002DD118
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BC62 RID: 48226 RVA: 0x002DEF25 File Offset: 0x002DD125
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BC63 RID: 48227 RVA: 0x002DEF2C File Offset: 0x002DD12C
		public static RhythmRole GetRootAsRhythmRole(ByteBuffer _bb)
		{
			return RhythmRole.GetRootAsRhythmRole(_bb, default(RhythmRole));
		}

		// Token: 0x0600BC64 RID: 48228 RVA: 0x002DEF48 File Offset: 0x002DD148
		public static RhythmRole GetRootAsRhythmRole(ByteBuffer _bb, RhythmRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BC65 RID: 48229 RVA: 0x002DEF65 File Offset: 0x002DD165
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BC66 RID: 48230 RVA: 0x002DEF74 File Offset: 0x002DD174
		public RhythmRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E31 RID: 11825
		// (get) Token: 0x0600BC67 RID: 48231 RVA: 0x002DEF84 File Offset: 0x002DD184
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

		// Token: 0x17002E32 RID: 11826
		// (get) Token: 0x0600BC68 RID: 48232 RVA: 0x002DEFC0 File Offset: 0x002DD1C0
		public int ActivityId
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

		// Token: 0x17002E33 RID: 11827
		// (get) Token: 0x0600BC69 RID: 48233 RVA: 0x002DEFFC File Offset: 0x002DD1FC
		public int UnlockCondition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002E34 RID: 11828
		// (get) Token: 0x0600BC6A RID: 48234 RVA: 0x002DF038 File Offset: 0x002DD238
		public bool DefaultRole
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600BC6B RID: 48235 RVA: 0x002DF078 File Offset: 0x002DD278
		public int Effect(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E35 RID: 11829
		// (get) Token: 0x0600BC6C RID: 48236 RVA: 0x002DF0B8 File Offset: 0x002DD2B8
		public int EffectLength
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

		// Token: 0x0600BC6D RID: 48237 RVA: 0x002DF0E4 File Offset: 0x002DD2E4
		public Span<int> GetEffectBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600BC6E RID: 48238 RVA: 0x002DF0F4 File Offset: 0x002DD2F4
		public int[] GetEffectArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17002E36 RID: 11830
		// (get) Token: 0x0600BC6F RID: 48239 RVA: 0x002DF10C File Offset: 0x002DD30C
		public string RoleNameText
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BC70 RID: 48240 RVA: 0x002DF144 File Offset: 0x002DD344
		public Span<byte> GetRoleNameTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BC71 RID: 48241 RVA: 0x002DF154 File Offset: 0x002DD354
		public byte[] GetRoleNameTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E37 RID: 11831
		// (get) Token: 0x0600BC72 RID: 48242 RVA: 0x002DF16C File Offset: 0x002DD36C
		public string RoleHeadTexture
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BC73 RID: 48243 RVA: 0x002DF1A4 File Offset: 0x002DD3A4
		public Span<byte> GetRoleHeadTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BC74 RID: 48244 RVA: 0x002DF1B4 File Offset: 0x002DD3B4
		public byte[] GetRoleHeadTextureArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E38 RID: 11832
		// (get) Token: 0x0600BC75 RID: 48245 RVA: 0x002DF1CC File Offset: 0x002DD3CC
		public string RoleHeadTexture2
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BC76 RID: 48246 RVA: 0x002DF204 File Offset: 0x002DD404
		public Span<byte> GetRoleHeadTexture2Bytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BC77 RID: 48247 RVA: 0x002DF214 File Offset: 0x002DD414
		public byte[] GetRoleHeadTexture2Array()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BC78 RID: 48248 RVA: 0x002DF22C File Offset: 0x002DD42C
		public int SkillEffectList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E39 RID: 11833
		// (get) Token: 0x0600BC79 RID: 48249 RVA: 0x002DF26C File Offset: 0x002DD46C
		public int SkillEffectListLength
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

		// Token: 0x0600BC7A RID: 48250 RVA: 0x002DF298 File Offset: 0x002DD498
		public Span<int> GetSkillEffectListBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600BC7B RID: 48251 RVA: 0x002DF2A8 File Offset: 0x002DD4A8
		public int[] GetSkillEffectListArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x17002E3A RID: 11834
		// (get) Token: 0x0600BC7C RID: 48252 RVA: 0x002DF2C0 File Offset: 0x002DD4C0
		public string SkillIcon
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BC7D RID: 48253 RVA: 0x002DF2F8 File Offset: 0x002DD4F8
		public Span<byte> GetSkillIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600BC7E RID: 48254 RVA: 0x002DF308 File Offset: 0x002DD508
		public byte[] GetSkillIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E3B RID: 11835
		// (get) Token: 0x0600BC7F RID: 48255 RVA: 0x002DF320 File Offset: 0x002DD520
		public string RoleDesText
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BC80 RID: 48256 RVA: 0x002DF358 File Offset: 0x002DD558
		public Span<byte> GetRoleDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600BC81 RID: 48257 RVA: 0x002DF368 File Offset: 0x002DD568
		public byte[] GetRoleDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E3C RID: 11836
		// (get) Token: 0x0600BC82 RID: 48258 RVA: 0x002DF380 File Offset: 0x002DD580
		public string LockTips
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BC83 RID: 48259 RVA: 0x002DF3B8 File Offset: 0x002DD5B8
		public Span<byte> GetLockTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600BC84 RID: 48260 RVA: 0x002DF3C8 File Offset: 0x002DD5C8
		public byte[] GetLockTipsArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E3D RID: 11837
		// (get) Token: 0x0600BC85 RID: 48261 RVA: 0x002DF3E0 File Offset: 0x002DD5E0
		public string RoleSkillText
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BC86 RID: 48262 RVA: 0x002DF418 File Offset: 0x002DD618
		public Span<byte> GetRoleSkillTextBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600BC87 RID: 48263 RVA: 0x002DF428 File Offset: 0x002DD628
		public byte[] GetRoleSkillTextArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E3E RID: 11838
		// (get) Token: 0x0600BC88 RID: 48264 RVA: 0x002DF440 File Offset: 0x002DD640
		public string RoleSkillMusic
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BC89 RID: 48265 RVA: 0x002DF478 File Offset: 0x002DD678
		public Span<byte> GetRoleSkillMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600BC8A RID: 48266 RVA: 0x002DF488 File Offset: 0x002DD688
		public byte[] GetRoleSkillMusicArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BC8B RID: 48267 RVA: 0x002DF4A0 File Offset: 0x002DD6A0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectIter()或GetEffectBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Effect()
		{
			RhythmRole rhythmRole = this;
			return rhythmRole.GetEffectArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BC8C RID: 48268 RVA: 0x002DF4C4 File Offset: 0x002DD6C4
		[NullableContext(1)]
		public readonly IEnumerable<int> EffectIter()
		{
			RhythmRole.<EffectIter>d__59 <EffectIter>d__ = new RhythmRole.<EffectIter>d__59(-2);
			<EffectIter>d__.<>3__<>4__this = this;
			return <EffectIter>d__;
		}

		// Token: 0x0600BC8D RID: 48269 RVA: 0x002DF4DC File Offset: 0x002DD6DC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillEffectListIter()或GetSkillEffectListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillEffectList()
		{
			RhythmRole rhythmRole = this;
			return rhythmRole.GetSkillEffectListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BC8E RID: 48270 RVA: 0x002DF500 File Offset: 0x002DD700
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillEffectListIter()
		{
			RhythmRole.<SkillEffectListIter>d__61 <SkillEffectListIter>d__ = new RhythmRole.<SkillEffectListIter>d__61(-2);
			<SkillEffectListIter>d__.<>3__<>4__this = this;
			return <SkillEffectListIter>d__;
		}

		// Token: 0x0400509C RID: 20636
		private Table __p;
	}
}
