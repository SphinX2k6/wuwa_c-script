using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E68 RID: 3688
	public struct ItemMotorPreview : IFlatbufferObject
	{
		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x06008D08 RID: 36104 RVA: 0x002857A0 File Offset: 0x002839A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008D09 RID: 36105 RVA: 0x002857AD File Offset: 0x002839AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008D0A RID: 36106 RVA: 0x002857B4 File Offset: 0x002839B4
		public static ItemMotorPreview GetRootAsItemMotorPreview(ByteBuffer _bb)
		{
			return ItemMotorPreview.GetRootAsItemMotorPreview(_bb, default(ItemMotorPreview));
		}

		// Token: 0x06008D0B RID: 36107 RVA: 0x002857D0 File Offset: 0x002839D0
		public static ItemMotorPreview GetRootAsItemMotorPreview(ByteBuffer _bb, ItemMotorPreview obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008D0C RID: 36108 RVA: 0x002857ED File Offset: 0x002839ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008D0D RID: 36109 RVA: 0x002857FC File Offset: 0x002839FC
		public ItemMotorPreview __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x06008D0E RID: 36110 RVA: 0x0028580C File Offset: 0x00283A0C
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

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x06008D0F RID: 36111 RVA: 0x00285848 File Offset: 0x00283A48
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

		// Token: 0x040053F4 RID: 21492
		private Table __p;
	}
}
