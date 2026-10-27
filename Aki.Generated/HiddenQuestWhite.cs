using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D2A RID: 3370
	public struct HiddenQuestWhite : IFlatbufferObject
	{
		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x06007E7A RID: 32378 RVA: 0x00253FF0 File Offset: 0x002521F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007E7B RID: 32379 RVA: 0x00253FFD File Offset: 0x002521FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007E7C RID: 32380 RVA: 0x00254004 File Offset: 0x00252204
		public static HiddenQuestWhite GetRootAsHiddenQuestWhite(ByteBuffer _bb)
		{
			return HiddenQuestWhite.GetRootAsHiddenQuestWhite(_bb, default(HiddenQuestWhite));
		}

		// Token: 0x06007E7D RID: 32381 RVA: 0x00254020 File Offset: 0x00252220
		public static HiddenQuestWhite GetRootAsHiddenQuestWhite(ByteBuffer _bb, HiddenQuestWhite obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007E7E RID: 32382 RVA: 0x0025403D File Offset: 0x0025223D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007E7F RID: 32383 RVA: 0x0025404C File Offset: 0x0025224C
		public HiddenQuestWhite __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x06007E80 RID: 32384 RVA: 0x0025405C File Offset: 0x0025225C
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

		// Token: 0x04004DA2 RID: 19874
		private Table __p;
	}
}
