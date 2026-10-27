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
	// Token: 0x02006621 RID: 26145
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingNormalTechView : UiTabViewBase
	{
		// Token: 0x060418C9 RID: 268489 RVA: 0x00FE48F4 File Offset: 0x00FE2AF4
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

		// Token: 0x060418CA RID: 268490 RVA: 0x00FE4A68 File Offset: 0x00FE2C68
		protected override UniTask OnBeforeStartAsync()
		{
			FishingNormalTechView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingNormalTechView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060418CB RID: 268491 RVA: 0x00FE4AAC File Offset: 0x00FE2CAC
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

		// Token: 0x060418CC RID: 268492 RVA: 0x00FE4CB0 File Offset: 0x00FE2EB0
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x060418CD RID: 268493 RVA: 0x00FE4CB8 File Offset: 0x00FE2EB8
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

		// Token: 0x060418CE RID: 268494 RVA: 0x00FE4CE4 File Offset: 0x00FE2EE4
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

		// Token: 0x060418CF RID: 268495 RVA: 0x00FE4D87 File Offset: 0x00FE2F87
		private FishingNormalTechCostItem InitItem()
		{
			return new FishingNormalTechCostItem();
		}

		// Token: 0x040221A6 RID: 139686
		public const int TECH_NODE_AREA_ONE = 1;

		// Token: 0x040221A7 RID: 139687
		public const int TECH_NODE_AREA_TWO = 2;

		// Token: 0x040221A8 RID: 139688
		public const int TECH_NODE_AREA_THREE = 3;

		// Token: 0x040221A9 RID: 139689
		private FishingTechNodeItem FirstNodeItem;

		// Token: 0x040221AA RID: 139690
		private FishingTechAreaItem NodeAreaOneItem;

		// Token: 0x040221AB RID: 139691
		private FishingTechAreaItem NodeAreaTwoItem;

		// Token: 0x040221AC RID: 139692
		private FishingTechAreaItem NodeAreaThreeItem;

		// Token: 0x040221AD RID: 139693
		private FishingTechNodeItem LastNodeItem;

		// Token: 0x040221AE RID: 139694
		private FishingNormalTechViewLevelUpItem LevelUpItem;

		// Token: 0x040221AF RID: 139695
		private GenericLayout<FishingNormalTechCostItem, int> CostLayout;

		// Token: 0x040221B0 RID: 139696
		private UUIExtendToggle CurrentSelectToggle;

		// Token: 0x040221B1 RID: 139697
		private int LastSelectNodeId;

		// Token: 0x0200C838 RID: 51256
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C79A RID: 247706
			public const int FirstNodeItem = 0;

			// Token: 0x0403C79B RID: 247707
			public const int NodeAreaOneItem = 1;

			// Token: 0x0403C79C RID: 247708
			public const int NodeAreaTwoItem = 2;

			// Token: 0x0403C79D RID: 247709
			public const int NodeAreaThreeItem = 3;

			// Token: 0x0403C79E RID: 247710
			public const int LastNodeItem = 4;

			// Token: 0x0403C79F RID: 247711
			public const int CostListLayout = 5;

			// Token: 0x0403C7A0 RID: 247712
			public const int CostItem = 6;

			// Token: 0x0403C7A1 RID: 247713
			public const int NodeLevelUpItem = 7;

			// Token: 0x0403C7A2 RID: 247714
			public const int ScrollView = 8;

			// Token: 0x0403C7A3 RID: 247715
			public const int ScrollViewContentItem = 9;
		}
	}
}
