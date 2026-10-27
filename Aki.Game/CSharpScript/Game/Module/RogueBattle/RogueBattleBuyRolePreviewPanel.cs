using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E49 RID: 20041
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueBattleBuyRolePreviewPanel : UiPanelBase
	{
		// Token: 0x06033AA1 RID: 211617 RVA: 0x00C18815 File Offset: 0x00C16A15
		public RogueBattleBuyRolePreviewPanel(int incId)
		{
			this.IncId = incId;
		}

		// Token: 0x06033AA2 RID: 211618 RVA: 0x00C18824 File Offset: 0x00C16A24
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(7, new Action(this.OnBtnBack))
			};
		}

		// Token: 0x06033AA3 RID: 211619 RVA: 0x00C18910 File Offset: 0x00C16B10
		private void OnBtnConfirm()
		{
			MapRogueOpSelectView mapRogueOpSelectView = MapRogueModel.Instance.GetOpData(this.IncId) as MapRogueOpSelectView;
			if (mapRogueOpSelectView == null)
			{
				return;
			}
			RogueResRole rogueResRole = this.Data.RogueResRole;
			if (rogueResRole.CurPrice > InventoryModel.Instance.GetItemCountByConfigId(rogueResRole.ItemId, 0))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("RogueBattle_BuyItemNotEnough", Array.Empty<object>());
				return;
			}
			mapRogueOpSelectView.Select(rogueResRole.Index);
		}

		// Token: 0x06033AA4 RID: 211620 RVA: 0x00C1897D File Offset: 0x00C16B7D
		private void OnBtnBack()
		{
			Action backBtnFunc = this.BackBtnFunc;
			if (backBtnFunc == null)
			{
				return;
			}
			backBtnFunc();
		}

		// Token: 0x06033AA5 RID: 211621 RVA: 0x00C18990 File Offset: 0x00C16B90
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleBuyRolePreviewPanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleBuyRolePreviewPanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033AA6 RID: 211622 RVA: 0x00C189D4 File Offset: 0x00C16BD4
		[NullableContext(1)]
		public void Refresh(RogueResGainData data)
		{
			RogueBattleBuyRolePreviewPanel.<>c__DisplayClass12_0 CS$<>8__locals1 = new RogueBattleBuyRolePreviewPanel.<>c__DisplayClass12_0();
			CS$<>8__locals1.<>4__this = this;
			this.Data = data;
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(data.RogueResRole.RoleIdOrTrialRoleId, true);
			if (roleDataById == null)
			{
				return;
			}
			RogueResRole roleInfoById = RogueBattleModel.Instance.GetRoleInfoById(data.RogueResRole.RoleIdOrTrialRoleId);
			CS$<>8__locals1.roleConfig = roleDataById.GetRoleConfig();
			CS$<>8__locals1.roleMaxStar = RogueBattleModel.Instance.MaxRoleStar;
			CS$<>8__locals1.roleUpStar = data.RogueResRole.Level;
			CS$<>8__locals1.roleCurStar = ((roleInfoById != null) ? roleInfoById.Level : 0) + CS$<>8__locals1.roleUpStar;
			this.ElementItem.Refresh(CS$<>8__locals1.roleConfig.ElementId, false, 0);
			base.GetText(1).SetText(roleDataById.GetName(null), true);
			int curPrice = data.RogueResRole.CurPrice;
			int itemId = data.RogueResRole.ItemId;
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(data.RogueResRole.ItemId, 0);
			this.ConfirmButton.SetCostItem(itemId);
			this.ConfirmButton.SetCostText(curPrice.ToString(), new bool?(itemCountByConfigId < curPrice));
			UiAsyncTask task = new UiAsyncTask("RogueBattleBuyRolePreviewPanel.Refresh", delegate()
			{
				RogueBattleBuyRolePreviewPanel.<>c__DisplayClass12_0.<<Refresh>b__0>d <<Refresh>b__0>d;
				<<Refresh>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<Refresh>b__0>d.<>4__this = CS$<>8__locals1;
				<<Refresh>b__0>d.<>1__state = -1;
				<<Refresh>b__0>d.<>t__builder.Start<RogueBattleBuyRolePreviewPanel.<>c__DisplayClass12_0.<<Refresh>b__0>d>(ref <<Refresh>b__0>d);
				return <<Refresh>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x06033AA7 RID: 211623 RVA: 0x00C18B20 File Offset: 0x00C16D20
		private void SetStarLayoutSelectOn(bool bOn)
		{
			if (this.Data == null)
			{
				return;
			}
			RogueResRole roleInfoById = RogueBattleModel.Instance.GetRoleInfoById(this.Data.RogueResRole.RoleIdOrTrialRoleId);
			int maxRoleStar = RogueBattleModel.Instance.MaxRoleStar;
			int level = this.Data.RogueResRole.Level;
			int num = (roleInfoById != null) ? roleInfoById.Level : 0;
			int num2 = Math.Min(num + level, maxRoleStar);
			for (int i = num; i < num2; i++)
			{
				RogueBattleBuyRoleStarItem layoutItemByIndex = this.StarLayout.GetLayoutItemByIndex(i);
				if (layoutItemByIndex != null)
				{
					layoutItemByIndex.SetPreviewAnimOn(bOn);
				}
			}
		}

		// Token: 0x0401B651 RID: 112209
		public Action BackBtnFunc;

		// Token: 0x0401B652 RID: 112210
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RogueBattleBuyRoleStarItem, bool> StarLayout;

		// Token: 0x0401B653 RID: 112211
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RogueBattleFetterLvUpItem, IRogueBattleRoleBondUpdateInfo> FetterLayout;

		// Token: 0x0401B654 RID: 112212
		private RogueResGainData Data;

		// Token: 0x0401B655 RID: 112213
		private RogueBattleShopButton ConfirmButton;

		// Token: 0x0401B656 RID: 112214
		private RogueBattleTokenElement ElementItem;

		// Token: 0x0401B657 RID: 112215
		private readonly int IncId;

		// Token: 0x0200B008 RID: 45064
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04035724 RID: 218916
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<IRogueBattleRoleBondUpdateInfo> <0>__SortRogueBattleRoleBondUpdateInfo;
		}
	}
}
