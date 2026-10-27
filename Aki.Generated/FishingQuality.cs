using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C89 RID: 3209
	public struct FishingQuality : IFlatbufferObject
	{
		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x0600704C RID: 28748 RVA: 0x00233A00 File Offset: 0x00231C00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600704D RID: 28749 RVA: 0x00233A0D File Offset: 0x00231C0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600704E RID: 28750 RVA: 0x00233A14 File Offset: 0x00231C14
		public static FishingQuality GetRootAsFishingQuality(ByteBuffer _bb)
		{
			return FishingQuality.GetRootAsFishingQuality(_bb, default(FishingQuality));
		}

		// Token: 0x0600704F RID: 28751 RVA: 0x00233A30 File Offset: 0x00231C30
		public static FishingQuality GetRootAsFishingQuality(ByteBuffer _bb, FishingQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007050 RID: 28752 RVA: 0x00233A4D File Offset: 0x00231C4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007051 RID: 28753 RVA: 0x00233A5C File Offset: 0x00231C5C
		public FishingQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x06007052 RID: 28754 RVA: 0x00233A6C File Offset: 0x00231C6C
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

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x06007053 RID: 28755 RVA: 0x00233AA8 File Offset: 0x00231CA8
		public string TxtColor
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

		// Token: 0x06007054 RID: 28756 RVA: 0x00233ADF File Offset: 0x00231CDF
		public Span<byte> GetTxtColorBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007055 RID: 28757 RVA: 0x00233AEE File Offset: 0x00231CEE
		public byte[] GetTxtColorArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x06007056 RID: 28758 RVA: 0x00233B08 File Offset: 0x00231D08
		public string TexBg
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

		// Token: 0x06007057 RID: 28759 RVA: 0x00233B3F File Offset: 0x00231D3F
		public Span<byte> GetTexBgBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007058 RID: 28760 RVA: 0x00233B4E File Offset: 0x00231D4E
		public byte[] GetTexBgArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x06007059 RID: 28761 RVA: 0x00233B68 File Offset: 0x00231D68
		public string GridColor
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

		// Token: 0x0600705A RID: 28762 RVA: 0x00233BA0 File Offset: 0x00231DA0
		public Span<byte> GetGridColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600705B RID: 28763 RVA: 0x00233BB0 File Offset: 0x00231DB0
		public byte[] GetGridColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x0600705C RID: 28764 RVA: 0x00233BC8 File Offset: 0x00231DC8
		public string GridSprite
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

		// Token: 0x0600705D RID: 28765 RVA: 0x00233C00 File Offset: 0x00231E00
		public Span<byte> GetGridSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600705E RID: 28766 RVA: 0x00233C10 File Offset: 0x00231E10
		public byte[] GetGridSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CDE RID: 19678
		private Table __p;
	}
}
