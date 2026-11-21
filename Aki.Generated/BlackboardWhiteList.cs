using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C14 RID: 3092
	public struct BlackboardWhiteList : IFlatbufferObject
	{
		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06005328 RID: 21288 RVA: 0x002042B8 File Offset: 0x002024B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005329 RID: 21289 RVA: 0x002042C5 File Offset: 0x002024C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600532A RID: 21290 RVA: 0x002042CC File Offset: 0x002024CC
		public static BlackboardWhiteList GetRootAsBlackboardWhiteList(ByteBuffer _bb)
		{
			return BlackboardWhiteList.GetRootAsBlackboardWhiteList(_bb, default(BlackboardWhiteList));
		}

		// Token: 0x0600532B RID: 21291 RVA: 0x002042E8 File Offset: 0x002024E8
		public static BlackboardWhiteList GetRootAsBlackboardWhiteList(ByteBuffer _bb, BlackboardWhiteList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600532C RID: 21292 RVA: 0x00204305 File Offset: 0x00202505
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600532D RID: 21293 RVA: 0x00204314 File Offset: 0x00202514
		public BlackboardWhiteList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x0600532E RID: 21294 RVA: 0x00204324 File Offset: 0x00202524
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

		// Token: 0x0600532F RID: 21295 RVA: 0x0020435B File Offset: 0x0020255B
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06005330 RID: 21296 RVA: 0x0020436A File Offset: 0x0020256A
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x0400510F RID: 20751
		private Table __p;
	}
}
