using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001960 RID: 6496
[NullableContext(1)]
[Nullable(0)]
public class CommonResultButton : UiPanelBase
{
	// Token: 0x0600BDFB RID: 48635 RVA: 0x002AF99B File Offset: 0x002ADB9B
	public CommonResultButton(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600BDFC RID: 48636 RVA: 0x002AF9B0 File Offset: 0x002ADBB0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick))
		};
	}

	// Token: 0x0600BDFD RID: 48637 RVA: 0x002AFA6F File Offset: 0x002ADC6F
	private void ButtonClick()
	{
		if (this.BtnFunction != null)
		{
			this.BtnFunction();
		}
		this.DoClickCallBack();
	}

	// Token: 0x0600BDFE RID: 48638 RVA: 0x002AFA8A File Offset: 0x002ADC8A
	protected override void OnBeforeDestroy()
	{
		this.ClearBtnTimer();
		this.BtnFunction = null;
	}

	// Token: 0x0600BDFF RID: 48639 RVA: 0x002AFA99 File Offset: 0x002ADC99
	public void ResetData()
	{
		this.CommonResultButtonData = null;
	}

	// Token: 0x0600BE00 RID: 48640 RVA: 0x002AFAA2 File Offset: 0x002ADCA2
	public void SetData(CommonResultButtonData data)
	{
		this.CommonResultButtonData = data;
	}

	// Token: 0x0600BE01 RID: 48641 RVA: 0x002AFAAB File Offset: 0x002ADCAB
	public void DoClickCallBack()
	{
		CommonResultButtonData commonResultButtonData = this.CommonResultButtonData;
		if (commonResultButtonData == null)
		{
			return;
		}
		Action buttonClickCallBack = commonResultButtonData.GetButtonClickCallBack();
		if (buttonClickCallBack == null)
		{
			return;
		}
		buttonClickCallBack();
	}

	// Token: 0x0600BE02 RID: 48642 RVA: 0x002AFAC7 File Offset: 0x002ADCC7
	public void DoTimerCallBack(int hasRunTime)
	{
		CommonResultButtonData commonResultButtonData = this.CommonResultButtonData;
		if (commonResultButtonData == null)
		{
			return;
		}
		Action<int, CommonResultButton> buttonTimerCallBack = commonResultButtonData.GetButtonTimerCallBack();
		if (buttonTimerCallBack == null)
		{
			return;
		}
		buttonTimerCallBack(hasRunTime, this);
	}

	// Token: 0x0600BE03 RID: 48643 RVA: 0x002AFAE5 File Offset: 0x002ADCE5
	public void DoRefreshCallBack()
	{
		CommonResultButtonData commonResultButtonData = this.CommonResultButtonData;
		if (commonResultButtonData == null)
		{
			return;
		}
		Action<CommonResultButton> buttonRefreshCallBack = commonResultButtonData.GetButtonRefreshCallBack();
		if (buttonRefreshCallBack == null)
		{
			return;
		}
		buttonRefreshCallBack(this);
	}

	// Token: 0x0600BE04 RID: 48644 RVA: 0x002AFB02 File Offset: 0x002ADD02
	public void SetBtnFunction(Action btnFunction)
	{
		this.BtnFunction = btnFunction;
	}

	// Token: 0x0600BE05 RID: 48645 RVA: 0x002AFB0C File Offset: 0x002ADD0C
	public void SetBtnCanClick(bool canClick)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button.GetSelfInteractive() != canClick)
		{
			button.SetSelfInteractive(canClick);
		}
	}

	// Token: 0x0600BE06 RID: 48646 RVA: 0x002AFB31 File Offset: 0x002ADD31
	public void SetBtnText(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(1), textId, args);
	}

	// Token: 0x0600BE07 RID: 48647 RVA: 0x002AFB46 File Offset: 0x002ADD46
	public UUIText GetBtnText()
	{
		return base.GetText(1);
	}

	// Token: 0x0600BE08 RID: 48648 RVA: 0x002AFB50 File Offset: 0x002ADD50
	[NullableContext(2)]
	public void SetTipsItem(int itemId, string countText = null)
	{
		string newText = "×" + ((countText != null) ? int.Parse(countText) : InventoryModel.Instance.GetItemCountByConfigId(itemId, 0)).ToString();
		base.GetText(4).SetText(newText, true);
		base.SetItemIcon(base.GetTexture(3), itemId, null, null);
		base.GetItem(5).SetUIActive(true);
	}

	// Token: 0x0600BE09 RID: 48649 RVA: 0x002AFBBA File Offset: 0x002ADDBA
	public void SetTipsItemTextColor(FColor color)
	{
		base.GetText(4).SetColor(color);
	}

	// Token: 0x0600BE0A RID: 48650 RVA: 0x002AFBC9 File Offset: 0x002ADDC9
	public void SetFloatText(string textId, params object[] args)
	{
		base.GetText(2).SetUIActive(true);
		LguiUtil.Instance.SetLocalText(base.GetText(2), textId, args);
	}

	// Token: 0x0600BE0B RID: 48651 RVA: 0x002AFBEB File Offset: 0x002ADDEB
	public UUIText GetBtnFloatText()
	{
		base.GetText(2).SetUIActive(true);
		return base.GetText(2);
	}

	// Token: 0x0600BE0C RID: 48652 RVA: 0x002AFC04 File Offset: 0x002ADE04
	public void SetFloatTextWithTimer(int delayTime, bool canClickDuringTimer, string textId)
	{
		this.ClearBtnTimer();
		if (!canClickDuringTimer)
		{
			this.SetBtnCanClick(canClickDuringTimer);
		}
		this.DelayTime = delayTime;
		this.TimerId = TimerSystem.GameplayTimeInstance.Loop(delegate(float _)
		{
			if (this.DelayTime > 0)
			{
				LguiUtil instance = LguiUtil.Instance;
				UUIText text = this.GetText(2);
				string textId2 = textId;
				CommonResultButton <>4__this = this;
				int delayTime2 = this.DelayTime;
				<>4__this.DelayTime = delayTime2 - 1;
				instance.SetLocalText(text, textId2, new <>z__ReadOnlySingleElementList<object>(delayTime2));
				return;
			}
			if (!canClickDuringTimer)
			{
				this.SetBtnCanClick(true);
				return;
			}
			this.ButtonClick();
		}, 1000f, delayTime + 1, 1f, null, null, true);
		base.GetText(2).SetUIActive(true);
	}

	// Token: 0x0600BE0D RID: 48653 RVA: 0x002AFC86 File Offset: 0x002ADE86
	protected void ClearBtnTimer()
	{
		if (this.TimerId != null && TimerSystem.GameplayTimeInstance.Has(this.TimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
		}
		this.TimerId = null;
	}

	// Token: 0x040055AC RID: 21932
	[Nullable(2)]
	private TimerHandle TimerId;

	// Token: 0x040055AD RID: 21933
	private int DelayTime;

	// Token: 0x040055AE RID: 21934
	[Nullable(2)]
	private Action BtnFunction;

	// Token: 0x040055AF RID: 21935
	[Nullable(2)]
	private CommonResultButtonData CommonResultButtonData;

	// Token: 0x02007EB5 RID: 32437
	[NullableContext(0)]
	private enum ECommonResultButton
	{
		// Token: 0x040296C9 RID: 169673
		Button,
		// Token: 0x040296CA RID: 169674
		ButtonText,
		// Token: 0x040296CB RID: 169675
		FloatText,
		// Token: 0x040296CC RID: 169676
		TipsIcon,
		// Token: 0x040296CD RID: 169677
		TipsCount,
		// Token: 0x040296CE RID: 169678
		TipsItem
	}
}
