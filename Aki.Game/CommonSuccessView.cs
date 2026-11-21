using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E6C RID: 3692
public class CommonSuccessView : UiViewBase
{
	// Token: 0x060093C8 RID: 37832 RVA: 0x002BF3E7 File Offset: 0x002BD5E7
	[NullableContext(1)]
	public CommonSuccessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060093C9 RID: 37833 RVA: 0x002BF3F0 File Offset: 0x002BD5F0
	protected override void OnBeforeCreate()
	{
		this.Data = ((this.OpenParam as CommonSuccessData) ?? new CommonSuccessData());
		this.SetAudio();
	}

	// Token: 0x060093CA RID: 37834 RVA: 0x002BF414 File Offset: 0x002BD614
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

	// Token: 0x060093CB RID: 37835 RVA: 0x002BF4BD File Offset: 0x002BD6BD
	private void CloseClick()
	{
		if (this.Data.GetNeedDelay())
		{
			return;
		}
		this.CloseView();
	}

	// Token: 0x060093CC RID: 37836 RVA: 0x002BF4D3 File Offset: 0x002BD6D3
	protected override void OnAfterPlayStartSequence()
	{
		this.UiViewSequence.PlaySequencePurely("Xunhuan", false, false);
		this.DelayClose();
	}

	// Token: 0x060093CD RID: 37837 RVA: 0x002BF4ED File Offset: 0x002BD6ED
	protected override void OnAfterShow()
	{
		this.SetTitleText();
		this.SetSubTitleText();
		this.SetClickText();
	}

	// Token: 0x060093CE RID: 37838 RVA: 0x002BF504 File Offset: 0x002BD704
	private void SetAudio()
	{
		string audioPath = this.Data.GetAudioPath();
		if (!string.IsNullOrEmpty(audioPath))
		{
			base.SetAudioEvent(audioPath);
		}
	}

	// Token: 0x060093CF RID: 37839 RVA: 0x002BF52C File Offset: 0x002BD72C
	private void SetTitleText()
	{
		string titleText = this.Data.GetTitleText();
		if (!string.IsNullOrEmpty(titleText))
		{
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalText(text, titleText, Array.Empty<object>());
		}
	}

	// Token: 0x060093D0 RID: 37840 RVA: 0x002BF568 File Offset: 0x002BD768
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

	// Token: 0x060093D1 RID: 37841 RVA: 0x002BF5B4 File Offset: 0x002BD7B4
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

	// Token: 0x060093D2 RID: 37842 RVA: 0x002BF5FB File Offset: 0x002BD7FB
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

	// Token: 0x060093D3 RID: 37843 RVA: 0x002BF634 File Offset: 0x002BD834
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

	// Token: 0x060093D4 RID: 37844 RVA: 0x002BF664 File Offset: 0x002BD864
	protected override void OnBeforeDestroy()
	{
		if (this.TimerId != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
			this.TimerId = null;
		}
	}

	// Token: 0x040056EE RID: 22254
	[Nullable(2)]
	private CommonSuccessData Data;

	// Token: 0x040056EF RID: 22255
	private static readonly int DelayTime = 1500;

	// Token: 0x040056F0 RID: 22256
	[Nullable(2)]
	protected TimerHandle TimerId;

	// Token: 0x02007064 RID: 28772
	private enum ECommonSuccessViewDefine
	{
		// Token: 0x04024A65 RID: 150117
		TitleText,
		// Token: 0x04024A66 RID: 150118
		SubTitleText,
		// Token: 0x04024A67 RID: 150119
		ClickText,
		// Token: 0x04024A68 RID: 150120
		CloseButton,
		// Token: 0x04024A69 RID: 150121
		ClickItem
	}
}
