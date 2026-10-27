using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C2D RID: 3117
	public struct EncircleChallenge : IFlatbufferObject
	{
		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x060068AE RID: 26798 RVA: 0x00222343 File Offset: 0x00220543
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060068AF RID: 26799 RVA: 0x00222350 File Offset: 0x00220550
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060068B0 RID: 26800 RVA: 0x00222358 File Offset: 0x00220558
		public static EncircleChallenge GetRootAsEncircleChallenge(ByteBuffer _bb)
		{
			return EncircleChallenge.GetRootAsEncircleChallenge(_bb, default(EncircleChallenge));
		}

		// Token: 0x060068B1 RID: 26801 RVA: 0x00222374 File Offset: 0x00220574
		public static EncircleChallenge GetRootAsEncircleChallenge(ByteBuffer _bb, EncircleChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060068B2 RID: 26802 RVA: 0x00222391 File Offset: 0x00220591
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060068B3 RID: 26803 RVA: 0x002223A0 File Offset: 0x002205A0
		public EncircleChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x060068B4 RID: 26804 RVA: 0x002223B0 File Offset: 0x002205B0
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

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x060068B5 RID: 26805 RVA: 0x002223EC File Offset: 0x002205EC
		public int PreId
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

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x060068B6 RID: 26806 RVA: 0x00222428 File Offset: 0x00220628
		public int Difficulty
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

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x060068B7 RID: 26807 RVA: 0x00222464 File Offset: 0x00220664
		public string LevelTitle
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

		// Token: 0x060068B8 RID: 26808 RVA: 0x0022249C File Offset: 0x0022069C
		public Span<byte> GetLevelTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060068B9 RID: 26809 RVA: 0x002224AC File Offset: 0x002206AC
		public byte[] GetLevelTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x060068BA RID: 26810 RVA: 0x002224C4 File Offset: 0x002206C4
		public string LevelDesc
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

		// Token: 0x060068BB RID: 26811 RVA: 0x002224FC File Offset: 0x002206FC
		public Span<byte> GetLevelDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060068BC RID: 26812 RVA: 0x0022250C File Offset: 0x0022070C
		public byte[] GetLevelDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x060068BD RID: 26813 RVA: 0x00222524 File Offset: 0x00220724
		public string LevelIcon
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

		// Token: 0x060068BE RID: 26814 RVA: 0x0022255C File Offset: 0x0022075C
		public Span<byte> GetLevelIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x0022256C File Offset: 0x0022076C
		public byte[] GetLevelIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x060068C0 RID: 26816 RVA: 0x00222584 File Offset: 0x00220784
		public int RewardId
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

		// Token: 0x04004C6D RID: 19565
		private Table __p;
	}
}
