using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E33 RID: 15923
	public struct IFinishDungeonQuestCondition : IFlatbufferObject
	{
		// Token: 0x17006E1A RID: 28186
		// (get) Token: 0x0601651B RID: 91419 RVA: 0x00338DBB File Offset: 0x00336FBB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601651C RID: 91420 RVA: 0x00338DC8 File Offset: 0x00336FC8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601651D RID: 91421 RVA: 0x00338DD0 File Offset: 0x00336FD0
		public static IFinishDungeonQuestCondition GetRootAsIFinishDungeonQuestCondition(ByteBuffer _bb)
		{
			return IFinishDungeonQuestCondition.GetRootAsIFinishDungeonQuestCondition(_bb, default(IFinishDungeonQuestCondition));
		}

		// Token: 0x0601651E RID: 91422 RVA: 0x00338DEC File Offset: 0x00336FEC
		public static IFinishDungeonQuestCondition GetRootAsIFinishDungeonQuestCondition(ByteBuffer _bb, IFinishDungeonQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601651F RID: 91423 RVA: 0x00338E09 File Offset: 0x00337009
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016520 RID: 91424 RVA: 0x00338E18 File Offset: 0x00337018
		public IFinishDungeonQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E1B RID: 28187
		// (get) Token: 0x06016521 RID: 91425 RVA: 0x00338E28 File Offset: 0x00337028
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

		// Token: 0x17006E1C RID: 28188
		// (get) Token: 0x06016522 RID: 91426 RVA: 0x00338E64 File Offset: 0x00337064
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

		// Token: 0x17006E1D RID: 28189
		// (get) Token: 0x06016523 RID: 91427 RVA: 0x00338EC4 File Offset: 0x003370C4
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

		// Token: 0x06016524 RID: 91428 RVA: 0x00338F00 File Offset: 0x00337100
		public TTable? Condition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016525 RID: 91429 RVA: 0x00338F48 File Offset: 0x00337148
		public IDungeonIdCondition ConditionAsIDungeonIdCondition()
		{
			return this.Condition<IDungeonIdCondition>().Value;
		}

		// Token: 0x06016526 RID: 91430 RVA: 0x00338F64 File Offset: 0x00337164
		public IDungeonSubTypeCondition ConditionAsIDungeonSubTypeCondition()
		{
			return this.Condition<IDungeonSubTypeCondition>().Value;
		}

		// Token: 0x06016527 RID: 91431 RVA: 0x00338F7F File Offset: 0x0033717F
		public static Offset<IFinishDungeonQuestCondition> CreateIFinishDungeonQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TDungeonConditionType Condition_type = TDungeonConditionType.NONE, int ConditionOffset = 0)
		{
			builder.StartTable(4);
			IFinishDungeonQuestCondition.AddCondition(builder, ConditionOffset);
			IFinishDungeonQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IFinishDungeonQuestCondition.AddConditionType(builder, Condition_type);
			IFinishDungeonQuestCondition.AddType(builder, Type);
			return IFinishDungeonQuestCondition.EndIFinishDungeonQuestCondition(builder);
		}

		// Token: 0x06016528 RID: 91432 RVA: 0x00338FAB File Offset: 0x003371AB
		public static void StartIFinishDungeonQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016529 RID: 91433 RVA: 0x00338FB4 File Offset: 0x003371B4
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601652A RID: 91434 RVA: 0x00338FBF File Offset: 0x003371BF
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601652B RID: 91435 RVA: 0x00338FCF File Offset: 0x003371CF
		public static void AddConditionType(FlatBufferBuilder builder, TDungeonConditionType conditionType)
		{
			builder.AddByte(2, (byte)conditionType, 0);
		}

		// Token: 0x0601652C RID: 91436 RVA: 0x00338FDA File Offset: 0x003371DA
		public static void AddCondition(FlatBufferBuilder builder, int conditionOffset)
		{
			builder.AddOffset(3, conditionOffset, 0);
		}

		// Token: 0x0601652D RID: 91437 RVA: 0x00338FE5 File Offset: 0x003371E5
		public static Offset<IFinishDungeonQuestCondition> EndIFinishDungeonQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFinishDungeonQuestCondition>(builder.EndTable());
		}

		// Token: 0x0601652E RID: 91438 RVA: 0x00338FF4 File Offset: 0x003371F4
		public IFinishDungeonQuestConditionT UnPack()
		{
			IFinishDungeonQuestConditionT finishDungeonQuestConditionT = new IFinishDungeonQuestConditionT();
			this.UnPackTo(finishDungeonQuestConditionT);
			return finishDungeonQuestConditionT;
		}

		// Token: 0x0601652F RID: 91439 RVA: 0x00339010 File Offset: 0x00337210
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

		// Token: 0x06016530 RID: 91440 RVA: 0x003390F4 File Offset: 0x003372F4
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

		// Token: 0x0400B7B9 RID: 47033
		private Table __p;
	}
}
