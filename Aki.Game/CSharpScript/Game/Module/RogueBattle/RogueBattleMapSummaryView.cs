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
	// Token: 0x02003EBB RID: 16059
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleMapSummaryView : UiViewBase
	{
		// Token: 0x06028BFB RID: 166907 RVA: 0x00B6E75F File Offset: 0x00B6C95F
		public RogueBattleMapSummaryView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028BFC RID: 166908 RVA: 0x00B6E774 File Offset: 0x00B6C974
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

		// Token: 0x06028BFD RID: 166909 RVA: 0x00B6E810 File Offset: 0x00B6CA10
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RogueResMapSummaryTeamToBondUpdate, new Action(this.OnJumpToBondTab));
		}

		// Token: 0x06028BFE RID: 166910 RVA: 0x00B6E82E File Offset: 0x00B6CA2E
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RogueResMapSummaryTeamToBondUpdate, new Action(this.OnJumpToBondTab));
		}

		// Token: 0x06028BFF RID: 166911 RVA: 0x00B6E84C File Offset: 0x00B6CA4C
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

		// Token: 0x06028C00 RID: 166912 RVA: 0x00B6E944 File Offset: 0x00B6CB44
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			RogueBattleMapSummaryView.<OnBeforeShowAsyncImplementImplement>d__11 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<RogueBattleMapSummaryView.<OnBeforeShowAsyncImplementImplement>d__11>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06028C01 RID: 166913 RVA: 0x00B6E987 File Offset: 0x00B6CB87
		protected override void OnBeforeDestroy()
		{
			if (this.TabComponent != null)
			{
				this.TabComponent.Destroy(null);
				this.TabComponent = null;
			}
		}

		// Token: 0x06028C02 RID: 166914 RVA: 0x00B6E9A4 File Offset: 0x00B6CBA4
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

		// Token: 0x06028C03 RID: 166915 RVA: 0x00B6EA29 File Offset: 0x00B6CC29
		protected override void OnHandleReleaseScene()
		{
			UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.TsUiSceneRoleActor);
			this.TsUiSceneRoleActor = null;
		}

		// Token: 0x06028C04 RID: 166916 RVA: 0x00B6EA43 File Offset: 0x00B6CC43
		private void OnCloseClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x06028C05 RID: 166917 RVA: 0x00B6EA4C File Offset: 0x00B6CC4C
		protected void InitTabComponent()
		{
			CommonTabComponentData<CommonTabItem> data = new CommonTabComponentData<CommonTabItem>(new Func<UUIItem, int?, CommonTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
			this.TabComponent = new TabComponentWithCaptionItem<CommonTabItem>(base.GetItem(0), data, new Action(this.OnCloseClicked), false);
			this.TabComponent.SetHelpButtonShowState(false);
			this.LastClickTime = null;
			this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
			this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(1), EKeyMode.Default);
		}

		// Token: 0x06028C06 RID: 166918 RVA: 0x00B6EAE8 File Offset: 0x00B6CCE8
		private UniTask RefreshTabListAsync()
		{
			RogueBattleMapSummaryView.<RefreshTabListAsync>d__17 <RefreshTabListAsync>d__;
			<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTabListAsync>d__.<>4__this = this;
			<RefreshTabListAsync>d__.<>1__state = -1;
			<RefreshTabListAsync>d__.<>t__builder.Start<RogueBattleMapSummaryView.<RefreshTabListAsync>d__17>(ref <RefreshTabListAsync>d__);
			return <RefreshTabListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028C07 RID: 166919 RVA: 0x00B6EB2C File Offset: 0x00B6CD2C
		private CommonTabData GetCommonData(int index)
		{
			UiDynamicTab uiDynamicTab = this.TabDataList[index];
			return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x06028C08 RID: 166920 RVA: 0x00B6EB64 File Offset: 0x00B6CD64
		protected bool CanToggleChange(int index, bool? _)
		{
			if (Info.Instance.IsInGamepad())
			{
				return true;
			}
			int? intConfig = ConfigCommonParamById.GetIntConfig("panel_interval_time");
			return this.LastClickTime == null || Time.Instance.Now - this.LastClickTime.Value >= (double)intConfig.Value;
		}

		// Token: 0x06028C09 RID: 166921 RVA: 0x00B6EBBA File Offset: 0x00B6CDBA
		private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x06028C0A RID: 166922 RVA: 0x00B6EBC4 File Offset: 0x00B6CDC4
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

		// Token: 0x06028C0B RID: 166923 RVA: 0x00B6EC54 File Offset: 0x00B6CE54
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

		// Token: 0x06028C0C RID: 166924 RVA: 0x00B6ECA4 File Offset: 0x00B6CEA4
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

		// Token: 0x06028C0D RID: 166925 RVA: 0x00B6ED18 File Offset: 0x00B6CF18
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

		// Token: 0x06028C0E RID: 166926 RVA: 0x00B6ED6E File Offset: 0x00B6CF6E
		private void OnExtendToggleStateChange(EToggleState newState)
		{
			RogueBattleModel.Instance.ChangeDescMode();
		}

		// Token: 0x06028C0F RID: 166927 RVA: 0x00B6ED7C File Offset: 0x00B6CF7C
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

		// Token: 0x04016297 RID: 90775
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x04016298 RID: 90776
		[Nullable(2)]
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x04016299 RID: 90777
		private double? LastClickTime;

		// Token: 0x0401629A RID: 90778
		protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x0401629B RID: 90779
		private EUiTabViewName? CurSelectTabView;

		// Token: 0x0401629C RID: 90780
		[Nullable(2)]
		private TsUiSceneRoleActor TsUiSceneRoleActor;
	}
}
