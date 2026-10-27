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
	// Token: 0x02006622 RID: 26146
	public class FishingNormalTechViewLevelUpItem : UiPanelBase
	{
		// Token: 0x060418D3 RID: 268499 RVA: 0x00FE4DDC File Offset: 0x00FE2FDC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickLevelUpBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060418D4 RID: 268500 RVA: 0x00FE5016 File Offset: 0x00FE3216
		protected override void OnStart()
		{
			EventSystem.Instance.Add<int>(EEventName.OnFishingTechNodeRefresh, new Action<int>(this.OnFishingTechNodeRefresh));
			EventSystem.Instance.Add(EEventName.FishingTechViewComeBack, new Action(this.FishingTechViewComeBack));
		}

		// Token: 0x060418D5 RID: 268501 RVA: 0x00FE5050 File Offset: 0x00FE3250
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnFishingTechNodeRefresh, new Action<int>(this.OnFishingTechNodeRefresh));
			EventSystem.Instance.Remove(EEventName.FishingTechViewComeBack, new Action(this.FishingTechViewComeBack));
		}

		// Token: 0x060418D6 RID: 268502 RVA: 0x00FE508C File Offset: 0x00FE328C
		protected override UniTask OnBeforeStartAsync()
		{
			FishingNormalTechViewLevelUpItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingNormalTechViewLevelUpItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060418D7 RID: 268503 RVA: 0x00FE50CF File Offset: 0x00FE32CF
		private void OnFishingTechNodeRefresh(int nodeId)
		{
			IFishingTechNode node = this.Node;
			if (node == null || node.ConfigId != nodeId)
			{
				IFishingTechNode node2 = this.Node;
				if (node2 == null || node2.PreNode != nodeId)
				{
					return;
				}
			}
			this.RefreshView(this.Node);
		}

		// Token: 0x060418D8 RID: 268504 RVA: 0x00FE510B File Offset: 0x00FE330B
		private void FishingTechViewComeBack()
		{
			if (this.Node != null)
			{
				this.RefreshView(this.Node);
			}
		}

		// Token: 0x060418D9 RID: 268505 RVA: 0x00FE5124 File Offset: 0x00FE3324
		[NullableContext(1)]
		public void RefreshView(IFishingTechNode node)
		{
			FishingTech fishingTechById = FishingConfig.Instance.GetFishingTechById(node.ConfigId);
			this.Node = node;
			base.SetTextureByPath(fishingTechById.Icon, base.GetTexture(2), null, null);
			bool flag = this.Node.NodeType == EFishingTechNodeType.Core;
			base.GetItem(0).SetUIActive(flag);
			base.GetItem(1).SetUIActive(!flag);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(12), FishingDefine.fishingNodeTypeText[(int)node.NodeType], Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), fishingTechById.Name, Array.Empty<object>());
			int techNodeCurrentLevel = FishingModel.Instance.GetTechNodeCurrentLevel(node.ConfigId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "PrefabTextItem_3692737534_Text", new <>z__ReadOnlySingleElementList<object>(techNodeCurrentLevel));
			int effectLength = fishingTechById.EffectLength;
			if (techNodeCurrentLevel >= effectLength)
			{
				base.GetItem(13).SetUIActive(false);
				base.GetItem(11).SetUIActive(true);
				base.GetItem(10).SetUIActive(false);
				base.GetButton(9).RootUIComp.Get().SetUIActive(false);
				int techEffectId = fishingTechById.Effect(effectLength - 1);
				FishingTechEffect fishingTechEffectById = FishingConfig.Instance.GetFishingTechEffectById(techEffectId);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), fishingTechEffectById.Desc, fishingTechEffectById.ShowParams());
				FishingTechCostItem costItem = this.CostItem;
				if (costItem == null)
				{
					return;
				}
				costItem.SetUiActive(false);
				return;
			}
			else
			{
				base.GetItem(13).SetUIActive(true);
				base.GetItem(11).SetUIActive(false);
				bool nodePreNodeUnlock = FishingModel.Instance.GetNodePreNodeUnlock(node.ConfigId);
				bool nodeLevelUpItemEnough = FishingModel.Instance.GetNodeLevelUpItemEnough(node.ConfigId);
				base.GetItem(10).SetUIActive(!nodePreNodeUnlock || !nodeLevelUpItemEnough);
				if (!nodePreNodeUnlock)
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(14), "FishingTechLevelUpNotPreNodeLock", Array.Empty<object>());
				}
				else if (!nodeLevelUpItemEnough)
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(14), "FishingTechLevelUpNotEnough", Array.Empty<object>());
				}
				base.GetButton(9).RootUIComp.Get().SetUIActive(nodePreNodeUnlock && nodeLevelUpItemEnough);
				base.GetItem(11).SetUIActive(false);
				int techEffectId2 = fishingTechById.Effect(techNodeCurrentLevel);
				FishingTechEffect fishingTechEffectById2 = FishingConfig.Instance.GetFishingTechEffectById(techEffectId2);
				List<IFishingTechLevelUpItem> list = new List<IFishingTechLevelUpItem>();
				Dictionary<int, int> dictionary = fishingTechEffectById2.Consume();
				bool uiActive = false;
				foreach (KeyValuePair<int, int> keyValuePair in dictionary)
				{
					if (keyValuePair.Key == 27)
					{
						FishingTechCostItem costItem2 = this.CostItem;
						if (costItem2 != null)
						{
							costItem2.RefreshCost(keyValuePair.Key, keyValuePair.Value, true);
						}
						uiActive = true;
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
				GenericLayout<FishingTechLevelUpItem, IFishingTechLevelUpItem> itemLayout = this.ItemLayout;
				if (itemLayout != null)
				{
					itemLayout.RefreshByData(list, null, false);
				}
				FishingTechCostItem costItem3 = this.CostItem;
				if (costItem3 != null)
				{
					costItem3.SetUiActive(uiActive);
				}
				if (techNodeCurrentLevel == 0)
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(5), fishingTechEffectById2.Desc, fishingTechEffectById2.ShowParams());
					return;
				}
				int techEffectId3 = fishingTechById.Effect(techNodeCurrentLevel - 1);
				FishingTechEffect fishingTechEffectById3 = FishingConfig.Instance.GetFishingTechEffectById(techEffectId3);
				List<string> list2 = new List<string>();
				int showParamsLength = fishingTechEffectById3.ShowParamsLength;
				for (int i = 0; i < showParamsLength; i++)
				{
					string item2 = fishingTechEffectById3.ShowParams(i) + "->" + fishingTechEffectById2.ShowParams(i);
					list2.Add(item2);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), fishingTechEffectById2.Desc, list2.ToArray());
				return;
			}
		}

		// Token: 0x060418DA RID: 268506 RVA: 0x00FE5500 File Offset: 0x00FE3700
		[NullableContext(1)]
		private FishingTechLevelUpItem InitItem()
		{
			return new FishingTechLevelUpItem();
		}

		// Token: 0x060418DB RID: 268507 RVA: 0x00FE5507 File Offset: 0x00FE3707
		private void OnClickLevelUpBtn()
		{
			if (this.Node != null)
			{
				FishingController.Instance.RequestFishingTechLevelUp(this.Node.ConfigId);
			}
		}

		// Token: 0x040221B2 RID: 139698
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<FishingTechLevelUpItem, IFishingTechLevelUpItem> ItemLayout;

		// Token: 0x040221B3 RID: 139699
		[Nullable(2)]
		private FishingTechCostItem CostItem;

		// Token: 0x040221B4 RID: 139700
		[Nullable(2)]
		private IFishingTechNode Node;

		// Token: 0x0200C83A RID: 51258
		private class EComponentDefine
		{
			// Token: 0x0403C7A8 RID: 247720
			public const int CubeBgItem = 0;

			// Token: 0x0403C7A9 RID: 247721
			public const int CircleBgItem = 1;

			// Token: 0x0403C7AA RID: 247722
			public const int TechTexture = 2;

			// Token: 0x0403C7AB RID: 247723
			public const int TechTitleText = 3;

			// Token: 0x0403C7AC RID: 247724
			public const int TechLevelText = 4;

			// Token: 0x0403C7AD RID: 247725
			public const int TechDesText = 5;

			// Token: 0x0403C7AE RID: 247726
			public const int LevelUpItemLayout = 6;

			// Token: 0x0403C7AF RID: 247727
			public const int LevelUpItem = 7;

			// Token: 0x0403C7B0 RID: 247728
			public const int CostItem = 8;

			// Token: 0x0403C7B1 RID: 247729
			public const int LevelUpBtn = 9;

			// Token: 0x0403C7B2 RID: 247730
			public const int NotEnoughItem = 10;

			// Token: 0x0403C7B3 RID: 247731
			public const int MaxLevelItem = 11;

			// Token: 0x0403C7B4 RID: 247732
			public const int LevelDesText = 12;

			// Token: 0x0403C7B5 RID: 247733
			public const int CostPanelItem = 13;

			// Token: 0x0403C7B6 RID: 247734
			public const int CannotLevelUpReasonText = 14;
		}
	}
}
