using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F21 RID: 3873
	public struct PinballAvgStyleConfig : IFlatbufferObject
	{
		// Token: 0x170028F1 RID: 10481
		// (get) Token: 0x0600AE01 RID: 44545 RVA: 0x002BFBA1 File Offset: 0x002BDDA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AE02 RID: 44546 RVA: 0x002BFBAE File Offset: 0x002BDDAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AE03 RID: 44547 RVA: 0x002BFBB8 File Offset: 0x002BDDB8
		public static PinballAvgStyleConfig GetRootAsPinballAvgStyleConfig(ByteBuffer _bb)
		{
			return PinballAvgStyleConfig.GetRootAsPinballAvgStyleConfig(_bb, default(PinballAvgStyleConfig));
		}

		// Token: 0x0600AE04 RID: 44548 RVA: 0x002BFBD4 File Offset: 0x002BDDD4
		public static PinballAvgStyleConfig GetRootAsPinballAvgStyleConfig(ByteBuffer _bb, PinballAvgStyleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AE05 RID: 44549 RVA: 0x002BFBF1 File Offset: 0x002BDDF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AE06 RID: 44550 RVA: 0x002BFC00 File Offset: 0x002BDE00
		public PinballAvgStyleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170028F2 RID: 10482
		// (get) Token: 0x0600AE07 RID: 44551 RVA: 0x002BFC10 File Offset: 0x002BDE10
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

		// Token: 0x170028F3 RID: 10483
		// (get) Token: 0x0600AE08 RID: 44552 RVA: 0x002BFC4C File Offset: 0x002BDE4C
		public string BgTexture
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

		// Token: 0x0600AE09 RID: 44553 RVA: 0x002BFC83 File Offset: 0x002BDE83
		public Span<byte> GetBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AE0A RID: 44554 RVA: 0x002BFC92 File Offset: 0x002BDE92
		public byte[] GetBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170028F4 RID: 10484
		// (get) Token: 0x0600AE0B RID: 44555 RVA: 0x002BFCAC File Offset: 0x002BDEAC
		public string DecorationTexture
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

		// Token: 0x0600AE0C RID: 44556 RVA: 0x002BFCE3 File Offset: 0x002BDEE3
		public Span<byte> GetDecorationTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AE0D RID: 44557 RVA: 0x002BFCF2 File Offset: 0x002BDEF2
		public byte[] GetDecorationTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004FEA RID: 20458
		private Table __p;
	}
}
