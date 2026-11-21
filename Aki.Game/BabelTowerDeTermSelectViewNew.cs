using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000609 RID: 1545
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerDeTermSelectViewNew : UiViewBase
{
	// Token: 0x06004829 RID: 18473 RVA: 0x00186C5B File Offset: 0x00184E5B
	public BabelTowerDeTermSelectViewNew(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600482A RID: 18474 RVA: 0x00186C70 File Offset: 0x00184E70
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickQuestBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600482B RID: 18475 RVA: 0x00186DBC File Offset: 0x00184FBC
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerDeTermSelectViewNew.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerDeTermSelectViewNew.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600482C RID: 18476 RVA: 0x00186DFF File Offset: 0x00184FFF
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.BabelTowerRefreshLevelInfo, new Action(this.BabelTowerRefreshLevelInfo));
	}

	// Token: 0x0600482D RID: 18477 RVA: 0x00186E1D File Offset: 0x0018501D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.BabelTowerRefreshLevelInfo, new Action(this.BabelTowerRefreshLevelInfo));
	}

	// Token: 0x0600482E RID: 18478 RVA: 0x00186E3C File Offset: 0x0018503C
	protected override void OnStart()
	{
		int levelId = (int)(this.OpenParam ?? 0);
		BabelTowerModel.Instance.DeTermSelectInfo.Clear();
		BabelTowerModel.Instance.DeTermSelectIndex = 0;
		this.InitDeTermSelectInfo(levelId);
		BabelTowerSvBuffItem svBuffItem = this.SvBuffItem;
		if (svBuffItem != null)
		{
			svBuffItem.SetLevelId(levelId);
		}
		BabelTowerDesRightItem desRightItem = this.DesRightItem;
		if (desRightItem != null)
		{
			desRightItem.SetLevelId(levelId);
		}
		BabelTowerDesRightItem desRightItem2 = this.DesRightItem;
		if (desRightItem2 != null)
		{
			desRightItem2.RefreshBuffList(0);
		}
		BabelTowerQuickItem quickItem = this.QuickItem;
		if (quickItem != null)
		{
			quickItem.SetLevelId(levelId);
		}
		this.RefreshView();
	}

	// Token: 0x0600482F RID: 18479 RVA: 0x00186ED0 File Offset: 0x001850D0
	private void InitDeTermSelectInfo(int levelId)
	{
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(levelId);
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		HashSet<int> clearedDeTerms = BabelTowerModel.Instance.ClearedDeTerms;
		if (babelTowerLevelConfig.FixBabelDeTermdsLength > 0)
		{
			for (int i = 0; i < babelTowerLevelConfig.FixBabelDeTermdsLength; i++)
			{
				int num = babelTowerLevelConfig.FixBabelDeTermds(i);
				BabelTowerConfig.Instance.GetBabelTowerDeTerm(num);
				BabelTowerSelectInfo babelTowerSelectInfo = new BabelTowerSelectInfo();
				babelTowerSelectInfo.State = EBabelTowerDeTermState.StaticSelect;
				BabelTowerModel instance = BabelTowerModel.Instance;
				int deTermSelectIndex = instance.DeTermSelectIndex;
				instance.DeTermSelectIndex = deTermSelectIndex + 1;
				babelTowerSelectInfo.SelectIndex = deTermSelectIndex;
				BabelTowerSelectInfo value = babelTowerSelectInfo;
				BabelTowerModel.Instance.DeTermSelectInfo[num] = value;
			}
		}
		for (int j = 0; j < babelTowerLevelConfig.BabelTowerDeTermMutexArrayLength; j++)
		{
			int id = babelTowerLevelConfig.BabelTowerDeTermMutexArray(j);
			BabelTowerDeTermMutex babelTowerDeTermMutual = BabelTowerConfig.Instance.GetBabelTowerDeTermMutual(id);
			for (int k = 0; k < babelTowerDeTermMutual.MutexDeTermGroupLength; k++)
			{
				int id2 = babelTowerDeTermMutual.MutexDeTermGroup(k);
				foreach (BabelTowerDeTerm babelTowerDeTerm in BabelTowerConfig.Instance.GetBabelTowerDeTermByGroupId(id2))
				{
					if (babelTowerData.GetDeTermIsLock(babelTowerDeTerm.Id))
					{
						BabelTowerSelectInfo babelTowerSelectInfo2 = new BabelTowerSelectInfo();
						babelTowerSelectInfo2.State = EBabelTowerDeTermState.Lock;
						BabelTowerModel instance2 = BabelTowerModel.Instance;
						int deTermSelectIndex = instance2.DeTermSelectIndex;
						instance2.DeTermSelectIndex = deTermSelectIndex + 1;
						babelTowerSelectInfo2.SelectIndex = deTermSelectIndex;
						BabelTowerSelectInfo value2 = babelTowerSelectInfo2;
						BabelTowerModel.Instance.DeTermSelectInfo[babelTowerDeTerm.Id] = value2;
					}
					else if (babelTowerData.GetDeTermIsUse(levelId, babelTowerDeTerm.Id))
					{
						EBabelTowerDeTermState state = clearedDeTerms.Contains(babelTowerDeTerm.Id) ? EBabelTowerDeTermState.Normal : EBabelTowerDeTermState.Select;
						BabelTowerSelectInfo babelTowerSelectInfo3 = new BabelTowerSelectInfo();
						babelTowerSelectInfo3.State = state;
						BabelTowerModel instance3 = BabelTowerModel.Instance;
						int deTermSelectIndex = instance3.DeTermSelectIndex;
						instance3.DeTermSelectIndex = deTermSelectIndex + 1;
						babelTowerSelectInfo3.SelectIndex = deTermSelectIndex;
						BabelTowerSelectInfo value3 = babelTowerSelectInfo3;
						BabelTowerModel.Instance.DeTermSelectInfo[babelTowerDeTerm.Id] = value3;
					}
					else
					{
						BabelTowerSelectInfo babelTowerSelectInfo4 = new BabelTowerSelectInfo();
						babelTowerSelectInfo4.State = EBabelTowerDeTermState.Normal;
						BabelTowerModel instance4 = BabelTowerModel.Instance;
						int deTermSelectIndex = instance4.DeTermSelectIndex;
						instance4.DeTermSelectIndex = deTermSelectIndex + 1;
						babelTowerSelectInfo4.SelectIndex = deTermSelectIndex;
						BabelTowerSelectInfo value4 = babelTowerSelectInfo4;
						BabelTowerModel.Instance.DeTermSelectInfo[babelTowerDeTerm.Id] = value4;
					}
				}
			}
		}
	}

	// Token: 0x06004830 RID: 18480 RVA: 0x0018712C File Offset: 0x0018532C
	protected override void OnBeforeShow()
	{
		this.RefreshView();
		this.RefreshDifficultyBg();
		if (this.SvBuffItem != null)
		{
			BabelTowerQuickItem quickItem = this.QuickItem;
			int num = (quickItem != null) ? quickItem.GetSelectedQuickIndex() : -1;
			if (num >= 0)
			{
				int id = (int)(this.OpenParam ?? 0);
				int instId = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(id).InstId;
				IReadOnlyList<BabelTowerQuick> babelTowerQuickByInstId = BabelTowerConfig.Instance.GetBabelTowerQuickByInstId(instId);
				BabelTowerQuick? babelTowerQuick = (babelTowerQuickByInstId != null && num < babelTowerQuickByInstId.Count) ? new BabelTowerQuick?(babelTowerQuickByInstId[num]) : null;
				if (babelTowerQuick != null)
				{
					this.SvBuffItem.ApplyQuickSelectDeTerms(BabelTowerDeTermSelectViewNew.BuildBuffGroupList(babelTowerQuick.Value));
				}
			}
			this.SvBuffItem.RefreshBuffList(null);
			this.SvBuffItem.RefreshStarNum();
		}
		if (this.DesRightItem != null)
		{
			this.DesRightItem.SetLevelId((int)(this.OpenParam ?? 0));
			this.DesRightItem.RefreshBuffList(0);
		}
		if (this.QuickItem != null)
		{
			this.QuickItem.SetLevelId((int)(this.OpenParam ?? 0));
			this.QuickItem.RefreshQuickListWithSelection();
		}
	}

	// Token: 0x06004831 RID: 18481 RVA: 0x00187268 File Offset: 0x00185468
	private void RefreshView()
	{
		int num = (int)(this.OpenParam ?? 0);
		int maxRecordText;
		if (BabelTowerConfig.Instance.GetBabelTowerLevelConfig(num).IsDifficult)
		{
			BabelActivityLevelInfo babelActivityLevelInfo;
			maxRecordText = (BabelTowerController.Instance.GetBabelTowerData().HardLevelDataMap.TryGetValue(num, out babelActivityLevelInfo) ? babelActivityLevelInfo.MaxPassStar : 0);
		}
		else
		{
			BabelActivityLevelInfo babelActivityLevelInfo2;
			maxRecordText = (BabelTowerController.Instance.GetBabelTowerData().NormalLevelDataMap.TryGetValue(num, out babelActivityLevelInfo2) ? babelActivityLevelInfo2.MaxPassStar : 0);
		}
		BabelTowerDesRightItem desRightItem = this.DesRightItem;
		if (desRightItem == null)
		{
			return;
		}
		desRightItem.SetMaxRecordText(maxRecordText);
	}

	// Token: 0x06004832 RID: 18482 RVA: 0x001872FC File Offset: 0x001854FC
	private void RefreshDifficultyBg()
	{
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig((int)(this.OpenParam ?? 0));
		bool isDifficult = babelTowerLevelConfig.IsDifficult;
		UUITexture texture = base.GetTexture(2);
		if (texture != null)
		{
			texture.SetUIActive(isDifficult);
		}
		UUITexture texture2 = base.GetTexture(3);
		if (texture2 != null)
		{
			texture2.SetUIActive(isDifficult);
		}
		if (isDifficult && !string.IsNullOrEmpty(babelTowerLevelConfig.BossTexture))
		{
			base.SetTextureByPath(babelTowerLevelConfig.BossTexture, base.GetTexture(3), null, null);
		}
	}

	// Token: 0x06004833 RID: 18483 RVA: 0x00187388 File Offset: 0x00185588
	private void RefreshDifficultyColor(int currentStar)
	{
		int id = (int)(this.OpenParam ?? 0);
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(id);
		BabelTowerDifficulty? babelTowerDifficulty = BabelTowerModel.Instance.CalculateDifficultyConfigByStarNum(babelTowerLevelConfig.ActivityId, currentStar);
		if (babelTowerDifficulty == null)
		{
			return;
		}
		FColor colorBg = FColor.FromHex(babelTowerDifficulty.Value.TextBgColor);
		BabelTowerDesRightItem desRightItem = this.DesRightItem;
		if (desRightItem != null)
		{
			desRightItem.SetColorBg(colorBg);
		}
		BabelTowerDesRightItem desRightItem2 = this.DesRightItem;
		if (desRightItem2 == null)
		{
			return;
		}
		desRightItem2.SetDifficultyText(babelTowerDifficulty.Value.DifficultyTextKey);
	}

	// Token: 0x06004834 RID: 18484 RVA: 0x0018741C File Offset: 0x0018561C
	private void BabelTowerRefreshLevelInfo()
	{
		if (this.SvBuffItem != null)
		{
			this.SvBuffItem.RefreshBuffList(null);
			this.SvBuffItem.RefreshStarNum();
		}
		if (this.QuickItem != null)
		{
			this.QuickItem.SetLevelId((int)(this.OpenParam ?? 0));
		}
	}

	// Token: 0x06004835 RID: 18485 RVA: 0x00187470 File Offset: 0x00185670
	private void OnRefreshStarNum(int currentStar)
	{
		BabelTowerDesRightItem desRightItem = this.DesRightItem;
		if (desRightItem != null)
		{
			desRightItem.SetStarNum(currentStar);
		}
		this.RefreshDifficultyColor(currentStar);
	}

	// Token: 0x06004836 RID: 18486 RVA: 0x0018748B File Offset: 0x0018568B
	private void OnDeTermToggle(int deTermId)
	{
		BabelTowerDesRightItem desRightItem = this.DesRightItem;
		if (desRightItem == null)
		{
			return;
		}
		desRightItem.RefreshBuffList(deTermId);
	}

	// Token: 0x06004837 RID: 18487 RVA: 0x0018749E File Offset: 0x0018569E
	private void OnDesRightRefresh(int deTermId)
	{
		BabelTowerDesRightItem desRightItem = this.DesRightItem;
		if (desRightItem == null)
		{
			return;
		}
		desRightItem.RefreshBuffList(deTermId);
	}

	// Token: 0x06004838 RID: 18488 RVA: 0x001874B4 File Offset: 0x001856B4
	private static List<int> BuildBuffGroupList(BabelTowerQuick quickConfig)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < quickConfig.BuffGroupLength; i++)
		{
			list.Add(quickConfig.BuffGroup(i));
		}
		return list;
	}

	// Token: 0x06004839 RID: 18489 RVA: 0x001874E8 File Offset: 0x001856E8
	private void OnQuickSelectApplied(BabelTowerQuick quickConfig)
	{
		BabelTowerSvBuffItem svBuffItem = this.SvBuffItem;
		if (svBuffItem != null)
		{
			svBuffItem.ApplyQuickSelectDeTerms(BabelTowerDeTermSelectViewNew.BuildBuffGroupList(quickConfig));
		}
		BabelTowerSvBuffItem svBuffItem2 = this.SvBuffItem;
		if (svBuffItem2 != null)
		{
			BabelTowerQuickItem quickItem = this.QuickItem;
			svBuffItem2.SetQuickSelectComponentsOpacity((quickItem != null) ? quickItem.GetSelectedQuickIndex() : -1);
		}
		BabelTowerDesRightItem desRightItem = this.DesRightItem;
		if (desRightItem != null)
		{
			desRightItem.RefreshBuffList(0);
		}
		BabelTowerQuickItem quickItem2 = this.QuickItem;
		if (quickItem2 == null)
		{
			return;
		}
		quickItem2.RefreshQuickListWithSelection();
	}

	// Token: 0x0600483A RID: 18490 RVA: 0x00187554 File Offset: 0x00185754
	private void OnQuickSelectCleared()
	{
		BabelTowerSvBuffItem svBuffItem = this.SvBuffItem;
		if (svBuffItem != null)
		{
			svBuffItem.ClearAllSelect();
		}
		BabelTowerSvBuffItem svBuffItem2 = this.SvBuffItem;
		if (svBuffItem2 != null)
		{
			BabelTowerQuickItem quickItem = this.QuickItem;
			svBuffItem2.SetQuickSelectComponentsOpacity((quickItem != null) ? quickItem.GetSelectedQuickIndex() : -1);
		}
		BabelTowerDesRightItem desRightItem = this.DesRightItem;
		if (desRightItem == null)
		{
			return;
		}
		desRightItem.RefreshBuffList(0);
	}

	// Token: 0x0600483B RID: 18491 RVA: 0x001875A8 File Offset: 0x001857A8
	private void OnBuffClick(int index, int deTermId)
	{
		if (deTermId <= 0)
		{
			return;
		}
		BabelTowerSvBuffItem svBuffItem = this.SvBuffItem;
		MutexGroupItem mutexGroupItem = (svBuffItem != null) ? svBuffItem.FindMutexGroupItemByDeTermId(deTermId) : null;
		if (mutexGroupItem != null)
		{
			mutexGroupItem.HandleToggle(deTermId, null);
		}
		BabelTowerItemInfoViewInfo param = new BabelTowerItemInfoViewInfo
		{
			IsDeTerm = true,
			ConfigId = deTermId,
			ShowWays = true
		};
		UiManager.Instance.OpenView(EUiViewName.BabelTowerItemInfoView, param, null);
	}

	// Token: 0x0600483C RID: 18492 RVA: 0x00187605 File Offset: 0x00185805
	private void OnDesRightBuffClick(int deTermId)
	{
		BabelTowerSvBuffItem svBuffItem = this.SvBuffItem;
		if (svBuffItem == null)
		{
			return;
		}
		svBuffItem.ScrollToDeTerm(deTermId);
	}

	// Token: 0x0600483D RID: 18493 RVA: 0x00187618 File Offset: 0x00185818
	private void OnClickQuestBtn()
	{
		if (!BabelTowerController.Instance.GetBabelTowerData().CheckIfInOpenTime())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BabelTowerIsNotOpen", Array.Empty<object>());
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.BabelTowerQuestView, null, null);
	}

	// Token: 0x0600483E RID: 18494 RVA: 0x00187651 File Offset: 0x00185851
	private void OnClickQuickSelectBtn()
	{
		if (this.IsShowingQuickSelect)
		{
			this.HideQuickSelectPanelWithAnimation();
			return;
		}
		this.ShowQuickSelectPanelWithAnimation();
	}

	// Token: 0x0600483F RID: 18495 RVA: 0x00187668 File Offset: 0x00185868
	private void OnCloseHandler()
	{
		if (this.IsShowingQuickSelect)
		{
			this.HideQuickSelectPanelWithAnimation();
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x06004840 RID: 18496 RVA: 0x00187680 File Offset: 0x00185880
	private void ShowQuickSelectPanelWithAnimation()
	{
		BabelTowerDeTermSelectViewNew.<>c__DisplayClass31_0 CS$<>8__locals1 = new BabelTowerDeTermSelectViewNew.<>c__DisplayClass31_0();
		CS$<>8__locals1.<>4__this = this;
		BabelTowerSvBuffItem svBuffItem = this.SvBuffItem;
		if (svBuffItem != null)
		{
			svBuffItem.SetQuickSelectPanelVisible(true);
		}
		BabelTowerSvBuffItem svBuffItem2 = this.SvBuffItem;
		if (svBuffItem2 != null)
		{
			BabelTowerQuickItem quickItem = this.QuickItem;
			svBuffItem2.SetQuickSelectComponentsOpacity((quickItem != null) ? quickItem.GetSelectedQuickIndex() : -1);
		}
		BabelTowerDeTermSelectViewNew.<>c__DisplayClass31_0 CS$<>8__locals2 = CS$<>8__locals1;
		BabelTowerQuickItem quickItem2 = this.QuickItem;
		CS$<>8__locals2.firstItem = ((quickItem2 != null) ? quickItem2.GetFirstQuickItem() : null);
		this.UiViewSequence.RemoveSequenceFinishEvent("Switch_In", new Action<string>(this.OnSwitchInFinished));
		this.UiViewSequence.StopSequenceByKey("Switch_Out", true, true);
		base.PlayOrReplaySequence("Switch_In", false, null);
		this.UiViewSequence.AddSequenceFinishEvent("Switch_In", new Action<string>(this.OnSwitchInFinished), true);
		BabelTowerQuickItem quickItem3 = this.QuickItem;
		if (quickItem3 != null)
		{
			quickItem3.PlayContentAnimController();
		}
		if (CS$<>8__locals1.firstItem != null)
		{
			BabelTowerQuickItem quickItem4 = this.QuickItem;
			if (quickItem4 == null)
			{
				return;
			}
			quickItem4.BindLateUpdate(delegate(float _)
			{
				UiNavigationNewController.Instance.SetNavigationFocusForView(CS$<>8__locals1.firstItem, true, false, false);
				BabelTowerQuickItem quickItem5 = CS$<>8__locals1.<>4__this.QuickItem;
				if (quickItem5 == null)
				{
					return;
				}
				quickItem5.UnBindLateUpdate();
			});
		}
	}

	// Token: 0x06004841 RID: 18497 RVA: 0x0018777C File Offset: 0x0018597C
	private void OnSwitchInFinished(string _)
	{
		this.UiViewSequence.RemoveSequenceFinishEvent("Switch_In", new Action<string>(this.OnSwitchInFinished));
		this.IsShowingQuickSelect = true;
		this.BackupCurrentDeTermState();
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(6);
		if (item2 != null)
		{
			item2.SetUIActive(true);
		}
		BabelTowerSvBuffItem svBuffItem = this.SvBuffItem;
		if (svBuffItem != null)
		{
			svBuffItem.SetActionButtonsVisible(false, new bool?(false));
		}
		BabelTowerSvBuffItem svBuffItem2 = this.SvBuffItem;
		if (svBuffItem2 == null)
		{
			return;
		}
		svBuffItem2.SetQuickSelectPanelVisible(true);
	}

	// Token: 0x06004842 RID: 18498 RVA: 0x00187804 File Offset: 0x00185A04
	private void BackupCurrentDeTermState()
	{
		this.BackupDeTermSelectInfo.Clear();
		foreach (KeyValuePair<int, IBabelTowerSelectInfo> keyValuePair in BabelTowerModel.Instance.DeTermSelectInfo)
		{
			this.BackupDeTermSelectInfo[keyValuePair.Key] = new BabelTowerSelectInfo
			{
				State = keyValuePair.Value.State,
				SelectIndex = keyValuePair.Value.SelectIndex
			};
		}
	}

	// Token: 0x06004843 RID: 18499 RVA: 0x0018789C File Offset: 0x00185A9C
	private void RestoreBackupDeTermState()
	{
		Dictionary<int, IBabelTowerSelectInfo> deTermSelectInfo = BabelTowerModel.Instance.DeTermSelectInfo;
		deTermSelectInfo.Clear();
		foreach (KeyValuePair<int, IBabelTowerSelectInfo> keyValuePair in this.BackupDeTermSelectInfo)
		{
			deTermSelectInfo[keyValuePair.Key] = new BabelTowerSelectInfo
			{
				State = keyValuePair.Value.State,
				SelectIndex = keyValuePair.Value.SelectIndex
			};
		}
		this.BackupDeTermSelectInfo.Clear();
	}

	// Token: 0x06004844 RID: 18500 RVA: 0x0018793C File Offset: 0x00185B3C
	private void HideQuickSelectPanelWithAnimation()
	{
		if (this.IsHidingQuickSelect)
		{
			return;
		}
		this.IsHidingQuickSelect = true;
		this.RestoreBackupDeTermState();
		BabelTowerQuickItem quickItem = this.QuickItem;
		if (quickItem != null)
		{
			quickItem.ClearSelectionWithoutCallback();
		}
		BabelTowerDesRightItem desRightItem = this.DesRightItem;
		if (desRightItem != null)
		{
			desRightItem.RefreshBuffList(0);
		}
		BabelTowerSvBuffItem svBuffItem = this.SvBuffItem;
		if (svBuffItem != null)
		{
			svBuffItem.RefreshBuffList(null);
		}
		BabelTowerSvBuffItem svBuffItem2 = this.SvBuffItem;
		if (svBuffItem2 != null)
		{
			svBuffItem2.RefreshStarNum();
		}
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		BabelTowerSvBuffItem svBuffItem3 = this.SvBuffItem;
		if (svBuffItem3 != null)
		{
			svBuffItem3.SetQuickSelectPanelVisible(false);
		}
		BabelTowerSvBuffItem svBuffItem4 = this.SvBuffItem;
		if (svBuffItem4 != null)
		{
			svBuffItem4.SetQuickSelectComponentsOpacity(-1);
		}
		UUIItem item2 = base.GetItem(6);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		this.UiViewSequence.RemoveSequenceFinishEvent("Switch_Out", new Action<string>(this.OnSwitchOutFinished));
		this.UiViewSequence.RemoveSequenceFinishEvent("Switch_Out", new Action<string>(this.OnConfirmSwitchOutFinished));
		this.UiViewSequence.StopSequenceByKey("Switch_In", true, true);
		base.PlayOrReplaySequence("Switch_Out", false, null);
		this.UiViewSequence.AddSequenceFinishEvent("Switch_Out", new Action<string>(this.OnSwitchOutFinished), true);
	}

	// Token: 0x06004845 RID: 18501 RVA: 0x00187A6C File Offset: 0x00185C6C
	private void OnSwitchOutFinished(string _)
	{
		this.UiViewSequence.RemoveSequenceFinishEvent("Switch_Out", new Action<string>(this.OnSwitchOutFinished));
		this.IsHidingQuickSelect = false;
		this.IsShowingQuickSelect = false;
		int id = (int)(this.OpenParam ?? 0);
		bool isDifficult = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(id).IsDifficult;
		BabelTowerSvBuffItem svBuffItem = this.SvBuffItem;
		if (svBuffItem != null)
		{
			svBuffItem.SetActionButtonsVisible(isDifficult, new bool?(isDifficult));
		}
		EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "BabelTowerDeTermSelectViewShow");
	}

	// Token: 0x06004846 RID: 18502 RVA: 0x00187AFC File Offset: 0x00185CFC
	private void ShowDesRightPanel()
	{
		this.IsShowingQuickSelect = false;
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUIItem item2 = base.GetItem(6);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		int id = (int)(this.OpenParam ?? 0);
		bool isDifficult = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(id).IsDifficult;
		BabelTowerSvBuffItem svBuffItem = this.SvBuffItem;
		if (svBuffItem != null)
		{
			svBuffItem.SetActionButtonsVisible(isDifficult, new bool?(isDifficult));
		}
		BabelTowerSvBuffItem svBuffItem2 = this.SvBuffItem;
		if (svBuffItem2 != null)
		{
			svBuffItem2.SetQuickSelectPanelVisible(false);
		}
		BabelTowerSvBuffItem svBuffItem3 = this.SvBuffItem;
		if (svBuffItem3 != null)
		{
			BabelTowerQuickItem quickItem = this.QuickItem;
			svBuffItem3.SetQuickSelectComponentsOpacity((quickItem != null) ? quickItem.GetSelectedQuickIndex() : -1);
		}
		EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "BabelTowerDeTermSelectViewShow");
	}

	// Token: 0x06004847 RID: 18503 RVA: 0x00187BC4 File Offset: 0x00185DC4
	private void SwitchToDesRightFromQuickSelect()
	{
		BabelTowerDesRightItem desRightItem = this.DesRightItem;
		if (desRightItem != null)
		{
			desRightItem.RefreshBuffList(0);
		}
		BabelTowerSvBuffItem svBuffItem = this.SvBuffItem;
		if (svBuffItem != null)
		{
			svBuffItem.RefreshBuffList(null);
		}
		BabelTowerSvBuffItem svBuffItem2 = this.SvBuffItem;
		if (svBuffItem2 != null)
		{
			svBuffItem2.RefreshStarNum();
		}
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		BabelTowerSvBuffItem svBuffItem3 = this.SvBuffItem;
		if (svBuffItem3 != null)
		{
			svBuffItem3.SetQuickSelectPanelVisible(false);
		}
		BabelTowerSvBuffItem svBuffItem4 = this.SvBuffItem;
		if (svBuffItem4 != null)
		{
			svBuffItem4.SetQuickSelectComponentsOpacity(-1);
		}
		UUIItem item2 = base.GetItem(6);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		this.UiViewSequence.RemoveSequenceFinishEvent("Switch_Out", new Action<string>(this.OnSwitchOutFinished));
		this.UiViewSequence.RemoveSequenceFinishEvent("Switch_Out", new Action<string>(this.OnConfirmSwitchOutFinished));
		this.UiViewSequence.StopSequenceByKey("Switch_In", true, true);
		base.PlayOrReplaySequence("Switch_Out", false, null);
		this.UiViewSequence.AddSequenceFinishEvent("Switch_Out", new Action<string>(this.OnConfirmSwitchOutFinished), true);
	}

	// Token: 0x06004848 RID: 18504 RVA: 0x00187CCC File Offset: 0x00185ECC
	private void OnConfirmSwitchOutFinished(string _)
	{
		this.UiViewSequence.RemoveSequenceFinishEvent("Switch_Out", new Action<string>(this.OnConfirmSwitchOutFinished));
		this.IsShowingQuickSelect = false;
		this.BackupDeTermSelectInfo.Clear();
		BabelTowerSvBuffItem svBuffItem = this.SvBuffItem;
		if (svBuffItem != null)
		{
			svBuffItem.SetActionButtonsVisible(true, new bool?(true));
		}
		EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "BabelTowerDeTermSelectViewShow");
	}

	// Token: 0x06004849 RID: 18505 RVA: 0x00187D34 File Offset: 0x00185F34
	private void OnClickClearBtn()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BabelTowerClearDeTerm);
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			BabelTowerQuickItem quickItem = this.QuickItem;
			if (quickItem != null)
			{
				quickItem.ClearSelection();
			}
			BabelTowerSvBuffItem svBuffItem = this.SvBuffItem;
			if (svBuffItem != null)
			{
				svBuffItem.ClearAllSelect();
			}
			BabelTowerSvBuffItem svBuffItem2 = this.SvBuffItem;
			if (svBuffItem2 != null)
			{
				BabelTowerQuickItem quickItem2 = this.QuickItem;
				svBuffItem2.SetQuickSelectComponentsOpacity((quickItem2 != null) ? quickItem2.GetSelectedQuickIndex() : -1);
			}
			BabelTowerDesRightItem desRightItem = this.DesRightItem;
			if (desRightItem == null)
			{
				return;
			}
			desRightItem.RefreshBuffList(0);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600484A RID: 18506 RVA: 0x00187D70 File Offset: 0x00185F70
	private void SubmitCurrentSelection(bool jumpToPreBattle)
	{
		List<int> selectedDeTermList = BabelTowerModel.Instance.GetSelectedDeTermList();
		int currentDeTermStar = BabelTowerModel.Instance.GetCurrentDeTermStar();
		int levelId = (int)(this.OpenParam ?? 0);
		BabelTowerQuickItem quickItem = this.QuickItem;
		int quickId = (quickItem != null) ? quickItem.GetSelectedQuickIndex() : -1;
		BabelTowerController.Instance.SubmitDeTermSelectionAndJump(levelId, selectedDeTermList, currentDeTermStar, jumpToPreBattle, quickId).Forget();
	}

	// Token: 0x0600484B RID: 18507 RVA: 0x00187DD0 File Offset: 0x00185FD0
	private void OnClickConfirmBtn()
	{
		BabelTowerQuickItem quickItem = this.QuickItem;
		if (((quickItem != null) ? quickItem.GetSelectedQuickIndex() : -1) >= 0)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BabelTowerQuickSelectConfirm);
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				this.SwitchToDesRightFromQuickSelect();
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		this.SwitchToDesRightFromQuickSelect();
	}

	// Token: 0x0600484C RID: 18508 RVA: 0x00187E28 File Offset: 0x00186028
	private void OnClickGoBtn()
	{
		int currentDeTermStar = BabelTowerModel.Instance.GetCurrentDeTermStar();
		int id = (int)(this.OpenParam ?? 0);
		if (currentDeTermStar >= BabelTowerConfig.Instance.GetBabelTowerLevelConfig(id).PassStar)
		{
			this.SubmitCurrentSelection(true);
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BabelTowerLowStarConfirm);
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			this.SubmitCurrentSelection(true);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x04003640 RID: 13888
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003641 RID: 13889
	[Nullable(2)]
	private BabelTowerDesRightItem DesRightItem;

	// Token: 0x04003642 RID: 13890
	[Nullable(2)]
	private BabelTowerSvBuffItem SvBuffItem;

	// Token: 0x04003643 RID: 13891
	[Nullable(2)]
	private BabelTowerQuickItem QuickItem;

	// Token: 0x04003644 RID: 13892
	private bool IsShowingQuickSelect;

	// Token: 0x04003645 RID: 13893
	private bool IsHidingQuickSelect;

	// Token: 0x04003646 RID: 13894
	private readonly Dictionary<int, IBabelTowerSelectInfo> BackupDeTermSelectInfo = new Dictionary<int, IBabelTowerSelectInfo>();

	// Token: 0x0200689F RID: 26783
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040227AF RID: 141231
		public const int CaptionItem = 0;

		// Token: 0x040227B0 RID: 141232
		public const int QuestBtn = 1;

		// Token: 0x040227B1 RID: 141233
		public const int HardBg = 2;

		// Token: 0x040227B2 RID: 141234
		public const int BossBg = 3;

		// Token: 0x040227B3 RID: 141235
		public const int SvBuffItem = 4;

		// Token: 0x040227B4 RID: 141236
		public const int DesRightItem = 5;

		// Token: 0x040227B5 RID: 141237
		public const int QuickItem = 6;
	}
}
