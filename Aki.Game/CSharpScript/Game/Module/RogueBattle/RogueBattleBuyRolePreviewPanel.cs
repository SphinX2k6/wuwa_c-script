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
	// Token: 0x02003E12 RID: 15890
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueBattleBuyRolePreviewPanel : UiPanelBase
	{
		// Token: 0x0602890C RID: 166156 RVA: 0x00B61D3D File Offset: 0x00B5FF3D
		public RogueBattleBuyRolePreviewPanel(int incId)
		{
			this.IncId = incId;
		}

		// Token: 0x0602890D RID: 166157 RVA: 0x00B61D4C File Offset: 0x00B5FF4C
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

		// Token: 0x0602890E RID: 166158 RVA: 0x00B61E38 File Offset: 0x00B60038
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

		// Token: 0x0602890F RID: 166159 RVA: 0x00B61EA5 File Offset: 0x00B600A5
		private void OnBtnBack()
		{
			Action backBtnFunc = this.BackBtnFunc;
			if (backBtnFunc == null)
			{
				return;
			}
			backBtnFunc();
		}

		// Token: 0x06028910 RID: 166160 RVA: 0x00B61EB8 File Offset: 0x00B600B8
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleBuyRolePreviewPanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleBuyRolePreviewPanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028911 RID: 166161 RVA: 0x00B61EFC File Offset: 0x00B600FC
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

		// Token: 0x06028912 RID: 166162 RVA: 0x00B62048 File Offset: 0x00B60248
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

		// Token: 0x04016024 RID: 90148
		public Action BackBtnFunc;

		// Token: 0x04016025 RID: 90149
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RogueBattleBuyRoleStarItem, bool> StarLayout;

		// Token: 0x04016026 RID: 90150
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RogueBattleFetterLvUpItem, IRogueBattleRoleBondUpdateInfo> FetterLayout;

		// Token: 0x04016027 RID: 90151
		private RogueResGainData Data;

		// Token: 0x04016028 RID: 90152
		private RogueBattleShopButton ConfirmButton;

		// Token: 0x04016029 RID: 90153
		private RogueBattleTokenElement ElementItem;

		// Token: 0x0401602A RID: 90154
		private readonly int IncId;

		// Token: 0x02009A3A RID: 39482
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030154 RID: 196948
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<IRogueBattleRoleBondUpdateInfo> <0>__SortRogueBattleRoleBondUpdateInfo;
		}
	}
}
