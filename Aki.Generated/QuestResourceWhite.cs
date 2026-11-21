using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001058 RID: 4184
	public struct QuestResourceWhite : IFlatbufferObject
	{
		// Token: 0x17002C37 RID: 11319
		// (get) Token: 0x0600BBF5 RID: 48117 RVA: 0x002ECC9D File Offset: 0x002EAE9D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BBF6 RID: 48118 RVA: 0x002ECCAA File Offset: 0x002EAEAA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BBF7 RID: 48119 RVA: 0x002ECCB4 File Offset: 0x002EAEB4
		public static QuestResourceWhite GetRootAsQuestResourceWhite(ByteBuffer _bb)
		{
			return QuestResourceWhite.GetRootAsQuestResourceWhite(_bb, default(QuestResourceWhite));
		}

		// Token: 0x0600BBF8 RID: 48120 RVA: 0x002ECCD0 File Offset: 0x002EAED0
		public static QuestResourceWhite GetRootAsQuestResourceWhite(ByteBuffer _bb, QuestResourceWhite obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BBF9 RID: 48121 RVA: 0x002ECCED File Offset: 0x002EAEED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BBFA RID: 48122 RVA: 0x002ECCFC File Offset: 0x002EAEFC
		public QuestResourceWhite __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C38 RID: 11320
		// (get) Token: 0x0600BBFB RID: 48123 RVA: 0x002ECD0C File Offset: 0x002EAF0C
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

		// Token: 0x04005626 RID: 22054
		private Table __p;
	}
}
