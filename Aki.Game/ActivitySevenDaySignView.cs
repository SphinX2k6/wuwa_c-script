using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001686 RID: 5766
public class ActivitySevenDaySignView : ActivitySubViewBase
{
	// Token: 0x0600A357 RID: 41815 RVA: 0x00242368 File Offset: 0x00240568
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickLook));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A358 RID: 41816 RVA: 0x0024253C File Offset: 0x0024073C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySevenDaySignView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySevenDaySignView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A359 RID: 41817 RVA: 0x00242580 File Offset: 0x00240780
	protected override void OnBeforeShow()
	{
		foreach (SignRewardItemBase child in this.ItemList)
		{
			base.AddChild(child);
		}
	}

	// Token: 0x0600A35A RID: 41818 RVA: 0x002425AD File Offset: 0x002407AD
	protected override void OnSetData()
	{
		this.ActivitySignData = (this.ActivityBaseData as ActivitySevenDaySignData);
	}

	// Token: 0x0600A35B RID: 41819 RVA: 0x002425C0 File Offset: 0x002407C0
	protected override void OnTimer(float gap)
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		base.GetText(1).SetUIActive(item);
		if (item)
		{
			base.GetText(1).SetText(item2, true);
		}
	}

	// Token: 0x0600A35C RID: 41820 RVA: 0x00242600 File Offset: 0x00240800
	protected override void OnBeforeDestroy()
	{
		foreach (SignRewardItemBase child in this.ItemList)
		{
			base.AddChild(child);
		}
	}

	// Token: 0x0600A35D RID: 41821 RVA: 0x00242630 File Offset: 0x00240830
	[NullableContext(1)]
	private string GetDesc()
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.ActivitySignData.LocalConfig.Value.Desc, null);
	}

	// Token: 0x0600A35E RID: 41822 RVA: 0x0024265B File Offset: 0x0024085B
	protected override void OnRefreshView()
	{
		base.GetText(0).SetText(this.ActivitySignData.GetTitle(), true);
		base.GetText(2).SetText(this.GetDesc(), true);
		this.RefreshReward();
	}

	// Token: 0x0600A35F RID: 41823 RVA: 0x00242690 File Offset: 0x00240890
	private void RefreshReward()
	{
		this.OnTimer(1f);
		for (int i = 0; i < 7; i++)
		{
			OneItemConfig[] rewardByDay = this.ActivitySignData.GetRewardByDay(i);
			SignState? rewardStateByDay = this.ActivitySignData.GetRewardStateByDay(i);
			OneItemConfig data = rewardByDay[0];
			SignRewardItemBase signRewardItemBase = this.ItemList[i];
			if (signRewardItemBase != null)
			{
				signRewardItemBase.RefreshByData(data, rewardStateByDay.Value, i);
			}
		}
		bool flag = this.ActivitySignData.GetImportantRewardType() != 0;
		UUIButtonComponent button = base.GetButton(3);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(flag);
		}
		UUIButtonComponent button2 = base.GetButton(3);
		if (button2 == null)
		{
			return;
		}
		button2.RootUIComp.Get().SetRaycastTarget(flag);
	}

	// Token: 0x0600A360 RID: 41824 RVA: 0x00242744 File Offset: 0x00240944
	private bool IsRewardCanGet(int day)
	{
		return this.ActivitySignData.GetRewardStateByDay(day).GetValueOrDefault() == SignState.Unlock;
	}

	// Token: 0x0600A361 RID: 41825 RVA: 0x00242768 File Offset: 0x00240968
	private void OnClickToGetReward(int index)
	{
		if (this.IsRewardCanGet(index))
		{
			ActivitySevenDaySignController.Instance.GetRewardByDay(this.ActivitySignData.Id, index);
			return;
		}
		if (index == this.ActivitySignData.GetImportantItemIndex())
		{
			this.OnClickLook();
		}
	}

	// Token: 0x0600A362 RID: 41826 RVA: 0x002427A0 File Offset: 0x002409A0
	private void OnClickLook()
	{
		ActivitySign? activitySignById = ActivitySevenDaySignConfig.Instance.GetActivitySignById(this.ActivitySignData.Id);
		int importantRewardType = activitySignById.Value.ImportantRewardType;
		if (importantRewardType == 1)
		{
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, 0, activitySignById.Value.PreviewListIter().ToList<int>(), null, null);
			return;
		}
		if (importantRewardType != 2)
		{
			return;
		}
		List<WeaponTrialData> list = new List<WeaponTrialData>();
		foreach (int trialId in activitySignById.Value.PreviewList())
		{
			WeaponTrialData weaponTrialData = new WeaponTrialData();
			weaponTrialData.SetTrialId(trialId, true);
			list.Add(weaponTrialData);
		}
		WeaponPreviewViewParam weaponPreviewViewParam = new WeaponPreviewViewParam();
		WeaponDataBase[] weaponDataList = list.ToArray();
		weaponPreviewViewParam.WeaponDataList = weaponDataList;
		weaponPreviewViewParam.SelectedIndex = 0;
		WeaponPreviewViewParam param = weaponPreviewViewParam;
		UiManager.Instance.OpenView(EUiViewName.WeaponPreviewView, param, null);
	}

	// Token: 0x04004A3B RID: 19003
	private const int ITEM_START_INDEX = 4;

	// Token: 0x04004A3C RID: 19004
	private const int SIGN_DAY_COUNT = 7;

	// Token: 0x04004A3D RID: 19005
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private SignRewardItemBase[] ItemList;

	// Token: 0x04004A3E RID: 19006
	[Nullable(2)]
	private ActivitySevenDaySignData ActivitySignData;

	// Token: 0x02007C51 RID: 31825
	private class EMainSignInComponents
	{
		// Token: 0x04028CAE RID: 167086
		public const int TxtTitle = 0;

		// Token: 0x04028CAF RID: 167087
		public const int TxtTime = 1;

		// Token: 0x04028CB0 RID: 167088
		public const int TxtInfo = 2;

		// Token: 0x04028CB1 RID: 167089
		public const int BtnLook = 3;

		// Token: 0x04028CB2 RID: 167090
		public const int ItemOne = 4;

		// Token: 0x04028CB3 RID: 167091
		public const int ItemTwo = 5;

		// Token: 0x04028CB4 RID: 167092
		public const int ItemThree = 6;

		// Token: 0x04028CB5 RID: 167093
		public const int ItemFour = 7;

		// Token: 0x04028CB6 RID: 167094
		public const int ItemFive = 8;

		// Token: 0x04028CB7 RID: 167095
		public const int ItemSix = 9;

		// Token: 0x04028CB8 RID: 167096
		public const int ItemSeven = 10;
	}
}
