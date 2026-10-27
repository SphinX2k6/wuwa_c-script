using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002280 RID: 8832
public class MotorcycleDiySkinTogItem : UiPanelBase
{
	// Token: 0x060113EF RID: 70639 RVA: 0x004359D0 File Offset: 0x00433BD0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x060113F0 RID: 70640 RVA: 0x00435A79 File Offset: 0x00433C79
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(() => this.CanExecuteChange == null || this.CanExecuteChange(this.SkinId));
	}

	// Token: 0x060113F1 RID: 70641 RVA: 0x00435A98 File Offset: 0x00433C98
	public void Refresh(int skinId)
	{
		this.SkinId = skinId;
		MotorSkin? motorSkinConfig = MotorDiyConfig.Instance.GetMotorSkinConfig(skinId);
		if (motorSkinConfig == null)
		{
			return;
		}
		base.SetTextureByPath(motorSkinConfig.Value.SkinIcon, base.GetTexture(1), null, null);
	}

	// Token: 0x060113F2 RID: 70642 RVA: 0x00435AE8 File Offset: 0x00433CE8
	public void SetEquippedStatus(bool isEquipped)
	{
		base.GetTexture(2).SetUIActive(isEquipped);
	}

	// Token: 0x060113F3 RID: 70643 RVA: 0x00435AF7 File Offset: 0x00433CF7
	public void SetRedDotVisible(bool isVisible)
	{
		base.GetItem(4).SetUIActive(isVisible);
	}

	// Token: 0x060113F4 RID: 70644 RVA: 0x00435B06 File Offset: 0x00433D06
	public void SetLockedStatus(bool isLock)
	{
		base.GetItem(3).SetUIActive(isLock);
	}

	// Token: 0x060113F5 RID: 70645 RVA: 0x00435B15 File Offset: 0x00433D15
	public void SetToggleStateForce(EToggleState state, bool isFireEvent = true)
	{
		base.GetExtendToggle(0).SetToggleStateForce(state, isFireEvent, false, false);
	}

	// Token: 0x060113F6 RID: 70646 RVA: 0x00435B27 File Offset: 0x00433D27
	public int GetSkinId()
	{
		return this.SkinId;
	}

	// Token: 0x060113F7 RID: 70647 RVA: 0x00435B2F File Offset: 0x00433D2F
	public EToggleState GetToggleState()
	{
		return base.GetExtendToggle(0).ToggleState;
	}

	// Token: 0x060113F8 RID: 70648 RVA: 0x00435B3D File Offset: 0x00433D3D
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<int> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this.SkinId);
	}

	// Token: 0x04008330 RID: 33584
	private int SkinId;

	// Token: 0x04008331 RID: 33585
	[Nullable(2)]
	public Func<int, bool> CanExecuteChange;

	// Token: 0x04008332 RID: 33586
	[Nullable(2)]
	public Action<int> OnClickToggleBack;

	// Token: 0x020087C5 RID: 34757
	private class EMotorDiySkinTogItemComponent
	{
		// Token: 0x0402C1FB RID: 180731
		public const int TogSkin = 0;

		// Token: 0x0402C1FC RID: 180732
		public const int TexIcon = 1;

		// Token: 0x0402C1FD RID: 180733
		public const int TexDone = 2;

		// Token: 0x0402C1FE RID: 180734
		public const int LockItem = 3;

		// Token: 0x0402C1FF RID: 180735
		public const int RedDotItem = 4;
	}
}
