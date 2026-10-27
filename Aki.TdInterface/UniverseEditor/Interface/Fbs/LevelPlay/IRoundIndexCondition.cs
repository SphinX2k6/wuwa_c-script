using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045AB RID: 17835
	public struct IRoundIndexCondition : IFlatbufferObject
	{
		// Token: 0x17007EC2 RID: 32450
		// (get) Token: 0x0601AF65 RID: 110437 RVA: 0x003D879A File Offset: 0x003D699A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AF66 RID: 110438 RVA: 0x003D87A7 File Offset: 0x003D69A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AF67 RID: 110439 RVA: 0x003D87B0 File Offset: 0x003D69B0
		public static IRoundIndexCondition GetRootAsIRoundIndexCondition(ByteBuffer _bb)
		{
			return IRoundIndexCondition.GetRootAsIRoundIndexCondition(_bb, default(IRoundIndexCondition));
		}

		// Token: 0x0601AF68 RID: 110440 RVA: 0x003D87CC File Offset: 0x003D69CC
		public static IRoundIndexCondition GetRootAsIRoundIndexCondition(ByteBuffer _bb, IRoundIndexCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AF69 RID: 110441 RVA: 0x003D87E9 File Offset: 0x003D69E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AF6A RID: 110442 RVA: 0x003D87F8 File Offset: 0x003D69F8
		public IRoundIndexCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EC3 RID: 32451
		// (get) Token: 0x0601AF6B RID: 110443 RVA: 0x003D8808 File Offset: 0x003D6A08
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

		// Token: 0x17007EC4 RID: 32452
		// (get) Token: 0x0601AF6C RID: 110444 RVA: 0x003D8844 File Offset: 0x003D6A44
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

		// Token: 0x0601AF6D RID: 110445 RVA: 0x003D8880 File Offset: 0x003D6A80
		public static Offset<IRoundIndexCondition> CreateIRoundIndexCondition(FlatBufferBuilder builder, EDartSkillConditionType Type = EDartSkillConditionType.RemainScoreGe, int Round = 0)
		{
			builder.StartTable(2);
			IRoundIndexCondition.AddRound(builder, Round);
			IRoundIndexCondition.AddType(builder, Type);
			return IRoundIndexCondition.EndIRoundIndexCondition(builder);
		}

		// Token: 0x0601AF6E RID: 110446 RVA: 0x003D889D File Offset: 0x003D6A9D
		public static void StartIRoundIndexCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601AF6F RID: 110447 RVA: 0x003D88A6 File Offset: 0x003D6AA6
		public static void AddType(FlatBufferBuilder builder, EDartSkillConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AF70 RID: 110448 RVA: 0x003D88B1 File Offset: 0x003D6AB1
		public static void AddRound(FlatBufferBuilder builder, int round)
		{
			builder.AddInt(1, round, 0);
		}

		// Token: 0x0601AF71 RID: 110449 RVA: 0x003D88BC File Offset: 0x003D6ABC
		public static Offset<IRoundIndexCondition> EndIRoundIndexCondition(FlatBufferBuilder builder)
		{
			return new Offset<IRoundIndexCondition>(builder.EndTable());
		}

		// Token: 0x0601AF72 RID: 110450 RVA: 0x003D88CC File Offset: 0x003D6ACC
		public IRoundIndexConditionT UnPack()
		{
			IRoundIndexConditionT roundIndexConditionT = new IRoundIndexConditionT();
			this.UnPackTo(roundIndexConditionT);
			return roundIndexConditionT;
		}

		// Token: 0x0601AF73 RID: 110451 RVA: 0x003D88E7 File Offset: 0x003D6AE7
		public void UnPackTo(IRoundIndexConditionT _o)
		{
			_o.Type = this.Type;
			_o.Round = this.Round;
		}

		// Token: 0x0601AF74 RID: 110452 RVA: 0x003D8904 File Offset: 0x003D6B04
		public static Offset<IRoundIndexCondition> Pack(FlatBufferBuilder builder, IRoundIndexConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoundIndexCondition>);
			}
			return IRoundIndexCondition.CreateIRoundIndexCondition(builder, _o.Type, _o.Round);
		}

		// Token: 0x0400C673 RID: 50803
		private Table __p;
	}
}
