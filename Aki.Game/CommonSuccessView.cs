using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020019AE RID: 6574
public class CommonSuccessView : UiViewBase
{
	// Token: 0x0600BFBE RID: 49086 RVA: 0x002B4457 File Offset: 0x002B2657
	[NullableContext(1)]
	public CommonSuccessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BFBF RID: 49087 RVA: 0x002B4460 File Offset: 0x002B2660
	protected override void OnBeforeCreate()
	{
		this.Data = ((this.OpenParam as CommonSuccessData) ?? new CommonSuccessData());
		this.SetAudio();
	}

	// Token: 0x0600BFC0 RID: 49088 RVA: 0x002B4484 File Offset: 0x002B2684
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.CloseClick))
		};
	}

	// Token: 0x0600BFC1 RID: 49089 RVA: 0x002B452D File Offset: 0x002B272D
	private void CloseClick()
	{
		if (this.Data.GetNeedDelay())
		{
			return;
		}
		this.CloseView();
	}

	// Token: 0x0600BFC2 RID: 49090 RVA: 0x002B4543 File Offset: 0x002B2743
	protected override void OnAfterPlayStartSequence()
	{
		this.UiViewSequence.PlaySequencePurely("Xunhuan", false, false);
		this.DelayClose();
	}

	// Token: 0x0600BFC3 RID: 49091 RVA: 0x002B455D File Offset: 0x002B275D
	protected override void OnAfterShow()
	{
		this.SetTitleText();
		this.SetSubTitleText();
		this.SetClickText();
	}

	// Token: 0x0600BFC4 RID: 49092 RVA: 0x002B4574 File Offset: 0x002B2774
	private void SetAudio()
	{
		string audioPath = this.Data.GetAudioPath();
		if (!string.IsNullOrEmpty(audioPath))
		{
			base.SetAudioEvent(audioPath);
		}
	}

	// Token: 0x0600BFC5 RID: 49093 RVA: 0x002B459C File Offset: 0x002B279C
	private void SetTitleText()
	{
		string titleText = this.Data.GetTitleText();
		if (!string.IsNullOrEmpty(titleText))
		{
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalText(text, titleText, Array.Empty<object>());
		}
	}

	// Token: 0x0600BFC6 RID: 49094 RVA: 0x002B45D8 File Offset: 0x002B27D8
	private void SetSubTitleText()
	{
		string subTitleText = this.Data.GetSubTitleText();
		UUIText text = base.GetText(1);
		if (!string.IsNullOrEmpty(subTitleText))
		{
			text.SetUIActive(true);
			LguiUtil.Instance.SetLocalText(text, subTitleText, Array.Empty<object>());
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x0600BFC7 RID: 49095 RVA: 0x002B4624 File Offset: 0x002B2824
	private void SetClickText()
	{
		string clickText = this.Data.GetClickText();
		if (!string.IsNullOrEmpty(clickText))
		{
			base.GetItem(4).SetUIActive(true);
			UUIText text = base.GetText(2);
			LguiUtil.Instance.SetLocalText(text, clickText, Array.Empty<object>());
		}
	}

	// Token: 0x0600BFC8 RID: 49096 RVA: 0x002B466B File Offset: 0x002B286B
	private void DelayClose()
	{
		if (this.Data.GetNeedDelay())
		{
			this.TimerId = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.CloseView();
			}, (float)CommonSuccessView.DelayTime, null, null, true, 1f);
		}
	}

	// Token: 0x0600BFC9 RID: 49097 RVA: 0x002B46A4 File Offset: 0x002B28A4
	private void CloseView()
	{
		Action clickFunction = this.Data.GetClickFunction();
		if (clickFunction != null)
		{
			clickFunction();
		}
		this.TimerId = null;
		base.CloseMe(null);
	}

	// Token: 0x0600BFCA RID: 49098 RVA: 0x002B46D4 File Offset: 0x002B28D4
	protected override void OnBeforeDestroy()
	{
		if (this.TimerId != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
			this.TimerId = null;
		}
	}

	// Token: 0x0400563C RID: 22076
	[Nullable(2)]
	private CommonSuccessData Data;

	// Token: 0x0400563D RID: 22077
	private static readonly int DelayTime = 1500;

	// Token: 0x0400563E RID: 22078
	[Nullable(2)]
	protected TimerHandle TimerId;

	// Token: 0x02007ED5 RID: 32469
	private enum ECommonSuccessViewDefine
	{
		// Token: 0x04029728 RID: 169768
		TitleText,
		// Token: 0x04029729 RID: 169769
		SubTitleText,
		// Token: 0x0402972A RID: 169770
		ClickText,
		// Token: 0x0402972B RID: 169771
		CloseButton,
		// Token: 0x0402972C RID: 169772
		ClickItem
	}
}
