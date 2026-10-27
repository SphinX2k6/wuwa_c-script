using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x0200566C RID: 22124
	public class ComposeMediumItemGridInner : MediumItemGrid
	{
		// Token: 0x0603845D RID: 230493 RVA: 0x00D56238 File Offset: 0x00D54438
		[NullableContext(1)]
		public void RefreshByBaseItemData(IBaseItemData data, bool isSelected)
		{
			int configId = data.ConfigId;
			bool flag = data.IsUnlock > 0;
			int num = 0;
			bool flag2 = true;
			switch (data.MainType)
			{
			case EComposeListType.ReagentProduction:
			{
				SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(data.ConfigId);
				num = ((synthesisFormulaById != null) ? synthesisFormulaById.GetValueOrDefault().ItemId : 0);
				flag2 = (((IReagentProductionData)data).SubType == ESubComposeDataType.ComposeMenu || ComposeController.Instance.CheckCanReagentProduction(configId));
				break;
			}
			case EComposeListType.Structure:
			{
				SynthesisFormula? synthesisFormulaById2 = ComposeConfig.Instance.GetSynthesisFormulaById(data.ConfigId);
				num = ((synthesisFormulaById2 != null) ? synthesisFormulaById2.GetValueOrDefault().ItemId : 0);
				IStructureData structureData = (IStructureData)data;
				flag2 = ComposeController.Instance.CheckCanStructure(structureData.ConfigId);
				break;
			}
			case EComposeListType.Purification:
			{
				SynthesisFormula? synthesisFormulaById3 = ComposeConfig.Instance.GetSynthesisFormulaById(data.ConfigId);
				num = ((synthesisFormulaById3 != null) ? synthesisFormulaById3.GetValueOrDefault().ItemId : 0);
				IPurificationData purificationData = (IPurificationData)data;
				flag2 = (ComposeModel.Instance.GetPurificationDataById(purificationData.ConfigId).IsUnlock != 0 && ComposeController.Instance.CheckCanPurification(purificationData.ConfigId));
				break;
			}
			case EComposeListType.Exchange:
			{
				num = data.ConfigId;
				IExchangeData exchangeData = (IExchangeData)data;
				flag2 = (ComposeModel.Instance.GetExchangeDataById(exchangeData.ConfigId).IsUnlock != 0 && ComposeController.Instance.CheckCanExchange(exchangeData.ConfigId));
				break;
			}
			case EComposeListType.Collect:
			{
				SynthesisFormula? synthesisFormulaById4 = ComposeConfig.Instance.GetSynthesisFormulaById(data.ConfigId);
				num = ((synthesisFormulaById4 != null) ? synthesisFormulaById4.GetValueOrDefault().ItemId : 0);
				ICollectData collectData = (ICollectData)data;
				flag2 = (ComposeModel.Instance.GetCollectDataById(collectData.ConfigId).IsUnlock != 0 && ComposeController.Instance.CheckCanCollect(collectData.ConfigId));
				break;
			}
			}
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(num);
			if (itemConfigData == null)
			{
				base.Apply<OnlyEmptyItemGrid>(new OnlyEmptyItemGrid
				{
					Data = data
				});
				this.SetSelected(false, false);
				return;
			}
			bool isLimitForever = data.IsLimitForever;
			bool flag3 = data.TotalMakeCountInLimitTime > 0;
			CSharpScript.Game.Module.Common.MediumItemGrid.MediumItemGridComposeTag mediumItemGridComposeTag = new CSharpScript.Game.Module.Common.MediumItemGrid.MediumItemGridComposeTag
			{
				IsLimitTimeItem = (flag3 && isLimitForever),
				IsRefreshItem = (flag3 && !isLimitForever),
				BuffItem = (EMediumItemGridBuffType)itemConfigData.ItemBuffType
			};
			PropMediumItemGrid parameters = new PropMediumItemGrid
			{
				Data = data,
				ItemConfigId = new int?(num),
				StarLevel = new int?(itemConfigData.QualityId),
				BottomTextId = itemConfigData.Name,
				IsProhibit = new bool?(!flag),
				IsNewVisible = new bool?(data.IsNew),
				IsDisable = new bool?(flag && !flag2),
				IsOmitBottomText = new bool?(true),
				ComposeIconTag = (flag ? mediumItemGridComposeTag : null)
			};
			base.Apply<PropMediumItemGrid>(parameters);
			this.SetSelected(isSelected, false);
		}
	}
}
