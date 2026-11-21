using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001053 RID: 4179
	public struct QuestNodeData : IFlatbufferObject
	{
		// Token: 0x17002C23 RID: 11299
		// (get) Token: 0x0600BBB0 RID: 48048 RVA: 0x002EC519 File Offset: 0x002EA719
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BBB1 RID: 48049 RVA: 0x002EC526 File Offset: 0x002EA726
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BBB2 RID: 48050 RVA: 0x002EC530 File Offset: 0x002EA730
		public static QuestNodeData GetRootAsQuestNodeData(ByteBuffer _bb)
		{
			return QuestNodeData.GetRootAsQuestNodeData(_bb, default(QuestNodeData));
		}

		// Token: 0x0600BBB3 RID: 48051 RVA: 0x002EC54C File Offset: 0x002EA74C
		public static QuestNodeData GetRootAsQuestNodeData(ByteBuffer _bb, QuestNodeData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BBB4 RID: 48052 RVA: 0x002EC569 File Offset: 0x002EA769
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BBB5 RID: 48053 RVA: 0x002EC578 File Offset: 0x002EA778
		public QuestNodeData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C24 RID: 11300
		// (get) Token: 0x0600BBB6 RID: 48054 RVA: 0x002EC588 File Offset: 0x002EA788
		public string Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BBB7 RID: 48055 RVA: 0x002EC5BF File Offset: 0x002EA7BF
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600BBB8 RID: 48056 RVA: 0x002EC5CE File Offset: 0x002EA7CE
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C25 RID: 11301
		// (get) Token: 0x0600BBB9 RID: 48057 RVA: 0x002EC5E8 File Offset: 0x002EA7E8
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

		// Token: 0x0600BBBA RID: 48058 RVA: 0x002EC61F File Offset: 0x002EA81F
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BBBB RID: 48059 RVA: 0x002EC62E File Offset: 0x002EA82E
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005621 RID: 22049
		private Table __p;
	}
}
