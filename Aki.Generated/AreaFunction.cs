using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B03 RID: 2819
	public struct AreaFunction : IFlatbufferObject
	{
		// Token: 0x17000336 RID: 822
		// (get) Token: 0x0600488B RID: 18571 RVA: 0x001D7BE9 File Offset: 0x001D5DE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600488C RID: 18572 RVA: 0x001D7BF6 File Offset: 0x001D5DF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600488D RID: 18573 RVA: 0x001D7C00 File Offset: 0x001D5E00
		public static AreaFunction GetRootAsAreaFunction(ByteBuffer _bb)
		{
			return AreaFunction.GetRootAsAreaFunction(_bb, default(AreaFunction));
		}

		// Token: 0x0600488E RID: 18574 RVA: 0x001D7C1C File Offset: 0x001D5E1C
		public static AreaFunction GetRootAsAreaFunction(ByteBuffer _bb, AreaFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600488F RID: 18575 RVA: 0x001D7C39 File Offset: 0x001D5E39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004890 RID: 18576 RVA: 0x001D7C48 File Offset: 0x001D5E48
		public AreaFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06004891 RID: 18577 RVA: 0x001D7C58 File Offset: 0x001D5E58
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

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06004892 RID: 18578 RVA: 0x001D7C94 File Offset: 0x001D5E94
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

		// Token: 0x06004893 RID: 18579 RVA: 0x001D7CCB File Offset: 0x001D5ECB
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004894 RID: 18580 RVA: 0x001D7CDA File Offset: 0x001D5EDA
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06004895 RID: 18581 RVA: 0x001D7CF4 File Offset: 0x001D5EF4
		public string Data
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

		// Token: 0x06004896 RID: 18582 RVA: 0x001D7D2B File Offset: 0x001D5F2B
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004897 RID: 18583 RVA: 0x001D7D3A File Offset: 0x001D5F3A
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AE8 RID: 19176
		private Table __p;
	}
}
