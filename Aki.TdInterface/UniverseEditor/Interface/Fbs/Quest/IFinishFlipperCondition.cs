using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E36 RID: 15926
	public struct IFinishFlipperCondition : IFlatbufferObject
	{
		// Token: 0x17006E21 RID: 28193
		// (get) Token: 0x06016539 RID: 91449 RVA: 0x0033924B File Offset: 0x0033744B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601653A RID: 91450 RVA: 0x00339258 File Offset: 0x00337458
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601653B RID: 91451 RVA: 0x00339260 File Offset: 0x00337460
		public static IFinishFlipperCondition GetRootAsIFinishFlipperCondition(ByteBuffer _bb)
		{
			return IFinishFlipperCondition.GetRootAsIFinishFlipperCondition(_bb, default(IFinishFlipperCondition));
		}

		// Token: 0x0601653C RID: 91452 RVA: 0x0033927C File Offset: 0x0033747C
		public static IFinishFlipperCondition GetRootAsIFinishFlipperCondition(ByteBuffer _bb, IFinishFlipperCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601653D RID: 91453 RVA: 0x00339299 File Offset: 0x00337499
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601653E RID: 91454 RVA: 0x003392A8 File Offset: 0x003374A8
		public IFinishFlipperCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E22 RID: 28194
		// (get) Token: 0x0601653F RID: 91455 RVA: 0x003392B8 File Offset: 0x003374B8
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006E23 RID: 28195
		// (get) Token: 0x06016540 RID: 91456 RVA: 0x003392F4 File Offset: 0x003374F4
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006E24 RID: 28196
		// (get) Token: 0x06016541 RID: 91457 RVA: 0x00339354 File Offset: 0x00337554
		public IFlipperConditionStepFight? Step
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IFlipperConditionStepFight?(default(IFlipperConditionStepFight).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06016542 RID: 91458 RVA: 0x003393B1 File Offset: 0x003375B1
		public static Offset<IFinishFlipperCondition> CreateIFinishFlipperCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<IFlipperConditionStepFight> StepOffset = default(Offset<IFlipperConditionStepFight>))
		{
			builder.StartTable(3);
			IFinishFlipperCondition.AddStep(builder, StepOffset);
			IFinishFlipperCondition.AddPreConditions(builder, PreConditionsOffset);
			IFinishFlipperCondition.AddType(builder, Type);
			return IFinishFlipperCondition.EndIFinishFlipperCondition(builder);
		}

		// Token: 0x06016543 RID: 91459 RVA: 0x003393D5 File Offset: 0x003375D5
		public static void StartIFinishFlipperCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016544 RID: 91460 RVA: 0x003393DE File Offset: 0x003375DE
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016545 RID: 91461 RVA: 0x003393E9 File Offset: 0x003375E9
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06016546 RID: 91462 RVA: 0x003393F9 File Offset: 0x003375F9
		public static void AddStep(FlatBufferBuilder builder, Offset<IFlipperConditionStepFight> stepOffset)
		{
			builder.AddOffset(2, stepOffset.Value, 0);
		}

		// Token: 0x06016547 RID: 91463 RVA: 0x00339409 File Offset: 0x00337609
		public static Offset<IFinishFlipperCondition> EndIFinishFlipperCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFinishFlipperCondition>(builder.EndTable());
		}

		// Token: 0x06016548 RID: 91464 RVA: 0x00339418 File Offset: 0x00337618
		public IFinishFlipperConditionT UnPack()
		{
			IFinishFlipperConditionT finishFlipperConditionT = new IFinishFlipperConditionT();
			this.UnPackTo(finishFlipperConditionT);
			return finishFlipperConditionT;
		}

		// Token: 0x06016549 RID: 91465 RVA: 0x00339434 File Offset: 0x00337634
		public void UnPackTo(IFinishFlipperConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Step = ((this.Step != null) ? this.Step.Value.UnPack() : null);
		}

		// Token: 0x0601654A RID: 91466 RVA: 0x003394AC File Offset: 0x003376AC
		public static Offset<IFinishFlipperCondition> Pack(FlatBufferBuilder builder, IFinishFlipperConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishFlipperCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			Offset<IFlipperConditionStepFight> stepOffset = (_o.Step == null) ? default(Offset<IFlipperConditionStepFight>) : IFlipperConditionStepFight.Pack(builder, _o.Step);
			return IFinishFlipperCondition.CreateIFinishFlipperCondition(builder, _o.Type, preConditionsOffset, stepOffset);
		}

		// Token: 0x0400B7BD RID: 47037
		private Table __p;
	}
}
