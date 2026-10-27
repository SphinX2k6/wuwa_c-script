using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F70 RID: 3952
	public struct QuestResource : IFlatbufferObject
	{
		// Token: 0x17002BBC RID: 11196
		// (get) Token: 0x0600B5AE RID: 46510 RVA: 0x002CFFBC File Offset: 0x002CE1BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B5AF RID: 46511 RVA: 0x002CFFC9 File Offset: 0x002CE1C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B5B0 RID: 46512 RVA: 0x002CFFD0 File Offset: 0x002CE1D0
		public static QuestResource GetRootAsQuestResource(ByteBuffer _bb)
		{
			return QuestResource.GetRootAsQuestResource(_bb, default(QuestResource));
		}

		// Token: 0x0600B5B1 RID: 46513 RVA: 0x002CFFEC File Offset: 0x002CE1EC
		public static QuestResource GetRootAsQuestResource(ByteBuffer _bb, QuestResource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B5B2 RID: 46514 RVA: 0x002D0009 File Offset: 0x002CE209
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B5B3 RID: 46515 RVA: 0x002D0018 File Offset: 0x002CE218
		public QuestResource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002BBD RID: 11197
		// (get) Token: 0x0600B5B4 RID: 46516 RVA: 0x002D0028 File Offset: 0x002CE228
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

		// Token: 0x17002BBE RID: 11198
		// (get) Token: 0x0600B5B5 RID: 46517 RVA: 0x002D0064 File Offset: 0x002CE264
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

		// Token: 0x0600B5B6 RID: 46518 RVA: 0x002D009B File Offset: 0x002CE29B
		public Span<byte> GetResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B5B7 RID: 46519 RVA: 0x002D00AA File Offset: 0x002CE2AA
		public byte[] GetResourceArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400503E RID: 20542
		private Table __p;
	}
}
