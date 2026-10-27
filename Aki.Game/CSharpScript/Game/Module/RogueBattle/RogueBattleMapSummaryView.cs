using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EF2 RID: 20210
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleMapSummaryView : UiViewBase
	{
		// Token: 0x06033D90 RID: 212368 RVA: 0x00C251B7 File Offset: 0x00C233B7
		public RogueBattleMapSummaryView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033D91 RID: 212369 RVA: 0x00C251CC File Offset: 0x00C233CC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
		}

		// Token: 0x06033D92 RID: 212370 RVA: 0x00C25268 File Offset: 0x00C23468
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RogueResMapSummaryTeamToBondUpdate, new Action(this.OnJumpToBondTab));
		}

		// Token: 0x06033D93 RID: 212371 RVA: 0x00C25286 File Offset: 0x00C23486
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RogueResMapSummaryTeamToBondUpdate, new Action(this.OnJumpToBondTab));
		}

		// Token: 0x06033D94 RID: 212372 RVA: 0x00C252A4 File Offset: 0x00C234A4
		protected override void OnStart()
		{
			this.TsUiSceneRoleActor = UiSceneManager.Instance.InitRoleSystemRoleActor(EUiModelUseWay.RoleInRoleView);
			TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
			object obj;
			if (tsUiSceneRoleActor == null)
			{
				obj = null;
			}
			else
			{
				UiModelBase model = tsUiSceneRoleActor.Model;
				obj = ((model != null) ? model.CheckGetComponent<UiModelDataComponent>() : null);
			}
			object obj2 = obj;
			if (obj2 != null)
			{
				obj2.SetVisible(false);
			}
			TsUiSceneRoleActor tsUiSceneRoleActor2 = this.TsUiSceneRoleActor;
			object obj3;
			if (tsUiSceneRoleActor2 == null)
			{
				obj3 = null;
			}
			else
			{
				UiModelBase model2 = tsUiSceneRoleActor2.Model;
				obj3 = ((model2 != null) ? model2.CheckGetComponent<UiModelLoadingIconComponent>() : null);
			}
			object obj4 = obj3;
			if (obj4 != null)
			{
				obj4.SetLoadingOpen(false);
			}
			this.InitTabComponent();
			if (this.OpenParam != null)
			{
				IRogueBattleMapSummeryOpenInfo rogueBattleMapSummeryOpenInfo = (IRogueBattleMapSummeryOpenInfo)this.OpenParam;
				this.CurSelectTabView = new EUiTabViewName?(rogueBattleMapSummeryOpenInfo.TabName);
				RogueBattleModel.Instance.CurrentMapSummaryBond = rogueBattleMapSummeryOpenInfo.FetterId.GetValueOrDefault();
				if (rogueBattleMapSummeryOpenInfo.FetterId != null && rogueBattleMapSummeryOpenInfo.FetterId.Value > 0)
				{
					RogueBattleModel.Instance.IsMapSummaryBondJumping = true;
				}
			}
			else
			{
				RogueBattleModel.Instance.CurrentMapSummaryBond = 0;
			}
			this.InitExtendToggle();
		}

		// Token: 0x06033D95 RID: 212373 RVA: 0x00C2539C File Offset: 0x00C2359C
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			RogueBattleMapSummaryView.<OnBeforeShowAsyncImplementImplement>d__11 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<RogueBattleMapSummaryView.<OnBeforeShowAsyncImplementImplement>d__11>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06033D96 RID: 212374 RVA: 0x00C253DF File Offset: 0x00C235DF
		protected override void OnBeforeDestroy()
		{
			if (this.TabComponent != null)
			{
				this.TabComponent.Destroy(null);
				this.TabComponent = null;
			}
		}

		// Token: 0x06033D97 RID: 212375 RVA: 0x00C253FC File Offset: 0x00C235FC
		protected override void OnHandleLoadScene()
		{
			if (this.TsUiSceneRoleActor == null)
			{
				this.TsUiSceneRoleActor = UiSceneManager.Instance.InitRoleSystemRoleActor(EUiModelUseWay.RoleInRoleView);
			}
			UiModelBase model = this.TsUiSceneRoleActor.Model;
			UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
			if (uiModelActorComponent != null)
			{
				uiModelActorComponent.SetTransformByTag("RoleCase");
			}
			if (this.CurSelectTabView == EUiTabViewName.RogueBattleMapSummaryTeamTabView)
			{
				EventSystem.Instance.Emit(EEventName.RogueResMapSummaryTeamShowAgain);
			}
		}

		// Token: 0x06033D98 RID: 212376 RVA: 0x00C25481 File Offset: 0x00C23681
		protected override void OnHandleReleaseScene()
		{
			UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.TsUiSceneRoleActor);
			this.TsUiSceneRoleActor = null;
		}

		// Token: 0x06033D99 RID: 212377 RVA: 0x00C2549B File Offset: 0x00C2369B
		private void OnCloseClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x06033D9A RID: 212378 RVA: 0x00C254A4 File Offset: 0x00C236A4
		protected void InitTabComponent()
		{
			CommonTabComponentData<CommonTabItem> data = new CommonTabComponentData<CommonTabItem>(new Func<UUIItem, int?, CommonTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
			this.TabComponent = new TabComponentWithCaptionItem<CommonTabItem>(base.GetItem(0), data, new Action(this.OnCloseClicked), false);
			this.TabComponent.SetHelpButtonShowState(false);
			this.LastClickTime = null;
			this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
			this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(1), EKeyMode.Default);
		}

		// Token: 0x06033D9B RID: 212379 RVA: 0x00C25540 File Offset: 0x00C23740
		private UniTask RefreshTabListAsync()
		{
			RogueBattleMapSummaryView.<RefreshTabListAsync>d__17 <RefreshTabListAsync>d__;
			<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTabListAsync>d__.<>4__this = this;
			<RefreshTabListAsync>d__.<>1__state = -1;
			<RefreshTabListAsync>d__.<>t__builder.Start<RogueBattleMapSummaryView.<RefreshTabListAsync>d__17>(ref <RefreshTabListAsync>d__);
			return <RefreshTabListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033D9C RID: 212380 RVA: 0x00C25584 File Offset: 0x00C23784
		private CommonTabData GetCommonData(int index)
		{
			UiDynamicTab uiDynamicTab = this.TabDataList[index];
			return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x06033D9D RID: 212381 RVA: 0x00C255BC File Offset: 0x00C237BC
		protected bool CanToggleChange(int index, bool? _)
		{
			if (Info.Instance.IsInGamepad())
			{
				return true;
			}
			int? intConfig = ConfigCommonParamById.GetIntConfig("panel_interval_time");
			return this.LastClickTime == null || Time.Instance.Now - this.LastClickTime.Value >= (double)intConfig.Value;
		}

		// Token: 0x06033D9E RID: 212382 RVA: 0x00C25612 File Offset: 0x00C23812
		private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x06033D9F RID: 212383 RVA: 0x00C2561C File Offset: 0x00C2381C
		private void ToggleCallBack(int index)
		{
			this.LastClickTime = new double?(Time.Instance.Now);
			UiDynamicTab data = this.TabDataList[index];
			EUiTabViewName euiTabViewName = (EUiTabViewName)data.ChildViewName;
			this.OnTeamTabShow(euiTabViewName == EUiTabViewName.RogueBattleMapSummaryTeamTabView);
			this.OnTokenTabShow(euiTabViewName == EUiTabViewName.RogueBattleSummaryTokenTabView);
			CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			this.TabViewComponent.ToggleCallBack(data, euiTabViewName, tabItemByIndex, null, null);
			this.CurSelectTabView = new EUiTabViewName?(euiTabViewName);
		}

		// Token: 0x06033DA0 RID: 212384 RVA: 0x00C256AC File Offset: 0x00C238AC
		private void OnTeamTabShow(bool isVisible)
		{
			TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
			object obj;
			if (tsUiSceneRoleActor == null)
			{
				obj = null;
			}
			else
			{
				UiModelBase model = tsUiSceneRoleActor.Model;
				obj = ((model != null) ? model.CheckGetComponent<UiModelDataComponent>() : null);
			}
			object obj2 = obj;
			if (obj2 != null)
			{
				obj2.SetVisible(isVisible);
			}
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(!isVisible);
		}

		// Token: 0x06033DA1 RID: 212385 RVA: 0x00C256FC File Offset: 0x00C238FC
		private void OnTokenTabShow(bool isOpen)
		{
			if (!isOpen)
			{
				UUIItem item = base.GetItem(2);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				UUIItem item2 = base.GetItem(5);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
				return;
			}
			else
			{
				bool flag = RogueBattleModel.Instance.GetTokenData().Count == 0;
				UUIItem item3 = base.GetItem(2);
				if (item3 != null)
				{
					item3.SetUIActive(flag);
				}
				UUIItem item4 = base.GetItem(5);
				if (item4 == null)
				{
					return;
				}
				item4.SetUIActive(!flag);
				return;
			}
		}

		// Token: 0x06033DA2 RID: 212386 RVA: 0x00C25770 File Offset: 0x00C23970
		private void OnJumpToBondTab()
		{
			for (int i = 0; i < this.TabDataList.Count; i++)
			{
				if ((EUiTabViewName)this.TabDataList[i].ChildViewName == EUiTabViewName.RogueBattleMapSummaryFettersTabView)
				{
					this.TabComponent.SelectToggleByIndex(i, false);
					return;
				}
			}
		}

		// Token: 0x06033DA3 RID: 212387 RVA: 0x00C257C6 File Offset: 0x00C239C6
		private void OnExtendToggleStateChange(EToggleState newState)
		{
			RogueBattleModel.Instance.ChangeDescMode();
		}

		// Token: 0x06033DA4 RID: 212388 RVA: 0x00C257D4 File Offset: 0x00C239D4
		protected void InitExtendToggle()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			EToggleState state = (RogueBattleModel.Instance.DescMode == EDescModel.DETAIL) ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(state, false, false, false);
			}
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnExtendToggleStateChange));
		}

		// Token: 0x0401B8C4 RID: 112836
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x0401B8C5 RID: 112837
		[Nullable(2)]
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x0401B8C6 RID: 112838
		private double? LastClickTime;

		// Token: 0x0401B8C7 RID: 112839
		protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x0401B8C8 RID: 112840
		private EUiTabViewName? CurSelectTabView;

		// Token: 0x0401B8C9 RID: 112841
		[Nullable(2)]
		private TsUiSceneRoleActor TsUiSceneRoleActor;
	}
}
