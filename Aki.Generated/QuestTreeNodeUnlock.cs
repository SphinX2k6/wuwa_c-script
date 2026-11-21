using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001065 RID: 4197
	public struct QuestTreeNodeUnlock : IFlatbufferObject
	{
		// Token: 0x17002CB9 RID: 11449
		// (get) Token: 0x0600BD64 RID: 48484 RVA: 0x002EFBC6 File Offset: 0x002EDDC6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BD65 RID: 48485 RVA: 0x002EFBD3 File Offset: 0x002EDDD3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BD66 RID: 48486 RVA: 0x002EFBDC File Offset: 0x002EDDDC
		public static QuestTreeNodeUnlock GetRootAsQuestTreeNodeUnlock(ByteBuffer _bb)
		{
			return QuestTreeNodeUnlock.GetRootAsQuestTreeNodeUnlock(_bb, default(QuestTreeNodeUnlock));
		}

		// Token: 0x0600BD67 RID: 48487 RVA: 0x002EFBF8 File Offset: 0x002EDDF8
		public static QuestTreeNodeUnlock GetRootAsQuestTreeNodeUnlock(ByteBuffer _bb, QuestTreeNodeUnlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BD68 RID: 48488 RVA: 0x002EFC15 File Offset: 0x002EDE15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BD69 RID: 48489 RVA: 0x002EFC24 File Offset: 0x002EDE24
		public QuestTreeNodeUnlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CBA RID: 11450
		// (get) Token: 0x0600BD6A RID: 48490 RVA: 0x002EFC34 File Offset: 0x002EDE34
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

		// Token: 0x17002CBB RID: 11451
		// (get) Token: 0x0600BD6B RID: 48491 RVA: 0x002EFC70 File Offset: 0x002EDE70
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

		// Token: 0x0600BD6C RID: 48492 RVA: 0x002EFCA7 File Offset: 0x002EDEA7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BD6D RID: 48493 RVA: 0x002EFCB6 File Offset: 0x002EDEB6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CBC RID: 11452
		// (get) Token: 0x0600BD6E RID: 48494 RVA: 0x002EFCD0 File Offset: 0x002EDED0
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

		// Token: 0x17002CBD RID: 11453
		// (get) Token: 0x0600BD6F RID: 48495 RVA: 0x002EFD0C File Offset: 0x002EDF0C
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

		// Token: 0x17002CBE RID: 11454
		// (get) Token: 0x0600BD70 RID: 48496 RVA: 0x002EFD4C File Offset: 0x002EDF4C
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

		// Token: 0x04005633 RID: 22067
		private Table __p;
	}
}
