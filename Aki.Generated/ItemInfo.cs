using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D81 RID: 3457
	public struct ItemInfo : IFlatbufferObject
	{
		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x06008679 RID: 34425 RVA: 0x00266119 File Offset: 0x00264319
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600867A RID: 34426 RVA: 0x00266126 File Offset: 0x00264326
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600867B RID: 34427 RVA: 0x00266130 File Offset: 0x00264330
		public static ItemInfo GetRootAsItemInfo(ByteBuffer _bb)
		{
			return ItemInfo.GetRootAsItemInfo(_bb, default(ItemInfo));
		}

		// Token: 0x0600867C RID: 34428 RVA: 0x0026614C File Offset: 0x0026434C
		public static ItemInfo GetRootAsItemInfo(ByteBuffer _bb, ItemInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600867D RID: 34429 RVA: 0x00266169 File Offset: 0x00264369
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600867E RID: 34430 RVA: 0x00266178 File Offset: 0x00264378
		public ItemInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x0600867F RID: 34431 RVA: 0x00266188 File Offset: 0x00264388
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

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x06008680 RID: 34432 RVA: 0x002661C4 File Offset: 0x002643C4
		public int ItemType
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

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x06008681 RID: 34433 RVA: 0x00266200 File Offset: 0x00264400
		public string Name
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

		// Token: 0x06008682 RID: 34434 RVA: 0x00266237 File Offset: 0x00264437
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008683 RID: 34435 RVA: 0x00266246 File Offset: 0x00264446
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06008684 RID: 34436 RVA: 0x00266260 File Offset: 0x00264460
		public int ShowTypes(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x06008685 RID: 34437 RVA: 0x002662A0 File Offset: 0x002644A0
		public int ShowTypesLength
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

		// Token: 0x06008686 RID: 34438 RVA: 0x002662CC File Offset: 0x002644CC
		public Span<int> GetShowTypesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06008687 RID: 34439 RVA: 0x002662DC File Offset: 0x002644DC
		public int[] GetShowTypesArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x06008688 RID: 34440 RVA: 0x002662F4 File Offset: 0x002644F4
		public string AttributesDescription
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

		// Token: 0x06008689 RID: 34441 RVA: 0x0026632C File Offset: 0x0026452C
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600868A RID: 34442 RVA: 0x0026633C File Offset: 0x0026453C
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x0600868B RID: 34443 RVA: 0x00266354 File Offset: 0x00264554
		public string BgDescription
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

		// Token: 0x0600868C RID: 34444 RVA: 0x0026638C File Offset: 0x0026458C
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600868D RID: 34445 RVA: 0x0026639C File Offset: 0x0026459C
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x0600868E RID: 34446 RVA: 0x002663B4 File Offset: 0x002645B4
		public string ObtainedShowDescription
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

		// Token: 0x0600868F RID: 34447 RVA: 0x002663EC File Offset: 0x002645EC
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008690 RID: 34448 RVA: 0x002663FC File Offset: 0x002645FC
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x06008691 RID: 34449 RVA: 0x00266414 File Offset: 0x00264614
		public int ObtainedShow
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

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x06008692 RID: 34450 RVA: 0x00266454 File Offset: 0x00264654
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008693 RID: 34451 RVA: 0x0026648C File Offset: 0x0026468C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06008694 RID: 34452 RVA: 0x0026649C File Offset: 0x0026469C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x06008695 RID: 34453 RVA: 0x002664B4 File Offset: 0x002646B4
		public string IconMiddle
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

		// Token: 0x06008696 RID: 34454 RVA: 0x002664EC File Offset: 0x002646EC
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008697 RID: 34455 RVA: 0x002664FC File Offset: 0x002646FC
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x06008698 RID: 34456 RVA: 0x00266514 File Offset: 0x00264714
		public string IconSmall
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

		// Token: 0x06008699 RID: 34457 RVA: 0x0026654C File Offset: 0x0026474C
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600869A RID: 34458 RVA: 0x0026655C File Offset: 0x0026475C
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x0600869B RID: 34459 RVA: 0x00266574 File Offset: 0x00264774
		public string Mesh
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

		// Token: 0x0600869C RID: 34460 RVA: 0x002665AC File Offset: 0x002647AC
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600869D RID: 34461 RVA: 0x002665BC File Offset: 0x002647BC
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x0600869E RID: 34462 RVA: 0x002665D4 File Offset: 0x002647D4
		public int QualityId
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

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x0600869F RID: 34463 RVA: 0x00266614 File Offset: 0x00264814
		public int MainTypeId
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

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x060086A0 RID: 34464 RVA: 0x00266654 File Offset: 0x00264854
		public int RedDotDisableRule
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

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x060086A1 RID: 34465 RVA: 0x00266694 File Offset: 0x00264894
		public int UseCountLimit
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

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x060086A2 RID: 34466 RVA: 0x002666D4 File Offset: 0x002648D4
		public int SortIndex
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

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x060086A3 RID: 34467 RVA: 0x00266714 File Offset: 0x00264914
		public int MaxCapcity
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 999999999;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x060086A4 RID: 34468 RVA: 0x00266758 File Offset: 0x00264958
		public int MaxStackableNum
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 99999999;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060086A5 RID: 34469 RVA: 0x0026679C File Offset: 0x0026499C
		public DicIntInt? DecomposeInfo(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x060086A6 RID: 34470 RVA: 0x00266800 File Offset: 0x00264A00
		public int DecomposeInfoLength
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

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x060086A7 RID: 34471 RVA: 0x0026682C File Offset: 0x00264A2C
		public int UseLevel
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x060086A8 RID: 34472 RVA: 0x0026686C File Offset: 0x00264A6C
		public int BeginTimeStamp
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

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x060086A9 RID: 34473 RVA: 0x002668AC File Offset: 0x00264AAC
		public int DurationStamp
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

		// Token: 0x060086AA RID: 34474 RVA: 0x002668EC File Offset: 0x00264AEC
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x060086AB RID: 34475 RVA: 0x0026692C File Offset: 0x00264B2C
		public int ItemAccessLength
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

		// Token: 0x060086AC RID: 34476 RVA: 0x00266958 File Offset: 0x00264B58
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(50, 4);
		}

		// Token: 0x060086AD RID: 34477 RVA: 0x00266968 File Offset: 0x00264B68
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(50) ?? Array.Empty<int>();
		}

		// Token: 0x060086AE RID: 34478 RVA: 0x00266980 File Offset: 0x00264B80
		public DicIntInt? Parameters(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x060086AF RID: 34479 RVA: 0x002669E4 File Offset: 0x00264BE4
		public int ParametersLength
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x060086B0 RID: 34480 RVA: 0x00266A10 File Offset: 0x00264C10
		public bool ShowUseButton
		{
			get
			{
				int num = this.__p.__offset(54);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060086B1 RID: 34481 RVA: 0x00266A50 File Offset: 0x00264C50
		public int CompositeItem(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x060086B2 RID: 34482 RVA: 0x00266A90 File Offset: 0x00264C90
		public int CompositeItemLength
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

		// Token: 0x060086B3 RID: 34483 RVA: 0x00266ABC File Offset: 0x00264CBC
		public Span<int> GetCompositeItemBytes()
		{
			return this.__p.__vector_as_span<int>(56, 4);
		}

		// Token: 0x060086B4 RID: 34484 RVA: 0x00266ACC File Offset: 0x00264CCC
		public int[] GetCompositeItemArray()
		{
			return this.__p.__vector_as_array<int>(56) ?? Array.Empty<int>();
		}

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x060086B5 RID: 34485 RVA: 0x00266AE4 File Offset: 0x00264CE4
		public int EntityConfig
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x060086B6 RID: 34486 RVA: 0x00266B24 File Offset: 0x00264D24
		public int NumLimit
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x060086B7 RID: 34487 RVA: 0x00266B64 File Offset: 0x00264D64
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(62);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060086B8 RID: 34488 RVA: 0x00266BA4 File Offset: 0x00264DA4
		public DicIntInt? ConvertItems(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x060086B9 RID: 34489 RVA: 0x00266C08 File Offset: 0x00264E08
		public int ConvertItemsLength
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x060086BA RID: 34490 RVA: 0x00266C34 File Offset: 0x00264E34
		public bool Destructible
		{
			get
			{
				int num = this.__p.__offset(66);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x060086BB RID: 34491 RVA: 0x00266C74 File Offset: 0x00264E74
		public int ItemBuffType
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x060086BC RID: 34492 RVA: 0x00266CB4 File Offset: 0x00264EB4
		public bool SpecialItem
		{
			get
			{
				int num = this.__p.__offset(70);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x060086BD RID: 34493 RVA: 0x00266CF4 File Offset: 0x00264EF4
		public bool UiPlayItem
		{
			get
			{
				int num = this.__p.__offset(72);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x060086BE RID: 34494 RVA: 0x00266D34 File Offset: 0x00264F34
		public bool IsBuffItem
		{
			get
			{
				int num = this.__p.__offset(74);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x060086BF RID: 34495 RVA: 0x00266D74 File Offset: 0x00264F74
		public int RestrictConditionGroupId
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060086C0 RID: 34496 RVA: 0x00266DB4 File Offset: 0x00264FB4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CompositeItemIter()或GetCompositeItemBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CompositeItem()
		{
			ItemInfo itemInfo = this;
			return itemInfo.GetCompositeItemArray() ?? Array.Empty<int>();
		}

		// Token: 0x060086C1 RID: 34497 RVA: 0x00266DD8 File Offset: 0x00264FD8
		[NullableContext(1)]
		public readonly IEnumerable<int> CompositeItemIter()
		{
			ItemInfo.<CompositeItemIter>d__111 <CompositeItemIter>d__ = new ItemInfo.<CompositeItemIter>d__111(-2);
			<CompositeItemIter>d__.<>3__<>4__this = this;
			return <CompositeItemIter>d__;
		}

		// Token: 0x060086C2 RID: 34498 RVA: 0x00266DF0 File Offset: 0x00264FF0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ConvertItemsFrozenDict()缓存字典，遍历请使用ConvertItemsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ConvertItems()
		{
			return this.ConvertItemsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060086C3 RID: 34499 RVA: 0x00266E46 File Offset: 0x00265046
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ConvertItemsIter()
		{
			ItemInfo.<ConvertItemsIter>d__113 <ConvertItemsIter>d__ = new ItemInfo.<ConvertItemsIter>d__113(-2);
			<ConvertItemsIter>d__.<>3__<>4__this = this;
			return <ConvertItemsIter>d__;
		}

		// Token: 0x060086C4 RID: 34500 RVA: 0x00266E5C File Offset: 0x0026505C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DecomposeInfoFrozenDict()缓存字典，遍历请使用DecomposeInfoIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> DecomposeInfo()
		{
			return this.DecomposeInfoIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060086C5 RID: 34501 RVA: 0x00266EB2 File Offset: 0x002650B2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> DecomposeInfoIter()
		{
			ItemInfo.<DecomposeInfoIter>d__115 <DecomposeInfoIter>d__ = new ItemInfo.<DecomposeInfoIter>d__115(-2);
			<DecomposeInfoIter>d__.<>3__<>4__this = this;
			return <DecomposeInfoIter>d__;
		}

		// Token: 0x060086C6 RID: 34502 RVA: 0x00266EC8 File Offset: 0x002650C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			ItemInfo itemInfo = this;
			return itemInfo.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x060086C7 RID: 34503 RVA: 0x00266EEC File Offset: 0x002650EC
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			ItemInfo.<ItemAccessIter>d__117 <ItemAccessIter>d__ = new ItemInfo.<ItemAccessIter>d__117(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x060086C8 RID: 34504 RVA: 0x00266F04 File Offset: 0x00265104
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ParametersFrozenDict()缓存字典，遍历请使用ParametersIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Parameters()
		{
			return this.ParametersIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060086C9 RID: 34505 RVA: 0x00266F5A File Offset: 0x0026515A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ParametersIter()
		{
			ItemInfo.<ParametersIter>d__119 <ParametersIter>d__ = new ItemInfo.<ParametersIter>d__119(-2);
			<ParametersIter>d__.<>3__<>4__this = this;
			return <ParametersIter>d__;
		}

		// Token: 0x060086CA RID: 34506 RVA: 0x00266F70 File Offset: 0x00265170
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowTypesIter()或GetShowTypesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowTypes()
		{
			ItemInfo itemInfo = this;
			return itemInfo.GetShowTypesArray() ?? Array.Empty<int>();
		}

		// Token: 0x060086CB RID: 34507 RVA: 0x00266F94 File Offset: 0x00265194
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowTypesIter()
		{
			ItemInfo.<ShowTypesIter>d__121 <ShowTypesIter>d__ = new ItemInfo.<ShowTypesIter>d__121(-2);
			<ShowTypesIter>d__.<>3__<>4__this = this;
			return <ShowTypesIter>d__;
		}

		// Token: 0x060086CC RID: 34508 RVA: 0x00266FAC File Offset: 0x002651AC
		public int? GetConvertItems(int key)
		{
			this.EnsureConvertItemsCacheIfNeeded();
			int value;
			if (!this.ConvertItemsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060086CD RID: 34509 RVA: 0x00266FE0 File Offset: 0x002651E0
		public int? GetDecomposeInfo(int key)
		{
			this.EnsureDecomposeInfoCacheIfNeeded();
			int value;
			if (!this.DecomposeInfoCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060086CE RID: 34510 RVA: 0x00267014 File Offset: 0x00265214
		public int? GetParameters(int key)
		{
			this.EnsureParametersCacheIfNeeded();
			int value;
			if (!this.ParametersCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060086CF RID: 34511 RVA: 0x00267048 File Offset: 0x00265248
		private void EnsureConvertItemsCacheIfNeeded()
		{
			if (this.ConvertItemsCache != null)
			{
				return;
			}
			this.ConvertItemsCache = this.ConvertItemsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060086D0 RID: 34512 RVA: 0x002670B0 File Offset: 0x002652B0
		private void EnsureDecomposeInfoCacheIfNeeded()
		{
			if (this.DecomposeInfoCache != null)
			{
				return;
			}
			this.DecomposeInfoCache = this.DecomposeInfoIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060086D1 RID: 34513 RVA: 0x00267118 File Offset: 0x00265318
		private void EnsureParametersCacheIfNeeded()
		{
			if (this.ParametersCache != null)
			{
				return;
			}
			this.ParametersCache = this.ParametersIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060086D2 RID: 34514 RVA: 0x0026717E File Offset: 0x0026537E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetConvertItemsFrozenDict(int key)
		{
			this.EnsureConvertItemsCacheIfNeeded();
			return this.ConvertItemsCache;
		}

		// Token: 0x060086D3 RID: 34515 RVA: 0x0026718C File Offset: 0x0026538C
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetDecomposeInfoFrozenDict(int key)
		{
			this.EnsureDecomposeInfoCacheIfNeeded();
			return this.DecomposeInfoCache;
		}

		// Token: 0x060086D4 RID: 34516 RVA: 0x0026719A File Offset: 0x0026539A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetParametersFrozenDict(int key)
		{
			this.EnsureParametersCacheIfNeeded();
			return this.ParametersCache;
		}

		// Token: 0x04004E0A RID: 19978
		private Table __p;

		// Token: 0x04004E0B RID: 19979
		[Nullable(2)]
		private FrozenDictionary<int, int> ConvertItemsCache;

		// Token: 0x04004E0C RID: 19980
		[Nullable(2)]
		private FrozenDictionary<int, int> DecomposeInfoCache;

		// Token: 0x04004E0D RID: 19981
		[Nullable(2)]
		private FrozenDictionary<int, int> ParametersCache;
	}
}
