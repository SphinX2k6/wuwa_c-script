using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001B99 RID: 7065
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchRaceCardItem : GridProxyAbstract<FloroRanchRaceData>
{
	// Token: 0x0600D26A RID: 53866 RVA: 0x00305034 File Offset: 0x00303234
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D26B RID: 53867 RVA: 0x00305208 File Offset: 0x00303408
	[NullableContext(1)]
	public override void Refresh(FloroRanchRaceData data, bool isSelected, int gridIndex)
	{
		this.RaceData = data;
		base.SetTextureByPath(data.Icon, base.GetTexture(3), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), data.GetRaceName(), Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), data.GetDesc(), Array.Empty<object>());
		base.GetText(5).bBestFit = false;
		FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(this.ActivityDataType, true);
		bool flag = this.IsFixedRace(data.Id);
		bool flag2 = !activityData.IsRaceUnlocked(data.Id);
		base.GetItem(1).SetUIActive(flag);
		base.GetItem(6).SetUIActive(!flag && flag2);
		base.GetItem(10).SetUIActive(false);
		if (flag)
		{
			this.SetToggleState(true);
		}
		base.GetItem(8).SetUIActive(false);
		if (flag2)
		{
			string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(activityData.GetRaceConditionId(data.Id));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), conditionGroupHintText, Array.Empty<object>());
			return;
		}
		if (this.ActivityDataType == EFloroRanchActivityDataType.Normal && !(LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.FloroRanchRaceRedDot, null) ?? new HashSet<int>()).Contains(data.Id))
		{
			base.GetItem(8).SetUIActive(true);
		}
	}

	// Token: 0x0600D26C RID: 53868 RVA: 0x0030535C File Offset: 0x0030355C
	private void OnClickToggle(EToggleState _)
	{
		FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(this.ActivityDataType, true);
		if (this.ActivityDataType == EFloroRanchActivityDataType.Normal)
		{
			HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.FloroRanchRaceRedDot, null) ?? new HashSet<int>();
			if (activityData.IsRaceUnlocked(this.RaceData.Id) && !hashSet.Contains(this.RaceData.Id))
			{
				hashSet.Add(this.RaceData.Id);
				LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.FloroRanchRaceRedDot, hashSet);
			}
		}
		base.GetItem(8).SetUIActive(false);
		Func<int, bool> isFixedRace = this.IsFixedRace;
		if (isFixedRace != null && isFixedRace(this.RaceData.Id))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("FarmCannotBeModified", Array.Empty<object>());
			this.SetToggleState(true);
			return;
		}
		if (!activityData.IsRaceUnlocked(this.RaceData.Id))
		{
			this.SetToggleState(false);
			return;
		}
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(this.RaceData.Id);
		}
	}

	// Token: 0x0600D26D RID: 53869 RVA: 0x0030545D File Offset: 0x0030365D
	[NullableContext(1)]
	public override object GetKey(FloroRanchRaceData data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x0600D26E RID: 53870 RVA: 0x0030546C File Offset: 0x0030366C
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(9).SetToggleState(state2, false, false, false);
	}

	// Token: 0x0600D26F RID: 53871 RVA: 0x00305493 File Offset: 0x00303693
	public void SetEquippedPanelVisible(bool isShow)
	{
		UUIItem item = base.GetItem(10);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isShow);
	}

	// Token: 0x04006078 RID: 24696
	private FloroRanchRaceData RaceData;

	// Token: 0x04006079 RID: 24697
	public EFloroRanchActivityDataType ActivityDataType;

	// Token: 0x0400607A RID: 24698
	public Func<int, bool> IsFixedRace;

	// Token: 0x0400607B RID: 24699
	public Action<int> OnToggleCallBack;

	// Token: 0x02008135 RID: 33077
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A2C5 RID: 172741
		public const int SpriteSelected = 0;

		// Token: 0x0402A2C6 RID: 172742
		public const int ItemFixedPanel = 1;

		// Token: 0x0402A2C7 RID: 172743
		public const int ItemOptionPanel = 2;

		// Token: 0x0402A2C8 RID: 172744
		public const int TextureIcon = 3;

		// Token: 0x0402A2C9 RID: 172745
		public const int TextName = 4;

		// Token: 0x0402A2CA RID: 172746
		public const int TextDescription = 5;

		// Token: 0x0402A2CB RID: 172747
		public const int ItemLockPanel = 6;

		// Token: 0x0402A2CC RID: 172748
		public const int TextLock = 7;

		// Token: 0x0402A2CD RID: 172749
		public const int ItemRedDot = 8;

		// Token: 0x0402A2CE RID: 172750
		public const int ToggleRoot = 9;

		// Token: 0x0402A2CF RID: 172751
		public const int ItemEquippedPanel = 10;
	}
}
