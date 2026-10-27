using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020022B1 RID: 8881
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleScenePopupItem : GridProxyAbstract<int>
{
	// Token: 0x17001625 RID: 5669
	// (get) Token: 0x06011684 RID: 71300 RVA: 0x0044389B File Offset: 0x00441A9B
	// (set) Token: 0x06011685 RID: 71301 RVA: 0x004438A3 File Offset: 0x00441AA3
	public Action<int> OnClickToggleBack { get; set; }

	// Token: 0x17001626 RID: 5670
	// (get) Token: 0x06011686 RID: 71302 RVA: 0x004438AC File Offset: 0x00441AAC
	// (set) Token: 0x06011687 RID: 71303 RVA: 0x004438B4 File Offset: 0x00441AB4
	public Func<int> GetCurrentSceneId { get; set; }

	// Token: 0x06011688 RID: 71304 RVA: 0x004438C0 File Offset: 0x00441AC0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x06011689 RID: 71305 RVA: 0x0044397F File Offset: 0x00441B7F
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
	}

	// Token: 0x0601168A RID: 71306 RVA: 0x004439A0 File Offset: 0x00441BA0
	public override void Refresh(int sceneId, bool isSelected, int gridIndex)
	{
		this.SceneId = new int?(sceneId);
		base.GridIndex = gridIndex;
		base.DisplayIndex = gridIndex;
		MotorScene? motorSceneConfig = MotorDiyConfig.Instance.GetMotorSceneConfig(sceneId);
		if (motorSceneConfig == null)
		{
			return;
		}
		int currentSceneId = MotorcycleDiyModel.Instance.GetCurrentSceneId();
		bool uiactive = sceneId == currentSceneId;
		bool flag = MotorcycleDiyModel.Instance.HasScene(sceneId);
		base.SetTextureByPath(motorSceneConfig.Value.SceneIcon, base.GetTexture(1), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), motorSceneConfig.Value.SceneName, Array.Empty<object>());
		base.GetItem(3).SetUIActive(uiactive);
		base.GetItem(4).SetUIActive(!flag);
		this.RefreshRedDot();
	}

	// Token: 0x0601168B RID: 71307 RVA: 0x00443A6A File Offset: 0x00441C6A
	public override void Clear()
	{
		this.SceneId = null;
	}

	// Token: 0x0601168C RID: 71308 RVA: 0x00443A78 File Offset: 0x00441C78
	public void SetToggleState(bool isSelected, bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x0601168D RID: 71309 RVA: 0x00443A90 File Offset: 0x00441C90
	public void RefreshRedDot()
	{
		if (this.SceneId == null)
		{
			return;
		}
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(MotorcycleDiyModel.Instance.RedDotHasNewScene(this.SceneId.Value));
	}

	// Token: 0x0601168E RID: 71310 RVA: 0x00443AD2 File Offset: 0x00441CD2
	[NullableContext(1)]
	public override object GetKey(int data, int displayIndex)
	{
		return data;
	}

	// Token: 0x0601168F RID: 71311 RVA: 0x00443ADA File Offset: 0x00441CDA
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06011690 RID: 71312 RVA: 0x00443AEC File Offset: 0x00441CEC
	private bool CanExecuteChange()
	{
		if (this.SceneId == null)
		{
			return false;
		}
		Func<int> getCurrentSceneId = this.GetCurrentSceneId;
		int num = (getCurrentSceneId != null) ? getCurrentSceneId() : 0;
		return this.SceneId.Value != num;
	}

	// Token: 0x06011691 RID: 71313 RVA: 0x00443B2C File Offset: 0x00441D2C
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.SceneId == null)
		{
			return;
		}
		Action<int> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this.SceneId.Value);
	}

	// Token: 0x04008447 RID: 33863
	private int? SceneId;

	// Token: 0x02008820 RID: 34848
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402C3CA RID: 181194
		public const int SceneToggle = 0;

		// Token: 0x0402C3CB RID: 181195
		public const int SceneTexture = 1;

		// Token: 0x0402C3CC RID: 181196
		public const int SceneNameText = 2;

		// Token: 0x0402C3CD RID: 181197
		public const int CurrentMarkItem = 3;

		// Token: 0x0402C3CE RID: 181198
		public const int LockItem = 4;

		// Token: 0x0402C3CF RID: 181199
		public const int RedDotItem = 5;
	}
}
