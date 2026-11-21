using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F0D RID: 3853
	public struct MoraleLevelDiffShow : IFlatbufferObject
	{
		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x06009C5B RID: 40027 RVA: 0x002A7C74 File Offset: 0x002A5E74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009C5C RID: 40028 RVA: 0x002A7C81 File Offset: 0x002A5E81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009C5D RID: 40029 RVA: 0x002A7C88 File Offset: 0x002A5E88
		public static MoraleLevelDiffShow GetRootAsMoraleLevelDiffShow(ByteBuffer _bb)
		{
			return MoraleLevelDiffShow.GetRootAsMoraleLevelDiffShow(_bb, default(MoraleLevelDiffShow));
		}

		// Token: 0x06009C5E RID: 40030 RVA: 0x002A7CA4 File Offset: 0x002A5EA4
		public static MoraleLevelDiffShow GetRootAsMoraleLevelDiffShow(ByteBuffer _bb, MoraleLevelDiffShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009C5F RID: 40031 RVA: 0x002A7CC1 File Offset: 0x002A5EC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009C60 RID: 40032 RVA: 0x002A7CD0 File Offset: 0x002A5ED0
		public MoraleLevelDiffShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x06009C61 RID: 40033 RVA: 0x002A7CE0 File Offset: 0x002A5EE0
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

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x06009C62 RID: 40034 RVA: 0x002A7D1C File Offset: 0x002A5F1C
		public int LevelDiffLower
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

		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x06009C63 RID: 40035 RVA: 0x002A7D58 File Offset: 0x002A5F58
		public int LevelDiffUpper
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

		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x06009C64 RID: 40036 RVA: 0x002A7D94 File Offset: 0x002A5F94
		public int MonsterLevelPattern
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

		// Token: 0x040054B2 RID: 21682
		private Table __p;
	}
}
