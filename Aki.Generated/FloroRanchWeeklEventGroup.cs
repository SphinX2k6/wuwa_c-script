using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CBF RID: 3263
	public struct FloroRanchWeeklEventGroup : IFlatbufferObject
	{
		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06007527 RID: 29991 RVA: 0x0023F634 File Offset: 0x0023D834
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007528 RID: 29992 RVA: 0x0023F641 File Offset: 0x0023D841
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007529 RID: 29993 RVA: 0x0023F648 File Offset: 0x0023D848
		public static FloroRanchWeeklEventGroup GetRootAsFloroRanchWeeklEventGroup(ByteBuffer _bb)
		{
			return FloroRanchWeeklEventGroup.GetRootAsFloroRanchWeeklEventGroup(_bb, default(FloroRanchWeeklEventGroup));
		}

		// Token: 0x0600752A RID: 29994 RVA: 0x0023F664 File Offset: 0x0023D864
		public static FloroRanchWeeklEventGroup GetRootAsFloroRanchWeeklEventGroup(ByteBuffer _bb, FloroRanchWeeklEventGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600752B RID: 29995 RVA: 0x0023F681 File Offset: 0x0023D881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600752C RID: 29996 RVA: 0x0023F690 File Offset: 0x0023D890
		public FloroRanchWeeklEventGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x0600752D RID: 29997 RVA: 0x0023F6A0 File Offset: 0x0023D8A0
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

		// Token: 0x04004D2F RID: 19759
		private Table __p;
	}
}
