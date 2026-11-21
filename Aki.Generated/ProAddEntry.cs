using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200130F RID: 4879
	public struct ProAddEntry : IFlatbufferObject
	{
		// Token: 0x1700427B RID: 17019
		// (get) Token: 0x0600F879 RID: 63609 RVA: 0x00373F49 File Offset: 0x00372149
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F87A RID: 63610 RVA: 0x00373F56 File Offset: 0x00372156
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F87B RID: 63611 RVA: 0x00373F60 File Offset: 0x00372160
		public static ProAddEntry GetRootAsProAddEntry(ByteBuffer _bb)
		{
			return ProAddEntry.GetRootAsProAddEntry(_bb, default(ProAddEntry));
		}

		// Token: 0x0600F87C RID: 63612 RVA: 0x00373F7C File Offset: 0x0037217C
		public static ProAddEntry GetRootAsProAddEntry(ByteBuffer _bb, ProAddEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F87D RID: 63613 RVA: 0x00373F99 File Offset: 0x00372199
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F87E RID: 63614 RVA: 0x00373FA8 File Offset: 0x003721A8
		public ProAddEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700427C RID: 17020
		// (get) Token: 0x0600F87F RID: 63615 RVA: 0x00373FB8 File Offset: 0x003721B8
		public int ProId
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

		// Token: 0x1700427D RID: 17021
		// (get) Token: 0x0600F880 RID: 63616 RVA: 0x00373FF4 File Offset: 0x003721F4
		public bool IsPer
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700427E RID: 17022
		// (get) Token: 0x0600F881 RID: 63617 RVA: 0x00374034 File Offset: 0x00372234
		public int ProValue
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

		// Token: 0x0400598A RID: 22922
		private Table __p;
	}
}
