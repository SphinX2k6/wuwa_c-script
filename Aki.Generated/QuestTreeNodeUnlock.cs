using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F7E RID: 3966
	public struct QuestTreeNodeUnlock : IFlatbufferObject
	{
		// Token: 0x17002C41 RID: 11329
		// (get) Token: 0x0600B727 RID: 46887 RVA: 0x002D3141 File Offset: 0x002D1341
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B728 RID: 46888 RVA: 0x002D314E File Offset: 0x002D134E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B729 RID: 46889 RVA: 0x002D3158 File Offset: 0x002D1358
		public static QuestTreeNodeUnlock GetRootAsQuestTreeNodeUnlock(ByteBuffer _bb)
		{
			return QuestTreeNodeUnlock.GetRootAsQuestTreeNodeUnlock(_bb, default(QuestTreeNodeUnlock));
		}

		// Token: 0x0600B72A RID: 46890 RVA: 0x002D3174 File Offset: 0x002D1374
		public static QuestTreeNodeUnlock GetRootAsQuestTreeNodeUnlock(ByteBuffer _bb, QuestTreeNodeUnlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B72B RID: 46891 RVA: 0x002D3191 File Offset: 0x002D1391
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B72C RID: 46892 RVA: 0x002D31A0 File Offset: 0x002D13A0
		public QuestTreeNodeUnlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C42 RID: 11330
		// (get) Token: 0x0600B72D RID: 46893 RVA: 0x002D31B0 File Offset: 0x002D13B0
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

		// Token: 0x17002C43 RID: 11331
		// (get) Token: 0x0600B72E RID: 46894 RVA: 0x002D31EC File Offset: 0x002D13EC
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B72F RID: 46895 RVA: 0x002D3223 File Offset: 0x002D1423
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B730 RID: 46896 RVA: 0x002D3232 File Offset: 0x002D1432
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C44 RID: 11332
		// (get) Token: 0x0600B731 RID: 46897 RVA: 0x002D324C File Offset: 0x002D144C
		public int QuestID
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

		// Token: 0x17002C45 RID: 11333
		// (get) Token: 0x0600B732 RID: 46898 RVA: 0x002D3288 File Offset: 0x002D1488
		public int AccessId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C46 RID: 11334
		// (get) Token: 0x0600B733 RID: 46899 RVA: 0x002D32C8 File Offset: 0x002D14C8
		public int HelpId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400504C RID: 20556
		private Table __p;
	}
}
