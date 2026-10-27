using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F2B RID: 3883
[NullableContext(1)]
[Nullable(0)]
public class AchievementProgressItem : UiPanelBase
{
	// Token: 0x0600626E RID: 25198 RVA: 0x00134240 File Offset: 0x00132440
	public AchievementProgressItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600626F RID: 25199 RVA: 0x00134258 File Offset: 0x00132458
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006270 RID: 25200 RVA: 0x001342E4 File Offset: 0x001324E4
	public void RefreshGroupState(AchievementGroupData data)
	{
		base.GetItem(0).SetUIActive(false);
		base.GetItem(1).SetUIActive(false);
		base.GetText(2).SetUIActive(false);
		if (data.GetFinishState() == EAchievementStateEnum.HaveGetReward)
		{
			base.GetItem(0).SetUIActive(true);
			base.GetText(2).SetUIActive(true);
			base.GetText(2).SetText(TimeUtil.Instance.DateFormat4(new DateTime((data.GetFinishTime() * (long)TimeUtil.Instance.InverseMillisecond).Value)), true);
			return;
		}
		if (data.GetFinishState() == EAchievementStateEnum.UnFinished)
		{
			base.GetItem(1).SetUIActive(true);
		}
	}

	// Token: 0x06006271 RID: 25201 RVA: 0x001343AC File Offset: 0x001325AC
	public void RefreshState(AchievementData data)
	{
		base.GetItem(0).SetUIActive(false);
		base.GetItem(1).SetUIActive(false);
		base.GetText(2).SetUIActive(false);
		if (data.GetFinishState() == EAchievementStateEnum.HaveGetReward)
		{
			base.GetItem(0).SetUIActive(true);
			base.GetText(2).SetUIActive(true);
			return;
		}
		if (data.GetFinishState() == EAchievementStateEnum.UnFinished)
		{
			base.GetItem(1).SetUIActive(true);
		}
	}

	// Token: 0x02007573 RID: 30067
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04026D4F RID: 159055
		FinishIcon,
		// Token: 0x04026D50 RID: 159056
		ProgressingText,
		// Token: 0x04026D51 RID: 159057
		FinishText
	}
}
