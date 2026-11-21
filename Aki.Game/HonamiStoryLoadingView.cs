using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001394 RID: 5012
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryLoadingView : LoadingViewBase
{
	// Token: 0x0600C6B6 RID: 50870 RVA: 0x003B366D File Offset: 0x003B186D
	public HonamiStoryLoadingView(UiViewInfo uiViewInfo) : base(uiViewInfo)
	{
	}

	// Token: 0x0600C6B7 RID: 50871 RVA: 0x003B3678 File Offset: 0x003B1878
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C6B8 RID: 50872 RVA: 0x003B37A8 File Offset: 0x003B19A8
	protected override void OnStart()
	{
		base.OnStart();
		IHonamiStoryLoadingData curLoadingData = HonamiStoryModel.Instance.GetCurLoadingData();
		if (curLoadingData == null)
		{
			return;
		}
		IHonamiStoryLoadingData honamiStoryLoadingData = curLoadingData;
		if (honamiStoryLoadingData.LoadingId != null)
		{
			int? num = honamiStoryLoadingData.LoadingId;
			int num2 = 0;
			if (num.GetValueOrDefault() > num2 & num != null)
			{
				this.LoadingConfig = HonamiStoryConfig.Instance.GetLoadingPerformConfigById(honamiStoryLoadingData.LoadingId.Value);
				goto IL_13B;
			}
		}
		if (honamiStoryLoadingData.Timing != null)
		{
			int? num = honamiStoryLoadingData.Timing;
			int num2 = 0;
			if (num.GetValueOrDefault() > num2 & num != null)
			{
				if (honamiStoryLoadingData.BtId != null)
				{
					num = honamiStoryLoadingData.BtId;
					num2 = 0;
					if (num.GetValueOrDefault() > num2 & num != null)
					{
						this.LoadingConfig = HonamiStoryConfig.Instance.GetLoadingPerformConfigByBtAndTime(honamiStoryLoadingData.BtId.Value, honamiStoryLoadingData.Timing.Value);
						goto IL_13B;
					}
				}
				IReadOnlyList<HonamiStoryLoadingPerform> loadingPerformConfigListByTiming = HonamiStoryConfig.Instance.GetLoadingPerformConfigListByTiming(honamiStoryLoadingData.Timing.Value);
				int count = loadingPerformConfigListByTiming.Count;
				int index = new Random().Next(0, count);
				this.LoadingConfig = new HonamiStoryLoadingPerform?(loadingPerformConfigListByTiming[index]);
			}
		}
		IL_13B:
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.AddSequenceStartEvent("Start", new Action<string>(this.OnStartSequenceEvent));
		}
		UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
		if (uiViewSequence2 != null)
		{
			uiViewSequence2.AddSequenceStartEvent("Close", new Action<string>(this.OnCloseSequenceEvent));
		}
		this.UpdateHonamiStoryLoading();
	}

	// Token: 0x0600C6B9 RID: 50873 RVA: 0x003B393A File Offset: 0x003B1B3A
	protected override void UpdateProgressRate(float rate)
	{
	}

	// Token: 0x0600C6BA RID: 50874 RVA: 0x003B393C File Offset: 0x003B1B3C
	protected override void UpdateProgressValue(float value)
	{
		this.SetTextProgressValue(1, value, "");
	}

	// Token: 0x0600C6BB RID: 50875 RVA: 0x003B394C File Offset: 0x003B1B4C
	private void UpdateHonamiStoryLoading()
	{
		if (this.LoadingConfig == null)
		{
			return;
		}
		HonamiStoryLoadingPerform? loadingConfig = this.LoadingConfig;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), loadingConfig.Value.Title, Array.Empty<object>());
		bool flag = !StringUtils.IsBlank(loadingConfig.Value.Tips);
		if (flag)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), loadingConfig.Value.Tips, Array.Empty<object>());
		}
		base.GetText(3).SetUIActive(flag);
		base.GetItem(4).SetUIActive(false);
		base.GetItem(5).SetUIActive(false);
		base.GetItem(6).SetUIActive(false);
		base.GetItem(7).SetUIActive(false);
		switch (loadingConfig.Value.PerformType)
		{
		case 1:
			base.GetItem(4).SetUIActive(true);
			break;
		case 2:
			base.GetItem(5).SetUIActive(true);
			break;
		case 3:
			base.GetItem(7).SetUIActive(true);
			break;
		case 4:
			base.GetItem(6).SetUIActive(true);
			break;
		}
		HonamiStoryModel.Instance.ClearCurLoadingData();
	}

	// Token: 0x0600C6BC RID: 50876 RVA: 0x003B3A82 File Offset: 0x003B1C82
	protected override void OnLevelSequencePlayerBandStateChange(bool state)
	{
		base.PlaySequence("Start", null, false);
	}

	// Token: 0x0600C6BD RID: 50877 RVA: 0x003B3A94 File Offset: 0x003B1C94
	private void OnStartSequenceEvent(string _)
	{
		if (this.LoadingConfig == null || this.LoadingConfig.Value.StartAudioEvent == "")
		{
			return;
		}
		AudioSystem.Instance.PostEvent(this.LoadingConfig.Value.StartAudioEvent);
	}

	// Token: 0x0600C6BE RID: 50878 RVA: 0x003B3AEC File Offset: 0x003B1CEC
	private void OnCloseSequenceEvent(string _)
	{
		if (this.LoadingConfig == null || this.LoadingConfig.Value.EndAudioEvent == "")
		{
			return;
		}
		AudioSystem.Instance.PostEvent(this.LoadingConfig.Value.EndAudioEvent);
	}

	// Token: 0x04007141 RID: 28993
	private HonamiStoryLoadingPerform? LoadingConfig;

	// Token: 0x0200763D RID: 30269
	[NullableContext(0)]
	private enum EHonamiStoryLoadingComponents
	{
		// Token: 0x04026648 RID: 157256
		BgTexture,
		// Token: 0x04026649 RID: 157257
		ProgressText,
		// Token: 0x0402664A RID: 157258
		TitleText,
		// Token: 0x0402664B RID: 157259
		DescText,
		// Token: 0x0402664C RID: 157260
		FxBusFirst,
		// Token: 0x0402664D RID: 157261
		FxBusNormal,
		// Token: 0x0402664E RID: 157262
		FxBusSuccess,
		// Token: 0x0402664F RID: 157263
		FxBusFail
	}
}
