using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200219D RID: 8605
[NullableContext(1)]
[Nullable(0)]
public class LordGymChallengeRecordView : UiViewBase
{
	// Token: 0x06010B9C RID: 68508 RVA: 0x0040FFD7 File Offset: 0x0040E1D7
	public LordGymChallengeRecordView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010B9D RID: 68509 RVA: 0x00410004 File Offset: 0x0040E204
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

	// Token: 0x06010B9E RID: 68510 RVA: 0x00410120 File Offset: 0x0040E320
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymChallengeRecordView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymChallengeRecordView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010B9F RID: 68511 RVA: 0x00410164 File Offset: 0x0040E364
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

	// Token: 0x06010BA0 RID: 68512 RVA: 0x004101CC File Offset: 0x0040E3CC
	private void RefreshAllTabToggleState()
	{
		GenericScrollViewNew<LordGymFilterTypeTabItem, LordGymFilterType> tabScroll = this.TabScroll;
		foreach (LordGymFilterTypeTabItem lordGymFilterTypeTabItem in (((tabScroll != null) ? tabScroll.GetScrollItemList() : null) ?? new List<LordGymFilterTypeTabItem>()))
		{
			lordGymFilterTypeTabItem.SetToggleActive(lordGymFilterTypeTabItem.GetFilterTypeId() == this.SelectedFilterTypeId);
		}
	}

	// Token: 0x06010BA1 RID: 68513 RVA: 0x00410240 File Offset: 0x0040E440
	protected override void OnBeforeDestroy()
	{
		this.TabScroll = null;
		this.RecordScroll = null;
		this.CaptionItem = null;
		this.SeqPlayer = null;
	}

	// Token: 0x06010BA2 RID: 68514 RVA: 0x00410260 File Offset: 0x0040E460
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

	// Token: 0x06010BA3 RID: 68515 RVA: 0x004102A8 File Offset: 0x0040E4A8
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

	// Token: 0x06010BA4 RID: 68516 RVA: 0x00410358 File Offset: 0x0040E558
	private bool MatchesSelectedFilter(LordGym config)
	{
		return config.FilterType == this.SelectedFilterTypeId;
	}

	// Token: 0x06010BA5 RID: 68517 RVA: 0x00410369 File Offset: 0x0040E569
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06010BA6 RID: 68518 RVA: 0x00410372 File Offset: 0x0040E572
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

	// Token: 0x06010BA7 RID: 68519 RVA: 0x004103A4 File Offset: 0x0040E5A4
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

	// Token: 0x06010BA8 RID: 68520 RVA: 0x004103F0 File Offset: 0x0040E5F0
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

	// Token: 0x06010BA9 RID: 68521 RVA: 0x0041044C File Offset: 0x0040E64C
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

	// Token: 0x06010BAA RID: 68522 RVA: 0x004104B0 File Offset: 0x0040E6B0
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

	// Token: 0x06010BAB RID: 68523 RVA: 0x0041057C File Offset: 0x0040E77C
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

	// Token: 0x06010BAC RID: 68524 RVA: 0x004105CC File Offset: 0x0040E7CC
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

	// Token: 0x06010BAD RID: 68525 RVA: 0x00410628 File Offset: 0x0040E828
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

	// Token: 0x06010BAE RID: 68526 RVA: 0x004106F4 File Offset: 0x0040E8F4
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

	// Token: 0x06010BAF RID: 68527 RVA: 0x00410745 File Offset: 0x0040E945
	private LordGymFilterTypeTabItem CreateTabItem()
	{
		return new LordGymFilterTypeTabItem(new Action<int>(this.OnSelectTab));
	}

	// Token: 0x06010BB0 RID: 68528 RVA: 0x00410758 File Offset: 0x0040E958
	private LordGymRecordItem CreateRecordItem()
	{
		return new LordGymRecordItem();
	}

	// Token: 0x04007F5E RID: 32606
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04007F5F RID: 32607
	private int DefaultLordEntranceId;

	// Token: 0x04007F60 RID: 32608
	private int DefaultDifficulty;

	// Token: 0x04007F61 RID: 32609
	private int SelectedFilterTypeId;

	// Token: 0x04007F62 RID: 32610
	private int SelectedDifficulty;

	// Token: 0x04007F63 RID: 32611
	private List<int> AvailableDifficulties = new List<int>();

	// Token: 0x04007F64 RID: 32612
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<LordGymFilterTypeTabItem, LordGymFilterType> TabScroll;

	// Token: 0x04007F65 RID: 32613
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<LordGymRecordItem, LordGym> RecordScroll;

	// Token: 0x04007F66 RID: 32614
	private List<LordGymFilterType> FilterTypeList = new List<LordGymFilterType>();

	// Token: 0x04007F67 RID: 32615
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04007F68 RID: 32616
	private readonly string SwitchSequenceName = "switch";

	// Token: 0x020086C6 RID: 34502
	[NullableContext(0)]
	private class EChallengeRecordComponents
	{
		// Token: 0x0402BD9D RID: 179613
		public const int Caption = 0;

		// Token: 0x0402BD9E RID: 179614
		public const int SvTabLordGym = 1;

		// Token: 0x0402BD9F RID: 179615
		public const int PnlTab = 2;

		// Token: 0x0402BDA0 RID: 179616
		public const int BtnFunctionL = 3;

		// Token: 0x0402BDA1 RID: 179617
		public const int BtnFunctionR = 4;

		// Token: 0x0402BDA2 RID: 179618
		public const int TxtDifficult = 5;

		// Token: 0x0402BDA3 RID: 179619
		public const int ScrollView = 6;

		// Token: 0x0402BDA4 RID: 179620
		public const int PnlList = 7;

		// Token: 0x0402BDA5 RID: 179621
		public const int UiItemEmpty = 8;
	}
}
