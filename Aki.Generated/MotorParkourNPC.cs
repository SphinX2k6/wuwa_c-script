using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F46 RID: 3910
	public struct MotorParkourNPC : IFlatbufferObject
	{
		// Token: 0x1700224C RID: 8780
		// (get) Token: 0x0600A174 RID: 41332 RVA: 0x002B334C File Offset: 0x002B154C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A175 RID: 41333 RVA: 0x002B3359 File Offset: 0x002B1559
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A176 RID: 41334 RVA: 0x002B3360 File Offset: 0x002B1560
		public static MotorParkourNPC GetRootAsMotorParkourNPC(ByteBuffer _bb)
		{
			return MotorParkourNPC.GetRootAsMotorParkourNPC(_bb, default(MotorParkourNPC));
		}

		// Token: 0x0600A177 RID: 41335 RVA: 0x002B337C File Offset: 0x002B157C
		public static MotorParkourNPC GetRootAsMotorParkourNPC(ByteBuffer _bb, MotorParkourNPC obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A178 RID: 41336 RVA: 0x002B3399 File Offset: 0x002B1599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A179 RID: 41337 RVA: 0x002B33A8 File Offset: 0x002B15A8
		public MotorParkourNPC __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700224D RID: 8781
		// (get) Token: 0x0600A17A RID: 41338 RVA: 0x002B33B8 File Offset: 0x002B15B8
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

		// Token: 0x1700224E RID: 8782
		// (get) Token: 0x0600A17B RID: 41339 RVA: 0x002B33F4 File Offset: 0x002B15F4
		public string Name
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

		// Token: 0x0600A17C RID: 41340 RVA: 0x002B342B File Offset: 0x002B162B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A17D RID: 41341 RVA: 0x002B343A File Offset: 0x002B163A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040054F2 RID: 21746
		private Table __p;
	}
}
