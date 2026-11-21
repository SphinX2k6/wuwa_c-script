using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012DB RID: 4827
	public struct WorldLevel : IFlatbufferObject
	{
		// Token: 0x170041D0 RID: 16848
		// (get) Token: 0x0600F69B RID: 63131 RVA: 0x00370457 File Offset: 0x0036E657
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F69C RID: 63132 RVA: 0x00370464 File Offset: 0x0036E664
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F69D RID: 63133 RVA: 0x0037046C File Offset: 0x0036E66C
		public static WorldLevel GetRootAsWorldLevel(ByteBuffer _bb)
		{
			return WorldLevel.GetRootAsWorldLevel(_bb, default(WorldLevel));
		}

		// Token: 0x0600F69E RID: 63134 RVA: 0x00370488 File Offset: 0x0036E688
		public static WorldLevel GetRootAsWorldLevel(ByteBuffer _bb, WorldLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F69F RID: 63135 RVA: 0x003704A5 File Offset: 0x0036E6A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F6A0 RID: 63136 RVA: 0x003704B4 File Offset: 0x0036E6B4
		public WorldLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170041D1 RID: 16849
		// (get) Token: 0x0600F6A1 RID: 63137 RVA: 0x003704C4 File Offset: 0x0036E6C4
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

		// Token: 0x170041D2 RID: 16850
		// (get) Token: 0x0600F6A2 RID: 63138 RVA: 0x00370500 File Offset: 0x0036E700
		public int PlayerLevelMax
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

		// Token: 0x170041D3 RID: 16851
		// (get) Token: 0x0600F6A3 RID: 63139 RVA: 0x0037053C File Offset: 0x0036E73C
		public int ConditionGroupId
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

		// Token: 0x170041D4 RID: 16852
		// (get) Token: 0x0600F6A4 RID: 63140 RVA: 0x00370578 File Offset: 0x0036E778
		public int AiTeamLevelId
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

		// Token: 0x170041D5 RID: 16853
		// (get) Token: 0x0600F6A5 RID: 63141 RVA: 0x003705B8 File Offset: 0x0036E7B8
		public int TrainingLevel
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

		// Token: 0x04005934 RID: 22836
		private Table __p;
	}
}
