using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004160 RID: 16736
	public struct ICheckConditionGroupQuestCondition : IFlatbufferObject
	{
		// Token: 0x17007160 RID: 29024
		// (get) Token: 0x06017039 RID: 94265 RVA: 0x00348356 File Offset: 0x00346556
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601703A RID: 94266 RVA: 0x00348363 File Offset: 0x00346563
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601703B RID: 94267 RVA: 0x0034836C File Offset: 0x0034656C
		public static ICheckConditionGroupQuestCondition GetRootAsICheckConditionGroupQuestCondition(ByteBuffer _bb)
		{
			return ICheckConditionGroupQuestCondition.GetRootAsICheckConditionGroupQuestCondition(_bb, default(ICheckConditionGroupQuestCondition));
		}

		// Token: 0x0601703C RID: 94268 RVA: 0x00348388 File Offset: 0x00346588
		public static ICheckConditionGroupQuestCondition GetRootAsICheckConditionGroupQuestCondition(ByteBuffer _bb, ICheckConditionGroupQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601703D RID: 94269 RVA: 0x003483A5 File Offset: 0x003465A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601703E RID: 94270 RVA: 0x003483B4 File Offset: 0x003465B4
		public ICheckConditionGroupQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007161 RID: 29025
		// (get) Token: 0x0601703F RID: 94271 RVA: 0x003483C4 File Offset: 0x003465C4
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

		// Token: 0x17007162 RID: 29026
		// (get) Token: 0x06017040 RID: 94272 RVA: 0x00348400 File Offset: 0x00346600
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

		// Token: 0x17007163 RID: 29027
		// (get) Token: 0x06017041 RID: 94273 RVA: 0x00348460 File Offset: 0x00346660
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

		// Token: 0x06017042 RID: 94274 RVA: 0x003484BD File Offset: 0x003466BD
		public static Offset<ICheckConditionGroupQuestCondition> CreateICheckConditionGroupQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(3);
			ICheckConditionGroupQuestCondition.AddCondition(builder, ConditionOffset);
			ICheckConditionGroupQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			ICheckConditionGroupQuestCondition.AddType(builder, Type);
			return ICheckConditionGroupQuestCondition.EndICheckConditionGroupQuestCondition(builder);
		}

		// Token: 0x06017043 RID: 94275 RVA: 0x003484E1 File Offset: 0x003466E1
		public static void StartICheckConditionGroupQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017044 RID: 94276 RVA: 0x003484EA File Offset: 0x003466EA
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017045 RID: 94277 RVA: 0x003484F5 File Offset: 0x003466F5
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017046 RID: 94278 RVA: 0x00348505 File Offset: 0x00346705
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(2, conditionOffset.Value, 0);
		}

		// Token: 0x06017047 RID: 94279 RVA: 0x00348515 File Offset: 0x00346715
		public static Offset<ICheckConditionGroupQuestCondition> EndICheckConditionGroupQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckConditionGroupQuestCondition>(builder.EndTable());
		}

		// Token: 0x06017048 RID: 94280 RVA: 0x00348524 File Offset: 0x00346724
		public ICheckConditionGroupQuestConditionT UnPack()
		{
			ICheckConditionGroupQuestConditionT checkConditionGroupQuestConditionT = new ICheckConditionGroupQuestConditionT();
			this.UnPackTo(checkConditionGroupQuestConditionT);
			return checkConditionGroupQuestConditionT;
		}

		// Token: 0x06017049 RID: 94281 RVA: 0x00348540 File Offset: 0x00346740
		public void UnPackTo(ICheckConditionGroupQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x0601704A RID: 94282 RVA: 0x003485B8 File Offset: 0x003467B8
		public static Offset<ICheckConditionGroupQuestCondition> Pack(FlatBufferBuilder builder, ICheckConditionGroupQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckConditionGroupQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return ICheckConditionGroupQuestCondition.CreateICheckConditionGroupQuestCondition(builder, _o.Type, preConditionsOffset, conditionOffset);
		}

		// Token: 0x0400BFCF RID: 49103
		private Table __p;
	}
}
