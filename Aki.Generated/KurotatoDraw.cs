using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E7F RID: 3711
	public struct KurotatoDraw : IFlatbufferObject
	{
		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x06008F4B RID: 36683 RVA: 0x0028BCA3 File Offset: 0x00289EA3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008F4C RID: 36684 RVA: 0x0028BCB0 File Offset: 0x00289EB0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008F4D RID: 36685 RVA: 0x0028BCB8 File Offset: 0x00289EB8
		public static KurotatoDraw GetRootAsKurotatoDraw(ByteBuffer _bb)
		{
			return KurotatoDraw.GetRootAsKurotatoDraw(_bb, default(KurotatoDraw));
		}

		// Token: 0x06008F4E RID: 36686 RVA: 0x0028BCD4 File Offset: 0x00289ED4
		public static KurotatoDraw GetRootAsKurotatoDraw(ByteBuffer _bb, KurotatoDraw obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008F4F RID: 36687 RVA: 0x0028BCF1 File Offset: 0x00289EF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008F50 RID: 36688 RVA: 0x0028BD00 File Offset: 0x00289F00
		public KurotatoDraw __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x06008F51 RID: 36689 RVA: 0x0028BD10 File Offset: 0x00289F10
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

		// Token: 0x0400540F RID: 21519
		private Table __p;
	}
}
