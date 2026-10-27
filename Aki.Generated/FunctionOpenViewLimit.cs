using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD4 RID: 3284
	public struct FunctionOpenViewLimit : IFlatbufferObject
	{
		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x06007738 RID: 30520 RVA: 0x00243FA0 File Offset: 0x002421A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007739 RID: 30521 RVA: 0x00243FAD File Offset: 0x002421AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600773A RID: 30522 RVA: 0x00243FB4 File Offset: 0x002421B4
		public static FunctionOpenViewLimit GetRootAsFunctionOpenViewLimit(ByteBuffer _bb)
		{
			return FunctionOpenViewLimit.GetRootAsFunctionOpenViewLimit(_bb, default(FunctionOpenViewLimit));
		}

		// Token: 0x0600773B RID: 30523 RVA: 0x00243FD0 File Offset: 0x002421D0
		public static FunctionOpenViewLimit GetRootAsFunctionOpenViewLimit(ByteBuffer _bb, FunctionOpenViewLimit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600773C RID: 30524 RVA: 0x00243FED File Offset: 0x002421ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600773D RID: 30525 RVA: 0x00243FFC File Offset: 0x002421FC
		public FunctionOpenViewLimit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x0600773E RID: 30526 RVA: 0x0024400C File Offset: 0x0024220C
		public string ViewName
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

		// Token: 0x0600773F RID: 30527 RVA: 0x00244043 File Offset: 0x00242243
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x00244052 File Offset: 0x00242252
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D44 RID: 19780
		private Table __p;
	}
}
