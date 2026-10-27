using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E42 RID: 15938
	public struct IFinishRhythmSpaceshipCondition : IFlatbufferObject
	{
		// Token: 0x17006E4B RID: 28235
		// (get) Token: 0x060165D2 RID: 91602 RVA: 0x0033A9DE File Offset: 0x00338BDE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060165D3 RID: 91603 RVA: 0x0033A9EB File Offset: 0x00338BEB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060165D4 RID: 91604 RVA: 0x0033A9F4 File Offset: 0x00338BF4
		public static IFinishRhythmSpaceshipCondition GetRootAsIFinishRhythmSpaceshipCondition(ByteBuffer _bb)
		{
			return IFinishRhythmSpaceshipCondition.GetRootAsIFinishRhythmSpaceshipCondition(_bb, default(IFinishRhythmSpaceshipCondition));
		}

		// Token: 0x060165D5 RID: 91605 RVA: 0x0033AA10 File Offset: 0x00338C10
		public static IFinishRhythmSpaceshipCondition GetRootAsIFinishRhythmSpaceshipCondition(ByteBuffer _bb, IFinishRhythmSpaceshipCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060165D6 RID: 91606 RVA: 0x0033AA2D File Offset: 0x00338C2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060165D7 RID: 91607 RVA: 0x0033AA3C File Offset: 0x00338C3C
		public IFinishRhythmSpaceshipCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E4C RID: 28236
		// (get) Token: 0x060165D8 RID: 91608 RVA: 0x0033AA4C File Offset: 0x00338C4C
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

		// Token: 0x17006E4D RID: 28237
		// (get) Token: 0x060165D9 RID: 91609 RVA: 0x0033AA88 File Offset: 0x00338C88
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

		// Token: 0x17006E4E RID: 28238
		// (get) Token: 0x060165DA RID: 91610 RVA: 0x0033AAE8 File Offset: 0x00338CE8
		public IRhythmSpaceshipConditionStepInteract? Step
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IRhythmSpaceshipConditionStepInteract?(default(IRhythmSpaceshipConditionStepInteract).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060165DB RID: 91611 RVA: 0x0033AB45 File Offset: 0x00338D45
		public static Offset<IFinishRhythmSpaceshipCondition> CreateIFinishRhythmSpaceshipCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<IRhythmSpaceshipConditionStepInteract> StepOffset = default(Offset<IRhythmSpaceshipConditionStepInteract>))
		{
			builder.StartTable(3);
			IFinishRhythmSpaceshipCondition.AddStep(builder, StepOffset);
			IFinishRhythmSpaceshipCondition.AddPreConditions(builder, PreConditionsOffset);
			IFinishRhythmSpaceshipCondition.AddType(builder, Type);
			return IFinishRhythmSpaceshipCondition.EndIFinishRhythmSpaceshipCondition(builder);
		}

		// Token: 0x060165DC RID: 91612 RVA: 0x0033AB69 File Offset: 0x00338D69
		public static void StartIFinishRhythmSpaceshipCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060165DD RID: 91613 RVA: 0x0033AB72 File Offset: 0x00338D72
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060165DE RID: 91614 RVA: 0x0033AB7D File Offset: 0x00338D7D
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060165DF RID: 91615 RVA: 0x0033AB8D File Offset: 0x00338D8D
		public static void AddStep(FlatBufferBuilder builder, Offset<IRhythmSpaceshipConditionStepInteract> stepOffset)
		{
			builder.AddOffset(2, stepOffset.Value, 0);
		}

		// Token: 0x060165E0 RID: 91616 RVA: 0x0033AB9D File Offset: 0x00338D9D
		public static Offset<IFinishRhythmSpaceshipCondition> EndIFinishRhythmSpaceshipCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFinishRhythmSpaceshipCondition>(builder.EndTable());
		}

		// Token: 0x060165E1 RID: 91617 RVA: 0x0033ABAC File Offset: 0x00338DAC
		public IFinishRhythmSpaceshipConditionT UnPack()
		{
			IFinishRhythmSpaceshipConditionT finishRhythmSpaceshipConditionT = new IFinishRhythmSpaceshipConditionT();
			this.UnPackTo(finishRhythmSpaceshipConditionT);
			return finishRhythmSpaceshipConditionT;
		}

		// Token: 0x060165E2 RID: 91618 RVA: 0x0033ABC8 File Offset: 0x00338DC8
		public void UnPackTo(IFinishRhythmSpaceshipConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Step = ((this.Step != null) ? this.Step.Value.UnPack() : null);
		}

		// Token: 0x060165E3 RID: 91619 RVA: 0x0033AC40 File Offset: 0x00338E40
		public static Offset<IFinishRhythmSpaceshipCondition> Pack(FlatBufferBuilder builder, IFinishRhythmSpaceshipConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishRhythmSpaceshipCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			Offset<IRhythmSpaceshipConditionStepInteract> stepOffset = (_o.Step == null) ? default(Offset<IRhythmSpaceshipConditionStepInteract>) : IRhythmSpaceshipConditionStepInteract.Pack(builder, _o.Step);
			return IFinishRhythmSpaceshipCondition.CreateIFinishRhythmSpaceshipCondition(builder, _o.Type, preConditionsOffset, stepOffset);
		}

		// Token: 0x0400B7D4 RID: 47060
		private Table __p;
	}
}
