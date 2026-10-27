using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F75 RID: 3957
	public struct QuestReviewTab : IFlatbufferObject
	{
		// Token: 0x17002BDE RID: 11230
		// (get) Token: 0x0600B60F RID: 46607 RVA: 0x002D0BD0 File Offset: 0x002CEDD0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B610 RID: 46608 RVA: 0x002D0BDD File Offset: 0x002CEDDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B611 RID: 46609 RVA: 0x002D0BE4 File Offset: 0x002CEDE4
		public static QuestReviewTab GetRootAsQuestReviewTab(ByteBuffer _bb)
		{
			return QuestReviewTab.GetRootAsQuestReviewTab(_bb, default(QuestReviewTab));
		}

		// Token: 0x0600B612 RID: 46610 RVA: 0x002D0C00 File Offset: 0x002CEE00
		public static QuestReviewTab GetRootAsQuestReviewTab(ByteBuffer _bb, QuestReviewTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B613 RID: 46611 RVA: 0x002D0C1D File Offset: 0x002CEE1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B614 RID: 46612 RVA: 0x002D0C2C File Offset: 0x002CEE2C
		public QuestReviewTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002BDF RID: 11231
		// (get) Token: 0x0600B615 RID: 46613 RVA: 0x002D0C3C File Offset: 0x002CEE3C
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

		// Token: 0x17002BE0 RID: 11232
		// (get) Token: 0x0600B616 RID: 46614 RVA: 0x002D0C78 File Offset: 0x002CEE78
		public int QuestTree
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

		// Token: 0x17002BE1 RID: 11233
		// (get) Token: 0x0600B617 RID: 46615 RVA: 0x002D0CB4 File Offset: 0x002CEEB4
		public string TabName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B618 RID: 46616 RVA: 0x002D0CEB File Offset: 0x002CEEEB
		public Span<byte> GetTabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B619 RID: 46617 RVA: 0x002D0CFA File Offset: 0x002CEEFA
		public byte[] GetTabNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BE2 RID: 11234
		// (get) Token: 0x0600B61A RID: 46618 RVA: 0x002D0D14 File Offset: 0x002CEF14
		public bool HideTabsWhenUnlock
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005043 RID: 20547
		private Table __p;
	}
}
