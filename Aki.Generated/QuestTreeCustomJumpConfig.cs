using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F7C RID: 3964
	public struct QuestTreeCustomJumpConfig : IFlatbufferObject
	{
		// Token: 0x17002C1F RID: 11295
		// (get) Token: 0x0600B6CA RID: 46794 RVA: 0x002D242C File Offset: 0x002D062C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B6CB RID: 46795 RVA: 0x002D2439 File Offset: 0x002D0639
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B6CC RID: 46796 RVA: 0x002D2440 File Offset: 0x002D0640
		public static QuestTreeCustomJumpConfig GetRootAsQuestTreeCustomJumpConfig(ByteBuffer _bb)
		{
			return QuestTreeCustomJumpConfig.GetRootAsQuestTreeCustomJumpConfig(_bb, default(QuestTreeCustomJumpConfig));
		}

		// Token: 0x0600B6CD RID: 46797 RVA: 0x002D245C File Offset: 0x002D065C
		public static QuestTreeCustomJumpConfig GetRootAsQuestTreeCustomJumpConfig(ByteBuffer _bb, QuestTreeCustomJumpConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B6CE RID: 46798 RVA: 0x002D2479 File Offset: 0x002D0679
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B6CF RID: 46799 RVA: 0x002D2488 File Offset: 0x002D0688
		public QuestTreeCustomJumpConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C20 RID: 11296
		// (get) Token: 0x0600B6D0 RID: 46800 RVA: 0x002D2498 File Offset: 0x002D0698
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

		// Token: 0x17002C21 RID: 11297
		// (get) Token: 0x0600B6D1 RID: 46801 RVA: 0x002D24D4 File Offset: 0x002D06D4
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

		// Token: 0x17002C22 RID: 11298
		// (get) Token: 0x0600B6D2 RID: 46802 RVA: 0x002D2510 File Offset: 0x002D0710
		public string PreConditionType
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

		// Token: 0x0600B6D3 RID: 46803 RVA: 0x002D2547 File Offset: 0x002D0747
		public Span<byte> GetPreConditionTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B6D4 RID: 46804 RVA: 0x002D2556 File Offset: 0x002D0756
		public byte[] GetPreConditionTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C23 RID: 11299
		// (get) Token: 0x0600B6D5 RID: 46805 RVA: 0x002D2570 File Offset: 0x002D0770
		public int ConditionIndex
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C24 RID: 11300
		// (get) Token: 0x0600B6D6 RID: 46806 RVA: 0x002D25B0 File Offset: 0x002D07B0
		public string JumpType
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

		// Token: 0x0600B6D7 RID: 46807 RVA: 0x002D25E8 File Offset: 0x002D07E8
		public Span<byte> GetJumpTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B6D8 RID: 46808 RVA: 0x002D25F8 File Offset: 0x002D07F8
		public byte[] GetJumpTypeArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C25 RID: 11301
		// (get) Token: 0x0600B6D9 RID: 46809 RVA: 0x002D2610 File Offset: 0x002D0810
		public int ParamsId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C26 RID: 11302
		// (get) Token: 0x0600B6DA RID: 46810 RVA: 0x002D2650 File Offset: 0x002D0850
		public string CustomTextKey
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B6DB RID: 46811 RVA: 0x002D2688 File Offset: 0x002D0888
		public Span<byte> GetCustomTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B6DC RID: 46812 RVA: 0x002D2698 File Offset: 0x002D0898
		public byte[] GetCustomTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0400504A RID: 20554
		private Table __p;
	}
}
