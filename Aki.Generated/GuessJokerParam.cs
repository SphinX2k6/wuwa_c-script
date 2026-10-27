using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D12 RID: 3346
	public struct GuessJokerParam : IFlatbufferObject
	{
		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x06007C3C RID: 31804 RVA: 0x0024F242 File Offset: 0x0024D442
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007C3D RID: 31805 RVA: 0x0024F24F File Offset: 0x0024D44F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007C3E RID: 31806 RVA: 0x0024F258 File Offset: 0x0024D458
		public static GuessJokerParam GetRootAsGuessJokerParam(ByteBuffer _bb)
		{
			return GuessJokerParam.GetRootAsGuessJokerParam(_bb, default(GuessJokerParam));
		}

		// Token: 0x06007C3F RID: 31807 RVA: 0x0024F274 File Offset: 0x0024D474
		public static GuessJokerParam GetRootAsGuessJokerParam(ByteBuffer _bb, GuessJokerParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007C40 RID: 31808 RVA: 0x0024F291 File Offset: 0x0024D491
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007C41 RID: 31809 RVA: 0x0024F2A0 File Offset: 0x0024D4A0
		public GuessJokerParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x06007C42 RID: 31810 RVA: 0x0024F2B0 File Offset: 0x0024D4B0
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

		// Token: 0x06007C43 RID: 31811 RVA: 0x0024F2E7 File Offset: 0x0024D4E7
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06007C44 RID: 31812 RVA: 0x0024F2F6 File Offset: 0x0024D4F6
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x06007C45 RID: 31813 RVA: 0x0024F310 File Offset: 0x0024D510
		public int Value
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

		// Token: 0x04004D8A RID: 19850
		private Table __p;
	}
}
