using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x020019D9 RID: 6617
[NullableContext(1)]
[Nullable(0)]
public class VisionSkinItem : LoopScrollSmallItemGrid<int>
{
	// Token: 0x06010517 RID: 66839 RVA: 0x004C39E4 File Offset: 0x004C1BE4
	protected override void OnRefresh(int data, bool isSelected, int gridIndex)
	{
		this.ItemId = data;
		bool value = NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.VisionSkin, data);
		bool value2 = PhantomBattleConfig.Instance.GetPhantomItemById(data).Value.ParentMonsterId != 0 && !PhantomBattleModel.Instance.GetSkinIsUnlock(data);
		PhantomSmallItemGrid parameters = new PhantomSmallItemGrid
		{
			Data = data,
			ItemConfigId = new int?(data),
			IsLockVisibleBlack = new bool?(value2),
			IsNewVisible = new bool?(value),
			IsQualityHidden = new bool?(true)
		};
		base.Apply<PhantomSmallItemGrid>(parameters);
		if (this.GetItemGridExtendToggle().ToggleState != EToggleState.ETT_UnChecked)
		{
			this.SetSelected(false, true);
		}
	}

	// Token: 0x06010518 RID: 66840 RVA: 0x004C3A94 File Offset: 0x004C1C94
	protected override void OnStart()
	{
		base.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnClickEvent));
		UUIExtendToggle itemGridExtendToggle = this.GetItemGridExtendToggle();
		if (itemGridExtendToggle == null)
		{
			return;
		}
		itemGridExtendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
	}

	// Token: 0x06010519 RID: 66841 RVA: 0x004C3AC9 File Offset: 0x004C1CC9
	public override void OnSelected(bool fireEvent)
	{
		if (this.GetItemGridExtendToggle().ToggleState != EToggleState.ETT_Checked)
		{
			this.SetSelected(true, true);
		}
	}

	// Token: 0x0601051A RID: 66842 RVA: 0x004C3AE4 File Offset: 0x004C1CE4
	private void OnClickEvent(MediumItemGridExtendCallback _)
	{
		Action<int, UUIExtendToggle> onClickCallBack = this.OnClickCallBack;
		if (onClickCallBack != null)
		{
			onClickCallBack(this.ItemId, this.GetItemGridExtendToggle());
		}
		base.SetNewFlagVisible(new bool?(false));
		NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.VisionSkin, this.ItemId);
		NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.VisionSkin);
	}

	// Token: 0x0601051B RID: 66843 RVA: 0x004C3B3A File Offset: 0x004C1D3A
	public void SetClickToggleEvent(Action<int, UUIExtendToggle> call)
	{
		this.OnClickCallBack = call;
	}

	// Token: 0x0601051C RID: 66844 RVA: 0x004C3B43 File Offset: 0x004C1D43
	public void BindCanToggleExecuteChange(Func<int, bool> toggle)
	{
		this.OnCanToggleClicked = toggle;
	}

	// Token: 0x0601051D RID: 66845 RVA: 0x004C3B4C File Offset: 0x004C1D4C
	private bool CanToggleExecuteChange()
	{
		return this.OnCanToggleClicked == null || this.OnCanToggleClicked(this.ItemId);
	}

	// Token: 0x04009073 RID: 36979
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle> OnClickCallBack;

	// Token: 0x04009074 RID: 36980
	[Nullable(2)]
	private Func<int, bool> OnCanToggleClicked;

	// Token: 0x04009075 RID: 36981
	private int ItemId = -1;
}
