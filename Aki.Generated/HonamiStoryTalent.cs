using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E35 RID: 3637
	public struct HonamiStoryTalent : IFlatbufferObject
	{
		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x0600876A RID: 34666 RVA: 0x00278E40 File Offset: 0x00277040
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600876B RID: 34667 RVA: 0x00278E4D File Offset: 0x0027704D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600876C RID: 34668 RVA: 0x00278E54 File Offset: 0x00277054
		public static HonamiStoryTalent GetRootAsHonamiStoryTalent(ByteBuffer _bb)
		{
			return HonamiStoryTalent.GetRootAsHonamiStoryTalent(_bb, default(HonamiStoryTalent));
		}

		// Token: 0x0600876D RID: 34669 RVA: 0x00278E70 File Offset: 0x00277070
		public static HonamiStoryTalent GetRootAsHonamiStoryTalent(ByteBuffer _bb, HonamiStoryTalent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600876E RID: 34670 RVA: 0x00278E8D File Offset: 0x0027708D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600876F RID: 34671 RVA: 0x00278E9C File Offset: 0x0027709C
		public HonamiStoryTalent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x06008770 RID: 34672 RVA: 0x00278EAC File Offset: 0x002770AC
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

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x06008771 RID: 34673 RVA: 0x00278EE8 File Offset: 0x002770E8
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

		// Token: 0x06008772 RID: 34674 RVA: 0x00278F24 File Offset: 0x00277124
		public int PreId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x06008773 RID: 34675 RVA: 0x00278F64 File Offset: 0x00277164
		public int PreIdLength
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

		// Token: 0x06008774 RID: 34676 RVA: 0x00278F8F File Offset: 0x0027718F
		public Span<int> GetPreIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06008775 RID: 34677 RVA: 0x00278F9E File Offset: 0x0027719E
		public int[] GetPreIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06008776 RID: 34678 RVA: 0x00278FB8 File Offset: 0x002771B8
		public int EffectIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x06008777 RID: 34679 RVA: 0x00278FF8 File Offset: 0x002771F8
		public int EffectIdsLength
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

		// Token: 0x06008778 RID: 34680 RVA: 0x00279024 File Offset: 0x00277224
		public Span<int> GetEffectIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06008779 RID: 34681 RVA: 0x00279034 File Offset: 0x00277234
		public int[] GetEffectIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x0600877A RID: 34682 RVA: 0x0027904C File Offset: 0x0027724C
		public int Area
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x0600877B RID: 34683 RVA: 0x0027908C File Offset: 0x0027728C
		public int Type
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

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x0600877C RID: 34684 RVA: 0x002790CC File Offset: 0x002772CC
		public int IndexId
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

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x0600877D RID: 34685 RVA: 0x0027910C File Offset: 0x0027730C
		public int IndexSortId
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

		// Token: 0x0600877E RID: 34686 RVA: 0x0027914C File Offset: 0x0027734C
		public DicIntInt? ConsumeItems(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x0600877F RID: 34687 RVA: 0x002791B0 File Offset: 0x002773B0
		public int ConsumeItemsLength
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

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x06008780 RID: 34688 RVA: 0x002791DC File Offset: 0x002773DC
		public string Icon
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

		// Token: 0x06008781 RID: 34689 RVA: 0x00279214 File Offset: 0x00277414
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008782 RID: 34690 RVA: 0x00279224 File Offset: 0x00277424
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x06008783 RID: 34691 RVA: 0x0027923C File Offset: 0x0027743C
		public string GreyIcon
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

		// Token: 0x06008784 RID: 34692 RVA: 0x00279274 File Offset: 0x00277474
		public Span<byte> GetGreyIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06008785 RID: 34693 RVA: 0x00279284 File Offset: 0x00277484
		public byte[] GetGreyIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x06008786 RID: 34694 RVA: 0x0027929C File Offset: 0x0027749C
		public string Name
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

		// Token: 0x06008787 RID: 34695 RVA: 0x002792D4 File Offset: 0x002774D4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06008788 RID: 34696 RVA: 0x002792E4 File Offset: 0x002774E4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x06008789 RID: 34697 RVA: 0x002792FC File Offset: 0x002774FC
		public string Desc
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

		// Token: 0x0600878A RID: 34698 RVA: 0x00279334 File Offset: 0x00277534
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600878B RID: 34699 RVA: 0x00279344 File Offset: 0x00277544
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x0600878C RID: 34700 RVA: 0x0027935C File Offset: 0x0027755C
		public string MidTitle
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

		// Token: 0x0600878D RID: 34701 RVA: 0x00279394 File Offset: 0x00277594
		public Span<byte> GetMidTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600878E RID: 34702 RVA: 0x002793A4 File Offset: 0x002775A4
		public byte[] GetMidTitleArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x0600878F RID: 34703 RVA: 0x002793BC File Offset: 0x002775BC
		public string MidDexc
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

		// Token: 0x06008790 RID: 34704 RVA: 0x002793F4 File Offset: 0x002775F4
		public Span<byte> GetMidDexcBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06008791 RID: 34705 RVA: 0x00279404 File Offset: 0x00277604
		public byte[] GetMidDexcArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x06008792 RID: 34706 RVA: 0x0027941C File Offset: 0x0027761C
		public string LockPopTip
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

		// Token: 0x06008793 RID: 34707 RVA: 0x00279454 File Offset: 0x00277654
		public Span<byte> GetLockPopTipBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06008794 RID: 34708 RVA: 0x00279464 File Offset: 0x00277664
		public byte[] GetLockPopTipArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x06008795 RID: 34709 RVA: 0x0027947C File Offset: 0x0027767C
		public string LockPanelTip
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

		// Token: 0x06008796 RID: 34710 RVA: 0x002794B4 File Offset: 0x002776B4
		public Span<byte> GetLockPanelTipBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06008797 RID: 34711 RVA: 0x002794C4 File Offset: 0x002776C4
		public byte[] GetLockPanelTipArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x06008798 RID: 34712 RVA: 0x002794DC File Offset: 0x002776DC
		public string SuccessTitle
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

		// Token: 0x06008799 RID: 34713 RVA: 0x00279514 File Offset: 0x00277714
		public Span<byte> GetSuccessTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600879A RID: 34714 RVA: 0x00279524 File Offset: 0x00277724
		public byte[] GetSuccessTitleArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x0600879B RID: 34715 RVA: 0x0027953C File Offset: 0x0027773C
		public string SuccessDesc
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600879C RID: 34716 RVA: 0x00279574 File Offset: 0x00277774
		public Span<byte> GetSuccessDescBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600879D RID: 34717 RVA: 0x00279584 File Offset: 0x00277784
		public byte[] GetSuccessDescArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x0600879E RID: 34718 RVA: 0x0027959C File Offset: 0x0027779C
		public string SuccessDescParams(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x0600879F RID: 34719 RVA: 0x002795D8 File Offset: 0x002777D8
		public int SuccessDescParamsLength
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

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x060087A0 RID: 34720 RVA: 0x00279604 File Offset: 0x00277804
		public string FlowListName
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060087A1 RID: 34721 RVA: 0x0027963C File Offset: 0x0027783C
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x060087A2 RID: 34722 RVA: 0x0027964C File Offset: 0x0027784C
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x060087A3 RID: 34723 RVA: 0x00279664 File Offset: 0x00277864
		public int FlowId
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

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x060087A4 RID: 34724 RVA: 0x002796A4 File Offset: 0x002778A4
		public int StateId
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

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x060087A5 RID: 34725 RVA: 0x002796E4 File Offset: 0x002778E4
		public string BoZaiTalk
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060087A6 RID: 34726 RVA: 0x0027971C File Offset: 0x0027791C
		public Span<byte> GetBoZaiTalkBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x060087A7 RID: 34727 RVA: 0x0027972C File Offset: 0x0027792C
		public byte[] GetBoZaiTalkArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x060087A8 RID: 34728 RVA: 0x00279744 File Offset: 0x00277944
		[NullableContext(1)]
		public Dictionary<int, int> ConsumeItems()
		{
			return this.ConsumeItemsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060087A9 RID: 34729 RVA: 0x0027979A File Offset: 0x0027799A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ConsumeItemsIter()
		{
			HonamiStoryTalent.<ConsumeItemsIter>d__89 <ConsumeItemsIter>d__ = new HonamiStoryTalent.<ConsumeItemsIter>d__89(-2);
			<ConsumeItemsIter>d__.<>3__<>4__this = this;
			return <ConsumeItemsIter>d__;
		}

		// Token: 0x060087AA RID: 34730 RVA: 0x002797AF File Offset: 0x002779AF
		[NullableContext(1)]
		public int[] EffectIds()
		{
			return this.GetEffectIdsArray();
		}

		// Token: 0x060087AB RID: 34731 RVA: 0x002797B7 File Offset: 0x002779B7
		[NullableContext(1)]
		public IEnumerable<int> EffectIdsIter()
		{
			HonamiStoryTalent.<EffectIdsIter>d__91 <EffectIdsIter>d__ = new HonamiStoryTalent.<EffectIdsIter>d__91(-2);
			<EffectIdsIter>d__.<>3__<>4__this = this;
			return <EffectIdsIter>d__;
		}

		// Token: 0x060087AC RID: 34732 RVA: 0x002797CC File Offset: 0x002779CC
		[NullableContext(1)]
		public int[] PreId()
		{
			return this.GetPreIdArray();
		}

		// Token: 0x060087AD RID: 34733 RVA: 0x002797D4 File Offset: 0x002779D4
		[NullableContext(1)]
		public IEnumerable<int> PreIdIter()
		{
			HonamiStoryTalent.<PreIdIter>d__93 <PreIdIter>d__ = new HonamiStoryTalent.<PreIdIter>d__93(-2);
			<PreIdIter>d__.<>3__<>4__this = this;
			return <PreIdIter>d__;
		}

		// Token: 0x060087AE RID: 34734 RVA: 0x002797E9 File Offset: 0x002779E9
		[NullableContext(1)]
		public string[] SuccessDescParams()
		{
			return this.SuccessDescParamsIter().ToArray<string>();
		}

		// Token: 0x060087AF RID: 34735 RVA: 0x002797F6 File Offset: 0x002779F6
		[NullableContext(1)]
		public IEnumerable<string> SuccessDescParamsIter()
		{
			HonamiStoryTalent.<SuccessDescParamsIter>d__95 <SuccessDescParamsIter>d__ = new HonamiStoryTalent.<SuccessDescParamsIter>d__95(-2);
			<SuccessDescParamsIter>d__.<>3__<>4__this = this;
			return <SuccessDescParamsIter>d__;
		}

		// Token: 0x060087B0 RID: 34736 RVA: 0x0027980C File Offset: 0x00277A0C
		public int? GetConsumeItems(int key)
		{
			this.EnsureConsumeItemsCacheIfNeeded();
			int value;
			if (!this.ConsumeItemsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060087B1 RID: 34737 RVA: 0x00279840 File Offset: 0x00277A40
		private void EnsureConsumeItemsCacheIfNeeded()
		{
			if (this.ConsumeItemsCache != null)
			{
				return;
			}
			this.ConsumeItemsCache = this.ConsumeItemsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060087B2 RID: 34738 RVA: 0x002798A6 File Offset: 0x00277AA6
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetConsumeItemsFrozenDict()
		{
			this.EnsureConsumeItemsCacheIfNeeded();
			return this.ConsumeItemsCache;
		}

		// Token: 0x040053B2 RID: 21426
		private Table __p;

		// Token: 0x040053B3 RID: 21427
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeItemsCache;
	}
}
