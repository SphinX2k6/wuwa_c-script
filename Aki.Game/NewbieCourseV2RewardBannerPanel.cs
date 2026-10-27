using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200139D RID: 5021
public class NewbieCourseV2RewardBannerPanel : UiPanelBase
{
	// Token: 0x06008CE5 RID: 36069 RVA: 0x001E3CF0 File Offset: 0x001E1EF0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickWeaponPreview));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008CE6 RID: 36070 RVA: 0x001E3E1A File Offset: 0x001E201A
	public void SetActivityId(int activityId)
	{
		this.ActivityId = activityId;
	}

	// Token: 0x06008CE7 RID: 36071 RVA: 0x001E3E24 File Offset: 0x001E2024
	public void RefreshWeaponPreviewEntrance()
	{
		bool flag = ((this.ActivityId > 0) ? ActivityNewbieCourseV2Config.Instance.GetWeaponPreviewIdsForActivity(this.ActivityId) : Array.Empty<int>()).Length != 0;
		UUIButtonComponent button = base.GetButton(5);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(flag);
			}
		}
		if (button == null)
		{
			return;
		}
		UUIItem uuiitem2 = button.RootUIComp.Get();
		if (uuiitem2 == null)
		{
			return;
		}
		uuiitem2.SetRaycastTarget(flag);
	}

	// Token: 0x06008CE8 RID: 36072 RVA: 0x001E3E9C File Offset: 0x001E209C
	private void OnClickWeaponPreview()
	{
		if (this.ActivityId <= 0)
		{
			return;
		}
		int[] weaponPreviewIdsForActivity = ActivityNewbieCourseV2Config.Instance.GetWeaponPreviewIdsForActivity(this.ActivityId);
		if (weaponPreviewIdsForActivity.Length == 0)
		{
			return;
		}
		List<WeaponTrialData> list = this.BuildWeaponPreviewTrialDataList(weaponPreviewIdsForActivity);
		if (list.Count == 0)
		{
			return;
		}
		WeaponPreviewViewParam weaponPreviewViewParam = new WeaponPreviewViewParam();
		WeaponDataBase[] weaponDataList = list.ToArray();
		weaponPreviewViewParam.WeaponDataList = weaponDataList;
		weaponPreviewViewParam.SelectedIndex = 0;
		WeaponPreviewViewParam param = weaponPreviewViewParam;
		UiManager.Instance.OpenView(EUiViewName.WeaponPreviewView, param, null);
	}

	// Token: 0x06008CE9 RID: 36073 RVA: 0x001E3F08 File Offset: 0x001E2108
	[NullableContext(1)]
	private List<WeaponTrialData> BuildWeaponPreviewTrialDataList(IReadOnlyList<int> previewIds)
	{
		List<WeaponTrialData> list = new List<WeaponTrialData>();
		foreach (int num in previewIds)
		{
			if (num > 0)
			{
				TrialWeaponInfo? trialWeaponConfig = WeaponConfig.Instance.GetTrialWeaponConfig(num);
				if (trialWeaponConfig != null)
				{
					WeaponTrialData weaponTrialData = new WeaponTrialData();
					weaponTrialData.SetTrialId(trialWeaponConfig.Value.Id, true);
					list.Add(weaponTrialData);
				}
			}
		}
		return list;
	}

	// Token: 0x04003E7D RID: 15997
	private int ActivityId;

	// Token: 0x02007A0F RID: 31247
	private static class ERewardBannerComponents
	{
		// Token: 0x040282C5 RID: 164549
		public const int SprIconLock = 0;

		// Token: 0x040282C6 RID: 164550
		public const int SprIcon = 1;

		// Token: 0x040282C7 RID: 164551
		public const int TxtRewardTitle = 2;

		// Token: 0x040282C8 RID: 164552
		public const int TxtRewardDesc = 3;

		// Token: 0x040282C9 RID: 164553
		public const int RedDot = 4;

		// Token: 0x040282CA RID: 164554
		public const int BtnLookA = 5;
	}
}
