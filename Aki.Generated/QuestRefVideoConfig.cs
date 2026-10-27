using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F6F RID: 3951
	public struct QuestRefVideoConfig : IFlatbufferObject
	{
		// Token: 0x17002BB6 RID: 11190
		// (get) Token: 0x0600B59F RID: 46495 RVA: 0x002CFDD9 File Offset: 0x002CDFD9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B5A0 RID: 46496 RVA: 0x002CFDE6 File Offset: 0x002CDFE6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B5A1 RID: 46497 RVA: 0x002CFDF0 File Offset: 0x002CDFF0
		public static QuestRefVideoConfig GetRootAsQuestRefVideoConfig(ByteBuffer _bb)
		{
			return QuestRefVideoConfig.GetRootAsQuestRefVideoConfig(_bb, default(QuestRefVideoConfig));
		}

		// Token: 0x0600B5A2 RID: 46498 RVA: 0x002CFE0C File Offset: 0x002CE00C
		public static QuestRefVideoConfig GetRootAsQuestRefVideoConfig(ByteBuffer _bb, QuestRefVideoConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B5A3 RID: 46499 RVA: 0x002CFE29 File Offset: 0x002CE029
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B5A4 RID: 46500 RVA: 0x002CFE38 File Offset: 0x002CE038
		public QuestRefVideoConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002BB7 RID: 11191
		// (get) Token: 0x0600B5A5 RID: 46501 RVA: 0x002CFE48 File Offset: 0x002CE048
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

		// Token: 0x17002BB8 RID: 11192
		// (get) Token: 0x0600B5A6 RID: 46502 RVA: 0x002CFE84 File Offset: 0x002CE084
		public int QuestId
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

		// Token: 0x17002BB9 RID: 11193
		// (get) Token: 0x0600B5A7 RID: 46503 RVA: 0x002CFEC0 File Offset: 0x002CE0C0
		public int GirlOrBoy
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

		// Token: 0x17002BBA RID: 11194
		// (get) Token: 0x0600B5A8 RID: 46504 RVA: 0x002CFEFC File Offset: 0x002CE0FC
		public string PakName
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B5A9 RID: 46505 RVA: 0x002CFF34 File Offset: 0x002CE134
		public Span<byte> GetPakNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B5AA RID: 46506 RVA: 0x002CFF44 File Offset: 0x002CE144
		public byte[] GetPakNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BBB RID: 11195
		// (get) Token: 0x0600B5AB RID: 46507 RVA: 0x002CFF5C File Offset: 0x002CE15C
		public string OnlineBranch
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B5AC RID: 46508 RVA: 0x002CFF94 File Offset: 0x002CE194
		public Span<byte> GetOnlineBranchBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B5AD RID: 46509 RVA: 0x002CFFA4 File Offset: 0x002CE1A4
		public byte[] GetOnlineBranchArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400503D RID: 20541
		private Table __p;
	}
}
