using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001133 RID: 4403
	public struct TotalTopUpScore : IFlatbufferObject
	{
		// Token: 0x17003A98 RID: 15000
		// (get) Token: 0x0600DF46 RID: 57158 RVA: 0x0032ED78 File Offset: 0x0032CF78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DF47 RID: 57159 RVA: 0x0032ED85 File Offset: 0x0032CF85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DF48 RID: 57160 RVA: 0x0032ED8C File Offset: 0x0032CF8C
		public static TotalTopUpScore GetRootAsTotalTopUpScore(ByteBuffer _bb)
		{
			return TotalTopUpScore.GetRootAsTotalTopUpScore(_bb, default(TotalTopUpScore));
		}

		// Token: 0x0600DF49 RID: 57161 RVA: 0x0032EDA8 File Offset: 0x0032CFA8
		public static TotalTopUpScore GetRootAsTotalTopUpScore(ByteBuffer _bb, TotalTopUpScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DF4A RID: 57162 RVA: 0x0032EDC5 File Offset: 0x0032CFC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DF4B RID: 57163 RVA: 0x0032EDD4 File Offset: 0x0032CFD4
		public TotalTopUpScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A99 RID: 15001
		// (get) Token: 0x0600DF4C RID: 57164 RVA: 0x0032EDE4 File Offset: 0x0032CFE4
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

		// Token: 0x17003A9A RID: 15002
		// (get) Token: 0x0600DF4D RID: 57165 RVA: 0x0032EE20 File Offset: 0x0032D020
		public int ActivityId
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

		// Token: 0x04005274 RID: 21108
		private Table __p;
	}
}
