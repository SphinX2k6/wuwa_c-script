using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001171 RID: 4465
public class BabelTowerItemInfoView : UiViewBase
{
	// Token: 0x060075DF RID: 30175 RVA: 0x00185CCA File Offset: 0x00183ECA
	[NullableContext(1)]
	public BabelTowerItemInfoView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060075E0 RID: 30176 RVA: 0x00185CD4 File Offset: 0x00183ED4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 14;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBackBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnClickBackBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060075E1 RID: 30177 RVA: 0x00185F30 File Offset: 0x00184130
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollViewNew<JumpToItem, IJumpToItemData>(base.GetScrollViewWithScrollbar(9), new Func<JumpToItem>(this.InitItem), null, false, null);
	}

	// Token: 0x060075E2 RID: 30178 RVA: 0x00185F54 File Offset: 0x00184154
	protected override void OnBeforeShow()
	{
		IBabelTowerItemInfoViewInfo babelTowerItemInfoViewInfo = this.OpenParam as IBabelTowerItemInfoViewInfo;
		this.Data = babelTowerItemInfoViewInfo;
		base.GetItem(1).SetUIActive(babelTowerItemInfoViewInfo.IsDeTerm);
		base.GetItem(2).SetUIActive(!babelTowerItemInfoViewInfo.IsDeTerm);
		if (babelTowerItemInfoViewInfo.IsDeTerm)
		{
			this.RefreshViewByDeTerm();
			return;
		}
		this.RefreshViewByBuff();
	}

	// Token: 0x060075E3 RID: 30179 RVA: 0x00185FB0 File Offset: 0x001841B0
	private void RefreshViewByDeTerm()
	{
		IBabelTowerItemInfoViewInfo data = this.Data;
		BabelTowerDeTerm babelTowerDeTerm = BabelTowerConfig.Instance.GetBabelTowerDeTerm(data.ConfigId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), babelTowerDeTerm.NameText, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), babelTowerDeTerm.DesText, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "BabelTowerUnlockTtitleDebuff", Array.Empty<object>());
		UUISprite sprite = base.GetSprite(11);
		UUIItem uuiitem = sprite;
		bool bUseChangeColor = false;
		FColor? fcolor = new FColor?(sprite.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		base.SetTextureByPath(babelTowerDeTerm.Texture, base.GetTexture(3), null, null);
		base.GetText(4).SetText(babelTowerDeTerm.Star.ToString() ?? "", true);
		base.GetItem(8).SetUIActive(data.ShowWays);
		if (!data.ShowWays)
		{
			return;
		}
		List<IJumpToItemData> list = new List<IJumpToItemData>();
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		for (int i = 0; i < babelTowerDeTerm.DifficultPreLevelStarLength; i++)
		{
			DicIntInt? dicIntInt = babelTowerDeTerm.DifficultPreLevelStar(i);
			if (dicIntInt != null)
			{
				int key = dicIntInt.Value.Key;
				int value = dicIntInt.Value.Value;
				double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
				BabelActivityLevelInfo babelActivityLevelInfo;
				(BabelTowerConfig.Instance.GetBabelTowerLevelConfig(key).IsDifficult ? babelTowerData.HardLevelDataMap : babelTowerData.NormalLevelDataMap).TryGetValue(key, out babelActivityLevelInfo);
				long num = MathUtils.Instance.LongToNumber((babelActivityLevelInfo != null) ? babelActivityLevelInfo.UnlockTime : 0L);
				bool isUnlock = num <= 0L || (double)num <= serverTimeStamp;
				list.Add(new JumpToItemData
				{
					LevelId = key,
					Done = (babelActivityLevelInfo != null && babelActivityLevelInfo.IsFinished && ((babelActivityLevelInfo != null) ? babelActivityLevelInfo.MaxPassStar : 0) >= value),
					IsUnlock = isUnlock,
					StarNumber = value
				});
			}
		}
		GenericScrollViewNew<JumpToItem, IJumpToItemData> scrollView = this.ScrollView;
		if (scrollView == null)
		{
			return;
		}
		scrollView.RefreshByData(list, null, false);
	}

	// Token: 0x060075E4 RID: 30180 RVA: 0x001861E4 File Offset: 0x001843E4
	private void RefreshViewByBuff()
	{
		IBabelTowerItemInfoViewInfo data = this.Data;
		BabelTowerBuff babelTowerBuff = BabelTowerConfig.Instance.GetBabelTowerBuff(data.ConfigId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), babelTowerBuff.NameText, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), babelTowerBuff.DesText, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "BabelTowerUnlockTtitlebuff", Array.Empty<object>());
		UUISprite sprite = base.GetSprite(11);
		UUIItem uuiitem = sprite;
		bool bUseChangeColor = true;
		FColor? fcolor = new FColor?(sprite.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		base.SetTextureByPath(babelTowerBuff.Texture, base.GetTexture(5), null, null);
		base.GetItem(8).SetUIActive(data.ShowWays);
		if (!data.ShowWays)
		{
			return;
		}
		List<IJumpToItemData> list = new List<IJumpToItemData>();
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		for (int i = 0; i < babelTowerBuff.DifficultPreLevelStarLength; i++)
		{
			DicIntInt? dicIntInt = babelTowerBuff.DifficultPreLevelStar(i);
			if (dicIntInt != null)
			{
				int key = dicIntInt.Value.Key;
				int value = dicIntInt.Value.Value;
				double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
				BabelActivityLevelInfo babelActivityLevelInfo;
				(BabelTowerConfig.Instance.GetBabelTowerLevelConfig(key).IsDifficult ? babelTowerData.HardLevelDataMap : babelTowerData.NormalLevelDataMap).TryGetValue(key, out babelActivityLevelInfo);
				long num = MathUtils.Instance.LongToNumber((babelActivityLevelInfo != null) ? babelActivityLevelInfo.UnlockTime : 0L);
				bool isUnlock = num <= 0L || (double)num <= serverTimeStamp;
				list.Add(new JumpToItemData
				{
					LevelId = key,
					Done = (babelActivityLevelInfo != null && babelActivityLevelInfo.IsFinished && ((babelActivityLevelInfo != null) ? babelActivityLevelInfo.MaxPassStar : 0) >= value),
					IsUnlock = isUnlock,
					StarNumber = value
				});
			}
		}
		GenericScrollViewNew<JumpToItem, IJumpToItemData> scrollView = this.ScrollView;
		if (scrollView == null)
		{
			return;
		}
		scrollView.RefreshByData(list, null, false);
	}

	// Token: 0x060075E5 RID: 30181 RVA: 0x001863EF File Offset: 0x001845EF
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x060075E6 RID: 30182 RVA: 0x001863F8 File Offset: 0x001845F8
	private void OnClickJumpTo(int levelId)
	{
		base.CloseMe(null);
		BabelTowerModel.Instance.LevelChoseHandle = levelId;
		if (BabelTowerConfig.Instance.GetBabelTowerLevelConfig(levelId).IsDifficult)
		{
			if (UiManager.Instance.IsViewHide(EUiViewName.BabelTowerHardLevelChoseView))
			{
				UiManager.Instance.NormalResetToView(EUiViewName.BabelTowerHardLevelChoseView, null, true);
				return;
			}
			UiManager.Instance.NormalResetToView(EUiViewName.BabelTowerMainView, delegate(bool _)
			{
				UiManager.Instance.OpenView(EUiViewName.BabelTowerHardLevelChoseView, null, null);
			}, true);
			return;
		}
		else
		{
			if (UiManager.Instance.IsViewHide(EUiViewName.BabelTowerNormalLevelChoseView))
			{
				UiManager.Instance.NormalResetToView(EUiViewName.BabelTowerNormalLevelChoseView, null, true);
				return;
			}
			UiManager.Instance.NormalResetToView(EUiViewName.BabelTowerMainView, delegate(bool _)
			{
				UiManager.Instance.OpenView(EUiViewName.BabelTowerNormalLevelChoseView, null, null);
			}, true);
			return;
		}
	}

	// Token: 0x060075E7 RID: 30183 RVA: 0x001864D1 File Offset: 0x001846D1
	[NullableContext(1)]
	private JumpToItem InitItem()
	{
		return new JumpToItem
		{
			OnClickButtonCallBack = new Action<int>(this.OnClickJumpTo)
		};
	}

	// Token: 0x04003616 RID: 13846
	[Nullable(2)]
	private IBabelTowerItemInfoViewInfo Data;

	// Token: 0x04003617 RID: 13847
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<JumpToItem, IJumpToItemData> ScrollView;

	// Token: 0x02007741 RID: 30529
	private class EComponentDefine
	{
		// Token: 0x0402755B RID: 161115
		public const int BackBtn = 0;

		// Token: 0x0402755C RID: 161116
		public const int DeTermItem = 1;

		// Token: 0x0402755D RID: 161117
		public const int BuffItem = 2;

		// Token: 0x0402755E RID: 161118
		public const int DeTermTexture = 3;

		// Token: 0x0402755F RID: 161119
		public const int DeTermStarText = 4;

		// Token: 0x04027560 RID: 161120
		public const int BuffTexture = 5;

		// Token: 0x04027561 RID: 161121
		public const int TitleText = 6;

		// Token: 0x04027562 RID: 161122
		public const int DesText = 7;

		// Token: 0x04027563 RID: 161123
		public const int JumpToItem = 8;

		// Token: 0x04027564 RID: 161124
		public const int JumpToScrollView = 9;

		// Token: 0x04027565 RID: 161125
		public const int JumpToBtn = 10;

		// Token: 0x04027566 RID: 161126
		public const int NameSprite = 11;

		// Token: 0x04027567 RID: 161127
		public const int NameText = 12;

		// Token: 0x04027568 RID: 161128
		public const int ExitBtn = 13;
	}
}
