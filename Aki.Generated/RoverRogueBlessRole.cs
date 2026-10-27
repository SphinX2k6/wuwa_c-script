using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001074 RID: 4212
	public struct RoverRogueBlessRole : IFlatbufferObject
	{
		// Token: 0x17003414 RID: 13332
		// (get) Token: 0x0600CD29 RID: 52521 RVA: 0x00304B34 File Offset: 0x00302D34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CD2A RID: 52522 RVA: 0x00304B41 File Offset: 0x00302D41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CD2B RID: 52523 RVA: 0x00304B48 File Offset: 0x00302D48
		public static RoverRogueBlessRole GetRootAsRoverRogueBlessRole(ByteBuffer _bb)
		{
			return RoverRogueBlessRole.GetRootAsRoverRogueBlessRole(_bb, default(RoverRogueBlessRole));
		}

		// Token: 0x0600CD2C RID: 52524 RVA: 0x00304B64 File Offset: 0x00302D64
		public static RoverRogueBlessRole GetRootAsRoverRogueBlessRole(ByteBuffer _bb, RoverRogueBlessRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CD2D RID: 52525 RVA: 0x00304B81 File Offset: 0x00302D81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CD2E RID: 52526 RVA: 0x00304B90 File Offset: 0x00302D90
		public RoverRogueBlessRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003415 RID: 13333
		// (get) Token: 0x0600CD2F RID: 52527 RVA: 0x00304BA0 File Offset: 0x00302DA0
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

		// Token: 0x17003416 RID: 13334
		// (get) Token: 0x0600CD30 RID: 52528 RVA: 0x00304BDC File Offset: 0x00302DDC
		public int UnlockInsId
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

		// Token: 0x17003417 RID: 13335
		// (get) Token: 0x0600CD31 RID: 52529 RVA: 0x00304C18 File Offset: 0x00302E18
		public int ActivityId
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

		// Token: 0x0600CD32 RID: 52530 RVA: 0x00304C54 File Offset: 0x00302E54
		public DicIntInt? BlessRoleWeightChange(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003418 RID: 13336
		// (get) Token: 0x0600CD33 RID: 52531 RVA: 0x00304CB8 File Offset: 0x00302EB8
		public int BlessRoleWeightChangeLength
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

		// Token: 0x17003419 RID: 13337
		// (get) Token: 0x0600CD34 RID: 52532 RVA: 0x00304CE4 File Offset: 0x00302EE4
		public int BaseWeight
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700341A RID: 13338
		// (get) Token: 0x0600CD35 RID: 52533 RVA: 0x00304D24 File Offset: 0x00302F24
		public string BlessRoleName
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

		// Token: 0x0600CD36 RID: 52534 RVA: 0x00304D5C File Offset: 0x00302F5C
		public Span<byte> GetBlessRoleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CD37 RID: 52535 RVA: 0x00304D6C File Offset: 0x00302F6C
		public byte[] GetBlessRoleNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700341B RID: 13339
		// (get) Token: 0x0600CD38 RID: 52536 RVA: 0x00304D84 File Offset: 0x00302F84
		public string UnlockDesc
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

		// Token: 0x0600CD39 RID: 52537 RVA: 0x00304DBC File Offset: 0x00302FBC
		public Span<byte> GetUnlockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CD3A RID: 52538 RVA: 0x00304DCC File Offset: 0x00302FCC
		public byte[] GetUnlockDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700341C RID: 13340
		// (get) Token: 0x0600CD3B RID: 52539 RVA: 0x00304DE4 File Offset: 0x00302FE4
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CD3C RID: 52540 RVA: 0x00304E24 File Offset: 0x00303024
		public int EnableRoleType(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700341D RID: 13341
		// (get) Token: 0x0600CD3D RID: 52541 RVA: 0x00304E64 File Offset: 0x00303064
		public int EnableRoleTypeLength
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

		// Token: 0x0600CD3E RID: 52542 RVA: 0x00304E90 File Offset: 0x00303090
		public Span<int> GetEnableRoleTypeBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600CD3F RID: 52543 RVA: 0x00304EA0 File Offset: 0x003030A0
		public int[] GetEnableRoleTypeArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x1700341E RID: 13342
		// (get) Token: 0x0600CD40 RID: 52544 RVA: 0x00304EB8 File Offset: 0x003030B8
		public string RoleIcon
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

		// Token: 0x0600CD41 RID: 52545 RVA: 0x00304EF0 File Offset: 0x003030F0
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600CD42 RID: 52546 RVA: 0x00304F00 File Offset: 0x00303100
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700341F RID: 13343
		// (get) Token: 0x0600CD43 RID: 52547 RVA: 0x00304F18 File Offset: 0x00303118
		public string IconPath
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

		// Token: 0x0600CD44 RID: 52548 RVA: 0x00304F50 File Offset: 0x00303150
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600CD45 RID: 52549 RVA: 0x00304F60 File Offset: 0x00303160
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003420 RID: 13344
		// (get) Token: 0x0600CD46 RID: 52550 RVA: 0x00304F78 File Offset: 0x00303178
		public string Stand
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

		// Token: 0x0600CD47 RID: 52551 RVA: 0x00304FB0 File Offset: 0x003031B0
		public Span<byte> GetStandBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600CD48 RID: 52552 RVA: 0x00304FC0 File Offset: 0x003031C0
		public byte[] GetStandArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17003421 RID: 13345
		// (get) Token: 0x0600CD49 RID: 52553 RVA: 0x00304FD8 File Offset: 0x003031D8
		public string UnlockStand
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

		// Token: 0x0600CD4A RID: 52554 RVA: 0x00305010 File Offset: 0x00303210
		public Span<byte> GetUnlockStandBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600CD4B RID: 52555 RVA: 0x00305020 File Offset: 0x00303220
		public byte[] GetUnlockStandArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003422 RID: 13346
		// (get) Token: 0x0600CD4C RID: 52556 RVA: 0x00305038 File Offset: 0x00303238
		public string SkillStand
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

		// Token: 0x0600CD4D RID: 52557 RVA: 0x00305070 File Offset: 0x00303270
		public Span<byte> GetSkillStandBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600CD4E RID: 52558 RVA: 0x00305080 File Offset: 0x00303280
		public byte[] GetSkillStandArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17003423 RID: 13347
		// (get) Token: 0x0600CD4F RID: 52559 RVA: 0x00305098 File Offset: 0x00303298
		public string SkillDesc
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CD50 RID: 52560 RVA: 0x003050D0 File Offset: 0x003032D0
		public Span<byte> GetSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600CD51 RID: 52561 RVA: 0x003050E0 File Offset: 0x003032E0
		public byte[] GetSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17003424 RID: 13348
		// (get) Token: 0x0600CD52 RID: 52562 RVA: 0x003050F8 File Offset: 0x003032F8
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003425 RID: 13349
		// (get) Token: 0x0600CD53 RID: 52563 RVA: 0x00305138 File Offset: 0x00303338
		public int PortalBallEntityId
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003426 RID: 13350
		// (get) Token: 0x0600CD54 RID: 52564 RVA: 0x00305178 File Offset: 0x00303378
		public string BlessSelectDesc
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CD55 RID: 52565 RVA: 0x003051B0 File Offset: 0x003033B0
		public Span<byte> GetBlessSelectDescBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600CD56 RID: 52566 RVA: 0x003051C0 File Offset: 0x003033C0
		public byte[] GetBlessSelectDescArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CD57 RID: 52567 RVA: 0x003051D8 File Offset: 0x003033D8
		public int BlessVoice(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003427 RID: 13351
		// (get) Token: 0x0600CD58 RID: 52568 RVA: 0x00305218 File Offset: 0x00303418
		public int BlessVoiceLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CD59 RID: 52569 RVA: 0x00305244 File Offset: 0x00303444
		public Span<int> GetBlessVoiceBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x0600CD5A RID: 52570 RVA: 0x00305254 File Offset: 0x00303454
		public int[] GetBlessVoiceArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x0600CD5B RID: 52571 RVA: 0x0030526C File Offset: 0x0030346C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用BlessRoleWeightChangeFrozenDict()缓存字典，遍历请使用BlessRoleWeightChangeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> BlessRoleWeightChange()
		{
			return this.BlessRoleWeightChangeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600CD5C RID: 52572 RVA: 0x003052C2 File Offset: 0x003034C2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> BlessRoleWeightChangeIter()
		{
			RoverRogueBlessRole.<BlessRoleWeightChangeIter>d__72 <BlessRoleWeightChangeIter>d__ = new RoverRogueBlessRole.<BlessRoleWeightChangeIter>d__72(-2);
			<BlessRoleWeightChangeIter>d__.<>3__<>4__this = this;
			return <BlessRoleWeightChangeIter>d__;
		}

		// Token: 0x0600CD5D RID: 52573 RVA: 0x003052D8 File Offset: 0x003034D8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BlessVoiceIter()或GetBlessVoiceBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BlessVoice()
		{
			RoverRogueBlessRole roverRogueBlessRole = this;
			return roverRogueBlessRole.GetBlessVoiceArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CD5E RID: 52574 RVA: 0x003052FC File Offset: 0x003034FC
		[NullableContext(1)]
		public readonly IEnumerable<int> BlessVoiceIter()
		{
			RoverRogueBlessRole.<BlessVoiceIter>d__74 <BlessVoiceIter>d__ = new RoverRogueBlessRole.<BlessVoiceIter>d__74(-2);
			<BlessVoiceIter>d__.<>3__<>4__this = this;
			return <BlessVoiceIter>d__;
		}

		// Token: 0x0600CD5F RID: 52575 RVA: 0x00305314 File Offset: 0x00303514
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EnableRoleTypeIter()或GetEnableRoleTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EnableRoleType()
		{
			RoverRogueBlessRole roverRogueBlessRole = this;
			return roverRogueBlessRole.GetEnableRoleTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CD60 RID: 52576 RVA: 0x00305338 File Offset: 0x00303538
		[NullableContext(1)]
		public readonly IEnumerable<int> EnableRoleTypeIter()
		{
			RoverRogueBlessRole.<EnableRoleTypeIter>d__76 <EnableRoleTypeIter>d__ = new RoverRogueBlessRole.<EnableRoleTypeIter>d__76(-2);
			<EnableRoleTypeIter>d__.<>3__<>4__this = this;
			return <EnableRoleTypeIter>d__;
		}

		// Token: 0x0600CD61 RID: 52577 RVA: 0x00305350 File Offset: 0x00303550
		public int? GetBlessRoleWeightChange(int key)
		{
			this.EnsureBlessRoleWeightChangeCacheIfNeeded();
			int value;
			if (!this.BlessRoleWeightChangeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600CD62 RID: 52578 RVA: 0x00305384 File Offset: 0x00303584
		private void EnsureBlessRoleWeightChangeCacheIfNeeded()
		{
			if (this.BlessRoleWeightChangeCache != null)
			{
				return;
			}
			this.BlessRoleWeightChangeCache = this.BlessRoleWeightChangeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600CD63 RID: 52579 RVA: 0x003053EA File Offset: 0x003035EA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetBlessRoleWeightChangeFrozenDict(int key)
		{
			this.EnsureBlessRoleWeightChangeCacheIfNeeded();
			return this.BlessRoleWeightChangeCache;
		}

		// Token: 0x0400517D RID: 20861
		private Table __p;

		// Token: 0x0400517E RID: 20862
		[Nullable(2)]
		private FrozenDictionary<int, int> BlessRoleWeightChangeCache;
	}
}
