using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000761 RID: 1889
[NullableContext(2)]
[Nullable(0)]
public class SevenHillsStageItem : GridProxyAbstract<int>
{
	// Token: 0x060056D2 RID: 22226 RVA: 0x001C7CA0 File Offset: 0x001C5EA0
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

	// Token: 0x060056D3 RID: 22227 RVA: 0x001C7EB8 File Offset: 0x001C60B8
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshStageState));
		this.AddTimer();
	}

	// Token: 0x060056D4 RID: 22228 RVA: 0x001C7EDC File Offset: 0x001C60DC
	private void AddTimer()
	{
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.OnRefreshTimer();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x060056D5 RID: 22229 RVA: 0x001C7F08 File Offset: 0x001C6108
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

	// Token: 0x060056D6 RID: 22230 RVA: 0x001C7F98 File Offset: 0x001C6198
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

	// Token: 0x060056D7 RID: 22231 RVA: 0x001C80D4 File Offset: 0x001C62D4
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

	// Token: 0x060056D8 RID: 22232 RVA: 0x001C81B3 File Offset: 0x001C63B3
	private void OnRefreshTimer()
	{
		this.RefreshLockText();
	}

	// Token: 0x060056D9 RID: 22233 RVA: 0x001C81BC File Offset: 0x001C63BC
	private void OnRefreshStageState(int activityId)
	{
		ActivityLongShanData activityData = this.ActivityData;
		int? num = (activityData != null) ? new int?(activityData.Id) : null;
		if (activityId == num.GetValueOrDefault() & num != null)
		{
			this.RefreshStageState();
		}
	}

	// Token: 0x060056DA RID: 22234 RVA: 0x001C8203 File Offset: 0x001C6403
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshStageState));
		this.RemoveTimer();
	}

	// Token: 0x060056DB RID: 22235 RVA: 0x001C8227 File Offset: 0x001C6427
	private void RemoveTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x060056DC RID: 22236 RVA: 0x001C824C File Offset: 0x001C644C
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

	// Token: 0x060056DD RID: 22237 RVA: 0x001C82C4 File Offset: 0x001C64C4
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

	// Token: 0x04003BBB RID: 15291
	private int StageId;

	// Token: 0x04003BBC RID: 15292
	public ActivityLongShanData ActivityData;

	// Token: 0x04003BBD RID: 15293
	private TimerHandle TimerHandle;

	// Token: 0x04003BBE RID: 15294
	public Action<int> OnClickStageItem;

	// Token: 0x02006A57 RID: 27223
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022FF0 RID: 143344
		public const int BtnRoot = 0;

		// Token: 0x04022FF1 RID: 143345
		public const int TextureImage = 1;

		// Token: 0x04022FF2 RID: 143346
		public const int SpriteRomeNum = 2;

		// Token: 0x04022FF3 RID: 143347
		public const int ItemFinish = 3;

		// Token: 0x04022FF4 RID: 143348
		public const int ItemRedDot = 4;

		// Token: 0x04022FF5 RID: 143349
		public const int SpriteLine = 5;

		// Token: 0x04022FF6 RID: 143350
		public const int TextStageName = 6;

		// Token: 0x04022FF7 RID: 143351
		public const int TextProgress = 7;

		// Token: 0x04022FF8 RID: 143352
		public const int ItemLock = 8;

		// Token: 0x04022FF9 RID: 143353
		public const int BtnGoto = 9;

		// Token: 0x04022FFA RID: 143354
		public const int TextLock = 10;

		// Token: 0x04022FFB RID: 143355
		public const int ItemTimeLock = 11;
	}
}
