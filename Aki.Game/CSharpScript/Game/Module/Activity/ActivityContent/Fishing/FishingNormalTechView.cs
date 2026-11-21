using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200559F RID: 21919
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingNormalTechView : UiTabViewBase
	{
		// Token: 0x0603658E RID: 222606 RVA: 0x00F2B9A8 File Offset: 0x00F29BA8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603658F RID: 222607 RVA: 0x00F2BB1C File Offset: 0x00F29D1C
		protected override UniTask OnBeforeStartAsync()
		{
			FishingNormalTechView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingNormalTechView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036590 RID: 222608 RVA: 0x00F2BB60 File Offset: 0x00F29D60
		protected override void OnStart()
		{
			this.NodeAreaOneItem.OnClickToggleBack = new Action<IFishingTechNode, UUIExtendToggle>(this.OnClickItem);
			this.NodeAreaTwoItem.OnClickToggleBack = new Action<IFishingTechNode, UUIExtendToggle>(this.OnClickItem);
			this.NodeAreaThreeItem.OnClickToggleBack = new Action<IFishingTechNode, UUIExtendToggle>(this.OnClickItem);
			foreach (KeyValuePair<int, List<IFishingTechNode>> keyValuePair in FishingModel.Instance.NormalTechNodeMap)
			{
				int num;
				List<IFishingTechNode> list;
				keyValuePair.Deconstruct(out num, out list);
				int num2 = num;
				List<IFishingTechNode> list2 = list;
				switch (num2)
				{
				case 1:
				{
					FishingTechAreaItem nodeAreaOneItem = this.NodeAreaOneItem;
					if (nodeAreaOneItem != null)
					{
						nodeAreaOneItem.RefreshNodeList(list2.ToArray());
					}
					break;
				}
				case 2:
				{
					FishingTechAreaItem nodeAreaTwoItem = this.NodeAreaTwoItem;
					if (nodeAreaTwoItem != null)
					{
						nodeAreaTwoItem.RefreshNodeList(list2.ToArray());
					}
					break;
				}
				case 3:
				{
					FishingTechAreaItem nodeAreaThreeItem = this.NodeAreaThreeItem;
					if (nodeAreaThreeItem != null)
					{
						nodeAreaThreeItem.RefreshNodeList(list2.ToArray());
					}
					break;
				}
				}
			}
			IFishingTechNode firstNode = FishingModel.Instance.GetFirstNode();
			FishingTechNodeItem firstNodeItem = this.FirstNodeItem;
			if (firstNodeItem != null)
			{
				firstNodeItem.RefreshNode(firstNode);
			}
			IFishingTechNode lastNode = FishingModel.Instance.GetLastNode();
			FishingTechNodeItem lastNodeItem = this.LastNodeItem;
			if (lastNodeItem != null)
			{
				lastNodeItem.RefreshNode(lastNode);
			}
			IFishingTechNode fishingTechNode;
			if (this.ExtraParams != null)
			{
				fishingTechNode = FishingModel.Instance.GetNormalTechNodeById((int)this.ExtraParams);
			}
			else
			{
				fishingTechNode = FishingModel.Instance.GetFirstUnlockNode();
			}
			if (fishingTechNode == null)
			{
				return;
			}
			if (fishingTechNode.Area == 0)
			{
				this.FirstNodeItem.SelectNode();
			}
			else if (fishingTechNode.Area == 4)
			{
				this.LastNodeItem.SelectNode();
			}
			else
			{
				FishingTechAreaItem nodeAreaOneItem2 = this.NodeAreaOneItem;
				if (nodeAreaOneItem2 != null)
				{
					nodeAreaOneItem2.FindAndSelectNode(fishingTechNode);
				}
				FishingTechAreaItem nodeAreaTwoItem2 = this.NodeAreaTwoItem;
				if (nodeAreaTwoItem2 != null)
				{
					nodeAreaTwoItem2.FindAndSelectNode(fishingTechNode);
				}
				FishingTechAreaItem nodeAreaThreeItem2 = this.NodeAreaThreeItem;
				if (nodeAreaThreeItem2 != null)
				{
					nodeAreaThreeItem2.FindAndSelectNode(fishingTechNode);
				}
			}
			if (fishingTechNode.Area >= 3)
			{
				base.GetScrollViewWithScrollbar(8).OnLateUpdate.Bind(delegate(float _)
				{
					TimerSystem.GameplayTimeInstance.Next(delegate(float _)
					{
						base.GetScrollViewWithScrollbar(8).ScrollTo(this.LastNodeItem.GetRootItem(), false);
					}, null, null);
					base.GetScrollViewWithScrollbar(8).OnLateUpdate.Unbind();
				});
			}
		}

		// Token: 0x06036591 RID: 222609 RVA: 0x00F2BD64 File Offset: 0x00F29F64
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x06036592 RID: 222610 RVA: 0x00F2BD6C File Offset: 0x00F29F6C
		private void RefreshView()
		{
			GenericLayout<FishingNormalTechCostItem, int> costLayout = this.CostLayout;
			if (costLayout == null)
			{
				return;
			}
			costLayout.RefreshByData(new <>z__ReadOnlyArray<int>(new int[]
			{
				38,
				37,
				29,
				30,
				31
			}), null, false);
		}

		// Token: 0x06036593 RID: 222611 RVA: 0x00F2BD98 File Offset: 0x00F29F98
		private void OnClickItem(IFishingTechNode node, UUIExtendToggle toggle)
		{
			if (this.LastSelectNodeId != 0)
			{
				if (!FishingModel.Instance.GetFishingTechUnlock(this.LastSelectNodeId))
				{
					UUIExtendToggle currentSelectToggle = this.CurrentSelectToggle;
					if (currentSelectToggle != null)
					{
						currentSelectToggle.SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
					}
				}
				else
				{
					UUIExtendToggle currentSelectToggle2 = this.CurrentSelectToggle;
					if (currentSelectToggle2 != null)
					{
						currentSelectToggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
					}
				}
			}
			else
			{
				UUIExtendToggle currentSelectToggle3 = this.CurrentSelectToggle;
				if (currentSelectToggle3 != null)
				{
					currentSelectToggle3.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				}
			}
			this.CurrentSelectToggle = toggle;
			this.LastSelectNodeId = node.ConfigId;
			FishingNormalTechViewLevelUpItem levelUpItem = this.LevelUpItem;
			if (levelUpItem != null)
			{
				levelUpItem.SetUiActive(true);
			}
			FishingNormalTechViewLevelUpItem levelUpItem2 = this.LevelUpItem;
			if (levelUpItem2 == null)
			{
				return;
			}
			levelUpItem2.RefreshView(node);
		}

		// Token: 0x06036594 RID: 222612 RVA: 0x00F2BE3B File Offset: 0x00F2A03B
		private FishingNormalTechCostItem InitItem()
		{
			return new FishingNormalTechCostItem();
		}

		// Token: 0x0401CAD7 RID: 117463
		public const int TECH_NODE_AREA_ONE = 1;

		// Token: 0x0401CAD8 RID: 117464
		public const int TECH_NODE_AREA_TWO = 2;

		// Token: 0x0401CAD9 RID: 117465
		public const int TECH_NODE_AREA_THREE = 3;

		// Token: 0x0401CADA RID: 117466
		private FishingTechNodeItem FirstNodeItem;

		// Token: 0x0401CADB RID: 117467
		private FishingTechAreaItem NodeAreaOneItem;

		// Token: 0x0401CADC RID: 117468
		private FishingTechAreaItem NodeAreaTwoItem;

		// Token: 0x0401CADD RID: 117469
		private FishingTechAreaItem NodeAreaThreeItem;

		// Token: 0x0401CADE RID: 117470
		private FishingTechNodeItem LastNodeItem;

		// Token: 0x0401CADF RID: 117471
		private FishingNormalTechViewLevelUpItem LevelUpItem;

		// Token: 0x0401CAE0 RID: 117472
		private GenericLayout<FishingNormalTechCostItem, int> CostLayout;

		// Token: 0x0401CAE1 RID: 117473
		private UUIExtendToggle CurrentSelectToggle;

		// Token: 0x0401CAE2 RID: 117474
		private int LastSelectNodeId;

		// Token: 0x0200B21A RID: 45594
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040370DF RID: 225503
			public const int FirstNodeItem = 0;

			// Token: 0x040370E0 RID: 225504
			public const int NodeAreaOneItem = 1;

			// Token: 0x040370E1 RID: 225505
			public const int NodeAreaTwoItem = 2;

			// Token: 0x040370E2 RID: 225506
			public const int NodeAreaThreeItem = 3;

			// Token: 0x040370E3 RID: 225507
			public const int LastNodeItem = 4;

			// Token: 0x040370E4 RID: 225508
			public const int CostListLayout = 5;

			// Token: 0x040370E5 RID: 225509
			public const int CostItem = 6;

			// Token: 0x040370E6 RID: 225510
			public const int NodeLevelUpItem = 7;

			// Token: 0x040370E7 RID: 225511
			public const int ScrollView = 8;

			// Token: 0x040370E8 RID: 225512
			public const int ScrollViewContentItem = 9;
		}
	}
}
