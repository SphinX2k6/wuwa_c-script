using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FE3 RID: 16355
	public struct IQuestFailedConditionPlayerMotionState : IFlatbufferObject
	{
		// Token: 0x170072C4 RID: 29380
		// (get) Token: 0x0601789D RID: 96413 RVA: 0x0036522F File Offset: 0x0036342F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601789E RID: 96414 RVA: 0x0036523C File Offset: 0x0036343C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601789F RID: 96415 RVA: 0x00365244 File Offset: 0x00363444
		public static IQuestFailedConditionPlayerMotionState GetRootAsIQuestFailedConditionPlayerMotionState(ByteBuffer _bb)
		{
			return IQuestFailedConditionPlayerMotionState.GetRootAsIQuestFailedConditionPlayerMotionState(_bb, default(IQuestFailedConditionPlayerMotionState));
		}

		// Token: 0x060178A0 RID: 96416 RVA: 0x00365260 File Offset: 0x00363460
		public static IQuestFailedConditionPlayerMotionState GetRootAsIQuestFailedConditionPlayerMotionState(ByteBuffer _bb, IQuestFailedConditionPlayerMotionState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060178A1 RID: 96417 RVA: 0x0036527D File Offset: 0x0036347D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060178A2 RID: 96418 RVA: 0x0036528C File Offset: 0x0036348C
		public IQuestFailedConditionPlayerMotionState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072C5 RID: 29381
		// (get) Token: 0x060178A3 RID: 96419 RVA: 0x0036529C File Offset: 0x0036349C
		public EPlayerMotionState MotionState
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayerMotionState.Ground;
				}
				return (EPlayerMotionState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170072C6 RID: 29382
		// (get) Token: 0x060178A4 RID: 96420 RVA: 0x003652D8 File Offset: 0x003634D8
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060178A5 RID: 96421 RVA: 0x00365314 File Offset: 0x00363514
		public static Offset<IQuestFailedConditionPlayerMotionState> CreateIQuestFailedConditionPlayerMotionState(FlatBufferBuilder builder, EPlayerMotionState MotionState = EPlayerMotionState.Ground, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(2);
			IQuestFailedConditionPlayerMotionState.AddCompare(builder, Compare);
			IQuestFailedConditionPlayerMotionState.AddMotionState(builder, MotionState);
			return IQuestFailedConditionPlayerMotionState.EndIQuestFailedConditionPlayerMotionState(builder);
		}

		// Token: 0x060178A6 RID: 96422 RVA: 0x00365331 File Offset: 0x00363531
		public static void StartIQuestFailedConditionPlayerMotionState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060178A7 RID: 96423 RVA: 0x0036533A File Offset: 0x0036353A
		public static void AddMotionState(FlatBufferBuilder builder, EPlayerMotionState motionState)
		{
			builder.AddByte(0, (byte)motionState, 0);
		}

		// Token: 0x060178A8 RID: 96424 RVA: 0x00365345 File Offset: 0x00363545
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x060178A9 RID: 96425 RVA: 0x00365350 File Offset: 0x00363550
		public static Offset<IQuestFailedConditionPlayerMotionState> EndIQuestFailedConditionPlayerMotionState(FlatBufferBuilder builder)
		{
			return new Offset<IQuestFailedConditionPlayerMotionState>(builder.EndTable());
		}

		// Token: 0x060178AA RID: 96426 RVA: 0x00365360 File Offset: 0x00363560
		public IQuestFailedConditionPlayerMotionStateT UnPack()
		{
			IQuestFailedConditionPlayerMotionStateT questFailedConditionPlayerMotionStateT = new IQuestFailedConditionPlayerMotionStateT();
			this.UnPackTo(questFailedConditionPlayerMotionStateT);
			return questFailedConditionPlayerMotionStateT;
		}

		// Token: 0x060178AB RID: 96427 RVA: 0x0036537B File Offset: 0x0036357B
		public void UnPackTo(IQuestFailedConditionPlayerMotionStateT _o)
		{
			_o.MotionState = this.MotionState;
			_o.Compare = this.Compare;
		}

		// Token: 0x060178AC RID: 96428 RVA: 0x00365398 File Offset: 0x00363598
		public static Offset<IQuestFailedConditionPlayerMotionState> Pack(FlatBufferBuilder builder, IQuestFailedConditionPlayerMotionStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestFailedConditionPlayerMotionState>);
			}
			return IQuestFailedConditionPlayerMotionState.CreateIQuestFailedConditionPlayerMotionState(builder, _o.MotionState, _o.Compare);
		}

		// Token: 0x0400BAE2 RID: 47842
		private Table __p;
	}
}
