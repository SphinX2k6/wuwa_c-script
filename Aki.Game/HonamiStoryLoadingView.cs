using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001ED2 RID: 7890
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryLoadingView : LoadingViewBase
{
	// Token: 0x0600F297 RID: 62103 RVA: 0x003A7B6D File Offset: 0x003A5D6D
	public HonamiStoryLoadingView(UiViewInfo uiViewInfo) : base(uiViewInfo)
	{
	}

	// Token: 0x0600F298 RID: 62104 RVA: 0x003A7B78 File Offset: 0x003A5D78
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

	// Token: 0x0600F299 RID: 62105 RVA: 0x003A7CA8 File Offset: 0x003A5EA8
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

	// Token: 0x0600F29A RID: 62106 RVA: 0x003A7E3A File Offset: 0x003A603A
	protected override void UpdateProgressRate(float rate)
	{
	}

	// Token: 0x0600F29B RID: 62107 RVA: 0x003A7E3C File Offset: 0x003A603C
	protected override void UpdateProgressValue(float value)
	{
		this.SetTextProgressValue(1, value, "");
	}

	// Token: 0x0600F29C RID: 62108 RVA: 0x003A7E4C File Offset: 0x003A604C
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

	// Token: 0x0600F29D RID: 62109 RVA: 0x003A7F82 File Offset: 0x003A6182
	protected override void OnLevelSequencePlayerBandStateChange(bool state)
	{
		base.PlaySequence("Start", null, false);
	}

	// Token: 0x0600F29E RID: 62110 RVA: 0x003A7F94 File Offset: 0x003A6194
	private void OnStartSequenceEvent(string _)
	{
		if (this.LoadingConfig == null || this.LoadingConfig.Value.StartAudioEvent == "")
		{
			return;
		}
		AudioSystem.Instance.PostEvent(this.LoadingConfig.Value.StartAudioEvent);
	}

	// Token: 0x0600F29F RID: 62111 RVA: 0x003A7FEC File Offset: 0x003A61EC
	private void OnCloseSequenceEvent(string _)
	{
		if (this.LoadingConfig == null || this.LoadingConfig.Value.EndAudioEvent == "")
		{
			return;
		}
		AudioSystem.Instance.PostEvent(this.LoadingConfig.Value.EndAudioEvent);
	}

	// Token: 0x04007060 RID: 28768
	private HonamiStoryLoadingPerform? LoadingConfig;

	// Token: 0x020084B8 RID: 33976
	[NullableContext(0)]
	private enum EHonamiStoryLoadingComponents
	{
		// Token: 0x0402B324 RID: 176932
		BgTexture,
		// Token: 0x0402B325 RID: 176933
		ProgressText,
		// Token: 0x0402B326 RID: 176934
		TitleText,
		// Token: 0x0402B327 RID: 176935
		DescText,
		// Token: 0x0402B328 RID: 176936
		FxBusFirst,
		// Token: 0x0402B329 RID: 176937
		FxBusNormal,
		// Token: 0x0402B32A RID: 176938
		FxBusSuccess,
		// Token: 0x0402B32B RID: 176939
		FxBusFail
	}
}
