using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A5 RID: 4517
	public struct WorldLevel : IFlatbufferObject
	{
		// Token: 0x17003E6B RID: 15979
		// (get) Token: 0x0600E92A RID: 59690 RVA: 0x003457CB File Offset: 0x003439CB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E92B RID: 59691 RVA: 0x003457D8 File Offset: 0x003439D8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E92C RID: 59692 RVA: 0x003457E0 File Offset: 0x003439E0
		public static WorldLevel GetRootAsWorldLevel(ByteBuffer _bb)
		{
			return WorldLevel.GetRootAsWorldLevel(_bb, default(WorldLevel));
		}

		// Token: 0x0600E92D RID: 59693 RVA: 0x003457FC File Offset: 0x003439FC
		public static WorldLevel GetRootAsWorldLevel(ByteBuffer _bb, WorldLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E92E RID: 59694 RVA: 0x00345819 File Offset: 0x00343A19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E92F RID: 59695 RVA: 0x00345828 File Offset: 0x00343A28
		public WorldLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E6C RID: 15980
		// (get) Token: 0x0600E930 RID: 59696 RVA: 0x00345838 File Offset: 0x00343A38
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

		// Token: 0x17003E6D RID: 15981
		// (get) Token: 0x0600E931 RID: 59697 RVA: 0x00345874 File Offset: 0x00343A74
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

		// Token: 0x17003E6E RID: 15982
		// (get) Token: 0x0600E932 RID: 59698 RVA: 0x003458B0 File Offset: 0x00343AB0
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

		// Token: 0x17003E6F RID: 15983
		// (get) Token: 0x0600E933 RID: 59699 RVA: 0x003458EC File Offset: 0x00343AEC
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

		// Token: 0x17003E70 RID: 15984
		// (get) Token: 0x0600E934 RID: 59700 RVA: 0x0034592C File Offset: 0x00343B2C
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

		// Token: 0x040052F1 RID: 21233
		private Table __p;
	}
}
