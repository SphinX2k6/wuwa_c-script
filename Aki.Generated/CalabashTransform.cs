using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C40 RID: 3136
	public struct CalabashTransform : IFlatbufferObject
	{
		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x0600581D RID: 22557 RVA: 0x0020F21A File Offset: 0x0020D41A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600581E RID: 22558 RVA: 0x0020F227 File Offset: 0x0020D427
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600581F RID: 22559 RVA: 0x0020F230 File Offset: 0x0020D430
		public static CalabashTransform GetRootAsCalabashTransform(ByteBuffer _bb)
		{
			return CalabashTransform.GetRootAsCalabashTransform(_bb, default(CalabashTransform));
		}

		// Token: 0x06005820 RID: 22560 RVA: 0x0020F24C File Offset: 0x0020D44C
		public static CalabashTransform GetRootAsCalabashTransform(ByteBuffer _bb, CalabashTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005821 RID: 22561 RVA: 0x0020F269 File Offset: 0x0020D469
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005822 RID: 22562 RVA: 0x0020F278 File Offset: 0x0020D478
		public CalabashTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06005823 RID: 22563 RVA: 0x0020F288 File Offset: 0x0020D488
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

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06005824 RID: 22564 RVA: 0x0020F2C4 File Offset: 0x0020D4C4
		public Vector? Location
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06005825 RID: 22565 RVA: 0x0020F324 File Offset: 0x0020D524
		public Vector? Rotation
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06005826 RID: 22566 RVA: 0x0020F384 File Offset: 0x0020D584
		public Vector? Size
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06005827 RID: 22567 RVA: 0x0020F3E4 File Offset: 0x0020D5E4
		public Vector? AxisRotate
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06005828 RID: 22568 RVA: 0x0020F444 File Offset: 0x0020D644
		public int RotateTime
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

		// Token: 0x04005140 RID: 20800
		private Table __p;
	}
}
