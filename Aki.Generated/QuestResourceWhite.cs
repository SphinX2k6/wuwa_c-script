using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F71 RID: 3953
	public struct QuestResourceWhite : IFlatbufferObject
	{
		// Token: 0x17002BBF RID: 11199
		// (get) Token: 0x0600B5B8 RID: 46520 RVA: 0x002D00C1 File Offset: 0x002CE2C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B5B9 RID: 46521 RVA: 0x002D00CE File Offset: 0x002CE2CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B5BA RID: 46522 RVA: 0x002D00D8 File Offset: 0x002CE2D8
		public static QuestResourceWhite GetRootAsQuestResourceWhite(ByteBuffer _bb)
		{
			return QuestResourceWhite.GetRootAsQuestResourceWhite(_bb, default(QuestResourceWhite));
		}

		// Token: 0x0600B5BB RID: 46523 RVA: 0x002D00F4 File Offset: 0x002CE2F4
		public static QuestResourceWhite GetRootAsQuestResourceWhite(ByteBuffer _bb, QuestResourceWhite obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B5BC RID: 46524 RVA: 0x002D0111 File Offset: 0x002CE311
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B5BD RID: 46525 RVA: 0x002D0120 File Offset: 0x002CE320
		public QuestResourceWhite __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002BC0 RID: 11200
		// (get) Token: 0x0600B5BE RID: 46526 RVA: 0x002D0130 File Offset: 0x002CE330
		public int QuestId
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

		// Token: 0x0400503F RID: 20543
		private Table __p;
	}
}
