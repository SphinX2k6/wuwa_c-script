using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F53 RID: 3923
	public struct MotorTechLv : IFlatbufferObject
	{
		// Token: 0x170022CD RID: 8909
		// (get) Token: 0x0600A2E0 RID: 41696 RVA: 0x002B637B File Offset: 0x002B457B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A2E1 RID: 41697 RVA: 0x002B6388 File Offset: 0x002B4588
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A2E2 RID: 41698 RVA: 0x002B6390 File Offset: 0x002B4590
		public static MotorTechLv GetRootAsMotorTechLv(ByteBuffer _bb)
		{
			return MotorTechLv.GetRootAsMotorTechLv(_bb, default(MotorTechLv));
		}

		// Token: 0x0600A2E3 RID: 41699 RVA: 0x002B63AC File Offset: 0x002B45AC
		public static MotorTechLv GetRootAsMotorTechLv(ByteBuffer _bb, MotorTechLv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A2E4 RID: 41700 RVA: 0x002B63C9 File Offset: 0x002B45C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A2E5 RID: 41701 RVA: 0x002B63D8 File Offset: 0x002B45D8
		public MotorTechLv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022CE RID: 8910
		// (get) Token: 0x0600A2E6 RID: 41702 RVA: 0x002B63E8 File Offset: 0x002B45E8
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

		// Token: 0x170022CF RID: 8911
		// (get) Token: 0x0600A2E7 RID: 41703 RVA: 0x002B6424 File Offset: 0x002B4624
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

		// Token: 0x0600A2E8 RID: 41704 RVA: 0x002B645B File Offset: 0x002B465B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A2E9 RID: 41705 RVA: 0x002B646A File Offset: 0x002B466A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170022D0 RID: 8912
		// (get) Token: 0x0600A2EA RID: 41706 RVA: 0x002B6484 File Offset: 0x002B4684
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

		// Token: 0x170022D1 RID: 8913
		// (get) Token: 0x0600A2EB RID: 41707 RVA: 0x002B64C0 File Offset: 0x002B46C0
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

		// Token: 0x04005501 RID: 21761
		private Table __p;
	}
}
