using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F82 RID: 20354
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPickRoleViewModel
	{
		// Token: 0x170063C5 RID: 25541
		// (get) Token: 0x060330E9 RID: 209129 RVA: 0x00E4F75B File Offset: 0x00E4D95B
		public bool IsFromActivity
		{
			get
			{
				return this.IsLoadedFromActivity;
			}
		}

		// Token: 0x060330EA RID: 209130 RVA: 0x00E4F764 File Offset: 0x00E4D964
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

		// Token: 0x060330EB RID: 209131 RVA: 0x00E4F828 File Offset: 0x00E4DA28
		public void LoadFromGiftPackageInBag(TotalTopUpRolePackageData packageData)
		{
			this.IsLoadedFromActivity = false;
			this.LoadContentDataFromGiftPackageData(packageData);
			this.ClaimHandler = new Action<int, int>(this.ClaimInBag);
		}

		// Token: 0x060330EC RID: 209132 RVA: 0x00E4F84C File Offset: 0x00E4DA4C
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

		// Token: 0x060330ED RID: 209133 RVA: 0x00E4FA04 File Offset: 0x00E4DC04
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

		// Token: 0x060330EE RID: 209134 RVA: 0x00E4FAF8 File Offset: 0x00E4DCF8
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

		// Token: 0x060330EF RID: 209135 RVA: 0x00E4FC14 File Offset: 0x00E4DE14
		private void ClaimInActivity(int rewardId, int selectId)
		{
			TotalTopUpController.Instance.RequestClaim(rewardId, new int?(selectId));
		}

		// Token: 0x060330F0 RID: 209136 RVA: 0x00E4FC27 File Offset: 0x00E4DE27
		private void ClaimInBag(int rewardId, int selectId)
		{
			InventoryGiftController.Instance.SendItemGiftUseRequest(this.GiftBagItemId, 1, new int[]
			{
				selectId
			});
		}

		// Token: 0x060330F1 RID: 209137 RVA: 0x00E4FC44 File Offset: 0x00E4DE44
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

		// Token: 0x060330F2 RID: 209138 RVA: 0x00E4FC85 File Offset: 0x00E4DE85
		private bool GetRoleOwned(int roleId)
		{
			return RoleModel.Instance.IsRoleOwned(roleId);
		}

		// Token: 0x060330F3 RID: 209139 RVA: 0x00E4FC94 File Offset: 0x00E4DE94
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

		// Token: 0x0401B19A RID: 111002
		[Nullable(2)]
		private TotalTopUpRewardData RewardData;

		// Token: 0x0401B19B RID: 111003
		private readonly Dictionary<int, ItemConfig> ItemConfigDataMap = new Dictionary<int, ItemConfig>();

		// Token: 0x0401B19C RID: 111004
		private int GiftBagItemId;

		// Token: 0x0401B19D RID: 111005
		public readonly List<ITotalTopUpPickRoleRewardItemData> ItemDataList = new List<ITotalTopUpPickRoleRewardItemData>();

		// Token: 0x0401B19E RID: 111006
		public int SelectedIndex = -1;

		// Token: 0x0401B19F RID: 111007
		public bool CanClaim;

		// Token: 0x0401B1A0 RID: 111008
		public bool IsRole;

		// Token: 0x0401B1A1 RID: 111009
		public int CurrentRoleId;

		// Token: 0x0401B1A2 RID: 111010
		public bool CurrentRoleOwned;

		// Token: 0x0401B1A3 RID: 111011
		public int CurrentRoleChainNum;

		// Token: 0x0401B1A4 RID: 111012
		public bool CurrentIsFullChain;

		// Token: 0x0401B1A5 RID: 111013
		public int CurrentItemId;

		// Token: 0x0401B1A6 RID: 111014
		public int CurrentItemCount;

		// Token: 0x0401B1A7 RID: 111015
		public string CurrentRoleBackgroundPath = "";

		// Token: 0x0401B1A8 RID: 111016
		[Nullable(2)]
		public ItemConfig CurrentSelectItemConfigData;

		// Token: 0x0401B1A9 RID: 111017
		public int FirstCanClaimIndex = -1;

		// Token: 0x0401B1AA RID: 111018
		[Nullable(2)]
		private Action<int, int> ClaimHandler;

		// Token: 0x0401B1AB RID: 111019
		private bool IsLoadedFromActivity;

		// Token: 0x0401B1AC RID: 111020
		private const int FULL_CHAIN = 6;

		// Token: 0x0200AC88 RID: 44168
		[NullableContext(0)]
		private class TotalTopUpPickRoleRewardItemData : ITotalTopUpPickRoleRewardItemData
		{
			// Token: 0x17007A18 RID: 31256
			// (get) Token: 0x06046B89 RID: 289673 RVA: 0x01559F47 File Offset: 0x01558147
			// (set) Token: 0x06046B8A RID: 289674 RVA: 0x01559F4F File Offset: 0x0155814F
			public int Index { get; set; }

			// Token: 0x17007A19 RID: 31257
			// (get) Token: 0x06046B8B RID: 289675 RVA: 0x01559F58 File Offset: 0x01558158
			// (set) Token: 0x06046B8C RID: 289676 RVA: 0x01559F60 File Offset: 0x01558160
			public int ItemId { get; set; }

			// Token: 0x17007A1A RID: 31258
			// (get) Token: 0x06046B8D RID: 289677 RVA: 0x01559F69 File Offset: 0x01558169
			// (set) Token: 0x06046B8E RID: 289678 RVA: 0x01559F71 File Offset: 0x01558171
			public int ItemCount { get; set; }

			// Token: 0x17007A1B RID: 31259
			// (get) Token: 0x06046B8F RID: 289679 RVA: 0x01559F7A File Offset: 0x0155817A
			// (set) Token: 0x06046B90 RID: 289680 RVA: 0x01559F82 File Offset: 0x01558182
			public int RoleId { get; set; }

			// Token: 0x17007A1C RID: 31260
			// (get) Token: 0x06046B91 RID: 289681 RVA: 0x01559F8B File Offset: 0x0155818B
			// (set) Token: 0x06046B92 RID: 289682 RVA: 0x01559F93 File Offset: 0x01558193
			public int RoleChain { get; set; }

			// Token: 0x17007A1D RID: 31261
			// (get) Token: 0x06046B93 RID: 289683 RVA: 0x01559F9C File Offset: 0x0155819C
			// (set) Token: 0x06046B94 RID: 289684 RVA: 0x01559FA4 File Offset: 0x015581A4
			public bool RoleOwned { get; set; }

			// Token: 0x17007A1E RID: 31262
			// (get) Token: 0x06046B95 RID: 289685 RVA: 0x01559FAD File Offset: 0x015581AD
			// (set) Token: 0x06046B96 RID: 289686 RVA: 0x01559FB5 File Offset: 0x015581B5
			public bool CanClaim { get; set; }
		}
	}
}
