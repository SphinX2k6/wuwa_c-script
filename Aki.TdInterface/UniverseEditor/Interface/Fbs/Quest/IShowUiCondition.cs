using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004562 RID: 17762
	public struct IShowUiCondition : IFlatbufferObject
	{
		// Token: 0x17007C13 RID: 31763
		// (get) Token: 0x06019D40 RID: 105792 RVA: 0x003AF511 File Offset: 0x003AD711
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019D41 RID: 105793 RVA: 0x003AF51E File Offset: 0x003AD71E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019D42 RID: 105794 RVA: 0x003AF528 File Offset: 0x003AD728
		public static IShowUiCondition GetRootAsIShowUiCondition(ByteBuffer _bb)
		{
			return IShowUiCondition.GetRootAsIShowUiCondition(_bb, default(IShowUiCondition));
		}

		// Token: 0x06019D43 RID: 105795 RVA: 0x003AF544 File Offset: 0x003AD744
		public static IShowUiCondition GetRootAsIShowUiCondition(ByteBuffer _bb, IShowUiCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019D44 RID: 105796 RVA: 0x003AF561 File Offset: 0x003AD761
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019D45 RID: 105797 RVA: 0x003AF570 File Offset: 0x003AD770
		public IShowUiCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C14 RID: 31764
		// (get) Token: 0x06019D46 RID: 105798 RVA: 0x003AF580 File Offset: 0x003AD780
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

		// Token: 0x17007C15 RID: 31765
		// (get) Token: 0x06019D47 RID: 105799 RVA: 0x003AF5BC File Offset: 0x003AD7BC
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

		// Token: 0x17007C16 RID: 31766
		// (get) Token: 0x06019D48 RID: 105800 RVA: 0x003AF61C File Offset: 0x003AD81C
		public TShowUi UiTypeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TShowUi.NONE;
				}
				return (TShowUi)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019D49 RID: 105801 RVA: 0x003AF658 File Offset: 0x003AD858
		public TTable? UiType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019D4A RID: 105802 RVA: 0x003AF6A0 File Offset: 0x003AD8A0
		public ICiacconaAvgBoard UiTypeAsICiacconaAvgBoard()
		{
			return this.UiType<ICiacconaAvgBoard>().Value;
		}

		// Token: 0x06019D4B RID: 105803 RVA: 0x003AF6BC File Offset: 0x003AD8BC
		public IInformationView UiTypeAsIInformationView()
		{
			return this.UiType<IInformationView>().Value;
		}

		// Token: 0x06019D4C RID: 105804 RVA: 0x003AF6D8 File Offset: 0x003AD8D8
		public IItemObtain UiTypeAsIItemObtain()
		{
			return this.UiType<IItemObtain>().Value;
		}

		// Token: 0x06019D4D RID: 105805 RVA: 0x003AF6F4 File Offset: 0x003AD8F4
		public IMowBuffDistribute UiTypeAsIMowBuffDistribute()
		{
			return this.UiType<IMowBuffDistribute>().Value;
		}

		// Token: 0x06019D4E RID: 105806 RVA: 0x003AF710 File Offset: 0x003AD910
		public IPermanentRogueUi UiTypeAsIPermanentRogueUi()
		{
			return this.UiType<IPermanentRogueUi>().Value;
		}

		// Token: 0x06019D4F RID: 105807 RVA: 0x003AF72C File Offset: 0x003AD92C
		public IRogueAbilitySelect UiTypeAsIRogueAbilitySelect()
		{
			return this.UiType<IRogueAbilitySelect>().Value;
		}

		// Token: 0x06019D50 RID: 105808 RVA: 0x003AF748 File Offset: 0x003AD948
		public IRogueRandomEvent UiTypeAsIRogueRandomEvent()
		{
			return this.UiType<IRogueRandomEvent>().Value;
		}

		// Token: 0x06019D51 RID: 105809 RVA: 0x003AF764 File Offset: 0x003AD964
		public IRoleSkinTrialActivities UiTypeAsIRoleSkinTrialActivities()
		{
			return this.UiType<IRoleSkinTrialActivities>().Value;
		}

		// Token: 0x06019D52 RID: 105810 RVA: 0x003AF780 File Offset: 0x003AD980
		public IRoleTrialActivities UiTypeAsIRoleTrialActivities()
		{
			return this.UiType<IRoleTrialActivities>().Value;
		}

		// Token: 0x06019D53 RID: 105811 RVA: 0x003AF79C File Offset: 0x003AD99C
		public IShowUiAll UiTypeAsIShowUiAll()
		{
			return this.UiType<IShowUiAll>().Value;
		}

		// Token: 0x06019D54 RID: 105812 RVA: 0x003AF7B8 File Offset: 0x003AD9B8
		public IShowUiCook UiTypeAsIShowUiCook()
		{
			return this.UiType<IShowUiCook>().Value;
		}

		// Token: 0x06019D55 RID: 105813 RVA: 0x003AF7D4 File Offset: 0x003AD9D4
		public IShowUiForging UiTypeAsIShowUiForging()
		{
			return this.UiType<IShowUiForging>().Value;
		}

		// Token: 0x06019D56 RID: 105814 RVA: 0x003AF7F0 File Offset: 0x003AD9F0
		public IShowUiSynthetic UiTypeAsIShowUiSynthetic()
		{
			return this.UiType<IShowUiSynthetic>().Value;
		}

		// Token: 0x17007C17 RID: 31767
		// (get) Token: 0x06019D57 RID: 105815 RVA: 0x003AF80C File Offset: 0x003ADA0C
		public bool KeepUiOpen
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007C18 RID: 31768
		// (get) Token: 0x06019D58 RID: 105816 RVA: 0x003AF84C File Offset: 0x003ADA4C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019D59 RID: 105817 RVA: 0x003AF889 File Offset: 0x003ADA89
		public static Offset<IShowUiCondition> CreateIShowUiCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TShowUi UiType_type = TShowUi.NONE, int UiTypeOffset = 0, bool KeepUiOpen = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IShowUiCondition.AddUiType(builder, UiTypeOffset);
			IShowUiCondition.AddPreConditions(builder, PreConditionsOffset);
			IShowUiCondition.AddNullMask(builder, NullMask);
			IShowUiCondition.AddKeepUiOpen(builder, KeepUiOpen);
			IShowUiCondition.AddUiTypeType(builder, UiType_type);
			IShowUiCondition.AddType(builder, Type);
			return IShowUiCondition.EndIShowUiCondition(builder);
		}

		// Token: 0x06019D5A RID: 105818 RVA: 0x003AF8C5 File Offset: 0x003ADAC5
		public static void StartIShowUiCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06019D5B RID: 105819 RVA: 0x003AF8CE File Offset: 0x003ADACE
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019D5C RID: 105820 RVA: 0x003AF8D9 File Offset: 0x003ADAD9
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06019D5D RID: 105821 RVA: 0x003AF8E9 File Offset: 0x003ADAE9
		public static void AddUiTypeType(FlatBufferBuilder builder, TShowUi uiTypeType)
		{
			builder.AddByte(2, (byte)uiTypeType, 0);
		}

		// Token: 0x06019D5E RID: 105822 RVA: 0x003AF8F4 File Offset: 0x003ADAF4
		public static void AddUiType(FlatBufferBuilder builder, int uiTypeOffset)
		{
			builder.AddOffset(3, uiTypeOffset, 0);
		}

		// Token: 0x06019D5F RID: 105823 RVA: 0x003AF8FF File Offset: 0x003ADAFF
		public static void AddKeepUiOpen(FlatBufferBuilder builder, bool keepUiOpen)
		{
			builder.AddBool(4, keepUiOpen, false);
		}

		// Token: 0x06019D60 RID: 105824 RVA: 0x003AF90A File Offset: 0x003ADB0A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06019D61 RID: 105825 RVA: 0x003AF915 File Offset: 0x003ADB15
		public static Offset<IShowUiCondition> EndIShowUiCondition(FlatBufferBuilder builder)
		{
			return new Offset<IShowUiCondition>(builder.EndTable());
		}

		// Token: 0x06019D62 RID: 105826 RVA: 0x003AF924 File Offset: 0x003ADB24
		public IShowUiConditionT UnPack()
		{
			IShowUiConditionT showUiConditionT = new IShowUiConditionT();
			this.UnPackTo(showUiConditionT);
			return showUiConditionT;
		}

		// Token: 0x06019D63 RID: 105827 RVA: 0x003AF940 File Offset: 0x003ADB40
		public void UnPackTo(IShowUiConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.UiType = new TShowUiUnion();
			_o.UiType.Type = this.UiTypeType;
			switch (this.UiTypeType)
			{
			case TShowUi.ICiacconaAvgBoard:
				_o.UiType.Value = ((this.UiType<ICiacconaAvgBoard>() != null) ? this.UiType<ICiacconaAvgBoard>().Value.UnPack() : null);
				break;
			case TShowUi.IInformationView:
				_o.UiType.Value = ((this.UiType<IInformationView>() != null) ? this.UiType<IInformationView>().Value.UnPack() : null);
				break;
			case TShowUi.IItemObtain:
				_o.UiType.Value = ((this.UiType<IItemObtain>() != null) ? this.UiType<IItemObtain>().Value.UnPack() : null);
				break;
			case TShowUi.IMowBuffDistribute:
				_o.UiType.Value = ((this.UiType<IMowBuffDistribute>() != null) ? this.UiType<IMowBuffDistribute>().Value.UnPack() : null);
				break;
			case TShowUi.IPermanentRogueUi:
				_o.UiType.Value = ((this.UiType<IPermanentRogueUi>() != null) ? this.UiType<IPermanentRogueUi>().Value.UnPack() : null);
				break;
			case TShowUi.IRogueAbilitySelect:
				_o.UiType.Value = ((this.UiType<IRogueAbilitySelect>() != null) ? this.UiType<IRogueAbilitySelect>().Value.UnPack() : null);
				break;
			case TShowUi.IRogueRandomEvent:
				_o.UiType.Value = ((this.UiType<IRogueRandomEvent>() != null) ? this.UiType<IRogueRandomEvent>().Value.UnPack() : null);
				break;
			case TShowUi.IRoleSkinTrialActivities:
				_o.UiType.Value = ((this.UiType<IRoleSkinTrialActivities>() != null) ? this.UiType<IRoleSkinTrialActivities>().Value.UnPack() : null);
				break;
			case TShowUi.IRoleTrialActivities:
				_o.UiType.Value = ((this.UiType<IRoleTrialActivities>() != null) ? this.UiType<IRoleTrialActivities>().Value.UnPack() : null);
				break;
			case TShowUi.IShowUiAll:
				_o.UiType.Value = ((this.UiType<IShowUiAll>() != null) ? this.UiType<IShowUiAll>().Value.UnPack() : null);
				break;
			case TShowUi.IShowUiCook:
				_o.UiType.Value = ((this.UiType<IShowUiCook>() != null) ? this.UiType<IShowUiCook>().Value.UnPack() : null);
				break;
			case TShowUi.IShowUiForging:
				_o.UiType.Value = ((this.UiType<IShowUiForging>() != null) ? this.UiType<IShowUiForging>().Value.UnPack() : null);
				break;
			case TShowUi.IShowUiSynthetic:
				_o.UiType.Value = ((this.UiType<IShowUiSynthetic>() != null) ? this.UiType<IShowUiSynthetic>().Value.UnPack() : null);
				break;
			}
			_o.KeepUiOpen = this.KeepUiOpen;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019D64 RID: 105828 RVA: 0x003AFD04 File Offset: 0x003ADF04
		public static Offset<IShowUiCondition> Pack(FlatBufferBuilder builder, IShowUiConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowUiCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			TShowUi uiType_type = (_o.UiType == null) ? TShowUi.NONE : _o.UiType.Type;
			int uiTypeOffset = (_o.UiType == null) ? 0 : TShowUiUnion.Pack(builder, _o.UiType);
			return IShowUiCondition.CreateIShowUiCondition(builder, _o.Type, preConditionsOffset, uiType_type, uiTypeOffset, _o.KeepUiOpen, _o.NullMask);
		}

		// Token: 0x0400C6F3 RID: 50931
		private Table __p;
	}
}
