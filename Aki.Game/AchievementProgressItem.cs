using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020003E0 RID: 992
[NullableContext(1)]
[Nullable(0)]
public class AchievementProgressItem : UiPanelBase
{
	// Token: 0x06003606 RID: 13830 RVA: 0x0013CB68 File Offset: 0x0013AD68
	public AchievementProgressItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06003607 RID: 13831 RVA: 0x0013CB80 File Offset: 0x0013AD80
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

	// Token: 0x06003608 RID: 13832 RVA: 0x0013CC0C File Offset: 0x0013AE0C
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

	// Token: 0x06003609 RID: 13833 RVA: 0x0013CCD4 File Offset: 0x0013AED4
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

	// Token: 0x02006707 RID: 26375
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402209A RID: 139418
		FinishIcon,
		// Token: 0x0402209B RID: 139419
		ProgressingText,
		// Token: 0x0402209C RID: 139420
		FinishText
	}
}
