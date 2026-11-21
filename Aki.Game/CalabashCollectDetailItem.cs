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

// Token: 0x02000BF8 RID: 3064
[NullableContext(2)]
[Nullable(0)]
public class CalabashCollectDetailItem : UiPanelBase
{
	// Token: 0x06008006 RID: 32774 RVA: 0x00273414 File Offset: 0x00271614
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

	// Token: 0x06008007 RID: 32775 RVA: 0x002735FC File Offset: 0x002717FC
	private void OnPositionBtnClick()
	{
		CalabashDevelopReward? calabashDevelopReward;
		AdventureGuideController.Instance.JumpToTargetView(EUiTabViewName.MonsterDetectView, (CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(this.PhantomId) != null) ? new int?(calabashDevelopReward.GetValueOrDefault().MonsterProbeId) : null, null);
	}

	// Token: 0x06008008 RID: 32776 RVA: 0x00273654 File Offset: 0x00271854
	private void OnHelpBtnClick()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CalabashCollectSuitTipId);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06008009 RID: 32777 RVA: 0x00273678 File Offset: 0x00271878
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

	// Token: 0x0600800A RID: 32778 RVA: 0x00273754 File Offset: 0x00271954
	protected override UniTask OnBeforeStartAsync()
	{
		CalabashCollectDetailItem.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CalabashCollectDetailItem.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600800B RID: 32779 RVA: 0x00273797 File Offset: 0x00271997
	private void OnSuitItemClick(int id)
	{
		EventSystem.Instance.Emit<int>(EEventName.JumpToPhantomBattleFettersTabView, id);
	}

	// Token: 0x0600800C RID: 32780 RVA: 0x002737AA File Offset: 0x002719AA
	[NullableContext(1)]
	private VisionFetterSuitItem CreateVisionFetterSuitItem()
	{
		return new VisionFetterSuitItem(null)
		{
			OnItemClick = new Action<int>(this.OnSuitItemClick)
		};
	}

	// Token: 0x0600800D RID: 32781 RVA: 0x002737C4 File Offset: 0x002719C4
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

	// Token: 0x0600800E RID: 32782 RVA: 0x00273824 File Offset: 0x00271A24
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

	// Token: 0x0600800F RID: 32783 RVA: 0x00273871 File Offset: 0x00271A71
	public void Refresh()
	{
		this.RefreshTitle();
		this.RefreshStage();
		this.RefreshSuit();
		this.RefreshDesc();
		this.RefreshInfoItem();
		this.RefreshSkinBtn();
	}

	// Token: 0x06008010 RID: 32784 RVA: 0x00273898 File Offset: 0x00271A98
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

	// Token: 0x06008011 RID: 32785 RVA: 0x00273954 File Offset: 0x00271B54
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

	// Token: 0x06008012 RID: 32786 RVA: 0x002739C4 File Offset: 0x00271BC4
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

	// Token: 0x06008013 RID: 32787 RVA: 0x00273A50 File Offset: 0x00271C50
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

	// Token: 0x06008014 RID: 32788 RVA: 0x00273AB4 File Offset: 0x00271CB4
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

	// Token: 0x06008015 RID: 32789 RVA: 0x00273B38 File Offset: 0x00271D38
	public void RefreshInfoItem()
	{
		base.GetItem(12).SetUIActive(this.Data.UnlockData);
		base.GetButton(11).RootUIComp.Get().SetUIActive(this.Data.UnlockData);
	}

	// Token: 0x06008016 RID: 32790 RVA: 0x00273B84 File Offset: 0x00271D84
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

	// Token: 0x06008017 RID: 32791 RVA: 0x00273C0C File Offset: 0x00271E0C
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

	// Token: 0x06008018 RID: 32792 RVA: 0x00273C54 File Offset: 0x00271E54
	public void PlayDetailShowSequence()
	{
		LevelSequencePlayer infoLevelSequencePlayer = this.InfoLevelSequencePlayer;
		if (infoLevelSequencePlayer == null)
		{
			return;
		}
		infoLevelSequencePlayer.PlayLevelSequenceByName("Start", true, null, false);
	}

	// Token: 0x06008019 RID: 32793 RVA: 0x00273C84 File Offset: 0x00271E84
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

	// Token: 0x04004EBC RID: 20156
	private int PhantomId;

	// Token: 0x04004EBD RID: 20157
	private CalabashDevelopRewardData Data;

	// Token: 0x04004EBE RID: 20158
	private PhantomItem? ItemConfig;

	// Token: 0x04004EBF RID: 20159
	[Nullable(1)]
	private readonly List<CalabashCollectStageItem> StageItemList = new List<CalabashCollectStageItem>();

	// Token: 0x04004EC0 RID: 20160
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<VisionFetterSuitItem, PhantomFetterGroup> SuitLayout;

	// Token: 0x04004EC1 RID: 20161
	private LevelSequencePlayer InfoLevelSequencePlayer;

	// Token: 0x04004EC2 RID: 20162
	private int[] SkinList;

	// Token: 0x04004EC3 RID: 20163
	private int ShowSkinIndex;

	// Token: 0x04004EC4 RID: 20164
	public Action OnLookOverBtnClick;

	// Token: 0x04004EC5 RID: 20165
	public Action<int, bool> OnMonsterSkinBtnClickCallBack;

	// Token: 0x02006EAC RID: 28332
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040242E5 RID: 148197
		NameText,
		// Token: 0x040242E6 RID: 148198
		LevelText,
		// Token: 0x040242E7 RID: 148199
		StageBarTexture,
		// Token: 0x040242E8 RID: 148200
		StageItem1,
		// Token: 0x040242E9 RID: 148201
		StageItem2,
		// Token: 0x040242EA RID: 148202
		StageItem3,
		// Token: 0x040242EB RID: 148203
		StageItem4,
		// Token: 0x040242EC RID: 148204
		HelpBtn,
		// Token: 0x040242ED RID: 148205
		SuitLayout,
		// Token: 0x040242EE RID: 148206
		DescText,
		// Token: 0x040242EF RID: 148207
		PositionBtn,
		// Token: 0x040242F0 RID: 148208
		LookOverBtn,
		// Token: 0x040242F1 RID: 148209
		InfoItem,
		// Token: 0x040242F2 RID: 148210
		SuitItem,
		// Token: 0x040242F3 RID: 148211
		DescItem,
		// Token: 0x040242F4 RID: 148212
		MonsterSkinBtn
	}
}
