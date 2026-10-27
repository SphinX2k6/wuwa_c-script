using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E62 RID: 3682
	public struct MotorParkourRank : IFlatbufferObject
	{
		// Token: 0x170021EA RID: 8682
		// (get) Token: 0x06009B5E RID: 39774 RVA: 0x00295B05 File Offset: 0x00293D05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009B5F RID: 39775 RVA: 0x00295B12 File Offset: 0x00293D12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009B60 RID: 39776 RVA: 0x00295B1C File Offset: 0x00293D1C
		public static MotorParkourRank GetRootAsMotorParkourRank(ByteBuffer _bb)
		{
			return MotorParkourRank.GetRootAsMotorParkourRank(_bb, default(MotorParkourRank));
		}

		// Token: 0x06009B61 RID: 39777 RVA: 0x00295B38 File Offset: 0x00293D38
		public static MotorParkourRank GetRootAsMotorParkourRank(ByteBuffer _bb, MotorParkourRank obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009B62 RID: 39778 RVA: 0x00295B55 File Offset: 0x00293D55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009B63 RID: 39779 RVA: 0x00295B64 File Offset: 0x00293D64
		public MotorParkourRank __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021EB RID: 8683
		// (get) Token: 0x06009B64 RID: 39780 RVA: 0x00295B74 File Offset: 0x00293D74
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

		// Token: 0x170021EC RID: 8684
		// (get) Token: 0x06009B65 RID: 39781 RVA: 0x00295BB0 File Offset: 0x00293DB0
		public string SpriteNum
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

		// Token: 0x06009B66 RID: 39782 RVA: 0x00295BE7 File Offset: 0x00293DE7
		public Span<byte> GetSpriteNumBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009B67 RID: 39783 RVA: 0x00295BF6 File Offset: 0x00293DF6
		public byte[] GetSpriteNumArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170021ED RID: 8685
		// (get) Token: 0x06009B68 RID: 39784 RVA: 0x00295C10 File Offset: 0x00293E10
		public string SpriteBg
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

		// Token: 0x06009B69 RID: 39785 RVA: 0x00295C47 File Offset: 0x00293E47
		public Span<byte> GetSpriteBgBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009B6A RID: 39786 RVA: 0x00295C56 File Offset: 0x00293E56
		public byte[] GetSpriteBgArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F0E RID: 20238
		private Table __p;
	}
}
