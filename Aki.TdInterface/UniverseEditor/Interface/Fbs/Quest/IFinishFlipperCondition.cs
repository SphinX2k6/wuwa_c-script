using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004271 RID: 17009
	public struct IFinishFlipperCondition : IFlatbufferObject
	{
		// Token: 0x17007407 RID: 29703
		// (get) Token: 0x06017B66 RID: 97126 RVA: 0x00361E43 File Offset: 0x00360043
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017B67 RID: 97127 RVA: 0x00361E50 File Offset: 0x00360050
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017B68 RID: 97128 RVA: 0x00361E58 File Offset: 0x00360058
		public static IFinishFlipperCondition GetRootAsIFinishFlipperCondition(ByteBuffer _bb)
		{
			return IFinishFlipperCondition.GetRootAsIFinishFlipperCondition(_bb, default(IFinishFlipperCondition));
		}

		// Token: 0x06017B69 RID: 97129 RVA: 0x00361E74 File Offset: 0x00360074
		public static IFinishFlipperCondition GetRootAsIFinishFlipperCondition(ByteBuffer _bb, IFinishFlipperCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017B6A RID: 97130 RVA: 0x00361E91 File Offset: 0x00360091
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017B6B RID: 97131 RVA: 0x00361EA0 File Offset: 0x003600A0
		public IFinishFlipperCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007408 RID: 29704
		// (get) Token: 0x06017B6C RID: 97132 RVA: 0x00361EB0 File Offset: 0x003600B0
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

		// Token: 0x17007409 RID: 29705
		// (get) Token: 0x06017B6D RID: 97133 RVA: 0x00361EEC File Offset: 0x003600EC
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

		// Token: 0x1700740A RID: 29706
		// (get) Token: 0x06017B6E RID: 97134 RVA: 0x00361F4C File Offset: 0x0036014C
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

		// Token: 0x06017B6F RID: 97135 RVA: 0x00361FA9 File Offset: 0x003601A9
		public static Offset<IFinishFlipperCondition> CreateIFinishFlipperCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<IFlipperConditionStepFight> StepOffset = default(Offset<IFlipperConditionStepFight>))
		{
			builder.StartTable(3);
			IFinishFlipperCondition.AddStep(builder, StepOffset);
			IFinishFlipperCondition.AddPreConditions(builder, PreConditionsOffset);
			IFinishFlipperCondition.AddType(builder, Type);
			return IFinishFlipperCondition.EndIFinishFlipperCondition(builder);
		}

		// Token: 0x06017B70 RID: 97136 RVA: 0x00361FCD File Offset: 0x003601CD
		public static void StartIFinishFlipperCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017B71 RID: 97137 RVA: 0x00361FD6 File Offset: 0x003601D6
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017B72 RID: 97138 RVA: 0x00361FE1 File Offset: 0x003601E1
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017B73 RID: 97139 RVA: 0x00361FF1 File Offset: 0x003601F1
		public static void AddStep(FlatBufferBuilder builder, Offset<IFlipperConditionStepFight> stepOffset)
		{
			builder.AddOffset(2, stepOffset.Value, 0);
		}

		// Token: 0x06017B74 RID: 97140 RVA: 0x00362001 File Offset: 0x00360201
		public static Offset<IFinishFlipperCondition> EndIFinishFlipperCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFinishFlipperCondition>(builder.EndTable());
		}

		// Token: 0x06017B75 RID: 97141 RVA: 0x00362010 File Offset: 0x00360210
		public IFinishFlipperConditionT UnPack()
		{
			IFinishFlipperConditionT finishFlipperConditionT = new IFinishFlipperConditionT();
			this.UnPackTo(finishFlipperConditionT);
			return finishFlipperConditionT;
		}

		// Token: 0x06017B76 RID: 97142 RVA: 0x0036202C File Offset: 0x0036022C
		public void UnPackTo(IFinishFlipperConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Step = ((this.Step != null) ? this.Step.Value.UnPack() : null);
		}

		// Token: 0x06017B77 RID: 97143 RVA: 0x003620A4 File Offset: 0x003602A4
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

		// Token: 0x0400C195 RID: 49557
		private Table __p;
	}
}
