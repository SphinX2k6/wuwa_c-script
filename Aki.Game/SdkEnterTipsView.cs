using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200296B RID: 10603
public class SdkEnterTipsView : UiTickViewBase
{
	// Token: 0x06015E85 RID: 89733 RVA: 0x00586A35 File Offset: 0x00584C35
	[NullableContext(1)]
	public SdkEnterTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015E86 RID: 89734 RVA: 0x00586A3E File Offset: 0x00584C3E
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06015E87 RID: 89735 RVA: 0x00586A78 File Offset: 0x00584C78
	protected override void OnStart()
	{
		this.Data = (this.OpenParam as SdkEnterTipsViewData);
		if (this.UiViewSequence != null)
		{
			this.UiViewSequence.AddSequenceFinishEvent("Start", delegate(string _)
			{
				this.IsCanClose = true;
			}, false);
		}
		this.RefreshText(this.Data);
	}

	// Token: 0x06015E88 RID: 89736 RVA: 0x00586AC7 File Offset: 0x00584CC7
	protected override void OnBeforeShow()
	{
		SdkEnterTipsViewData data = this.Data;
		if (data != null && data.NeedMask)
		{
			UiLayer.Instance.SetShowMaskLayer("SdkLoading", true);
		}
	}

	// Token: 0x06015E89 RID: 89737 RVA: 0x00586AED File Offset: 0x00584CED
	protected override void OnBeforeHide()
	{
		SdkEnterTipsViewData data = this.Data;
		if (data != null && data.NeedMask)
		{
			UiLayer.Instance.SetShowMaskLayer("SdkLoading", false);
		}
	}

	// Token: 0x06015E8A RID: 89738 RVA: 0x00586B13 File Offset: 0x00584D13
	protected override void OnTick(float delta)
	{
		if (this.IsCanClose && base.IsShow)
		{
			this.IsCanClose = false;
			base.CloseMe(null);
		}
	}

	// Token: 0x06015E8B RID: 89739 RVA: 0x00586B33 File Offset: 0x00584D33
	[NullableContext(2)]
	private void RefreshText(SdkEnterTipsViewData data)
	{
		if (data != null)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetText(data.Text, true);
		}
	}

	// Token: 0x0400A317 RID: 41751
	private bool IsCanClose;

	// Token: 0x0400A318 RID: 41752
	[Nullable(2)]
	private SdkEnterTipsViewData Data;

	// Token: 0x02008F2C RID: 36652
	private enum EComponents
	{
		// Token: 0x0402E68A RID: 190090
		TipsText,
		// Token: 0x0402E68B RID: 190091
		CircleImg
	}
}
