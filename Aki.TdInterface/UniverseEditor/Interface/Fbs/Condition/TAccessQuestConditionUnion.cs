using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005224 RID: 21028
	public class TAccessQuestConditionUnion
	{
		// Token: 0x1700966E RID: 38510
		// (get) Token: 0x060211E5 RID: 135653 RVA: 0x00492E70 File Offset: 0x00491070
		// (set) Token: 0x060211E6 RID: 135654 RVA: 0x00492E78 File Offset: 0x00491078
		public TAccessQuestCondition Type { get; set; }

		// Token: 0x1700966F RID: 38511
		// (get) Token: 0x060211E7 RID: 135655 RVA: 0x00492E81 File Offset: 0x00491081
		// (set) Token: 0x060211E8 RID: 135656 RVA: 0x00492E89 File Offset: 0x00491089
		public object Value { get; set; }

		// Token: 0x060211E9 RID: 135657 RVA: 0x00492E92 File Offset: 0x00491092
		public TAccessQuestConditionUnion()
		{
			this.Type = TAccessQuestCondition.NONE;
			this.Value = null;
		}

		// Token: 0x060211EA RID: 135658 RVA: 0x00492EA8 File Offset: 0x004910A8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060211EB RID: 135659 RVA: 0x00492EBA File Offset: 0x004910BA
		public IDungeonQuestPreConditionT AsIDungeonQuestPreCondition()
		{
			return this.As<IDungeonQuestPreConditionT>();
		}

		// Token: 0x060211EC RID: 135660 RVA: 0x00492EC2 File Offset: 0x004910C2
		public static TAccessQuestConditionUnion FromIDungeonQuestPreCondition(IDungeonQuestPreConditionT _idungeonquestprecondition)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IDungeonQuestPreCondition,
				Value = _idungeonquestprecondition
			};
		}

		// Token: 0x060211ED RID: 135661 RVA: 0x00492ED7 File Offset: 0x004910D7
		public IExploreLevelCondtionT AsIExploreLevelCondtion()
		{
			return this.As<IExploreLevelCondtionT>();
		}

		// Token: 0x060211EE RID: 135662 RVA: 0x00492EDF File Offset: 0x004910DF
		public static TAccessQuestConditionUnion FromIExploreLevelCondtion(IExploreLevelCondtionT _iexplorelevelcondtion)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IExploreLevelCondtion,
				Value = _iexplorelevelcondtion
			};
		}

		// Token: 0x060211EF RID: 135663 RVA: 0x00492EF4 File Offset: 0x004910F4
		public IFeatureCollectionLevelPreConditionT AsIFeatureCollectionLevelPreCondition()
		{
			return this.As<IFeatureCollectionLevelPreConditionT>();
		}

		// Token: 0x060211F0 RID: 135664 RVA: 0x00492EFC File Offset: 0x004910FC
		public static TAccessQuestConditionUnion FromIFeatureCollectionLevelPreCondition(IFeatureCollectionLevelPreConditionT _ifeaturecollectionlevelprecondition)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IFeatureCollectionLevelPreCondition,
				Value = _ifeaturecollectionlevelprecondition
			};
		}

		// Token: 0x060211F1 RID: 135665 RVA: 0x00492F11 File Offset: 0x00491111
		public IItemConditionT AsIItemCondition()
		{
			return this.As<IItemConditionT>();
		}

		// Token: 0x060211F2 RID: 135666 RVA: 0x00492F19 File Offset: 0x00491119
		public static TAccessQuestConditionUnion FromIItemCondition(IItemConditionT _iitemcondition)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IItemCondition,
				Value = _iitemcondition
			};
		}

		// Token: 0x060211F3 RID: 135667 RVA: 0x00492F2E File Offset: 0x0049112E
		public IPreChildQuestCondtionT AsIPreChildQuestCondtion()
		{
			return this.As<IPreChildQuestCondtionT>();
		}

		// Token: 0x060211F4 RID: 135668 RVA: 0x00492F36 File Offset: 0x00491136
		public static TAccessQuestConditionUnion FromIPreChildQuestCondtion(IPreChildQuestCondtionT _iprechildquestcondtion)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IPreChildQuestCondtion,
				Value = _iprechildquestcondtion
			};
		}

		// Token: 0x060211F5 RID: 135669 RVA: 0x00492F4B File Offset: 0x0049114B
		public IPreGenderCondtionT AsIPreGenderCondtion()
		{
			return this.As<IPreGenderCondtionT>();
		}

		// Token: 0x060211F6 RID: 135670 RVA: 0x00492F53 File Offset: 0x00491153
		public static TAccessQuestConditionUnion FromIPreGenderCondtion(IPreGenderCondtionT _ipregendercondtion)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IPreGenderCondtion,
				Value = _ipregendercondtion
			};
		}

		// Token: 0x060211F7 RID: 135671 RVA: 0x00492F68 File Offset: 0x00491168
		public IPreLevelPlayCondtionT AsIPreLevelPlayCondtion()
		{
			return this.As<IPreLevelPlayCondtionT>();
		}

		// Token: 0x060211F8 RID: 135672 RVA: 0x00492F70 File Offset: 0x00491170
		public static TAccessQuestConditionUnion FromIPreLevelPlayCondtion(IPreLevelPlayCondtionT _iprelevelplaycondtion)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IPreLevelPlayCondtion,
				Value = _iprelevelplaycondtion
			};
		}

		// Token: 0x060211F9 RID: 135673 RVA: 0x00492F85 File Offset: 0x00491185
		public IPreQuestCondtionT AsIPreQuestCondtion()
		{
			return this.As<IPreQuestCondtionT>();
		}

		// Token: 0x060211FA RID: 135674 RVA: 0x00492F8D File Offset: 0x0049118D
		public static TAccessQuestConditionUnion FromIPreQuestCondtion(IPreQuestCondtionT _iprequestcondtion)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IPreQuestCondtion,
				Value = _iprequestcondtion
			};
		}

		// Token: 0x060211FB RID: 135675 RVA: 0x00492FA2 File Offset: 0x004911A2
		public IReachAreaCondtionT AsIReachAreaCondtion()
		{
			return this.As<IReachAreaCondtionT>();
		}

		// Token: 0x060211FC RID: 135676 RVA: 0x00492FAA File Offset: 0x004911AA
		public static TAccessQuestConditionUnion FromIReachAreaCondtion(IReachAreaCondtionT _ireachareacondtion)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IReachAreaCondtion,
				Value = _ireachareacondtion
			};
		}

		// Token: 0x060211FD RID: 135677 RVA: 0x00492FC0 File Offset: 0x004911C0
		public ISystemStateConditonT AsISystemStateConditon()
		{
			return this.As<ISystemStateConditonT>();
		}

		// Token: 0x060211FE RID: 135678 RVA: 0x00492FC8 File Offset: 0x004911C8
		public static TAccessQuestConditionUnion FromISystemStateConditon(ISystemStateConditonT _isystemstateconditon)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.ISystemStateConditon,
				Value = _isystemstateconditon
			};
		}

		// Token: 0x060211FF RID: 135679 RVA: 0x00492FDE File Offset: 0x004911DE
		public IOpenDateConditonT AsIOpenDateConditon()
		{
			return this.As<IOpenDateConditonT>();
		}

		// Token: 0x06021200 RID: 135680 RVA: 0x00492FE6 File Offset: 0x004911E6
		public static TAccessQuestConditionUnion FromIOpenDateConditon(IOpenDateConditonT _iopendateconditon)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IOpenDateConditon,
				Value = _iopendateconditon
			};
		}

		// Token: 0x06021201 RID: 135681 RVA: 0x00492FFC File Offset: 0x004911FC
		public IMapThemedActivityReachRankT AsIMapThemedActivityReachRank()
		{
			return this.As<IMapThemedActivityReachRankT>();
		}

		// Token: 0x06021202 RID: 135682 RVA: 0x00493004 File Offset: 0x00491204
		public static TAccessQuestConditionUnion FromIMapThemedActivityReachRank(IMapThemedActivityReachRankT _imapthemedactivityreachrank)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IMapThemedActivityReachRank,
				Value = _imapthemedactivityreachrank
			};
		}

		// Token: 0x06021203 RID: 135683 RVA: 0x0049301C File Offset: 0x0049121C
		public static int Pack(FlatBufferBuilder builder, TAccessQuestConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TAccessQuestCondition.IDungeonQuestPreCondition:
				return IDungeonQuestPreCondition.Pack(builder, _o.AsIDungeonQuestPreCondition()).Value;
			case TAccessQuestCondition.IExploreLevelCondtion:
				return IExploreLevelCondtion.Pack(builder, _o.AsIExploreLevelCondtion()).Value;
			case TAccessQuestCondition.IFeatureCollectionLevelPreCondition:
				return IFeatureCollectionLevelPreCondition.Pack(builder, _o.AsIFeatureCollectionLevelPreCondition()).Value;
			case TAccessQuestCondition.IItemCondition:
				return IItemCondition.Pack(builder, _o.AsIItemCondition()).Value;
			case TAccessQuestCondition.IPreChildQuestCondtion:
				return IPreChildQuestCondtion.Pack(builder, _o.AsIPreChildQuestCondtion()).Value;
			case TAccessQuestCondition.IPreGenderCondtion:
				return IPreGenderCondtion.Pack(builder, _o.AsIPreGenderCondtion()).Value;
			case TAccessQuestCondition.IPreLevelPlayCondtion:
				return IPreLevelPlayCondtion.Pack(builder, _o.AsIPreLevelPlayCondtion()).Value;
			case TAccessQuestCondition.IPreQuestCondtion:
				return IPreQuestCondtion.Pack(builder, _o.AsIPreQuestCondtion()).Value;
			case TAccessQuestCondition.IReachAreaCondtion:
				return IReachAreaCondtion.Pack(builder, _o.AsIReachAreaCondtion()).Value;
			case TAccessQuestCondition.ISystemStateConditon:
				return ISystemStateConditon.Pack(builder, _o.AsISystemStateConditon()).Value;
			case TAccessQuestCondition.IOpenDateConditon:
				return IOpenDateConditon.Pack(builder, _o.AsIOpenDateConditon()).Value;
			case TAccessQuestCondition.IMapThemedActivityReachRank:
				return IMapThemedActivityReachRank.Pack(builder, _o.AsIMapThemedActivityReachRank()).Value;
			default:
				return 0;
			}
		}
	}
}
