using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001158 RID: 4440
[NullableContext(2)]
[Nullable(0)]
public class BabelTowerSvBuffItem : UiPanelBase
{
	// Token: 0x060074D3 RID: 29907 RVA: 0x0017FB78 File Offset: 0x0017DD78
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

	// Token: 0x060074D4 RID: 29908 RVA: 0x0017FD90 File Offset: 0x0017DF90
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerSvBuffItem.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerSvBuffItem.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060074D5 RID: 29909 RVA: 0x0017FDD4 File Offset: 0x0017DFD4
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

	// Token: 0x060074D6 RID: 29910 RVA: 0x0017FE6C File Offset: 0x0017E06C
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

	// Token: 0x060074D7 RID: 29911 RVA: 0x0017FE98 File Offset: 0x0017E098
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

	// Token: 0x060074D8 RID: 29912 RVA: 0x0017FEF3 File Offset: 0x0017E0F3
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

	// Token: 0x060074D9 RID: 29913 RVA: 0x0017FF20 File Offset: 0x0017E120
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

	// Token: 0x060074DA RID: 29914 RVA: 0x0017FF80 File Offset: 0x0017E180
	public bool IsQuickSelectMode()
	{
		return this.IsQuickSelectPanelOpen;
	}

	// Token: 0x060074DB RID: 29915 RVA: 0x0017FF88 File Offset: 0x0017E188
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

	// Token: 0x060074DC RID: 29916 RVA: 0x0017FFF0 File Offset: 0x0017E1F0
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

	// Token: 0x060074DD RID: 29917 RVA: 0x0018006C File Offset: 0x0017E26C
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

