using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004315 RID: 17173
	public class TShowUiUnion
	{
		// Token: 0x17007970 RID: 31088
		// (get) Token: 0x0601976D RID: 104301 RVA: 0x003A62D6 File Offset: 0x003A44D6
		// (set) Token: 0x0601976E RID: 104302 RVA: 0x003A62DE File Offset: 0x003A44DE
		public TShowUi Type { get; set; }

		// Token: 0x17007971 RID: 31089
		// (get) Token: 0x0601976F RID: 104303 RVA: 0x003A62E7 File Offset: 0x003A44E7
		// (set) Token: 0x06019770 RID: 104304 RVA: 0x003A62EF File Offset: 0x003A44EF
		public object Value { get; set; }

		// Token: 0x06019771 RID: 104305 RVA: 0x003A62F8 File Offset: 0x003A44F8
		public TShowUiUnion()
		{
			this.Type = TShowUi.NONE;
			this.Value = null;
		}

		// Token: 0x06019772 RID: 104306 RVA: 0x003A630E File Offset: 0x003A450E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019773 RID: 104307 RVA: 0x003A6320 File Offset: 0x003A4520
		public ICiacconaAvgBoardT AsICiacconaAvgBoard()
		{
			return this.As<ICiacconaAvgBoardT>();
		}

		// Token: 0x06019774 RID: 104308 RVA: 0x003A6328 File Offset: 0x003A4528
		public static TShowUiUnion FromICiacconaAvgBoard(ICiacconaAvgBoardT _iciacconaavgboard)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.ICiacconaAvgBoard,
				Value = _iciacconaavgboard
			};
		}

		// Token: 0x06019775 RID: 104309 RVA: 0x003A633D File Offset: 0x003A453D
		public IInformationViewT AsIInformationView()
		{
			return this.As<IInformationViewT>();
		}

		// Token: 0x06019776 RID: 104310 RVA: 0x003A6345 File Offset: 0x003A4545
		public static TShowUiUnion FromIInformationView(IInformationViewT _iinformationview)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IInformationView,
				Value = _iinformationview
			};
		}

		// Token: 0x06019777 RID: 104311 RVA: 0x003A635A File Offset: 0x003A455A
		public IItemObtainT AsIItemObtain()
		{
			return this.As<IItemObtainT>();
		}

		// Token: 0x06019778 RID: 104312 RVA: 0x003A6362 File Offset: 0x003A4562
		public static TShowUiUnion FromIItemObtain(IItemObtainT _iitemobtain)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IItemObtain,
				Value = _iitemobtain
			};
		}

		// Token: 0x06019779 RID: 104313 RVA: 0x003A6377 File Offset: 0x003A4577
		public IMowBuffDistributeT AsIMowBuffDistribute()
		{
			return this.As<IMowBuffDistributeT>();
		}

		// Token: 0x0601977A RID: 104314 RVA: 0x003A637F File Offset: 0x003A457F
		public static TShowUiUnion FromIMowBuffDistribute(IMowBuffDistributeT _imowbuffdistribute)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IMowBuffDistribute,
				Value = _imowbuffdistribute
			};
		}

		// Token: 0x0601977B RID: 104315 RVA: 0x003A6394 File Offset: 0x003A4594
		public IPermanentRogueUiT AsIPermanentRogueUi()
		{
			return this.As<IPermanentRogueUiT>();
		}

		// Token: 0x0601977C RID: 104316 RVA: 0x003A639C File Offset: 0x003A459C
		public static TShowUiUnion FromIPermanentRogueUi(IPermanentRogueUiT _ipermanentrogueui)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IPermanentRogueUi,
				Value = _ipermanentrogueui
			};
		}

		// Token: 0x0601977D RID: 104317 RVA: 0x003A63B1 File Offset: 0x003A45B1
		public IRogueAbilitySelectT AsIRogueAbilitySelect()
		{
			return this.As<IRogueAbilitySelectT>();
		}

		// Token: 0x0601977E RID: 104318 RVA: 0x003A63B9 File Offset: 0x003A45B9
		public static TShowUiUnion FromIRogueAbilitySelect(IRogueAbilitySelectT _irogueabilityselect)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IRogueAbilitySelect,
				Value = _irogueabilityselect
			};
		}

		// Token: 0x0601977F RID: 104319 RVA: 0x003A63CE File Offset: 0x003A45CE
		public IRogueRandomEventT AsIRogueRandomEvent()
		{
			return this.As<IRogueRandomEventT>();
		}

		// Token: 0x06019780 RID: 104320 RVA: 0x003A63D6 File Offset: 0x003A45D6
		public static TShowUiUnion FromIRogueRandomEvent(IRogueRandomEventT _iroguerandomevent)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IRogueRandomEvent,
				Value = _iroguerandomevent
			};
		}

		// Token: 0x06019781 RID: 104321 RVA: 0x003A63EB File Offset: 0x003A45EB
		public IRoleSkinTrialActivitiesT AsIRoleSkinTrialActivities()
		{
			return this.As<IRoleSkinTrialActivitiesT>();
		}

		// Token: 0x06019782 RID: 104322 RVA: 0x003A63F3 File Offset: 0x003A45F3
		public static TShowUiUnion FromIRoleSkinTrialActivities(IRoleSkinTrialActivitiesT _iroleskintrialactivities)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IRoleSkinTrialActivities,
				Value = _iroleskintrialactivities
			};
		}

		// Token: 0x06019783 RID: 104323 RVA: 0x003A6408 File Offset: 0x003A4608
		public IRoleTrialActivitiesT AsIRoleTrialActivities()
		{
			return this.As<IRoleTrialActivitiesT>();
		}

		// Token: 0x06019784 RID: 104324 RVA: 0x003A6410 File Offset: 0x003A4610
		public static TShowUiUnion FromIRoleTrialActivities(IRoleTrialActivitiesT _iroletrialactivities)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IRoleTrialActivities,
				Value = _iroletrialactivities
			};
		}

		// Token: 0x06019785 RID: 104325 RVA: 0x003A6426 File Offset: 0x003A4626
		public IShowUiAllT AsIShowUiAll()
		{
			return this.As<IShowUiAllT>();
		}

		// Token: 0x06019786 RID: 104326 RVA: 0x003A642E File Offset: 0x003A462E
		public static TShowUiUnion FromIShowUiAll(IShowUiAllT _ishowuiall)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IShowUiAll,
				Value = _ishowuiall
			};
		}

		// Token: 0x06019787 RID: 104327 RVA: 0x003A6444 File Offset: 0x003A4644
		public IShowUiCookT AsIShowUiCook()
		{
			return this.As<IShowUiCookT>();
		}

		// Token: 0x06019788 RID: 104328 RVA: 0x003A644C File Offset: 0x003A464C
		public static TShowUiUnion FromIShowUiCook(IShowUiCookT _ishowuicook)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IShowUiCook,
				Value = _ishowuicook
			};
		}

		// Token: 0x06019789 RID: 104329 RVA: 0x003A6462 File Offset: 0x003A4662
		public IShowUiForgingT AsIShowUiForging()
		{
			return this.As<IShowUiForgingT>();
		}

		// Token: 0x0601978A RID: 104330 RVA: 0x003A646A File Offset: 0x003A466A
		public static TShowUiUnion FromIShowUiForging(IShowUiForgingT _ishowuiforging)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IShowUiForging,
				Value = _ishowuiforging
			};
		}

		// Token: 0x0601978B RID: 104331 RVA: 0x003A6480 File Offset: 0x003A4680
		public IShowUiSyntheticT AsIShowUiSynthetic()
		{
			return this.As<IShowUiSyntheticT>();
		}

		// Token: 0x0601978C RID: 104332 RVA: 0x003A6488 File Offset: 0x003A4688
		public static TShowUiUnion FromIShowUiSynthetic(IShowUiSyntheticT _ishowuisynthetic)
		{
			return new TShowUiUnion
			{
				Type = TShowUi.IShowUiSynthetic,
				Value = _ishowuisynthetic
			};
		}

		// Token: 0x0601978D RID: 104333 RVA: 0x003A64A0 File Offset: 0x003A46A0
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
