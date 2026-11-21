using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001057 RID: 4183
	public struct QuestResource : IFlatbufferObject
	{
		// Token: 0x17002C34 RID: 11316
		// (get) Token: 0x0600BBEB RID: 48107 RVA: 0x002ECB98 File Offset: 0x002EAD98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BBEC RID: 48108 RVA: 0x002ECBA5 File Offset: 0x002EADA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BBED RID: 48109 RVA: 0x002ECBAC File Offset: 0x002EADAC
		public static QuestResource GetRootAsQuestResource(ByteBuffer _bb)
		{
			return QuestResource.GetRootAsQuestResource(_bb, default(QuestResource));
		}

		// Token: 0x0600BBEE RID: 48110 RVA: 0x002ECBC8 File Offset: 0x002EADC8
		public static QuestResource GetRootAsQuestResource(ByteBuffer _bb, QuestResource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BBEF RID: 48111 RVA: 0x002ECBE5 File Offset: 0x002EADE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BBF0 RID: 48112 RVA: 0x002ECBF4 File Offset: 0x002EADF4
		public QuestResource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C35 RID: 11317
		// (get) Token: 0x0600BBF1 RID: 48113 RVA: 0x002ECC04 File Offset: 0x002EAE04
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

		// Token: 0x17002C36 RID: 11318
		// (get) Token: 0x0600BBF2 RID: 48114 RVA: 0x002ECC40 File Offset: 0x002EAE40
		public string Resource
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

		// Token: 0x0600BBF3 RID: 48115 RVA: 0x002ECC77 File Offset: 0x002EAE77
		public Span<byte> GetResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BBF4 RID: 48116 RVA: 0x002ECC86 File Offset: 0x002EAE86
		public byte[] GetResourceArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005625 RID: 22053
		private Table __p;
	}
}
