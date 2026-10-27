using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020012AD RID: 4781
[NullableContext(2)]
[Nullable(0)]
public class SevenHillsStageItem : GridProxyAbstract<int>
{
	// Token: 0x0600833B RID: 33595 RVA: 0x001BEF10 File Offset: 0x001BD110
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickStageBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickGotoBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600833C RID: 33596 RVA: 0x001BF128 File Offset: 0x001BD328
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshStageState));
		this.AddTimer();
	}

	// Token: 0x0600833D RID: 33597 RVA: 0x001BF14C File Offset: 0x001BD34C
	private void AddTimer()
	{
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.OnRefreshTimer();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x0600833E RID: 33598 RVA: 0x001BF178 File Offset: 0x001BD378
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.StageId = data;
		LongShanStage value = ConfigLongShanStageById.GetConfig(this.StageId, true).Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), value.Title, Array.Empty<object>());
		base.SetTextureByPath(value.Picture, base.GetTexture(1), null, null);
		this.SetSpriteByPath(value.RomeNumSprite, base.GetSprite(2), false, null, null);
		this.RefreshStageState();
		this.RefreshLockText();
	}

	// Token: 0x0600833F RID: 33599 RVA: 0x001BF208 File Offset: 0x001BD408
	private void RefreshStageState()
	{
		bool flag = !this.ActivityData.IsStageUnlock(this.StageId);
		UUIItem item = base.GetItem(8);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		bool flag2 = this.ActivityData.IsStageReachOpenTime(this.StageId);
		UUIButtonComponent button = base.GetButton(9);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(flag && flag2);
		}
		UUIItem item2 = base.GetItem(11);
		if (item2 != null)
		{
			item2.SetUIActive(flag && !flag2);
		}
		int progress = this.ActivityData.GetProgress(this.StageId);
		bool flag3 = progress == 100;
		UUIText text = base.GetText(7);
		if (text != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(progress);
			defaultInterpolatedStringHandler.AppendLiteral("%");
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		UUIItem item3 = base.GetItem(3);
		if (item3 != null)
		{
			item3.SetUIActive(flag3);
		}
		bool useChangeColor = flag || flag3;
		base.GetText(6).useChangeColor = useChangeColor;
		base.GetText(7).useChangeColor = useChangeColor;
		base.GetSprite(5).useChangeColor = useChangeColor;
		UUIItem item4 = base.GetItem(4);
		if (item4 == null)
		{
			return;
		}
		item4.SetUIActive(this.ActivityData.CheckStageRed(this.StageId));
	}

	// Token: 0x06008340 RID: 33600 RVA: 0x001BF344 File Offset: 0x001BD544
	private void RefreshLockText()
	{
		if (this.ActivityData.IsStageUnlock(this.StageId))
		{
			this.RefreshStageState();
			this.RemoveTimer();
			return;
		}
		if (this.ActivityData.IsStageReachOpenTime(this.StageId))
		{
			string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(ConfigLongShanStageById.GetConfig(this.StageId, true).Value.OpenConditionId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), conditionGroupHintText, Array.Empty<object>());
			return;
		}
		ActivityLongShanData activityData = this.ActivityData;
		long endTime = ((activityData != null) ? activityData.GetStageInfoByIdIncludeLock(this.StageId) : null).BeginOpenTime / 1000L;
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("QiqiuTheme_UnlockTime", null);
		string newText = ActivityModel.Instance.GetRemainTimeText(endTime, localTextNew) ?? "";
		UUIText text = base.GetText(10);
		if (text == null)
		{
			return;
		}
		text.SetText(newText, true);
	}

	// Token: 0x06008341 RID: 33601 RVA: 0x001BF423 File Offset: 0x001BD623
	private void OnRefreshTimer()
	{
		this.RefreshLockText();
	}

	// Token: 0x06008342 RID: 33602 RVA: 0x001BF42C File Offset: 0x001BD62C
	private void OnRefreshStageState(int activityId)
	{
		ActivityLongShanData activityData = this.ActivityData;
		int? num = (activityData != null) ? new int?(activityData.Id) : null;
		if (activityId == num.GetValueOrDefault() & num != null)
		{
			this.RefreshStageState();
		}
	}

	// Token: 0x06008343 RID: 33603 RVA: 0x001BF473 File Offset: 0x001BD673
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshStageState));
		this.RemoveTimer();
	}

	// Token: 0x06008344 RID: 33604 RVA: 0x001BF497 File Offset: 0x001BD697
	private void RemoveTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06008345 RID: 33605 RVA: 0x001BF4BC File Offset: 0x001BD6BC
	private void OnClickGotoBtn()
	{
		ActivityLongShanData activityData = this.ActivityData;
		bool? flag = (activityData != null) ? new bool?(activityData.IsStageReachOpenTime(this.StageId)) : null;
		if (flag != null)
		{
			bool? flag2 = flag;
			bool flag3 = false;
			if (!(flag2.GetValueOrDefault() == flag3 & flag2 != null))
			{
				SkipTaskManager.RunByConfigId(ConfigLongShanStageById.GetConfig(this.StageId, true).Value.JumpId, null);
				return;
			}
		}
	}

	// Token: 0x06008346 RID: 33606 RVA: 0x001BF534 File Offset: 0x001BD734
	private void OnClickStageBtn()
	{
		if (!this.ActivityData.IsStageUnlock(this.StageId))
		{
			return;
		}
		Action<int> onClickStageItem = this.OnClickStageItem;
		if (onClickStageItem == null)
		{
			return;
		}
		onClickStageItem(this.StageId);
	}

	// Token: 0x04003B23 RID: 15139
	private int StageId;

	// Token: 0x04003B24 RID: 15140
	public ActivityLongShanData ActivityData;

	// Token: 0x04003B25 RID: 15141
	private TimerHandle TimerHandle;

	// Token: 0x04003B26 RID: 15142
	public Action<int> OnClickStageItem;

	// Token: 0x020078CD RID: 30925
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027CC2 RID: 163010
		public const int BtnRoot = 0;

		// Token: 0x04027CC3 RID: 163011
		public const int TextureImage = 1;

		// Token: 0x04027CC4 RID: 163012
		public const int SpriteRomeNum = 2;

		// Token: 0x04027CC5 RID: 163013
		public const int ItemFinish = 3;

		// Token: 0x04027CC6 RID: 163014
		public const int ItemRedDot = 4;

		// Token: 0x04027CC7 RID: 163015
		public const int SpriteLine = 5;

		// Token: 0x04027CC8 RID: 163016
		public const int TextStageName = 6;

		// Token: 0x04027CC9 RID: 163017
		public const int TextProgress = 7;

		// Token: 0x04027CCA RID: 163018
		public const int ItemLock = 8;

		// Token: 0x04027CCB RID: 163019
		public const int BtnGoto = 9;

		// Token: 0x04027CCC RID: 163020
		public const int TextLock = 10;

		// Token: 0x04027CCD RID: 163021
		public const int ItemTimeLock = 11;
	}
}
