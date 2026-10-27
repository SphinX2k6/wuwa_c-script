using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F6A RID: 3946
	public struct QuestData : IFlatbufferObject
	{
		// Token: 0x17002B9A RID: 11162
		// (get) Token: 0x0600B548 RID: 46408 RVA: 0x002CF36D File Offset: 0x002CD56D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B549 RID: 46409 RVA: 0x002CF37A File Offset: 0x002CD57A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B54A RID: 46410 RVA: 0x002CF384 File Offset: 0x002CD584
		public static QuestData GetRootAsQuestData(ByteBuffer _bb)
		{
			return QuestData.GetRootAsQuestData(_bb, default(QuestData));
		}

		// Token: 0x0600B54B RID: 46411 RVA: 0x002CF3A0 File Offset: 0x002CD5A0
		public static QuestData GetRootAsQuestData(ByteBuffer _bb, QuestData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B54C RID: 46412 RVA: 0x002CF3BD File Offset: 0x002CD5BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B54D RID: 46413 RVA: 0x002CF3CC File Offset: 0x002CD5CC
		public QuestData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B9B RID: 11163
		// (get) Token: 0x0600B54E RID: 46414 RVA: 0x002CF3DC File Offset: 0x002CD5DC
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

		// Token: 0x17002B9C RID: 11164
		// (get) Token: 0x0600B54F RID: 46415 RVA: 0x002CF418 File Offset: 0x002CD618
		public string Data
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

		// Token: 0x0600B550 RID: 46416 RVA: 0x002CF44F File Offset: 0x002CD64F
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B551 RID: 46417 RVA: 0x002CF45E File Offset: 0x002CD65E
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005038 RID: 20536
		private Table __p;
	}
}
