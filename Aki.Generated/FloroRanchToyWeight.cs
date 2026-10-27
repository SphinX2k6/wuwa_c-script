using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CBD RID: 3261
	public struct FloroRanchToyWeight : IFlatbufferObject
	{
		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x06007517 RID: 29975 RVA: 0x0023F469 File Offset: 0x0023D669
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007518 RID: 29976 RVA: 0x0023F476 File Offset: 0x0023D676
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007519 RID: 29977 RVA: 0x0023F480 File Offset: 0x0023D680
		public static FloroRanchToyWeight GetRootAsFloroRanchToyWeight(ByteBuffer _bb)
		{
			return FloroRanchToyWeight.GetRootAsFloroRanchToyWeight(_bb, default(FloroRanchToyWeight));
		}

		// Token: 0x0600751A RID: 29978 RVA: 0x0023F49C File Offset: 0x0023D69C
		public static FloroRanchToyWeight GetRootAsFloroRanchToyWeight(ByteBuffer _bb, FloroRanchToyWeight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600751B RID: 29979 RVA: 0x0023F4B9 File Offset: 0x0023D6B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600751C RID: 29980 RVA: 0x0023F4C8 File Offset: 0x0023D6C8
		public FloroRanchToyWeight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x0600751D RID: 29981 RVA: 0x0023F4D8 File Offset: 0x0023D6D8
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

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x0600751E RID: 29982 RVA: 0x0023F514 File Offset: 0x0023D714
		public int Group
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

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x0600751F RID: 29983 RVA: 0x0023F550 File Offset: 0x0023D750
		public int Stage
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

		// Token: 0x04004D2D RID: 19757
		private Table __p;
	}
}
