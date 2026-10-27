using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE8 RID: 4072
	public struct RogueParam : IFlatbufferObject
	{
		// Token: 0x17002F6D RID: 12141
		// (get) Token: 0x0600BFCB RID: 49099 RVA: 0x002E687D File Offset: 0x002E4A7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BFCC RID: 49100 RVA: 0x002E688A File Offset: 0x002E4A8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BFCD RID: 49101 RVA: 0x002E6894 File Offset: 0x002E4A94
		public static RogueParam GetRootAsRogueParam(ByteBuffer _bb)
		{
			return RogueParam.GetRootAsRogueParam(_bb, default(RogueParam));
		}

		// Token: 0x0600BFCE RID: 49102 RVA: 0x002E68B0 File Offset: 0x002E4AB0
		public static RogueParam GetRootAsRogueParam(ByteBuffer _bb, RogueParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BFCF RID: 49103 RVA: 0x002E68CD File Offset: 0x002E4ACD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BFD0 RID: 49104 RVA: 0x002E68DC File Offset: 0x002E4ADC
		public RogueParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F6E RID: 12142
		// (get) Token: 0x0600BFD1 RID: 49105 RVA: 0x002E68EC File Offset: 0x002E4AEC
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

		// Token: 0x17002F6F RID: 12143
		// (get) Token: 0x0600BFD2 RID: 49106 RVA: 0x002E6928 File Offset: 0x002E4B28
		public string RoguelikeSettleBgS
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

		// Token: 0x0600BFD3 RID: 49107 RVA: 0x002E695F File Offset: 0x002E4B5F
		public Span<byte> GetRoguelikeSettleBgSBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BFD4 RID: 49108 RVA: 0x002E696E File Offset: 0x002E4B6E
		public byte[] GetRoguelikeSettleBgSArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F70 RID: 12144
		// (get) Token: 0x0600BFD5 RID: 49109 RVA: 0x002E6988 File Offset: 0x002E4B88
		public string RoguelikeSettleBgNormal
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

		// Token: 0x0600BFD6 RID: 49110 RVA: 0x002E69BF File Offset: 0x002E4BBF
		public Span<byte> GetRoguelikeSettleBgNormalBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BFD7 RID: 49111 RVA: 0x002E69CE File Offset: 0x002E4BCE
		public byte[] GetRoguelikeSettleBgNormalArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F71 RID: 12145
		// (get) Token: 0x0600BFD8 RID: 49112 RVA: 0x002E69E8 File Offset: 0x002E4BE8
		public string RoguelikeRoomFloatTipsNoHeadIcon
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BFD9 RID: 49113 RVA: 0x002E6A20 File Offset: 0x002E4C20
		public Span<byte> GetRoguelikeRoomFloatTipsNoHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BFDA RID: 49114 RVA: 0x002E6A30 File Offset: 0x002E4C30
		public byte[] GetRoguelikeRoomFloatTipsNoHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F72 RID: 12146
		// (get) Token: 0x0600BFDB RID: 49115 RVA: 0x002E6A48 File Offset: 0x002E4C48
		public string RoguelikeRoomFloatTipsSpecialIcon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BFDC RID: 49116 RVA: 0x002E6A80 File Offset: 0x002E4C80
		public Span<byte> GetRoguelikeRoomFloatTipsSpecialIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BFDD RID: 49117 RVA: 0x002E6A90 File Offset: 0x002E4C90
		public byte[] GetRoguelikeRoomFloatTipsSpecialIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F73 RID: 12147
		// (get) Token: 0x0600BFDE RID: 49118 RVA: 0x002E6AA8 File Offset: 0x002E4CA8
		public int RoguelikeSettleS
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002F74 RID: 12148
		// (get) Token: 0x0600BFDF RID: 49119 RVA: 0x002E6AE8 File Offset: 0x002E4CE8
		public int RoguelikeSettleA
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002F75 RID: 12149
		// (get) Token: 0x0600BFE0 RID: 49120 RVA: 0x002E6B28 File Offset: 0x002E4D28
		public int RoguelikeSettleB
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

		// Token: 0x17002F76 RID: 12150
		// (get) Token: 0x0600BFE1 RID: 49121 RVA: 0x002E6B68 File Offset: 0x002E4D68
		public int RoguelikeSettleC
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002F77 RID: 12151
		// (get) Token: 0x0600BFE2 RID: 49122 RVA: 0x002E6BA8 File Offset: 0x002E4DA8
		public int PointItem
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002F78 RID: 12152
		// (get) Token: 0x0600BFE3 RID: 49123 RVA: 0x002E6BE8 File Offset: 0x002E4DE8
		public int PointItemMaxCount
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002F79 RID: 12153
		// (get) Token: 0x0600BFE4 RID: 49124 RVA: 0x002E6C28 File Offset: 0x002E4E28
		public int TokenItem
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002F7A RID: 12154
		// (get) Token: 0x0600BFE5 RID: 49125 RVA: 0x002E6C68 File Offset: 0x002E4E68
		public int WeekTokenMaxCount
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002F7B RID: 12155
		// (get) Token: 0x0600BFE6 RID: 49126 RVA: 0x002E6CA8 File Offset: 0x002E4EA8
		public int SkillPoint
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002F7C RID: 12156
		// (get) Token: 0x0600BFE7 RID: 49127 RVA: 0x002E6CE8 File Offset: 0x002E4EE8
		public int SkillPointMaxCount
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002F7D RID: 12157
		// (get) Token: 0x0600BFE8 RID: 49128 RVA: 0x002E6D28 File Offset: 0x002E4F28
		public int InsideCurrency
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

		// Token: 0x0600BFE9 RID: 49129 RVA: 0x002E6D68 File Offset: 0x002E4F68
		public int GuideInstArray(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F7E RID: 12158
		// (get) Token: 0x0600BFEA RID: 49130 RVA: 0x002E6DA8 File Offset: 0x002E4FA8
		public int GuideInstArrayLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BFEB RID: 49131 RVA: 0x002E6DD4 File Offset: 0x002E4FD4
		public Span<int> GetGuideInstArrayBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x0600BFEC RID: 49132 RVA: 0x002E6DE4 File Offset: 0x002E4FE4
		public int[] GetGuideInstArrayArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x0600BFED RID: 49133 RVA: 0x002E6DFC File Offset: 0x002E4FFC
		public int GuideInstRoleIdArray(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F7F RID: 12159
		// (get) Token: 0x0600BFEE RID: 49134 RVA: 0x002E6E3C File Offset: 0x002E503C
		public int GuideInstRoleIdArrayLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BFEF RID: 49135 RVA: 0x002E6E68 File Offset: 0x002E5068
		public Span<int> GetGuideInstRoleIdArrayBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x0600BFF0 RID: 49136 RVA: 0x002E6E78 File Offset: 0x002E5078
		public int[] GetGuideInstRoleIdArrayArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x0600BFF1 RID: 49137 RVA: 0x002E6E90 File Offset: 0x002E5090
		public int DungeonList(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F80 RID: 12160
		// (get) Token: 0x0600BFF2 RID: 49138 RVA: 0x002E6ED0 File Offset: 0x002E50D0
		public int DungeonListLength
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

		// Token: 0x0600BFF3 RID: 49139 RVA: 0x002E6EFC File Offset: 0x002E50FC
		public Span<int> GetDungeonListBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x0600BFF4 RID: 49140 RVA: 0x002E6F0C File Offset: 0x002E510C
		public int[] GetDungeonListArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x0600BFF5 RID: 49141 RVA: 0x002E6F24 File Offset: 0x002E5124
		public DicIntInt? ValidRoleOpenTimeMap(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002F81 RID: 12161
		// (get) Token: 0x0600BFF6 RID: 49142 RVA: 0x002E6F88 File Offset: 0x002E5188
		public int ValidRoleOpenTimeMapLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BFF7 RID: 49143 RVA: 0x002E6FB4 File Offset: 0x002E51B4
		public DicIntInt? DungeonRoleOpenTimeMap(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002F82 RID: 12162
		// (get) Token: 0x0600BFF8 RID: 49144 RVA: 0x002E7018 File Offset: 0x002E5218
		public int DungeonRoleOpenTimeMapLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002F83 RID: 12163
		// (get) Token: 0x0600BFF9 RID: 49145 RVA: 0x002E7044 File Offset: 0x002E5244
		public int BlackFlowerDropId
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BFFA RID: 49146 RVA: 0x002E7084 File Offset: 0x002E5284
		public int BlackFlowerInstList(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F84 RID: 12164
		// (get) Token: 0x0600BFFB RID: 49147 RVA: 0x002E70C4 File Offset: 0x002E52C4
		public int BlackFlowerInstListLength
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BFFC RID: 49148 RVA: 0x002E70F0 File Offset: 0x002E52F0
		public Span<int> GetBlackFlowerInstListBytes()
		{
			return this.__p.__vector_as_span<int>(48, 4);
		}

		// Token: 0x0600BFFD RID: 49149 RVA: 0x002E7100 File Offset: 0x002E5300
		public int[] GetBlackFlowerInstListArray()
		{
			return this.__p.__vector_as_array<int>(48) ?? Array.Empty<int>();
		}

		// Token: 0x0600BFFE RID: 49150 RVA: 0x002E7118 File Offset: 0x002E5318
		public int ElementList(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F85 RID: 12165
		// (get) Token: 0x0600BFFF RID: 49151 RVA: 0x002E7158 File Offset: 0x002E5358
		public int ElementListLength
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C000 RID: 49152 RVA: 0x002E7184 File Offset: 0x002E5384
		public Span<int> GetElementListBytes()
		{
			return this.__p.__vector_as_span<int>(50, 4);
		}

		// Token: 0x0600C001 RID: 49153 RVA: 0x002E7194 File Offset: 0x002E5394
		public int[] GetElementListArray()
		{
			return this.__p.__vector_as_array<int>(50) ?? Array.Empty<int>();
		}

		// Token: 0x0600C002 RID: 49154 RVA: 0x002E71AC File Offset: 0x002E53AC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BlackFlowerInstListIter()或GetBlackFlowerInstListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BlackFlowerInstList()
		{
			RogueParam rogueParam = this;
			return rogueParam.GetBlackFlowerInstListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C003 RID: 49155 RVA: 0x002E71D0 File Offset: 0x002E53D0
		[NullableContext(1)]
		public readonly IEnumerable<int> BlackFlowerInstListIter()
		{
			RogueParam.<BlackFlowerInstListIter>d__82 <BlackFlowerInstListIter>d__ = new RogueParam.<BlackFlowerInstListIter>d__82(-2);
			<BlackFlowerInstListIter>d__.<>3__<>4__this = this;
			return <BlackFlowerInstListIter>d__;
		}

		// Token: 0x0600C004 RID: 49156 RVA: 0x002E71E8 File Offset: 0x002E53E8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DungeonListIter()或GetDungeonListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DungeonList()
		{
			RogueParam rogueParam = this;
			return rogueParam.GetDungeonListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C005 RID: 49157 RVA: 0x002E720C File Offset: 0x002E540C
		[NullableContext(1)]
		public readonly IEnumerable<int> DungeonListIter()
		{
			RogueParam.<DungeonListIter>d__84 <DungeonListIter>d__ = new RogueParam.<DungeonListIter>d__84(-2);
			<DungeonListIter>d__.<>3__<>4__this = this;
			return <DungeonListIter>d__;
		}

		// Token: 0x0600C006 RID: 49158 RVA: 0x002E7224 File Offset: 0x002E5424
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DungeonRoleOpenTimeMapFrozenDict()缓存字典，遍历请使用DungeonRoleOpenTimeMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> DungeonRoleOpenTimeMap()
		{
			return this.DungeonRoleOpenTimeMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C007 RID: 49159 RVA: 0x002E727A File Offset: 0x002E547A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> DungeonRoleOpenTimeMapIter()
		{
			RogueParam.<DungeonRoleOpenTimeMapIter>d__86 <DungeonRoleOpenTimeMapIter>d__ = new RogueParam.<DungeonRoleOpenTimeMapIter>d__86(-2);
			<DungeonRoleOpenTimeMapIter>d__.<>3__<>4__this = this;
			return <DungeonRoleOpenTimeMapIter>d__;
		}

		// Token: 0x0600C008 RID: 49160 RVA: 0x002E7290 File Offset: 0x002E5490
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ElementListIter()或GetElementListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ElementList()
		{
			RogueParam rogueParam = this;
			return rogueParam.GetElementListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C009 RID: 49161 RVA: 0x002E72B4 File Offset: 0x002E54B4
		[NullableContext(1)]
		public readonly IEnumerable<int> ElementListIter()
		{
			RogueParam.<ElementListIter>d__88 <ElementListIter>d__ = new RogueParam.<ElementListIter>d__88(-2);
			<ElementListIter>d__.<>3__<>4__this = this;
			return <ElementListIter>d__;
		}

		// Token: 0x0600C00A RID: 49162 RVA: 0x002E72CC File Offset: 0x002E54CC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GuideInstArrayIter()或GetGuideInstArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GuideInstArray()
		{
			RogueParam rogueParam = this;
			return rogueParam.GetGuideInstArrayArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C00B RID: 49163 RVA: 0x002E72F0 File Offset: 0x002E54F0
		[NullableContext(1)]
		public readonly IEnumerable<int> GuideInstArrayIter()
		{
			RogueParam.<GuideInstArrayIter>d__90 <GuideInstArrayIter>d__ = new RogueParam.<GuideInstArrayIter>d__90(-2);
			<GuideInstArrayIter>d__.<>3__<>4__this = this;
			return <GuideInstArrayIter>d__;
		}

		// Token: 0x0600C00C RID: 49164 RVA: 0x002E7308 File Offset: 0x002E5508
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GuideInstRoleIdArrayIter()或GetGuideInstRoleIdArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GuideInstRoleIdArray()
		{
			RogueParam rogueParam = this;
			return rogueParam.GetGuideInstRoleIdArrayArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C00D RID: 49165 RVA: 0x002E732C File Offset: 0x002E552C
		[NullableContext(1)]
		public readonly IEnumerable<int> GuideInstRoleIdArrayIter()
		{
			RogueParam.<GuideInstRoleIdArrayIter>d__92 <GuideInstRoleIdArrayIter>d__ = new RogueParam.<GuideInstRoleIdArrayIter>d__92(-2);
			<GuideInstRoleIdArrayIter>d__.<>3__<>4__this = this;
			return <GuideInstRoleIdArrayIter>d__;
		}

		// Token: 0x0600C00E RID: 49166 RVA: 0x002E7344 File Offset: 0x002E5544
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ValidRoleOpenTimeMapFrozenDict()缓存字典，遍历请使用ValidRoleOpenTimeMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ValidRoleOpenTimeMap()
		{
			return this.ValidRoleOpenTimeMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C00F RID: 49167 RVA: 0x002E739A File Offset: 0x002E559A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ValidRoleOpenTimeMapIter()
		{
			RogueParam.<ValidRoleOpenTimeMapIter>d__94 <ValidRoleOpenTimeMapIter>d__ = new RogueParam.<ValidRoleOpenTimeMapIter>d__94(-2);
			<ValidRoleOpenTimeMapIter>d__.<>3__<>4__this = this;
			return <ValidRoleOpenTimeMapIter>d__;
		}

		// Token: 0x0600C010 RID: 49168 RVA: 0x002E73B0 File Offset: 0x002E55B0
		public int? GetDungeonRoleOpenTimeMap(int key)
		{
			this.EnsureDungeonRoleOpenTimeMapCacheIfNeeded();
			int value;
			if (!this.DungeonRoleOpenTimeMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C011 RID: 49169 RVA: 0x002E73E4 File Offset: 0x002E55E4
		public int? GetValidRoleOpenTimeMap(int key)
		{
			this.EnsureValidRoleOpenTimeMapCacheIfNeeded();
			int value;
			if (!this.ValidRoleOpenTimeMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C012 RID: 49170 RVA: 0x002E7418 File Offset: 0x002E5618
		private void EnsureDungeonRoleOpenTimeMapCacheIfNeeded()
		{
			if (this.DungeonRoleOpenTimeMapCache != null)
			{
				return;
			}
			this.DungeonRoleOpenTimeMapCache = this.DungeonRoleOpenTimeMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C013 RID: 49171 RVA: 0x002E7480 File Offset: 0x002E5680
		private void EnsureValidRoleOpenTimeMapCacheIfNeeded()
		{
			if (this.ValidRoleOpenTimeMapCache != null)
			{
				return;
			}
			this.ValidRoleOpenTimeMapCache = this.ValidRoleOpenTimeMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C014 RID: 49172 RVA: 0x002E74E6 File Offset: 0x002E56E6
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetDungeonRoleOpenTimeMapFrozenDict(int key)
		{
			this.EnsureDungeonRoleOpenTimeMapCacheIfNeeded();
			return this.DungeonRoleOpenTimeMapCache;
		}

		// Token: 0x0600C015 RID: 49173 RVA: 0x002E74F4 File Offset: 0x002E56F4
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetValidRoleOpenTimeMapFrozenDict(int key)
		{
			this.EnsureValidRoleOpenTimeMapCacheIfNeeded();
			return this.ValidRoleOpenTimeMapCache;
		}

		// Token: 0x040050C7 RID: 20679
		private Table __p;

		// Token: 0x040050C8 RID: 20680
		[Nullable(2)]
		private FrozenDictionary<int, int> DungeonRoleOpenTimeMapCache;

		// Token: 0x040050C9 RID: 20681
		[Nullable(2)]
		private FrozenDictionary<int, int> ValidRoleOpenTimeMapCache;
	}
}
