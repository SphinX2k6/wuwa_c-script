using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x020013AD RID: 5037
[NullableContext(1)]
[Nullable(0)]
public class ActivitySubViewNewcomerSignIn : ActivitySubViewBase
{
	// Token: 0x06008D79 RID: 36217 RVA: 0x001E73DC File Offset: 0x001E55DC
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

	// Token: 0x06008D7A RID: 36218 RVA: 0x001E7729 File Offset: 0x001E5929
	private void ClickLeftBtn()
	{
		this.SetGrandRewardShowIndex(this.SelectGrandRewardIndex - 1);
	}

	// Token: 0x06008D7B RID: 36219 RVA: 0x001E7739 File Offset: 0x001E5939
	private void ClickRightBtn()
	{
		this.SetGrandRewardShowIndex(this.SelectGrandRewardIndex + 1);
	}

	// Token: 0x06008D7C RID: 36220 RVA: 0x001E774C File Offset: 0x001E594C
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

	// Token: 0x06008D7D RID: 36221 RVA: 0x001E7820 File Offset: 0x001E5A20
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
		ItemController.Instance.OpenItemTipsByItemId(dropPackagePreviewItemList[0].ItemData.ItemId, true, null);
	}

	// Token: 0x06008D7E RID: 36222 RVA: 0x001E78A4 File Offset: 0x001E5AA4
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
		RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, 0, activitySignGrandReward.Value.GetPreviewListArray().ToList<int>(), null, null);
	}

	// Token: 0x06008D7F RID: 36223 RVA: 0x001E7926 File Offset: 0x001E5B26
	protected override void OnSetData()
	{
		this.ActivitySignData = (this.ActivityBaseData as ActivitySevenDaySignData);
	}

	// Token: 0x06008D80 RID: 36224 RVA: 0x001E793C File Offset: 0x001E5B3C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewNewcomerSignIn.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewNewcomerSignIn.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008D81 RID: 36225 RVA: 0x001E7980 File Offset: 0x001E5B80
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

	// Token: 0x06008D82 RID: 36226 RVA: 0x001E7BDA File Offset: 0x001E5DDA
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.CloseGachaSceneView, new Action(this.UpdateGrandRewardInfo));
	}

	// Token: 0x06008D83 RID: 36227 RVA: 0x001E7BF8 File Offset: 0x001E5DF8
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.CloseGachaSceneView, new Action(this.UpdateGrandRewardInfo));
	}

	// Token: 0x06008D84 RID: 36228 RVA: 0x001E7C18 File Offset: 0x001E5E18
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

	// Token: 0x06008D85 RID: 36229 RVA: 0x001E7CDC File Offset: 0x001E5EDC
	private void UpdateGrandRewardInfo()
	{
		int num = this.GrandRewardConfigs.FindIndex((ActivitySignGrandReward? cfg) => this.ActivitySignData != null && this.ActivitySignData.GetRewardStateByDay(cfg.Value.GrandRewardIndex - 1).GetValueOrDefault() != SignState.IsReceive);
		int grandRewardShowIndex = (num >= 0) ? num : 0;
		this.SetGrandRewardShowIndex(grandRewardShowIndex);
	}

	// Token: 0x06008D86 RID: 36230 RVA: 0x001E7D14 File Offset: 0x001E5F14
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

	// Token: 0x06008D87 RID: 36231 RVA: 0x001E7D68 File Offset: 0x001E5F68
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

	// Token: 0x06008D88 RID: 36232 RVA: 0x001E7F90 File Offset: 0x001E6190
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

	// Token: 0x06008D89 RID: 36233 RVA: 0x001E7FE3 File Offset: 0x001E61E3
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

	// Token: 0x06008D8A RID: 36234 RVA: 0x001E8013 File Offset: 0x001E6213
	private NewcomerSignInItem InitItem()
	{
		NewcomerSignInItem newcomerSignInItem = new NewcomerSignInItem();
		newcomerSignInItem.SetActivityData(this.ActivitySignData);
		newcomerSignInItem.SetGrandRewardConfigMap(this.GrandRewardConfigMap);
		return newcomerSignInItem;
	}

	// Token: 0x06008D8B RID: 36235 RVA: 0x001E8034 File Offset: 0x001E6234
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

	// Token: 0x04003ECD RID: 16077
	private string NEWCOMER_LOGO_MALE_RESOURCE_ID = "T_NewcomerLogoMale";

	// Token: 0x04003ECE RID: 16078
	private string NEWCOMER_LOGO_FEMALE_RESOURCE_ID = "T_NewcomerLogoFemale";

	// Token: 0x04003ECF RID: 16079
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<NewcomerSignInItem, OneItemConfig> Layout;

	// Token: 0x04003ED0 RID: 16080
	[Nullable(2)]
	private ActivitySevenDaySignData ActivitySignData;

	// Token: 0x04003ED1 RID: 16081
	private ActivitySign? ActivitySignConfig;

	// Token: 0x04003ED2 RID: 16082
	[Nullable(2)]
	private global::RoleDescribeComponent DescComponent;

	// Token: 0x04003ED3 RID: 16083
	private readonly List<ActivitySignGrandReward?> GrandRewardConfigs = new List<ActivitySignGrandReward?>();

	// Token: 0x04003ED4 RID: 16084
	private readonly Dictionary<int, ActivitySignGrandReward?> GrandRewardConfigMap = new Dictionary<int, ActivitySignGrandReward?>();

	// Token: 0x04003ED5 RID: 16085
	private readonly Dictionary<int, UUIItem> GrandRewardItemMap = new Dictionary<int, UUIItem>();

	// Token: 0x04003ED6 RID: 16086
	private readonly HashSet<int> GrandRewardLoadSet = new HashSet<int>();

	// Token: 0x04003ED7 RID: 16087
	[Nullable(2)]
	private SimpleGenericLayout WeaponStarLayout;

	// Token: 0x04003ED8 RID: 16088
	private int SelectGrandRewardIndex = -1;

	// Token: 0x02007A1E RID: 31262
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04028321 RID: 164641
		public const int RewardContent = 0;

		// Token: 0x04028322 RID: 164642
		public const int LeftBtn = 1;

		// Token: 0x04028323 RID: 164643
		public const int RightBtn = 2;

		// Token: 0x04028324 RID: 164644
		public const int BtnFreeReward = 3;

		// Token: 0x04028325 RID: 164645
		public const int PnlNml = 4;

		// Token: 0x04028326 RID: 164646
		public const int PnlGot = 5;

		// Token: 0x04028327 RID: 164647
		public const int GrandRewardText = 6;

		// Token: 0x04028328 RID: 164648
		public const int GrandRoleItem = 7;

		// Token: 0x04028329 RID: 164649
		public const int GrandWeaponItem = 8;

		// Token: 0x0402832A RID: 164650
		public const int Layout = 9;

		// Token: 0x0402832B RID: 164651
		public const int GridItem = 10;

		// Token: 0x0402832C RID: 164652
		public const int WeaponText = 11;

		// Token: 0x0402832D RID: 164653
		public const int WeaponStarLayout = 12;

		// Token: 0x0402832E RID: 164654
		public const int WeaponStarItem = 13;

		// Token: 0x0402832F RID: 164655
		public const int LookWeaponBtn = 14;

		// Token: 0x04028330 RID: 164656
		public const int TitleText = 15;

		// Token: 0x04028331 RID: 164657
		public const int RewardCountText = 16;

		// Token: 0x04028332 RID: 164658
		public const int TitleLogo = 17;

		// Token: 0x04028333 RID: 164659
		public const int TitleLogo2 = 18;

		// Token: 0x04028334 RID: 164660
		public const int TitleSubText = 19;
	}
}
