using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013BD RID: 5053
public class HonamiStoryProfitPanel : UiPanelBase
{
	// Token: 0x0600C83E RID: 51262 RVA: 0x003BA020 File Offset: 0x003B8220
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnRewardButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C83F RID: 51263 RVA: 0x003BA0E8 File Offset: 0x003B82E8
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryProfitPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryProfitPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C840 RID: 51264 RVA: 0x003BA12B File Offset: 0x003B832B
	protected override void OnStart()
	{
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600C841 RID: 51265 RVA: 0x003BA15A File Offset: 0x003B835A
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0600C842 RID: 51266 RVA: 0x003BA178 File Offset: 0x003B8378
	[NullableContext(1)]
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "Change")
		{
			int totalRevenue = HonamiStoryModel.Instance.TotalRevenue;
			UUIArtText artText = base.GetArtText(0);
			if (artText != null)
			{
				artText.SetText(totalRevenue.ToString());
			}
			HonamiStoryModel.Instance.LastRecordRevenue = totalRevenue;
		}
	}

	// Token: 0x0600C843 RID: 51267 RVA: 0x003BA1C4 File Offset: 0x003B83C4
	public void Refresh(bool isBtnActive = true)
	{
		int lastRecordRevenue = HonamiStoryModel.Instance.LastRecordRevenue;
		UUIArtText artText = base.GetArtText(0);
		if (artText != null)
		{
			artText.SetText(lastRecordRevenue.ToString());
		}
		this.RefreshRewardButton(isBtnActive);
	}

	// Token: 0x0600C844 RID: 51268 RVA: 0x003BA1FC File Offset: 0x003B83FC
	public void RefreshNormal(bool isBtnActive = true)
	{
		int totalRevenue = HonamiStoryModel.Instance.TotalRevenue;
		UUIArtText artText = base.GetArtText(0);
		if (artText != null)
		{
			artText.SetText(totalRevenue.ToString());
		}
		this.RefreshRewardButton(isBtnActive);
	}

	// Token: 0x0600C845 RID: 51269 RVA: 0x003BA234 File Offset: 0x003B8434
	private void RefreshRewardButton(bool isBtnActive = true)
	{
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
		bool flag = activityData != null && activityData.IsPermanentTaskHasRedDot();
		UUIButtonComponent button = base.GetButton(1);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(flag && isBtnActive);
	}

	// Token: 0x0600C846 RID: 51270 RVA: 0x003BA27C File Offset: 0x003B847C
	public void PlayChangeSequence()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600C847 RID: 51271 RVA: 0x003BA2A9 File Offset: 0x003B84A9
	private void OnRewardButtonClick()
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryPermanentTaskView, null, null);
	}

	// Token: 0x040071E5 RID: 29157
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0200767E RID: 30334
	private enum EHonamiStoryProfitPanelComponent
	{
		// Token: 0x04026780 RID: 157568
		TotalProfitText,
		// Token: 0x04026781 RID: 157569
		RewardButton,
		// Token: 0x04026782 RID: 157570
		RedDotItem
	}
}
