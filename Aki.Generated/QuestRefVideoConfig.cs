using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001056 RID: 4182
	public struct QuestRefVideoConfig : IFlatbufferObject
	{
		// Token: 0x17002C2E RID: 11310
		// (get) Token: 0x0600BBDC RID: 48092 RVA: 0x002EC9B6 File Offset: 0x002EABB6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BBDD RID: 48093 RVA: 0x002EC9C3 File Offset: 0x002EABC3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BBDE RID: 48094 RVA: 0x002EC9CC File Offset: 0x002EABCC
		public static QuestRefVideoConfig GetRootAsQuestRefVideoConfig(ByteBuffer _bb)
		{
			return QuestRefVideoConfig.GetRootAsQuestRefVideoConfig(_bb, default(QuestRefVideoConfig));
		}

		// Token: 0x0600BBDF RID: 48095 RVA: 0x002EC9E8 File Offset: 0x002EABE8
		public static QuestRefVideoConfig GetRootAsQuestRefVideoConfig(ByteBuffer _bb, QuestRefVideoConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BBE0 RID: 48096 RVA: 0x002ECA05 File Offset: 0x002EAC05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BBE1 RID: 48097 RVA: 0x002ECA14 File Offset: 0x002EAC14
		public QuestRefVideoConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C2F RID: 11311
		// (get) Token: 0x0600BBE2 RID: 48098 RVA: 0x002ECA24 File Offset: 0x002EAC24
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

		// Token: 0x17002C30 RID: 11312
		// (get) Token: 0x0600BBE3 RID: 48099 RVA: 0x002ECA60 File Offset: 0x002EAC60
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

		// Token: 0x17002C31 RID: 11313
		// (get) Token: 0x0600BBE4 RID: 48100 RVA: 0x002ECA9C File Offset: 0x002EAC9C
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

		// Token: 0x17002C32 RID: 11314
		// (get) Token: 0x0600BBE5 RID: 48101 RVA: 0x002ECAD8 File Offset: 0x002EACD8
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

		// Token: 0x0600BBE6 RID: 48102 RVA: 0x002ECB10 File Offset: 0x002EAD10
		public Span<byte> GetPakNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BBE7 RID: 48103 RVA: 0x002ECB20 File Offset: 0x002EAD20
		public byte[] GetPakNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C33 RID: 11315
		// (get) Token: 0x0600BBE8 RID: 48104 RVA: 0x002ECB38 File Offset: 0x002EAD38
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

		// Token: 0x0600BBE9 RID: 48105 RVA: 0x002ECB70 File Offset: 0x002EAD70
		public Span<byte> GetOnlineBranchBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BBEA RID: 48106 RVA: 0x002ECB80 File Offset: 0x002EAD80
		public byte[] GetOnlineBranchArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005624 RID: 22052
		private Table __p;
	}
}
