using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA7 RID: 3751
	public struct OutAreaBorderConfig : IFlatbufferObject
	{
		// Token: 0x17002467 RID: 9319
		// (get) Token: 0x0600A23B RID: 41531 RVA: 0x002A4B58 File Offset: 0x002A2D58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A23C RID: 41532 RVA: 0x002A4B65 File Offset: 0x002A2D65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A23D RID: 41533 RVA: 0x002A4B6C File Offset: 0x002A2D6C
		public static OutAreaBorderConfig GetRootAsOutAreaBorderConfig(ByteBuffer _bb)
		{
			return OutAreaBorderConfig.GetRootAsOutAreaBorderConfig(_bb, default(OutAreaBorderConfig));
		}

		// Token: 0x0600A23E RID: 41534 RVA: 0x002A4B88 File Offset: 0x002A2D88
		public static OutAreaBorderConfig GetRootAsOutAreaBorderConfig(ByteBuffer _bb, OutAreaBorderConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A23F RID: 41535 RVA: 0x002A4BA5 File Offset: 0x002A2DA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A240 RID: 41536 RVA: 0x002A4BB4 File Offset: 0x002A2DB4
		public OutAreaBorderConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002468 RID: 9320
		// (get) Token: 0x0600A241 RID: 41537 RVA: 0x002A4BC4 File Offset: 0x002A2DC4
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

		// Token: 0x17002469 RID: 9321
		// (get) Token: 0x0600A242 RID: 41538 RVA: 0x002A4C00 File Offset: 0x002A2E00
		public string Desc
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

		// Token: 0x0600A243 RID: 41539 RVA: 0x002A4C37 File Offset: 0x002A2E37
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A244 RID: 41540 RVA: 0x002A4C46 File Offset: 0x002A2E46
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700246A RID: 9322
		// (get) Token: 0x0600A245 RID: 41541 RVA: 0x002A4C60 File Offset: 0x002A2E60
		public string Data
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

		// Token: 0x0600A246 RID: 41542 RVA: 0x002A4C97 File Offset: 0x002A2E97
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A247 RID: 41543 RVA: 0x002A4CA6 File Offset: 0x002A2EA6
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700246B RID: 9323
		// (get) Token: 0x0600A248 RID: 41544 RVA: 0x002A4CC0 File Offset: 0x002A2EC0
		public string TidTipText
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

		// Token: 0x0600A249 RID: 41545 RVA: 0x002A4CF8 File Offset: 0x002A2EF8
		public Span<byte> GetTidTipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A24A RID: 41546 RVA: 0x002A4D08 File Offset: 0x002A2F08
		public byte[] GetTidTipTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F5C RID: 20316
		private Table __p;
	}
}
