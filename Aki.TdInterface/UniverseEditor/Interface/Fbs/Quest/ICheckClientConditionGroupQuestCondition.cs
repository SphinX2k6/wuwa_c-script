using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200415D RID: 16733
	public struct ICheckClientConditionGroupQuestCondition : IFlatbufferObject
	{
		// Token: 0x17007159 RID: 29017
		// (get) Token: 0x0601701F RID: 94239 RVA: 0x00347FC3 File Offset: 0x003461C3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017020 RID: 94240 RVA: 0x00347FD0 File Offset: 0x003461D0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017021 RID: 94241 RVA: 0x00347FD8 File Offset: 0x003461D8
		public static ICheckClientConditionGroupQuestCondition GetRootAsICheckClientConditionGroupQuestCondition(ByteBuffer _bb)
		{
			return ICheckClientConditionGroupQuestCondition.GetRootAsICheckClientConditionGroupQuestCondition(_bb, default(ICheckClientConditionGroupQuestCondition));
		}

		// Token: 0x06017022 RID: 94242 RVA: 0x00347FF4 File Offset: 0x003461F4
		public static ICheckClientConditionGroupQuestCondition GetRootAsICheckClientConditionGroupQuestCondition(ByteBuffer _bb, ICheckClientConditionGroupQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017023 RID: 94243 RVA: 0x00348011 File Offset: 0x00346211
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017024 RID: 94244 RVA: 0x00348020 File Offset: 0x00346220
		public ICheckClientConditionGroupQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700715A RID: 29018
		// (get) Token: 0x06017025 RID: 94245 RVA: 0x00348030 File Offset: 0x00346230
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

		// Token: 0x1700715B RID: 29019
		// (get) Token: 0x06017026 RID: 94246 RVA: 0x0034806C File Offset: 0x0034626C
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

		// Token: 0x1700715C RID: 29020
		// (get) Token: 0x06017027 RID: 94247 RVA: 0x003480CC File Offset: 0x003462CC
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06017028 RID: 94248 RVA: 0x00348129 File Offset: 0x00346329
		public static Offset<ICheckClientConditionGroupQuestCondition> CreateICheckClientConditionGroupQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(3);
			ICheckClientConditionGroupQuestCondition.AddCondition(builder, ConditionOffset);
			ICheckClientConditionGroupQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			ICheckClientConditionGroupQuestCondition.AddType(builder, Type);
			return ICheckClientConditionGroupQuestCondition.EndICheckClientConditionGroupQuestCondition(builder);
		}

		// Token: 0x06017029 RID: 94249 RVA: 0x0034814D File Offset: 0x0034634D
		public static void StartICheckClientConditionGroupQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601702A RID: 94250 RVA: 0x00348156 File Offset: 0x00346356
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601702B RID: 94251 RVA: 0x00348161 File Offset: 0x00346361
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601702C RID: 94252 RVA: 0x00348171 File Offset: 0x00346371
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(2, conditionOffset.Value, 0);
		}

		// Token: 0x0601702D RID: 94253 RVA: 0x00348181 File Offset: 0x00346381
		public static Offset<ICheckClientConditionGroupQuestCondition> EndICheckClientConditionGroupQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckClientConditionGroupQuestCondition>(builder.EndTable());
		}

		// Token: 0x0601702E RID: 94254 RVA: 0x00348190 File Offset: 0x00346390
		public ICheckClientConditionGroupQuestConditionT UnPack()
		{
			ICheckClientConditionGroupQuestConditionT checkClientConditionGroupQuestConditionT = new ICheckClientConditionGroupQuestConditionT();
			this.UnPackTo(checkClientConditionGroupQuestConditionT);
			return checkClientConditionGroupQuestConditionT;
		}

		// Token: 0x0601702F RID: 94255 RVA: 0x003481AC File Offset: 0x003463AC
		public void UnPackTo(ICheckClientConditionGroupQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x06017030 RID: 94256 RVA: 0x00348224 File Offset: 0x00346424
		public static Offset<ICheckClientConditionGroupQuestCondition> Pack(FlatBufferBuilder builder, ICheckClientConditionGroupQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckClientConditionGroupQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return ICheckClientConditionGroupQuestCondition.CreateICheckClientConditionGroupQuestCondition(builder, _o.Type, preConditionsOffset, conditionOffset);
		}

		// Token: 0x0400BFCB RID: 49099
		private Table __p;
	}
}
