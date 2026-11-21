using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C12 RID: 3090
	public struct BirthDay : IFlatbufferObject
	{
		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06005304 RID: 21252 RVA: 0x00203DD8 File Offset: 0x00201FD8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005305 RID: 21253 RVA: 0x00203DE5 File Offset: 0x00201FE5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x00203DEC File Offset: 0x00201FEC
		public static BirthDay GetRootAsBirthDay(ByteBuffer _bb)
		{
			return BirthDay.GetRootAsBirthDay(_bb, default(BirthDay));
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x00203E08 File Offset: 0x00202008
		public static BirthDay GetRootAsBirthDay(ByteBuffer _bb, BirthDay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x00203E25 File Offset: 0x00202025
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x00203E34 File Offset: 0x00202034
		public BirthDay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x0600530A RID: 21258 RVA: 0x00203E44 File Offset: 0x00202044
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

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600530B RID: 21259 RVA: 0x00203E80 File Offset: 0x00202080
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

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x0600530C RID: 21260 RVA: 0x00203EBC File Offset: 0x002020BC
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

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600530D RID: 21261 RVA: 0x00203EF8 File Offset: 0x002020F8
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

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x0600530E RID: 21262 RVA: 0x00203F38 File Offset: 0x00202138
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

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600530F RID: 21263 RVA: 0x00203F78 File Offset: 0x00202178
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

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06005310 RID: 21264 RVA: 0x00203FB8 File Offset: 0x002021B8
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

		// Token: 0x06005311 RID: 21265 RVA: 0x00203FF0 File Offset: 0x002021F0
		public Span<byte> GetCakePicBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005312 RID: 21266 RVA: 0x00204000 File Offset: 0x00202200
		public byte[] GetCakePicArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06005313 RID: 21267 RVA: 0x00204018 File Offset: 0x00202218
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

		// Token: 0x06005314 RID: 21268 RVA: 0x00204050 File Offset: 0x00202250
		public Span<byte> GetPhoneMsgCakeIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005315 RID: 21269 RVA: 0x00204060 File Offset: 0x00202260
		public byte[] GetPhoneMsgCakeIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06005316 RID: 21270 RVA: 0x00204078 File Offset: 0x00202278
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

		// Token: 0x06005317 RID: 21271 RVA: 0x002040B0 File Offset: 0x002022B0
		public Span<byte> GetPhoneMsgCakeBgBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005318 RID: 21272 RVA: 0x002040C0 File Offset: 0x002022C0
		public byte[] GetPhoneMsgCakeBgArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06005319 RID: 21273 RVA: 0x002040D8 File Offset: 0x002022D8
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

		// Token: 0x0600531A RID: 21274 RVA: 0x00204110 File Offset: 0x00202310
		public Span<byte> GetPhoneMsgHighLightCakeBgBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600531B RID: 21275 RVA: 0x00204120 File Offset: 0x00202320
		public byte[] GetPhoneMsgHighLightCakeBgArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0400510D RID: 20749
		private Table __p;
	}
}
