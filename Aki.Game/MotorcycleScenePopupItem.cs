using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001795 RID: 6037
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleScenePopupItem : GridProxyAbstract<int>
{
	// Token: 0x1700165C RID: 5724
	// (get) Token: 0x0600EB1C RID: 60188 RVA: 0x0045047F File Offset: 0x0044E67F
	// (set) Token: 0x0600EB1D RID: 60189 RVA: 0x00450487 File Offset: 0x0044E687
	public Action<int> OnClickToggleBack { get; set; }

	// Token: 0x1700165D RID: 5725
	// (get) Token: 0x0600EB1E RID: 60190 RVA: 0x00450490 File Offset: 0x0044E690
	// (set) Token: 0x0600EB1F RID: 60191 RVA: 0x00450498 File Offset: 0x0044E698
	public Func<int> GetCurrentSceneId { get; set; }

	// Token: 0x0600EB20 RID: 60192 RVA: 0x004504A4 File Offset: 0x0044E6A4
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

	// Token: 0x0600EB21 RID: 60193 RVA: 0x00450563 File Offset: 0x0044E763
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
	}

	// Token: 0x0600EB22 RID: 60194 RVA: 0x00450584 File Offset: 0x0044E784
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

	// Token: 0x0600EB23 RID: 60195 RVA: 0x0045064E File Offset: 0x0044E84E
	public override void Clear()
	{
		this.SceneId = null;
	}

	// Token: 0x0600EB24 RID: 60196 RVA: 0x0045065C File Offset: 0x0044E85C
	public void SetToggleState(bool isSelected, bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x0600EB25 RID: 60197 RVA: 0x00450674 File Offset: 0x0044E874
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

	// Token: 0x0600EB26 RID: 60198 RVA: 0x004506B6 File Offset: 0x0044E8B6
	[NullableContext(1)]
	public override object GetKey(int data, int displayIndex)
	{
		return data;
	}

	// Token: 0x0600EB27 RID: 60199 RVA: 0x004506BE File Offset: 0x0044E8BE
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600EB28 RID: 60200 RVA: 0x004506D0 File Offset: 0x0044E8D0
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

	// Token: 0x0600EB29 RID: 60201 RVA: 0x00450710 File Offset: 0x0044E910
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

	// Token: 0x04008585 RID: 34181
	private int? SceneId;

	// Token: 0x020079A4 RID: 31140
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x040276CF RID: 161487
		public const int SceneToggle = 0;

		// Token: 0x040276D0 RID: 161488
		public const int SceneTexture = 1;

		// Token: 0x040276D1 RID: 161489
		public const int SceneNameText = 2;

		// Token: 0x040276D2 RID: 161490
		public const int CurrentMarkItem = 3;

		// Token: 0x040276D3 RID: 161491
		public const int LockItem = 4;

		// Token: 0x040276D4 RID: 161492
		public const int RedDotItem = 5;
	}
}
