using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001063 RID: 4195
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchTechNodeItem : UiPanelBase
{
	// Token: 0x0600A6C5 RID: 42693 RVA: 0x00311DFC File Offset: 0x0030FFFC
	public FloroRanchTechNodeItem(UUIItem parent, FloroRanchTechnologyData data, UUIItem gridPanelItem)
	{
		this.Data = data2;
		this.PreItem = parent;
		this.GridPanelItem = gridPanelItem;
	}

	// Token: 0x0600A6C6 RID: 42694 RVA: 0x00311E54 File Offset: 0x00310054
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(10, new Action<EToggleState>(this.OnToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A6C7 RID: 42695 RVA: 0x00312049 File Offset: 0x00310249
	protected override void OnStart()
	{
		base.GetExtendToggle(10).bLockStateOnSelect = true;
	}

	// Token: 0x0600A6C8 RID: 42696 RVA: 0x0031205C File Offset: 0x0031025C
	[NullableContext(2)]
	public void Refresh(FloroRanchTechnologyData data = null)
	{
		FloroRanchTechNodeItem.<>c__DisplayClass9_0 CS$<>8__locals1 = new FloroRanchTechNodeItem.<>c__DisplayClass9_0();
		CS$<>8__locals1.<>4__this = this;
		this.Data = (data ?? this.Data);
		FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true);
		int[] array = this.Data.PreNode ?? Array.Empty<int>();
		CS$<>8__locals1.i = 0;
		while (CS$<>8__locals1.i < array.Length)
		{
			int offset = activityData.GetFloroRanchTechnologyData(array[CS$<>8__locals1.i]).Row - this.Data.Row;
			UUIItem prePosItem = this.GetPrePosItem(offset);
			if (this.LineComponentList.Count <= CS$<>8__locals1.i || this.LineComponentList[CS$<>8__locals1.i] == null)
			{
				UniTask<AActor> task = LguiUtil.Instance.LoadPrefabByResourceIdAsync("UiItem_PastureSkillLine", prePosItem, null, ResourceSystem.EResourceLoadPriority.Default, "js_undefined");
				Func<AActor, UniTask> continuationFunction;
				if ((continuationFunction = CS$<>8__locals1.<>9__0) == null)
				{
					continuationFunction = (CS$<>8__locals1.<>9__0 = delegate(AActor prefab)
					{
						FloroRanchTechNodeItem.<>c__DisplayClass9_0.<<Refresh>b__0>d <<Refresh>b__0>d;
						<<Refresh>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
						<<Refresh>b__0>d.<>4__this = CS$<>8__locals1;
						<<Refresh>b__0>d.prefab = prefab;
						<<Refresh>b__0>d.<>1__state = -1;
						<<Refresh>b__0>d.<>t__builder.Start<FloroRanchTechNodeItem.<>c__DisplayClass9_0.<<Refresh>b__0>d>(ref <<Refresh>b__0>d);
						return <<Refresh>b__0>d.<>t__builder.Task;
					});
				}
				task.ContinueWith(continuationFunction);
			}
			else
			{
				this.LineComponentList[CS$<>8__locals1.i].Refresh(this.Data.IsUnLock);
			}
			int i = CS$<>8__locals1.i;
			CS$<>8__locals1.i = i + 1;
		}
		bool flag = activityData.GetTechnologyCoinNum() >= this.Data.Cost;
		bool flag2 = activityData.IsPreNodeAllUnlock(this.Data);
		this.SetSpriteByPath(this.Data.Icon, base.GetSprite(8), false, null, null);
		this.SetSpriteByPath(this.Data.Icon, base.GetSprite(11), false, null, null);
		base.GetSprite(11).SetUIActive(!this.Data.IsUnLock);
		base.GetSprite(8).SetUIActive(this.Data.IsUnLock);
		base.GetSprite(6).SetUIActive(!this.Data.IsUnLock);
		base.GetSprite(7).SetUIActive(this.Data.IsUnLock);
		base.GetSprite(9).SetUIActive(!this.Data.IsUnLock && flag && flag2);
		if (activityData.GetNextCanUnlockTechId() == this.Data.Id)
		{
			FloroRanchTechnologyView floroRanchTechnologyView = UiManager.Instance.GetViewByName(EUiViewName.FloroRanchTechnologyView) as FloroRanchTechnologyView;
			if (floroRanchTechnologyView != null && (floroRanchTechnologyView.IsShowOrShowing || floroRanchTechnologyView.IsStartOrStarting))
			{
				floroRanchTechnologyView.TrySelectTechNode(this);
			}
		}
	}

	// Token: 0x0600A6C9 RID: 42697 RVA: 0x003122C1 File Offset: 0x003104C1
	public UUIItem GetPrePosItem(int offset)
	{
		if (offset > 0)
		{
			return base.GetItem(2);
		}
		if (offset < 0)
		{
			return base.GetItem(0);
		}
		return base.GetItem(1);
	}

	// Token: 0x0600A6CA RID: 42698 RVA: 0x003122E2 File Offset: 0x003104E2
	private void OnToggleClick(EToggleState _)
	{
		Action<FloroRanchTechNodeItem> onClickCallback = this.OnClickCallback;
		if (onClickCallback == null)
		{
			return;
		}
		onClickCallback(this);
	}

	// Token: 0x0600A6CB RID: 42699 RVA: 0x003122F5 File Offset: 0x003104F5
	public void SetToggleState(EToggleState state)
	{
		base.GetExtendToggle(10).SetToggleState(state, false, false, false);
	}

	// Token: 0x04006164 RID: 24932
	[Nullable(2)]
	public FloroRanchTechnologyData Data;

	// Token: 0x04006165 RID: 24933
	[Nullable(2)]
	public UUIItem PreItem;

	// Token: 0x04006166 RID: 24934
	private List<FloroRanchTechLine> LineComponentList = new List<FloroRanchTechLine>();

	// Token: 0x04006167 RID: 24935
	[Nullable(2)]
	public UUIItem GridPanelItem;

	// Token: 0x04006168 RID: 24936
	public Action<FloroRanchTechNodeItem> OnClickCallback = delegate(FloroRanchTechNodeItem data)
	{
	};

	// Token: 0x020072D1 RID: 29393
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04025641 RID: 153153
		public const int PrePos1 = 0;

		// Token: 0x04025642 RID: 153154
		public const int PrePos2 = 1;

		// Token: 0x04025643 RID: 153155
		public const int PrePos3 = 2;

		// Token: 0x04025644 RID: 153156
		public const int OutPos1 = 3;

		// Token: 0x04025645 RID: 153157
		public const int OutPos2 = 4;

		// Token: 0x04025646 RID: 153158
		public const int OutPos3 = 5;

		// Token: 0x04025647 RID: 153159
		public const int SpriteLock = 6;

		// Token: 0x04025648 RID: 153160
		public const int SpriteUnlock = 7;

		// Token: 0x04025649 RID: 153161
		public const int SpriteIcon = 8;

		// Token: 0x0402564A RID: 153162
		public const int SpriteUp = 9;

		// Token: 0x0402564B RID: 153163
		public const int Toggle = 10;

		// Token: 0x0402564C RID: 153164
		public const int SpriteIconLock = 11;
	}
}
