using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F30 RID: 3888
	public struct MotorFightQuality : IFlatbufferObject
	{
		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x06009F1D RID: 40733 RVA: 0x002ADF5D File Offset: 0x002AC15D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009F1E RID: 40734 RVA: 0x002ADF6A File Offset: 0x002AC16A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009F1F RID: 40735 RVA: 0x002ADF74 File Offset: 0x002AC174
		public static MotorFightQuality GetRootAsMotorFightQuality(ByteBuffer _bb)
		{
			return MotorFightQuality.GetRootAsMotorFightQuality(_bb, default(MotorFightQuality));
		}

		// Token: 0x06009F20 RID: 40736 RVA: 0x002ADF90 File Offset: 0x002AC190
		public static MotorFightQuality GetRootAsMotorFightQuality(ByteBuffer _bb, MotorFightQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009F21 RID: 40737 RVA: 0x002ADFAD File Offset: 0x002AC1AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009F22 RID: 40738 RVA: 0x002ADFBC File Offset: 0x002AC1BC
		public MotorFightQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x06009F23 RID: 40739 RVA: 0x002ADFCC File Offset: 0x002AC1CC
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

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x06009F24 RID: 40740 RVA: 0x002AE008 File Offset: 0x002AC208
		public string SmallGridBg
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

		// Token: 0x06009F25 RID: 40741 RVA: 0x002AE03F File Offset: 0x002AC23F
		public Span<byte> GetSmallGridBgBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009F26 RID: 40742 RVA: 0x002AE04E File Offset: 0x002AC24E
		public byte[] GetSmallGridBgArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x06009F27 RID: 40743 RVA: 0x002AE068 File Offset: 0x002AC268
		public string DetailCardBg
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

		// Token: 0x06009F28 RID: 40744 RVA: 0x002AE09F File Offset: 0x002AC29F
		public Span<byte> GetDetailCardBgBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009F29 RID: 40745 RVA: 0x002AE0AE File Offset: 0x002AC2AE
		public byte[] GetDetailCardBgArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x06009F2A RID: 40746 RVA: 0x002AE0C8 File Offset: 0x002AC2C8
		public string BgColor
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

		// Token: 0x06009F2B RID: 40747 RVA: 0x002AE100 File Offset: 0x002AC300
		public Span<byte> GetBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009F2C RID: 40748 RVA: 0x002AE110 File Offset: 0x002AC310
		public byte[] GetBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x06009F2D RID: 40749 RVA: 0x002AE128 File Offset: 0x002AC328
		public string DoorBuffGateBg
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

		// Token: 0x06009F2E RID: 40750 RVA: 0x002AE160 File Offset: 0x002AC360
		public Span<byte> GetDoorBuffGateBgBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009F2F RID: 40751 RVA: 0x002AE170 File Offset: 0x002AC370
		public byte[] GetDoorBuffGateBgArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x06009F30 RID: 40752 RVA: 0x002AE188 File Offset: 0x002AC388
		public string DropBuffGateBg
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

		// Token: 0x06009F31 RID: 40753 RVA: 0x002AE1C0 File Offset: 0x002AC3C0
		public Span<byte> GetDropBuffGateBgBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009F32 RID: 40754 RVA: 0x002AE1D0 File Offset: 0x002AC3D0
		public byte[] GetDropBuffGateBgArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040054D8 RID: 21720
		private Table __p;
	}
}
