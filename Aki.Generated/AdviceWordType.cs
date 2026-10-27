using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE5 RID: 2789
	public struct AdviceWordType : IFlatbufferObject
	{
		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06004615 RID: 17941 RVA: 0x001D1BC5 File Offset: 0x001CFDC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x001D1BD2 File Offset: 0x001CFDD2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004617 RID: 17943 RVA: 0x001D1BDC File Offset: 0x001CFDDC
		public static AdviceWordType GetRootAsAdviceWordType(ByteBuffer _bb)
		{
			return AdviceWordType.GetRootAsAdviceWordType(_bb, default(AdviceWordType));
		}

		// Token: 0x06004618 RID: 17944 RVA: 0x001D1BF8 File Offset: 0x001CFDF8
		public static AdviceWordType GetRootAsAdviceWordType(ByteBuffer _bb, AdviceWordType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x001D1C15 File Offset: 0x001CFE15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x001D1C24 File Offset: 0x001CFE24
		public AdviceWordType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600461B RID: 17947 RVA: 0x001D1C34 File Offset: 0x001CFE34
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

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600461C RID: 17948 RVA: 0x001D1C70 File Offset: 0x001CFE70
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

		// Token: 0x0600461D RID: 17949 RVA: 0x001D1CA7 File Offset: 0x001CFEA7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x001D1CB6 File Offset: 0x001CFEB6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AC5 RID: 19141
		private Table __p;
	}
}
