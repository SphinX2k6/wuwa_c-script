using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FE6 RID: 16358
	public struct IQuestFailedConditionPlayerMovementMode : IFlatbufferObject
	{
		// Token: 0x170072C9 RID: 29385
		// (get) Token: 0x060178B3 RID: 96435 RVA: 0x0036542E File Offset: 0x0036362E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060178B4 RID: 96436 RVA: 0x0036543B File Offset: 0x0036363B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060178B5 RID: 96437 RVA: 0x00365444 File Offset: 0x00363644
		public static IQuestFailedConditionPlayerMovementMode GetRootAsIQuestFailedConditionPlayerMovementMode(ByteBuffer _bb)
		{
			return IQuestFailedConditionPlayerMovementMode.GetRootAsIQuestFailedConditionPlayerMovementMode(_bb, default(IQuestFailedConditionPlayerMovementMode));
		}

		// Token: 0x060178B6 RID: 96438 RVA: 0x00365460 File Offset: 0x00363660
		public static IQuestFailedConditionPlayerMovementMode GetRootAsIQuestFailedConditionPlayerMovementMode(ByteBuffer _bb, IQuestFailedConditionPlayerMovementMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060178B7 RID: 96439 RVA: 0x0036547D File Offset: 0x0036367D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060178B8 RID: 96440 RVA: 0x0036548C File Offset: 0x0036368C
		public IQuestFailedConditionPlayerMovementMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072CA RID: 29386
		// (get) Token: 0x060178B9 RID: 96441 RVA: 0x0036549C File Offset: 0x0036369C
		public EPlayerMovementMode Mode
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayerMovementMode.Ski;
				}
				return (EPlayerMovementMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170072CB RID: 29387
		// (get) Token: 0x060178BA RID: 96442 RVA: 0x003654D8 File Offset: 0x003636D8
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

		// Token: 0x060178BB RID: 96443 RVA: 0x00365514 File Offset: 0x00363714
		public static Offset<IQuestFailedConditionPlayerMovementMode> CreateIQuestFailedConditionPlayerMovementMode(FlatBufferBuilder builder, EPlayerMovementMode Mode = EPlayerMovementMode.Ski, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(2);
			IQuestFailedConditionPlayerMovementMode.AddCompare(builder, Compare);
			IQuestFailedConditionPlayerMovementMode.AddMode(builder, Mode);
			return IQuestFailedConditionPlayerMovementMode.EndIQuestFailedConditionPlayerMovementMode(builder);
		}

		// Token: 0x060178BC RID: 96444 RVA: 0x00365531 File Offset: 0x00363731
		public static void StartIQuestFailedConditionPlayerMovementMode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060178BD RID: 96445 RVA: 0x0036553A File Offset: 0x0036373A
		public static void AddMode(FlatBufferBuilder builder, EPlayerMovementMode mode)
		{
			builder.AddByte(0, (byte)mode, 0);
		}

		// Token: 0x060178BE RID: 96446 RVA: 0x00365545 File Offset: 0x00363745
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x060178BF RID: 96447 RVA: 0x00365550 File Offset: 0x00363750
		public static Offset<IQuestFailedConditionPlayerMovementMode> EndIQuestFailedConditionPlayerMovementMode(FlatBufferBuilder builder)
		{
			return new Offset<IQuestFailedConditionPlayerMovementMode>(builder.EndTable());
		}

		// Token: 0x060178C0 RID: 96448 RVA: 0x00365560 File Offset: 0x00363760
		public IQuestFailedConditionPlayerMovementModeT UnPack()
		{
			IQuestFailedConditionPlayerMovementModeT questFailedConditionPlayerMovementModeT = new IQuestFailedConditionPlayerMovementModeT();
			this.UnPackTo(questFailedConditionPlayerMovementModeT);
			return questFailedConditionPlayerMovementModeT;
		}

		// Token: 0x060178C1 RID: 96449 RVA: 0x0036557B File Offset: 0x0036377B
		public void UnPackTo(IQuestFailedConditionPlayerMovementModeT _o)
		{
			_o.Mode = this.Mode;
			_o.Compare = this.Compare;
		}

		// Token: 0x060178C2 RID: 96450 RVA: 0x00365598 File Offset: 0x00363798
		public static Offset<IQuestFailedConditionPlayerMovementMode> Pack(FlatBufferBuilder builder, IQuestFailedConditionPlayerMovementModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestFailedConditionPlayerMovementMode>);
			}
			return IQuestFailedConditionPlayerMovementMode.CreateIQuestFailedConditionPlayerMovementMode(builder, _o.Mode, _o.Compare);
		}

		// Token: 0x0400BAE5 RID: 47845
		private Table __p;
	}
}
