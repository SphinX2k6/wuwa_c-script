using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC9 RID: 3529
	public struct LineCrossActivity : IFlatbufferObject
	{
		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x06008E0D RID: 36365 RVA: 0x00277A31 File Offset: 0x00275C31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008E0E RID: 36366 RVA: 0x00277A3E File Offset: 0x00275C3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008E0F RID: 36367 RVA: 0x00277A48 File Offset: 0x00275C48
		public static LineCrossActivity GetRootAsLineCrossActivity(ByteBuffer _bb)
		{
			return LineCrossActivity.GetRootAsLineCrossActivity(_bb, default(LineCrossActivity));
		}

		// Token: 0x06008E10 RID: 36368 RVA: 0x00277A64 File Offset: 0x00275C64
		public static LineCrossActivity GetRootAsLineCrossActivity(ByteBuffer _bb, LineCrossActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008E11 RID: 36369 RVA: 0x00277A81 File Offset: 0x00275C81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008E12 RID: 36370 RVA: 0x00277A90 File Offset: 0x00275C90
		public LineCrossActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x06008E13 RID: 36371 RVA: 0x00277AA0 File Offset: 0x00275CA0
		public int ActivityId
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

		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x06008E14 RID: 36372 RVA: 0x00277ADC File Offset: 0x00275CDC
		public int MarkId
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

		// Token: 0x04004E5F RID: 20063
		private Table __p;
	}
}
