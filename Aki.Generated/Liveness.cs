using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD3 RID: 3539
	public struct Liveness : IFlatbufferObject
	{
		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x06008EEE RID: 36590 RVA: 0x00279A05 File Offset: 0x00277C05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008EEF RID: 36591 RVA: 0x00279A12 File Offset: 0x00277C12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008EF0 RID: 36592 RVA: 0x00279A1C File Offset: 0x00277C1C
		public static Liveness GetRootAsLiveness(ByteBuffer _bb)
		{
			return Liveness.GetRootAsLiveness(_bb, default(Liveness));
		}

		// Token: 0x06008EF1 RID: 36593 RVA: 0x00279A38 File Offset: 0x00277C38
		public static Liveness GetRootAsLiveness(ByteBuffer _bb, Liveness obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008EF2 RID: 36594 RVA: 0x00279A55 File Offset: 0x00277C55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008EF3 RID: 36595 RVA: 0x00279A64 File Offset: 0x00277C64
		public Liveness __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x06008EF4 RID: 36596 RVA: 0x00279A74 File Offset: 0x00277C74
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

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x06008EF5 RID: 36597 RVA: 0x00279AB0 File Offset: 0x00277CB0
		public int Goal
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

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x06008EF6 RID: 36598 RVA: 0x00279AEC File Offset: 0x00277CEC
		public int DropId
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

		// Token: 0x04004E6D RID: 20077
		private Table __p;
	}
}
