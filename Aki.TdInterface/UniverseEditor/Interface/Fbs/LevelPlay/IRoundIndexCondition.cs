using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A13 RID: 18963
	public struct IRoundIndexCondition : IFlatbufferObject
	{
		// Token: 0x17008503 RID: 34051
		// (get) Token: 0x0601C73A RID: 116538 RVA: 0x00404A36 File Offset: 0x00402C36
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C73B RID: 116539 RVA: 0x00404A43 File Offset: 0x00402C43
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C73C RID: 116540 RVA: 0x00404A4C File Offset: 0x00402C4C
		public static IRoundIndexCondition GetRootAsIRoundIndexCondition(ByteBuffer _bb)
		{
			return IRoundIndexCondition.GetRootAsIRoundIndexCondition(_bb, default(IRoundIndexCondition));
		}

		// Token: 0x0601C73D RID: 116541 RVA: 0x00404A68 File Offset: 0x00402C68
		public static IRoundIndexCondition GetRootAsIRoundIndexCondition(ByteBuffer _bb, IRoundIndexCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C73E RID: 116542 RVA: 0x00404A85 File Offset: 0x00402C85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C73F RID: 116543 RVA: 0x00404A94 File Offset: 0x00402C94
		public IRoundIndexCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008504 RID: 34052
		// (get) Token: 0x0601C740 RID: 116544 RVA: 0x00404AA4 File Offset: 0x00402CA4
		public EDartSkillConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartSkillConditionType.RemainScoreGe;
				}
				return (EDartSkillConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008505 RID: 34053
		// (get) Token: 0x0601C741 RID: 116545 RVA: 0x00404AE0 File Offset: 0x00402CE0
		public int Round
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

		// Token: 0x0601C742 RID: 116546 RVA: 0x00404B1C File Offset: 0x00402D1C
		public static Offset<IRoundIndexCondition> CreateIRoundIndexCondition(FlatBufferBuilder builder, EDartSkillConditionType Type = EDartSkillConditionType.RemainScoreGe, int Round = 0)
		{
			builder.StartTable(2);
			IRoundIndexCondition.AddRound(builder, Round);
			IRoundIndexCondition.AddType(builder, Type);
			return IRoundIndexCondition.EndIRoundIndexCondition(builder);
		}

		// Token: 0x0601C743 RID: 116547 RVA: 0x00404B39 File Offset: 0x00402D39
		public static void StartIRoundIndexCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C744 RID: 116548 RVA: 0x00404B42 File Offset: 0x00402D42
		public static void AddType(FlatBufferBuilder builder, EDartSkillConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C745 RID: 116549 RVA: 0x00404B4D File Offset: 0x00402D4D
		public static void AddRound(FlatBufferBuilder builder, int round)
		{
			builder.AddInt(1, round, 0);
		}

		// Token: 0x0601C746 RID: 116550 RVA: 0x00404B58 File Offset: 0x00402D58
		public static Offset<IRoundIndexCondition> EndIRoundIndexCondition(FlatBufferBuilder builder)
		{
			return new Offset<IRoundIndexCondition>(builder.EndTable());
		}

		// Token: 0x0601C747 RID: 116551 RVA: 0x00404B68 File Offset: 0x00402D68
		public IRoundIndexConditionT UnPack()
		{
			IRoundIndexConditionT roundIndexConditionT = new IRoundIndexConditionT();
			this.UnPackTo(roundIndexConditionT);
			return roundIndexConditionT;
		}

		// Token: 0x0601C748 RID: 116552 RVA: 0x00404B83 File Offset: 0x00402D83
		public void UnPackTo(IRoundIndexConditionT _o)
		{
			_o.Type = this.Type;
			_o.Round = this.Round;
		}

		// Token: 0x0601C749 RID: 116553 RVA: 0x00404BA0 File Offset: 0x00402DA0
		public static Offset<IRoundIndexCondition> Pack(FlatBufferBuilder builder, IRoundIndexConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoundIndexCondition>);
			}
			return IRoundIndexCondition.CreateIRoundIndexCondition(builder, _o.Type, _o.Round);
		}

		// Token: 0x0400D0A2 RID: 53410
		private Table __p;
	}
}
