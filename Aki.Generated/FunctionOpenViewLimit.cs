using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB8 RID: 3512
	public struct FunctionOpenViewLimit : IFlatbufferObject
	{
		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x06007D43 RID: 32067 RVA: 0x00262B3C File Offset: 0x00260D3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007D44 RID: 32068 RVA: 0x00262B49 File Offset: 0x00260D49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007D45 RID: 32069 RVA: 0x00262B50 File Offset: 0x00260D50
		public static FunctionOpenViewLimit GetRootAsFunctionOpenViewLimit(ByteBuffer _bb)
		{
			return FunctionOpenViewLimit.GetRootAsFunctionOpenViewLimit(_bb, default(FunctionOpenViewLimit));
		}

		// Token: 0x06007D46 RID: 32070 RVA: 0x00262B6C File Offset: 0x00260D6C
		public static FunctionOpenViewLimit GetRootAsFunctionOpenViewLimit(ByteBuffer _bb, FunctionOpenViewLimit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007D47 RID: 32071 RVA: 0x00262B89 File Offset: 0x00260D89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007D48 RID: 32072 RVA: 0x00262B98 File Offset: 0x00260D98
		public FunctionOpenViewLimit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x06007D49 RID: 32073 RVA: 0x00262BA8 File Offset: 0x00260DA8
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

		// Token: 0x06007D4A RID: 32074 RVA: 0x00262BDF File Offset: 0x00260DDF
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06007D4B RID: 32075 RVA: 0x00262BEE File Offset: 0x00260DEE
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x04005328 RID: 21288
		private Table __p;
	}
}
