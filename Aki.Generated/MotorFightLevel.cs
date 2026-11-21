using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F2B RID: 3883
	public struct MotorFightLevel : IFlatbufferObject
	{
		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x06009E9E RID: 40606 RVA: 0x002ACE08 File Offset: 0x002AB008
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009E9F RID: 40607 RVA: 0x002ACE15 File Offset: 0x002AB015
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009EA0 RID: 40608 RVA: 0x002ACE1C File Offset: 0x002AB01C
		public static MotorFightLevel GetRootAsMotorFightLevel(ByteBuffer _bb)
		{
			return MotorFightLevel.GetRootAsMotorFightLevel(_bb, default(MotorFightLevel));
		}

		// Token: 0x06009EA1 RID: 40609 RVA: 0x002ACE38 File Offset: 0x002AB038
		public static MotorFightLevel GetRootAsMotorFightLevel(ByteBuffer _bb, MotorFightLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009EA2 RID: 40610 RVA: 0x002ACE55 File Offset: 0x002AB055
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009EA3 RID: 40611 RVA: 0x002ACE64 File Offset: 0x002AB064
		public MotorFightLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x06009EA4 RID: 40612 RVA: 0x002ACE74 File Offset: 0x002AB074
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

		// Token: 0x17002136 RID: 8502
		// (get) Token: 0x06009EA5 RID: 40613 RVA: 0x002ACEB0 File Offset: 0x002AB0B0
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

		// Token: 0x17002137 RID: 8503
		// (get) Token: 0x06009EA6 RID: 40614 RVA: 0x002ACEEC File Offset: 0x002AB0EC
		public int InstId
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

		// Token: 0x17002138 RID: 8504
		// (get) Token: 0x06009EA7 RID: 40615 RVA: 0x002ACF28 File Offset: 0x002AB128
		public int InstType
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

		// Token: 0x06009EA8 RID: 40616 RVA: 0x002ACF68 File Offset: 0x002AB168
		public int PreId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002139 RID: 8505
		// (get) Token: 0x06009EA9 RID: 40617 RVA: 0x002ACFA8 File Offset: 0x002AB1A8
		public int PreIdLength
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

		// Token: 0x06009EAA RID: 40618 RVA: 0x002ACFD4 File Offset: 0x002AB1D4
		public Span<int> GetPreIdBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06009EAB RID: 40619 RVA: 0x002ACFE4 File Offset: 0x002AB1E4
		public int[] GetPreIdArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x1700213A RID: 8506
		// (get) Token: 0x06009EAC RID: 40620 RVA: 0x002ACFFC File Offset: 0x002AB1FC
		public int OpenDay
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

		// Token: 0x1700213B RID: 8507
		// (get) Token: 0x06009EAD RID: 40621 RVA: 0x002AD03C File Offset: 0x002AB23C
		public string LevelName
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

		// Token: 0x06009EAE RID: 40622 RVA: 0x002AD074 File Offset: 0x002AB274
		public Span<byte> GetLevelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009EAF RID: 40623 RVA: 0x002AD084 File Offset: 0x002AB284
		public byte[] GetLevelNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700213C RID: 8508
		// (get) Token: 0x06009EB0 RID: 40624 RVA: 0x002AD09C File Offset: 0x002AB29C
		public string LevelDesc
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

		// Token: 0x06009EB1 RID: 40625 RVA: 0x002AD0D4 File Offset: 0x002AB2D4
		public Span<byte> GetLevelDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009EB2 RID: 40626 RVA: 0x002AD0E4 File Offset: 0x002AB2E4
		public byte[] GetLevelDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700213D RID: 8509
		// (get) Token: 0x06009EB3 RID: 40627 RVA: 0x002AD0FC File Offset: 0x002AB2FC
		public string LevelTexture
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

		// Token: 0x06009EB4 RID: 40628 RVA: 0x002AD134 File Offset: 0x002AB334
		public Span<byte> GetLevelTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06009EB5 RID: 40629 RVA: 0x002AD144 File Offset: 0x002AB344
		public byte[] GetLevelTextureArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700213E RID: 8510
		// (get) Token: 0x06009EB6 RID: 40630 RVA: 0x002AD15C File Offset: 0x002AB35C
		public string SerialNumber
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

		// Token: 0x06009EB7 RID: 40631 RVA: 0x002AD194 File Offset: 0x002AB394
		public Span<byte> GetSerialNumberBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009EB8 RID: 40632 RVA: 0x002AD1A4 File Offset: 0x002AB3A4
		public byte[] GetSerialNumberArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700213F RID: 8511
		// (get) Token: 0x06009EB9 RID: 40633 RVA: 0x002AD1BC File Offset: 0x002AB3BC
		public int RewardId
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

		// Token: 0x06009EBA RID: 40634 RVA: 0x002AD1FC File Offset: 0x002AB3FC
		public int RecommnedRoleList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x06009EBB RID: 40635 RVA: 0x002AD23C File Offset: 0x002AB43C
		public int RecommnedRoleListLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009EBC RID: 40636 RVA: 0x002AD268 File Offset: 0x002AB468
		public Span<int> GetRecommnedRoleListBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06009EBD RID: 40637 RVA: 0x002AD278 File Offset: 0x002AB478
		public int[] GetRecommnedRoleListArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x06009EBE RID: 40638 RVA: 0x002AD290 File Offset: 0x002AB490
		public int Column
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

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x06009EBF RID: 40639 RVA: 0x002AD2D0 File Offset: 0x002AB4D0
		public int Row
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

		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x06009EC0 RID: 40640 RVA: 0x002AD310 File Offset: 0x002AB510
		public string LevelBg
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

		// Token: 0x06009EC1 RID: 40641 RVA: 0x002AD348 File Offset: 0x002AB548
		public Span<byte> GetLevelBgBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06009EC2 RID: 40642 RVA: 0x002AD358 File Offset: 0x002AB558
		public byte[] GetLevelBgArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x06009EC3 RID: 40643 RVA: 0x002AD370 File Offset: 0x002AB570
		[NullableContext(1)]
		public int[] PreId()
		{
			return this.GetPreIdArray();
		}

		// Token: 0x06009EC4 RID: 40644 RVA: 0x002AD378 File Offset: 0x002AB578
		[NullableContext(1)]
		public IEnumerable<int> PreIdIter()
		{
			MotorFightLevel.<PreIdIter>d__55 <PreIdIter>d__ = new MotorFightLevel.<PreIdIter>d__55(-2);
			<PreIdIter>d__.<>3__<>4__this = this;
			return <PreIdIter>d__;
		}

		// Token: 0x06009EC5 RID: 40645 RVA: 0x002AD38D File Offset: 0x002AB58D
		[NullableContext(1)]
		public int[] RecommnedRoleList()
		{
			return this.GetRecommnedRoleListArray();
		}

		// Token: 0x06009EC6 RID: 40646 RVA: 0x002AD395 File Offset: 0x002AB595
		[NullableContext(1)]
		public IEnumerable<int> RecommnedRoleListIter()
		{
			MotorFightLevel.<RecommnedRoleListIter>d__57 <RecommnedRoleListIter>d__ = new MotorFightLevel.<RecommnedRoleListIter>d__57(-2);
			<RecommnedRoleListIter>d__.<>3__<>4__this = this;
			return <RecommnedRoleListIter>d__;
		}

		// Token: 0x040054D3 RID: 21715
		private Table __p;
	}
}
