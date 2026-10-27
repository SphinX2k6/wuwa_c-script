using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005F9B RID: 24475
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPickRoleViewModel
	{
		// Token: 0x17008FF3 RID: 36851
		// (get) Token: 0x0603E14F RID: 254287 RVA: 0x00EFDAA3 File Offset: 0x00EFBCA3
		public bool IsFromActivity
		{
			get
			{
				return this.IsLoadedFromActivity;
			}
		}

		// Token: 0x0603E150 RID: 254288 RVA: 0x00EFDAAC File Offset: 0x00EFBCAC
		public unsafe void LoadFromActivityData(TotalTopUpData actData, int rewardIndex)
		{
			this.IsLoadedFromActivity = true;
			this.RewardData = actData.RewardDataList[rewardIndex];
			TotalTopUpRewardData totalTopUpRewardData = actData.RewardDataList[rewardIndex];
			if (totalTopUpRewardData == null || totalTopUpRewardData.TotalTopUpRolePackageData == null)
			{
				string message = "加载角色选择数据失败，奖励数据不存在";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RewardIndex", rewardIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PackageData", (totalTopUpRewardData != null && totalTopUpRewardData.TotalTopUpRolePackageData != null) ? "exist" : "null");
				TotalTopUpUtil.Error(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			TotalTopUpRolePackageData totalTopUpRolePackageData = totalTopUpRewardData.TotalTopUpRolePackageData;
			this.LoadContentDataFromGiftPackageData(totalTopUpRolePackageData);
			this.ClaimHandler = new Action<int, int>(this.ClaimInActivity);
		}

		// Token: 0x0603E151 RID: 254289 RVA: 0x00EFDB70 File Offset: 0x00EFBD70
		public void LoadFromGiftPackageInBag(TotalTopUpRolePackageData packageData)
		{
			this.IsLoadedFromActivity = false;
			this.LoadContentDataFromGiftPackageData(packageData);
			this.ClaimHandler = new Action<int, int>(this.ClaimInBag);
		}

		// Token: 0x0603E152 RID: 254290 RVA: 0x00EFDB94 File Offset: 0x00EFBD94
		private void LoadContentDataFromGiftPackageData(TotalTopUpRolePackageData packageData)
		{
			this.ItemConfigDataMap.Clear();
			this.GiftBagItemId = packageData.GiftBagItemId;
			this.ItemDataList.Clear();
			foreach (int num in packageData.RoleList)
			{
				int roleChainNum = this.GetRoleChainNum(num);
				bool roleOwned = this.GetRoleOwned(num);
				TotalTopUpPickRoleViewModel.TotalTopUpPickRoleRewardItemData item = new TotalTopUpPickRoleViewModel.TotalTopUpPickRoleRewardItemData
				{
					Index = this.ItemDataList.Count,
					ItemCount = 1,
					ItemId = 0,
					RoleId = num,
					RoleChain = roleChainNum,
					RoleOwned = roleOwned,
					CanClaim = (roleChainNum < 6)
				};
				this.ItemDataList.Add(item);
				ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(num);
				if (itemConfigData != null)
				{
					this.ItemConfigDataMap[num] = itemConfigData;
				}
			}
			TotalTopUpPickRoleViewModel.TotalTopUpPickRoleRewardItemData item2 = new TotalTopUpPickRoleViewModel.TotalTopUpPickRoleRewardItemData
			{
				Index = this.ItemDataList.Count,
				ItemId = packageData.ItemId,
				ItemCount = packageData.ItemCount,
				RoleId = 0,
				RoleChain = 0,
				RoleOwned = false,
				CanClaim = true
			};
			this.ItemDataList.Add(item2);
			ItemConfig itemConfigData2 = InventoryConfig.Instance.GetItemConfigData(packageData.ItemId);
			if (itemConfigData2 != null)
			{
				this.ItemConfigDataMap[packageData.ItemId] = itemConfigData2;
			}
			this.FirstCanClaimIndex = -1;
			for (int i = 0; i < this.ItemDataList.Count; i++)
			{
				if (this.ItemDataList[i].CanClaim)
				{
					this.FirstCanClaimIndex = i;
					return;
				}
			}
		}

		// Token: 0x0603E153 RID: 254291 RVA: 0x00EFDD4C File Offset: 0x00EFBF4C
		public void SelectItem(int index)
		{
			this.SelectedIndex = index;
			ITotalTopUpPickRoleRewardItemData totalTopUpPickRoleRewardItemData = this.ItemDataList[index];
			this.IsRole = (totalTopUpPickRoleRewardItemData.RoleId > 0);
			this.CurrentRoleId = totalTopUpPickRoleRewardItemData.RoleId;
			this.CurrentRoleChainNum = totalTopUpPickRoleRewardItemData.RoleChain;
			this.CurrentIsFullChain = (this.CurrentRoleChainNum >= 6);
			this.CurrentRoleOwned = totalTopUpPickRoleRewardItemData.RoleOwned;
			this.CurrentItemId = totalTopUpPickRoleRewardItemData.ItemId;
			this.CurrentItemCount = totalTopUpPickRoleRewardItemData.ItemCount;
			this.CanClaim = totalTopUpPickRoleRewardItemData.CanClaim;
			int num = (totalTopUpPickRoleRewardItemData.RoleId > 0) ? totalTopUpPickRoleRewardItemData.RoleId : totalTopUpPickRoleRewardItemData.ItemId;
			this.CurrentSelectItemConfigData = this.ItemConfigDataMap.GetValueOrDefault(num);
			TotalTopUpConfig instance = TotalTopUpConfig.Instance;
			TotalTopUpRoleViewConfig? totalTopUpRoleViewConfig;
			this.CurrentRoleBackgroundPath = (((instance != null) ? ((instance.GetRoleViewConfigByRoleIdOrItemId(num) != null) ? totalTopUpRoleViewConfig.GetValueOrDefault().RoleBackgroundPath : null) : null) ?? "");
		}

		// Token: 0x0603E154 RID: 254292 RVA: 0x00EFDE40 File Offset: 0x00EFC040
		public void Claim(Action callback)
		{
			TotalTopUpPickRoleViewModel.<>c__DisplayClass24_0 CS$<>8__locals1 = new TotalTopUpPickRoleViewModel.<>c__DisplayClass24_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callback = callback;
			if (!this.CanClaim)
			{
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.TotalTopUpClaimRoleConfirm);
			ITotalTopUpPickRoleRewardItemData totalTopUpPickRoleRewardItemData = this.ItemDataList[this.SelectedIndex];
			CS$<>8__locals1.selectId = ((totalTopUpPickRoleRewardItemData.RoleId > 0) ? totalTopUpPickRoleRewardItemData.RoleId : totalTopUpPickRoleRewardItemData.ItemId);
			TotalTopUpPickRoleViewModel.<>c__DisplayClass24_0 CS$<>8__locals2 = CS$<>8__locals1;
			TotalTopUpRewardData rewardData = this.RewardData;
			CS$<>8__locals2.rewardId = ((rewardData != null) ? rewardData.Id : 0);
			string text;
			if (totalTopUpPickRoleRewardItemData.RoleId > 0)
			{
				RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(totalTopUpPickRoleRewardItemData.RoleId);
				text = ((roleConfig != null) ? roleConfig.GetValueOrDefault().Name : null);
			}
			else
			{
				ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(totalTopUpPickRoleRewardItemData.ItemId);
				text = ((itemConfigData != null) ? itemConfigData.Name : null);
			}
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(text ?? string.Empty, null);
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				localTextNew
			});
			confirmBoxDataNew.FunctionMap[2] = new Action(CS$<>8__locals1.<Claim>g__ConfirmFunction|0);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603E155 RID: 254293 RVA: 0x00EFDF5C File Offset: 0x00EFC15C
		private void ClaimInActivity(int rewardId, int selectId)
		{
			TotalTopUpController.Instance.RequestClaim(rewardId, new int?(selectId));
		}

		// Token: 0x0603E156 RID: 254294 RVA: 0x00EFDF6F File Offset: 0x00EFC16F
		private void ClaimInBag(int rewardId, int selectId)
		{
			InventoryGiftController.Instance.SendItemGiftUseRequest(this.GiftBagItemId, 1, new int[]
			{
				selectId
			});
		}

		// Token: 0x0603E157 RID: 254295 RVA: 0x00EFDF8C File Offset: 0x00EFC18C
		private int GetRoleChainNum(int roleId)
		{
			RoleModel instance = RoleModel.Instance;
			if (!instance.IsRoleOwned(roleId))
			{
				return 0;
			}
			if (instance.GetRoleInstanceById(roleId) == null)
			{
				return 0;
			}
			int roleLeftResonantCountWithInventoryItem = RoleModel.Instance.GetRoleLeftResonantCountWithInventoryItem(roleId);
			return RoleResonanceConfig.Instance.GetResonanceMaxLevel() - roleLeftResonantCountWithInventoryItem;
		}

		// Token: 0x0603E158 RID: 254296 RVA: 0x00EFDFCD File Offset: 0x00EFC1CD
		private bool GetRoleOwned(int roleId)
		{
			return RoleModel.Instance.IsRoleOwned(roleId);
		}

		// Token: 0x0603E159 RID: 254297 RVA: 0x00EFDFDC File Offset: 0x00EFC1DC
		public void PreviewAllRoles()
		{
			if (this.CurrentRoleId <= 0)
			{
				return;
			}
			List<int> list = new List<int>();
			foreach (ITotalTopUpPickRoleRewardItemData totalTopUpPickRoleRewardItemData in this.ItemDataList)
			{
				if (totalTopUpPickRoleRewardItemData.RoleId > 0)
				{
					list.Add(totalTopUpPickRoleRewardItemData.RoleId);
				}
			}
			if (list.Count == 0)
			{
				TotalTopUpUtil.Error("[PreviewAllRoles]预览角色失败，未找到角色数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int selectRoleId = 0;
			List<int> list2 = new List<int>();
			foreach (int num in list)
			{
				GachaTextureInfo? gachaTextureInfo = GachaConfig.Instance.GetGachaTextureInfo(num);
				if (gachaTextureInfo == null)
				{
					string message = "[PreviewAllRoles]预览角色失败，找不到角色Trial配置";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RoleId", num);
					TotalTopUpUtil.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					if (num == this.CurrentRoleId)
					{
						selectRoleId = gachaTextureInfo.Value.TrialId;
					}
					list2.Add(gachaTextureInfo.Value.TrialId);
				}
			}
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, selectRoleId, list2, null, null);
		}

		// Token: 0x040206C8 RID: 132808
		[Nullable(2)]
		private TotalTopUpRewardData RewardData;

		// Token: 0x040206C9 RID: 132809
		private readonly Dictionary<int, ItemConfig> ItemConfigDataMap = new Dictionary<int, ItemConfig>();

		// Token: 0x040206CA RID: 132810
		private int GiftBagItemId;

		// Token: 0x040206CB RID: 132811
		public readonly List<ITotalTopUpPickRoleRewardItemData> ItemDataList = new List<ITotalTopUpPickRoleRewardItemData>();

		// Token: 0x040206CC RID: 132812
		public int SelectedIndex = -1;

		// Token: 0x040206CD RID: 132813
		public bool CanClaim;

		// Token: 0x040206CE RID: 132814
		public bool IsRole;

		// Token: 0x040206CF RID: 132815
		public int CurrentRoleId;

		// Token: 0x040206D0 RID: 132816
		public bool CurrentRoleOwned;

		// Token: 0x040206D1 RID: 132817
		public int CurrentRoleChainNum;

		// Token: 0x040206D2 RID: 132818
		public bool CurrentIsFullChain;

		// Token: 0x040206D3 RID: 132819
		public int CurrentItemId;

		// Token: 0x040206D4 RID: 132820
		public int CurrentItemCount;

		// Token: 0x040206D5 RID: 132821
		public string CurrentRoleBackgroundPath = "";

		// Token: 0x040206D6 RID: 132822
		[Nullable(2)]
		public ItemConfig CurrentSelectItemConfigData;

		// Token: 0x040206D7 RID: 132823
		public int FirstCanClaimIndex = -1;

		// Token: 0x040206D8 RID: 132824
		[Nullable(2)]
		private Action<int, int> ClaimHandler;

		// Token: 0x040206D9 RID: 132825
		private bool IsLoadedFromActivity;

		// Token: 0x040206DA RID: 132826
		private const int FULL_CHAIN = 6;

		// Token: 0x0200C27D RID: 49789
		[NullableContext(0)]
		private class TotalTopUpPickRoleRewardItemData : ITotalTopUpPickRoleRewardItemData
		{
			// Token: 0x1700A27B RID: 41595
			// (get) Token: 0x06050655 RID: 329301 RVA: 0x015A08D7 File Offset: 0x0159EAD7
			// (set) Token: 0x06050656 RID: 329302 RVA: 0x015A08DF File Offset: 0x0159EADF
			public int Index { get; set; }

			// Token: 0x1700A27C RID: 41596
			// (get) Token: 0x06050657 RID: 329303 RVA: 0x015A08E8 File Offset: 0x0159EAE8
			// (set) Token: 0x06050658 RID: 329304 RVA: 0x015A08F0 File Offset: 0x0159EAF0
			public int ItemId { get; set; }

			// Token: 0x1700A27D RID: 41597
			// (get) Token: 0x06050659 RID: 329305 RVA: 0x015A08F9 File Offset: 0x0159EAF9
			// (set) Token: 0x0605065A RID: 329306 RVA: 0x015A0901 File Offset: 0x0159EB01
			public int ItemCount { get; set; }

			// Token: 0x1700A27E RID: 41598
			// (get) Token: 0x0605065B RID: 329307 RVA: 0x015A090A File Offset: 0x0159EB0A
			// (set) Token: 0x0605065C RID: 329308 RVA: 0x015A0912 File Offset: 0x0159EB12
			public int RoleId { get; set; }

			// Token: 0x1700A27F RID: 41599
			// (get) Token: 0x0605065D RID: 329309 RVA: 0x015A091B File Offset: 0x0159EB1B
			// (set) Token: 0x0605065E RID: 329310 RVA: 0x015A0923 File Offset: 0x0159EB23
			public int RoleChain { get; set; }

			// Token: 0x1700A280 RID: 41600
			// (get) Token: 0x0605065F RID: 329311 RVA: 0x015A092C File Offset: 0x0159EB2C
			// (set) Token: 0x06050660 RID: 329312 RVA: 0x015A0934 File Offset: 0x0159EB34
			public bool RoleOwned { get; set; }

			// Token: 0x1700A281 RID: 41601
			// (get) Token: 0x06050661 RID: 329313 RVA: 0x015A093D File Offset: 0x0159EB3D
			// (set) Token: 0x06050662 RID: 329314 RVA: 0x015A0945 File Offset: 0x0159EB45
			public bool CanClaim { get; set; }
		}
	}
}
