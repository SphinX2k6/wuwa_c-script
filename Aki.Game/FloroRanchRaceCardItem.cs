using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001058 RID: 4184
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchRaceCardItem : GridProxyAbstract<FloroRanchRaceData>
{
	// Token: 0x0600A67B RID: 42619 RVA: 0x0031010C File Offset: 0x0030E30C
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

	// Token: 0x0600A67C RID: 42620 RVA: 0x003102E0 File Offset: 0x0030E4E0
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

	// Token: 0x0600A67D RID: 42621 RVA: 0x00310434 File Offset: 0x0030E634
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

	// Token: 0x0600A67E RID: 42622 RVA: 0x00310535 File Offset: 0x0030E735
	[NullableContext(1)]
	public override object GetKey(FloroRanchRaceData data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x0600A67F RID: 42623 RVA: 0x00310544 File Offset: 0x0030E744
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(9).SetToggleState(state2, false, false, false);
	}

	// Token: 0x0600A680 RID: 42624 RVA: 0x0031056B File Offset: 0x0030E76B
	public void SetEquippedPanelVisible(bool isShow)
	{
		UUIItem item = base.GetItem(10);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isShow);
	}

	// Token: 0x04006147 RID: 24903
	private FloroRanchRaceData RaceData;

	// Token: 0x04006148 RID: 24904
	public EFloroRanchActivityDataType ActivityDataType;

	// Token: 0x04006149 RID: 24905
	public Func<int, bool> IsFixedRace;

	// Token: 0x0400614A RID: 24906
	public Action<int> OnToggleCallBack;

	// Token: 0x020072C3 RID: 29379
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040255F9 RID: 153081
		public const int SpriteSelected = 0;

		// Token: 0x040255FA RID: 153082
		public const int ItemFixedPanel = 1;

		// Token: 0x040255FB RID: 153083
		public const int ItemOptionPanel = 2;

		// Token: 0x040255FC RID: 153084
		public const int TextureIcon = 3;

		// Token: 0x040255FD RID: 153085
		public const int TextName = 4;

		// Token: 0x040255FE RID: 153086
		public const int TextDescription = 5;

		// Token: 0x040255FF RID: 153087
		public const int ItemLockPanel = 6;

		// Token: 0x04025600 RID: 153088
		public const int TextLock = 7;

		// Token: 0x04025601 RID: 153089
		public const int ItemRedDot = 8;

		// Token: 0x04025602 RID: 153090
		public const int ToggleRoot = 9;

		// Token: 0x04025603 RID: 153091
		public const int ItemEquippedPanel = 10;
	}
}
