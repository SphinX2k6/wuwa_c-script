using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000B3E RID: 2878
public class ActivitySevenDaySignView : ActivitySubViewBase
{
	// Token: 0x06007734 RID: 30516 RVA: 0x0024C3D0 File Offset: 0x0024A5D0
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

	// Token: 0x06007735 RID: 30517 RVA: 0x0024C5A4 File Offset: 0x0024A7A4
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySevenDaySignView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySevenDaySignView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007736 RID: 30518 RVA: 0x0024C5E8 File Offset: 0x0024A7E8
	protected override void OnBeforeShow()
	{
		foreach (SignRewardItemBase child in this.ItemList)
		{
			base.AddChild(child);
		}
	}

	// Token: 0x06007737 RID: 30519 RVA: 0x0024C615 File Offset: 0x0024A815
	protected override void OnSetData()
	{
		this.ActivitySignData = (this.ActivityBaseData as ActivitySevenDaySignData);
	}

	// Token: 0x06007738 RID: 30520 RVA: 0x0024C628 File Offset: 0x0024A828
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

	// Token: 0x06007739 RID: 30521 RVA: 0x0024C668 File Offset: 0x0024A868
	protected override void OnBeforeDestroy()
	{
		foreach (SignRewardItemBase child in this.ItemList)
		{
			base.AddChild(child);
		}
	}

	// Token: 0x0600773A RID: 30522 RVA: 0x0024C698 File Offset: 0x0024A898
	[NullableContext(1)]
	private string GetDesc()
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.ActivitySignData.LocalConfig.Value.Desc, null);
	}

	// Token: 0x0600773B RID: 30523 RVA: 0x0024C6C3 File Offset: 0x0024A8C3
	protected override void OnRefreshView()
	{
		base.GetText(0).SetText(this.ActivitySignData.GetTitle(), true);
		base.GetText(2).SetText(this.GetDesc(), true);
		this.RefreshReward();
	}

	// Token: 0x0600773C RID: 30524 RVA: 0x0024C6F8 File Offset: 0x0024A8F8
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

	// Token: 0x0600773D RID: 30525 RVA: 0x0024C7AC File Offset: 0x0024A9AC
	private bool IsRewardCanGet(int day)
	{
		return this.ActivitySignData.GetRewardStateByDay(day).GetValueOrDefault() == SignState.Unlock;
	}

	// Token: 0x0600773E RID: 30526 RVA: 0x0024C7D0 File Offset: 0x0024A9D0
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

	// Token: 0x0600773F RID: 30527 RVA: 0x0024C808 File Offset: 0x0024AA08
	private void OnClickLook()
	{
		ActivitySign? activitySignById = ActivitySevenDaySignConfig.Instance.GetActivitySignById(this.ActivitySignData.Id);
		int importantRewardType = activitySignById.Value.ImportantRewardType;
		if (importantRewardType == 1)
		{
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, 0, new List<int>(activitySignById.Value.PreviewListIter()), null, null);
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

	// Token: 0x04004AE2 RID: 19170
	private const int ITEM_START_INDEX = 4;

	// Token: 0x04004AE3 RID: 19171
	private const int SIGN_DAY_COUNT = 7;

	// Token: 0x04004AE4 RID: 19172
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private SignRewardItemBase[] ItemList;

	// Token: 0x04004AE5 RID: 19173
	[Nullable(2)]
	private ActivitySevenDaySignData ActivitySignData;

	// Token: 0x02006DD6 RID: 28118
	private class EMainSignInComponents
	{
		// Token: 0x04023FD8 RID: 147416
		public const int TxtTitle = 0;

		// Token: 0x04023FD9 RID: 147417
		public const int TxtTime = 1;

		// Token: 0x04023FDA RID: 147418
		public const int TxtInfo = 2;

		// Token: 0x04023FDB RID: 147419
		public const int BtnLook = 3;

		// Token: 0x04023FDC RID: 147420
		public const int ItemOne = 4;

		// Token: 0x04023FDD RID: 147421
		public const int ItemTwo = 5;

		// Token: 0x04023FDE RID: 147422
		public const int ItemThree = 6;

		// Token: 0x04023FDF RID: 147423
		public const int ItemFour = 7;

		// Token: 0x04023FE0 RID: 147424
		public const int ItemFive = 8;

		// Token: 0x04023FE1 RID: 147425
		public const int ItemSix = 9;

		// Token: 0x04023FE2 RID: 147426
		public const int ItemSeven = 10;
	}
}
