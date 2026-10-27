using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B9A RID: 2970
	public struct ConsumptiveTask : IFlatbufferObject
	{
		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06005906 RID: 22790 RVA: 0x001FED78 File Offset: 0x001FCF78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005907 RID: 22791 RVA: 0x001FED85 File Offset: 0x001FCF85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005908 RID: 22792 RVA: 0x001FED8C File Offset: 0x001FCF8C
		public static ConsumptiveTask GetRootAsConsumptiveTask(ByteBuffer _bb)
		{
			return ConsumptiveTask.GetRootAsConsumptiveTask(_bb, default(ConsumptiveTask));
		}

		// Token: 0x06005909 RID: 22793 RVA: 0x001FEDA8 File Offset: 0x001FCFA8
		public static ConsumptiveTask GetRootAsConsumptiveTask(ByteBuffer _bb, ConsumptiveTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600590A RID: 22794 RVA: 0x001FEDC5 File Offset: 0x001FCFC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600590B RID: 22795 RVA: 0x001FEDD4 File Offset: 0x001FCFD4
		public ConsumptiveTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x0600590C RID: 22796 RVA: 0x001FEDE4 File Offset: 0x001FCFE4
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

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x0600590D RID: 22797 RVA: 0x001FEE20 File Offset: 0x001FD020
		public int MaxFinishCount
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

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x0600590E RID: 22798 RVA: 0x001FEE5C File Offset: 0x001FD05C
		public int RewardScore
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

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x0600590F RID: 22799 RVA: 0x001FEE98 File Offset: 0x001FD098
		public int TaskTab
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

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06005910 RID: 22800 RVA: 0x001FEED8 File Offset: 0x001FD0D8
		public string DesString
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

		// Token: 0x06005911 RID: 22801 RVA: 0x001FEF10 File Offset: 0x001FD110
		public Span<byte> GetDesStringBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005912 RID: 22802 RVA: 0x001FEF20 File Offset: 0x001FD120
		public byte[] GetDesStringArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06005913 RID: 22803 RVA: 0x001FEF38 File Offset: 0x001FD138
		public int SkipId
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

		// Token: 0x04004BBB RID: 19387
		private Table __p;
	}
}
