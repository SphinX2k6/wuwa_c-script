using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F95 RID: 3989
	public struct PayShop : IFlatbufferObject
	{
		// Token: 0x17002514 RID: 9492
		// (get) Token: 0x0600A918 RID: 43288 RVA: 0x002C3921 File Offset: 0x002C1B21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A919 RID: 43289 RVA: 0x002C392E File Offset: 0x002C1B2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A91A RID: 43290 RVA: 0x002C3938 File Offset: 0x002C1B38
		public static PayShop GetRootAsPayShop(ByteBuffer _bb)
		{
			return PayShop.GetRootAsPayShop(_bb, default(PayShop));
		}

		// Token: 0x0600A91B RID: 43291 RVA: 0x002C3954 File Offset: 0x002C1B54
		public static PayShop GetRootAsPayShop(ByteBuffer _bb, PayShop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A91C RID: 43292 RVA: 0x002C3971 File Offset: 0x002C1B71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A91D RID: 43293 RVA: 0x002C3980 File Offset: 0x002C1B80
		public PayShop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002515 RID: 9493
		// (get) Token: 0x0600A91E RID: 43294 RVA: 0x002C3990 File Offset: 0x002C1B90
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

		// Token: 0x17002516 RID: 9494
		// (get) Token: 0x0600A91F RID: 43295 RVA: 0x002C39CC File Offset: 0x002C1BCC
		public int ShopTabViewType
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

		// Token: 0x17002517 RID: 9495
		// (get) Token: 0x0600A920 RID: 43296 RVA: 0x002C3A08 File Offset: 0x002C1C08
		public int DynamicTabId
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

		// Token: 0x17002518 RID: 9496
		// (get) Token: 0x0600A921 RID: 43297 RVA: 0x002C3A44 File Offset: 0x002C1C44
		public int Sort
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

		// Token: 0x17002519 RID: 9497
		// (get) Token: 0x0600A922 RID: 43298 RVA: 0x002C3A84 File Offset: 0x002C1C84
		public string Name
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

		// Token: 0x0600A923 RID: 43299 RVA: 0x002C3ABC File Offset: 0x002C1CBC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A924 RID: 43300 RVA: 0x002C3ACC File Offset: 0x002C1CCC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A925 RID: 43301 RVA: 0x002C3AE4 File Offset: 0x002C1CE4
		public int Money(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700251A RID: 9498
		// (get) Token: 0x0600A926 RID: 43302 RVA: 0x002C3B24 File Offset: 0x002C1D24
		public int MoneyLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A927 RID: 43303 RVA: 0x002C3B50 File Offset: 0x002C1D50
		public Span<int> GetMoneyBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600A928 RID: 43304 RVA: 0x002C3B60 File Offset: 0x002C1D60
		public int[] GetMoneyArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x1700251B RID: 9499
		// (get) Token: 0x0600A929 RID: 43305 RVA: 0x002C3B78 File Offset: 0x002C1D78
		public string Notice
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

		// Token: 0x0600A92A RID: 43306 RVA: 0x002C3BB0 File Offset: 0x002C1DB0
		public Span<byte> GetNoticeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A92B RID: 43307 RVA: 0x002C3BC0 File Offset: 0x002C1DC0
		public byte[] GetNoticeArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700251C RID: 9500
		// (get) Token: 0x0600A92C RID: 43308 RVA: 0x002C3BD8 File Offset: 0x002C1DD8
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700251D RID: 9501
		// (get) Token: 0x0600A92D RID: 43309 RVA: 0x002C3C18 File Offset: 0x002C1E18
		public string Icon
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

		// Token: 0x0600A92E RID: 43310 RVA: 0x002C3C50 File Offset: 0x002C1E50
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A92F RID: 43311 RVA: 0x002C3C60 File Offset: 0x002C1E60
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700251E RID: 9502
		// (get) Token: 0x0600A930 RID: 43312 RVA: 0x002C3C78 File Offset: 0x002C1E78
		public int SortRule
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A931 RID: 43313 RVA: 0x002C3CB5 File Offset: 0x002C1EB5
		[NullableContext(1)]
		public int[] Money()
		{
			return this.GetMoneyArray();
		}

		// Token: 0x0600A932 RID: 43314 RVA: 0x002C3CBD File Offset: 0x002C1EBD
		[NullableContext(1)]
		public IEnumerable<int> MoneyIter()
		{
			PayShop.<MoneyIter>d__38 <MoneyIter>d__ = new PayShop.<MoneyIter>d__38(-2);
			<MoneyIter>d__.<>3__<>4__this = this;
			return <MoneyIter>d__;
		}

		// Token: 0x0400554B RID: 21835
		private Table __p;
	}
}
