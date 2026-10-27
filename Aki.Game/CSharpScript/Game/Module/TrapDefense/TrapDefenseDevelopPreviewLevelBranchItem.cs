using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A9F RID: 19103
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseDevelopPreviewLevelBranchItem : GridProxyAbstract<ITrapDefenseDevelopPreviewLevelInfo>
	{
		// Token: 0x06031830 RID: 202800 RVA: 0x00B7A748 File Offset: 0x00B78948
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031831 RID: 202801 RVA: 0x00B7A7F4 File Offset: 0x00B789F4
		public override void Refresh(ITrapDefenseDevelopPreviewLevelInfo data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			int id = data.Id;
			ITrapDefenseMachineIdInfo trapDefenseMachineIdInfo = TrapDefenseModel.Instance.DecomposeMachineId(id);
			bool flag;
			int branchCount;
			if (trapDefenseMachineIdInfo.MachineType == ETrapDefenseMachineType.Building)
			{
				TrapDefenseBuilding? buildingById = TrapDefenseConfig.Instance.GetBuildingById(this.Data.Id);
				TrapDefenseBuildingType? buildingTypeById = TrapDefenseConfig.Instance.GetBuildingTypeById(buildingById.Value.BuildingType);
				int maxLevel = buildingTypeById.Value.MaxLevel;
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), buildingById.Value.DescDetail, buildingById.Value.DescDetailArgs());
				flag = (trapDefenseMachineIdInfo.Level == maxLevel);
				branchCount = buildingTypeById.Value.BranchCount;
			}
			else
			{
				TrapDefenseAuxiliary? auxiliaryById = TrapDefenseConfig.Instance.GetAuxiliaryById(this.Data.Id);
				TrapDefenseAuxiliaryType? auxiliaryTypeById = TrapDefenseConfig.Instance.GetAuxiliaryTypeById(auxiliaryById.Value.AuxiliaryType);
				int maxLevel2 = auxiliaryTypeById.Value.MaxLevel;
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), auxiliaryById.Value.DescDetail, auxiliaryById.Value.DescDetailArgs());
				flag = (trapDefenseMachineIdInfo.Level == maxLevel2);
				branchCount = auxiliaryTypeById.Value.BranchCount;
			}
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(flag && branchCount > 1);
			}
			if (flag && branchCount > 1)
			{
				string branchName = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetBranchName(trapDefenseMachineIdInfo.Branch);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), branchName, Array.Empty<object>());
				UUIItem item2 = base.GetItem(3);
				if (item2 != null)
				{
					item2.SetUIActive(data.IsCurLevel);
				}
			}
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAlpha(data.NeedAlpha.GetValueOrDefault() ? 0.5f : 1f);
		}

		// Token: 0x0401A775 RID: 108405
		protected ITrapDefenseDevelopPreviewLevelInfo Data;

		// Token: 0x0200ABF7 RID: 44023
		[NullableContext(0)]
		private class EBranch
		{
			// Token: 0x04034416 RID: 214038
			public const int PanelTitleLayout = 0;

			// Token: 0x04034417 RID: 214039
			public const int TxtBranch = 1;

			// Token: 0x04034418 RID: 214040
			public const int TxtDesc = 2;

			// Token: 0x04034419 RID: 214041
			public const int Arrow = 3;
		}
	}
}
