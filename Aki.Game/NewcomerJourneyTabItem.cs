using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200085D RID: 2141
[NullableContext(1)]
[Nullable(0)]
public class NewcomerJourneyTabItem : GridProxyAbstract<AdventureTaskChapterV2>
{
	// Token: 0x060060E6 RID: 24806 RVA: 0x001EEED8 File Offset: 0x001ED0D8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060060E7 RID: 24807 RVA: 0x001EEFE1 File Offset: 0x001ED1E1
	public void SetActivityData(ActivityNewcomerJourneyData data)
	{
		this.ActivityData = data;
	}

	// Token: 0x060060E8 RID: 24808 RVA: 0x001EEFEC File Offset: 0x001ED1EC
	public override void Refresh(AdventureTaskChapterV2 config, bool isSelected, int gridIndex)
	{
		this.Config = new AdventureTaskChapterV2?(config);
		base.GridIndex = gridIndex;
		if (this.ActivityData == null)
		{
			return;
		}
		bool chapterHasReward = this.ActivityData.GetChapterHasReward(config.Id);
		base.GetItem(3).SetUIActive(chapterHasReward);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), config.Name, Array.Empty<object>());
		EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleStateForce(state, false, false, false);
		}
		bool chapterIsLock = this.ActivityData.GetChapterIsLock(config.Id);
		bool chapterTaskAllComplete = this.ActivityData.GetChapterTaskAllComplete(config.Id);
		bool chapterRewardHasGet = this.ActivityData.GetChapterRewardHasGet(config.Id);
		UUISprite sprite = base.GetSprite(2);
		sprite.SetUIActive(chapterIsLock || chapterTaskAllComplete);
		if (chapterIsLock || (chapterTaskAllComplete && chapterRewardHasGet))
		{
			string resourceId = chapterIsLock ? "SP_TabLock" : "SP_TabFinish";
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			if (!string.IsNullOrEmpty(resourcePath))
			{
				base.TrySetSpriteByPath(resourcePath, sprite, false, null, null);
			}
		}
	}

	// Token: 0x060060E9 RID: 24809 RVA: 0x001EF104 File Offset: 0x001ED304
	public void SetBtnClickCallback(Action<AdventureTaskChapterV2, int> callback)
	{
		this.BtnClickCb = callback;
	}

	// Token: 0x060060EA RID: 24810 RVA: 0x001EF10D File Offset: 0x001ED30D
	private void OnClickButton(EToggleState state)
	{
		Action<AdventureTaskChapterV2, int> btnClickCb = this.BtnClickCb;
		if (btnClickCb == null)
		{
			return;
		}
		btnClickCb(this.Config.Value, base.GridIndex);
	}

	// Token: 0x060060EB RID: 24811 RVA: 0x001EF130 File Offset: 0x001ED330
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x060060EC RID: 24812 RVA: 0x001EF143 File Offset: 0x001ED343
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04003F55 RID: 16213
	private const string NEWCOMER_TAB_LOCKED_RESOURCE_ID = "SP_TabLock";

	// Token: 0x04003F56 RID: 16214
	private const string NEWCOMER_TAB_FINISH_RESOURCE_ID = "SP_TabFinish";

	// Token: 0x04003F57 RID: 16215
	protected AdventureTaskChapterV2? Config;

	// Token: 0x04003F58 RID: 16216
	[Nullable(2)]
	protected ActivityNewcomerJourneyData ActivityData;

	// Token: 0x04003F59 RID: 16217
	[Nullable(2)]
	private Action<AdventureTaskChapterV2, int> BtnClickCb;

	// Token: 0x02006BA0 RID: 27552
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023622 RID: 144930
		public const int ClickToggle = 0;

		// Token: 0x04023623 RID: 144931
		public const int ShowText = 1;

		// Token: 0x04023624 RID: 144932
		public const int StateIcon = 2;

		// Token: 0x04023625 RID: 144933
		public const int RedDotItem = 3;

		// Token: 0x04023626 RID: 144934
		public const int SelectBg = 4;
	}
}
