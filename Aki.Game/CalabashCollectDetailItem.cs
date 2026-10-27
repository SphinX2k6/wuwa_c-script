using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200173F RID: 5951
[NullableContext(2)]
[Nullable(0)]
public class CalabashCollectDetailItem : UiPanelBase
{
	// Token: 0x0600AC1F RID: 44063 RVA: 0x00268FD8 File Offset: 0x002671D8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(10, new Action(this.OnPositionBtnClick)),
			new ValueTuple<int, Delegate>(7, new Action(this.OnHelpBtnClick)),
			new ValueTuple<int, Delegate>(11, this.OnLookOverBtnClick),
			new ValueTuple<int, Delegate>(15, new Action(this.OnMonsterSkinBtnClick))
		};
	}

	// Token: 0x0600AC20 RID: 44064 RVA: 0x002691C0 File Offset: 0x002673C0
	private void OnPositionBtnClick()
	{
		CalabashDevelopReward? calabashDevelopReward;
		AdventureGuideController.Instance.JumpToTargetView(EUiTabViewName.MonsterDetectView, (CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(this.PhantomId) != null) ? new int?(calabashDevelopReward.GetValueOrDefault().MonsterProbeId) : null, null);
	}

	// Token: 0x0600AC21 RID: 44065 RVA: 0x00269218 File Offset: 0x00267418
	private void OnHelpBtnClick()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CalabashCollectSuitTipId);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600AC22 RID: 44066 RVA: 0x0026923C File Offset: 0x0026743C
	private void OnMonsterSkinBtnClick()
	{
		if (this.SkinList == null)
		{
			return;
		}
		this.ShowSkinIndex++;
		if (this.ShowSkinIndex >= this.SkinList.Length)
		{
			this.ShowSkinIndex = 0;
		}
		if (this.OnMonsterSkinBtnClickCallBack != null)
		{
			int monsterId = PhantomBattleConfig.Instance.GetPhantomItemById(this.SkinList[this.ShowSkinIndex]).Value.MonsterId;
			bool flag = (this.ShowSkinIndex == 0) ? (!this.Data.UnlockData) : (this.ShowSkinIndex > 0 && !PhantomBattleModel.Instance.GetSkinIsUnlock(this.SkinList[this.ShowSkinIndex]));
			this.OnMonsterSkinBtnClickCallBack(monsterId, flag);
			base.GetButton(11).RootUIComp.Get().SetUIActive(!flag);
		}
	}

	// Token: 0x0600AC23 RID: 44067 RVA: 0x00269318 File Offset: 0x00267518
	protected override UniTask OnBeforeStartAsync()
	{
		CalabashCollectDetailItem.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CalabashCollectDetailItem.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AC24 RID: 44068 RVA: 0x0026935B File Offset: 0x0026755B
	private void OnSuitItemClick(int id)
	{
		EventSystem.Instance.Emit<int>(EEventName.JumpToPhantomBattleFettersTabView, id);
	}

	// Token: 0x0600AC25 RID: 44069 RVA: 0x0026936E File Offset: 0x0026756E
	[NullableContext(1)]
	private VisionFetterSuitItem CreateVisionFetterSuitItem()
	{
		return new VisionFetterSuitItem(null)
		{
			OnItemClick = new Action<int>(this.OnSuitItemClick)
		};
	}

	// Token: 0x0600AC26 RID: 44070 RVA: 0x00269388 File Offset: 0x00267588
	[NullableContext(1)]
	public void Update(CalabashDevelopRewardData data)
	{
		this.Data = data;
		CalabashDevelopRewardData data2 = this.Data;
		this.PhantomId = ((data2 != null) ? data2.DevelopRewardData.MonsterId : 0);
		int[] phantomItemIdArrayByMonsterId = PhantomBattleModel.Instance.GetPhantomItemIdArrayByMonsterId(this.PhantomId);
		this.ItemConfig = InventoryConfig.Instance.GetPhantomItemConfig(phantomItemIdArrayByMonsterId[0]);
		this.Refresh();
	}

	// Token: 0x0600AC27 RID: 44071 RVA: 0x002693E8 File Offset: 0x002675E8
	public void UpdateSkinInfo(int data)
	{
		this.PhantomId = data;
		int[] phantomItemIdArrayByMonsterId = PhantomBattleModel.Instance.GetPhantomItemIdArrayByMonsterId(this.PhantomId);
		this.ItemConfig = InventoryConfig.Instance.GetPhantomItemConfig(phantomItemIdArrayByMonsterId[0]);
		if (this.ShowSkinIndex != 0)
		{
			this.RefreshTitleBySkinId();
			return;
		}
		this.RefreshTitle();
	}

	// Token: 0x0600AC28 RID: 44072 RVA: 0x00269435 File Offset: 0x00267635
	public void Refresh()
	{
		this.RefreshTitle();
		this.RefreshStage();
		this.RefreshSuit();
		this.RefreshDesc();
		this.RefreshInfoItem();
		this.RefreshSkinBtn();
	}

	// Token: 0x0600AC29 RID: 44073 RVA: 0x0026945C File Offset: 0x0026765C
	public void RefreshTitle()
	{
		CalabashDevelopRewardData data = this.Data;
		if (!data.UnlockData)
		{
			return;
		}
		string monsterNumber = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(this.PhantomId).Value.MonsterNumber;
		IReadOnlyList<PhantomItem> phantomItemByMonsterId = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(this.PhantomId);
		PhantomRarity? phantomRareConfig = PhantomBattleConfig.Instance.GetPhantomRareConfig(phantomItemByMonsterId[0].Rarity);
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(data.SkillName, null);
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText(monsterNumber + localTextNew, true);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), phantomRareConfig.Value.Desc, Array.Empty<object>());
	}

	// Token: 0x0600AC2A RID: 44074 RVA: 0x00269518 File Offset: 0x00267718
	public void RefreshTitleBySkinId()
	{
		if (!this.Data.UnlockData)
		{
			return;
		}
		string monsterNumber = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(this.PhantomId).Value.MonsterNumber;
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(this.ItemConfig.Value.MonsterName, null);
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.SetText(monsterNumber + localTextNew, true);
	}

	// Token: 0x0600AC2B RID: 44075 RVA: 0x00269588 File Offset: 0x00267788
	public void RefreshStage()
	{
		ICalabashDevelopRewardInfoData[] calabashDevelopRewardInfoData = CalabashModel.Instance.GetCalabashDevelopRewardInfoData(this.PhantomId);
		if (calabashDevelopRewardInfoData == null || calabashDevelopRewardInfoData.Length != this.StageItemList.Count)
		{
			return;
		}
		int num = calabashDevelopRewardInfoData.Length;
		int num2 = -1;
		for (int i = 0; i < this.StageItemList.Count; i++)
		{
			ICalabashDevelopRewardInfoData calabashDevelopRewardInfoData2 = calabashDevelopRewardInfoData[i];
			this.StageItemList[i].Refresh(calabashDevelopRewardInfoData2, false, i);
			if (calabashDevelopRewardInfoData2.IsUnlock)
			{
				num2 = i;
			}
		}
		UUITexture texture = base.GetTexture(2);
		if (texture == null)
		{
			return;
		}
		texture.SetFillAmount((float)num2 / (float)(num - 1));
	}

	// Token: 0x0600AC2C RID: 44076 RVA: 0x00269614 File Offset: 0x00267814
	public void RefreshSuit()
	{
		int[] array = this.ItemConfig.Value.FetterGroup();
		List<PhantomFetterGroup> list = new List<PhantomFetterGroup>();
		foreach (int groupId in array)
		{
			PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(groupId);
			list.Add(fetterGroupById);
		}
		GenericLayout<VisionFetterSuitItem, PhantomFetterGroup> suitLayout = this.SuitLayout;
		if (suitLayout == null)
		{
			return;
		}
		suitLayout.RefreshByData(list, null, false);
	}

	// Token: 0x0600AC2D RID: 44077 RVA: 0x00269678 File Offset: 0x00267878
	public void RefreshDesc()
	{
		PhantomSkill? phantomSkillBySkillId = PhantomBattleConfig.Instance.GetPhantomSkillBySkillId(this.ItemConfig.Value.SkillId);
		if (phantomSkillBySkillId == null || StringUtils.IsEmpty(phantomSkillBySkillId.Value.SimplyDescription))
		{
			base.GetText(9).SetText("", true);
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), phantomSkillBySkillId.Value.SimplyDescription, Array.Empty<object>());
	}

	// Token: 0x0600AC2E RID: 44078 RVA: 0x002696FC File Offset: 0x002678FC
	public void RefreshInfoItem()
	{
		base.GetItem(12).SetUIActive(this.Data.UnlockData);
		base.GetButton(11).RootUIComp.Get().SetUIActive(this.Data.UnlockData);
	}

	// Token: 0x0600AC2F RID: 44079 RVA: 0x00269748 File Offset: 0x00267948
	public void RefreshSkinBtn()
	{
		int[] monsterSkinListByMonsterId = PhantomBattleModel.Instance.GetMonsterSkinListByMonsterId(this.Data.DevelopRewardData.MonsterId);
		if (monsterSkinListByMonsterId == null)
		{
			base.GetButton(15).RootUIComp.Get().SetUIActive(false);
			return;
		}
		base.GetButton(15).RootUIComp.Get().SetUIActive(this.Data.UnlockData && monsterSkinListByMonsterId.Length > 1);
		this.SkinList = monsterSkinListByMonsterId;
		this.ShowSkinIndex = 0;
	}

	// Token: 0x0600AC30 RID: 44080 RVA: 0x002697D0 File Offset: 0x002679D0
	public void RefreshDetailState()
	{
		bool ifSimpleState = CalabashModel.Instance.GetIfSimpleState();
		UUIItem item = base.GetItem(14);
		if (item != null)
		{
			item.SetUIActive(!ifSimpleState);
		}
		UUIItem item2 = base.GetItem(13);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(!ifSimpleState);
	}

	// Token: 0x0600AC31 RID: 44081 RVA: 0x00269818 File Offset: 0x00267A18
	public void PlayDetailShowSequence()
	{
		LevelSequencePlayer infoLevelSequencePlayer = this.InfoLevelSequencePlayer;
		if (infoLevelSequencePlayer == null)
		{
			return;
		}
		infoLevelSequencePlayer.PlayLevelSequenceByName("Start", true, null, false);
	}

	// Token: 0x0600AC32 RID: 44082 RVA: 0x00269848 File Offset: 0x00267A48
	public void PlayDetailHideSequence()
	{
		UUIItem item = base.GetItem(14);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUIItem item2 = base.GetItem(13);
		if (item2 != null)
		{
			item2.SetUIActive(true);
		}
		LevelSequencePlayer infoLevelSequencePlayer = this.InfoLevelSequencePlayer;
		if (infoLevelSequencePlayer == null)
		{
			return;
		}
		infoLevelSequencePlayer.PlayLevelSequenceByName("Close", true, null, false);
	}

	// Token: 0x04004E13 RID: 19987
	private int PhantomId;

	// Token: 0x04004E14 RID: 19988
	private CalabashDevelopRewardData Data;

	// Token: 0x04004E15 RID: 19989
	private PhantomItem? ItemConfig;

	// Token: 0x04004E16 RID: 19990
	[Nullable(1)]
	private readonly List<CalabashCollectStageItem> StageItemList = new List<CalabashCollectStageItem>();

	// Token: 0x04004E17 RID: 19991
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<VisionFetterSuitItem, PhantomFetterGroup> SuitLayout;

	// Token: 0x04004E18 RID: 19992
	private LevelSequencePlayer InfoLevelSequencePlayer;

	// Token: 0x04004E19 RID: 19993
	private int[] SkinList;

	// Token: 0x04004E1A RID: 19994
	private int ShowSkinIndex;

	// Token: 0x04004E1B RID: 19995
	public Action OnLookOverBtnClick;

	// Token: 0x04004E1C RID: 19996
	public Action<int, bool> OnMonsterSkinBtnClickCallBack;

	// Token: 0x02007D26 RID: 32038
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04028FBB RID: 167867
		NameText,
		// Token: 0x04028FBC RID: 167868
		LevelText,
		// Token: 0x04028FBD RID: 167869
		StageBarTexture,
		// Token: 0x04028FBE RID: 167870
		StageItem1,
		// Token: 0x04028FBF RID: 167871
		StageItem2,
		// Token: 0x04028FC0 RID: 167872
		StageItem3,
		// Token: 0x04028FC1 RID: 167873
		StageItem4,
		// Token: 0x04028FC2 RID: 167874
		HelpBtn,
		// Token: 0x04028FC3 RID: 167875
		SuitLayout,
		// Token: 0x04028FC4 RID: 167876
		DescText,
		// Token: 0x04028FC5 RID: 167877
		PositionBtn,
		// Token: 0x04028FC6 RID: 167878
		LookOverBtn,
		// Token: 0x04028FC7 RID: 167879
		InfoItem,
		// Token: 0x04028FC8 RID: 167880
		SuitItem,
		// Token: 0x04028FC9 RID: 167881
		DescItem,
		// Token: 0x04028FCA RID: 167882
		MonsterSkinBtn
	}
}
