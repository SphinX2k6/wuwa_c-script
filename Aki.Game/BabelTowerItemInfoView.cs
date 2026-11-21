using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000625 RID: 1573
public class BabelTowerItemInfoView : UiViewBase
{
	// Token: 0x06004976 RID: 18806 RVA: 0x0018E872 File Offset: 0x0018CA72
	[NullableContext(1)]
	public BabelTowerItemInfoView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06004977 RID: 18807 RVA: 0x0018E87C File Offset: 0x0018CA7C
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

	// Token: 0x06004978 RID: 18808 RVA: 0x0018EAD8 File Offset: 0x0018CCD8
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollViewNew<JumpToItem, IJumpToItemData>(base.GetScrollViewWithScrollbar(9), new Func<JumpToItem>(this.InitItem), null, false, null);
	}

	// Token: 0x06004979 RID: 18809 RVA: 0x0018EAFC File Offset: 0x0018CCFC
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

	// Token: 0x0600497A RID: 18810 RVA: 0x0018EB58 File Offset: 0x0018CD58
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

	// Token: 0x0600497B RID: 18811 RVA: 0x0018ED8C File Offset: 0x0018CF8C
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

	// Token: 0x0600497C RID: 18812 RVA: 0x0018EF97 File Offset: 0x0018D197
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600497D RID: 18813 RVA: 0x0018EFA0 File Offset: 0x0018D1A0
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

	// Token: 0x0600497E RID: 18814 RVA: 0x0018F079 File Offset: 0x0018D279
	[NullableContext(1)]
	private JumpToItem InitItem()
	{
		return new JumpToItem
		{
			OnClickButtonCallBack = new Action<int>(this.OnClickJumpTo)
		};
	}

	// Token: 0x040036AF RID: 13999
	[Nullable(2)]
	private IBabelTowerItemInfoViewInfo Data;

	// Token: 0x040036B0 RID: 14000
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<JumpToItem, IJumpToItemData> ScrollView;

	// Token: 0x020068CE RID: 26830
	private class EComponentDefine
	{
		// Token: 0x04022894 RID: 141460
		public const int BackBtn = 0;

		// Token: 0x04022895 RID: 141461
		public const int DeTermItem = 1;

		// Token: 0x04022896 RID: 141462
		public const int BuffItem = 2;

		// Token: 0x04022897 RID: 141463
		public const int DeTermTexture = 3;

		// Token: 0x04022898 RID: 141464
		public const int DeTermStarText = 4;

		// Token: 0x04022899 RID: 141465
		public const int BuffTexture = 5;

		// Token: 0x0402289A RID: 141466
		public const int TitleText = 6;

		// Token: 0x0402289B RID: 141467
		public const int DesText = 7;

		// Token: 0x0402289C RID: 141468
		public const int JumpToItem = 8;

		// Token: 0x0402289D RID: 141469
		public const int JumpToScrollView = 9;

		// Token: 0x0402289E RID: 141470
		public const int JumpToBtn = 10;

		// Token: 0x0402289F RID: 141471
		public const int NameSprite = 11;

		// Token: 0x040228A0 RID: 141472
		public const int NameText = 12;

		// Token: 0x040228A1 RID: 141473
		public const int ExitBtn = 13;
	}
}
