using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001051 RID: 4177
	public struct QuestData : IFlatbufferObject
	{
		// Token: 0x17002C12 RID: 11282
		// (get) Token: 0x0600BB85 RID: 48005 RVA: 0x002EBF89 File Offset: 0x002EA189
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BB86 RID: 48006 RVA: 0x002EBF96 File Offset: 0x002EA196
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BB87 RID: 48007 RVA: 0x002EBFA0 File Offset: 0x002EA1A0
		public static QuestData GetRootAsQuestData(ByteBuffer _bb)
		{
			return QuestData.GetRootAsQuestData(_bb, default(QuestData));
		}

		// Token: 0x0600BB88 RID: 48008 RVA: 0x002EBFBC File Offset: 0x002EA1BC
		public static QuestData GetRootAsQuestData(ByteBuffer _bb, QuestData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BB89 RID: 48009 RVA: 0x002EBFD9 File Offset: 0x002EA1D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BB8A RID: 48010 RVA: 0x002EBFE8 File Offset: 0x002EA1E8
		public QuestData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C13 RID: 11283
		// (get) Token: 0x0600BB8B RID: 48011 RVA: 0x002EBFF8 File Offset: 0x002EA1F8
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

		// Token: 0x17002C14 RID: 11284
		// (get) Token: 0x0600BB8C RID: 48012 RVA: 0x002EC034 File Offset: 0x002EA234
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

		// Token: 0x0600BB8D RID: 48013 RVA: 0x002EC06B File Offset: 0x002EA26B
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BB8E RID: 48014 RVA: 0x002EC07A File Offset: 0x002EA27A
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400561F RID: 22047
		private Table __p;
	}
}
