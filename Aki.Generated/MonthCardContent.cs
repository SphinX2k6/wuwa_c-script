using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E20 RID: 3616
	public struct MonthCardContent : IFlatbufferObject
	{
		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x060095B7 RID: 38327 RVA: 0x00288EBC File Offset: 0x002870BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060095B8 RID: 38328 RVA: 0x00288EC9 File Offset: 0x002870C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060095B9 RID: 38329 RVA: 0x00288ED0 File Offset: 0x002870D0
		public static MonthCardContent GetRootAsMonthCardContent(ByteBuffer _bb)
		{
			return MonthCardContent.GetRootAsMonthCardContent(_bb, default(MonthCardContent));
		}

		// Token: 0x060095BA RID: 38330 RVA: 0x00288EEC File Offset: 0x002870EC
		public static MonthCardContent GetRootAsMonthCardContent(ByteBuffer _bb, MonthCardContent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060095BB RID: 38331 RVA: 0x00288F09 File Offset: 0x00287109
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060095BC RID: 38332 RVA: 0x00288F18 File Offset: 0x00287118
		public MonthCardContent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x060095BD RID: 38333 RVA: 0x00288F28 File Offset: 0x00287128
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

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x060095BE RID: 38334 RVA: 0x00288F64 File Offset: 0x00287164
		public int Days
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

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x060095BF RID: 38335 RVA: 0x00288FA0 File Offset: 0x002871A0
		public int ItemId
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

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x060095C0 RID: 38336 RVA: 0x00288FDC File Offset: 0x002871DC
		public int Count
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

		// Token: 0x04004EC5 RID: 20165
		private Table __p;
	}
}
