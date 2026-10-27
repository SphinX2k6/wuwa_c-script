using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001EFB RID: 7931
public class HonamiStoryProfitPanel : UiPanelBase
{
	// Token: 0x0600F41F RID: 62495 RVA: 0x003AE52C File Offset: 0x003AC72C
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

	// Token: 0x0600F420 RID: 62496 RVA: 0x003AE5F4 File Offset: 0x003AC7F4
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryProfitPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryProfitPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F421 RID: 62497 RVA: 0x003AE637 File Offset: 0x003AC837
	protected override void OnStart()
	{
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600F422 RID: 62498 RVA: 0x003AE666 File Offset: 0x003AC866
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0600F423 RID: 62499 RVA: 0x003AE684 File Offset: 0x003AC884
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

	// Token: 0x0600F424 RID: 62500 RVA: 0x003AE6D0 File Offset: 0x003AC8D0
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

	// Token: 0x0600F425 RID: 62501 RVA: 0x003AE708 File Offset: 0x003AC908
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

	// Token: 0x0600F426 RID: 62502 RVA: 0x003AE740 File Offset: 0x003AC940
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

	// Token: 0x0600F427 RID: 62503 RVA: 0x003AE788 File Offset: 0x003AC988
	public void PlayChangeSequence()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600F428 RID: 62504 RVA: 0x003AE7B5 File Offset: 0x003AC9B5
	private void OnRewardButtonClick()
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryPermanentTaskView, null, null);
	}

	// Token: 0x04007104 RID: 28932
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x020084F9 RID: 34041
	private enum EHonamiStoryProfitPanelComponent
	{
		// Token: 0x0402B45C RID: 177244
		TotalProfitText,
		// Token: 0x0402B45D RID: 177245
		RewardButton,
		// Token: 0x0402B45E RID: 177246
		RedDotItem
	}
}
