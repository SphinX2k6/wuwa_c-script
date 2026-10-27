using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x020024F2 RID: 9458
[NullableContext(1)]
[Nullable(0)]
public class VisionSkinItem : LoopScrollSmallItemGrid<int>
{
	// Token: 0x06013058 RID: 77912 RVA: 0x004B5D3C File Offset: 0x004B3F3C
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

	// Token: 0x06013059 RID: 77913 RVA: 0x004B5DEC File Offset: 0x004B3FEC
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

	// Token: 0x0601305A RID: 77914 RVA: 0x004B5E21 File Offset: 0x004B4021
	public override void OnSelected(bool fireEvent)
	{
		if (this.GetItemGridExtendToggle().ToggleState != EToggleState.ETT_Checked)
		{
			this.SetSelected(true, true);
		}
	}

	// Token: 0x0601305B RID: 77915 RVA: 0x004B5E3C File Offset: 0x004B403C
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

	// Token: 0x0601305C RID: 77916 RVA: 0x004B5E92 File Offset: 0x004B4092
	public void SetClickToggleEvent(Action<int, UUIExtendToggle> call)
	{
		this.OnClickCallBack = call;
	}

	// Token: 0x0601305D RID: 77917 RVA: 0x004B5E9B File Offset: 0x004B409B
	public void BindCanToggleExecuteChange(Func<int, bool> toggle)
	{
		this.OnCanToggleClicked = toggle;
	}

	// Token: 0x0601305E RID: 77918 RVA: 0x004B5EA4 File Offset: 0x004B40A4
	private bool CanToggleExecuteChange()
	{
		return this.OnCanToggleClicked == null || this.OnCanToggleClicked(this.ItemId);
	}

	// Token: 0x04008F29 RID: 36649
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle> OnClickCallBack;

	// Token: 0x04008F2A RID: 36650
	[Nullable(2)]
	private Func<int, bool> OnCanToggleClicked;

	// Token: 0x04008F2B RID: 36651
	private int ItemId = -1;
}
