using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020013A9 RID: 5033
[NullableContext(1)]
[Nullable(0)]
public class NewcomerJourneyTabItem : GridProxyAbstract<AdventureTaskChapterV2>
{
	// Token: 0x06008D50 RID: 36176 RVA: 0x001E62A4 File Offset: 0x001E44A4
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

	// Token: 0x06008D51 RID: 36177 RVA: 0x001E63AD File Offset: 0x001E45AD
	public void SetActivityData(ActivityNewcomerJourneyData data)
	{
		this.ActivityData = data;
	}

	// Token: 0x06008D52 RID: 36178 RVA: 0x001E63B8 File Offset: 0x001E45B8
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

	// Token: 0x06008D53 RID: 36179 RVA: 0x001E64D0 File Offset: 0x001E46D0
	public void SetBtnClickCallback(Action<AdventureTaskChapterV2, int> callback)
	{
		this.BtnClickCb = callback;
	}

	// Token: 0x06008D54 RID: 36180 RVA: 0x001E64D9 File Offset: 0x001E46D9
	private void OnClickButton(EToggleState state)
	{
		Action<AdventureTaskChapterV2, int> btnClickCb = this.BtnClickCb;
		if (btnClickCb == null)
		{
			return;
		}
		btnClickCb(this.Config.Value, base.GridIndex);
	}

	// Token: 0x06008D55 RID: 36181 RVA: 0x001E64FC File Offset: 0x001E46FC
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06008D56 RID: 36182 RVA: 0x001E650F File Offset: 0x001E470F
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04003EBD RID: 16061
	private const string NEWCOMER_TAB_LOCKED_RESOURCE_ID = "SP_TabLock";

	// Token: 0x04003EBE RID: 16062
	private const string NEWCOMER_TAB_FINISH_RESOURCE_ID = "SP_TabFinish";

	// Token: 0x04003EBF RID: 16063
	protected AdventureTaskChapterV2? Config;

	// Token: 0x04003EC0 RID: 16064
	[Nullable(2)]
	protected ActivityNewcomerJourneyData ActivityData;

	// Token: 0x04003EC1 RID: 16065
	[Nullable(2)]
	private Action<AdventureTaskChapterV2, int> BtnClickCb;

	// Token: 0x02007A19 RID: 31257
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04028302 RID: 164610
		public const int ClickToggle = 0;

		// Token: 0x04028303 RID: 164611
		public const int ShowText = 1;

		// Token: 0x04028304 RID: 164612
		public const int StateIcon = 2;

		// Token: 0x04028305 RID: 164613
		public const int RedDotItem = 3;

		// Token: 0x04028306 RID: 164614
		public const int SelectBg = 4;
	}
}
