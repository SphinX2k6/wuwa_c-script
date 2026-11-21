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
	// Token: 0x020037E4 RID: 14308
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrBuildBottomPanel : UiPanelBase
	{
		// Token: 0x060253A1 RID: 152481 RVA: 0x00A7F8B8 File Offset: 0x00A7DAB8
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

		// Token: 0x060253A2 RID: 152482 RVA: 0x00A7F998 File Offset: 0x00A7DB98
		private InfrV2TreeBuild GetTreeConfig()
		{
			return VillageInfrConfig.Instance.GetInfrTreeBuild(this.SelectId).Value;
		}

		// Token: 0x060253A3 RID: 152483 RVA: 0x00A7F9C0 File Offset: 0x00A7DBC0
		private InfrV2Level GetVillageConfig()
		{
			return VillageInfrConfig.Instance.GetInfrLevel(this.SelectId).Value;
		}

		// Token: 0x060253A4 RID: 152484 RVA: 0x00A7F9E8 File Offset: 0x00A7DBE8
		protected override UniTask OnBeforeStartAsync()
		{
			VillageInfrBuildBottomPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VillageInfrBuildBottomPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060253A5 RID: 152485 RVA: 0x00A7FA2C File Offset: 0x00A7DC2C
		private void SetOpenParam()
		{
			IVillageInfrBuildInfoParam villageInfrBuildInfoParam = this.OpenParam as IVillageInfrBuildInfoParam;
			this.SelectType = villageInfrBuildInfoParam.SelectType;
			this.SelectId = villageInfrBuildInfoParam.SelectId;
			this.IsDelivery = villageInfrBuildInfoParam.IsDelivery;
		}

		// Token: 0x060253A6 RID: 152486 RVA: 0x00A7FA6C File Offset: 0x00A7DC6C
		private UniTask CreateButton()
		{
			VillageInfrBuildBottomPanel.<CreateButton>d__9 <CreateButton>d__;
			<CreateButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButton>d__.<>4__this = this;
			<CreateButton>d__.<>1__state = -1;
			<CreateButton>d__.<>t__builder.Start<VillageInfrBuildBottomPanel.<CreateButton>d__9>(ref <CreateButton>d__);
			return <CreateButton>d__.<>t__builder.Task;
		}

		// Token: 0x060253A7 RID: 152487 RVA: 0x00A7FAAF File Offset: 0x00A7DCAF
		protected override void OnStart()
		{
			this.Refresh(null);
		}

		// Token: 0x060253A8 RID: 152488 RVA: 0x00A7FAB8 File Offset: 0x00A7DCB8
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

		// Token: 0x060253A9 RID: 152489 RVA: 0x00A7FAE8 File Offset: 0x00A7DCE8
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

		// Token: 0x060253AA RID: 152490 RVA: 0x00A7FB34 File Offset: 0x00A7DD34
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

		// Token: 0x060253AB RID: 152491 RVA: 0x00A7FD1A File Offset: 0x00A7DF1A
		private void RefreshMaxLevel()
		{
			if (this.SelectType == EVillageInfrSelectType.Village)
			{
				base.GetItem(6).SetUIActive(this.SelectId >= VillageInfrConfig.Instance.GetInfrMaxLevel());
				return;
			}
			base.GetItem(6).SetUIActive(false);
		}

		// Token: 0x060253AC RID: 152492 RVA: 0x00A7FD54 File Offset: 0x00A7DF54
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

		// Token: 0x060253AD RID: 152493 RVA: 0x00A7FDA4 File Offset: 0x00A7DFA4
		private void RefreshButton()
		{
			if (this.SelectType == EVillageInfrSelectType.Village)
			{
				this.RefreshVillageButton();
				return;
			}
			this.RefreshTreeButton();
		}

		// Token: 0x060253AE RID: 152494 RVA: 0x00A7FDBC File Offset: 0x00A7DFBC
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

		// Token: 0x060253AF RID: 152495 RVA: 0x00A7FE38 File Offset: 0x00A7E038
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

		// Token: 0x060253B0 RID: 152496 RVA: 0x00A7FF24 File Offset: 0x00A7E124
		public void SetBottomBtnClickCb(Action cb)
		{
			this.Button.SetFunction(delegate(int _)
			{
				cb();
			});
		}

		// Token: 0x0401497C RID: 84348
		private int SelectId;

		// Token: 0x0401497D RID: 84349
		private EVillageInfrSelectType SelectType;

		// Token: 0x0401497E RID: 84350
		private bool IsDelivery;

		// Token: 0x0401497F RID: 84351
		private readonly ButtonItem Button = new ButtonItem(null);
	}
}
