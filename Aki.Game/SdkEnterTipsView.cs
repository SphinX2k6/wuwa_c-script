using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EE6 RID: 7910
public class SdkEnterTipsView : UiTickViewBase
{
	// Token: 0x06013889 RID: 80009 RVA: 0x005B1A39 File Offset: 0x005AFC39
	[NullableContext(1)]
	public SdkEnterTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601388A RID: 80010 RVA: 0x005B1A42 File Offset: 0x005AFC42
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x0601388B RID: 80011 RVA: 0x005B1A7C File Offset: 0x005AFC7C
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

	// Token: 0x0601388C RID: 80012 RVA: 0x005B1ACB File Offset: 0x005AFCCB
	protected override void OnBeforeShow()
	{
		SdkEnterTipsViewData data = this.Data;
		if (data != null && data.NeedMask)
		{
			UiLayer.Instance.SetShowMaskLayer("SdkLoading", true);
		}
	}

	// Token: 0x0601388D RID: 80013 RVA: 0x005B1AF1 File Offset: 0x005AFCF1
	protected override void OnBeforeHide()
	{
		SdkEnterTipsViewData data = this.Data;
		if (data != null && data.NeedMask)
		{
			UiLayer.Instance.SetShowMaskLayer("SdkLoading", false);
		}
	}

	// Token: 0x0601388E RID: 80014 RVA: 0x005B1B17 File Offset: 0x005AFD17
	protected override void OnTick(float delta)
	{
		if (this.IsCanClose && base.IsShow)
		{
			this.IsCanClose = false;
			base.CloseMe(null);
		}
	}

	// Token: 0x0601388F RID: 80015 RVA: 0x005B1B37 File Offset: 0x005AFD37
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

	// Token: 0x0400A701 RID: 42753
	private bool IsCanClose;

	// Token: 0x0400A702 RID: 42754
	[Nullable(2)]
	private SdkEnterTipsViewData Data;

	// Token: 0x02008174 RID: 33140
	private enum EComponents
	{
		// Token: 0x04029D87 RID: 171399
		TipsText,
		// Token: 0x04029D88 RID: 171400
		CircleImg
	}
}
