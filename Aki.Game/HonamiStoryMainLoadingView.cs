using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001395 RID: 5013
public class HonamiStoryMainLoadingView : LoadingViewBase
{
	// Token: 0x0600C6BF RID: 50879 RVA: 0x003B3B44 File Offset: 0x003B1D44
	[NullableContext(1)]
	public HonamiStoryMainLoadingView(UiViewInfo uiViewInfo) : base(uiViewInfo)
	{
	}

	// Token: 0x0600C6C0 RID: 50880 RVA: 0x003B3B50 File Offset: 0x003B1D50
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

	// Token: 0x0600C6C1 RID: 50881 RVA: 0x003B3BDC File Offset: 0x003B1DDC
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

	// Token: 0x0600C6C2 RID: 50882 RVA: 0x003B3C64 File Offset: 0x003B1E64
	protected override void UpdateProgressRate(float rate)
	{
	}

	// Token: 0x0600C6C3 RID: 50883 RVA: 0x003B3C66 File Offset: 0x003B1E66
	protected override void UpdateProgressValue(float value)
	{
		this.SetTextProgressValue(0, value, "");
	}

	// Token: 0x0600C6C4 RID: 50884 RVA: 0x003B3C78 File Offset: 0x003B1E78
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

	// Token: 0x0600C6C5 RID: 50885 RVA: 0x003B3CC9 File Offset: 0x003B1EC9
	protected override void OnLevelSequencePlayerBandStateChange(bool state)
	{
		base.PlaySequence("Start", null, false);
	}

	// Token: 0x04007142 RID: 28994
	private HonamiStoryLoadingPerform? LoadingConfig;

	// Token: 0x0200763E RID: 30270
	private enum EHonamiStoryLoadingComponents
	{
		// Token: 0x04026651 RID: 157265
		ProgressText,
		// Token: 0x04026652 RID: 157266
		TitleText,
		// Token: 0x04026653 RID: 157267
		DescText
	}
}
