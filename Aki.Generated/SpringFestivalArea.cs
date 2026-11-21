using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200121C RID: 4636
	public struct SpringFestivalArea : IFlatbufferObject
	{
		// Token: 0x17003B59 RID: 15193
		// (get) Token: 0x0600E5BA RID: 58810 RVA: 0x0034A7C5 File Offset: 0x003489C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E5BB RID: 58811 RVA: 0x0034A7D2 File Offset: 0x003489D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E5BC RID: 58812 RVA: 0x0034A7DC File Offset: 0x003489DC
		public static SpringFestivalArea GetRootAsSpringFestivalArea(ByteBuffer _bb)
		{
			return SpringFestivalArea.GetRootAsSpringFestivalArea(_bb, default(SpringFestivalArea));
		}

		// Token: 0x0600E5BD RID: 58813 RVA: 0x0034A7F8 File Offset: 0x003489F8
		public static SpringFestivalArea GetRootAsSpringFestivalArea(ByteBuffer _bb, SpringFestivalArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E5BE RID: 58814 RVA: 0x0034A815 File Offset: 0x00348A15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E5BF RID: 58815 RVA: 0x0034A824 File Offset: 0x00348A24
		public SpringFestivalArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B5A RID: 15194
		// (get) Token: 0x0600E5C0 RID: 58816 RVA: 0x0034A834 File Offset: 0x00348A34
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

		// Token: 0x17003B5B RID: 15195
		// (get) Token: 0x0600E5C1 RID: 58817 RVA: 0x0034A870 File Offset: 0x00348A70
		public int Floor
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

		// Token: 0x17003B5C RID: 15196
		// (get) Token: 0x0600E5C2 RID: 58818 RVA: 0x0034A8AC File Offset: 0x00348AAC
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

		// Token: 0x17003B5D RID: 15197
		// (get) Token: 0x0600E5C3 RID: 58819 RVA: 0x0034A8E8 File Offset: 0x00348AE8
		public int MaxAtmosphere
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

		// Token: 0x0600E5C4 RID: 58820 RVA: 0x0034A928 File Offset: 0x00348B28
		public int SlotEntityIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B5E RID: 15198
		// (get) Token: 0x0600E5C5 RID: 58821 RVA: 0x0034A968 File Offset: 0x00348B68
		public int SlotEntityIdsLength
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

		// Token: 0x0600E5C6 RID: 58822 RVA: 0x0034A994 File Offset: 0x00348B94
		public Span<int> GetSlotEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600E5C7 RID: 58823 RVA: 0x0034A9A4 File Offset: 0x00348BA4
		public int[] GetSlotEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17003B5F RID: 15199
		// (get) Token: 0x0600E5C8 RID: 58824 RVA: 0x0034A9BC File Offset: 0x00348BBC
		public int QuestId
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

		// Token: 0x17003B60 RID: 15200
		// (get) Token: 0x0600E5C9 RID: 58825 RVA: 0x0034A9FC File Offset: 0x00348BFC
		public int NodeId
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

		// Token: 0x17003B61 RID: 15201
		// (get) Token: 0x0600E5CA RID: 58826 RVA: 0x0034AA3C File Offset: 0x00348C3C
		public int AtmosphereLevelId
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

		// Token: 0x0600E5CB RID: 58827 RVA: 0x0034AA7C File Offset: 0x00348C7C
		public DicIntIntArray? DefaultFurnitures(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003B62 RID: 15202
		// (get) Token: 0x0600E5CC RID: 58828 RVA: 0x0034AAE0 File Offset: 0x00348CE0
		public int DefaultFurnituresLength
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

		// Token: 0x17003B63 RID: 15203
		// (get) Token: 0x0600E5CD RID: 58829 RVA: 0x0034AB0C File Offset: 0x00348D0C
		public Vector? CameraLocation
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003B64 RID: 15204
		// (get) Token: 0x0600E5CE RID: 58830 RVA: 0x0034AB6C File Offset: 0x00348D6C
		public Vector? CameraRotator
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003B65 RID: 15205
		// (get) Token: 0x0600E5CF RID: 58831 RVA: 0x0034ABCC File Offset: 0x00348DCC
		public int CameraFov
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 90;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E5D0 RID: 58832 RVA: 0x0034AC0C File Offset: 0x00348E0C
		public int CameraList(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B66 RID: 15206
		// (get) Token: 0x0600E5D1 RID: 58833 RVA: 0x0034AC4C File Offset: 0x00348E4C
		public int CameraListLength
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

		// Token: 0x0600E5D2 RID: 58834 RVA: 0x0034AC78 File Offset: 0x00348E78
		public Span<int> GetCameraListBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600E5D3 RID: 58835 RVA: 0x0034AC88 File Offset: 0x00348E88
		public int[] GetCameraListArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x17003B67 RID: 15207
		// (get) Token: 0x0600E5D4 RID: 58836 RVA: 0x0034ACA0 File Offset: 0x00348EA0
		public string AreaName
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

		// Token: 0x0600E5D5 RID: 58837 RVA: 0x0034ACD8 File Offset: 0x00348ED8
		public Span<byte> GetAreaNameBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600E5D6 RID: 58838 RVA: 0x0034ACE8 File Offset: 0x00348EE8
		public byte[] GetAreaNameArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B68 RID: 15208
		// (get) Token: 0x0600E5D7 RID: 58839 RVA: 0x0034AD00 File Offset: 0x00348F00
		public string AreaDescription
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

		// Token: 0x0600E5D8 RID: 58840 RVA: 0x0034AD38 File Offset: 0x00348F38
		public Span<byte> GetAreaDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600E5D9 RID: 58841 RVA: 0x0034AD48 File Offset: 0x00348F48
		public byte[] GetAreaDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B69 RID: 15209
		// (get) Token: 0x0600E5DA RID: 58842 RVA: 0x0034AD60 File Offset: 0x00348F60
		public string AreaFinishedSmallIcon
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

		// Token: 0x0600E5DB RID: 58843 RVA: 0x0034AD98 File Offset: 0x00348F98
		public Span<byte> GetAreaFinishedSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600E5DC RID: 58844 RVA: 0x0034ADA8 File Offset: 0x00348FA8
		public byte[] GetAreaFinishedSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B6A RID: 15210
		// (get) Token: 0x0600E5DD RID: 58845 RVA: 0x0034ADC0 File Offset: 0x00348FC0
		public string AreaUnFinishedSmallIcon
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

		// Token: 0x0600E5DE RID: 58846 RVA: 0x0034ADF8 File Offset: 0x00348FF8
		public Span<byte> GetAreaUnFinishedSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600E5DF RID: 58847 RVA: 0x0034AE08 File Offset: 0x00349008
		public byte[] GetAreaUnFinishedSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B6B RID: 15211
		// (get) Token: 0x0600E5E0 RID: 58848 RVA: 0x0034AE20 File Offset: 0x00349020
		public string AreaFinishedBigIcon
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

		// Token: 0x0600E5E1 RID: 58849 RVA: 0x0034AE58 File Offset: 0x00349058
		public Span<byte> GetAreaFinishedBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600E5E2 RID: 58850 RVA: 0x0034AE68 File Offset: 0x00349068
		public byte[] GetAreaFinishedBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B6C RID: 15212
		// (get) Token: 0x0600E5E3 RID: 58851 RVA: 0x0034AE80 File Offset: 0x00349080
		public string AreaUnFinishedBigIcon
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

		// Token: 0x0600E5E4 RID: 58852 RVA: 0x0034AEB8 File Offset: 0x003490B8
		public Span<byte> GetAreaUnFinishedBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600E5E5 RID: 58853 RVA: 0x0034AEC8 File Offset: 0x003490C8
		public byte[] GetAreaUnFinishedBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B6D RID: 15213
		// (get) Token: 0x0600E5E6 RID: 58854 RVA: 0x0034AEE0 File Offset: 0x003490E0
		public int MaxSlotCount
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E5E7 RID: 58855 RVA: 0x0034AF20 File Offset: 0x00349120
		public int RangeEntityList(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B6E RID: 15214
		// (get) Token: 0x0600E5E8 RID: 58856 RVA: 0x0034AF60 File Offset: 0x00349160
		public int RangeEntityListLength
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

		// Token: 0x0600E5E9 RID: 58857 RVA: 0x0034AF8C File Offset: 0x0034918C
		public Span<int> GetRangeEntityListBytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x0600E5EA RID: 58858 RVA: 0x0034AF9C File Offset: 0x0034919C
		public int[] GetRangeEntityListArray()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x17003B6F RID: 15215
		// (get) Token: 0x0600E5EB RID: 58859 RVA: 0x0034AFB4 File Offset: 0x003491B4
		public Vector? TeleportLocation
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003B70 RID: 15216
		// (get) Token: 0x0600E5EC RID: 58860 RVA: 0x0034B014 File Offset: 0x00349214
		public Vector? TeleportRotator
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0600E5ED RID: 58861 RVA: 0x0034B072 File Offset: 0x00349272
		[NullableContext(1)]
		public int[] CameraList()
		{
			return this.GetCameraListArray();
		}

		// Token: 0x0600E5EE RID: 58862 RVA: 0x0034B07A File Offset: 0x0034927A
		[NullableContext(1)]
		public IEnumerable<int> CameraListIter()
		{
			SpringFestivalArea.<CameraListIter>d__77 <CameraListIter>d__ = new SpringFestivalArea.<CameraListIter>d__77(-2);
			<CameraListIter>d__.<>3__<>4__this = this;
			return <CameraListIter>d__;
		}

		// Token: 0x0600E5EF RID: 58863 RVA: 0x0034B090 File Offset: 0x00349290
		[NullableContext(1)]
		public Dictionary<int, IntArray> DefaultFurnitures()
		{
			return this.DefaultFurnituresIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600E5F0 RID: 58864 RVA: 0x0034B0E6 File Offset: 0x003492E6
		[NullableContext(1)]
		public IEnumerable<DicIntIntArray> DefaultFurnituresIter()
		{
			SpringFestivalArea.<DefaultFurnituresIter>d__79 <DefaultFurnituresIter>d__ = new SpringFestivalArea.<DefaultFurnituresIter>d__79(-2);
			<DefaultFurnituresIter>d__.<>3__<>4__this = this;
			return <DefaultFurnituresIter>d__;
		}

		// Token: 0x0600E5F1 RID: 58865 RVA: 0x0034B0FB File Offset: 0x003492FB
		[NullableContext(1)]
		public int[] RangeEntityList()
		{
			return this.GetRangeEntityListArray();
		}

		// Token: 0x0600E5F2 RID: 58866 RVA: 0x0034B103 File Offset: 0x00349303
		[NullableContext(1)]
		public IEnumerable<int> RangeEntityListIter()
		{
			SpringFestivalArea.<RangeEntityListIter>d__81 <RangeEntityListIter>d__ = new SpringFestivalArea.<RangeEntityListIter>d__81(-2);
			<RangeEntityListIter>d__.<>3__<>4__this = this;
			return <RangeEntityListIter>d__;
		}

		// Token: 0x0600E5F3 RID: 58867 RVA: 0x0034B118 File Offset: 0x00349318
		[NullableContext(1)]
		public int[] SlotEntityIds()
		{
			return this.GetSlotEntityIdsArray();
		}

		// Token: 0x0600E5F4 RID: 58868 RVA: 0x0034B120 File Offset: 0x00349320
		[NullableContext(1)]
		public IEnumerable<int> SlotEntityIdsIter()
		{
			SpringFestivalArea.<SlotEntityIdsIter>d__83 <SlotEntityIdsIter>d__ = new SpringFestivalArea.<SlotEntityIdsIter>d__83(-2);
			<SlotEntityIdsIter>d__.<>3__<>4__this = this;
			return <SlotEntityIdsIter>d__;
		}

		// Token: 0x0600E5F5 RID: 58869 RVA: 0x0034B138 File Offset: 0x00349338
		public IntArray? GetDefaultFurnitures(int key)
		{
			this.EnsureDefaultFurnituresCacheIfNeeded();
			IntArray value;
			if (!this.DefaultFurnituresCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600E5F6 RID: 58870 RVA: 0x0034B16C File Offset: 0x0034936C
		private void EnsureDefaultFurnituresCacheIfNeeded()
		{
			if (this.DefaultFurnituresCache != null)
			{
				return;
			}
			this.DefaultFurnituresCache = this.DefaultFurnituresIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600E5F7 RID: 58871 RVA: 0x0034B1D2 File Offset: 0x003493D2
		[NullableContext(1)]
		public FrozenDictionary<int, IntArray> GetDefaultFurnituresFrozenDict()
		{
			this.EnsureDefaultFurnituresCacheIfNeeded();
			return this.DefaultFurnituresCache;
		}

		// Token: 0x0400585C RID: 22620
		private Table __p;

		// Token: 0x0400585D RID: 22621
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> DefaultFurnituresCache;
	}
}
