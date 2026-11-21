using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F49 RID: 3913
	public struct MotorParkourReward : IFlatbufferObject
	{
		// Token: 0x17002258 RID: 8792
		// (get) Token: 0x0600A19A RID: 41370 RVA: 0x002B378D File Offset: 0x002B198D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A19B RID: 41371 RVA: 0x002B379A File Offset: 0x002B199A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A19C RID: 41372 RVA: 0x002B37A4 File Offset: 0x002B19A4
		public static MotorParkourReward GetRootAsMotorParkourReward(ByteBuffer _bb)
		{
			return MotorParkourReward.GetRootAsMotorParkourReward(_bb, default(MotorParkourReward));
		}

		// Token: 0x0600A19D RID: 41373 RVA: 0x002B37C0 File Offset: 0x002B19C0
		public static MotorParkourReward GetRootAsMotorParkourReward(ByteBuffer _bb, MotorParkourReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A19E RID: 41374 RVA: 0x002B37DD File Offset: 0x002B19DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A19F RID: 41375 RVA: 0x002B37EC File Offset: 0x002B19EC
		public MotorParkourReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002259 RID: 8793
		// (get) Token: 0x0600A1A0 RID: 41376 RVA: 0x002B37FC File Offset: 0x002B19FC
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

		// Token: 0x1700225A RID: 8794
		// (get) Token: 0x0600A1A1 RID: 41377 RVA: 0x002B3838 File Offset: 0x002B1A38
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

		// Token: 0x0600A1A2 RID: 41378 RVA: 0x002B386F File Offset: 0x002B1A6F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A1A3 RID: 41379 RVA: 0x002B387E File Offset: 0x002B1A7E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700225B RID: 8795
		// (get) Token: 0x0600A1A4 RID: 41380 RVA: 0x002B3898 File Offset: 0x002B1A98
		public int DropId
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

		// Token: 0x1700225C RID: 8796
		// (get) Token: 0x0600A1A5 RID: 41381 RVA: 0x002B38D4 File Offset: 0x002B1AD4
		public int JumpId
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

		// Token: 0x1700225D RID: 8797
		// (get) Token: 0x0600A1A6 RID: 41382 RVA: 0x002B3914 File Offset: 0x002B1B14
		public int RecordId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040054F5 RID: 21749
		private Table __p;
	}
}
