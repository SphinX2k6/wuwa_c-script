using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E28 RID: 20008
	public class IBaseAccessQuestCondition_UnionUnion
	{
		// Token: 0x17008E89 RID: 36489
		// (get) Token: 0x0601EEEF RID: 126703 RVA: 0x004524FD File Offset: 0x004506FD
		// (set) Token: 0x0601EEF0 RID: 126704 RVA: 0x00452505 File Offset: 0x00450705
		public IBaseAccessQuestCondition_Union Type { get; set; }

		// Token: 0x17008E8A RID: 36490
		// (get) Token: 0x0601EEF1 RID: 126705 RVA: 0x0045250E File Offset: 0x0045070E
		// (set) Token: 0x0601EEF2 RID: 126706 RVA: 0x00452516 File Offset: 0x00450716
		public object Value { get; set; }

		// Token: 0x0601EEF3 RID: 126707 RVA: 0x0045251F File Offset: 0x0045071F
		public IBaseAccessQuestCondition_UnionUnion()
		{
			this.Type = IBaseAccessQuestCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601EEF4 RID: 126708 RVA: 0x00452535 File Offset: 0x00450735
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601EEF5 RID: 126709 RVA: 0x00452547 File Offset: 0x00450747
		public IBaseAccessQuestConditionT AsIBaseAccessQuestCondition()
		{
			return this.As<IBaseAccessQuestConditionT>();
		}

		// Token: 0x0601EEF6 RID: 126710 RVA: 0x0045254F File Offset: 0x0045074F
		public static IBaseAccessQuestCondition_UnionUnion FromIBaseAccessQuestCondition(IBaseAccessQuestConditionT _ibaseaccessquestcondition)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IBaseAccessQuestCondition,
				Value = _ibaseaccessquestcondition
			};
		}

		// Token: 0x0601EEF7 RID: 126711 RVA: 0x00452564 File Offset: 0x00450764
		public IExploreLevelCondtionT AsIExploreLevelCondtion()
		{
			return this.As<IExploreLevelCondtionT>();
		}

		// Token: 0x0601EEF8 RID: 126712 RVA: 0x0045256C File Offset: 0x0045076C
		public static IBaseAccessQuestCondition_UnionUnion FromIExploreLevelCondtion(IExploreLevelCondtionT _iexplorelevelcondtion)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IExploreLevelCondtion,
				Value = _iexplorelevelcondtion
			};
		}

		// Token: 0x0601EEF9 RID: 126713 RVA: 0x00452581 File Offset: 0x00450781
		public IPreQuestCondtionT AsIPreQuestCondtion()
		{
			return this.As<IPreQuestCondtionT>();
		}

		// Token: 0x0601EEFA RID: 126714 RVA: 0x00452589 File Offset: 0x00450789
		public static IBaseAccessQuestCondition_UnionUnion FromIPreQuestCondtion(IPreQuestCondtionT _iprequestcondtion)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IPreQuestCondtion,
				Value = _iprequestcondtion
			};
		}

		// Token: 0x0601EEFB RID: 126715 RVA: 0x0045259E File Offset: 0x0045079E
		public IPreChildQuestCondtionT AsIPreChildQuestCondtion()
		{
			return this.As<IPreChildQuestCondtionT>();
		}

		// Token: 0x0601EEFC RID: 126716 RVA: 0x004525A6 File Offset: 0x004507A6
		public static IBaseAccessQuestCondition_UnionUnion FromIPreChildQuestCondtion(IPreChildQuestCondtionT _iprechildquestcondtion)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IPreChildQuestCondtion,
				Value = _iprechildquestcondtion
			};
		}

		// Token: 0x0601EEFD RID: 126717 RVA: 0x004525BB File Offset: 0x004507BB
		public IItemConditionT AsIItemCondition()
		{
			return this.As<IItemConditionT>();
		}

		// Token: 0x0601EEFE RID: 126718 RVA: 0x004525C3 File Offset: 0x004507C3
		public static IBaseAccessQuestCondition_UnionUnion FromIItemCondition(IItemConditionT _iitemcondition)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IItemCondition,
				Value = _iitemcondition
			};
		}

		// Token: 0x0601EEFF RID: 126719 RVA: 0x004525D8 File Offset: 0x004507D8
		public IPreLevelPlayCondtionT AsIPreLevelPlayCondtion()
		{
			return this.As<IPreLevelPlayCondtionT>();
		}

		// Token: 0x0601EF00 RID: 126720 RVA: 0x004525E0 File Offset: 0x004507E0
		public static IBaseAccessQuestCondition_UnionUnion FromIPreLevelPlayCondtion(IPreLevelPlayCondtionT _iprelevelplaycondtion)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IPreLevelPlayCondtion,
				Value = _iprelevelplaycondtion
			};
		}

		// Token: 0x0601EF01 RID: 126721 RVA: 0x004525F5 File Offset: 0x004507F5
		public IPreGenderCondtionT AsIPreGenderCondtion()
		{
			return this.As<IPreGenderCondtionT>();
		}

		// Token: 0x0601EF02 RID: 126722 RVA: 0x004525FD File Offset: 0x004507FD
		public static IBaseAccessQuestCondition_UnionUnion FromIPreGenderCondtion(IPreGenderCondtionT _ipregendercondtion)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IPreGenderCondtion,
				Value = _ipregendercondtion
			};
		}

		// Token: 0x0601EF03 RID: 126723 RVA: 0x00452612 File Offset: 0x00450812
		public IReachAreaCondtionT AsIReachAreaCondtion()
		{
			return this.As<IReachAreaCondtionT>();
		}

		// Token: 0x0601EF04 RID: 126724 RVA: 0x0045261A File Offset: 0x0045081A
		public static IBaseAccessQuestCondition_UnionUnion FromIReachAreaCondtion(IReachAreaCondtionT _ireachareacondtion)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IReachAreaCondtion,
				Value = _ireachareacondtion
			};
		}

		// Token: 0x0601EF05 RID: 126725 RVA: 0x0045262F File Offset: 0x0045082F
		public IOpenDateConditonT AsIOpenDateConditon()
		{
			return this.As<IOpenDateConditonT>();
		}

		// Token: 0x0601EF06 RID: 126726 RVA: 0x00452637 File Offset: 0x00450837
		public static IBaseAccessQuestCondition_UnionUnion FromIOpenDateConditon(IOpenDateConditonT _iopendateconditon)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IOpenDateConditon,
				Value = _iopendateconditon
			};
		}

		// Token: 0x0601EF07 RID: 126727 RVA: 0x0045264D File Offset: 0x0045084D
		public ISystemStateConditonT AsISystemStateConditon()
		{
			return this.As<ISystemStateConditonT>();
		}

		// Token: 0x0601EF08 RID: 126728 RVA: 0x00452655 File Offset: 0x00450855
		public static IBaseAccessQuestCondition_UnionUnion FromISystemStateConditon(ISystemStateConditonT _isystemstateconditon)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.ISystemStateConditon,
				Value = _isystemstateconditon
			};
		}

		// Token: 0x0601EF09 RID: 126729 RVA: 0x0045266B File Offset: 0x0045086B
		public IDungeonQuestPreConditionT AsIDungeonQuestPreCondition()
		{
			return this.As<IDungeonQuestPreConditionT>();
		}

		// Token: 0x0601EF0A RID: 126730 RVA: 0x00452673 File Offset: 0x00450873
		public static IBaseAccessQuestCondition_UnionUnion FromIDungeonQuestPreCondition(IDungeonQuestPreConditionT _idungeonquestprecondition)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IDungeonQuestPreCondition,
				Value = _idungeonquestprecondition
			};
		}

		// Token: 0x0601EF0B RID: 126731 RVA: 0x00452689 File Offset: 0x00450889
		public IFeatureCollectionLevelPreConditionT AsIFeatureCollectionLevelPreCondition()
		{
			return this.As<IFeatureCollectionLevelPreConditionT>();
		}

		// Token: 0x0601EF0C RID: 126732 RVA: 0x00452691 File Offset: 0x00450891
		public static IBaseAccessQuestCondition_UnionUnion FromIFeatureCollectionLevelPreCondition(IFeatureCollectionLevelPreConditionT _ifeaturecollectionlevelprecondition)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IFeatureCollectionLevelPreCondition,
				Value = _ifeaturecollectionlevelprecondition
			};
		}

		// Token: 0x0601EF0D RID: 126733 RVA: 0x004526A7 File Offset: 0x004508A7
		public IMapThemedActivityReachRankT AsIMapThemedActivityReachRank()
		{
			return this.As<IMapThemedActivityReachRankT>();
		}

		// Token: 0x0601EF0E RID: 126734 RVA: 0x004526AF File Offset: 0x004508AF
		public static IBaseAccessQuestCondition_UnionUnion FromIMapThemedActivityReachRank(IMapThemedActivityReachRankT _imapthemedactivityreachrank)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IMapThemedActivityReachRank,
				Value = _imapthemedactivityreachrank
			};
		}

		// Token: 0x0601EF0F RID: 126735 RVA: 0x004526C8 File Offset: 0x004508C8
		public static int Pack(FlatBufferBuilder builder, IBaseAccessQuestCondition_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IBaseAccessQuestCondition_Union.IBaseAccessQuestCondition:
				return IBaseAccessQuestCondition.Pack(builder, _o.AsIBaseAccessQuestCondition()).Value;
			case IBaseAccessQuestCondition_Union.IExploreLevelCondtion:
				return IExploreLevelCondtion.Pack(builder, _o.AsIExploreLevelCondtion()).Value;
			case IBaseAccessQuestCondition_Union.IPreQuestCondtion:
				return IPreQuestCondtion.Pack(builder, _o.AsIPreQuestCondtion()).Value;
			case IBaseAccessQuestCondition_Union.IPreChildQuestCondtion:
				return IPreChildQuestCondtion.Pack(builder, _o.AsIPreChildQuestCondtion()).Value;
			case IBaseAccessQuestCondition_Union.IItemCondition:
				return IItemCondition.Pack(builder, _o.AsIItemCondition()).Value;
			case IBaseAccessQuestCondition_Union.IPreLevelPlayCondtion:
				return IPreLevelPlayCondtion.Pack(builder, _o.AsIPreLevelPlayCondtion()).Value;
			case IBaseAccessQuestCondition_Union.IPreGenderCondtion:
				return IPreGenderCondtion.Pack(builder, _o.AsIPreGenderCondtion()).Value;
			case IBaseAccessQuestCondition_Union.IReachAreaCondtion:
				return IReachAreaCondtion.Pack(builder, _o.AsIReachAreaCondtion()).Value;
			case IBaseAccessQuestCondition_Union.IOpenDateConditon:
				return IOpenDateConditon.Pack(builder, _o.AsIOpenDateConditon()).Value;
			case IBaseAccessQuestCondition_Union.ISystemStateConditon:
				return ISystemStateConditon.Pack(builder, _o.AsISystemStateConditon()).Value;
			case IBaseAccessQuestCondition_Union.IDungeonQuestPreCondition:
				return IDungeonQuestPreCondition.Pack(builder, _o.AsIDungeonQuestPreCondition()).Value;
			case IBaseAccessQuestCondition_Union.IFeatureCollectionLevelPreCondition:
				return IFeatureCollectionLevelPreCondition.Pack(builder, _o.AsIFeatureCollectionLevelPreCondition()).Value;
			case IBaseAccessQuestCondition_Union.IMapThemedActivityReachRank:
				return IMapThemedActivityReachRank.Pack(builder, _o.AsIMapThemedActivityReachRank()).Value;
			default:
				return 0;
			}
		}
	}
}
