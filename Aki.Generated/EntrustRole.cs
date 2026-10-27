using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C3C RID: 3132
	public struct EntrustRole : IFlatbufferObject
	{
		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x060069F4 RID: 27124 RVA: 0x00224CC0 File Offset: 0x00222EC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060069F5 RID: 27125 RVA: 0x00224CCD File Offset: 0x00222ECD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060069F6 RID: 27126 RVA: 0x00224CD4 File Offset: 0x00222ED4
		public static EntrustRole GetRootAsEntrustRole(ByteBuffer _bb)
		{
			return EntrustRole.GetRootAsEntrustRole(_bb, default(EntrustRole));
		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x00224CF0 File Offset: 0x00222EF0
		public static EntrustRole GetRootAsEntrustRole(ByteBuffer _bb, EntrustRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060069F8 RID: 27128 RVA: 0x00224D0D File Offset: 0x00222F0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060069F9 RID: 27129 RVA: 0x00224D1C File Offset: 0x00222F1C
		public EntrustRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x060069FA RID: 27130 RVA: 0x00224D2C File Offset: 0x00222F2C
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

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x060069FB RID: 27131 RVA: 0x00224D68 File Offset: 0x00222F68
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

		// Token: 0x060069FC RID: 27132 RVA: 0x00224D9F File Offset: 0x00222F9F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060069FD RID: 27133 RVA: 0x00224DAE File Offset: 0x00222FAE
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x060069FE RID: 27134 RVA: 0x00224DC8 File Offset: 0x00222FC8
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

		// Token: 0x060069FF RID: 27135 RVA: 0x00224DFF File Offset: 0x00222FFF
		public Span<byte> GetHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006A00 RID: 27136 RVA: 0x00224E0E File Offset: 0x0022300E
		public byte[] GetHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06006A01 RID: 27137 RVA: 0x00224E28 File Offset: 0x00223028
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

		// Token: 0x06006A02 RID: 27138 RVA: 0x00224E60 File Offset: 0x00223060
		public Span<byte> GetSmallHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006A03 RID: 27139 RVA: 0x00224E70 File Offset: 0x00223070
		public byte[] GetSmallHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06006A04 RID: 27140 RVA: 0x00224E88 File Offset: 0x00223088
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

		// Token: 0x06006A05 RID: 27141 RVA: 0x00224EC0 File Offset: 0x002230C0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006A06 RID: 27142 RVA: 0x00224ED0 File Offset: 0x002230D0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06006A07 RID: 27143 RVA: 0x00224EE8 File Offset: 0x002230E8
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

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06006A08 RID: 27144 RVA: 0x00224F28 File Offset: 0x00223128
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

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06006A09 RID: 27145 RVA: 0x00224F68 File Offset: 0x00223168
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

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06006A0A RID: 27146 RVA: 0x00224FA8 File Offset: 0x002231A8
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

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06006A0B RID: 27147 RVA: 0x00224FE8 File Offset: 0x002231E8
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

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06006A0C RID: 27148 RVA: 0x00225028 File Offset: 0x00223228
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

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06006A0D RID: 27149 RVA: 0x00225068 File Offset: 0x00223268
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

		// Token: 0x06006A0E RID: 27150 RVA: 0x002250A0 File Offset: 0x002232A0
		public Span<byte> GetFailDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06006A0F RID: 27151 RVA: 0x002250B0 File Offset: 0x002232B0
		public byte[] GetFailDialogArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06006A10 RID: 27152 RVA: 0x002250C8 File Offset: 0x002232C8
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

		// Token: 0x06006A11 RID: 27153 RVA: 0x00225100 File Offset: 0x00223300
		public Span<byte> GetSuccessDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06006A12 RID: 27154 RVA: 0x00225110 File Offset: 0x00223310
		public byte[] GetSuccessDialogArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06006A13 RID: 27155 RVA: 0x00225128 File Offset: 0x00223328
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

		// Token: 0x06006A14 RID: 27156 RVA: 0x00225160 File Offset: 0x00223360
		public Span<byte> GetInvestDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06006A15 RID: 27157 RVA: 0x00225170 File Offset: 0x00223370
		public byte[] GetInvestDialogArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06006A16 RID: 27158 RVA: 0x00225188 File Offset: 0x00223388
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

		// Token: 0x06006A17 RID: 27159 RVA: 0x002251C0 File Offset: 0x002233C0
		public Span<byte> GetInvestSuccessDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06006A18 RID: 27160 RVA: 0x002251D0 File Offset: 0x002233D0
		public byte[] GetInvestSuccessDialogArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06006A19 RID: 27161 RVA: 0x002251E8 File Offset: 0x002233E8
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

		// Token: 0x06006A1A RID: 27162 RVA: 0x00225220 File Offset: 0x00223420
		public Span<byte> GetInvestFailDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06006A1B RID: 27163 RVA: 0x00225230 File Offset: 0x00223430
		public byte[] GetInvestFailDialogArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06006A1C RID: 27164 RVA: 0x00225248 File Offset: 0x00223448
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

		// Token: 0x06006A1D RID: 27165 RVA: 0x00225280 File Offset: 0x00223480
		public Span<byte> GetJoinDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06006A1E RID: 27166 RVA: 0x00225290 File Offset: 0x00223490
		public byte[] GetJoinDialogArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06006A1F RID: 27167 RVA: 0x002252A8 File Offset: 0x002234A8
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

		// Token: 0x06006A20 RID: 27168 RVA: 0x002252E0 File Offset: 0x002234E0
		public Span<byte> GetBuildSuccessDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06006A21 RID: 27169 RVA: 0x002252F0 File Offset: 0x002234F0
		public byte[] GetBuildSuccessDialogArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06006A22 RID: 27170 RVA: 0x00225308 File Offset: 0x00223508
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

		// Token: 0x06006A23 RID: 27171 RVA: 0x00225340 File Offset: 0x00223540
		public Span<byte> GetSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06006A24 RID: 27172 RVA: 0x00225350 File Offset: 0x00223550
		public byte[] GetSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06006A25 RID: 27173 RVA: 0x00225368 File Offset: 0x00223568
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

		// Token: 0x06006A26 RID: 27174 RVA: 0x002253A0 File Offset: 0x002235A0
		public Span<byte> GetSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06006A27 RID: 27175 RVA: 0x002253B0 File Offset: 0x002235B0
		public byte[] GetSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06006A28 RID: 27176 RVA: 0x002253C8 File Offset: 0x002235C8
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

		// Token: 0x06006A29 RID: 27177 RVA: 0x00225400 File Offset: 0x00223600
		public Span<byte> GetSmallSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06006A2A RID: 27178 RVA: 0x00225410 File Offset: 0x00223610
		public byte[] GetSmallSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06006A2B RID: 27179 RVA: 0x00225428 File Offset: 0x00223628
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

		// Token: 0x06006A2C RID: 27180 RVA: 0x00225460 File Offset: 0x00223660
		public Span<byte> GetSmallSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06006A2D RID: 27181 RVA: 0x00225470 File Offset: 0x00223670
		public byte[] GetSmallSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06006A2E RID: 27182 RVA: 0x00225488 File Offset: 0x00223688
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

		// Token: 0x06006A2F RID: 27183 RVA: 0x002254C0 File Offset: 0x002236C0
		public Span<byte> GetPortraitBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x06006A30 RID: 27184 RVA: 0x002254D0 File Offset: 0x002236D0
		public byte[] GetPortraitArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C7C RID: 19580
		private Table __p;
	}
}
