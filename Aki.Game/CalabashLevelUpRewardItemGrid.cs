using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02000BFE RID: 3070
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CalabashLevelUpRewardItemGrid : LoopScrollSmallItemGrid<CalabashRewardItemData>
{
	// Token: 0x0600804A RID: 32842 RVA: 0x00274D20 File Offset: 0x00272F20
	protected override void OnRefresh(CalabashRewardItemData data, bool isSelected, int gridIndex)
	{
		this.ConfigId = data.ItemData.Value.ItemData.ItemId;
		int count = data.ItemData.Value.Count;
		this.RefreshByConfigId(this.ConfigId, new int?(count), data);
	}

	// Token: 0x0600804B RID: 32843 RVA: 0x00274D6C File Offset: 0x00272F6C
	[NullableContext(2)]
	private void RefreshByConfigId(int itemConfigId, int? count = null, CalabashRewardItemData data = null)
	{
		this.ConfigId = itemConfigId;
		if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(this.ConfigId)) == InventoryDefine.EItemDataType.RoleItem)
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.ConfigId);
			CharacterSmallItemGrid characterSmallItemGrid = new CharacterSmallItemGrid();
			characterSmallItemGrid.Data = data;
			characterSmallItemGrid.ItemConfigId = new int?(this.ConfigId);
			string bottomText;
			if (count.GetValueOrDefault() <= 0)
			{
				bottomText = "";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int?>(count);
				bottomText = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			characterSmallItemGrid.BottomText = bottomText;
			characterSmallItemGrid.QualityId = new int?(roleConfig.Value.QualityId);
			characterSmallItemGrid.IsReceivedVisible = new bool?(data != null && data.ReceiveState == ECalabashRewardState.HasReceived);
			CharacterSmallItemGrid parameters = characterSmallItemGrid;
			base.Apply<CharacterSmallItemGrid>(parameters);
			return;
		}
		PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid();
		propSmallItemGrid.Data = data;
		propSmallItemGrid.ItemConfigId = new int?(this.ConfigId);
		string bottomText2;
		if (count.GetValueOrDefault() <= 0)
		{
			bottomText2 = "";
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int?>(count);
			bottomText2 = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		propSmallItemGrid.BottomText = bottomText2;
		propSmallItemGrid.IsReceivedVisible = new bool?(data != null && data.ReceiveState == ECalabashRewardState.HasReceived);
		PropSmallItemGrid parameters2 = propSmallItemGrid;
		base.Apply<PropSmallItemGrid>(parameters2);
	}

	// Token: 0x0600804C RID: 32844 RVA: 0x00274EA4 File Offset: 0x002730A4
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x0600804D RID: 32845 RVA: 0x00274EA7 File Offset: 0x002730A7
	protected override void OnExtendToggleClicked()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null, false);
	}

	// Token: 0x04004EDD RID: 20189
	private int ConfigId;
}
