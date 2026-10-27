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

// Token: 0x02001155 RID: 4437
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerDeTermSelectViewNew : UiViewBase
{
	// Token: 0x06007492 RID: 29842 RVA: 0x0017E10F File Offset: 0x0017C30F
	public BabelTowerDeTermSelectViewNew(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06007493 RID: 29843 RVA: 0x0017E124 File Offset: 0x0017C324
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

	// Token: 0x06007494 RID: 29844 RVA: 0x0017E270 File Offset: 0x0017C470
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerDeTermSelectViewNew.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerDeTermSelectViewNew.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007495 RID: 29845 RVA: 0x0017E2B3 File Offset: 0x0017C4B3
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.BabelTowerRefreshLevelInfo, new Action(this.BabelTowerRefreshLevelInfo));
	}

	// Token: 0x06007496 RID: 29846 RVA: 0x0017E2D1 File Offset: 0x0017C4D1
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.BabelTowerRefreshLevelInfo, new Action(this.BabelTowerRefreshLevelInfo));
	}

	// Token: 0x06007497 RID: 29847 RVA: 0x0017E2F0 File Offset: 0x0017C4F0
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

	// Token: 0x06007498 RID: 29848 RVA: 0x0017E384 File Offset: 0x0017C584
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

	// Token: 0x06007499 RID: 29849 RVA: 0x0017E5E0 File Offset: 0x0017C7E0
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

	// Token: 0x0600749A RID: 29850 RVA: 0x0017E71C File Offset: 0x0017C91C
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

	// Token: 0x0600749B RID: 29851 RVA: 0x0017E7B0 File Offset: 0x0017C9B0
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

	// Token: 0x0600749C RID: 29852 RVA: 0x0017E83C File Offset: 0x0017CA3C
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

	// Token: 0x0600749D RID: 29853 RVA: 0x0017E8D0 File Offset: 0x0017CAD0
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

	// Token: 0x0600749E RID: 29854 RVA: 0x0017E924 File Offset: 0x0017CB24
	private void OnRefreshStarNum(int currentStar)
	{
		BabelTowerDesRightItem desRightItem = this.DesRightItem;
		if (desRightItem != null)
		{
			desRightItem.SetStarNum(currentStar);
		}
		this.RefreshDifficultyColor(currentStar);
	}

	// Token: 0x0600749F RID: 29855 RVA: 0x0017E93F File Offset: 0x0017CB3F
	private void OnDeTermToggle(int deTermId)
	{
		BabelTowerDesRightItem desRightItem = this.DesRightItem;
		if (desRightItem == null)
		{
			return;
		}
		desRightItem.RefreshBuffList(deTermId);
	}

	// Token: 0x060074A0 RID: 29856 RVA: 0x0017E952 File Offset: 0x0017CB52
	private void OnDesRightRefresh(int deTermId)
	{
		BabelTowerDesRightItem desRightItem = this.DesRightItem;
		if (desRightItem == null)
		{
			return;
		}
		desRightItem.RefreshBuffList(deTermId);
	}

	// Token: 0x060074A1 RID: 29857 RVA: 0x0017E968 File Offset: 0x0017CB68
	private static List<int> BuildBuffGroupList(BabelTowerQuick quickConfig)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < quickConfig.BuffGroupLength; i++)
		{
			list.Add(quickConfig.BuffGroup(i));
		}
		return list;
	}

	// Token: 0x060074A2 RID: 29858 RVA: 0x0017E99C File Offset: 0x0017CB9C
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

	// Token: 0x060074A3 RID: 29859 RVA: 0x0017EA08 File Offset: 0x0017CC08
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

	// Token: 0x060074A4 RID: 29860 RVA: 0x0017EA5C File Offset: 0x0017CC5C
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

	// Token: 0x060074A5 RID: 29861 RVA: 0x0017EAB9 File Offset: 0x0017CCB9
	private void OnDesRightBuffClick(int deTermId)
	{
		BabelTowerSvBuffItem svBuffItem = this.SvBuffItem;
		if (svBuffItem == null)
		{
			return;
		}
		svBuffItem.ScrollToDeTerm(deTermId);
	}

	// Token: 0x060074A6 RID: 29862 RVA: 0x0017EACC File Offset: 0x0017CCCC
	private void OnClickQuestBtn()
	{
		if (!BabelTowerController.Instance.GetBabelTowerData().CheckIfInOpenTime())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BabelTowerIsNotOpen", Array.Empty<object>());
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.BabelTowerQuestView, null, null);
	}

	// Token: 0x060074A7 RID: 29863 RVA: 0x0017EB05 File Offset: 0x0017CD05
	private void OnClickQuickSelectBtn()
	{
		if (this.IsShowingQuickSelect)
		{
			this.HideQuickSelectPanelWithAnimation();
			return;
		}
		this.ShowQuickSelectPanelWithAnimation();
	}

	// Token: 0x060074A8 RID: 29864 RVA: 0x0017EB1C File Offset: 0x0017CD1C
	private void OnCloseHandler()
	{
		if (this.IsShowingQuickSelect)
		{
			this.HideQuickSelectPanelWithAnimation();
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x060074A9 RID: 29865 RVA: 0x0017EB34 File Offset: 0x0017CD34
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

	// Token: 0x060074AA RID: 29866 RVA: 0x0017EC30 File Offset: 0x0017CE30
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

	// Token: 0x060074AB RID: 29867 RVA: 0x0017ECB8 File Offset: 0x0017CEB8
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

	// Token: 0x060074AC RID: 29868 RVA: 0x0017ED50 File Offset: 0x0017CF50
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

	// Token: 0x060074AD RID: 29869 RVA: 0x0017EDF0 File Offset: 0x0017CFF0
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

	// Token: 0x060074AE RID: 29870 RVA: 0x0017EF20 File Offset: 0x0017D120
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

	// Token: 0x060074AF RID: 29871 RVA: 0x0017EFB0 File Offset: 0x0017D1B0
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

	// Token: 0x060074B0 RID: 29872 RVA: 0x0017F078 File Offset: 0x0017D278
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

	// Token: 0x060074B1 RID: 29873 RVA: 0x0017F180 File Offset: 0x0017D380
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

	// Token: 0x060074B2 RID: 29874 RVA: 0x0017F1E8 File Offset: 0x0017D3E8
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

	// Token: 0x060074B3 RID: 29875 RVA: 0x0017F224 File Offset: 0x0017D424
	private void SubmitCurrentSelection(bool jumpToPreBattle)
	{
		List<int> selectedDeTermList = BabelTowerModel.Instance.GetSelectedDeTermList();
		int currentDeTermStar = BabelTowerModel.Instance.GetCurrentDeTermStar();
		int levelId = (int)(this.OpenParam ?? 0);
		BabelTowerQuickItem quickItem = this.QuickItem;
		int quickId = (quickItem != null) ? quickItem.GetSelectedQuickIndex() : -1;
		BabelTowerController.Instance.SubmitDeTermSelectionAndJump(levelId, selectedDeTermList, currentDeTermStar, jumpToPreBattle, quickId).Forget();
	}

	// Token: 0x060074B4 RID: 29876 RVA: 0x0017F284 File Offset: 0x0017D484
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

	// Token: 0x060074B5 RID: 29877 RVA: 0x0017F2DC File Offset: 0x0017D4DC
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

	// Token: 0x040035A7 RID: 13735
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040035A8 RID: 13736
	[Nullable(2)]
	private BabelTowerDesRightItem DesRightItem;

	// Token: 0x040035A9 RID: 13737
	[Nullable(2)]
	private BabelTowerSvBuffItem SvBuffItem;

	// Token: 0x040035AA RID: 13738
	[Nullable(2)]
	private BabelTowerQuickItem QuickItem;

	// Token: 0x040035AB RID: 13739
	private bool IsShowingQuickSelect;

	// Token: 0x040035AC RID: 13740
	private bool IsHidingQuickSelect;

	// Token: 0x040035AD RID: 13741
	private readonly Dictionary<int, IBabelTowerSelectInfo> BackupDeTermSelectInfo = new Dictionary<int, IBabelTowerSelectInfo>();

	// Token: 0x02007710 RID: 30480
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402746E RID: 160878
		public const int CaptionItem = 0;

		// Token: 0x0402746F RID: 160879
		public const int QuestBtn = 1;

		// Token: 0x04027470 RID: 160880
		public const int HardBg = 2;

		// Token: 0x04027471 RID: 160881
		public const int BossBg = 3;

		// Token: 0x04027472 RID: 160882
		public const int SvBuffItem = 4;

		// Token: 0x04027473 RID: 160883
		public const int DesRightItem = 5;

		// Token: 0x04027474 RID: 160884
		public const int QuickItem = 6;
	}
}
