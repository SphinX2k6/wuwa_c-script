using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001681 RID: 5761
[NullableContext(1)]
[Nullable(0)]
public class LordGymChallengeRecordView : UiViewBase
{
	// Token: 0x0600E02D RID: 57389 RVA: 0x0041C8C2 File Offset: 0x0041AAC2
	public LordGymChallengeRecordView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E02E RID: 57390 RVA: 0x0041C8EC File Offset: 0x0041AAEC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickPrevDifficulty)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickNextDifficulty))
		};
	}

	// Token: 0x0600E02F RID: 57391 RVA: 0x0041CA08 File Offset: 0x0041AC08
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymChallengeRecordView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymChallengeRecordView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E030 RID: 57392 RVA: 0x0041CA4C File Offset: 0x0041AC4C
	protected override void OnStart()
	{
		int defaultTabIndex = this.GetDefaultTabIndex();
		this.SelectedFilterTypeId = ((this.FilterTypeList.Count > 0) ? this.FilterTypeList[defaultTabIndex].Id : 0);
		if (this.DefaultDifficulty > 0)
		{
			this.SelectedDifficulty = this.DefaultDifficulty;
		}
		this.RefreshAllTabToggleState();
		this.RefreshDifficultyState();
		this.UpdateRecordScrollView();
	}

	// Token: 0x0600E031 RID: 57393 RVA: 0x0041CAB4 File Offset: 0x0041ACB4
	private void RefreshAllTabToggleState()
	{
		GenericScrollViewNew<LordGymFilterTypeTabItem, LordGymFilterType> tabScroll = this.TabScroll;
		foreach (LordGymFilterTypeTabItem lordGymFilterTypeTabItem in (((tabScroll != null) ? tabScroll.GetScrollItemList() : null) ?? new List<LordGymFilterTypeTabItem>()))
		{
			lordGymFilterTypeTabItem.SetToggleActive(lordGymFilterTypeTabItem.GetFilterTypeId() == this.SelectedFilterTypeId);
		}
	}

	// Token: 0x0600E032 RID: 57394 RVA: 0x0041CB28 File Offset: 0x0041AD28
	protected override void OnBeforeDestroy()
	{
		this.TabScroll = null;
		this.RecordScroll = null;
		this.CaptionItem = null;
		this.SeqPlayer = null;
	}

	// Token: 0x0600E033 RID: 57395 RVA: 0x0041CB48 File Offset: 0x0041AD48
	private void PlaySwitchSequence()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.StopSequenceByKey(this.SwitchSequenceName, false, false);
		}
		LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
		if (seqPlayer2 == null)
		{
			return;
		}
		seqPlayer2.PlayLevelSequenceByName(this.SwitchSequenceName, false, null, false);
	}

	// Token: 0x0600E034 RID: 57396 RVA: 0x0041CB90 File Offset: 0x0041AD90
	private int GetDefaultTabIndex()
	{
		if (this.FilterTypeList.Count == 0)
		{
			return 0;
		}
		if (this.DefaultLordEntranceId > 0)
		{
			LordGymConfig instance = LordGymConfig.Instance;
			int[] lordGymEntranceLordList = instance.GetLordGymEntranceLordList(this.DefaultLordEntranceId);
			if (lordGymEntranceLordList != null)
			{
				foreach (int lordId in lordGymEntranceLordList)
				{
					LordGym? lordGymConfig = instance.GetLordGymConfig(lordId);
					if (lordGymConfig != null)
					{
						int filterType = lordGymConfig.Value.FilterType;
						for (int j = 0; j < this.FilterTypeList.Count; j++)
						{
							if (this.FilterTypeList[j].Id == filterType)
							{
								return j;
							}
						}
					}
				}
			}
		}
		return 0;
	}

	// Token: 0x0600E035 RID: 57397 RVA: 0x0041CC40 File Offset: 0x0041AE40
	private bool MatchesSelectedFilter(LordGym config)
	{
		return config.FilterType == this.SelectedFilterTypeId;
	}

	// Token: 0x0600E036 RID: 57398 RVA: 0x0041CC51 File Offset: 0x0041AE51
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600E037 RID: 57399 RVA: 0x0041CC5A File Offset: 0x0041AE5A
	private void OnSelectTab(int filterTypeId)
	{
		if (this.SelectedFilterTypeId == filterTypeId)
		{
			this.RefreshAllTabToggleState();
			return;
		}
		this.SelectedFilterTypeId = filterTypeId;
		this.RefreshAllTabToggleState();
		this.RefreshDifficultyState();
		this.UpdateRecordScrollView();
		this.PlaySwitchSequence();
	}

	// Token: 0x0600E038 RID: 57400 RVA: 0x0041CC8C File Offset: 0x0041AE8C
	private void OnClickPrevDifficulty()
	{
		int num = this.AvailableDifficulties.IndexOf(this.SelectedDifficulty);
		if (num <= 0)
		{
			return;
		}
		this.SelectedDifficulty = this.AvailableDifficulties[num - 1];
		this.UpdateDifficultyLabel();
		this.UpdateRecordScrollView();
		this.PlaySwitchSequence();
	}

	// Token: 0x0600E039 RID: 57401 RVA: 0x0041CCD8 File Offset: 0x0041AED8
	private void OnClickNextDifficulty()
	{
		int num = this.AvailableDifficulties.IndexOf(this.SelectedDifficulty);
		if (num < 0 || num >= this.AvailableDifficulties.Count - 1)
		{
			return;
		}
		this.SelectedDifficulty = this.AvailableDifficulties[num + 1];
		this.UpdateDifficultyLabel();
		this.UpdateRecordScrollView();
		this.PlaySwitchSequence();
	}

	// Token: 0x0600E03A RID: 57402 RVA: 0x0041CD34 File Offset: 0x0041AF34
	private void RefreshDifficultyState()
	{
		this.AvailableDifficulties = this.ComputeAvailableDifficulties();
		if (this.AvailableDifficulties.Count > 0)
		{
			if (!this.AvailableDifficulties.Contains(this.SelectedDifficulty))
			{
				this.SelectedDifficulty = this.AvailableDifficulties[0];
			}
		}
		else
		{
			this.SelectedDifficulty = 0;
		}
		this.UpdateDifficultyLabel();
		this.UpdateDifficultyButtons();
	}

	// Token: 0x0600E03B RID: 57403 RVA: 0x0041CD98 File Offset: 0x0041AF98
	private List<int> ComputeAvailableDifficulties()
	{
		List<int> list = new List<int>();
		if (this.SelectedFilterTypeId == 0)
		{
			return list;
		}
		IReadOnlyList<LordGym> lordGymAllConfig = LordGymConfig.Instance.GetLordGymAllConfig();
		if (lordGymAllConfig == null)
		{
			return list;
		}
		HashSet<int> hashSet = new HashSet<int>();
		foreach (LordGym config in lordGymAllConfig)
		{
			if (!config.IsDebug && this.MatchesSelectedFilter(config) && LordGymModel.Instance.GetLordGymIsUnLock(config.Id))
			{
				hashSet.Add(config.Difficulty);
			}
		}
		list.AddRange(hashSet);
		list.Sort((int a, int b) => a - b);
		return list;
	}

	// Token: 0x0600E03C RID: 57404 RVA: 0x0041CE64 File Offset: 0x0041B064
	private void UpdateDifficultyLabel()
	{
		UUIText text = base.GetText(5);
		if (text == null)
		{
			return;
		}
		if (this.SelectedDifficulty == 0)
		{
			text.SetUIActive(false);
			return;
		}
		text.SetUIActive(true);
		LguiUtil.Instance.SetLocalTextNew(text, "LordGymDifficulty", new <>z__ReadOnlySingleElementList<object>(this.SelectedDifficulty));
	}

	// Token: 0x0600E03D RID: 57405 RVA: 0x0041CEB4 File Offset: 0x0041B0B4
	private void UpdateDifficultyButtons()
	{
		bool uiactive = this.AvailableDifficulties.Count > 1;
		UUIButtonComponent button = base.GetButton(3);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(uiactive);
		}
		UUIButtonComponent button2 = base.GetButton(4);
		if (button2 == null)
		{
			return;
		}
		button2.RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x0600E03E RID: 57406 RVA: 0x0041CF10 File Offset: 0x0041B110
	private List<LordGym> GetLordList()
	{
		List<LordGym> list = new List<LordGym>();
		if (this.SelectedFilterTypeId == 0 || this.SelectedDifficulty == 0)
		{
			return list;
		}
		IReadOnlyList<LordGym> lordGymAllConfig = LordGymConfig.Instance.GetLordGymAllConfig();
		if (lordGymAllConfig == null)
		{
			return list;
		}
		foreach (LordGym lordGym in lordGymAllConfig)
		{
			if (!lordGym.IsDebug && this.MatchesSelectedFilter(lordGym) && lordGym.Difficulty == this.SelectedDifficulty && LordGymModel.Instance.GetLordGymIsUnLock(lordGym.Id))
			{
				list.Add(lordGym);
			}
		}
		list.Sort((LordGym a, LordGym b) => a.Id - b.Id);
		return list;
	}

	// Token: 0x0600E03F RID: 57407 RVA: 0x0041CFDC File Offset: 0x0041B1DC
	private void UpdateRecordScrollView()
	{
		List<LordGym> lordList = this.GetLordList();
		this.RecordScroll.RefreshByData(lordList, null, false);
		UUIItem item = base.GetItem(8);
		if (item != null)
		{
			item.SetUIActive(lordList.Count == 0);
		}
		this.RecordScroll.SetActive(lordList.Count > 0);
	}

	// Token: 0x0600E040 RID: 57408 RVA: 0x0041D02D File Offset: 0x0041B22D
	private LordGymFilterTypeTabItem CreateTabItem()
	{
		return new LordGymFilterTypeTabItem(new Action<int>(this.OnSelectTab));
	}

	// Token: 0x0600E041 RID: 57409 RVA: 0x0041D040 File Offset: 0x0041B240
	private LordGymRecordItem CreateRecordItem()
	{
		return new LordGymRecordItem();
	}

	// Token: 0x040080A5 RID: 32933
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040080A6 RID: 32934
	private int DefaultLordEntranceId;

	// Token: 0x040080A7 RID: 32935
	private int DefaultDifficulty;

	// Token: 0x040080A8 RID: 32936
	private int SelectedFilterTypeId;

	// Token: 0x040080A9 RID: 32937
	private int SelectedDifficulty;

	// Token: 0x040080AA RID: 32938
	private List<int> AvailableDifficulties = new List<int>();

	// Token: 0x040080AB RID: 32939
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<LordGymFilterTypeTabItem, LordGymFilterType> TabScroll;

	// Token: 0x040080AC RID: 32940
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<LordGymRecordItem, LordGym> RecordScroll;

	// Token: 0x040080AD RID: 32941
	private List<LordGymFilterType> FilterTypeList = new List<LordGymFilterType>();

	// Token: 0x040080AE RID: 32942
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x040080AF RID: 32943
	private readonly string SwitchSequenceName = "switch";

	// Token: 0x02007851 RID: 30801
	[NullableContext(0)]
	private class EChallengeRecordComponents
	{
		// Token: 0x040270BE RID: 159934
		public const int Caption = 0;

		// Token: 0x040270BF RID: 159935
		public const int SvTabLordGym = 1;

		// Token: 0x040270C0 RID: 159936
		public const int PnlTab = 2;

		// Token: 0x040270C1 RID: 159937
		public const int BtnFunctionL = 3;

		// Token: 0x040270C2 RID: 159938
		public const int BtnFunctionR = 4;

		// Token: 0x040270C3 RID: 159939
		public const int TxtDifficult = 5;

		// Token: 0x040270C4 RID: 159940
		public const int ScrollView = 6;

		// Token: 0x040270C5 RID: 159941
		public const int PnlList = 7;

		// Token: 0x040270C6 RID: 159942
		public const int UiItemEmpty = 8;
	}
}
