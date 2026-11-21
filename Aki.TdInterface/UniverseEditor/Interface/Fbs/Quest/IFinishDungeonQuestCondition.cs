using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200426E RID: 17006
	public struct IFinishDungeonQuestCondition : IFlatbufferObject
	{
		// Token: 0x17007400 RID: 29696
		// (get) Token: 0x06017B48 RID: 97096 RVA: 0x003619B3 File Offset: 0x0035FBB3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017B49 RID: 97097 RVA: 0x003619C0 File Offset: 0x0035FBC0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017B4A RID: 97098 RVA: 0x003619C8 File Offset: 0x0035FBC8
		public static IFinishDungeonQuestCondition GetRootAsIFinishDungeonQuestCondition(ByteBuffer _bb)
		{
			return IFinishDungeonQuestCondition.GetRootAsIFinishDungeonQuestCondition(_bb, default(IFinishDungeonQuestCondition));
		}

		// Token: 0x06017B4B RID: 97099 RVA: 0x003619E4 File Offset: 0x0035FBE4
		public static IFinishDungeonQuestCondition GetRootAsIFinishDungeonQuestCondition(ByteBuffer _bb, IFinishDungeonQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017B4C RID: 97100 RVA: 0x00361A01 File Offset: 0x0035FC01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017B4D RID: 97101 RVA: 0x00361A10 File Offset: 0x0035FC10
		public IFinishDungeonQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007401 RID: 29697
		// (get) Token: 0x06017B4E RID: 97102 RVA: 0x00361A20 File Offset: 0x0035FC20
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

		// Token: 0x17007402 RID: 29698
		// (get) Token: 0x06017B4F RID: 97103 RVA: 0x00361A5C File Offset: 0x0035FC5C
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

		// Token: 0x17007403 RID: 29699
		// (get) Token: 0x06017B50 RID: 97104 RVA: 0x00361ABC File Offset: 0x0035FCBC
		public TDungeonConditionType ConditionType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TDungeonConditionType.NONE;
				}
				return (TDungeonConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017B51 RID: 97105 RVA: 0x00361AF8 File Offset: 0x0035FCF8
		public TTable? Condition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017B52 RID: 97106 RVA: 0x00361B40 File Offset: 0x0035FD40
		public IDungeonIdCondition ConditionAsIDungeonIdCondition()
		{
			return this.Condition<IDungeonIdCondition>().Value;
		}

		// Token: 0x06017B53 RID: 97107 RVA: 0x00361B5C File Offset: 0x0035FD5C
		public IDungeonSubTypeCondition ConditionAsIDungeonSubTypeCondition()
		{
			return this.Condition<IDungeonSubTypeCondition>().Value;
		}

		// Token: 0x06017B54 RID: 97108 RVA: 0x00361B77 File Offset: 0x0035FD77
		public static Offset<IFinishDungeonQuestCondition> CreateIFinishDungeonQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TDungeonConditionType Condition_type = TDungeonConditionType.NONE, int ConditionOffset = 0)
		{
			builder.StartTable(4);
			IFinishDungeonQuestCondition.AddCondition(builder, ConditionOffset);
			IFinishDungeonQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IFinishDungeonQuestCondition.AddConditionType(builder, Condition_type);
			IFinishDungeonQuestCondition.AddType(builder, Type);
			return IFinishDungeonQuestCondition.EndIFinishDungeonQuestCondition(builder);
		}

		// Token: 0x06017B55 RID: 97109 RVA: 0x00361BA3 File Offset: 0x0035FDA3
		public static void StartIFinishDungeonQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017B56 RID: 97110 RVA: 0x00361BAC File Offset: 0x0035FDAC
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017B57 RID: 97111 RVA: 0x00361BB7 File Offset: 0x0035FDB7
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017B58 RID: 97112 RVA: 0x00361BC7 File Offset: 0x0035FDC7
		public static void AddConditionType(FlatBufferBuilder builder, TDungeonConditionType conditionType)
		{
			builder.AddByte(2, (byte)conditionType, 0);
		}

		// Token: 0x06017B59 RID: 97113 RVA: 0x00361BD2 File Offset: 0x0035FDD2
		public static void AddCondition(FlatBufferBuilder builder, int conditionOffset)
		{
			builder.AddOffset(3, conditionOffset, 0);
		}

		// Token: 0x06017B5A RID: 97114 RVA: 0x00361BDD File Offset: 0x0035FDDD
		public static Offset<IFinishDungeonQuestCondition> EndIFinishDungeonQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFinishDungeonQuestCondition>(builder.EndTable());
		}

		// Token: 0x06017B5B RID: 97115 RVA: 0x00361BEC File Offset: 0x0035FDEC
		public IFinishDungeonQuestConditionT UnPack()
		{
			IFinishDungeonQuestConditionT finishDungeonQuestConditionT = new IFinishDungeonQuestConditionT();
			this.UnPackTo(finishDungeonQuestConditionT);
			return finishDungeonQuestConditionT;
		}

		// Token: 0x06017B5C RID: 97116 RVA: 0x00361C08 File Offset: 0x0035FE08
		public void UnPackTo(IFinishDungeonQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Condition = new TDungeonConditionTypeUnion();
			_o.Condition.Type = this.ConditionType;
			TDungeonConditionType conditionType = this.ConditionType;
			if (conditionType == TDungeonConditionType.IDungeonIdCondition)
			{
				_o.Condition.Value = ((this.Condition<IDungeonIdCondition>() != null) ? this.Condition<IDungeonIdCondition>().Value.UnPack() : null);
				return;
			}
			if (conditionType != TDungeonConditionType.IDungeonSubTypeCondition)
			{
				return;
			}
			_o.Condition.Value = ((this.Condition<IDungeonSubTypeCondition>() != null) ? this.Condition<IDungeonSubTypeCondition>().Value.UnPack() : null);
		}

		// Token: 0x06017B5D RID: 97117 RVA: 0x00361CEC File Offset: 0x0035FEEC
		public static Offset<IFinishDungeonQuestCondition> Pack(FlatBufferBuilder builder, IFinishDungeonQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishDungeonQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			TDungeonConditionType condition_type = (_o.Condition == null) ? TDungeonConditionType.NONE : _o.Condition.Type;
			int conditionOffset = (_o.Condition == null) ? 0 : TDungeonConditionTypeUnion.Pack(builder, _o.Condition);
			return IFinishDungeonQuestCondition.CreateIFinishDungeonQuestCondition(builder, _o.Type, preConditionsOffset, condition_type, conditionOffset);
		}

		// Token: 0x0400C191 RID: 49553
		private Table __p;
	}
}
