using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F2B RID: 3883
	public struct PinballEffect : IFlatbufferObject
	{
		// Token: 0x1700293E RID: 10558
		// (get) Token: 0x0600AECF RID: 44751 RVA: 0x002C16D5 File Offset: 0x002BF8D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AED0 RID: 44752 RVA: 0x002C16E2 File Offset: 0x002BF8E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AED1 RID: 44753 RVA: 0x002C16EC File Offset: 0x002BF8EC
		public static PinballEffect GetRootAsPinballEffect(ByteBuffer _bb)
		{
			return PinballEffect.GetRootAsPinballEffect(_bb, default(PinballEffect));
		}

		// Token: 0x0600AED2 RID: 44754 RVA: 0x002C1708 File Offset: 0x002BF908
		public static PinballEffect GetRootAsPinballEffect(ByteBuffer _bb, PinballEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AED3 RID: 44755 RVA: 0x002C1725 File Offset: 0x002BF925
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AED4 RID: 44756 RVA: 0x002C1734 File Offset: 0x002BF934
		public PinballEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700293F RID: 10559
		// (get) Token: 0x0600AED5 RID: 44757 RVA: 0x002C1744 File Offset: 0x002BF944
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

		// Token: 0x17002940 RID: 10560
		// (get) Token: 0x0600AED6 RID: 44758 RVA: 0x002C1780 File Offset: 0x002BF980
		public int Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002941 RID: 10561
		// (get) Token: 0x0600AED7 RID: 44759 RVA: 0x002C17BC File Offset: 0x002BF9BC
		public string Param1
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

		// Token: 0x0600AED8 RID: 44760 RVA: 0x002C17F3 File Offset: 0x002BF9F3
		public Span<byte> GetParam1Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AED9 RID: 44761 RVA: 0x002C1802 File Offset: 0x002BFA02
		public byte[] GetParam1Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002942 RID: 10562
		// (get) Token: 0x0600AEDA RID: 44762 RVA: 0x002C181C File Offset: 0x002BFA1C
		public string Param2
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

		// Token: 0x0600AEDB RID: 44763 RVA: 0x002C1854 File Offset: 0x002BFA54
		public Span<byte> GetParam2Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AEDC RID: 44764 RVA: 0x002C1864 File Offset: 0x002BFA64
		public byte[] GetParam2Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002943 RID: 10563
		// (get) Token: 0x0600AEDD RID: 44765 RVA: 0x002C187C File Offset: 0x002BFA7C
		public string Param3
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

		// Token: 0x0600AEDE RID: 44766 RVA: 0x002C18B4 File Offset: 0x002BFAB4
		public Span<byte> GetParam3Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AEDF RID: 44767 RVA: 0x002C18C4 File Offset: 0x002BFAC4
		public byte[] GetParam3Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004FF4 RID: 20468
		private Table __p;
	}
}
