using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001796 RID: 6038
public class MotorcycleScenePopupView : UiViewBase
{
	// Token: 0x0600EB2B RID: 60203 RVA: 0x00450743 File Offset: 0x0044E943
	[NullableContext(1)]
	public MotorcycleScenePopupView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EB2C RID: 60204 RVA: 0x0045074C File Offset: 0x0044E94C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x0600EB2D RID: 60205 RVA: 0x004507BC File Offset: 0x0044E9BC
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleScenePopupView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleScenePopupView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EB2E RID: 60206 RVA: 0x00450800 File Offset: 0x0044EA00
	private UniTask InitDeActivePanelAsync()
	{
		MotorcycleScenePopupView.<InitDeActivePanelAsync>d__8 <InitDeActivePanelAsync>d__;
		<InitDeActivePanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDeActivePanelAsync>d__.<>4__this = this;
		<InitDeActivePanelAsync>d__.<>1__state = -1;
		<InitDeActivePanelAsync>d__.<>t__builder.Start<MotorcycleScenePopupView.<InitDeActivePanelAsync>d__8>(ref <InitDeActivePanelAsync>d__);
		return <InitDeActivePanelAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EB2F RID: 60207 RVA: 0x00450844 File Offset: 0x0044EA44
	private UniTask InitConfirmBtnAsync()
	{
		MotorcycleScenePopupView.<InitConfirmBtnAsync>d__9 <InitConfirmBtnAsync>d__;
		<InitConfirmBtnAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitConfirmBtnAsync>d__.<>4__this = this;
		<InitConfirmBtnAsync>d__.<>1__state = -1;
		<InitConfirmBtnAsync>d__.<>t__builder.Start<MotorcycleScenePopupView.<InitConfirmBtnAsync>d__9>(ref <InitConfirmBtnAsync>d__);
		return <InitConfirmBtnAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EB30 RID: 60208 RVA: 0x00450887 File Offset: 0x0044EA87
	protected override void OnBeforeDestroy()
	{
		GenericLayout<MotorcycleScenePopupItem, int> sceneLayout = this.SceneLayout;
		if (sceneLayout != null)
		{
			sceneLayout.ClearChildren();
		}
		this.SceneLayout = null;
		this.ConfirmBtn = null;
	}

	// Token: 0x0600EB31 RID: 60209 RVA: 0x004508A8 File Offset: 0x0044EAA8
	[NullableContext(1)]
	private MotorcycleScenePopupItem CreateSceneItem()
	{
		return new MotorcycleScenePopupItem
		{
			OnClickToggleBack = new Action<int>(this.OnClickSceneItem),
			GetCurrentSceneId = (() => this.CurrentSelectedSceneId)
		};
	}

	// Token: 0x0600EB32 RID: 60210 RVA: 0x004508D4 File Offset: 0x0044EAD4
	private UniTask RefreshSceneListAsync()
	{
		MotorcycleScenePopupView.<RefreshSceneListAsync>d__12 <RefreshSceneListAsync>d__;
		<RefreshSceneListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSceneListAsync>d__.<>4__this = this;
		<RefreshSceneListAsync>d__.<>1__state = -1;
		<RefreshSceneListAsync>d__.<>t__builder.Start<MotorcycleScenePopupView.<RefreshSceneListAsync>d__12>(ref <RefreshSceneListAsync>d__);
		return <RefreshSceneListAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EB33 RID: 60211 RVA: 0x00450918 File Offset: 0x0044EB18
	private void SelectDefaultScene()
	{
		int currentSceneId = MotorcycleDiyModel.Instance.GetCurrentSceneId();
		if (currentSceneId > 0)
		{
			GenericLayout<MotorcycleScenePopupItem, int> sceneLayout = this.SceneLayout;
			if (sceneLayout != null)
			{
				sceneLayout.SelectGridProxyByKey(currentSceneId, false);
			}
			GenericLayout<MotorcycleScenePopupItem, int> sceneLayout2 = this.SceneLayout;
			if (sceneLayout2 == null)
			{
				return;
			}
			MotorcycleScenePopupItem layoutItemByKey = sceneLayout2.GetLayoutItemByKey(currentSceneId);
			if (layoutItemByKey == null)
			{
				return;
			}
			layoutItemByKey.SetToggleState(true, true);
		}
	}

	// Token: 0x0600EB34 RID: 60212 RVA: 0x00450970 File Offset: 0x0044EB70
	private void RefreshBottomBar()
	{
		MotorScene? motorSceneConfig = MotorDiyConfig.Instance.GetMotorSceneConfig(this.CurrentSelectedSceneId);
		if (motorSceneConfig == null)
		{
			ButtonItem confirmBtn = this.ConfirmBtn;
			if (confirmBtn != null)
			{
				confirmBtn.SetActive(false);
			}
			FunctionalPanelConditionLock deActivePanel = this.DeActivePanel;
			if (deActivePanel == null)
			{
				return;
			}
			deActivePanel.SetUiActive(false);
			return;
		}
		else if (!MotorcycleDiyModel.Instance.HasScene(this.CurrentSelectedSceneId))
		{
			ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(motorSceneConfig.Value.UnlockItem);
			if (itemConfig != null && itemConfig.Value.ItemAccessLength > 0)
			{
				int accessPathId = itemConfig.Value.ItemAccess(0);
				AccessPath? accessPathConfig = InventoryConfig.Instance.GetAccessPathConfig(accessPathId);
				if (accessPathConfig != null)
				{
					FunctionalPanelConditionLock deActivePanel2 = this.DeActivePanel;
					if (deActivePanel2 != null)
					{
						deActivePanel2.SetTextByTextId(accessPathConfig.Value.Description, Array.Empty<string>());
					}
				}
			}
			ButtonItem confirmBtn2 = this.ConfirmBtn;
			if (confirmBtn2 != null)
			{
				confirmBtn2.SetActive(false);
			}
			FunctionalPanelConditionLock deActivePanel3 = this.DeActivePanel;
			if (deActivePanel3 == null)
			{
				return;
			}
			deActivePanel3.SetUiActive(true);
			return;
		}
		else
		{
			int currentSceneId = MotorcycleDiyModel.Instance.GetCurrentSceneId();
			bool flag = this.CurrentSelectedSceneId == currentSceneId;
			string textId = flag ? "MotorUILevel_Onuse" : "MotorUILevel_useButton";
			FunctionalPanelConditionLock deActivePanel4 = this.DeActivePanel;
			if (deActivePanel4 != null)
			{
				deActivePanel4.SetUiActive(false);
			}
			ButtonItem confirmBtn3 = this.ConfirmBtn;
			if (confirmBtn3 != null)
			{
				confirmBtn3.SetActive(true);
			}
			ButtonItem confirmBtn4 = this.ConfirmBtn;
			if (confirmBtn4 != null)
			{
				confirmBtn4.SetEnableClick(!flag);
			}
			ButtonItem confirmBtn5 = this.ConfirmBtn;
			if (confirmBtn5 == null)
			{
				return;
			}
			confirmBtn5.SetLocalTextNew(textId, Array.Empty<object>());
			return;
		}
	}

	// Token: 0x0600EB35 RID: 60213 RVA: 0x00450AF0 File Offset: 0x0044ECF0
	private void OnClickSceneItem(int sceneId)
	{
		if (this.CurrentSelectedSceneId > 0 && this.CurrentSelectedSceneId != sceneId)
		{
			GenericLayout<MotorcycleScenePopupItem, int> sceneLayout = this.SceneLayout;
			if (sceneLayout != null)
			{
				sceneLayout.DeselectCurrentGridProxy();
			}
		}
		this.CurrentSelectedSceneId = sceneId;
		GenericLayout<MotorcycleScenePopupItem, int> sceneLayout2 = this.SceneLayout;
		MotorcycleScenePopupItem motorcycleScenePopupItem = (sceneLayout2 != null) ? sceneLayout2.GetLayoutItemByKey(sceneId) : null;
		if (motorcycleScenePopupItem != null)
		{
			MotorcycleDiyModel.Instance.RecordHadCheckNewScene(sceneId);
			motorcycleScenePopupItem.RefreshRedDot();
		}
		GenericLayout<MotorcycleScenePopupItem, int> sceneLayout3 = this.SceneLayout;
		if (sceneLayout3 != null)
		{
			sceneLayout3.SelectGridProxyByKey(sceneId, true);
		}
		this.RefreshBottomBar();
	}

	// Token: 0x0600EB36 RID: 60214 RVA: 0x00450B72 File Offset: 0x0044ED72
	private void OnClickConfirmButton()
	{
		if (!MotorcycleDiyModel.Instance.HasScene(this.CurrentSelectedSceneId))
		{
			return;
		}
		MotorcycleDiyController.Instance.UseMotorSceneRequest(this.CurrentSelectedSceneId, delegate
		{
			this.SwitchScene();
		});
	}

	// Token: 0x0600EB37 RID: 60215 RVA: 0x00450BA4 File Offset: 0x0044EDA4
	protected void SwitchScene()
	{
		int currentSceneId = MotorcycleDiyModel.Instance.GetCurrentSceneId();
		if (currentSceneId <= 0)
		{
			return;
		}
		MotorScene? motorSceneConfig = MotorDiyConfig.Instance.GetMotorSceneConfig(currentSceneId);
		if (motorSceneConfig == null || StringUtils.IsBlank(motorSceneConfig.Value.SceneId))
		{
			return;
		}
		UiSceneManager.Instance.SwitchUiSceneWithBlackScreen(motorSceneConfig.Value.SceneId, delegate(bool isSuccess)
		{
			MotorcycleScenePopupView.<<SwitchScene>b__17_0>d <<SwitchScene>b__17_0>d;
			<<SwitchScene>b__17_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<SwitchScene>b__17_0>d.<>4__this = this;
			<<SwitchScene>b__17_0>d.isSuccess = isSuccess;
			<<SwitchScene>b__17_0>d.<>1__state = -1;
			<<SwitchScene>b__17_0>d.<>t__builder.Start<MotorcycleScenePopupView.<<SwitchScene>b__17_0>d>(ref <<SwitchScene>b__17_0>d);
			return <<SwitchScene>b__17_0>d.<>t__builder.Task;
		}).Forget();
	}

	// Token: 0x04008588 RID: 34184
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<MotorcycleScenePopupItem, int> SceneLayout;

	// Token: 0x04008589 RID: 34185
	[Nullable(2)]
	private FunctionalPanelConditionLock DeActivePanel;

	// Token: 0x0400858A RID: 34186
	[Nullable(2)]
	private ButtonItem ConfirmBtn;

	// Token: 0x0400858B RID: 34187
	private int CurrentSelectedSceneId;

	// Token: 0x020079A5 RID: 31141
	private class EComponent
	{
		// Token: 0x040276D5 RID: 161493
		public const int SceneLayout = 0;

		// Token: 0x040276D6 RID: 161494
		public const int SceneItem = 1;

		// Token: 0x040276D7 RID: 161495
		public const int DeActivePanel = 2;

		// Token: 0x040276D8 RID: 161496
		public const int ConfirmButton = 3;
	}
}
