using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200427D RID: 17021
	public struct IFinishRhythmSpaceshipCondition : IFlatbufferObject
	{
		// Token: 0x1700742F RID: 29743
		// (get) Token: 0x06017BF9 RID: 97273 RVA: 0x0036350E File Offset: 0x0036170E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017BFA RID: 97274 RVA: 0x0036351B File Offset: 0x0036171B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017BFB RID: 97275 RVA: 0x00363524 File Offset: 0x00361724
		public static IFinishRhythmSpaceshipCondition GetRootAsIFinishRhythmSpaceshipCondition(ByteBuffer _bb)
		{
			return IFinishRhythmSpaceshipCondition.GetRootAsIFinishRhythmSpaceshipCondition(_bb, default(IFinishRhythmSpaceshipCondition));
		}

		// Token: 0x06017BFC RID: 97276 RVA: 0x00363540 File Offset: 0x00361740
		public static IFinishRhythmSpaceshipCondition GetRootAsIFinishRhythmSpaceshipCondition(ByteBuffer _bb, IFinishRhythmSpaceshipCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017BFD RID: 97277 RVA: 0x0036355D File Offset: 0x0036175D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017BFE RID: 97278 RVA: 0x0036356C File Offset: 0x0036176C
		public IFinishRhythmSpaceshipCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007430 RID: 29744
		// (get) Token: 0x06017BFF RID: 97279 RVA: 0x0036357C File Offset: 0x0036177C
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

		// Token: 0x17007431 RID: 29745
		// (get) Token: 0x06017C00 RID: 97280 RVA: 0x003635B8 File Offset: 0x003617B8
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

		// Token: 0x17007432 RID: 29746
		// (get) Token: 0x06017C01 RID: 97281 RVA: 0x00363618 File Offset: 0x00361818
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

		// Token: 0x06017C02 RID: 97282 RVA: 0x00363675 File Offset: 0x00361875
		public static Offset<IFinishRhythmSpaceshipCondition> CreateIFinishRhythmSpaceshipCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<IRhythmSpaceshipConditionStepInteract> StepOffset = default(Offset<IRhythmSpaceshipConditionStepInteract>))
		{
			builder.StartTable(3);
			IFinishRhythmSpaceshipCondition.AddStep(builder, StepOffset);
			IFinishRhythmSpaceshipCondition.AddPreConditions(builder, PreConditionsOffset);
			IFinishRhythmSpaceshipCondition.AddType(builder, Type);
			return IFinishRhythmSpaceshipCondition.EndIFinishRhythmSpaceshipCondition(builder);
		}

		// Token: 0x06017C03 RID: 97283 RVA: 0x00363699 File Offset: 0x00361899
		public static void StartIFinishRhythmSpaceshipCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017C04 RID: 97284 RVA: 0x003636A2 File Offset: 0x003618A2
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017C05 RID: 97285 RVA: 0x003636AD File Offset: 0x003618AD
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017C06 RID: 97286 RVA: 0x003636BD File Offset: 0x003618BD
		public static void AddStep(FlatBufferBuilder builder, Offset<IRhythmSpaceshipConditionStepInteract> stepOffset)
		{
			builder.AddOffset(2, stepOffset.Value, 0);
		}

		// Token: 0x06017C07 RID: 97287 RVA: 0x003636CD File Offset: 0x003618CD
		public static Offset<IFinishRhythmSpaceshipCondition> EndIFinishRhythmSpaceshipCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFinishRhythmSpaceshipCondition>(builder.EndTable());
		}

		// Token: 0x06017C08 RID: 97288 RVA: 0x003636DC File Offset: 0x003618DC
		public IFinishRhythmSpaceshipConditionT UnPack()
		{
			IFinishRhythmSpaceshipConditionT finishRhythmSpaceshipConditionT = new IFinishRhythmSpaceshipConditionT();
			this.UnPackTo(finishRhythmSpaceshipConditionT);
			return finishRhythmSpaceshipConditionT;
		}

		// Token: 0x06017C09 RID: 97289 RVA: 0x003636F8 File Offset: 0x003618F8
		public void UnPackTo(IFinishRhythmSpaceshipConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Step = ((this.Step != null) ? this.Step.Value.UnPack() : null);
		}

		// Token: 0x06017C0A RID: 97290 RVA: 0x00363770 File Offset: 0x00361970
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

		// Token: 0x0400C1AB RID: 49579
		private Table __p;
	}
}
