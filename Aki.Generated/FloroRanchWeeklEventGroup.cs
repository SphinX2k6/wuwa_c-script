using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA3 RID: 3491
	public struct FloroRanchWeeklEventGroup : IFlatbufferObject
	{
		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x06007B32 RID: 31538 RVA: 0x0025E360 File Offset: 0x0025C560
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007B33 RID: 31539 RVA: 0x0025E36D File Offset: 0x0025C56D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007B34 RID: 31540 RVA: 0x0025E374 File Offset: 0x0025C574
		public static FloroRanchWeeklEventGroup GetRootAsFloroRanchWeeklEventGroup(ByteBuffer _bb)
		{
			return FloroRanchWeeklEventGroup.GetRootAsFloroRanchWeeklEventGroup(_bb, default(FloroRanchWeeklEventGroup));
		}

		// Token: 0x06007B35 RID: 31541 RVA: 0x0025E390 File Offset: 0x0025C590
		public static FloroRanchWeeklEventGroup GetRootAsFloroRanchWeeklEventGroup(ByteBuffer _bb, FloroRanchWeeklEventGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007B36 RID: 31542 RVA: 0x0025E3AD File Offset: 0x0025C5AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007B37 RID: 31543 RVA: 0x0025E3BC File Offset: 0x0025C5BC
		public FloroRanchWeeklEventGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x06007B38 RID: 31544 RVA: 0x0025E3CC File Offset: 0x0025C5CC
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

		// Token: 0x04005313 RID: 21267
		private Table __p;
	}
}
