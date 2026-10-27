using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BA4 RID: 7076
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchTechNodeItem : UiPanelBase
{
	// Token: 0x0600D2B4 RID: 53940 RVA: 0x00306D1C File Offset: 0x00304F1C
	public FloroRanchTechNodeItem(UUIItem parent, FloroRanchTechnologyData data, UUIItem gridPanelItem)
	{
		this.Data = data2;
		this.PreItem = parent;
		this.GridPanelItem = gridPanelItem;
	}

	// Token: 0x0600D2B5 RID: 53941 RVA: 0x00306D74 File Offset: 0x00304F74
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

	// Token: 0x0600D2B6 RID: 53942 RVA: 0x00306F69 File Offset: 0x00305169
	protected override void OnStart()
	{
		base.GetExtendToggle(10).bLockStateOnSelect = true;
	}

	// Token: 0x0600D2B7 RID: 53943 RVA: 0x00306F7C File Offset: 0x0030517C
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

	// Token: 0x0600D2B8 RID: 53944 RVA: 0x003071E1 File Offset: 0x003053E1
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

	// Token: 0x0600D2B9 RID: 53945 RVA: 0x00307202 File Offset: 0x00305402
	private void OnToggleClick(EToggleState _)
	{
		Action<FloroRanchTechNodeItem> onClickCallback = this.OnClickCallback;
		if (onClickCallback == null)
		{
			return;
		}
		onClickCallback(this);
	}

	// Token: 0x0600D2BA RID: 53946 RVA: 0x00307215 File Offset: 0x00305415
	public void SetToggleState(EToggleState state)
	{
		base.GetExtendToggle(10).SetToggleState(state, false, false, false);
	}

	// Token: 0x04006095 RID: 24725
	[Nullable(2)]
	public FloroRanchTechnologyData Data;

	// Token: 0x04006096 RID: 24726
	[Nullable(2)]
	public UUIItem PreItem;

	// Token: 0x04006097 RID: 24727
	private List<FloroRanchTechLine> LineComponentList = new List<FloroRanchTechLine>();

	// Token: 0x04006098 RID: 24728
	[Nullable(2)]
	public UUIItem GridPanelItem;

	// Token: 0x04006099 RID: 24729
	public Action<FloroRanchTechNodeItem> OnClickCallback = delegate(FloroRanchTechNodeItem data)
	{
	};

	// Token: 0x02008143 RID: 33091
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A30D RID: 172813
		public const int PrePos1 = 0;

		// Token: 0x0402A30E RID: 172814
		public const int PrePos2 = 1;

		// Token: 0x0402A30F RID: 172815
		public const int PrePos3 = 2;

		// Token: 0x0402A310 RID: 172816
		public const int OutPos1 = 3;

		// Token: 0x0402A311 RID: 172817
		public const int OutPos2 = 4;

		// Token: 0x0402A312 RID: 172818
		public const int OutPos3 = 5;

		// Token: 0x0402A313 RID: 172819
		public const int SpriteLock = 6;

		// Token: 0x0402A314 RID: 172820
		public const int SpriteUnlock = 7;

		// Token: 0x0402A315 RID: 172821
		public const int SpriteIcon = 8;

		// Token: 0x0402A316 RID: 172822
		public const int SpriteUp = 9;

		// Token: 0x0402A317 RID: 172823
		public const int Toggle = 10;

		// Token: 0x0402A318 RID: 172824
		public const int SpriteIconLock = 11;
	}
}
