using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E37 RID: 3639
	public struct HonamiStoryWeapon : IFlatbufferObject
	{
		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x060087BD RID: 34749 RVA: 0x00279A11 File Offset: 0x00277C11
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060087BE RID: 34750 RVA: 0x00279A1E File Offset: 0x00277C1E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060087BF RID: 34751 RVA: 0x00279A28 File Offset: 0x00277C28
		public static HonamiStoryWeapon GetRootAsHonamiStoryWeapon(ByteBuffer _bb)
		{
			return HonamiStoryWeapon.GetRootAsHonamiStoryWeapon(_bb, default(HonamiStoryWeapon));
		}

		// Token: 0x060087C0 RID: 34752 RVA: 0x00279A44 File Offset: 0x00277C44
		public static HonamiStoryWeapon GetRootAsHonamiStoryWeapon(ByteBuffer _bb, HonamiStoryWeapon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060087C1 RID: 34753 RVA: 0x00279A61 File Offset: 0x00277C61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060087C2 RID: 34754 RVA: 0x00279A70 File Offset: 0x00277C70
		public HonamiStoryWeapon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x060087C3 RID: 34755 RVA: 0x00279A80 File Offset: 0x00277C80
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

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x060087C4 RID: 34756 RVA: 0x00279ABC File Offset: 0x00277CBC
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

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x060087C5 RID: 34757 RVA: 0x00279AF8 File Offset: 0x00277CF8
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x060087C6 RID: 34758 RVA: 0x00279B34 File Offset: 0x00277D34
		public int PropLibraryId
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

		// Token: 0x060087C7 RID: 34759 RVA: 0x00279B74 File Offset: 0x00277D74
		public int BuffTempId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x060087C8 RID: 34760 RVA: 0x00279BB4 File Offset: 0x00277DB4
		public int BuffTempIdLength
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

		// Token: 0x060087C9 RID: 34761 RVA: 0x00279BE0 File Offset: 0x00277DE0
		public Span<int> GetBuffTempIdBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060087CA RID: 34762 RVA: 0x00279BF0 File Offset: 0x00277DF0
		public int[] GetBuffTempIdArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x060087CB RID: 34763 RVA: 0x00279C08 File Offset: 0x00277E08
		public int SuitId(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x060087CC RID: 34764 RVA: 0x00279C48 File Offset: 0x00277E48
		public int SuitIdLength
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

		// Token: 0x060087CD RID: 34765 RVA: 0x00279C74 File Offset: 0x00277E74
		public Span<int> GetSuitIdBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060087CE RID: 34766 RVA: 0x00279C84 File Offset: 0x00277E84
		public int[] GetSuitIdArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x060087CF RID: 34767 RVA: 0x00279C9C File Offset: 0x00277E9C
		public int PhantomItemId
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

		// Token: 0x060087D0 RID: 34768 RVA: 0x00279CDC File Offset: 0x00277EDC
		public DicIntInt? ExtraSuitAddEnhanceLevel(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170018C7 RID: 6343
		// (get) Token: 0x060087D1 RID: 34769 RVA: 0x00279D40 File Offset: 0x00277F40
		public int ExtraSuitAddEnhanceLevelLength
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

		// Token: 0x060087D2 RID: 34770 RVA: 0x00279D6C File Offset: 0x00277F6C
		public int PluginTags(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x060087D3 RID: 34771 RVA: 0x00279DAC File Offset: 0x00277FAC
		public int PluginTagsLength
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

		// Token: 0x060087D4 RID: 34772 RVA: 0x00279DD8 File Offset: 0x00277FD8
		public Span<int> GetPluginTagsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x060087D5 RID: 34773 RVA: 0x00279DE8 File Offset: 0x00277FE8
		public int[] GetPluginTagsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x060087D6 RID: 34774 RVA: 0x00279E00 File Offset: 0x00278000
		public string AttributesDescription
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

		// Token: 0x060087D7 RID: 34775 RVA: 0x00279E38 File Offset: 0x00278038
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060087D8 RID: 34776 RVA: 0x00279E48 File Offset: 0x00278048
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x060087D9 RID: 34777 RVA: 0x00279E60 File Offset: 0x00278060
		public string AttributesDescriptionArgs(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x060087DA RID: 34778 RVA: 0x00279E9C File Offset: 0x0027809C
		public int AttributesDescriptionArgsLength
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

		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x060087DB RID: 34779 RVA: 0x00279EC8 File Offset: 0x002780C8
		public string AttributesDescriptionSimple
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

		// Token: 0x060087DC RID: 34780 RVA: 0x00279F00 File Offset: 0x00278100
		public Span<byte> GetAttributesDescriptionSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060087DD RID: 34781 RVA: 0x00279F10 File Offset: 0x00278110
		public byte[] GetAttributesDescriptionSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x060087DE RID: 34782 RVA: 0x00279F28 File Offset: 0x00278128
		public string AttributesDescriptionSimpleArgs(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x060087DF RID: 34783 RVA: 0x00279F64 File Offset: 0x00278164
		public int AttributesDescriptionSimpleArgsLength
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

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x060087E0 RID: 34784 RVA: 0x00279F90 File Offset: 0x00278190
		public string Icon
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

		// Token: 0x060087E1 RID: 34785 RVA: 0x00279FC8 File Offset: 0x002781C8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060087E2 RID: 34786 RVA: 0x00279FD8 File Offset: 0x002781D8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x060087E3 RID: 34787 RVA: 0x00279FF0 File Offset: 0x002781F0
		public string IconToggle
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

		// Token: 0x060087E4 RID: 34788 RVA: 0x0027A028 File Offset: 0x00278228
		public Span<byte> GetIconToggleBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x060087E5 RID: 34789 RVA: 0x0027A038 File Offset: 0x00278238
		public byte[] GetIconToggleArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x060087E6 RID: 34790 RVA: 0x0027A050 File Offset: 0x00278250
		public int Type
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

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x060087E7 RID: 34791 RVA: 0x0027A090 File Offset: 0x00278290
		public string Name
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

		// Token: 0x060087E8 RID: 34792 RVA: 0x0027A0C8 File Offset: 0x002782C8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x060087E9 RID: 34793 RVA: 0x0027A0D8 File Offset: 0x002782D8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x060087EA RID: 34794 RVA: 0x0027A0F0 File Offset: 0x002782F0
		public string GetWayDes
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

		// Token: 0x060087EB RID: 34795 RVA: 0x0027A128 File Offset: 0x00278328
		public Span<byte> GetGetWayDesBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x060087EC RID: 34796 RVA: 0x0027A138 File Offset: 0x00278338
		public byte[] GetGetWayDesArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x060087ED RID: 34797 RVA: 0x0027A150 File Offset: 0x00278350
		public string LockDescription
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

		// Token: 0x060087EE RID: 34798 RVA: 0x0027A188 File Offset: 0x00278388
		public Span<byte> GetLockDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x060087EF RID: 34799 RVA: 0x0027A198 File Offset: 0x00278398
		public byte[] GetLockDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x060087F0 RID: 34800 RVA: 0x0027A1B0 File Offset: 0x002783B0
		public bool IsShowReward
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x060087F1 RID: 34801 RVA: 0x0027A1F0 File Offset: 0x002783F0
		public string TypeDescription
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

		// Token: 0x060087F2 RID: 34802 RVA: 0x0027A228 File Offset: 0x00278428
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x060087F3 RID: 34803 RVA: 0x0027A238 File Offset: 0x00278438
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x060087F4 RID: 34804 RVA: 0x0027A250 File Offset: 0x00278450
		[NullableContext(1)]
		public string[] AttributesDescriptionArgs()
		{
			return this.AttributesDescriptionArgsIter().ToArray<string>();
		}

		// Token: 0x060087F5 RID: 34805 RVA: 0x0027A25D File Offset: 0x0027845D
		[NullableContext(1)]
		public IEnumerable<string> AttributesDescriptionArgsIter()
		{
			HonamiStoryWeapon.<AttributesDescriptionArgsIter>d__79 <AttributesDescriptionArgsIter>d__ = new HonamiStoryWeapon.<AttributesDescriptionArgsIter>d__79(-2);
			<AttributesDescriptionArgsIter>d__.<>3__<>4__this = this;
			return <AttributesDescriptionArgsIter>d__;
		}

		// Token: 0x060087F6 RID: 34806 RVA: 0x0027A272 File Offset: 0x00278472
		[NullableContext(1)]
		public string[] AttributesDescriptionSimpleArgs()
		{
			return this.AttributesDescriptionSimpleArgsIter().ToArray<string>();
		}

		// Token: 0x060087F7 RID: 34807 RVA: 0x0027A27F File Offset: 0x0027847F
		[NullableContext(1)]
		public IEnumerable<string> AttributesDescriptionSimpleArgsIter()
		{
			HonamiStoryWeapon.<AttributesDescriptionSimpleArgsIter>d__81 <AttributesDescriptionSimpleArgsIter>d__ = new HonamiStoryWeapon.<AttributesDescriptionSimpleArgsIter>d__81(-2);
			<AttributesDescriptionSimpleArgsIter>d__.<>3__<>4__this = this;
			return <AttributesDescriptionSimpleArgsIter>d__;
		}

		// Token: 0x060087F8 RID: 34808 RVA: 0x0027A294 File Offset: 0x00278494
		[NullableContext(1)]
		public int[] BuffTempId()
		{
			return this.GetBuffTempIdArray();
		}

		// Token: 0x060087F9 RID: 34809 RVA: 0x0027A29C File Offset: 0x0027849C
		[NullableContext(1)]
		public IEnumerable<int> BuffTempIdIter()
		{
			HonamiStoryWeapon.<BuffTempIdIter>d__83 <BuffTempIdIter>d__ = new HonamiStoryWeapon.<BuffTempIdIter>d__83(-2);
			<BuffTempIdIter>d__.<>3__<>4__this = this;
			return <BuffTempIdIter>d__;
		}

		// Token: 0x060087FA RID: 34810 RVA: 0x0027A2B4 File Offset: 0x002784B4
		[NullableContext(1)]
		public Dictionary<int, int> ExtraSuitAddEnhanceLevel()
		{
			return this.ExtraSuitAddEnhanceLevelIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060087FB RID: 34811 RVA: 0x0027A30A File Offset: 0x0027850A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ExtraSuitAddEnhanceLevelIter()
		{
			HonamiStoryWeapon.<ExtraSuitAddEnhanceLevelIter>d__85 <ExtraSuitAddEnhanceLevelIter>d__ = new HonamiStoryWeapon.<ExtraSuitAddEnhanceLevelIter>d__85(-2);
			<ExtraSuitAddEnhanceLevelIter>d__.<>3__<>4__this = this;
			return <ExtraSuitAddEnhanceLevelIter>d__;
		}

		// Token: 0x060087FC RID: 34812 RVA: 0x0027A31F File Offset: 0x0027851F
		[NullableContext(1)]
		public int[] PluginTags()
		{
			return this.GetPluginTagsArray();
		}

		// Token: 0x060087FD RID: 34813 RVA: 0x0027A327 File Offset: 0x00278527
		[NullableContext(1)]
		public IEnumerable<int> PluginTagsIter()
		{
			HonamiStoryWeapon.<PluginTagsIter>d__87 <PluginTagsIter>d__ = new HonamiStoryWeapon.<PluginTagsIter>d__87(-2);
			<PluginTagsIter>d__.<>3__<>4__this = this;
			return <PluginTagsIter>d__;
		}

		// Token: 0x060087FE RID: 34814 RVA: 0x0027A33C File Offset: 0x0027853C
		[NullableContext(1)]
		public int[] SuitId()
		{
			return this.GetSuitIdArray();
		}

		// Token: 0x060087FF RID: 34815 RVA: 0x0027A344 File Offset: 0x00278544
		[NullableContext(1)]
		public IEnumerable<int> SuitIdIter()
		{
			HonamiStoryWeapon.<SuitIdIter>d__89 <SuitIdIter>d__ = new HonamiStoryWeapon.<SuitIdIter>d__89(-2);
			<SuitIdIter>d__.<>3__<>4__this = this;
			return <SuitIdIter>d__;
		}

		// Token: 0x06008800 RID: 34816 RVA: 0x0027A35C File Offset: 0x0027855C
		public int? GetExtraSuitAddEnhanceLevel(int key)
		{
			this.EnsureExtraSuitAddEnhanceLevelCacheIfNeeded();
			int value;
			if (!this.ExtraSuitAddEnhanceLevelCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06008801 RID: 34817 RVA: 0x0027A390 File Offset: 0x00278590
		private void EnsureExtraSuitAddEnhanceLevelCacheIfNeeded()
		{
			if (this.ExtraSuitAddEnhanceLevelCache != null)
			{
				return;
			}
			this.ExtraSuitAddEnhanceLevelCache = this.ExtraSuitAddEnhanceLevelIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008802 RID: 34818 RVA: 0x0027A3F6 File Offset: 0x002785F6
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetExtraSuitAddEnhanceLevelFrozenDict()
		{
			this.EnsureExtraSuitAddEnhanceLevelCacheIfNeeded();
			return this.ExtraSuitAddEnhanceLevelCache;
		}

		// Token: 0x040053B5 RID: 21429
		private Table __p;

		// Token: 0x040053B6 RID: 21430
		[Nullable(2)]
		private FrozenDictionary<int, int> ExtraSuitAddEnhanceLevelCache;
	}
}
