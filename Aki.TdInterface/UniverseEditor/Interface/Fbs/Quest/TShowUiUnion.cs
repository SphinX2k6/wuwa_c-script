using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004774 RID: 18292
	public class TShowUiUnion
	{
		// Token: 0x17007FA3 RID: 32675
		// (get) Token: 0x0601AEEF RID: 110319 RVA: 0x003D1C06 File Offset: 0x003CFE06
		// (set) Token: 0x0601AEF0 RID: 110320 RVA: 0x003D1C0E File Offset: 0x003CFE0E
		public TShowUi Type { get; set; }

		// Token: 0x17007FA4 RID: 32676
		// (get) Token: 0x0601AEF1 RID: 110321 RVA: 0x003D1C17 File Offset: 0x003CFE17
		// (set) Token: 0x0601AEF2 RID: 110322 RVA: 0x003D1C1F File Offset: 0x003CFE1F
		public object Value { get; set; }

		// Token: 0x0601AEF3 RID: 110323 RVA: 0x003D1C28 File Offset: 0x003CFE28
		public TShowUiUnion()
		{
			this.Type = TShowUi.NONE;
			this.Value = null;
		}

		// Token: 0x0601AEF4 RID: 110324 RVA: 0x003D1C3E File Offset: 0x003CFE3E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AEF5 RID: 110325 RVA: 0x003D1C50 File Offset: 0x003CFE50
		public ICiacconaAvgBoardT AsICiacconaAvgBoard()
		{
			return this.As<ICiacconaAvgBoardT>();
		}

		// Token: 0x0601AEF6 RID: 110326 RVA: 0x003D1C58 File Offset: 0x003CFE58
		public static TShowUiUnion FromICiacconaAvgBoard(ICiacconaAvgBoardT _iciacconaavgboard)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.ICiacconaAvgBoard,
				Value = _iciacconaavgboard
			};
		}

		// Token: 0x0601AEF7 RID: 110327 RVA: 0x003D1C6D File Offset: 0x003CFE6D
		public IInformationViewT AsIInformationView()
		{
			return this.As<IInformationViewT>();
		}

		// Token: 0x0601AEF8 RID: 110328 RVA: 0x003D1C75 File Offset: 0x003CFE75
		public static TShowUiUnion FromIInformationView(IInformationViewT _iinformationview)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IInformationView,
				Value = _iinformationview
			};
		}

		// Token: 0x0601AEF9 RID: 110329 RVA: 0x003D1C8A File Offset: 0x003CFE8A
		public IItemObtainT AsIItemObtain()
		{
			return this.As<IItemObtainT>();
		}

		// Token: 0x0601AEFA RID: 110330 RVA: 0x003D1C92 File Offset: 0x003CFE92
		public static TShowUiUnion FromIItemObtain(IItemObtainT _iitemobtain)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IItemObtain,
				Value = _iitemobtain
			};
		}

		// Token: 0x0601AEFB RID: 110331 RVA: 0x003D1CA7 File Offset: 0x003CFEA7
		public IMowBuffDistributeT AsIMowBuffDistribute()
		{
			return this.As<IMowBuffDistributeT>();
		}

		// Token: 0x0601AEFC RID: 110332 RVA: 0x003D1CAF File Offset: 0x003CFEAF
		public static TShowUiUnion FromIMowBuffDistribute(IMowBuffDistributeT _imowbuffdistribute)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IMowBuffDistribute,
				Value = _imowbuffdistribute
			};
		}

		// Token: 0x0601AEFD RID: 110333 RVA: 0x003D1CC4 File Offset: 0x003CFEC4
		public IPermanentRogueUiT AsIPermanentRogueUi()
		{
			return this.As<IPermanentRogueUiT>();
		}

		// Token: 0x0601AEFE RID: 110334 RVA: 0x003D1CCC File Offset: 0x003CFECC
		public static TShowUiUnion FromIPermanentRogueUi(IPermanentRogueUiT _ipermanentrogueui)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IPermanentRogueUi,
				Value = _ipermanentrogueui
			};
		}

		// Token: 0x0601AEFF RID: 110335 RVA: 0x003D1CE1 File Offset: 0x003CFEE1
		public IRogueAbilitySelectT AsIRogueAbilitySelect()
		{
			return this.As<IRogueAbilitySelectT>();
		}

		// Token: 0x0601AF00 RID: 110336 RVA: 0x003D1CE9 File Offset: 0x003CFEE9
		public static TShowUiUnion FromIRogueAbilitySelect(IRogueAbilitySelectT _irogueabilityselect)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IRogueAbilitySelect,
				Value = _irogueabilityselect
			};
		}

		// Token: 0x0601AF01 RID: 110337 RVA: 0x003D1CFE File Offset: 0x003CFEFE
		public IRogueRandomEventT AsIRogueRandomEvent()
		{
			return this.As<IRogueRandomEventT>();
		}

		// Token: 0x0601AF02 RID: 110338 RVA: 0x003D1D06 File Offset: 0x003CFF06
		public static TShowUiUnion FromIRogueRandomEvent(IRogueRandomEventT _iroguerandomevent)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IRogueRandomEvent,
				Value = _iroguerandomevent
			};
		}

		// Token: 0x0601AF03 RID: 110339 RVA: 0x003D1D1B File Offset: 0x003CFF1B
		public IRoleSkinTrialActivitiesT AsIRoleSkinTrialActivities()
		{
			return this.As<IRoleSkinTrialActivitiesT>();
		}

		// Token: 0x0601AF04 RID: 110340 RVA: 0x003D1D23 File Offset: 0x003CFF23
		public static TShowUiUnion FromIRoleSkinTrialActivities(IRoleSkinTrialActivitiesT _iroleskintrialactivities)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IRoleSkinTrialActivities,
				Value = _iroleskintrialactivities
			};
		}

		// Token: 0x0601AF05 RID: 110341 RVA: 0x003D1D38 File Offset: 0x003CFF38
		public IRoleTrialActivitiesT AsIRoleTrialActivities()
		{
			return this.As<IRoleTrialActivitiesT>();
		}

		// Token: 0x0601AF06 RID: 110342 RVA: 0x003D1D40 File Offset: 0x003CFF40
		public static TShowUiUnion FromIRoleTrialActivities(IRoleTrialActivitiesT _iroletrialactivities)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IRoleTrialActivities,
				Value = _iroletrialactivities
			};
		}

		// Token: 0x0601AF07 RID: 110343 RVA: 0x003D1D56 File Offset: 0x003CFF56
		public IShowUiAllT AsIShowUiAll()
		{
			return this.As<IShowUiAllT>();
		}

		// Token: 0x0601AF08 RID: 110344 RVA: 0x003D1D5E File Offset: 0x003CFF5E
		public static TShowUiUnion FromIShowUiAll(IShowUiAllT _ishowuiall)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IShowUiAll,
				Value = _ishowuiall
			};
		}

		// Token: 0x0601AF09 RID: 110345 RVA: 0x003D1D74 File Offset: 0x003CFF74
		public IShowUiCookT AsIShowUiCook()
		{
			return this.As<IShowUiCookT>();
		}

		// Token: 0x0601AF0A RID: 110346 RVA: 0x003D1D7C File Offset: 0x003CFF7C
		public static TShowUiUnion FromIShowUiCook(IShowUiCookT _ishowuicook)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IShowUiCook,
				Value = _ishowuicook
			};
		}

		// Token: 0x0601AF0B RID: 110347 RVA: 0x003D1D92 File Offset: 0x003CFF92
		public IShowUiForgingT AsIShowUiForging()
		{
			return this.As<IShowUiForgingT>();
		}

		// Token: 0x0601AF0C RID: 110348 RVA: 0x003D1D9A File Offset: 0x003CFF9A
		public static TShowUiUnion FromIShowUiForging(IShowUiForgingT _ishowuiforging)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IShowUiForging,
				Value = _ishowuiforging
			};
		}

		// Token: 0x0601AF0D RID: 110349 RVA: 0x003D1DB0 File Offset: 0x003CFFB0
		public IShowUiSyntheticT AsIShowUiSynthetic()
		{
			return this.As<IShowUiSyntheticT>();
		}

		// Token: 0x0601AF0E RID: 110350 RVA: 0x003D1DB8 File Offset: 0x003CFFB8
		public static TShowUiUnion FromIShowUiSynthetic(IShowUiSyntheticT _ishowuisynthetic)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IShowUiSynthetic,
				Value = _ishowuisynthetic
			};
		}

		// Token: 0x0601AF0F RID: 110351 RVA: 0x003D1DD0 File Offset: 0x003CFFD0
		public static int Pack(FlatBufferBuilder builder, TShowUiUnion _o)
		{
			switch (_o.Type)
			{
			case TShowUi.ICiacconaAvgBoard:
				return ICiacconaAvgBoard.Pack(builder, _o.AsICiacconaAvgBoard()).Value;
			case TShowUi.IInformationView:
				return IInformationView.Pack(builder, _o.AsIInformationView()).Value;
			case TShowUi.IItemObtain:
				return IItemObtain.Pack(builder, _o.AsIItemObtain()).Value;
			case TShowUi.IMowBuffDistribute:
				return IMowBuffDistribute.Pack(builder, _o.AsIMowBuffDistribute()).Value;
			case TShowUi.IPermanentRogueUi:
				return IPermanentRogueUi.Pack(builder, _o.AsIPermanentRogueUi()).Value;
			case TShowUi.IRogueAbilitySelect:
				return IRogueAbilitySelect.Pack(builder, _o.AsIRogueAbilitySelect()).Value;
			case TShowUi.IRogueRandomEvent:
				return IRogueRandomEvent.Pack(builder, _o.AsIRogueRandomEvent()).Value;
			case TShowUi.IRoleSkinTrialActivities:
				return IRoleSkinTrialActivities.Pack(builder, _o.AsIRoleSkinTrialActivities()).Value;
			case TShowUi.IRoleTrialActivities:
				return IRoleTrialActivities.Pack(builder, _o.AsIRoleTrialActivities()).Value;
			case TShowUi.IShowUiAll:
				return IShowUiAll.Pack(builder, _o.AsIShowUiAll()).Value;
			case TShowUi.IShowUiCook:
				return IShowUiCook.Pack(builder, _o.AsIShowUiCook()).Value;
			case TShowUi.IShowUiForging:
				return IShowUiForging.Pack(builder, _o.AsIShowUiForging()).Value;
			case TShowUi.IShowUiSynthetic:
				return IShowUiSynthetic.Pack(builder, _o.AsIShowUiSynthetic()).Value;
			default:
				return 0;
			}
		}
	}
}
