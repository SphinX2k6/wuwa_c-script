using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004971 RID: 18801
	public class IBaseAccessQuestCondition_UnionUnion
	{
		// Token: 0x170087CE RID: 34766
		// (get) Token: 0x0601D4CA RID: 120010 RVA: 0x00422049 File Offset: 0x00420249
		// (set) Token: 0x0601D4CB RID: 120011 RVA: 0x00422051 File Offset: 0x00420251
		public IBaseAccessQuestCondition_Union Type { get; set; }

		// Token: 0x170087CF RID: 34767
		// (get) Token: 0x0601D4CC RID: 120012 RVA: 0x0042205A File Offset: 0x0042025A
		// (set) Token: 0x0601D4CD RID: 120013 RVA: 0x00422062 File Offset: 0x00420262
		public object Value { get; set; }

		// Token: 0x0601D4CE RID: 120014 RVA: 0x0042206B File Offset: 0x0042026B
		public IBaseAccessQuestCondition_UnionUnion()
		{
			this.Type = IBaseAccessQuestCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601D4CF RID: 120015 RVA: 0x00422081 File Offset: 0x00420281
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601D4D0 RID: 120016 RVA: 0x00422093 File Offset: 0x00420293
		public IBaseAccessQuestConditionT AsIBaseAccessQuestCondition()
		{
			return this.As<IBaseAccessQuestConditionT>();
		}

		// Token: 0x0601D4D1 RID: 120017 RVA: 0x0042209B File Offset: 0x0042029B
		public static IBaseAccessQuestCondition_UnionUnion FromIBaseAccessQuestCondition(IBaseAccessQuestConditionT _ibaseaccessquestcondition)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IBaseAccessQuestCondition,
				Value = _ibaseaccessquestcondition
			};
		}

		// Token: 0x0601D4D2 RID: 120018 RVA: 0x004220B0 File Offset: 0x004202B0
		public IExploreLevelCondtionT AsIExploreLevelCondtion()
		{
			return this.As<IExploreLevelCondtionT>();
		}

		// Token: 0x0601D4D3 RID: 120019 RVA: 0x004220B8 File Offset: 0x004202B8
		public static IBaseAccessQuestCondition_UnionUnion FromIExploreLevelCondtion(IExploreLevelCondtionT _iexplorelevelcondtion)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IExploreLevelCondtion,
				Value = _iexplorelevelcondtion
			};
		}

		// Token: 0x0601D4D4 RID: 120020 RVA: 0x004220CD File Offset: 0x004202CD
		public IPreQuestCondtionT AsIPreQuestCondtion()
		{
			return this.As<IPreQuestCondtionT>();
		}

		// Token: 0x0601D4D5 RID: 120021 RVA: 0x004220D5 File Offset: 0x004202D5
		public static IBaseAccessQuestCondition_UnionUnion FromIPreQuestCondtion(IPreQuestCondtionT _iprequestcondtion)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IPreQuestCondtion,
				Value = _iprequestcondtion
			};
		}

		// Token: 0x0601D4D6 RID: 120022 RVA: 0x004220EA File Offset: 0x004202EA
		public IPreChildQuestCondtionT AsIPreChildQuestCondtion()
		{
			return this.As<IPreChildQuestCondtionT>();
		}

		// Token: 0x0601D4D7 RID: 120023 RVA: 0x004220F2 File Offset: 0x004202F2
		public static IBaseAccessQuestCondition_UnionUnion FromIPreChildQuestCondtion(IPreChildQuestCondtionT _iprechildquestcondtion)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IPreChildQuestCondtion,
				Value = _iprechildquestcondtion
			};
		}

		// Token: 0x0601D4D8 RID: 120024 RVA: 0x00422107 File Offset: 0x00420307
		public IItemConditionT AsIItemCondition()
		{
			return this.As<IItemConditionT>();
		}

		// Token: 0x0601D4D9 RID: 120025 RVA: 0x0042210F File Offset: 0x0042030F
		public static IBaseAccessQuestCondition_UnionUnion FromIItemCondition(IItemConditionT _iitemcondition)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IItemCondition,
				Value = _iitemcondition
			};
		}

		// Token: 0x0601D4DA RID: 120026 RVA: 0x00422124 File Offset: 0x00420324
		public IPreLevelPlayCondtionT AsIPreLevelPlayCondtion()
		{
			return this.As<IPreLevelPlayCondtionT>();
		}

		// Token: 0x0601D4DB RID: 120027 RVA: 0x0042212C File Offset: 0x0042032C
		public static IBaseAccessQuestCondition_UnionUnion FromIPreLevelPlayCondtion(IPreLevelPlayCondtionT _iprelevelplaycondtion)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IPreLevelPlayCondtion,
				Value = _iprelevelplaycondtion
			};
		}

		// Token: 0x0601D4DC RID: 120028 RVA: 0x00422141 File Offset: 0x00420341
		public IPreGenderCondtionT AsIPreGenderCondtion()
		{
			return this.As<IPreGenderCondtionT>();
		}

		// Token: 0x0601D4DD RID: 120029 RVA: 0x00422149 File Offset: 0x00420349
		public static IBaseAccessQuestCondition_UnionUnion FromIPreGenderCondtion(IPreGenderCondtionT _ipregendercondtion)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IPreGenderCondtion,
				Value = _ipregendercondtion
			};
		}

		// Token: 0x0601D4DE RID: 120030 RVA: 0x0042215E File Offset: 0x0042035E
		public IReachAreaCondtionT AsIReachAreaCondtion()
		{
			return this.As<IReachAreaCondtionT>();
		}

		// Token: 0x0601D4DF RID: 120031 RVA: 0x00422166 File Offset: 0x00420366
		public static IBaseAccessQuestCondition_UnionUnion FromIReachAreaCondtion(IReachAreaCondtionT _ireachareacondtion)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IReachAreaCondtion,
				Value = _ireachareacondtion
			};
		}

		// Token: 0x0601D4E0 RID: 120032 RVA: 0x0042217B File Offset: 0x0042037B
		public IOpenDateConditonT AsIOpenDateConditon()
		{
			return this.As<IOpenDateConditonT>();
		}

		// Token: 0x0601D4E1 RID: 120033 RVA: 0x00422183 File Offset: 0x00420383
		public static IBaseAccessQuestCondition_UnionUnion FromIOpenDateConditon(IOpenDateConditonT _iopendateconditon)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IOpenDateConditon,
				Value = _iopendateconditon
			};
		}

		// Token: 0x0601D4E2 RID: 120034 RVA: 0x00422199 File Offset: 0x00420399
		public ISystemStateConditonT AsISystemStateConditon()
		{
			return this.As<ISystemStateConditonT>();
		}

		// Token: 0x0601D4E3 RID: 120035 RVA: 0x004221A1 File Offset: 0x004203A1
		public static IBaseAccessQuestCondition_UnionUnion FromISystemStateConditon(ISystemStateConditonT _isystemstateconditon)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.ISystemStateConditon,
				Value = _isystemstateconditon
			};
		}

		// Token: 0x0601D4E4 RID: 120036 RVA: 0x004221B7 File Offset: 0x004203B7
		public IDungeonQuestPreConditionT AsIDungeonQuestPreCondition()
		{
			return this.As<IDungeonQuestPreConditionT>();
		}

		// Token: 0x0601D4E5 RID: 120037 RVA: 0x004221BF File Offset: 0x004203BF
		public static IBaseAccessQuestCondition_UnionUnion FromIDungeonQuestPreCondition(IDungeonQuestPreConditionT _idungeonquestprecondition)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IDungeonQuestPreCondition,
				Value = _idungeonquestprecondition
			};
		}

		// Token: 0x0601D4E6 RID: 120038 RVA: 0x004221D5 File Offset: 0x004203D5
		public IFeatureCollectionLevelPreConditionT AsIFeatureCollectionLevelPreCondition()
		{
			return this.As<IFeatureCollectionLevelPreConditionT>();
		}

		// Token: 0x0601D4E7 RID: 120039 RVA: 0x004221DD File Offset: 0x004203DD
		public static IBaseAccessQuestCondition_UnionUnion FromIFeatureCollectionLevelPreCondition(IFeatureCollectionLevelPreConditionT _ifeaturecollectionlevelprecondition)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IFeatureCollectionLevelPreCondition,
				Value = _ifeaturecollectionlevelprecondition
			};
		}

		// Token: 0x0601D4E8 RID: 120040 RVA: 0x004221F3 File Offset: 0x004203F3
		public IMapThemedActivityReachRankT AsIMapThemedActivityReachRank()
		{
			return this.As<IMapThemedActivityReachRankT>();
		}

		// Token: 0x0601D4E9 RID: 120041 RVA: 0x004221FB File Offset: 0x004203FB
		public static IBaseAccessQuestCondition_UnionUnion FromIMapThemedActivityReachRank(IMapThemedActivityReachRankT _imapthemedactivityreachrank)
		{
			return new IBaseAccessQuestCondition_UnionUnion
			{
				Type = IBaseAccessQuestCondition_Union.IMapThemedActivityReachRank,
				Value = _imapthemedactivityreachrank
			};
		}

		// Token: 0x0601D4EA RID: 120042 RVA: 0x00422214 File Offset: 0x00420414
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
