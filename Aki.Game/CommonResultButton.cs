using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E1D RID: 3613
[NullableContext(1)]
[Nullable(0)]
public class CommonResultButton : UiPanelBase
{
	// Token: 0x060091FE RID: 37374 RVA: 0x002BA7DF File Offset: 0x002B89DF
	public CommonResultButton(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x060091FF RID: 37375 RVA: 0x002BA7F4 File Offset: 0x002B89F4
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

	// Token: 0x06009200 RID: 37376 RVA: 0x002BA8B3 File Offset: 0x002B8AB3
	private void ButtonClick()
	{
		if (this.BtnFunction != null)
		{
			this.BtnFunction();
		}
		this.DoClickCallBack();
	}

	// Token: 0x06009201 RID: 37377 RVA: 0x002BA8CE File Offset: 0x002B8ACE
	protected override void OnBeforeDestroy()
	{
		this.ClearBtnTimer();
		this.BtnFunction = null;
	}

	// Token: 0x06009202 RID: 37378 RVA: 0x002BA8DD File Offset: 0x002B8ADD
	public void ResetData()
	{
		this.CommonResultButtonData = null;
	}

	// Token: 0x06009203 RID: 37379 RVA: 0x002BA8E6 File Offset: 0x002B8AE6
	public void SetData(CommonResultButtonData data)
	{
		this.CommonResultButtonData = data;
	}

	// Token: 0x06009204 RID: 37380 RVA: 0x002BA8EF File Offset: 0x002B8AEF
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

	// Token: 0x06009205 RID: 37381 RVA: 0x002BA90B File Offset: 0x002B8B0B
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

	// Token: 0x06009206 RID: 37382 RVA: 0x002BA929 File Offset: 0x002B8B29
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

	// Token: 0x06009207 RID: 37383 RVA: 0x002BA946 File Offset: 0x002B8B46
	public void SetBtnFunction(Action btnFunction)
	{
		this.BtnFunction = btnFunction;
	}

	// Token: 0x06009208 RID: 37384 RVA: 0x002BA950 File Offset: 0x002B8B50
	public void SetBtnCanClick(bool canClick)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button.GetSelfInteractive() != canClick)
		{
			button.SetSelfInteractive(canClick);
		}
	}

	// Token: 0x06009209 RID: 37385 RVA: 0x002BA975 File Offset: 0x002B8B75
	public void SetBtnText(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(1), textId, args);
	}

	// Token: 0x0600920A RID: 37386 RVA: 0x002BA98A File Offset: 0x002B8B8A
	public UUIText GetBtnText()
	{
		return base.GetText(1);
	}

	// Token: 0x0600920B RID: 37387 RVA: 0x002BA994 File Offset: 0x002B8B94
	[NullableContext(2)]
	public void SetTipsItem(int itemId, string countText = null)
	{
		string newText = "×" + ((countText != null) ? int.Parse(countText) : InventoryModel.Instance.GetItemCountByConfigId(itemId, 0)).ToString();
		base.GetText(4).SetText(newText, true);
		base.SetItemIcon(base.GetTexture(3), itemId, null, null);
		base.GetItem(5).SetUIActive(true);
	}

	// Token: 0x0600920C RID: 37388 RVA: 0x002BA9FE File Offset: 0x002B8BFE
	public void SetTipsItemTextColor(FColor color)
	{
		base.GetText(4).SetColor(color);
	}

	// Token: 0x0600920D RID: 37389 RVA: 0x002BAA0D File Offset: 0x002B8C0D
	public void SetFloatText(string textId, params object[] args)
	{
		base.GetText(2).SetUIActive(true);
		LguiUtil.Instance.SetLocalText(base.GetText(2), textId, args);
	}

	// Token: 0x0600920E RID: 37390 RVA: 0x002BAA2F File Offset: 0x002B8C2F
	public UUIText GetBtnFloatText()
	{
		base.GetText(2).SetUIActive(true);
		return base.GetText(2);
	}

	// Token: 0x0600920F RID: 37391 RVA: 0x002BAA48 File Offset: 0x002B8C48
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

	// Token: 0x06009210 RID: 37392 RVA: 0x002BAACA File Offset: 0x002B8CCA
	protected void ClearBtnTimer()
	{
		if (this.TimerId != null && TimerSystem.GameplayTimeInstance.Has(this.TimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
		}
		this.TimerId = null;
	}

	// Token: 0x04005659 RID: 22105
	[Nullable(2)]
	private TimerHandle TimerId;

	// Token: 0x0400565A RID: 22106
	private int DelayTime;

	// Token: 0x0400565B RID: 22107
	[Nullable(2)]
	private Action BtnFunction;

	// Token: 0x0400565C RID: 22108
	[Nullable(2)]
	private CommonResultButtonData CommonResultButtonData;

	// Token: 0x02007044 RID: 28740
	[NullableContext(0)]
	private enum ECommonResultButton
	{
		// Token: 0x04024A06 RID: 150022
		Button,
		// Token: 0x04024A07 RID: 150023
		ButtonText,
		// Token: 0x04024A08 RID: 150024
		FloatText,
		// Token: 0x04024A09 RID: 150025
		TipsIcon,
		// Token: 0x04024A0A RID: 150026
		TipsCount,
		// Token: 0x04024A0B RID: 150027
		TipsItem
	}
}
