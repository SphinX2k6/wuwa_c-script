using System;
using System.Collections.Generic;
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
	// Token: 0x020037F0 RID: 14320
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class VillageInfrMissionListItem : GridProxyAbstract<IVillageInfrBuildQuestParam>
	{
		// Token: 0x060253EB RID: 152555 RVA: 0x00A80FE8 File Offset: 0x00A7F1E8
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

		// Token: 0x060253EC RID: 152556 RVA: 0x00A81068 File Offset: 0x00A7F268
		protected override void OnStart()
		{
			this.Item.Initialize(base.GetItem(0).GetOwner());
			this.Item.BindOnCanExecuteChange((object _, bool __, EToggleState ___) => false);
			this.Item.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback callbackParameter)
			{
				TItem? titem = callbackParameter.Data as TItem?;
				ItemController.Instance.OpenItemTipsByItemId(titem.Value.ItemData.ItemId, true, null, false);
			});
		}

		// Token: 0x060253ED RID: 152557 RVA: 0x00A810E0 File Offset: 0x00A7F2E0
		public override void Refresh(IVillageInfrBuildQuestParam data, bool isSelected, int gridIndex)
		{
			this.Id = data.Id;
			this.Index = gridIndex;
			this.SelectId = data.SelectId;
			this.RefreshName();
			this.RefreshReward();
			this.RefreshBtn();
		}

		// Token: 0x060253EE RID: 152558 RVA: 0x00A81114 File Offset: 0x00A7F314
		private void RefreshName()
		{
			AccessPath? accessPathConfig = SkipInterfaceConfig.Instance.GetAccessPathConfig(this.Id);
			base.GetText(1).ShowTextNew(accessPathConfig.Value.Description);
		}

		// Token: 0x060253EF RID: 152559 RVA: 0x00A81150 File Offset: 0x00A7F350
		private void RefreshReward()
		{
			InfrV2TreeBuild? infrTreeBuild = VillageInfrConfig.Instance.GetInfrTreeBuild(this.SelectId);
			int num = 0;
			using (Dictionary<int, int>.KeyCollection.Enumerator enumerator = infrTreeBuild.Value.Requirement().Keys.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					num = enumerator.Current;
				}
			}
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

		// Token: 0x060253F0 RID: 152560 RVA: 0x00A81254 File Offset: 0x00A7F454
		private void RefreshBtn()
		{
			int item = VillageInfrConfig.Instance.GetInfrTreeBuild(this.SelectId).Value.FinishCondition(this.Index);
			bool flag = VillageInfrModel.Instance.GetTreeFinishConditions().Contains(item);
			base.GetButton(2).RootUIComp.Get().SetUIActive(!flag);
		}

		// Token: 0x060253F1 RID: 152561 RVA: 0x00A812B8 File Offset: 0x00A7F4B8
		private void OnClickFunction()
		{
			SkipTaskManager.RunByConfigId(VillageInfrConfig.Instance.GetInfrTreeBuild(this.SelectId).Value.GetQuestAccessPathArray()[this.Index], null);
			EventSystem.Instance.Emit(EEventName.VillageInfrMissionItemClick);
		}

		// Token: 0x040149B4 RID: 84404
		private int Id;

		// Token: 0x040149B5 RID: 84405
		private int Index;

		// Token: 0x040149B6 RID: 84406
		private int SelectId;

		// Token: 0x040149B7 RID: 84407
		private readonly SmallItemGrid Item = new SmallItemGrid();
	}
}
