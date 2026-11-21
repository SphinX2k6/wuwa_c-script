using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D1F RID: 3359
	public struct EntrustRole : IFlatbufferObject
	{
		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06006FF6 RID: 28662 RVA: 0x00244008 File Offset: 0x00242208
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006FF7 RID: 28663 RVA: 0x00244015 File Offset: 0x00242215
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006FF8 RID: 28664 RVA: 0x0024401C File Offset: 0x0024221C
		public static EntrustRole GetRootAsEntrustRole(ByteBuffer _bb)
		{
			return EntrustRole.GetRootAsEntrustRole(_bb, default(EntrustRole));
		}

		// Token: 0x06006FF9 RID: 28665 RVA: 0x00244038 File Offset: 0x00242238
		public static EntrustRole GetRootAsEntrustRole(ByteBuffer _bb, EntrustRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006FFA RID: 28666 RVA: 0x00244055 File Offset: 0x00242255
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006FFB RID: 28667 RVA: 0x00244064 File Offset: 0x00242264
		public EntrustRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06006FFC RID: 28668 RVA: 0x00244074 File Offset: 0x00242274
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

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06006FFD RID: 28669 RVA: 0x002440B0 File Offset: 0x002422B0
		public string Icon
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

		// Token: 0x06006FFE RID: 28670 RVA: 0x002440E7 File Offset: 0x002422E7
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006FFF RID: 28671 RVA: 0x002440F6 File Offset: 0x002422F6
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06007000 RID: 28672 RVA: 0x00244110 File Offset: 0x00242310
		public string HeadIcon
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

		// Token: 0x06007001 RID: 28673 RVA: 0x00244147 File Offset: 0x00242347
		public Span<byte> GetHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007002 RID: 28674 RVA: 0x00244156 File Offset: 0x00242356
		public byte[] GetHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06007003 RID: 28675 RVA: 0x00244170 File Offset: 0x00242370
		public string SmallHeadIcon
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

		// Token: 0x06007004 RID: 28676 RVA: 0x002441A8 File Offset: 0x002423A8
		public Span<byte> GetSmallHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007005 RID: 28677 RVA: 0x002441B8 File Offset: 0x002423B8
		public byte[] GetSmallHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06007006 RID: 28678 RVA: 0x002441D0 File Offset: 0x002423D0
		public string Name
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

		// Token: 0x06007007 RID: 28679 RVA: 0x00244208 File Offset: 0x00242408
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007008 RID: 28680 RVA: 0x00244218 File Offset: 0x00242418
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06007009 RID: 28681 RVA: 0x00244230 File Offset: 0x00242430
		public int UnLockCondition
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

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x0600700A RID: 28682 RVA: 0x00244270 File Offset: 0x00242470
		public int JumpType
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

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x0600700B RID: 28683 RVA: 0x002442B0 File Offset: 0x002424B0
		public int JumpParam
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

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x0600700C RID: 28684 RVA: 0x002442F0 File Offset: 0x002424F0
		public int ExPropertyCurve
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

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x0600700D RID: 28685 RVA: 0x00244330 File Offset: 0x00242530
		public int Type
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

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x0600700E RID: 28686 RVA: 0x00244370 File Offset: 0x00242570
		public int MapSortId
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

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x0600700F RID: 28687 RVA: 0x002443B0 File Offset: 0x002425B0
		public string FailDialog
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

		// Token: 0x06007010 RID: 28688 RVA: 0x002443E8 File Offset: 0x002425E8
		public Span<byte> GetFailDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06007011 RID: 28689 RVA: 0x002443F8 File Offset: 0x002425F8
		public byte[] GetFailDialogArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06007012 RID: 28690 RVA: 0x00244410 File Offset: 0x00242610
		public string SuccessDialog
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

		// Token: 0x06007013 RID: 28691 RVA: 0x00244448 File Offset: 0x00242648
		public Span<byte> GetSuccessDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06007014 RID: 28692 RVA: 0x00244458 File Offset: 0x00242658
		public byte[] GetSuccessDialogArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x06007015 RID: 28693 RVA: 0x00244470 File Offset: 0x00242670
		public string InvestDialog
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

		// Token: 0x06007016 RID: 28694 RVA: 0x002444A8 File Offset: 0x002426A8
		public Span<byte> GetInvestDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06007017 RID: 28695 RVA: 0x002444B8 File Offset: 0x002426B8
		public byte[] GetInvestDialogArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x06007018 RID: 28696 RVA: 0x002444D0 File Offset: 0x002426D0
		public string InvestSuccessDialog
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

		// Token: 0x06007019 RID: 28697 RVA: 0x00244508 File Offset: 0x00242708
		public Span<byte> GetInvestSuccessDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600701A RID: 28698 RVA: 0x00244518 File Offset: 0x00242718
		public byte[] GetInvestSuccessDialogArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x0600701B RID: 28699 RVA: 0x00244530 File Offset: 0x00242730
		public string InvestFailDialog
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

		// Token: 0x0600701C RID: 28700 RVA: 0x00244568 File Offset: 0x00242768
		public Span<byte> GetInvestFailDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600701D RID: 28701 RVA: 0x00244578 File Offset: 0x00242778
		public byte[] GetInvestFailDialogArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x0600701E RID: 28702 RVA: 0x00244590 File Offset: 0x00242790
		public string JoinDialog
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

		// Token: 0x0600701F RID: 28703 RVA: 0x002445C8 File Offset: 0x002427C8
		public Span<byte> GetJoinDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06007020 RID: 28704 RVA: 0x002445D8 File Offset: 0x002427D8
		public byte[] GetJoinDialogArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x06007021 RID: 28705 RVA: 0x002445F0 File Offset: 0x002427F0
		public string BuildSuccessDialog
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

		// Token: 0x06007022 RID: 28706 RVA: 0x00244628 File Offset: 0x00242828
		public Span<byte> GetBuildSuccessDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06007023 RID: 28707 RVA: 0x00244638 File Offset: 0x00242838
		public byte[] GetBuildSuccessDialogArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x06007024 RID: 28708 RVA: 0x00244650 File Offset: 0x00242850
		public string SpineAtlas
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

		// Token: 0x06007025 RID: 28709 RVA: 0x00244688 File Offset: 0x00242888
		public Span<byte> GetSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06007026 RID: 28710 RVA: 0x00244698 File Offset: 0x00242898
		public byte[] GetSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x06007027 RID: 28711 RVA: 0x002446B0 File Offset: 0x002428B0
		public string SpineSkeletonData
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

		// Token: 0x06007028 RID: 28712 RVA: 0x002446E8 File Offset: 0x002428E8
		public Span<byte> GetSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06007029 RID: 28713 RVA: 0x002446F8 File Offset: 0x002428F8
		public byte[] GetSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x0600702A RID: 28714 RVA: 0x00244710 File Offset: 0x00242910
		public string SmallSpineAtlas
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

		// Token: 0x0600702B RID: 28715 RVA: 0x00244748 File Offset: 0x00242948
		public Span<byte> GetSmallSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600702C RID: 28716 RVA: 0x00244758 File Offset: 0x00242958
		public byte[] GetSmallSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x0600702D RID: 28717 RVA: 0x00244770 File Offset: 0x00242970
		public string SmallSpineSkeletonData
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600702E RID: 28718 RVA: 0x002447A8 File Offset: 0x002429A8
		public Span<byte> GetSmallSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600702F RID: 28719 RVA: 0x002447B8 File Offset: 0x002429B8
		public byte[] GetSmallSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06007030 RID: 28720 RVA: 0x002447D0 File Offset: 0x002429D0
		public string Portrait
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007031 RID: 28721 RVA: 0x00244808 File Offset: 0x00242A08
		public Span<byte> GetPortraitBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x06007032 RID: 28722 RVA: 0x00244818 File Offset: 0x00242A18
		public byte[] GetPortraitArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x0400525F RID: 21087
		private Table __p;
	}
}
