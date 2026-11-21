using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004424 RID: 17444
	public struct IQuestFailedConditionPlayerMotionState : IFlatbufferObject
	{
		// Token: 0x170078C6 RID: 30918
		// (get) Token: 0x06018F36 RID: 102198 RVA: 0x0038F023 File Offset: 0x0038D223
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018F37 RID: 102199 RVA: 0x0038F030 File Offset: 0x0038D230
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018F38 RID: 102200 RVA: 0x0038F038 File Offset: 0x0038D238
		public static IQuestFailedConditionPlayerMotionState GetRootAsIQuestFailedConditionPlayerMotionState(ByteBuffer _bb)
		{
			return IQuestFailedConditionPlayerMotionState.GetRootAsIQuestFailedConditionPlayerMotionState(_bb, default(IQuestFailedConditionPlayerMotionState));
		}

		// Token: 0x06018F39 RID: 102201 RVA: 0x0038F054 File Offset: 0x0038D254
		public static IQuestFailedConditionPlayerMotionState GetRootAsIQuestFailedConditionPlayerMotionState(ByteBuffer _bb, IQuestFailedConditionPlayerMotionState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018F3A RID: 102202 RVA: 0x0038F071 File Offset: 0x0038D271
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018F3B RID: 102203 RVA: 0x0038F080 File Offset: 0x0038D280
		public IQuestFailedConditionPlayerMotionState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078C7 RID: 30919
		// (get) Token: 0x06018F3C RID: 102204 RVA: 0x0038F090 File Offset: 0x0038D290
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

		// Token: 0x170078C8 RID: 30920
		// (get) Token: 0x06018F3D RID: 102205 RVA: 0x0038F0CC File Offset: 0x0038D2CC
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

		// Token: 0x06018F3E RID: 102206 RVA: 0x0038F108 File Offset: 0x0038D308
		public static Offset<IQuestFailedConditionPlayerMotionState> CreateIQuestFailedConditionPlayerMotionState(FlatBufferBuilder builder, EPlayerMotionState MotionState = EPlayerMotionState.Ground, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(2);
			IQuestFailedConditionPlayerMotionState.AddCompare(builder, Compare);
			IQuestFailedConditionPlayerMotionState.AddMotionState(builder, MotionState);
			return IQuestFailedConditionPlayerMotionState.EndIQuestFailedConditionPlayerMotionState(builder);
		}

		// Token: 0x06018F3F RID: 102207 RVA: 0x0038F125 File Offset: 0x0038D325
		public static void StartIQuestFailedConditionPlayerMotionState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018F40 RID: 102208 RVA: 0x0038F12E File Offset: 0x0038D32E
		public static void AddMotionState(FlatBufferBuilder builder, EPlayerMotionState motionState)
		{
			builder.AddByte(0, (byte)motionState, 0);
		}

		// Token: 0x06018F41 RID: 102209 RVA: 0x0038F139 File Offset: 0x0038D339
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x06018F42 RID: 102210 RVA: 0x0038F144 File Offset: 0x0038D344
		public static Offset<IQuestFailedConditionPlayerMotionState> EndIQuestFailedConditionPlayerMotionState(FlatBufferBuilder builder)
		{
			return new Offset<IQuestFailedConditionPlayerMotionState>(builder.EndTable());
		}

		// Token: 0x06018F43 RID: 102211 RVA: 0x0038F154 File Offset: 0x0038D354
		public IQuestFailedConditionPlayerMotionStateT UnPack()
		{
			IQuestFailedConditionPlayerMotionStateT questFailedConditionPlayerMotionStateT = new IQuestFailedConditionPlayerMotionStateT();
			this.UnPackTo(questFailedConditionPlayerMotionStateT);
			return questFailedConditionPlayerMotionStateT;
		}

		// Token: 0x06018F44 RID: 102212 RVA: 0x0038F16F File Offset: 0x0038D36F
		public void UnPackTo(IQuestFailedConditionPlayerMotionStateT _o)
		{
			_o.MotionState = this.MotionState;
			_o.Compare = this.Compare;
		}

		// Token: 0x06018F45 RID: 102213 RVA: 0x0038F18C File Offset: 0x0038D38C
		public static Offset<IQuestFailedConditionPlayerMotionState> Pack(FlatBufferBuilder builder, IQuestFailedConditionPlayerMotionStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestFailedConditionPlayerMotionState>);
			}
			return IQuestFailedConditionPlayerMotionState.CreateIQuestFailedConditionPlayerMotionState(builder, _o.MotionState, _o.Compare);
		}

		// Token: 0x0400C4C9 RID: 50377
		private Table __p;
	}
}
