using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D28 RID: 19752
	public class TAccessQuestConditionUnion
	{
		// Token: 0x17008F35 RID: 36661
		// (get) Token: 0x0601F59E RID: 128414 RVA: 0x0045EEE0 File Offset: 0x0045D0E0
		// (set) Token: 0x0601F59F RID: 128415 RVA: 0x0045EEE8 File Offset: 0x0045D0E8
		public TAccessQuestCondition Type { get; set; }

		// Token: 0x17008F36 RID: 36662
		// (get) Token: 0x0601F5A0 RID: 128416 RVA: 0x0045EEF1 File Offset: 0x0045D0F1
		// (set) Token: 0x0601F5A1 RID: 128417 RVA: 0x0045EEF9 File Offset: 0x0045D0F9
		public object Value { get; set; }

		// Token: 0x0601F5A2 RID: 128418 RVA: 0x0045EF02 File Offset: 0x0045D102
		public TAccessQuestConditionUnion()
		{
			this.Type = TAccessQuestCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0601F5A3 RID: 128419 RVA: 0x0045EF18 File Offset: 0x0045D118
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F5A4 RID: 128420 RVA: 0x0045EF2A File Offset: 0x0045D12A
		public IDungeonQuestPreConditionT AsIDungeonQuestPreCondition()
		{
			return this.As<IDungeonQuestPreConditionT>();
		}

		// Token: 0x0601F5A5 RID: 128421 RVA: 0x0045EF32 File Offset: 0x0045D132
		public static TAccessQuestConditionUnion FromIDungeonQuestPreCondition(IDungeonQuestPreConditionT _idungeonquestprecondition)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IDungeonQuestPreCondition,
				Value = _idungeonquestprecondition
			};
		}

		// Token: 0x0601F5A6 RID: 128422 RVA: 0x0045EF47 File Offset: 0x0045D147
		public IExploreLevelCondtionT AsIExploreLevelCondtion()
		{
			return this.As<IExploreLevelCondtionT>();
		}

		// Token: 0x0601F5A7 RID: 128423 RVA: 0x0045EF4F File Offset: 0x0045D14F
		public static TAccessQuestConditionUnion FromIExploreLevelCondtion(IExploreLevelCondtionT _iexplorelevelcondtion)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IExploreLevelCondtion,
				Value = _iexplorelevelcondtion
			};
		}

		// Token: 0x0601F5A8 RID: 128424 RVA: 0x0045EF64 File Offset: 0x0045D164
		public IFeatureCollectionLevelPreConditionT AsIFeatureCollectionLevelPreCondition()
		{
			return this.As<IFeatureCollectionLevelPreConditionT>();
		}

		// Token: 0x0601F5A9 RID: 128425 RVA: 0x0045EF6C File Offset: 0x0045D16C
		public static TAccessQuestConditionUnion FromIFeatureCollectionLevelPreCondition(IFeatureCollectionLevelPreConditionT _ifeaturecollectionlevelprecondition)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IFeatureCollectionLevelPreCondition,
				Value = _ifeaturecollectionlevelprecondition
			};
		}

		// Token: 0x0601F5AA RID: 128426 RVA: 0x0045EF81 File Offset: 0x0045D181
		public IItemConditionT AsIItemCondition()
		{
			return this.As<IItemConditionT>();
		}

		// Token: 0x0601F5AB RID: 128427 RVA: 0x0045EF89 File Offset: 0x0045D189
		public static TAccessQuestConditionUnion FromIItemCondition(IItemConditionT _iitemcondition)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IItemCondition,
				Value = _iitemcondition
			};
		}

		// Token: 0x0601F5AC RID: 128428 RVA: 0x0045EF9E File Offset: 0x0045D19E
		public IPreChildQuestCondtionT AsIPreChildQuestCondtion()
		{
			return this.As<IPreChildQuestCondtionT>();
		}

		// Token: 0x0601F5AD RID: 128429 RVA: 0x0045EFA6 File Offset: 0x0045D1A6
		public static TAccessQuestConditionUnion FromIPreChildQuestCondtion(IPreChildQuestCondtionT _iprechildquestcondtion)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IPreChildQuestCondtion,
				Value = _iprechildquestcondtion
			};
		}

		// Token: 0x0601F5AE RID: 128430 RVA: 0x0045EFBB File Offset: 0x0045D1BB
		public IPreGenderCondtionT AsIPreGenderCondtion()
		{
			return this.As<IPreGenderCondtionT>();
		}

		// Token: 0x0601F5AF RID: 128431 RVA: 0x0045EFC3 File Offset: 0x0045D1C3
		public static TAccessQuestConditionUnion FromIPreGenderCondtion(IPreGenderCondtionT _ipregendercondtion)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IPreGenderCondtion,
				Value = _ipregendercondtion
			};
		}

		// Token: 0x0601F5B0 RID: 128432 RVA: 0x0045EFD8 File Offset: 0x0045D1D8
		public IPreLevelPlayCondtionT AsIPreLevelPlayCondtion()
		{
			return this.As<IPreLevelPlayCondtionT>();
		}

		// Token: 0x0601F5B1 RID: 128433 RVA: 0x0045EFE0 File Offset: 0x0045D1E0
		public static TAccessQuestConditionUnion FromIPreLevelPlayCondtion(IPreLevelPlayCondtionT _iprelevelplaycondtion)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IPreLevelPlayCondtion,
				Value = _iprelevelplaycondtion
			};
		}

		// Token: 0x0601F5B2 RID: 128434 RVA: 0x0045EFF5 File Offset: 0x0045D1F5
		public IPreQuestCondtionT AsIPreQuestCondtion()
		{
			return this.As<IPreQuestCondtionT>();
		}

		// Token: 0x0601F5B3 RID: 128435 RVA: 0x0045EFFD File Offset: 0x0045D1FD
		public static TAccessQuestConditionUnion FromIPreQuestCondtion(IPreQuestCondtionT _iprequestcondtion)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IPreQuestCondtion,
				Value = _iprequestcondtion
			};
		}

		// Token: 0x0601F5B4 RID: 128436 RVA: 0x0045F012 File Offset: 0x0045D212
		public IReachAreaCondtionT AsIReachAreaCondtion()
		{
			return this.As<IReachAreaCondtionT>();
		}

		// Token: 0x0601F5B5 RID: 128437 RVA: 0x0045F01A File Offset: 0x0045D21A
		public static TAccessQuestConditionUnion FromIReachAreaCondtion(IReachAreaCondtionT _ireachareacondtion)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IReachAreaCondtion,
				Value = _ireachareacondtion
			};
		}

		// Token: 0x0601F5B6 RID: 128438 RVA: 0x0045F030 File Offset: 0x0045D230
		public ISystemStateConditonT AsISystemStateConditon()
		{
			return this.As<ISystemStateConditonT>();
		}

		// Token: 0x0601F5B7 RID: 128439 RVA: 0x0045F038 File Offset: 0x0045D238
		public static TAccessQuestConditionUnion FromISystemStateConditon(ISystemStateConditonT _isystemstateconditon)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.ISystemStateConditon,
				Value = _isystemstateconditon
			};
		}

		// Token: 0x0601F5B8 RID: 128440 RVA: 0x0045F04E File Offset: 0x0045D24E
		public IOpenDateConditonT AsIOpenDateConditon()
		{
			return this.As<IOpenDateConditonT>();
		}

		// Token: 0x0601F5B9 RID: 128441 RVA: 0x0045F056 File Offset: 0x0045D256
		public static TAccessQuestConditionUnion FromIOpenDateConditon(IOpenDateConditonT _iopendateconditon)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IOpenDateConditon,
				Value = _iopendateconditon
			};
		}

		// Token: 0x0601F5BA RID: 128442 RVA: 0x0045F06C File Offset: 0x0045D26C
		public IMapThemedActivityReachRankT AsIMapThemedActivityReachRank()
		{
			return this.As<IMapThemedActivityReachRankT>();
		}

		// Token: 0x0601F5BB RID: 128443 RVA: 0x0045F074 File Offset: 0x0045D274
		public static TAccessQuestConditionUnion FromIMapThemedActivityReachRank(IMapThemedActivityReachRankT _imapthemedactivityreachrank)
		{
			return new TAccessQuestConditionUnion
			{
				Type = TAccessQuestCondition.IMapThemedActivityReachRank,
				Value = _imapthemedactivityreachrank
			};
		}

		// Token: 0x0601F5BC RID: 128444 RVA: 0x0045F08C File Offset: 0x0045D28C
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
