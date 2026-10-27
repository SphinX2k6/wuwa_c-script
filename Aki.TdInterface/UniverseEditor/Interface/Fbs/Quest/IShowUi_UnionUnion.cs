using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004131 RID: 16689
	public class IShowUi_UnionUnion
	{
		// Token: 0x1700763C RID: 30268
		// (get) Token: 0x06018786 RID: 100230 RVA: 0x00387478 File Offset: 0x00385678
		// (set) Token: 0x06018787 RID: 100231 RVA: 0x00387480 File Offset: 0x00385680
		public IShowUi_Union Type { get; set; }

		// Token: 0x1700763D RID: 30269
		// (get) Token: 0x06018788 RID: 100232 RVA: 0x00387489 File Offset: 0x00385689
		// (set) Token: 0x06018789 RID: 100233 RVA: 0x00387491 File Offset: 0x00385691
		public object Value { get; set; }

		// Token: 0x0601878A RID: 100234 RVA: 0x0038749A File Offset: 0x0038569A
		public IShowUi_UnionUnion()
		{
			this.Type = IShowUi_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601878B RID: 100235 RVA: 0x003874B0 File Offset: 0x003856B0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601878C RID: 100236 RVA: 0x003874C2 File Offset: 0x003856C2
		public IShowUiT AsIShowUi()
		{
			return this.As<IShowUiT>();
		}

		// Token: 0x0601878D RID: 100237 RVA: 0x003874CA File Offset: 0x003856CA
		public static IShowUi_UnionUnion FromIShowUi(IShowUiT _ishowui)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IShowUi,
				Value = _ishowui
			};
		}

		// Token: 0x0601878E RID: 100238 RVA: 0x003874DF File Offset: 0x003856DF
		public IShowUiAllT AsIShowUiAll()
		{
			return this.As<IShowUiAllT>();
		}

		// Token: 0x0601878F RID: 100239 RVA: 0x003874E7 File Offset: 0x003856E7
		public static IShowUi_UnionUnion FromIShowUiAll(IShowUiAllT _ishowuiall)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IShowUiAll,
				Value = _ishowuiall
			};
		}

		// Token: 0x06018790 RID: 100240 RVA: 0x003874FC File Offset: 0x003856FC
		public IRogueAbilitySelectT AsIRogueAbilitySelect()
		{
			return this.As<IRogueAbilitySelectT>();
		}

		// Token: 0x06018791 RID: 100241 RVA: 0x00387504 File Offset: 0x00385704
		public static IShowUi_UnionUnion FromIRogueAbilitySelect(IRogueAbilitySelectT _irogueabilityselect)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IRogueAbilitySelect,
				Value = _irogueabilityselect
			};
		}

		// Token: 0x06018792 RID: 100242 RVA: 0x00387519 File Offset: 0x00385719
		public IInformationViewT AsIInformationView()
		{
			return this.As<IInformationViewT>();
		}

		// Token: 0x06018793 RID: 100243 RVA: 0x00387521 File Offset: 0x00385721
		public static IShowUi_UnionUnion FromIInformationView(IInformationViewT _iinformationview)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IInformationView,
				Value = _iinformationview
			};
		}

		// Token: 0x06018794 RID: 100244 RVA: 0x00387536 File Offset: 0x00385736
		public IRogueRandomEventT AsIRogueRandomEvent()
		{
			return this.As<IRogueRandomEventT>();
		}

		// Token: 0x06018795 RID: 100245 RVA: 0x0038753E File Offset: 0x0038573E
		public static IShowUi_UnionUnion FromIRogueRandomEvent(IRogueRandomEventT _iroguerandomevent)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IRogueRandomEvent,
				Value = _iroguerandomevent
			};
		}

		// Token: 0x06018796 RID: 100246 RVA: 0x00387553 File Offset: 0x00385753
		public IRoleTrialActivitiesT AsIRoleTrialActivities()
		{
			return this.As<IRoleTrialActivitiesT>();
		}

		// Token: 0x06018797 RID: 100247 RVA: 0x0038755B File Offset: 0x0038575B
		public static IShowUi_UnionUnion FromIRoleTrialActivities(IRoleTrialActivitiesT _iroletrialactivities)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IRoleTrialActivities,
				Value = _iroletrialactivities
			};
		}

		// Token: 0x06018798 RID: 100248 RVA: 0x00387570 File Offset: 0x00385770
		public IRoleSkinTrialActivitiesT AsIRoleSkinTrialActivities()
		{
			return this.As<IRoleSkinTrialActivitiesT>();
		}

		// Token: 0x06018799 RID: 100249 RVA: 0x00387578 File Offset: 0x00385778
		public static IShowUi_UnionUnion FromIRoleSkinTrialActivities(IRoleSkinTrialActivitiesT _iroleskintrialactivities)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IRoleSkinTrialActivities,
				Value = _iroleskintrialactivities
			};
		}

		// Token: 0x0601879A RID: 100250 RVA: 0x0038758D File Offset: 0x0038578D
		public IMowBuffDistributeT AsIMowBuffDistribute()
		{
			return this.As<IMowBuffDistributeT>();
		}

		// Token: 0x0601879B RID: 100251 RVA: 0x00387595 File Offset: 0x00385795
		public static IShowUi_UnionUnion FromIMowBuffDistribute(IMowBuffDistributeT _imowbuffdistribute)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IMowBuffDistribute,
				Value = _imowbuffdistribute
			};
		}

		// Token: 0x0601879C RID: 100252 RVA: 0x003875AA File Offset: 0x003857AA
		public IPermanentRogueUiT AsIPermanentRogueUi()
		{
			return this.As<IPermanentRogueUiT>();
		}

		// Token: 0x0601879D RID: 100253 RVA: 0x003875B2 File Offset: 0x003857B2
		public static IShowUi_UnionUnion FromIPermanentRogueUi(IPermanentRogueUiT _ipermanentrogueui)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IPermanentRogueUi,
				Value = _ipermanentrogueui
			};
		}

		// Token: 0x0601879E RID: 100254 RVA: 0x003875C8 File Offset: 0x003857C8
		public ICiacconaAvgBoardT AsICiacconaAvgBoard()
		{
			return this.As<ICiacconaAvgBoardT>();
		}

		// Token: 0x0601879F RID: 100255 RVA: 0x003875D0 File Offset: 0x003857D0
		public static IShowUi_UnionUnion FromICiacconaAvgBoard(ICiacconaAvgBoardT _iciacconaavgboard)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.ICiacconaAvgBoard,
				Value = _iciacconaavgboard
			};
		}

		// Token: 0x060187A0 RID: 100256 RVA: 0x003875E6 File Offset: 0x003857E6
		public IItemObtainT AsIItemObtain()
		{
			return this.As<IItemObtainT>();
		}

		// Token: 0x060187A1 RID: 100257 RVA: 0x003875EE File Offset: 0x003857EE
		public static IShowUi_UnionUnion FromIItemObtain(IItemObtainT _iitemobtain)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IItemObtain,
				Value = _iitemobtain
			};
		}

		// Token: 0x060187A2 RID: 100258 RVA: 0x00387604 File Offset: 0x00385804
		public IShowUiCraftingT AsIShowUiCrafting()
		{
			return this.As<IShowUiCraftingT>();
		}

		// Token: 0x060187A3 RID: 100259 RVA: 0x0038760C File Offset: 0x0038580C
		public static IShowUi_UnionUnion FromIShowUiCrafting(IShowUiCraftingT _ishowuicrafting)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IShowUiCrafting,
				Value = _ishowuicrafting
			};
		}

		// Token: 0x060187A4 RID: 100260 RVA: 0x00387622 File Offset: 0x00385822
		public IShowUiCookT AsIShowUiCook()
		{
			return this.As<IShowUiCookT>();
		}

		// Token: 0x060187A5 RID: 100261 RVA: 0x0038762A File Offset: 0x0038582A
		public static IShowUi_UnionUnion FromIShowUiCook(IShowUiCookT _ishowuicook)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IShowUiCook,
				Value = _ishowuicook
			};
		}

		// Token: 0x060187A6 RID: 100262 RVA: 0x00387640 File Offset: 0x00385840
		public IShowUiSyntheticT AsIShowUiSynthetic()
		{
			return this.As<IShowUiSyntheticT>();
		}

		// Token: 0x060187A7 RID: 100263 RVA: 0x00387648 File Offset: 0x00385848
		public static IShowUi_UnionUnion FromIShowUiSynthetic(IShowUiSyntheticT _ishowuisynthetic)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IShowUiSynthetic,
				Value = _ishowuisynthetic
			};
		}

		// Token: 0x060187A8 RID: 100264 RVA: 0x0038765E File Offset: 0x0038585E
		public IShowUiForgingT AsIShowUiForging()
		{
			return this.As<IShowUiForgingT>();
		}

		// Token: 0x060187A9 RID: 100265 RVA: 0x00387666 File Offset: 0x00385866
		public static IShowUi_UnionUnion FromIShowUiForging(IShowUiForgingT _ishowuiforging)
		{
			return new IShowUi_UnionUnion
			{
				Type = IShowUi_Union.IShowUiForging,
				Value = _ishowuiforging
			};
		}

		// Token: 0x060187AA RID: 100266 RVA: 0x0038767C File Offset: 0x0038587C
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
