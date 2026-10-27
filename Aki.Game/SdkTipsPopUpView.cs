using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002971 RID: 10609
public class SdkTipsPopUpView : UiTickViewBase
{
	// Token: 0x06015EB5 RID: 89781 RVA: 0x00587951 File Offset: 0x00585B51
	[NullableContext(1)]
	public SdkTipsPopUpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015EB6 RID: 89782 RVA: 0x0058795C File Offset: 0x00585B5C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06015EB7 RID: 89783 RVA: 0x005879B8 File Offset: 0x00585BB8
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

	// Token: 0x06015EB8 RID: 89784 RVA: 0x00587A87 File Offset: 0x00585C87
	protected override void OnBeforeShow()
	{
		SdkPopUpViewData data = this.Data;
		if (data != null && data.NeedMask)
		{
			UiLayer.Instance.SetShowMaskLayer("SdkLoading", true);
		}
	}

	// Token: 0x06015EB9 RID: 89785 RVA: 0x00587AAD File Offset: 0x00585CAD
	protected override void OnBeforeHide()
	{
		SdkPopUpViewData data = this.Data;
		if (data != null && data.NeedMask)
		{
			UiLayer.Instance.SetShowMaskLayer("SdkLoading", false);
		}
	}

	// Token: 0x06015EBA RID: 89786 RVA: 0x00587AD4 File Offset: 0x00585CD4
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

	// Token: 0x06015EBB RID: 89787 RVA: 0x00587B68 File Offset: 0x00585D68
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

	// Token: 0x0400A322 RID: 41762
	private const int AUTOCLOSETIME = 10;

	// Token: 0x0400A323 RID: 41763
	private const int LOGINCLOSETIME = 2000;

	// Token: 0x0400A324 RID: 41764
	private bool IsCanClose;

	// Token: 0x0400A325 RID: 41765
	[Nullable(2)]
	private SdkPopUpViewData Data;

	// Token: 0x0400A326 RID: 41766
	private float CurrentRunningTime;

	// Token: 0x02008F35 RID: 36661
	private enum EComponents
	{
		// Token: 0x0402E6B5 RID: 190133
		CircleImg,
		// Token: 0x0402E6B6 RID: 190134
		TipsText,
		// Token: 0x0402E6B7 RID: 190135
		PlayStationItem
	}
}
