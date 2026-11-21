using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EEC RID: 7916
public class SdkTipsPopUpView : UiTickViewBase
{
	// Token: 0x060138B9 RID: 80057 RVA: 0x005B2955 File Offset: 0x005B0B55
	[NullableContext(1)]
	public SdkTipsPopUpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060138BA RID: 80058 RVA: 0x005B2960 File Offset: 0x005B0B60
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x060138BB RID: 80059 RVA: 0x005B29BC File Offset: 0x005B0BBC
	protected override void OnStart()
	{
		SdkPopUpViewData sdkPopUpViewData = this.OpenParam as SdkPopUpViewData;
		this.Data = sdkPopUpViewData;
		if (sdkPopUpViewData != null && sdkPopUpViewData.ViewType == ESdkPopUpViewType.Login)
		{
			if (this.UiViewSequence != null)
			{
				this.UiViewSequence.AddSequenceFinishEvent("Start", delegate(string _)
				{
					TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
					{
						this.IsCanClose = true;
					}, 2000f, null, null, true, 1f);
				}, false);
			}
		}
		else if (this.UiViewSequence != null)
		{
			this.UiViewSequence.AddSequenceFinishEvent("Start", delegate(string _)
			{
				if (this.UiViewSequence != null)
				{
					this.UiViewSequence.PlaySequence("Loop", false, null);
				}
			}, false);
		}
		if (sdkPopUpViewData != null)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(sdkPopUpViewData.ViewType == ESdkPopUpViewType.Login);
			}
			UUIItem item2 = base.GetItem(0);
			if (item2 != null)
			{
				item2.SetUIActive(sdkPopUpViewData.ViewType == ESdkPopUpViewType.Creating);
			}
			this.RefreshText(sdkPopUpViewData);
		}
	}

	// Token: 0x060138BC RID: 80060 RVA: 0x005B2A8B File Offset: 0x005B0C8B
	protected override void OnBeforeShow()
	{
		SdkPopUpViewData data = this.Data;
		if (data != null && data.NeedMask)
		{
			UiLayer.Instance.SetShowMaskLayer("SdkLoading", true);
		}
	}

	// Token: 0x060138BD RID: 80061 RVA: 0x005B2AB1 File Offset: 0x005B0CB1
	protected override void OnBeforeHide()
	{
		SdkPopUpViewData data = this.Data;
		if (data != null && data.NeedMask)
		{
			UiLayer.Instance.SetShowMaskLayer("SdkLoading", false);
		}
	}

	// Token: 0x060138BE RID: 80062 RVA: 0x005B2AD8 File Offset: 0x005B0CD8
	protected override void OnTick(float delta)
	{
		if (this.IsCanClose && base.IsShow)
		{
			this.IsCanClose = false;
			base.CloseMe(null);
		}
		SdkPopUpViewData data = this.Data;
		if (((data != null) ? new ESdkPopUpViewType?(data.ViewType) : null) == ESdkPopUpViewType.Creating)
		{
			this.CurrentRunningTime += delta / 1000f;
			if (this.CurrentRunningTime >= 10f)
			{
				base.CloseMe(null);
			}
		}
	}

	// Token: 0x060138BF RID: 80063 RVA: 0x005B2B6C File Offset: 0x005B0D6C
	[NullableContext(1)]
	private void RefreshText(SdkPopUpViewData data)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(data.Text, true);
	}

	// Token: 0x0400A70C RID: 42764
	private const int AUTOCLOSETIME = 10;

	// Token: 0x0400A70D RID: 42765
	private const int LOGINCLOSETIME = 2000;

	// Token: 0x0400A70E RID: 42766
	private bool IsCanClose;

	// Token: 0x0400A70F RID: 42767
	[Nullable(2)]
	private SdkPopUpViewData Data;

	// Token: 0x0400A710 RID: 42768
	private float CurrentRunningTime;

	// Token: 0x0200817D RID: 33149
	private enum EComponents
	{
		// Token: 0x04029DB2 RID: 171442
		CircleImg,
		// Token: 0x04029DB3 RID: 171443
		TipsText,
		// Token: 0x04029DB4 RID: 171444
		PlayStationItem
	}
}
