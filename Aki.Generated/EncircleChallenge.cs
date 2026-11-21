using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D10 RID: 3344
	public struct EncircleChallenge : IFlatbufferObject
	{
		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06006EB0 RID: 28336 RVA: 0x00241853 File Offset: 0x0023FA53
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006EB1 RID: 28337 RVA: 0x00241860 File Offset: 0x0023FA60
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006EB2 RID: 28338 RVA: 0x00241868 File Offset: 0x0023FA68
		public static EncircleChallenge GetRootAsEncircleChallenge(ByteBuffer _bb)
		{
			return EncircleChallenge.GetRootAsEncircleChallenge(_bb, default(EncircleChallenge));
		}

		// Token: 0x06006EB3 RID: 28339 RVA: 0x00241884 File Offset: 0x0023FA84
		public static EncircleChallenge GetRootAsEncircleChallenge(ByteBuffer _bb, EncircleChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006EB4 RID: 28340 RVA: 0x002418A1 File Offset: 0x0023FAA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006EB5 RID: 28341 RVA: 0x002418B0 File Offset: 0x0023FAB0
		public EncircleChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06006EB6 RID: 28342 RVA: 0x002418C0 File Offset: 0x0023FAC0
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

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06006EB7 RID: 28343 RVA: 0x002418FC File Offset: 0x0023FAFC
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

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06006EB8 RID: 28344 RVA: 0x00241938 File Offset: 0x0023FB38
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

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06006EB9 RID: 28345 RVA: 0x00241974 File Offset: 0x0023FB74
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

		// Token: 0x06006EBA RID: 28346 RVA: 0x002419AC File Offset: 0x0023FBAC
		public Span<byte> GetLevelTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006EBB RID: 28347 RVA: 0x002419BC File Offset: 0x0023FBBC
		public byte[] GetLevelTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06006EBC RID: 28348 RVA: 0x002419D4 File Offset: 0x0023FBD4
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

		// Token: 0x06006EBD RID: 28349 RVA: 0x00241A0C File Offset: 0x0023FC0C
		public Span<byte> GetLevelDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006EBE RID: 28350 RVA: 0x00241A1C File Offset: 0x0023FC1C
		public byte[] GetLevelDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06006EBF RID: 28351 RVA: 0x00241A34 File Offset: 0x0023FC34
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

		// Token: 0x06006EC0 RID: 28352 RVA: 0x00241A6C File Offset: 0x0023FC6C
		public Span<byte> GetLevelIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006EC1 RID: 28353 RVA: 0x00241A7C File Offset: 0x0023FC7C
		public byte[] GetLevelIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06006EC2 RID: 28354 RVA: 0x00241A94 File Offset: 0x0023FC94
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

		// Token: 0x04005250 RID: 21072
		private Table __p;
	}
}
