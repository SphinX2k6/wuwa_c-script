using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200060C RID: 1548
[NullableContext(2)]
[Nullable(0)]
public class BabelTowerSvBuffItem : UiPanelBase
{
	// Token: 0x0600486A RID: 18538 RVA: 0x001886C4 File Offset: 0x001868C4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickLookBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickQuickSelectBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickDelBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600486B RID: 18539 RVA: 0x001888DC File Offset: 0x00186ADC
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerSvBuffItem.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerSvBuffItem.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600486C RID: 18540 RVA: 0x00188920 File Offset: 0x00186B20
	public void SetLevelId(int levelId)
	{
		this.LevelId = levelId;
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(levelId);
		UUIButtonComponent button = base.GetButton(6);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(babelTowerLevelConfig.IsDifficult);
		}
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(!babelTowerLevelConfig.IsDifficult);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), babelTowerLevelConfig.NameText ?? "", Array.Empty<object>());
		this.RefreshBuffList(null);
		this.RefreshStarNum();
	}

	// Token: 0x0600486D RID: 18541 RVA: 0x001889B8 File Offset: 0x00186BB8
	public void RefreshBuffList([Nullable(new byte[]
	{
		2,
		1
	})] List<IBabelTowerMutexGroupData> dataList = null)
	{
		List<IBabelTowerMutexGroupData> data = dataList ?? this.BuildMutexGroupDataList();
		GenericScrollViewNew<MutexGroupItem, IBabelTowerMutexGroupData> buffScrollView = this.BuffScrollView;
		if (buffScrollView == null)
		{
			return;
		}
		buffScrollView.RefreshByData(data, null, false);
	}

	// Token: 0x0600486E RID: 18542 RVA: 0x001889E4 File Offset: 0x00186BE4
	public void SetActionButtonsVisible(bool visible, bool? showQuickSelect = null)
	{
		UUIButtonComponent button = base.GetButton(5);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(visible);
		}
		if (showQuickSelect != null)
		{
			UUIButtonComponent button2 = base.GetButton(6);
			if (button2 == null)
			{
				return;
			}
			button2.RootUIComp.Get().SetUIActive(showQuickSelect.Value);
		}
	}

	// Token: 0x0600486F RID: 18543 RVA: 0x00188A3F File Offset: 0x00186C3F
	public void SetQuickSelectPanelVisible(bool visible)
	{
		this.IsQuickSelectPanelOpen = visible;
		UUIText text = base.GetText(7);
		if (text != null)
		{
			text.SetUIActive(visible);
		}
		ButtonItem applyButton = this.ApplyButton;
		if (applyButton == null)
		{
			return;
		}
		applyButton.SetUiActive(visible);
	}

	// Token: 0x06004870 RID: 18544 RVA: 0x00188A6C File Offset: 0x00186C6C
	public void SetQuickSelectComponentsOpacity(int quickIndex)
	{
		bool flag = this.IsQuickSelectMode();
		bool flag2 = quickIndex >= 0;
		float uiitemAlpha = (flag && !flag2) ? 0.8f : 1f;
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(3);
		if (scrollViewWithScrollbar != null)
		{
			scrollViewWithScrollbar.RootUIComp.Get().SetUIItemAlpha(uiitemAlpha);
		}
		UUIItem item = base.GetItem(10);
		if (item == null)
		{
			return;
		}
		item.SetUIItemAlpha(uiitemAlpha);
	}

	// Token: 0x06004871 RID: 18545 RVA: 0x00188ACC File Offset: 0x00186CCC
	public bool IsQuickSelectMode()
	{
		return this.IsQuickSelectPanelOpen;
	}

	// Token: 0x06004872 RID: 18546 RVA: 0x00188AD4 File Offset: 0x00186CD4
	public MutexGroupItem FindMutexGroupItemByDeTermId(int deTermId)
	{
		GenericScrollViewNew<MutexGroupItem, IBabelTowerMutexGroupData> buffScrollView = this.BuffScrollView;
		if (buffScrollView == null)
		{
			return null;
		}
		foreach (MutexGroupItem mutexGroupItem in buffScrollView.GetScrollItemList())
		{
			if (mutexGroupItem.GetBuffItemById(deTermId) != null)
			{
				return mutexGroupItem;
			}
		}
		return null;
	}

	// Token: 0x06004873 RID: 18547 RVA: 0x00188B3C File Offset: 0x00186D3C
	public void ScrollToDeTerm(int deTermId)
	{
		GenericScrollViewNew<MutexGroupItem, IBabelTowerMutexGroupData> buffScrollView = this.BuffScrollView;
		if (buffScrollView == null || deTermId == 0)
		{
			return;
		}
		foreach (MutexGroupItem mutexGroupItem in buffScrollView.GetScrollItemList())
		{
			SvBuffGridItem buffItemById = mutexGroupItem.GetBuffItemById(deTermId);
			if (buffItemById != null)
			{
				buffScrollView.LateScrollTo(mutexGroupItem.GetRootItem(), null, false);
				buffItemById.FlashHighlight();
				break;
			}
		}
	}

	// Token: 0x06004874 RID: 18548 RVA: 0x00188BB8 File Offset: 0x00186DB8
	public void RefreshStarNum()
	{
		int currentDeTermStar = BabelTowerModel.Instance.GetCurrentDeTermStar();
		int selectedDeTermCount = BabelTowerModel.Instance.GetSelectedDeTermCount();
		this.SetStarNumText(selectedDeTermCount);
		this.RefreshDifficultyColor(currentDeTermStar);
		Action<int> onRefreshStarNum = this.OnRefreshStarNum;
		if (onRefreshStarNum == null)
		{
			return;
		}
		onRefreshStarNum(currentDeTermStar);
	}

	// Token: 0x06004875 RID: 18549 RVA: 0x00188BFC File Offset: 0x00186DFC
	private void SetStarNumText(int selectedCount)
	{
		UUIText text = base.GetText(7);
		if (text != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "BabelQuickSelect_star", new <>z__ReadOnlySingleElementList<object>(selectedCount));
		}
	}

	// Token: 0x06004876 RID: 18550 RVA: 0x00188C30 File Offset: 0x00186E30
	private void RefreshDifficultyColor(int currentStar)
	{
		BabelTowerLevel? config = ConfigBabelTowerLevelById.GetConfig(this.LevelId, true);
		if (config == null)
		{
			return;
		}
		BabelTowerLevel valueOrDefault = config.GetValueOrDefault();
		BabelTowerDifficulty? babelTowerDifficulty = BabelTowerModel.Instance.CalculateDifficultyConfigByStarNum(valueOrDefault.ActivityId, currentStar);
		if (babelTowerDifficulty == null)
		{
			return;
		}
		FColor color = FColor.FromHex(babelTowerDifficulty.GetValueOrDefault().TextBgColor);
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetColor(color);
	}

	// Token: 0x06004877 RID: 18551 RVA: 0x00188CA8 File Offset: 0x00186EA8
	[NullableContext(1)]
	private List<IBabelTowerMutexGroupData> BuildMutexGroupDataList()
	{
		BabelTowerLevel? config = ConfigBabelTowerLevelById.GetConfig(this.LevelId, true);
		if (config != null)
		{
			BabelTowerLevel valueOrDefault = config.GetValueOrDefault();
			List<IBabelTowerMutexGroupData> list = new List<IBabelTowerMutexGroupData>();
			bool value = true;
			if (valueOrDefault.FixBabelDeTermdsLength > 0)
			{
				List<int> list2 = new List<int>();
				for (int i = 0; i < valueOrDefault.FixBabelDeTermdsLength; i++)
				{
					int num = valueOrDefault.FixBabelDeTermds(i);
					BabelTowerDeTerm babelTowerDeTerm = BabelTowerConfig.Instance.GetBabelTowerDeTerm(num);
					int j = 1;
					while (babelTowerDeTerm.Star > j)
					{
						list2.Add(0);
						j++;
					}
					list2.Add(num);
					for (j++; j <= 3; j++)
					{
						list2.Add(0);
					}
				}
				list.Add(new BabelTowerMutexGroupData
				{
					MutexId = 0,
					GroupId = 0,
					DeTermList = list2,
					IsNecessary = new bool?(value)
				});
			}
			for (int k = 0; k < valueOrDefault.BabelTowerDeTermMutexArrayLength; k++)
			{
				int num2 = valueOrDefault.BabelTowerDeTermMutexArray(k);
				BabelTowerDeTermMutex babelTowerDeTermMutual = BabelTowerConfig.Instance.GetBabelTowerDeTermMutual(num2);
				List<int> mergedDeTermListByMutexId = this.GetMergedDeTermListByMutexId(babelTowerDeTermMutual);
				int value2 = 0;
				foreach (int num3 in mergedDeTermListByMutexId)
				{
					if (num3 != 0)
					{
						IBabelTowerSelectInfo valueOrDefault2 = BabelTowerModel.Instance.DeTermSelectInfo.GetValueOrDefault(num3);
						if (valueOrDefault2 != null && valueOrDefault2.State == EBabelTowerDeTermState.Select)
						{
							value2 = num3;
							break;
						}
					}
				}
				list.Add(new BabelTowerMutexGroupData
				{
					MutexId = num2,
					GroupId = ((babelTowerDeTermMutual.MutexDeTermGroupLength > 0) ? babelTowerDeTermMutual.MutexDeTermGroup(0) : 0),
					DeTermList = mergedDeTermListByMutexId,
					CurrentDeTermId = new int?(value2)
				});
			}
			return list;
		}
		return new List<IBabelTowerMutexGroupData>();
	}

	// Token: 0x06004878 RID: 18552 RVA: 0x00188E84 File Offset: 0x00187084
	[NullableContext(1)]
	private List<int> GetMergedDeTermListByMutexId(BabelTowerDeTermMutex mutexConfig)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < mutexConfig.MutexDeTermGroupLength; i++)
		{
			int id = mutexConfig.MutexDeTermGroup(i);
			List<BabelTowerDeTerm> list2 = new List<BabelTowerDeTerm>(BabelTowerConfig.Instance.GetBabelTowerDeTermByGroupId(id));
			list2.Sort((BabelTowerDeTerm a, BabelTowerDeTerm b) => a.Star - b.Star);
			for (int j = 1; j <= 3; j++)
			{
				BabelTowerDeTerm? babelTowerDeTerm = null;
				for (int k = 0; k < list2.Count; k++)
				{
					if (list2[k].Star == j)
					{
						babelTowerDeTerm = new BabelTowerDeTerm?(list2[k]);
						break;
					}
				}
				if (babelTowerDeTerm != null)
				{
					list.Add(babelTowerDeTerm.GetValueOrDefault().Id);
				}
				else
				{
					list.Add(0);
				}
			}
		}
		return list;
	}

	// Token: 0x06004879 RID: 18553 RVA: 0x00188F6A File Offset: 0x0018716A
	[NullableContext(1)]
	private MutexGroupItem CreateMutexGroupItem()
	{
		MutexGroupItem mutexGroupItem = new MutexGroupItem();
		mutexGroupItem.SetParentItem(this);
		mutexGroupItem.OnBuffClick = new Action<int, UUIExtendToggle>(this.OnBuffItemClick);
		return mutexGroupItem;
	}

	// Token: 0x0600487A RID: 18554 RVA: 0x00188F8C File Offset: 0x0018718C
	private void OnBuffItemClick(int deTermId, UUIExtendToggle toggle)
	{
		if (deTermId <= 0)
		{
			return;
		}
		IBabelTowerSelectInfo selectInfoByDeTerm = this.GetSelectInfoByDeTerm(deTermId);
		if (selectInfoByDeTerm == null)
		{
			return;
		}
		if (selectInfoByDeTerm.State == EBabelTowerDeTermState.Lock)
		{
			return;
		}
		MutexGroupItem mutexGroupItem = this.FindMutexGroupItemByDeTermId(deTermId);
		if (mutexGroupItem != null)
		{
			mutexGroupItem.HandleToggle(deTermId, toggle);
		}
	}

	// Token: 0x0600487B RID: 18555 RVA: 0x00188FC8 File Offset: 0x001871C8
	private void OnClickLookBtn()
	{
		int levelId = this.LevelId;
		if (levelId <= 0)
		{
			return;
		}
		BabelTowerLevel? config = ConfigBabelTowerLevelById.GetConfig(levelId, true);
		if (config != null)
		{
			BabelTowerLevel valueOrDefault = config.GetValueOrDefault();
			InstanceDungeonEntranceModel.Instance.SelectInstanceId = valueOrDefault.InstId;
			InstanceDungeonMonsterView.InstanceDungeonMonsterViewOpenParam param = new InstanceDungeonMonsterView.InstanceDungeonMonsterViewOpenParam
			{
				InstanceId = valueOrDefault.InstId,
				InfoType = null
			};
			UiManager.Instance.OpenView(EUiViewName.InstanceDungeonMonsterPreView, param, null);
			return;
		}
	}

	// Token: 0x0600487C RID: 18556 RVA: 0x00189042 File Offset: 0x00187242
	private void OnClickQuickSelectBtn()
	{
		Action onQuickSelectClick = this.OnQuickSelectClick;
		if (onQuickSelectClick == null)
		{
			return;
		}
		onQuickSelectClick();
	}

	// Token: 0x0600487D RID: 18557 RVA: 0x00189054 File Offset: 0x00187254
	private void OnClickDelBtn()
	{
		Action onClearClick = this.OnClearClick;
		if (onClearClick == null)
		{
			return;
		}
		onClearClick();
	}

	// Token: 0x0600487E RID: 18558 RVA: 0x00189066 File Offset: 0x00187266
	private void OnClickConfirmBtn(int data)
	{
		Action onConfirmClick = this.OnConfirmClick;
		if (onConfirmClick == null)
		{
			return;
		}
		onConfirmClick();
	}

	// Token: 0x0600487F RID: 18559 RVA: 0x00189078 File Offset: 0x00187278
	public IBabelTowerSelectInfo GetSelectInfoByDeTerm(int deTermId)
	{
		return BabelTowerModel.Instance.GetDeTermSelectInfo(deTermId);
	}

	// Token: 0x06004880 RID: 18560 RVA: 0x00189085 File Offset: 0x00187285
	public void NotifyDeTermToggle(int deTermId)
	{
		Action<int> onDeTermToggle = this.OnDeTermToggle;
		if (onDeTermToggle == null)
		{
			return;
		}
		onDeTermToggle(deTermId);
	}

	// Token: 0x06004881 RID: 18561 RVA: 0x00189098 File Offset: 0x00187298
	public void ClearAllSelect()
	{
		foreach (KeyValuePair<int, IBabelTowerSelectInfo> keyValuePair in BabelTowerModel.Instance.DeTermSelectInfo)
		{
			bool key = keyValuePair.Key != 0;
			IBabelTowerSelectInfo value = keyValuePair.Value;
			if (key && value.State == EBabelTowerDeTermState.Select)
			{
				value.State = EBabelTowerDeTermState.Normal;
			}
		}
		this.RefreshBuffList(null);
		this.RefreshStarNum();
	}

	// Token: 0x06004882 RID: 18562 RVA: 0x00189118 File Offset: 0x00187318
	[NullableContext(1)]
	public void ApplyQuickSelectDeTerms(List<int> buffGroup)
	{
		Dictionary<int, IBabelTowerSelectInfo> deTermSelectInfo = BabelTowerModel.Instance.DeTermSelectInfo;
		foreach (KeyValuePair<int, IBabelTowerSelectInfo> keyValuePair in deTermSelectInfo)
		{
			bool key = keyValuePair.Key != 0;
			IBabelTowerSelectInfo value = keyValuePair.Value;
			if (key && value.State == EBabelTowerDeTermState.Select)
			{
				value.State = EBabelTowerDeTermState.Normal;
			}
		}
		foreach (int num in buffGroup)
		{
			IBabelTowerSelectInfo valueOrDefault = deTermSelectInfo.GetValueOrDefault(num);
			if (valueOrDefault != null)
			{
				if (valueOrDefault.State != EBabelTowerDeTermState.StaticSelect)
				{
					valueOrDefault.State = EBabelTowerDeTermState.Select;
				}
			}
			else if (ConfigBabelTowerDeTermById.GetConfig(num, true) != null)
			{
				BabelTowerSelectInfo babelTowerSelectInfo = new BabelTowerSelectInfo();
				babelTowerSelectInfo.State = EBabelTowerDeTermState.Select;
				BabelTowerModel instance = BabelTowerModel.Instance;
				int deTermSelectIndex = instance.DeTermSelectIndex;
				instance.DeTermSelectIndex = deTermSelectIndex + 1;
				babelTowerSelectInfo.SelectIndex = deTermSelectIndex;
				BabelTowerSelectInfo value2 = babelTowerSelectInfo;
				deTermSelectInfo[num] = value2;
			}
		}
		this.RefreshBuffList(null);
		this.RefreshStarNum();
	}

	// Token: 0x04003651 RID: 13905
	private const int MAX_STAR_NUM = 3;

	// Token: 0x04003652 RID: 13906
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MutexGroupItem, IBabelTowerMutexGroupData> BuffScrollView;

	// Token: 0x04003653 RID: 13907
	private int LevelId;

	// Token: 0x04003654 RID: 13908
	private bool IsQuickSelectPanelOpen;

	// Token: 0x04003655 RID: 13909
	private ButtonItem ApplyButton;

	// Token: 0x04003656 RID: 13910
	public Action<int, int> OnBuffClick;

	// Token: 0x04003657 RID: 13911
	public Action<int> OnDeTermToggle;

	// Token: 0x04003658 RID: 13912
	public Action<int> OnDesRightRefresh;

	// Token: 0x04003659 RID: 13913
	public Action OnQuickSelectClick;

	// Token: 0x0400365A RID: 13914
	public Action OnClearClick;

	// Token: 0x0400365B RID: 13915
	public Action OnConfirmClick;

	// Token: 0x0400365C RID: 13916
	public Action<int> OnRefreshStarNum;

	// Token: 0x020068A5 RID: 26789
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040227CD RID: 141261
		public const int ColorFrameSprite = 0;

		// Token: 0x040227CE RID: 141262
		public const int BtnLook = 1;

		// Token: 0x040227CF RID: 141263
		public const int DeBuffTopTips = 2;

		// Token: 0x040227D0 RID: 141264
		public const int DeBuffItemScroll = 3;

		// Token: 0x040227D1 RID: 141265
		public const int UiItemDeBuffItemGroup = 4;

		// Token: 0x040227D2 RID: 141266
		public const int BtnFunctionDel = 5;

		// Token: 0x040227D3 RID: 141267
		public const int BtnQuickSelect = 6;

		// Token: 0x040227D4 RID: 141268
		public const int TxtDeBuffValue = 7;

		// Token: 0x040227D5 RID: 141269
		public const int BtnApply = 8;

		// Token: 0x040227D6 RID: 141270
		public const int TitleNameText = 9;

		// Token: 0x040227D7 RID: 141271
		public const int ApplyBtnGroupItem = 10;
	}
}
