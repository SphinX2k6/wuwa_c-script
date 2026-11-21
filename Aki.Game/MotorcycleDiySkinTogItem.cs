using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001764 RID: 5988
public class MotorcycleDiySkinTogItem : UiPanelBase
{
	// Token: 0x0600E885 RID: 59525 RVA: 0x004425DC File Offset: 0x004407DC
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

	// Token: 0x0600E886 RID: 59526 RVA: 0x00442685 File Offset: 0x00440885
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(() => this.CanExecuteChange == null || this.CanExecuteChange(this.SkinId));
	}

	// Token: 0x0600E887 RID: 59527 RVA: 0x004426A4 File Offset: 0x004408A4
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

	// Token: 0x0600E888 RID: 59528 RVA: 0x004426F4 File Offset: 0x004408F4
	public void SetEquippedStatus(bool isEquipped)
	{
		base.GetTexture(2).SetUIActive(isEquipped);
	}

	// Token: 0x0600E889 RID: 59529 RVA: 0x00442703 File Offset: 0x00440903
	public void SetRedDotVisible(bool isVisible)
	{
		base.GetItem(4).SetUIActive(isVisible);
	}

	// Token: 0x0600E88A RID: 59530 RVA: 0x00442712 File Offset: 0x00440912
	public void SetLockedStatus(bool isLock)
	{
		base.GetItem(3).SetUIActive(isLock);
	}

	// Token: 0x0600E88B RID: 59531 RVA: 0x00442721 File Offset: 0x00440921
	public void SetToggleStateForce(EToggleState state, bool isFireEvent = true)
	{
		base.GetExtendToggle(0).SetToggleStateForce(state, isFireEvent, false, false);
	}

	// Token: 0x0600E88C RID: 59532 RVA: 0x00442733 File Offset: 0x00440933
	public int GetSkinId()
	{
		return this.SkinId;
	}

	// Token: 0x0600E88D RID: 59533 RVA: 0x0044273B File Offset: 0x0044093B
	public EToggleState GetToggleState()
	{
		return base.GetExtendToggle(0).ToggleState;
	}

	// Token: 0x0600E88E RID: 59534 RVA: 0x00442749 File Offset: 0x00440949
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<int> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this.SkinId);
	}

	// Token: 0x0400846E RID: 33902
	private int SkinId;

	// Token: 0x0400846F RID: 33903
	[Nullable(2)]
	public Func<int, bool> CanExecuteChange;

	// Token: 0x04008470 RID: 33904
	[Nullable(2)]
	public Action<int> OnClickToggleBack;

	// Token: 0x0200794E RID: 31054
	private class EMotorDiySkinTogItemComponent
	{
		// Token: 0x04027513 RID: 161043
		public const int TogSkin = 0;

		// Token: 0x04027514 RID: 161044
		public const int TexIcon = 1;

		// Token: 0x04027515 RID: 161045
		public const int TexDone = 2;

		// Token: 0x04027516 RID: 161046
		public const int LockItem = 3;

		// Token: 0x04027517 RID: 161047
		public const int RedDotItem = 4;
	}
}
