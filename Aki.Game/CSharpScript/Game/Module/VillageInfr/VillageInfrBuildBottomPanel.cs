using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x0200486D RID: 18541
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrBuildBottomPanel : UiPanelBase
	{
		// Token: 0x06030875 RID: 198773 RVA: 0x00B44B1C File Offset: 0x00B42D1C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent))
			};
		}

		// Token: 0x06030876 RID: 198774 RVA: 0x00B44BFC File Offset: 0x00B42DFC
		private InfrV2TreeBuild GetTreeConfig()
		{
			return VillageInfrConfig.Instance.GetInfrTreeBuild(this.SelectId).Value;
		}

		// Token: 0x06030877 RID: 198775 RVA: 0x00B44C24 File Offset: 0x00B42E24
		private InfrV2Level GetVillageConfig()
		{
			return VillageInfrConfig.Instance.GetInfrLevel(this.SelectId).Value;
		}

		// Token: 0x06030878 RID: 198776 RVA: 0x00B44C4C File Offset: 0x00B42E4C
		protected override UniTask OnBeforeStartAsync()
		{
			VillageInfrBuildBottomPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VillageInfrBuildBottomPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030879 RID: 198777 RVA: 0x00B44C90 File Offset: 0x00B42E90
		private void SetOpenParam()
		{
			IVillageInfrBuildInfoParam villageInfrBuildInfoParam = this.OpenParam as IVillageInfrBuildInfoParam;
			this.SelectType = villageInfrBuildInfoParam.SelectType;
			this.SelectId = villageInfrBuildInfoParam.SelectId;
			this.IsDelivery = villageInfrBuildInfoParam.IsDelivery;
		}

		// Token: 0x0603087A RID: 198778 RVA: 0x00B44CD0 File Offset: 0x00B42ED0
		private UniTask CreateButton()
		{
			VillageInfrBuildBottomPanel.<CreateButton>d__9 <CreateButton>d__;
			<CreateButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButton>d__.<>4__this = this;
			<CreateButton>d__.<>1__state = -1;
			<CreateButton>d__.<>t__builder.Start<VillageInfrBuildBottomPanel.<CreateButton>d__9>(ref <CreateButton>d__);
			return <CreateButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603087B RID: 198779 RVA: 0x00B44D13 File Offset: 0x00B42F13
		protected override void OnStart()
		{
			this.Refresh(null);
		}

		// Token: 0x0603087C RID: 198780 RVA: 0x00B44D1C File Offset: 0x00B42F1C
		[NullableContext(2)]
		public void Refresh(IVillageInfrBuildInfoParam param = null)
		{
			if (param != null)
			{
				this.OpenParam = param;
				this.SetOpenParam();
			}
			this.RefreshLevel();
			this.RefreshProgress();
			this.RefreshMaxLevel();
			this.RefreshFinishState();
			this.RefreshButton();
		}

		// Token: 0x0603087D RID: 198781 RVA: 0x00B44D4C File Offset: 0x00B42F4C
		private void RefreshLevel()
		{
			if (this.SelectType != EVillageInfrSelectType.Village)
			{
				base.GetItem(0).SetUIActive(false);
				return;
			}
			base.GetItem(0).SetUIActive(true);
			base.GetText(1).ShowTextNew(this.GetVillageConfig().Name);
		}

		// Token: 0x0603087E RID: 198782 RVA: 0x00B44D98 File Offset: 0x00B42F98
		private void RefreshProgress()
		{
			if (this.SelectType == EVillageInfrSelectType.Village)
			{
				if (this.SelectId >= VillageInfrConfig.Instance.GetInfrMaxLevel())
				{
					base.GetItem(3).SetUIActive(false);
					return;
				}
				base.GetItem(3).SetUIActive(true);
				Dictionary<int, int>.Enumerator enumerator = this.GetVillageConfig().Requirement().GetEnumerator();
				enumerator.MoveNext();
				KeyValuePair<int, int> keyValuePair = enumerator.Current;
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				ItemInfo? config = ItemConfig.Instance.GetConfig(key);
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(key, 0);
				base.SetTextureByPath(config.Value.Icon, base.GetTexture(4), null, null);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "VillageInfr_Village_Quantityprops", new <>z__ReadOnlyArray<object>(new object[]
				{
					itemCountByConfigId,
					value
				}));
				return;
			}
			else
			{
				VillageInfrModel instance = VillageInfrModel.Instance;
				if (!instance.GetTreeIsUnlock(this.SelectId) || instance.GetTreeIsComplete(this.SelectId))
				{
					base.GetItem(3).SetUIActive(false);
					return;
				}
				base.GetItem(3).SetUIActive(true);
				Dictionary<int, int>.Enumerator enumerator2 = this.GetTreeConfig().Requirement().GetEnumerator();
				enumerator2.MoveNext();
				KeyValuePair<int, int> keyValuePair2 = enumerator2.Current;
				int key2 = keyValuePair2.Key;
				int value2 = keyValuePair2.Value;
				ItemInfo? config2 = ItemConfig.Instance.GetConfig(key2);
				int itemCountByConfigId2 = InventoryModel.Instance.GetItemCountByConfigId(key2, 0);
				base.SetTextureByPath(config2.Value.Icon, base.GetTexture(4), null, null);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "VillageInfr_Village_Quantityprops", new <>z__ReadOnlyArray<object>(new object[]
				{
					itemCountByConfigId2,
					value2
				}));
				return;
			}
		}

		// Token: 0x0603087F RID: 198783 RVA: 0x00B44F7E File Offset: 0x00B4317E
		private void RefreshMaxLevel()
		{
			if (this.SelectType == EVillageInfrSelectType.Village)
			{
				base.GetItem(6).SetUIActive(this.SelectId >= VillageInfrConfig.Instance.GetInfrMaxLevel());
				return;
			}
			base.GetItem(6).SetUIActive(false);
		}

		// Token: 0x06030880 RID: 198784 RVA: 0x00B44FB8 File Offset: 0x00B431B8
		private void RefreshFinishState()
		{
			if (this.SelectType == EVillageInfrSelectType.Village)
			{
				base.GetItem(7).SetUIActive(false);
				return;
			}
			IVillageInfrTreeData treeData = VillageInfrModel.Instance.GetTreeData(this.SelectId);
			base.GetItem(7).SetUIActive(treeData != null && treeData.Status == InfrV2StatusPb.InfrV2StatusComplete);
		}

		// Token: 0x06030881 RID: 198785 RVA: 0x00B45008 File Offset: 0x00B43208
		private void RefreshButton()
		{
			if (this.SelectType == EVillageInfrSelectType.Village)
			{
				this.RefreshVillageButton();
				return;
			}
			this.RefreshTreeButton();
		}

		// Token: 0x06030882 RID: 198786 RVA: 0x00B45020 File Offset: 0x00B43220
		private void RefreshVillageButton()
		{
			bool canVillageLevelUp = VillageInfrModel.Instance.GetCanVillageLevelUp();
			this.Button.SetRedDotVisible(canVillageLevelUp);
			this.Button.SetEnableClick(true);
			if (!this.IsDelivery)
			{
				this.Button.SetShowText("VillageInfr_Village_Go");
				return;
			}
			if (canVillageLevelUp)
			{
				this.Button.SetShowText("VillageInfr_Tree_Achieve");
				return;
			}
			this.Button.SetShowText("VillageInfr_Tree_InsufficientItem");
			this.Button.SetEnableClick(false);
		}

		// Token: 0x06030883 RID: 198787 RVA: 0x00B4509C File Offset: 0x00B4329C
		private void RefreshTreeButton()
		{
			VillageInfrModel instance = VillageInfrModel.Instance;
			IVillageInfrTreeData treeData = instance.GetTreeData(this.SelectId);
			this.Button.SetRedDotVisible(instance.GetCanTreeLevelUp(this.SelectId));
			this.Button.SetEnableClick(true);
			if (!instance.GetTreeIsUnlock(this.SelectId))
			{
				this.Button.SetShowText("VillageInfr_Tree_Locking");
				return;
			}
			if (!instance.GetCanTreeLevelUp(this.SelectId))
			{
				if (this.IsDelivery)
				{
					this.Button.SetShowText("VillageInfr_Tree_InsufficientItem");
					this.Button.SetEnableClick(false);
					return;
				}
				this.Button.SetShowText("VillageInfr_Tree_Tobuilt");
				return;
			}
			else
			{
				if (this.IsDelivery)
				{
					this.Button.SetShowText("VillageInfr_Tree_Achieve");
					this.Button.SetEnableClick(treeData == null || treeData.Status != InfrV2StatusPb.InfrV2StatusComplete);
					return;
				}
				this.Button.SetShowText("VillageInfr_Tree_Tobuilt");
				return;
			}
		}

		// Token: 0x06030884 RID: 198788 RVA: 0x00B45188 File Offset: 0x00B43388
		public void SetBottomBtnClickCb(Action cb)
		{
			this.Button.SetFunction(delegate(int _)
			{
				cb();
			});
		}

		// Token: 0x0401A109 RID: 106761
		private int SelectId;

		// Token: 0x0401A10A RID: 106762
		private EVillageInfrSelectType SelectType;

		// Token: 0x0401A10B RID: 106763
		private bool IsDelivery;

		// Token: 0x0401A10C RID: 106764
		private readonly ButtonItem Button = new ButtonItem(null);
	}
}
