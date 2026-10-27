using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E6E RID: 3694
	public struct MotorTechLv : IFlatbufferObject
	{
		// Token: 0x17002268 RID: 8808
		// (get) Token: 0x06009CC0 RID: 40128 RVA: 0x00298B1D File Offset: 0x00296D1D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009CC1 RID: 40129 RVA: 0x00298B2A File Offset: 0x00296D2A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009CC2 RID: 40130 RVA: 0x00298B34 File Offset: 0x00296D34
		public static MotorTechLv GetRootAsMotorTechLv(ByteBuffer _bb)
		{
			return MotorTechLv.GetRootAsMotorTechLv(_bb, default(MotorTechLv));
		}

		// Token: 0x06009CC3 RID: 40131 RVA: 0x00298B50 File Offset: 0x00296D50
		public static MotorTechLv GetRootAsMotorTechLv(ByteBuffer _bb, MotorTechLv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009CC4 RID: 40132 RVA: 0x00298B6D File Offset: 0x00296D6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009CC5 RID: 40133 RVA: 0x00298B7C File Offset: 0x00296D7C
		public MotorTechLv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002269 RID: 8809
		// (get) Token: 0x06009CC6 RID: 40134 RVA: 0x00298B8C File Offset: 0x00296D8C
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

		// Token: 0x1700226A RID: 8810
		// (get) Token: 0x06009CC7 RID: 40135 RVA: 0x00298BC8 File Offset: 0x00296DC8
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

		// Token: 0x06009CC8 RID: 40136 RVA: 0x00298BFF File Offset: 0x00296DFF
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009CC9 RID: 40137 RVA: 0x00298C0E File Offset: 0x00296E0E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700226B RID: 8811
		// (get) Token: 0x06009CCA RID: 40138 RVA: 0x00298C28 File Offset: 0x00296E28
		public int Consume
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

		// Token: 0x1700226C RID: 8812
		// (get) Token: 0x06009CCB RID: 40139 RVA: 0x00298C64 File Offset: 0x00296E64
		public int Effect
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

		// Token: 0x04004F1C RID: 20252
		private Table __p;
	}
}
