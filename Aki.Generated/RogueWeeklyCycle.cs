using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200102C RID: 4140
	public struct RogueWeeklyCycle : IFlatbufferObject
	{
		// Token: 0x17003173 RID: 12659
		// (get) Token: 0x0600C5E7 RID: 50663 RVA: 0x002F4161 File Offset: 0x002F2361
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C5E8 RID: 50664 RVA: 0x002F416E File Offset: 0x002F236E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C5E9 RID: 50665 RVA: 0x002F4178 File Offset: 0x002F2378
		public static RogueWeeklyCycle GetRootAsRogueWeeklyCycle(ByteBuffer _bb)
		{
			return RogueWeeklyCycle.GetRootAsRogueWeeklyCycle(_bb, default(RogueWeeklyCycle));
		}

		// Token: 0x0600C5EA RID: 50666 RVA: 0x002F4194 File Offset: 0x002F2394
		public static RogueWeeklyCycle GetRootAsRogueWeeklyCycle(ByteBuffer _bb, RogueWeeklyCycle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C5EB RID: 50667 RVA: 0x002F41B1 File Offset: 0x002F23B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C5EC RID: 50668 RVA: 0x002F41C0 File Offset: 0x002F23C0
		public RogueWeeklyCycle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003174 RID: 12660
		// (get) Token: 0x0600C5ED RID: 50669 RVA: 0x002F41D0 File Offset: 0x002F23D0
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

		// Token: 0x17003175 RID: 12661
		// (get) Token: 0x0600C5EE RID: 50670 RVA: 0x002F420C File Offset: 0x002F240C
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

		// Token: 0x17003176 RID: 12662
		// (get) Token: 0x0600C5EF RID: 50671 RVA: 0x002F4248 File Offset: 0x002F2448
		public int LoopId
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

		// Token: 0x17003177 RID: 12663
		// (get) Token: 0x0600C5F0 RID: 50672 RVA: 0x002F4284 File Offset: 0x002F2484
		public int TimeId
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

		// Token: 0x0600C5F1 RID: 50673 RVA: 0x002F42C4 File Offset: 0x002F24C4
		public DicIntInt? Diff(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003178 RID: 12664
		// (get) Token: 0x0600C5F2 RID: 50674 RVA: 0x002F4328 File Offset: 0x002F2528
		public int DiffLength
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

		// Token: 0x17003179 RID: 12665
		// (get) Token: 0x0600C5F3 RID: 50675 RVA: 0x002F4354 File Offset: 0x002F2554
		public int MapMark
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

		// Token: 0x1700317A RID: 12666
		// (get) Token: 0x0600C5F4 RID: 50676 RVA: 0x002F4394 File Offset: 0x002F2594
		public int QuestId
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

		// Token: 0x1700317B RID: 12667
		// (get) Token: 0x0600C5F5 RID: 50677 RVA: 0x002F43D4 File Offset: 0x002F25D4
		public int EntranceId
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

		// Token: 0x1700317C RID: 12668
		// (get) Token: 0x0600C5F6 RID: 50678 RVA: 0x002F4414 File Offset: 0x002F2614
		public int InstId
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

		// Token: 0x0600C5F7 RID: 50679 RVA: 0x002F4454 File Offset: 0x002F2654
		public int RecommendedRole(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700317D RID: 12669
		// (get) Token: 0x0600C5F8 RID: 50680 RVA: 0x002F4494 File Offset: 0x002F2694
		public int RecommendedRoleLength
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

		// Token: 0x0600C5F9 RID: 50681 RVA: 0x002F44C0 File Offset: 0x002F26C0
		public Span<int> GetRecommendedRoleBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600C5FA RID: 50682 RVA: 0x002F44D0 File Offset: 0x002F26D0
		public int[] GetRecommendedRoleArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x1700317E RID: 12670
		// (get) Token: 0x0600C5FB RID: 50683 RVA: 0x002F44E8 File Offset: 0x002F26E8
		public int ScoreRate
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

		// Token: 0x1700317F RID: 12671
		// (get) Token: 0x0600C5FC RID: 50684 RVA: 0x002F4528 File Offset: 0x002F2728
		public string RoguelikeRoomFloatTipsSpecialIcon
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

		// Token: 0x0600C5FD RID: 50685 RVA: 0x002F4560 File Offset: 0x002F2760
		public Span<byte> GetRoguelikeRoomFloatTipsSpecialIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600C5FE RID: 50686 RVA: 0x002F4570 File Offset: 0x002F2770
		public byte[] GetRoguelikeRoomFloatTipsSpecialIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C5FF RID: 50687 RVA: 0x002F4588 File Offset: 0x002F2788
		public DicIntInt? BlackFlowerCost(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003180 RID: 12672
		// (get) Token: 0x0600C600 RID: 50688 RVA: 0x002F45EC File Offset: 0x002F27EC
		public int BlackFlowerCostLength
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

		// Token: 0x17003181 RID: 12673
		// (get) Token: 0x0600C601 RID: 50689 RVA: 0x002F4618 File Offset: 0x002F2818
		public int BlackFlowerAward
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

		// Token: 0x17003182 RID: 12674
		// (get) Token: 0x0600C602 RID: 50690 RVA: 0x002F4658 File Offset: 0x002F2858
		public int GoldItemId
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

		// Token: 0x17003183 RID: 12675
		// (get) Token: 0x0600C603 RID: 50691 RVA: 0x002F4698 File Offset: 0x002F2898
		public string CycleName
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C604 RID: 50692 RVA: 0x002F46D0 File Offset: 0x002F28D0
		public Span<byte> GetCycleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600C605 RID: 50693 RVA: 0x002F46E0 File Offset: 0x002F28E0
		public byte[] GetCycleNameArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17003184 RID: 12676
		// (get) Token: 0x0600C606 RID: 50694 RVA: 0x002F46F8 File Offset: 0x002F28F8
		public string ViewBackground
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C607 RID: 50695 RVA: 0x002F4730 File Offset: 0x002F2930
		public Span<byte> GetViewBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600C608 RID: 50696 RVA: 0x002F4740 File Offset: 0x002F2940
		public byte[] GetViewBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17003185 RID: 12677
		// (get) Token: 0x0600C609 RID: 50697 RVA: 0x002F4758 File Offset: 0x002F2958
		public string BuffIcon
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

		// Token: 0x0600C60A RID: 50698 RVA: 0x002F4790 File Offset: 0x002F2990
		public Span<byte> GetBuffIconBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600C60B RID: 50699 RVA: 0x002F47A0 File Offset: 0x002F29A0
		public byte[] GetBuffIconArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17003186 RID: 12678
		// (get) Token: 0x0600C60C RID: 50700 RVA: 0x002F47B8 File Offset: 0x002F29B8
		public int BuffPR
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003187 RID: 12679
		// (get) Token: 0x0600C60D RID: 50701 RVA: 0x002F47F8 File Offset: 0x002F29F8
		public string BuffDesc
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C60E RID: 50702 RVA: 0x002F4830 File Offset: 0x002F2A30
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600C60F RID: 50703 RVA: 0x002F4840 File Offset: 0x002F2A40
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C610 RID: 50704 RVA: 0x002F4858 File Offset: 0x002F2A58
		public string BuffDescParam(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003188 RID: 12680
		// (get) Token: 0x0600C611 RID: 50705 RVA: 0x002F4894 File Offset: 0x002F2A94
		public int BuffDescParamLength
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

		// Token: 0x17003189 RID: 12681
		// (get) Token: 0x0600C612 RID: 50706 RVA: 0x002F48C0 File Offset: 0x002F2AC0
		public int HelpId
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

		// Token: 0x1700318A RID: 12682
		// (get) Token: 0x0600C613 RID: 50707 RVA: 0x002F4900 File Offset: 0x002F2B00
		public int BlackFlowerHelpId
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700318B RID: 12683
		// (get) Token: 0x0600C614 RID: 50708 RVA: 0x002F4940 File Offset: 0x002F2B40
		public int BaseScore
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 4000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700318C RID: 12684
		// (get) Token: 0x0600C615 RID: 50709 RVA: 0x002F4984 File Offset: 0x002F2B84
		public int MaxScore
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700318D RID: 12685
		// (get) Token: 0x0600C616 RID: 50710 RVA: 0x002F49C4 File Offset: 0x002F2BC4
		public int LinkId
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C617 RID: 50711 RVA: 0x002F4A04 File Offset: 0x002F2C04
		public DicIntLong54? BattleBuffIdMap(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return null;
			}
			return new DicIntLong54?(default(DicIntLong54).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700318E RID: 12686
		// (get) Token: 0x0600C618 RID: 50712 RVA: 0x002F4A68 File Offset: 0x002F2C68
		public int BattleBuffIdMapLength
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700318F RID: 12687
		// (get) Token: 0x0600C619 RID: 50713 RVA: 0x002F4A94 File Offset: 0x002F2C94
		public long BattleBuffId
		{
			get
			{
				int num = this.__p.__offset(58);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x0600C61A RID: 50714 RVA: 0x002F4ADC File Offset: 0x002F2CDC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用BattleBuffIdMapFrozenDict()缓存字典，遍历请使用BattleBuffIdMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, long> BattleBuffIdMap()
		{
			return this.BattleBuffIdMapIter().ToDictionary((DicIntLong54 element) => element.Key, (DicIntLong54 element) => element.Value);
		}

		// Token: 0x0600C61B RID: 50715 RVA: 0x002F4B32 File Offset: 0x002F2D32
		[NullableContext(1)]
		public readonly IEnumerable<DicIntLong54> BattleBuffIdMapIter()
		{
			RogueWeeklyCycle.<BattleBuffIdMapIter>d__82 <BattleBuffIdMapIter>d__ = new RogueWeeklyCycle.<BattleBuffIdMapIter>d__82(-2);
			<BattleBuffIdMapIter>d__.<>3__<>4__this = this;
			return <BattleBuffIdMapIter>d__;
		}

		// Token: 0x0600C61C RID: 50716 RVA: 0x002F4B48 File Offset: 0x002F2D48
		[NullableContext(1)]
		[Obsolete("已废弃，请使用BlackFlowerCostFrozenDict()缓存字典，遍历请使用BlackFlowerCostIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> BlackFlowerCost()
		{
			return this.BlackFlowerCostIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C61D RID: 50717 RVA: 0x002F4B9E File Offset: 0x002F2D9E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> BlackFlowerCostIter()
		{
			RogueWeeklyCycle.<BlackFlowerCostIter>d__84 <BlackFlowerCostIter>d__ = new RogueWeeklyCycle.<BlackFlowerCostIter>d__84(-2);
			<BlackFlowerCostIter>d__.<>3__<>4__this = this;
			return <BlackFlowerCostIter>d__;
		}

		// Token: 0x0600C61E RID: 50718 RVA: 0x002F4BB3 File Offset: 0x002F2DB3
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffDescParamIter()或GetBuffDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BuffDescParam()
		{
			return this.BuffDescParamIter().ToArray<string>();
		}

		// Token: 0x0600C61F RID: 50719 RVA: 0x002F4BC0 File Offset: 0x002F2DC0
		[NullableContext(1)]
		public readonly IEnumerable<string> BuffDescParamIter()
		{
			RogueWeeklyCycle.<BuffDescParamIter>d__86 <BuffDescParamIter>d__ = new RogueWeeklyCycle.<BuffDescParamIter>d__86(-2);
			<BuffDescParamIter>d__.<>3__<>4__this = this;
			return <BuffDescParamIter>d__;
		}

		// Token: 0x0600C620 RID: 50720 RVA: 0x002F4BD8 File Offset: 0x002F2DD8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DiffFrozenDict()缓存字典，遍历请使用DiffIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Diff()
		{
			return this.DiffIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C621 RID: 50721 RVA: 0x002F4C2E File Offset: 0x002F2E2E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> DiffIter()
		{
			RogueWeeklyCycle.<DiffIter>d__88 <DiffIter>d__ = new RogueWeeklyCycle.<DiffIter>d__88(-2);
			<DiffIter>d__.<>3__<>4__this = this;
			return <DiffIter>d__;
		}

		// Token: 0x0600C622 RID: 50722 RVA: 0x002F4C44 File Offset: 0x002F2E44
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendedRoleIter()或GetRecommendedRoleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendedRole()
		{
			RogueWeeklyCycle rogueWeeklyCycle = this;
			return rogueWeeklyCycle.GetRecommendedRoleArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C623 RID: 50723 RVA: 0x002F4C68 File Offset: 0x002F2E68
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendedRoleIter()
		{
			RogueWeeklyCycle.<RecommendedRoleIter>d__90 <RecommendedRoleIter>d__ = new RogueWeeklyCycle.<RecommendedRoleIter>d__90(-2);
			<RecommendedRoleIter>d__.<>3__<>4__this = this;
			return <RecommendedRoleIter>d__;
		}

		// Token: 0x0600C624 RID: 50724 RVA: 0x002F4C80 File Offset: 0x002F2E80
		public long? GetBattleBuffIdMap(int key)
		{
			this.EnsureBattleBuffIdMapCacheIfNeeded();
			long value;
			if (!this.BattleBuffIdMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new long?(value);
		}

		// Token: 0x0600C625 RID: 50725 RVA: 0x002F4CB4 File Offset: 0x002F2EB4
		public int? GetBlackFlowerCost(int key)
		{
			this.EnsureBlackFlowerCostCacheIfNeeded();
			int value;
			if (!this.BlackFlowerCostCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C626 RID: 50726 RVA: 0x002F4CE8 File Offset: 0x002F2EE8
		public int? GetDiff(int key)
		{
			this.EnsureDiffCacheIfNeeded();
			int value;
			if (!this.DiffCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C627 RID: 50727 RVA: 0x002F4D1C File Offset: 0x002F2F1C
		private void EnsureBattleBuffIdMapCacheIfNeeded()
		{
			if (this.BattleBuffIdMapCache != null)
			{
				return;
			}
			this.BattleBuffIdMapCache = this.BattleBuffIdMapIter().ToFrozenDictionary((DicIntLong54 kvp) => kvp.Key, (DicIntLong54 kvp) => kvp.Value, null);
		}

		// Token: 0x0600C628 RID: 50728 RVA: 0x002F4D84 File Offset: 0x002F2F84
		private void EnsureBlackFlowerCostCacheIfNeeded()
		{
			if (this.BlackFlowerCostCache != null)
			{
				return;
			}
			this.BlackFlowerCostCache = this.BlackFlowerCostIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C629 RID: 50729 RVA: 0x002F4DEC File Offset: 0x002F2FEC
		private void EnsureDiffCacheIfNeeded()
		{
			if (this.DiffCache != null)
			{
				return;
			}
			this.DiffCache = this.DiffIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C62A RID: 50730 RVA: 0x002F4E52 File Offset: 0x002F3052
		[NullableContext(2)]
		public FrozenDictionary<int, long> GetBattleBuffIdMapFrozenDict(int key)
		{
			this.EnsureBattleBuffIdMapCacheIfNeeded();
			return this.BattleBuffIdMapCache;
		}

		// Token: 0x0600C62B RID: 50731 RVA: 0x002F4E60 File Offset: 0x002F3060
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetBlackFlowerCostFrozenDict(int key)
		{
			this.EnsureBlackFlowerCostCacheIfNeeded();
			return this.BlackFlowerCostCache;
		}

		// Token: 0x0600C62C RID: 50732 RVA: 0x002F4E6E File Offset: 0x002F306E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetDiffFrozenDict(int key)
		{
			this.EnsureDiffCacheIfNeeded();
			return this.DiffCache;
		}

		// Token: 0x0400511F RID: 20767
		private Table __p;

		// Token: 0x04005120 RID: 20768
		[Nullable(2)]
		private FrozenDictionary<int, long> BattleBuffIdMapCache;

		// Token: 0x04005121 RID: 20769
		[Nullable(2)]
		private FrozenDictionary<int, int> BlackFlowerCostCache;

		// Token: 0x04005122 RID: 20770
		[Nullable(2)]
		private FrozenDictionary<int, int> DiffCache;
	}
}
