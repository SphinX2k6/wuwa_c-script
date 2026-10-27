using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B32 RID: 2866
	public struct BirthDay : IFlatbufferObject
	{
		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06004D42 RID: 19778 RVA: 0x001E3A74 File Offset: 0x001E1C74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004D43 RID: 19779 RVA: 0x001E3A81 File Offset: 0x001E1C81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004D44 RID: 19780 RVA: 0x001E3A88 File Offset: 0x001E1C88
		public static BirthDay GetRootAsBirthDay(ByteBuffer _bb)
		{
			return BirthDay.GetRootAsBirthDay(_bb, default(BirthDay));
		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x001E3AA4 File Offset: 0x001E1CA4
		public static BirthDay GetRootAsBirthDay(ByteBuffer _bb, BirthDay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004D46 RID: 19782 RVA: 0x001E3AC1 File Offset: 0x001E1CC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004D47 RID: 19783 RVA: 0x001E3AD0 File Offset: 0x001E1CD0
		public BirthDay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06004D48 RID: 19784 RVA: 0x001E3AE0 File Offset: 0x001E1CE0
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

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06004D49 RID: 19785 RVA: 0x001E3B1C File Offset: 0x001E1D1C
		public int LimitYear
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

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06004D4A RID: 19786 RVA: 0x001E3B58 File Offset: 0x001E1D58
		public int BirthDayCardItemId
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

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06004D4B RID: 19787 RVA: 0x001E3B94 File Offset: 0x001E1D94
		public int SendShortMessage
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

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06004D4C RID: 19788 RVA: 0x001E3BD4 File Offset: 0x001E1DD4
		public int BirthDayReward
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

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06004D4D RID: 19789 RVA: 0x001E3C14 File Offset: 0x001E1E14
		public int ValidDay
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06004D4E RID: 19790 RVA: 0x001E3C54 File Offset: 0x001E1E54
		public string CakePic
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004D4F RID: 19791 RVA: 0x001E3C8C File Offset: 0x001E1E8C
		public Span<byte> GetCakePicBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004D50 RID: 19792 RVA: 0x001E3C9C File Offset: 0x001E1E9C
		public byte[] GetCakePicArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06004D51 RID: 19793 RVA: 0x001E3CB4 File Offset: 0x001E1EB4
		public string PhoneMsgCakeIcon
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004D52 RID: 19794 RVA: 0x001E3CEC File Offset: 0x001E1EEC
		public Span<byte> GetPhoneMsgCakeIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004D53 RID: 19795 RVA: 0x001E3CFC File Offset: 0x001E1EFC
		public byte[] GetPhoneMsgCakeIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06004D54 RID: 19796 RVA: 0x001E3D14 File Offset: 0x001E1F14
		public string PhoneMsgCakeBg
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004D55 RID: 19797 RVA: 0x001E3D4C File Offset: 0x001E1F4C
		public Span<byte> GetPhoneMsgCakeBgBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004D56 RID: 19798 RVA: 0x001E3D5C File Offset: 0x001E1F5C
		public byte[] GetPhoneMsgCakeBgArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06004D57 RID: 19799 RVA: 0x001E3D74 File Offset: 0x001E1F74
		public string PhoneMsgHighLightCakeBg
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004D58 RID: 19800 RVA: 0x001E3DAC File Offset: 0x001E1FAC
		public Span<byte> GetPhoneMsgHighLightCakeBgBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004D59 RID: 19801 RVA: 0x001E3DBC File Offset: 0x001E1FBC
		public byte[] GetPhoneMsgHighLightCakeBgArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B2D RID: 19245
		private Table __p;
	}
}
