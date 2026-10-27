using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02004879 RID: 18553
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class VillageInfrMissionListItem : GridProxyAbstract<IVillageInfrBuildQuestParam>
	{
		// Token: 0x060308BF RID: 198847 RVA: 0x00B4624C File Offset: 0x00B4444C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnClickFunction))
			};
		}

		// Token: 0x060308C0 RID: 198848 RVA: 0x00B462CC File Offset: 0x00B444CC
		protected override void OnStart()
		{
			this.Item.Initialize(base.GetItem(0).GetOwner());
			this.Item.BindOnCanExecuteChange((object _, bool __, EToggleState ___) => false);
			this.Item.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback callbackParameter)
			{
				TItem? titem = callbackParameter.Data as TItem?;
				ItemController.Instance.OpenItemTipsByItemId(titem.Value.ItemData.ItemId, true, null);
			});
		}

		// Token: 0x060308C1 RID: 198849 RVA: 0x00B46344 File Offset: 0x00B44544
		public override void Refresh(IVillageInfrBuildQuestParam data, bool isSelected, int gridIndex)
		{
			this.Id = data.Id;
			this.Index = gridIndex;
			this.SelectId = data.SelectId;
			this.RefreshName();
			this.RefreshReward();
			this.RefreshBtn();
		}

		// Token: 0x060308C2 RID: 198850 RVA: 0x00B46378 File Offset: 0x00B44578
		private void RefreshName()
		{
			AccessPath? accessPathConfig = SkipInterfaceConfig.Instance.GetAccessPathConfig(this.Id);
			base.GetText(1).ShowTextNew(accessPathConfig.Value.Description);
		}

		// Token: 0x060308C3 RID: 198851 RVA: 0x00B463B4 File Offset: 0x00B445B4
		private void RefreshReward()
		{
			InfrV2TreeBuild? infrTreeBuild = VillageInfrConfig.Instance.GetInfrTreeBuild(this.SelectId);
			int num = infrTreeBuild.Value.Requirement().Keys.First<int>();
			int item = infrTreeBuild.Value.FinishCondition(this.Index);
			int count = infrTreeBuild.Value.ItemNum(this.Index);
			TItem titem = new TItem(new InventoryDefine.GetItemData(num, 0), count);
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = titem,
				ItemConfigId = new int?(num),
				BottomText = count.ToString(),
				IsReceivedVisible = new bool?(VillageInfrModel.Instance.GetTreeFinishConditions().Contains(item))
			};
			this.Item.Apply<PropSmallItemGrid>(parameters);
		}

		// Token: 0x060308C4 RID: 198852 RVA: 0x00B46480 File Offset: 0x00B44680
		private void RefreshBtn()
		{
			int item = VillageInfrConfig.Instance.GetInfrTreeBuild(this.SelectId).Value.FinishCondition(this.Index);
			bool flag = VillageInfrModel.Instance.GetTreeFinishConditions().Contains(item);
			base.GetButton(2).RootUIComp.Get().SetUIActive(!flag);
		}

		// Token: 0x060308C5 RID: 198853 RVA: 0x00B464E4 File Offset: 0x00B446E4
		private void OnClickFunction()
		{
			SkipTaskManager.RunByConfigId(VillageInfrConfig.Instance.GetInfrTreeBuild(this.SelectId).Value.GetQuestAccessPathArray()[this.Index], null);
			EventSystem.Instance.Emit(EEventName.VillageInfrMissionItemClick);
		}

		// Token: 0x0401A141 RID: 106817
		private int Id;

		// Token: 0x0401A142 RID: 106818
		private int Index;

		// Token: 0x0401A143 RID: 106819
		private int SelectId;

		// Token: 0x0401A144 RID: 106820
		private readonly SmallItemGrid Item = new SmallItemGrid();
	}
}
