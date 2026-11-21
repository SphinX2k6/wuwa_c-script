using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000861 RID: 2145
[NullableContext(1)]
[Nullable(0)]
public class ActivitySubViewNewcomerSignIn : ActivitySubViewBase
{
	// Token: 0x0600610F RID: 24847 RVA: 0x001F002C File Offset: 0x001EE22C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 19;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.ClickLeftBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.ClickRightBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.ClickWeaponBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.ClickFreeRewardBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06006110 RID: 24848 RVA: 0x001F0379 File Offset: 0x001EE579
	private void ClickLeftBtn()
	{
		this.SetGrandRewardShowIndex(this.SelectGrandRewardIndex - 1);
	}

	// Token: 0x06006111 RID: 24849 RVA: 0x001F0389 File Offset: 0x001EE589
	private void ClickRightBtn()
	{
		this.SetGrandRewardShowIndex(this.SelectGrandRewardIndex + 1);
	}

	// Token: 0x06006112 RID: 24850 RVA: 0x001F039C File Offset: 0x001EE59C
	private void ClickWeaponBtn()
	{
		if (this.SelectGrandRewardIndex < 0 || this.SelectGrandRewardIndex >= this.GrandRewardConfigs.Count)
		{
			return;
		}
		ActivitySignGrandReward? activitySignGrandReward = this.GrandRewardConfigs[this.SelectGrandRewardIndex];
		if (activitySignGrandReward == null || activitySignGrandReward.Value.PreviewType != 2)
		{
			return;
		}
		WeaponTrialData[] array = new WeaponTrialData[activitySignGrandReward.Value.PreviewListLength];
		for (int i = 0; i < array.Length; i++)
		{
			int trialId = activitySignGrandReward.Value.PreviewList(i);
			WeaponTrialData weaponTrialData = new WeaponTrialData();
			weaponTrialData.SetTrialId(trialId, true);
			array[i] = weaponTrialData;
		}
		WeaponPreviewViewParam weaponPreviewViewParam = new WeaponPreviewViewParam();
		WeaponDataBase[] weaponDataList = array;
		weaponPreviewViewParam.WeaponDataList = weaponDataList;
		weaponPreviewViewParam.SelectedIndex = 0;
		IWeaponPreviewViewParam param = weaponPreviewViewParam;
		UiManager.Instance.OpenView(EUiViewName.WeaponPreviewView, param, null);
	}

	// Token: 0x06006113 RID: 24851 RVA: 0x001F0470 File Offset: 0x001EE670
	private void ClickFreeRewardBtn()
	{
		if (this.ActivitySignData != null && !this.ActivitySignData.GetFreeRewardIsGet())
		{
			ActivitySevenDaySignController.Instance.GetActivityFreeDrop(this.ActivitySignData.Id);
			return;
		}
		if (this.ActivitySignConfig == null)
		{
			return;
		}
		List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(this.ActivitySignConfig.Value.FreeDropId);
		ItemController.Instance.OpenItemTipsByItemId(dropPackagePreviewItemList[0].ItemData.ItemId, true, null, false);
	}

