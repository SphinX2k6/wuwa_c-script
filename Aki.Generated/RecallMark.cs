using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001088 RID: 4232
	public struct RecallMark : IFlatbufferObject
	{
		// Token: 0x17002DCD RID: 11725
		// (get) Token: 0x0600C03B RID: 49211 RVA: 0x002F6139 File Offset: 0x002F4339
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C03C RID: 49212 RVA: 0x002F6146 File Offset: 0x002F4346
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C03D RID: 49213 RVA: 0x002F6150 File Offset: 0x002F4350
		public static RecallMark GetRootAsRecallMark(ByteBuffer _bb)
		{
			return RecallMark.GetRootAsRecallMark(_bb, default(RecallMark));
		}

		// Token: 0x0600C03E RID: 49214 RVA: 0x002F616C File Offset: 0x002F436C
		public static RecallMark GetRootAsRecallMark(ByteBuffer _bb, RecallMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C03F RID: 49215 RVA: 0x002F6189 File Offset: 0x002F4389
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C040 RID: 49216 RVA: 0x002F6198 File Offset: 0x002F4398
		public RecallMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DCE RID: 11726
		// (get) Token: 0x0600C041 RID: 49217 RVA: 0x002F61A8 File Offset: 0x002F43A8
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

		// Token: 0x17002DCF RID: 11727
		// (get) Token: 0x0600C042 RID: 49218 RVA: 0x002F61E4 File Offset: 0x002F43E4
		public int RecallId
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

		// Token: 0x17002DD0 RID: 11728
		// (get) Token: 0x0600C043 RID: 49219 RVA: 0x002F6220 File Offset: 0x002F4420
		public int MarkId
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

		// Token: 0x0400565B RID: 22107
		private Table __p;
	}
}
