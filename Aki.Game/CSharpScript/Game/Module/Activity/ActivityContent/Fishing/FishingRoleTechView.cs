using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020055A3 RID: 21923
	[NullableContext(2)]
	[Nullable(0)]
	public class FishingRoleTechView : UiTabViewBase
	{
		// Token: 0x060365AA RID: 222634 RVA: 0x00F2CA78 File Offset: 0x00F2AC78
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickLevelUpBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060365AB RID: 222635 RVA: 0x00F2CCD4 File Offset: 0x00F2AED4
		protected override UniTask OnBeforeStartAsync()
		{
			FishingRoleTechView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingRoleTechView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060365AC RID: 222636 RVA: 0x00F2CD18 File Offset: 0x00F2AF18
		protected override void OnStart()
		{
			RoleTechToggle rightToggle = this.RightToggle;
			if (rightToggle != null)
			{
				rightToggle.RefreshItem(5);
			}
			RoleTechToggle leftToggle = this.LeftToggle;
			if (leftToggle != null)
			{
				leftToggle.RefreshItem(4);
			}
			int? num = this.ExtraParams as int?;
			if (num != null)
			{
				this.TargetNodeId = num.Value;
				List<IFishingTechNode> list = FishingModel.Instance.RoleTechNodeMap[5];
				bool flag = false;
				foreach (IFishingTechNode fishingTechNode in list)
				{
					int configId = fishingTechNode.ConfigId;
					int? num2 = num;
					if (configId == num2.GetValueOrDefault() & num2 != null)
					{
						RoleTechToggle rightToggle2 = this.RightToggle;
						if (rightToggle2 != null)
						{
							rightToggle2.SelectToggle();
						}
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					RoleTechToggle leftToggle2 = this.LeftToggle;
					if (leftToggle2 != null)
					{
						leftToggle2.SelectToggle();
					}
				}
			}
			else
			{
				RoleTechToggle leftToggle3 = this.LeftToggle;
				if (leftToggle3 != null)
				{
					leftToggle3.SelectToggle();
				}
			}
			EventSystem.Instance.Emit(EEventName.FishingRoleTechViewOpened);
			if (!FunctionModel.Instance.IsOpen(100781))
			{
				base.GetItem(13).SetUIActive(false);
			}
		}

		// Token: 0x060365AD RID: 222637 RVA: 0x00F2CE44 File Offset: 0x00F2B044
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.FishingRoleToggleTech, base.GetItem(12), 5);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.FishingRoleToggleTech, base.GetItem(11), 4);
		}

		// Token: 0x060365AE RID: 222638 RVA: 0x00F2CE78 File Offset: 0x00F2B078
		protected override void OnBeforeShow()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Switch", false, null, false);
		}

		// Token: 0x060365AF RID: 222639 RVA: 0x00F2CEA5 File Offset: 0x00F2B0A5
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.OnFishingTechNodeRefresh, new Action<int>(this.OnFishingTechNodeRefresh));
			EventSystem.Instance.Add(EEventName.FishingTechViewComeBack, new Action(this.FishingTechViewComeBack));
		}

		// Token: 0x060365B0 RID: 222640 RVA: 0x00F2CEDF File Offset: 0x00F2B0DF
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnFishingTechNodeRefresh, new Action<int>(this.OnFishingTechNodeRefresh));
			EventSystem.Instance.Remove(EEventName.FishingTechViewComeBack, new Action(this.FishingTechViewComeBack));
		}

		// Token: 0x060365B1 RID: 222641 RVA: 0x00F2CF19 File Offset: 0x00F2B119
		private void OnFishingTechNodeRefresh(int nodeId)
		{
			this.CurrentSelectToggle = null;
			this.RefreshView(this.CurrentRole);
			EventSystem.Instance.Emit<int>(EEventName.OnFishingTechNodeRedDotRefresh, nodeId);
			EventSystem.Instance.Emit<EFishingTechNodeType>(EEventName.OnFishingRoleTechRefresh, (EFishingTechNodeType)this.CurrentRole);
		}

		// Token: 0x060365B2 RID: 222642 RVA: 0x00F2CF55 File Offset: 0x00F2B155
		private void FishingTechViewComeBack()
		{
			if (this.CurrentRole != 0)
			{
				this.RefreshView(this.CurrentRole);
			}
		}

		// Token: 0x060365B3 RID: 222643 RVA: 0x00F2CF6C File Offset: 0x00F2B16C
		private void RefreshView(int roleType)
		{
			this.CurrentRole = roleType;
			int currentRole = this.CurrentRole;
			string resourceId;
			if (currentRole != 4)
			{
				if (currentRole != 5)
				{
					resourceId = "T_NavigationRoleFeibi";
				}
				else
				{
					resourceId = "T_NavigationRoleFeibi";
				}
			}
			else
			{
				resourceId = ((PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? "T_NavigationRoleFemale" : "T_NavigationRoleMale");
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetTextureByPath(resourcePath, base.GetTexture(0), null, null);
			List<IFishingTechNode> list;
			List<IFishingTechNode> data = FishingModel.Instance.RoleTechNodeMap.TryGetValue(roleType, out list) ? list : new List<IFishingTechNode>();
			GenericLayout<FishingRoleTechItem, IFishingTechNode> roleTechNodeLayout = this.RoleTechNodeLayout;
			if (roleTechNodeLayout == null)
			{
				return;
			}
			roleTechNodeLayout.RefreshByData(data, delegate
			{
				GenericLayout<FishingRoleTechItem, IFishingTechNode> roleTechNodeLayout2 = this.RoleTechNodeLayout;
				if (roleTechNodeLayout2 != null)
				{
					UUIInturnAnimController uiAnimController = roleTechNodeLayout2.GetUiAnimController();
					if (uiAnimController != null)
					{
						uiAnimController.Play("", -1, false);
					}
				}
				GenericLayout<FishingRoleTechItem, IFishingTechNode> roleTechNodeLayout3 = this.RoleTechNodeLayout;
				foreach (FishingRoleTechItem fishingRoleTechItem in ((roleTechNodeLayout3 != null) ? roleTechNodeLayout3.GetLayoutItemList() : null))
				{
					if (this.TargetNodeId == 0 || fishingRoleTechItem.Node != this.CurrentNode)
					{
						IFishingTechNode node = fishingRoleTechItem.Node;
						int? num = (node != null) ? new int?(node.ConfigId) : null;
						int targetNodeId = this.TargetNodeId;
						if (!(num.GetValueOrDefault() == targetNodeId & num != null))
						{
							continue;
						}
					}
					this.TargetNodeId = 0;
					fishingRoleTechItem.SelectToggle();
					return;
				}
				GenericLayout<FishingRoleTechItem, IFishingTechNode> roleTechNodeLayout4 = this.RoleTechNodeLayout;
				if (roleTechNodeLayout4 == null)
				{
					return;
				}
				FishingRoleTechItem layoutItemByIndex = roleTechNodeLayout4.GetLayoutItemByIndex(0);
				if (layoutItemByIndex == null)
				{
					return;
				}
				layoutItemByIndex.SelectToggle();
			}, false);
		}

		// Token: 0x060365B4 RID: 222644 RVA: 0x00F2D023 File Offset: 0x00F2B223
		[NullableContext(1)]
		private void OnClickRightToggle(UUIExtendToggle toggle)
		{
			if (this.CurrentRole != 5)
			{
				this.RefreshView(5);
				UUIExtendToggle currentSelectRoleToggle = this.CurrentSelectRoleToggle;
				if (currentSelectRoleToggle != null)
				{
					currentSelectRoleToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				}
				this.CurrentSelectRoleToggle = toggle;
			}
		}

		// Token: 0x060365B5 RID: 222645 RVA: 0x00F2D052 File Offset: 0x00F2B252
		[NullableContext(1)]
		private void OnClickLeftToggle(UUIExtendToggle toggle)
		{
			if (this.CurrentRole != 4)
			{
				this.RefreshView(4);
				UUIExtendToggle currentSelectRoleToggle = this.CurrentSelectRoleToggle;
				if (currentSelectRoleToggle != null)
				{
					currentSelectRoleToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				}
				this.CurrentSelectRoleToggle = toggle;
			}
		}

		// Token: 0x060365B6 RID: 222646 RVA: 0x00F2D081 File Offset: 0x00F2B281
		private void OnClickLevelUpBtn()
		{
			if (this.CurrentNode != null)
			{
				FishingController.Instance.RequestFishingTechLevelUp(this.CurrentNode.ConfigId);
			}
		}

		// Token: 0x060365B7 RID: 222647 RVA: 0x00F2D0A0 File Offset: 0x00F2B2A0
		[NullableContext(1)]
		private FishingTechLevelUpItem InitItem()
		{
			return new FishingTechLevelUpItem();
		}

		// Token: 0x060365B8 RID: 222648 RVA: 0x00F2D0A7 File Offset: 0x00F2B2A7
		[NullableContext(1)]
		private FishingRoleTechItem InitRoleTech()
		{
			return new FishingRoleTechItem
			{
				OnClickToggleBack = new Action<IFishingTechNode, UUIExtendToggle>(this.OnClickFishingRoleTechItem)
			};
		}

		// Token: 0x060365B9 RID: 222649 RVA: 0x00F2D0C0 File Offset: 0x00F2B2C0
		[NullableContext(1)]
		private void OnClickFishingRoleTechItem(IFishingTechNode node, UUIExtendToggle toggle)
		{
			UUIExtendToggle currentSelectToggle = this.CurrentSelectToggle;
			if (currentSelectToggle != null)
			{
				currentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.CurrentSelectToggle = toggle;
			this.CurrentNode = node;
			FishingTech fishingTechById = FishingConfig.Instance.GetFishingTechById(node.ConfigId);
			int techNodeCurrentLevel = FishingModel.Instance.GetTechNodeCurrentLevel(node.ConfigId);
			int effectLength = fishingTechById.EffectLength;
			if (techNodeCurrentLevel >= effectLength)
			{
				base.GetHorizontalLayout(6).RootUIComp.Get().SetUIActive(false);
				base.GetItem(10).SetUIActive(true);
				base.GetButton(8).RootUIComp.Get().SetUIActive(false);
				FishingTechCostItem costItem = this.CostItem;
				if (costItem != null)
				{
					costItem.SetUiActive(false);
				}
				base.GetItem(14).SetUIActive(false);
				return;
			}
			base.GetItem(14).SetUIActive(true);
			base.GetHorizontalLayout(6).RootUIComp.Get().SetUIActive(true);
			base.GetItem(10).SetUIActive(false);
			int techEffectId = fishingTechById.Effect(techNodeCurrentLevel);
			FishingTechEffect fishingTechEffectById = FishingConfig.Instance.GetFishingTechEffectById(techEffectId);
			List<IFishingTechLevelUpItem> list = new List<IFishingTechLevelUpItem>();
			Dictionary<int, int> dictionary = fishingTechEffectById.Consume();
			bool uiActive = false;
			bool flag = true;
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(keyValuePair.Key, 0);
				flag = (flag && itemCountByConfigId >= keyValuePair.Value);
				uiActive = true;
				if (keyValuePair.Key == 27)
				{
					FishingTechCostItem costItem2 = this.CostItem;
					if (costItem2 != null)
					{
						costItem2.RefreshCost(keyValuePair.Key, keyValuePair.Value, false);
					}
				}
				else
				{
					FishingTechLevelUpItemData item = new FishingTechLevelUpItemData
					{
						ItemId = keyValuePair.Key,
						ItemNeedNum = keyValuePair.Value
					};
					list.Add(item);
				}
			}
			base.GetButton(8).RootUIComp.Get().SetUIActive(flag);
			base.GetItem(9).SetUIActive(!flag);
			GenericLayout<FishingTechLevelUpItem, IFishingTechLevelUpItem> itemLayout = this.ItemLayout;
			if (itemLayout != null)
			{
				itemLayout.RefreshByData(list, null, false);
			}
			FishingTechCostItem costItem3 = this.CostItem;
			if (costItem3 == null)
			{
				return;
			}
			costItem3.SetUiActive(uiActive);
		}

		// Token: 0x0401CAEB RID: 117483
		private int CurrentRole;

		// Token: 0x0401CAEC RID: 117484
		private IFishingTechNode CurrentNode;

		// Token: 0x0401CAED RID: 117485
		private RoleTechToggle RightToggle;

		// Token: 0x0401CAEE RID: 117486
		private RoleTechToggle LeftToggle;

		// Token: 0x0401CAEF RID: 117487
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<FishingRoleTechItem, IFishingTechNode> RoleTechNodeLayout;

		// Token: 0x0401CAF0 RID: 117488
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<FishingTechLevelUpItem, IFishingTechLevelUpItem> ItemLayout;

		// Token: 0x0401CAF1 RID: 117489
		private UUIExtendToggle CurrentSelectToggle;

		// Token: 0x0401CAF2 RID: 117490
		private UUIExtendToggle CurrentSelectRoleToggle;

		// Token: 0x0401CAF3 RID: 117491
		private FishingTechCostItem CostItem;

		// Token: 0x0401CAF4 RID: 117492
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401CAF5 RID: 117493
		private int TargetNodeId;

		// Token: 0x0200B21F RID: 45599
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403710A RID: 225546
			public const int RoleTexture = 0;

			// Token: 0x0403710B RID: 225547
			public const int LeftToggleItem = 1;

			// Token: 0x0403710C RID: 225548
			public const int RightToggleItem = 2;

			// Token: 0x0403710D RID: 225549
			public const int RoleTechNodeItemLayout = 3;

			// Token: 0x0403710E RID: 225550
			public const int RoleTechNodeItem = 4;

			// Token: 0x0403710F RID: 225551
			public const int CostItem = 5;

			// Token: 0x04037110 RID: 225552
			public const int NeedItemLayout = 6;

			// Token: 0x04037111 RID: 225553
			public const int NeedItem = 7;

			// Token: 0x04037112 RID: 225554
			public const int LevelUpBtn = 8;

			// Token: 0x04037113 RID: 225555
			public const int NotEnoughItem = 9;

			// Token: 0x04037114 RID: 225556
			public const int MaxLevelItem = 10;

			// Token: 0x04037115 RID: 225557
			public const int LeftToggleRedDotItem = 11;

			// Token: 0x04037116 RID: 225558
			public const int RightToggleRedDotItem = 12;

			// Token: 0x04037117 RID: 225559
			public const int RoleTypeRootItem = 13;

			// Token: 0x04037118 RID: 225560
			public const int CostDesItem = 14;
		}
	}
}
