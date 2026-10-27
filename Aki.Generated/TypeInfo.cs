using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001180 RID: 4480
	public struct TypeInfo : IFlatbufferObject
	{
		// Token: 0x17003D12 RID: 15634
		// (get) Token: 0x0600E5DC RID: 58844 RVA: 0x0033DC29 File Offset: 0x0033BE29
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E5DD RID: 58845 RVA: 0x0033DC36 File Offset: 0x0033BE36
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E5DE RID: 58846 RVA: 0x0033DC40 File Offset: 0x0033BE40
		public static TypeInfo GetRootAsTypeInfo(ByteBuffer _bb)
		{
			return TypeInfo.GetRootAsTypeInfo(_bb, default(TypeInfo));
		}

		// Token: 0x0600E5DF RID: 58847 RVA: 0x0033DC5C File Offset: 0x0033BE5C
		public static TypeInfo GetRootAsTypeInfo(ByteBuffer _bb, TypeInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E5E0 RID: 58848 RVA: 0x0033DC79 File Offset: 0x0033BE79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E5E1 RID: 58849 RVA: 0x0033DC88 File Offset: 0x0033BE88
		public TypeInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D13 RID: 15635
		// (get) Token: 0x0600E5E2 RID: 58850 RVA: 0x0033DC98 File Offset: 0x0033BE98
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

		// Token: 0x17003D14 RID: 15636
		// (get) Token: 0x0600E5E3 RID: 58851 RVA: 0x0033DCD4 File Offset: 0x0033BED4
		public string TypeDescription
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

		// Token: 0x0600E5E4 RID: 58852 RVA: 0x0033DD0B File Offset: 0x0033BF0B
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E5E5 RID: 58853 RVA: 0x0033DD1A File Offset: 0x0033BF1A
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D15 RID: 15637
		// (get) Token: 0x0600E5E6 RID: 58854 RVA: 0x0033DD34 File Offset: 0x0033BF34
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D16 RID: 15638
		// (get) Token: 0x0600E5E7 RID: 58855 RVA: 0x0033DD74 File Offset: 0x0033BF74
		public bool Deprecate
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D17 RID: 15639
		// (get) Token: 0x0600E5E8 RID: 58856 RVA: 0x0033DDB4 File Offset: 0x0033BFB4
		public bool ShowStock
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D18 RID: 15640
		// (get) Token: 0x0600E5E9 RID: 58857 RVA: 0x0033DDF4 File Offset: 0x0033BFF4
		public int SortIndex
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

		// Token: 0x17003D19 RID: 15641
		// (get) Token: 0x0600E5EA RID: 58858 RVA: 0x0033DE34 File Offset: 0x0033C034
		public int ItemInfoDisplayType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040052C7 RID: 21191
		private Table __p;
	}
}
