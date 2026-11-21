using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004572 RID: 17778
	public class IShowUi_UnionUnion
	{
		// Token: 0x17007C42 RID: 31810
		// (get) Token: 0x06019E29 RID: 106025 RVA: 0x003B1480 File Offset: 0x003AF680
		// (set) Token: 0x06019E2A RID: 106026 RVA: 0x003B1488 File Offset: 0x003AF688
		public IShowUi_Union Type { get; set; }

		// Token: 0x17007C43 RID: 31811
		// (get) Token: 0x06019E2B RID: 106027 RVA: 0x003B1491 File Offset: 0x003AF691
		// (set) Token: 0x06019E2C RID: 106028 RVA: 0x003B1499 File Offset: 0x003AF699
		public object Value { get; set; }

		// Token: 0x06019E2D RID: 106029 RVA: 0x003B14A2 File Offset: 0x003AF6A2
		public IShowUi_UnionUnion()
		{
			this.Type = IShowUi_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06019E2E RID: 106030 RVA: 0x003B14B8 File Offset: 0x003AF6B8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019E2F RID: 106031 RVA: 0x003B14CA File Offset: 0x003AF6CA
		public IShowUiT AsIShowUi()
		{
			return this.As<IShowUiT>();
		}

		// Token: 0x06019E30 RID: 106032 RVA: 0x003B14D2 File Offset: 0x003AF6D2
		public static IShowUi_UnionUnion FromIShowUi(IShowUiT _ishowui)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IShowUi,
				Value = _ishowui
			};
		}

		// Token: 0x06019E31 RID: 106033 RVA: 0x003B14E7 File Offset: 0x003AF6E7
		public IShowUiAllT AsIShowUiAll()
		{
			return this.As<IShowUiAllT>();
		}

		// Token: 0x06019E32 RID: 106034 RVA: 0x003B14EF File Offset: 0x003AF6EF
		public static IShowUi_UnionUnion FromIShowUiAll(IShowUiAllT _ishowuiall)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IShowUiAll,
				Value = _ishowuiall
			};
		}

		// Token: 0x06019E33 RID: 106035 RVA: 0x003B1504 File Offset: 0x003AF704
		public IRogueAbilitySelectT AsIRogueAbilitySelect()
		{
			return this.As<IRogueAbilitySelectT>();
		}

		// Token: 0x06019E34 RID: 106036 RVA: 0x003B150C File Offset: 0x003AF70C
		public static IShowUi_UnionUnion FromIRogueAbilitySelect(IRogueAbilitySelectT _irogueabilityselect)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IRogueAbilitySelect,
				Value = _irogueabilityselect
			};
		}

		// Token: 0x06019E35 RID: 106037 RVA: 0x003B1521 File Offset: 0x003AF721
		public IInformationViewT AsIInformationView()
		{
			return this.As<IInformationViewT>();
		}

		// Token: 0x06019E36 RID: 106038 RVA: 0x003B1529 File Offset: 0x003AF729
		public static IShowUi_UnionUnion FromIInformationView(IInformationViewT _iinformationview)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IInformationView,
				Value = _iinformationview
			};
		}

		// Token: 0x06019E37 RID: 106039 RVA: 0x003B153E File Offset: 0x003AF73E
		public IRogueRandomEventT AsIRogueRandomEvent()
		{
			return this.As<IRogueRandomEventT>();
		}

		// Token: 0x06019E38 RID: 106040 RVA: 0x003B1546 File Offset: 0x003AF746
		public static IShowUi_UnionUnion FromIRogueRandomEvent(IRogueRandomEventT _iroguerandomevent)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IRogueRandomEvent,
				Value = _iroguerandomevent
			};
		}

		// Token: 0x06019E39 RID: 106041 RVA: 0x003B155B File Offset: 0x003AF75B
		public IRoleTrialActivitiesT AsIRoleTrialActivities()
		{
			return this.As<IRoleTrialActivitiesT>();
		}

		// Token: 0x06019E3A RID: 106042 RVA: 0x003B1563 File Offset: 0x003AF763
		public static IShowUi_UnionUnion FromIRoleTrialActivities(IRoleTrialActivitiesT _iroletrialactivities)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IRoleTrialActivities,
				Value = _iroletrialactivities
			};
		}

		// Token: 0x06019E3B RID: 106043 RVA: 0x003B1578 File Offset: 0x003AF778
		public IRoleSkinTrialActivitiesT AsIRoleSkinTrialActivities()
		{
			return this.As<IRoleSkinTrialActivitiesT>();
		}

		// Token: 0x06019E3C RID: 106044 RVA: 0x003B1580 File Offset: 0x003AF780
		public static IShowUi_UnionUnion FromIRoleSkinTrialActivities(IRoleSkinTrialActivitiesT _iroleskintrialactivities)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IRoleSkinTrialActivities,
				Value = _iroleskintrialactivities
			};
		}

		// Token: 0x06019E3D RID: 106045 RVA: 0x003B1595 File Offset: 0x003AF795
		public IMowBuffDistributeT AsIMowBuffDistribute()
		{
			return this.As<IMowBuffDistributeT>();
		}

		// Token: 0x06019E3E RID: 106046 RVA: 0x003B159D File Offset: 0x003AF79D
		public static IShowUi_UnionUnion FromIMowBuffDistribute(IMowBuffDistributeT _imowbuffdistribute)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IMowBuffDistribute,
				Value = _imowbuffdistribute
			};
		}

		// Token: 0x06019E3F RID: 106047 RVA: 0x003B15B2 File Offset: 0x003AF7B2
		public IPermanentRogueUiT AsIPermanentRogueUi()
		{
			return this.As<IPermanentRogueUiT>();
		}

		// Token: 0x06019E40 RID: 106048 RVA: 0x003B15BA File Offset: 0x003AF7BA
		public static IShowUi_UnionUnion FromIPermanentRogueUi(IPermanentRogueUiT _ipermanentrogueui)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IPermanentRogueUi,
				Value = _ipermanentrogueui
			};
		}

		// Token: 0x06019E41 RID: 106049 RVA: 0x003B15D0 File Offset: 0x003AF7D0
		public ICiacconaAvgBoardT AsICiacconaAvgBoard()
		{
			return this.As<ICiacconaAvgBoardT>();
		}

		// Token: 0x06019E42 RID: 106050 RVA: 0x003B15D8 File Offset: 0x003AF7D8
		public static IShowUi_UnionUnion FromICiacconaAvgBoard(ICiacconaAvgBoardT _iciacconaavgboard)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.ICiacconaAvgBoard,
				Value = _iciacconaavgboard
			};
		}

		// Token: 0x06019E43 RID: 106051 RVA: 0x003B15EE File Offset: 0x003AF7EE
		public IItemObtainT AsIItemObtain()
		{
			return this.As<IItemObtainT>();
		}

		// Token: 0x06019E44 RID: 106052 RVA: 0x003B15F6 File Offset: 0x003AF7F6
		public static IShowUi_UnionUnion FromIItemObtain(IItemObtainT _iitemobtain)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IItemObtain,
				Value = _iitemobtain
			};
		}

		// Token: 0x06019E45 RID: 106053 RVA: 0x003B160C File Offset: 0x003AF80C
		public IShowUiCraftingT AsIShowUiCrafting()
		{
			return this.As<IShowUiCraftingT>();
		}

		// Token: 0x06019E46 RID: 106054 RVA: 0x003B1614 File Offset: 0x003AF814
		public static IShowUi_UnionUnion FromIShowUiCrafting(IShowUiCraftingT _ishowuicrafting)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IShowUiCrafting,
				Value = _ishowuicrafting
			};
		}

		// Token: 0x06019E47 RID: 106055 RVA: 0x003B162A File Offset: 0x003AF82A
		public IShowUiCookT AsIShowUiCook()
		{
			return this.As<IShowUiCookT>();
		}

		// Token: 0x06019E48 RID: 106056 RVA: 0x003B1632 File Offset: 0x003AF832
		public static IShowUi_UnionUnion FromIShowUiCook(IShowUiCookT _ishowuicook)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IShowUiCook,
				Value = _ishowuicook
			};
		}

		// Token: 0x06019E49 RID: 106057 RVA: 0x003B1648 File Offset: 0x003AF848
		public IShowUiSyntheticT AsIShowUiSynthetic()
		{
			return this.As<IShowUiSyntheticT>();
		}

		// Token: 0x06019E4A RID: 106058 RVA: 0x003B1650 File Offset: 0x003AF850
		public static IShowUi_UnionUnion FromIShowUiSynthetic(IShowUiSyntheticT _ishowuisynthetic)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IShowUiSynthetic,
				Value = _ishowuisynthetic
			};
		}

		// Token: 0x06019E4B RID: 106059 RVA: 0x003B1666 File Offset: 0x003AF866
		public IShowUiForgingT AsIShowUiForging()
		{
			return this.As<IShowUiForgingT>();
		}

		// Token: 0x06019E4C RID: 106060 RVA: 0x003B166E File Offset: 0x003AF86E
		public static IShowUi_UnionUnion FromIShowUiForging(IShowUiForgingT _ishowuiforging)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IShowUiForging,
				Value = _ishowuiforging
			};
		}

		// Token: 0x06019E4D RID: 106061 RVA: 0x003B1684 File Offset: 0x003AF884
		public static int Pack(FlatBufferBuilder builder, IShowUi_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IShowUi_Union.IShowUi:
				return IShowUi.Pack(builder, _o.AsIShowUi()).Value;
			case IShowUi_Union.IShowUiAll:
				return IShowUiAll.Pack(builder, _o.AsIShowUiAll()).Value;
			case IShowUi_Union.IRogueAbilitySelect:
				return IRogueAbilitySelect.Pack(builder, _o.AsIRogueAbilitySelect()).Value;
			case IShowUi_Union.IInformationView:
				return IInformationView.Pack(builder, _o.AsIInformationView()).Value;
			case IShowUi_Union.IRogueRandomEvent:
				return IRogueRandomEvent.Pack(builder, _o.AsIRogueRandomEvent()).Value;
			case IShowUi_Union.IRoleTrialActivities:
				return IRoleTrialActivities.Pack(builder, _o.AsIRoleTrialActivities()).Value;
			case IShowUi_Union.IRoleSkinTrialActivities:
				return IRoleSkinTrialActivities.Pack(builder, _o.AsIRoleSkinTrialActivities()).Value;
			case IShowUi_Union.IMowBuffDistribute:
				return IMowBuffDistribute.Pack(builder, _o.AsIMowBuffDistribute()).Value;
			case IShowUi_Union.IPermanentRogueUi:
				return IPermanentRogueUi.Pack(builder, _o.AsIPermanentRogueUi()).Value;
			case IShowUi_Union.ICiacconaAvgBoard:
				return ICiacconaAvgBoard.Pack(builder, _o.AsICiacconaAvgBoard()).Value;
			case IShowUi_Union.IItemObtain:
				return IItemObtain.Pack(builder, _o.AsIItemObtain()).Value;
			case IShowUi_Union.IShowUiCrafting:
				return IShowUiCrafting.Pack(builder, _o.AsIShowUiCrafting()).Value;
			case IShowUi_Union.IShowUiCook:
				return IShowUiCook.Pack(builder, _o.AsIShowUiCook()).Value;
			case IShowUi_Union.IShowUiSynthetic:
				return IShowUiSynthetic.Pack(builder, _o.AsIShowUiSynthetic()).Value;
			case IShowUi_Union.IShowUiForging:
				return IShowUiForging.Pack(builder, _o.AsIShowUiForging()).Value;
			default:
				return 0;
			}
		}
	}
}