	// Token: 0x060074DE RID: 29918 RVA: 0x001800B0 File Offset: 0x0017E2B0
	private void SetStarNumText(int selectedCount)
	{
		UUIText text = base.GetText(7);
		if (text != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "BabelQuickSelect_star", new <>z__ReadOnlySingleElementList<object>(selectedCount));
		}
	}

	// Token: 0x060074DF RID: 29919 RVA: 0x001800E4 File Offset: 0x0017E2E4
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

	// Token: 0x060074E0 RID: 29920 RVA: 0x0018015C File Offset: 0x0017E35C
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

	// Token: 0x060074E1 RID: 29921 RVA: 0x00180338 File Offset: 0x0017E538
	[NullableContext(1)]
	private List<int> GetMergedDeTermListByMutexId(BabelTowerDeTermMutex mutexConfig)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < mutexConfig.MutexDeTermGroupLength; i++)
		{
			int id = mutexConfig.MutexDeTermGroup(i);
			List<BabelTowerDeTerm> list2 = BabelTowerConfig.Instance.GetBabelTowerDeTermByGroupId(id).ToList<BabelTowerDeTerm>();
			list2.Sort((BabelTowerDeTerm a, BabelTowerDeTerm b) => a.Star - b.Star);
			int star2;
			int star;
			for (star = 1; star <= 3; star = star2 + 1)
			{
				BabelTowerDeTerm? babelTowerDeTerm = (from config in list2
				where config.Star == star
				select new BabelTowerDeTerm?(config)).FirstOrDefault<BabelTowerDeTerm?>();
				if (babelTowerDeTerm != null)
				{
					list.Add(babelTowerDeTerm.GetValueOrDefault().Id);
				}
				else
				{
					list.Add(0);
				}
				star2 = star;
			}
		}
		return list;
	}

	// Token: 0x060074E2 RID: 29922 RVA: 0x0018043B File Offset: 0x0017E63B
	[NullableContext(1)]
	private MutexGroupItem CreateMutexGroupItem()
	{
		MutexGroupItem mutexGroupItem = new MutexGroupItem();
		mutexGroupItem.SetParentItem(this);
		mutexGroupItem.OnBuffClick = new Action<int, UUIExtendToggle>(this.OnBuffItemClick);
		return mutexGroupItem;
	}

	// Token: 0x060074E3 RID: 29923 RVA: 0x0018045C File Offset: 0x0017E65C
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

	// Token: 0x060074E4 RID: 29924 RVA: 0x00180498 File Offset: 0x0017E698
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

	// Token: 0x060074E5 RID: 29925 RVA: 0x00180512 File Offset: 0x0017E712
	private void OnClickQuickSelectBtn()
	{
		Action onQuickSelectClick = this.OnQuickSelectClick;
		if (onQuickSelectClick == null)
		{
			return;
		}
		onQuickSelectClick();
	}

	// Token: 0x060074E6 RID: 29926 RVA: 0x00180524 File Offset: 0x0017E724
	private void OnClickDelBtn()
	{
		Action onClearClick = this.OnClearClick;
		if (onClearClick == null)
		{
			return;
		}
		onClearClick();
	}

	// Token: 0x060074E7 RID: 29927 RVA: 0x00180536 File Offset: 0x0017E736
	private void OnClickConfirmBtn(int data)
	{
		Action onConfirmClick = this.OnConfirmClick;
		if (onConfirmClick == null)
		{
			return;
		}
		onConfirmClick();
	}

	// Token: 0x060074E8 RID: 29928 RVA: 0x00180548 File Offset: 0x0017E748
	public IBabelTowerSelectInfo GetSelectInfoByDeTerm(int deTermId)
	{
		return BabelTowerModel.Instance.GetDeTermSelectInfo(deTermId);
	}

	// Token: 0x060074E9 RID: 29929 RVA: 0x00180555 File Offset: 0x0017E755
	public void NotifyDeTermToggle(int deTermId)
	{
		Action<int> onDeTermToggle = this.OnDeTermToggle;
		if (onDeTermToggle == null)
		{
			return;
		}
		onDeTermToggle(deTermId);
	}

	// Token: 0x060074EA RID: 29930 RVA: 0x00180568 File Offset: 0x0017E768
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

	// Token: 0x060074EB RID: 29931 RVA: 0x001805E8 File Offset: 0x0017E7E8
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

	// Token: 0x040035B8 RID: 13752
	private const int MAX_STAR_NUM = 3;

	// Token: 0x040035B9 RID: 13753
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MutexGroupItem, IBabelTowerMutexGroupData> BuffScrollView;

	// Token: 0x040035BA RID: 13754
	private int LevelId;

	// Token: 0x040035BB RID: 13755
	private bool IsQuickSelectPanelOpen;

	// Token: 0x040035BC RID: 13756
	private ButtonItem ApplyButton;

	// Token: 0x040035BD RID: 13757
	public Action<int, int> OnBuffClick;

	// Token: 0x040035BE RID: 13758
	public Action<int> OnDeTermToggle;

	// Token: 0x040035BF RID: 13759
	public Action<int> OnDesRightRefresh;

	// Token: 0x040035C0 RID: 13760
	public Action OnQuickSelectClick;

	// Token: 0x040035C1 RID: 13761
	public Action OnClearClick;

	// Token: 0x040035C2 RID: 13762
	public Action OnConfirmClick;

	// Token: 0x040035C3 RID: 13763
	public Action<int> OnRefreshStarNum;

	// Token: 0x02007716 RID: 30486
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402748C RID: 160908
		public const int ColorFrameSprite = 0;

		// Token: 0x0402748D RID: 160909
		public const int BtnLook = 1;

		// Token: 0x0402748E RID: 160910
		public const int DeBuffTopTips = 2;

		// Token: 0x0402748F RID: 160911
		public const int DeBuffItemScroll = 3;

		// Token: 0x04027490 RID: 160912
		public const int UiItemDeBuffItemGroup = 4;

		// Token: 0x04027491 RID: 160913
		public const int BtnFunctionDel = 5;

		// Token: 0x04027492 RID: 160914
		public const int BtnQuickSelect = 6;

		// Token: 0x04027493 RID: 160915
		public const int TxtDeBuffValue = 7;

		// Token: 0x04027494 RID: 160916
		public const int BtnApply = 8;

		// Token: 0x04027495 RID: 160917
		public const int TitleNameText = 9;

		// Token: 0x04027496 RID: 160918
		public const int ApplyBtnGroupItem = 10;
	}
}
