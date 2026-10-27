using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B34 RID: 2868
	public struct BlackboardWhiteList : IFlatbufferObject
	{
		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06004D66 RID: 19814 RVA: 0x001E3F54 File Offset: 0x001E2154
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004D67 RID: 19815 RVA: 0x001E3F61 File Offset: 0x001E2161
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004D68 RID: 19816 RVA: 0x001E3F68 File Offset: 0x001E2168
		public static BlackboardWhiteList GetRootAsBlackboardWhiteList(ByteBuffer _bb)
		{
			return BlackboardWhiteList.GetRootAsBlackboardWhiteList(_bb, default(BlackboardWhiteList));
		}

		// Token: 0x06004D69 RID: 19817 RVA: 0x001E3F84 File Offset: 0x001E2184
		public static BlackboardWhiteList GetRootAsBlackboardWhiteList(ByteBuffer _bb, BlackboardWhiteList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004D6A RID: 19818 RVA: 0x001E3FA1 File Offset: 0x001E21A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004D6B RID: 19819 RVA: 0x001E3FB0 File Offset: 0x001E21B0
		public BlackboardWhiteList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06004D6C RID: 19820 RVA: 0x001E3FC0 File Offset: 0x001E21C0
		public string Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004D6D RID: 19821 RVA: 0x001E3FF7 File Offset: 0x001E21F7
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06004D6E RID: 19822 RVA: 0x001E4006 File Offset: 0x001E2206
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B2F RID: 19247
		private Table __p;
	}
}
