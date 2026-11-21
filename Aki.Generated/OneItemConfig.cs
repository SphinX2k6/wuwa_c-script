using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200130A RID: 4874
	public struct OneItemConfig : IFlatbufferObject
	{
		// Token: 0x17004266 RID: 16998
		// (get) Token: 0x0600F84B RID: 63563 RVA: 0x0037395E File Offset: 0x00371B5E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F84C RID: 63564 RVA: 0x0037396B File Offset: 0x00371B6B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F84D RID: 63565 RVA: 0x00373974 File Offset: 0x00371B74
		public static OneItemConfig GetRootAsOneItemConfig(ByteBuffer _bb)
		{
			return OneItemConfig.GetRootAsOneItemConfig(_bb, default(OneItemConfig));
		}

		// Token: 0x0600F84E RID: 63566 RVA: 0x00373990 File Offset: 0x00371B90
		public static OneItemConfig GetRootAsOneItemConfig(ByteBuffer _bb, OneItemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F84F RID: 63567 RVA: 0x003739AD File Offset: 0x00371BAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F850 RID: 63568 RVA: 0x003739BC File Offset: 0x00371BBC
		public OneItemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004267 RID: 16999
		// (get) Token: 0x0600F851 RID: 63569 RVA: 0x003739CC File Offset: 0x00371BCC
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

		// Token: 0x17004268 RID: 17000
		// (get) Token: 0x0600F852 RID: 63570 RVA: 0x00373A08 File Offset: 0x00371C08
		public int Count
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

		// Token: 0x04005985 RID: 22917
		private Table __p;
	}
}
