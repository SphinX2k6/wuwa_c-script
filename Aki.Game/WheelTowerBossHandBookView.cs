using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000AC6 RID: 2758
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerBossHandBookView : UiViewBase
{
	// Token: 0x060072CF RID: 29391 RVA: 0x0023605C File Offset: 0x0023425C
	public WheelTowerBossHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060072D0 RID: 29392 RVA: 0x002360AC File Offset: 0x002342AC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060072D1 RID: 29393 RVA: 0x00236244 File Offset: 0x00234444
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerBossHandBookView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerBossHandBookView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060072D2 RID: 29394 RVA: 0x00236287 File Offset: 0x00234487
	private WheelTowerBossHandBookTitleItem CreateTitleItem()
	{
		return new WheelTowerBossHandBookTitleItem
		{
			OnClickToggleBack = new Action<NewTowerWave?, UUIExtendToggle>(this.OnClickTitle)
		};
	}

	// Token: 0x060072D3 RID: 29395 RVA: 0x002362A0 File Offset: 0x002344A0
	private WheelTowerBossHandBookModeItem CreateModeItem()
	{
		return new WheelTowerBossHandBookModeItem
		{
			OnClickToggleBack = new Action<bool, UUIExtendToggle, bool>(this.OnClickMode)
		};
	}

	// Token: 0x060072D4 RID: 29396 RVA: 0x002362B9 File Offset: 0x002344B9
	private WheelTowerBossHandBookBuffItem CreateBuffItem()
	{
		return new WheelTowerBossHandBookBuffItem();
	}

	// Token: 0x060072D5 RID: 29397 RVA: 0x002362C0 File Offset: 0x002344C0
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	private ValueTuple<List<int>, List<int>> GetBossHandBookInfoList(bool isEndless, int bossRound)
	{
		NewTowerClimbingLevelRecord levelRecord = WheelTowerModel.Instance.ActivityData.GetLevelRecord(isEndless);
		IReadOnlyList<NewTowerWave> waveConfigListByLevelId = WheelTowerConfig.Instance.GetWaveConfigListByLevelId(levelRecord.LevelId);
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		if (waveConfigListByLevelId != null)
		{
			int num = 0;
			foreach (NewTowerWave newTowerWave in waveConfigListByLevelId)
			{
				num = Math.Max(num, newTowerWave.Round);
			}
			int num2 = (bossRound > num) ? num : bossRound;
			foreach (NewTowerWave newTowerWave2 in waveConfigListByLevelId)
			{
				if (newTowerWave2.IsShowInView && newTowerWave2.Round == num2)
				{
					list.Add(newTowerWave2.Id);
					list2.Add(newTowerWave2.MonsterId);
				}
			}
		}
		return new ValueTuple<List<int>, List<int>>(list, list2);
	}

	// Token: 0x060072D6 RID: 29398 RVA: 0x002363C8 File Offset: 0x002345C8
	private void InitAllBossIdList()
	{
		ValueTuple<List<int>, List<int>> bossHandBookInfoList = this.GetBossHandBookInfoList(false, 1);
		this.NormalWaveIdList = bossHandBookInfoList.Item1;
		this.NormalBossIdList = bossHandBookInfoList.Item2;
		int round = WheelTowerModel.Instance.GetLastBossInfo(true).Round;
		int num = (this.SelectedBossRound != 0) ? this.SelectedBossRound : round;
		num = Math.Max(1, num);
		ValueTuple<List<int>, List<int>> bossHandBookInfoList2 = this.GetBossHandBookInfoList(true, num);
		this.EndlessWaveIdList = bossHandBookInfoList2.Item1;
		this.EndlessBossIdList = bossHandBookInfoList2.Item2;
	}

	// Token: 0x060072D7 RID: 29399 RVA: 0x00236444 File Offset: 0x00234644
	private void UpdateTitleDetailByMode(bool isEndless)
	{
		List<int> data = isEndless ? this.EndlessWaveIdList : this.NormalWaveIdList;
		List<int> list = isEndless ? this.EndlessBossIdList : this.NormalBossIdList;
		int targetIndex = list.IndexOf(this.SelectedBossId);
		if (targetIndex == -1)
		{
			targetIndex = 0;
		}
		this.TitleScroll.RefreshByData(data, true, delegate
		{
			this.TitleScroll.SelectGridProxy(targetIndex, true);
		}, false);
	}

	// Token: 0x060072D8 RID: 29400 RVA: 0x002364C0 File Offset: 0x002346C0
	private void UpdateModeDetailByBossId(int bossId)
	{
		List<bool> list = new List<bool>();
		if (this.NormalBossIdList.Contains(bossId))
		{
			list.Add(false);
		}
		if (this.EndlessBossIdList.Contains(bossId))
		{
			list.Add(true);
		}
		int targetIndex = list.IndexOf(this.IsCurEndless);
		if (targetIndex == -1)
		{
			targetIndex = 0;
		}
		this.ModeLayout.RefreshByData(list, delegate
		{
			this.ModeLayout.SelectGridProxy(targetIndex, false);
		}, false);
	}

	// Token: 0x060072D9 RID: 29401 RVA: 0x00236548 File Offset: 0x00234748
	private void UpdateBossInfoDetail(NewTowerWave waveConfig)
	{
		WheelTowerBossAttrData attrData = new WheelTowerBossAttrData
		{
			AttrName = waveConfig.Name,
			AttrLevel = waveConfig.MonsterLevel,
			ElementId = waveConfig.ElementId,
			TagIdList = waveConfig.TagIdListIter().ToList<int>()
		};
		this.AttrItem.Refresh(attrData);
		WheelTowerModel instance = WheelTowerModel.Instance;
		int lastChallengeRound = instance.GetLastChallengeRound(new bool?(this.IsCurEndless));
		int round = (this.SelectedTeamRound != -1) ? this.SelectedTeamRound : lastChallengeRound;
		MonsterInfoPreview bossInfoByRound = instance.GetBossInfoByRound(round, new bool?(this.IsCurEndless));
		List<IWheelTowerBossHandBookBuffData> list = new List<IWheelTowerBossHandBookBuffData>();
		foreach (DicIntIntArray dicIntIntArray in waveConfig.HandBookBuffIter())
		{
			list.Add(new WheelTowerBossHandBookBuffData
			{
				Round = dicIntIntArray.Key,
				BuffIdList = dicIntIntArray.Value.Value.ArrayIntIter().ToList<int>(),
				IsActivate = (bossInfoByRound.Round >= dicIntIntArray.Key)
			});
		}
		this.BuffScroll.RefreshByData(list, delegate
		{
			UUIInturnAnimController animationController = this.AnimationController;
			if (animationController == null)
			{
				return;
			}
			animationController.Play("", -1, false);
		}, false);
		base.SetTextureByPath(waveConfig.MonsterPortrait, base.GetTexture(1), null, null);
	}

	// Token: 0x060072DA RID: 29402 RVA: 0x002366B4 File Offset: 0x002348B4
	private void OnClickTitle(NewTowerWave? waveConfig, UUIExtendToggle toggle)
	{
		if (waveConfig == null)
		{
			return;
		}
		UUIExtendToggle currentTitleToggle = this.CurrentTitleToggle;
		if (currentTitleToggle != null)
		{
			currentTitleToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentTitleToggle = toggle;
		this.CurrentTitleToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		this.SelectedBossId = waveConfig.Value.MonsterId;
		this.UpdateBossInfoDetail(waveConfig.Value);
		this.UpdateModeDetailByBossId(waveConfig.Value.MonsterId);
		if (!this.IsForbidPlaySwitch || this.IsFirstEnter)
		{
			if (this.IsFirstEnter)
			{
				this.PlaySwitchSequenceNextFrameAsync().Forget();
			}
			else
			{
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence != null)
				{
					uiViewSequence.StopSequenceByKey("Switch", false, false);
				}
				UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
				if (uiViewSequence2 != null)
				{
					uiViewSequence2.PlaySequence("Switch", true, null);
				}
			}
		}
		this.IsForbidPlaySwitch = false;
		this.IsFirstEnter = false;
	}

	// Token: 0x060072DB RID: 29403 RVA: 0x0023679C File Offset: 0x0023499C
	private UniTask PlaySwitchSequenceNextFrameAsync()
	{
		WheelTowerBossHandBookView.<PlaySwitchSequenceNextFrameAsync>d__30 <PlaySwitchSequenceNextFrameAsync>d__;
		<PlaySwitchSequenceNextFrameAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySwitchSequenceNextFrameAsync>d__.<>4__this = this;
		<PlaySwitchSequenceNextFrameAsync>d__.<>1__state = -1;
		<PlaySwitchSequenceNextFrameAsync>d__.<>t__builder.Start<WheelTowerBossHandBookView.<PlaySwitchSequenceNextFrameAsync>d__30>(ref <PlaySwitchSequenceNextFrameAsync>d__);
		return <PlaySwitchSequenceNextFrameAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060072DC RID: 29404 RVA: 0x002367E0 File Offset: 0x002349E0
	private void OnClickMode(bool isEndless, UUIExtendToggle toggle, bool fireEvent)
	{
		UUIExtendToggle currentModeToggle = this.CurrentModeToggle;
		if (currentModeToggle != null)
		{
			currentModeToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentModeToggle = toggle;
		this.CurrentModeToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		if (!fireEvent)
		{
			return;
		}
		this.IsCurEndless = isEndless;
		this.IsForbidPlaySwitch = true;
		this.UpdateTitleDetailByMode(isEndless);
		UUIItem item = base.GetItem(9);
		if (item != null)
		{
			item.SetUIActive(isEndless);
		}
		UUIItem item2 = base.GetItem(10);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(!isEndless);
	}

	// Token: 0x040047E6 RID: 18406
	[Nullable(2)]
	private PopupCaptionItem Caption;

	// Token: 0x040047E7 RID: 18407
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<WheelTowerBossHandBookTitleItem, int> TitleScroll;

	// Token: 0x040047E8 RID: 18408
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<WheelTowerBossHandBookModeItem, bool> ModeLayout;

	// Token: 0x040047E9 RID: 18409
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<WheelTowerBossHandBookBuffItem, IWheelTowerBossHandBookBuffData> BuffScroll;

	// Token: 0x040047EA RID: 18410
	[Nullable(2)]
	private WheelTowerBossAttrItem AttrItem;

	// Token: 0x040047EB RID: 18411
	[Nullable(2)]
	private UUIExtendToggle CurrentTitleToggle;

	// Token: 0x040047EC RID: 18412
	[Nullable(2)]
	private UUIExtendToggle CurrentModeToggle;

	// Token: 0x040047ED RID: 18413
	[Nullable(2)]
	private UUIInturnAnimController AnimationController;

	// Token: 0x040047EE RID: 18414
	private bool IsCurEndless;

	// Token: 0x040047EF RID: 18415
	private bool IsForbidPlaySwitch;

	// Token: 0x040047F0 RID: 18416
	private bool IsFirstEnter = true;

	// Token: 0x040047F1 RID: 18417
	private List<int> NormalWaveIdList = new List<int>();

	// Token: 0x040047F2 RID: 18418
	private List<int> EndlessWaveIdList = new List<int>();

	// Token: 0x040047F3 RID: 18419
	private List<int> NormalBossIdList = new List<int>();

	// Token: 0x040047F4 RID: 18420
	private List<int> EndlessBossIdList = new List<int>();

	// Token: 0x040047F5 RID: 18421
	private int SelectedBossId;

	// Token: 0x040047F6 RID: 18422
	private int SelectedBossRound;

	// Token: 0x040047F7 RID: 18423
	private int SelectedTeamRound = -1;
}
