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

// Token: 0x020022B2 RID: 8882
public class MotorcycleScenePopupView : UiViewBase
{
	// Token: 0x06011693 RID: 71315 RVA: 0x00443B5F File Offset: 0x00441D5F
	[NullableContext(1)]
	public MotorcycleScenePopupView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011694 RID: 71316 RVA: 0x00443B68 File Offset: 0x00441D68
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

	// Token: 0x06011695 RID: 71317 RVA: 0x00443BD8 File Offset: 0x00441DD8
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleScenePopupView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleScenePopupView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011696 RID: 71318 RVA: 0x00443C1C File Offset: 0x00441E1C
	private UniTask InitDeActivePanelAsync()
	{
		MotorcycleScenePopupView.<InitDeActivePanelAsync>d__8 <InitDeActivePanelAsync>d__;
		<InitDeActivePanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDeActivePanelAsync>d__.<>4__this = this;
		<InitDeActivePanelAsync>d__.<>1__state = -1;
		<InitDeActivePanelAsync>d__.<>t__builder.Start<MotorcycleScenePopupView.<InitDeActivePanelAsync>d__8>(ref <InitDeActivePanelAsync>d__);
		return <InitDeActivePanelAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011697 RID: 71319 RVA: 0x00443C60 File Offset: 0x00441E60
	private UniTask InitConfirmBtnAsync()
	{
		MotorcycleScenePopupView.<InitConfirmBtnAsync>d__9 <InitConfirmBtnAsync>d__;
		<InitConfirmBtnAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitConfirmBtnAsync>d__.<>4__this = this;
		<InitConfirmBtnAsync>d__.<>1__state = -1;
		<InitConfirmBtnAsync>d__.<>t__builder.Start<MotorcycleScenePopupView.<InitConfirmBtnAsync>d__9>(ref <InitConfirmBtnAsync>d__);
		return <InitConfirmBtnAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011698 RID: 71320 RVA: 0x00443CA3 File Offset: 0x00441EA3
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

	// Token: 0x06011699 RID: 71321 RVA: 0x00443CC4 File Offset: 0x00441EC4
	[NullableContext(1)]
	private MotorcycleScenePopupItem CreateSceneItem()
	{
		return new MotorcycleScenePopupItem
		{
			OnClickToggleBack = new Action<int>(this.OnClickSceneItem),
			GetCurrentSceneId = (() => this.CurrentSelectedSceneId)
		};
	}

	// Token: 0x0601169A RID: 71322 RVA: 0x00443CF0 File Offset: 0x00441EF0
	private UniTask RefreshSceneListAsync()
	{
		MotorcycleScenePopupView.<RefreshSceneListAsync>d__12 <RefreshSceneListAsync>d__;
		<RefreshSceneListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSceneListAsync>d__.<>4__this = this;
		<RefreshSceneListAsync>d__.<>1__state = -1;
		<RefreshSceneListAsync>d__.<>t__builder.Start<MotorcycleScenePopupView.<RefreshSceneListAsync>d__12>(ref <RefreshSceneListAsync>d__);
		return <RefreshSceneListAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601169B RID: 71323 RVA: 0x00443D34 File Offset: 0x00441F34
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

	// Token: 0x0601169C RID: 71324 RVA: 0x00443D8C File Offset: 0x00441F8C
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

	// Token: 0x0601169D RID: 71325 RVA: 0x00443F0C File Offset: 0x0044210C
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

	// Token: 0x0601169E RID: 71326 RVA: 0x00443F8E File Offset: 0x0044218E
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

	// Token: 0x0601169F RID: 71327 RVA: 0x00443FC0 File Offset: 0x004421C0
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

	// Token: 0x0400844A RID: 33866
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<MotorcycleScenePopupItem, int> SceneLayout;

	// Token: 0x0400844B RID: 33867
	[Nullable(2)]
	private FunctionalPanelConditionLock DeActivePanel;

	// Token: 0x0400844C RID: 33868
	[Nullable(2)]
	private ButtonItem ConfirmBtn;

	// Token: 0x0400844D RID: 33869
	private int CurrentSelectedSceneId;

	// Token: 0x02008821 RID: 34849
	private class EComponent
	{
		// Token: 0x0402C3D0 RID: 181200
		public const int SceneLayout = 0;

		// Token: 0x0402C3D1 RID: 181201
		public const int SceneItem = 1;

		// Token: 0x0402C3D2 RID: 181202
		public const int DeActivePanel = 2;

		// Token: 0x0402C3D3 RID: 181203
		public const int ConfirmButton = 3;
	}
}
