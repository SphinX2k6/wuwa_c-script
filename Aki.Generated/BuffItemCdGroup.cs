using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B57 RID: 2903
	public struct BuffItemCdGroup : IFlatbufferObject
	{
		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06005127 RID: 20775 RVA: 0x001EC521 File Offset: 0x001EA721
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005128 RID: 20776 RVA: 0x001EC52E File Offset: 0x001EA72E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005129 RID: 20777 RVA: 0x001EC538 File Offset: 0x001EA738
		public static BuffItemCdGroup GetRootAsBuffItemCdGroup(ByteBuffer _bb)
		{
			return BuffItemCdGroup.GetRootAsBuffItemCdGroup(_bb, default(BuffItemCdGroup));
		}

		// Token: 0x0600512A RID: 20778 RVA: 0x001EC554 File Offset: 0x001EA754
		public static BuffItemCdGroup GetRootAsBuffItemCdGroup(ByteBuffer _bb, BuffItemCdGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600512B RID: 20779 RVA: 0x001EC571 File Offset: 0x001EA771
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600512C RID: 20780 RVA: 0x001EC580 File Offset: 0x001EA780
		public BuffItemCdGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x0600512D RID: 20781 RVA: 0x001EC590 File Offset: 0x001EA790
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

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x0600512E RID: 20782 RVA: 0x001EC5CC File Offset: 0x001EA7CC
		public int CoolDownTime
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

		// Token: 0x04004B54 RID: 19284
		private Table __p;
	}
}
