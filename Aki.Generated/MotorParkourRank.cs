using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F47 RID: 3911
	public struct MotorParkourRank : IFlatbufferObject
	{
		// Token: 0x1700224F RID: 8783
		// (get) Token: 0x0600A17E RID: 41342 RVA: 0x002B3451 File Offset: 0x002B1651
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A17F RID: 41343 RVA: 0x002B345E File Offset: 0x002B165E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A180 RID: 41344 RVA: 0x002B3468 File Offset: 0x002B1668
		public static MotorParkourRank GetRootAsMotorParkourRank(ByteBuffer _bb)
		{
			return MotorParkourRank.GetRootAsMotorParkourRank(_bb, default(MotorParkourRank));
		}

		// Token: 0x0600A181 RID: 41345 RVA: 0x002B3484 File Offset: 0x002B1684
		public static MotorParkourRank GetRootAsMotorParkourRank(ByteBuffer _bb, MotorParkourRank obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A182 RID: 41346 RVA: 0x002B34A1 File Offset: 0x002B16A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A183 RID: 41347 RVA: 0x002B34B0 File Offset: 0x002B16B0
		public MotorParkourRank __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002250 RID: 8784
		// (get) Token: 0x0600A184 RID: 41348 RVA: 0x002B34C0 File Offset: 0x002B16C0
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

		// Token: 0x17002251 RID: 8785
		// (get) Token: 0x0600A185 RID: 41349 RVA: 0x002B34FC File Offset: 0x002B16FC
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

		// Token: 0x0600A186 RID: 41350 RVA: 0x002B3533 File Offset: 0x002B1733
		public Span<byte> GetSpriteNumBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A187 RID: 41351 RVA: 0x002B3542 File Offset: 0x002B1742
		public byte[] GetSpriteNumArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002252 RID: 8786
		// (get) Token: 0x0600A188 RID: 41352 RVA: 0x002B355C File Offset: 0x002B175C
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

		// Token: 0x0600A189 RID: 41353 RVA: 0x002B3593 File Offset: 0x002B1793
		public Span<byte> GetSpriteBgBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A18A RID: 41354 RVA: 0x002B35A2 File Offset: 0x002B17A2
		public byte[] GetSpriteBgArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040054F3 RID: 21747
		private Table __p;
	}
}