	// Token: 0x06006114 RID: 24852 RVA: 0x001F04F4 File Offset: 0x001EE6F4
	private void ClickCharacterDetailBtn()
	{
		if (this.SelectGrandRewardIndex < 0 || this.SelectGrandRewardIndex >= this.GrandRewardConfigs.Count)
		{
			return;
		}
		ActivitySignGrandReward? activitySignGrandReward = this.GrandRewardConfigs[this.SelectGrandRewardIndex];
		if (activitySignGrandReward == null || activitySignGrandReward.Value.PreviewType != 1)
		{
			return;
		}
		RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, 0, new List<int>(activitySignGrandReward.Value.GetPreviewListArray()), null, null);
	}

	// Token: 0x06006115 RID: 24853 RVA: 0x001F0576 File Offset: 0x001EE776
	protected override void OnSetData()
	{
		this.ActivitySignData = (this.ActivityBaseData as ActivitySevenDaySignData);
	}

	// Token: 0x06006116 RID: 24854 RVA: 0x001F058C File Offset: 0x001EE78C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewNewcomerSignIn.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewNewcomerSignIn.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006117 RID: 24855 RVA: 0x001F05D0 File Offset: 0x001EE7D0
	protected override void OnStart()
	{
		foreach (int actId in (this.ActivitySignConfig != null) ? this.ActivitySignConfig.GetValueOrDefault().GetGrandRewardIdArray() : null)
		{
			ActivitySignGrandReward? byId = ActivitySignGrandRewardConfig.Instance.GetById(actId);
			if (byId != null)
			{
				this.GrandRewardConfigs.Add(byId);
				this.GrandRewardConfigMap.Add(byId.Value.GrandRewardIndex, byId);
			}
		}
		List<OneItemConfig> list = new List<OneItemConfig>();
		int num = 0;
		for (;;)
		{
			int num2 = num;
			int? num3 = (this.ActivitySignConfig != null) ? new int?(this.ActivitySignConfig.GetValueOrDefault().SignRewardsLength) : null;
			if (!(num2 < num3.GetValueOrDefault() & num3 != null))
			{
				break;
			}
			list.Add(((this.ActivitySignConfig != null) ? this.ActivitySignConfig.GetValueOrDefault().SignRewards(num) : null).Value);
			num++;
		}
		this.Layout.RefreshByData(list, null, false);
		this.UpdateGrandRewardInfo();
		if (this.ActivitySignData != null && !this.ActivitySignData.GetFreeRewardIsGet())
		{
			ActivitySevenDaySignController.Instance.GetActivityFreeDrop(this.ActivitySignData.Id);
		}
		Activity? activityConfig = ActivityConfig.Instance.GetActivityConfig(this.ActivitySignData.Id);
		if (activityConfig != null)
		{
			base.GetText(15).ShowTextNew(activityConfig.Value.Name);
		}
		List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(this.ActivitySignConfig.Value.FreeDropId);
		if (dropPackagePreviewItemList.Count > 0)
		{
			base.GetText(16).SetText("X" + dropPackagePreviewItemList[0].Count.ToString(), true);
		}
		UUITexture texture = base.GetTexture(17);
		UUITexture texture2 = base.GetTexture(18);
		if (texture != null)
		{
			string resourceId = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? this.NEWCOMER_LOGO_MALE_RESOURCE_ID : this.NEWCOMER_LOGO_FEMALE_RESOURCE_ID;
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			if (resourcePath != null)
			{
				base.SetTextureByPath(resourcePath, texture, null, null);
				base.SetTextureByPath(resourcePath, texture2, null, null);
			}
		}
	}

	// Token: 0x06006118 RID: 24856 RVA: 0x001F082A File Offset: 0x001EEA2A
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.CloseGachaSceneView, new Action(this.UpdateGrandRewardInfo));
	}

	// Token: 0x06006119 RID: 24857 RVA: 0x001F0848 File Offset: 0x001EEA48
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.CloseGachaSceneView, new Action(this.UpdateGrandRewardInfo));
	}

	// Token: 0x0600611A RID: 24858 RVA: 0x001F0868 File Offset: 0x001EEA68
	protected override void OnRefreshView()
	{
		List<OneItemConfig> list = new List<OneItemConfig>();
		int num = 0;
		for (;;)
		{
			int num2 = num;
			int? num3 = (this.ActivitySignConfig != null) ? new int?(this.ActivitySignConfig.GetValueOrDefault().SignRewardsLength) : null;
			if (!(num2 < num3.GetValueOrDefault() & num3 != null))
			{
				break;
			}
			list.Add(((this.ActivitySignConfig != null) ? this.ActivitySignConfig.GetValueOrDefault().SignRewards(num) : null).Value);
			num++;
		}
		this.Layout.RefreshByData(list, null, false);
		if (this.ActivitySignData != null)
		{
			base.GetItem(5).SetUIActive(this.ActivitySignData.GetFreeRewardIsGet());
		}
	}

	// Token: 0x0600611B RID: 24859 RVA: 0x001F092C File Offset: 0x001EEB2C
	private void UpdateGrandRewardInfo()
	{
		int num = this.GrandRewardConfigs.FindIndex((ActivitySignGrandReward? cfg) => this.ActivitySignData != null && this.ActivitySignData.GetRewardStateByDay(cfg.Value.GrandRewardIndex - 1).GetValueOrDefault() != SignState.IsReceive);
		int grandRewardShowIndex = (num >= 0) ? num : 0;
		this.SetGrandRewardShowIndex(grandRewardShowIndex);
	}

	// Token: 0x0600611C RID: 24860 RVA: 0x001F0964 File Offset: 0x001EEB64
	private void SetGrandRewardShowIndex(int index)
	{
		if (index < 0 || index >= this.GrandRewardConfigs.Count)
		{
			return;
		}
		if (this.SelectGrandRewardIndex == index)
		{
			return;
		}
		base.SetButtonUiActive(1, index > 0);
		base.SetButtonUiActive(2, index < this.GrandRewardConfigs.Count - 1);
		this.SetGrandRewardShow(index);
	}

	// Token: 0x0600611D RID: 24861 RVA: 0x001F09B8 File Offset: 0x001EEBB8
	private void SetGrandRewardShow(int index)
	{
		ActivitySignGrandReward? activitySignGrandReward = this.GrandRewardConfigs[index];
		if (activitySignGrandReward == null)
		{
			return;
		}
		base.GetItem(7).SetUIActive(activitySignGrandReward.Value.PreviewType == 1);
		base.GetItem(8).SetUIActive(activitySignGrandReward.Value.PreviewType == 2);
		int previewType = activitySignGrandReward.Value.PreviewType;
		if (previewType != 1)
		{
			if (previewType == 2)
			{
				int grandRewardIndex = activitySignGrandReward.Value.GrandRewardIndex;
				if (this.ActivitySignConfig != null && grandRewardIndex > 0 && grandRewardIndex <= this.ActivitySignConfig.Value.SignRewardsLength)
				{
					OneItemConfig? oneItemConfig = this.ActivitySignConfig.Value.SignRewards(grandRewardIndex - 1);
					if (oneItemConfig != null)
					{
						CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(oneItemConfig.Value.ItemId);
						if (itemConfigData != null && this.WeaponStarLayout != null)
						{
							this.WeaponStarLayout.RebuildLayout(itemConfigData.QualityId);
						}
					}
				}
				base.GetText(11).ShowTextNew(activitySignGrandReward.Value.GrandTitle);
			}
		}
		else
		{
			TrialRoleInfo? trialRoleConfig = TrialRoleConfig.Instance.GetTrialRoleConfig(activitySignGrandReward.Value.PreviewList(0));
			if (this.DescComponent != null && trialRoleConfig != null)
			{
				this.DescComponent.Update(trialRoleConfig.Value.ParentId, false);
				this.DescComponent.SetLookBtnActive(true);
			}
		}
		base.GetText(6).ShowTextNew(activitySignGrandReward.Value.GrandDesc);
		string text = (this.SelectGrandRewardIndex > index) ? "Switch" : "Switch2";
		if (this.GrandRewardItemMap.ContainsKey(this.SelectGrandRewardIndex))
		{
			this.GrandRewardItemMap[this.SelectGrandRewardIndex].SetUIActive(false);
		}
		if (!this.GrandRewardItemMap.ContainsKey(index))
		{
			this.LoadGrandRewardItem(index, text);
		}
		else
		{
			this.GrandRewardItemMap[index].SetUIActive(true);
			this.PlaySubViewSequence(text, false);
		}
		this.SelectGrandRewardIndex = index;
	}

	// Token: 0x0600611E RID: 24862 RVA: 0x001F0BE0 File Offset: 0x001EEDE0
	private UniTask LoadGrandRewardItem(int index, string switchAnim)
	{
		ActivitySubViewNewcomerSignIn.<LoadGrandRewardItem>d__28 <LoadGrandRewardItem>d__;
		<LoadGrandRewardItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadGrandRewardItem>d__.<>4__this = this;
		<LoadGrandRewardItem>d__.index = index;
		<LoadGrandRewardItem>d__.switchAnim = switchAnim;
		<LoadGrandRewardItem>d__.<>1__state = -1;
		<LoadGrandRewardItem>d__.<>t__builder.Start<ActivitySubViewNewcomerSignIn.<LoadGrandRewardItem>d__28>(ref <LoadGrandRewardItem>d__);
		return <LoadGrandRewardItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600611F RID: 24863 RVA: 0x001F0C33 File Offset: 0x001EEE33
	protected override void OnSequenceStart(string sequenceName)
	{
		if (sequenceName == "Start")
		{
			GenericLayout<NewcomerSignInItem, OneItemConfig> layout = this.Layout;
			if (layout == null)
			{
				return;
			}
			UUIInturnAnimController uiAnimController = layout.GetUiAnimController();
			if (uiAnimController == null)
			{
				return;
			}
			uiAnimController.Play("", -1, false);
		}
	}

	// Token: 0x06006120 RID: 24864 RVA: 0x001F0C63 File Offset: 0x001EEE63
	private NewcomerSignInItem InitItem()
	{
		NewcomerSignInItem newcomerSignInItem = new NewcomerSignInItem();
		newcomerSignInItem.SetActivityData(this.ActivitySignData);
		newcomerSignInItem.SetGrandRewardConfigMap(this.GrandRewardConfigMap);
		return newcomerSignInItem;
	}

	// Token: 0x06006121 RID: 24865 RVA: 0x001F0C84 File Offset: 0x001EEE84
	protected override void OnTimer(float gap)
	{
		if (this.ActivityBaseData == null)
		{
			return;
		}
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(this.ActivityBaseData, null);
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		UUIText text = base.GetText(19);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(item);
		text.SetText(item2, true);
	}

	// Token: 0x04003F65 RID: 16229
	private string NEWCOMER_LOGO_MALE_RESOURCE_ID = "T_NewcomerLogoMale";

	// Token: 0x04003F66 RID: 16230
	private string NEWCOMER_LOGO_FEMALE_RESOURCE_ID = "T_NewcomerLogoFemale";

	// Token: 0x04003F67 RID: 16231
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<NewcomerSignInItem, OneItemConfig> Layout;

	// Token: 0x04003F68 RID: 16232
	[Nullable(2)]
	private ActivitySevenDaySignData ActivitySignData;

	// Token: 0x04003F69 RID: 16233
	private ActivitySign? ActivitySignConfig;

	// Token: 0x04003F6A RID: 16234
	[Nullable(2)]
	private global::RoleDescribeComponent DescComponent;

	// Token: 0x04003F6B RID: 16235
	private readonly List<ActivitySignGrandReward?> GrandRewardConfigs = new List<ActivitySignGrandReward?>();

	// Token: 0x04003F6C RID: 16236
	private readonly Dictionary<int, ActivitySignGrandReward?> GrandRewardConfigMap = new Dictionary<int, ActivitySignGrandReward?>();

	// Token: 0x04003F6D RID: 16237
	private readonly Dictionary<int, UUIItem> GrandRewardItemMap = new Dictionary<int, UUIItem>();

	// Token: 0x04003F6E RID: 16238
	private readonly HashSet<int> GrandRewardLoadSet = new HashSet<int>();

	// Token: 0x04003F6F RID: 16239
	[Nullable(2)]
	private SimpleGenericLayout WeaponStarLayout;

	// Token: 0x04003F70 RID: 16240
	private int SelectGrandRewardIndex = -1;

	// Token: 0x02006BA4 RID: 27556
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402363E RID: 144958
		public const int RewardContent = 0;

		// Token: 0x0402363F RID: 144959
		public const int LeftBtn = 1;

		// Token: 0x04023640 RID: 144960
		public const int RightBtn = 2;

		// Token: 0x04023641 RID: 144961
		public const int BtnFreeReward = 3;

		// Token: 0x04023642 RID: 144962
		public const int PnlNml = 4;

		// Token: 0x04023643 RID: 144963
		public const int PnlGot = 5;

		// Token: 0x04023644 RID: 144964
		public const int GrandRewardText = 6;

		// Token: 0x04023645 RID: 144965
		public const int GrandRoleItem = 7;

		// Token: 0x04023646 RID: 144966
		public const int GrandWeaponItem = 8;

		// Token: 0x04023647 RID: 144967
		public const int Layout = 9;

		// Token: 0x04023648 RID: 144968
		public const int GridItem = 10;

		// Token: 0x04023649 RID: 144969
		public const int WeaponText = 11;

		// Token: 0x0402364A RID: 144970
		public const int WeaponStarLayout = 12;

		// Token: 0x0402364B RID: 144971
		public const int WeaponStarItem = 13;

		// Token: 0x0402364C RID: 144972
		public const int LookWeaponBtn = 14;

		// Token: 0x0402364D RID: 144973
		public const int TitleText = 15;

		// Token: 0x0402364E RID: 144974
		public const int RewardCountText = 16;

		// Token: 0x0402364F RID: 144975
		public const int TitleLogo = 17;

		// Token: 0x04023650 RID: 144976
		public const int TitleLogo2 = 18;

		// Token: 0x04023651 RID: 144977
		public const int TitleSubText = 19;
	}
}
