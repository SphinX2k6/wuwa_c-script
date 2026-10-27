using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001ED3 RID: 7891
public class HonamiStoryMainLoadingView : LoadingViewBase
{
	// Token: 0x0600F2A0 RID: 62112 RVA: 0x003A8044 File Offset: 0x003A6244
	[NullableContext(1)]
	public HonamiStoryMainLoadingView(UiViewInfo uiViewInfo) : base(uiViewInfo)
	{
	}

	// Token: 0x0600F2A1 RID: 62113 RVA: 0x003A8050 File Offset: 0x003A6250
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F2A2 RID: 62114 RVA: 0x003A80DC File Offset: 0x003A62DC
	protected override void OnStart()
	{
		base.OnStart();
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		IHonamiStoryLoadingData curLoadingData = HonamiStoryModel.Instance.GetCurLoadingData();
		if (curLoadingData == null)
		{
			return;
		}
		IHonamiStoryLoadingData honamiStoryLoadingData = curLoadingData;
		if (honamiStoryLoadingData.LoadingId != null)
		{
			int? loadingId = honamiStoryLoadingData.LoadingId;
			int num = 0;
			if (loadingId.GetValueOrDefault() > num & loadingId != null)
			{
				this.LoadingConfig = HonamiStoryConfig.Instance.GetLoadingPerformConfigById(honamiStoryLoadingData.LoadingId.Value);
			}
		}
		this.UpdateHonamiStoryLoading();
	}

	// Token: 0x0600F2A3 RID: 62115 RVA: 0x003A8164 File Offset: 0x003A6364
	protected override void UpdateProgressRate(float rate)
	{
	}

	// Token: 0x0600F2A4 RID: 62116 RVA: 0x003A8166 File Offset: 0x003A6366
	protected override void UpdateProgressValue(float value)
	{
		this.SetTextProgressValue(0, value, "");
	}

	// Token: 0x0600F2A5 RID: 62117 RVA: 0x003A8178 File Offset: 0x003A6378
	private void UpdateHonamiStoryLoading()
	{
		if (this.LoadingConfig == null)
		{
			return;
		}
		HonamiStoryLoadingPerform? loadingConfig = this.LoadingConfig;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), loadingConfig.Value.Title, Array.Empty<object>());
		HonamiStoryModel.Instance.ClearCurLoadingData();
	}

	// Token: 0x0600F2A6 RID: 62118 RVA: 0x003A81C9 File Offset: 0x003A63C9
	protected override void OnLevelSequencePlayerBandStateChange(bool state)
	{
		base.PlaySequence("Start", null, false);
	}

	// Token: 0x04007061 RID: 28769
	private HonamiStoryLoadingPerform? LoadingConfig;

	// Token: 0x020084B9 RID: 33977
	private enum EHonamiStoryLoadingComponents
	{
		// Token: 0x0402B32D RID: 176941
		ProgressText,
		// Token: 0x0402B32E RID: 176942
		TitleText,
		// Token: 0x0402B32F RID: 176943
		DescText
	}
}
