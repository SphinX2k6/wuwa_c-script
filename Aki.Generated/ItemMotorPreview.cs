using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D83 RID: 3459
	public struct ItemMotorPreview : IFlatbufferObject
	{
		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x060086ED RID: 34541 RVA: 0x00267570 File Offset: 0x00265770
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060086EE RID: 34542 RVA: 0x0026757D File Offset: 0x0026577D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060086EF RID: 34543 RVA: 0x00267584 File Offset: 0x00265784
		public static ItemMotorPreview GetRootAsItemMotorPreview(ByteBuffer _bb)
		{
			return ItemMotorPreview.GetRootAsItemMotorPreview(_bb, default(ItemMotorPreview));
		}

		// Token: 0x060086F0 RID: 34544 RVA: 0x002675A0 File Offset: 0x002657A0
		public static ItemMotorPreview GetRootAsItemMotorPreview(ByteBuffer _bb, ItemMotorPreview obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060086F1 RID: 34545 RVA: 0x002675BD File Offset: 0x002657BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060086F2 RID: 34546 RVA: 0x002675CC File Offset: 0x002657CC
		public ItemMotorPreview __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x060086F3 RID: 34547 RVA: 0x002675DC File Offset: 0x002657DC
		public int ItemId
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

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x060086F4 RID: 34548 RVA: 0x00267618 File Offset: 0x00265818
		public int PreviewId
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

		// Token: 0x04004E0F RID: 19983
		private Table __p;
	}
}
