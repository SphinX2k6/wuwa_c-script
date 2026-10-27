using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001745 RID: 5957
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CalabashLevelUpRewardItemGrid : LoopScrollSmallItemGrid<CalabashRewardItemData>
{
	// Token: 0x0600AC63 RID: 44131 RVA: 0x0026A8D8 File Offset: 0x00268AD8
	protected override void OnRefresh(CalabashRewardItemData data, bool isSelected, int gridIndex)
	{
		this.ConfigId = data.ItemData.Value.ItemData.ItemId;
		int count = data.ItemData.Value.Count;
		this.RefreshByConfigId(this.ConfigId, new int?(count), data);
	}

	// Token: 0x0600AC64 RID: 44132 RVA: 0x0026A924 File Offset: 0x00268B24
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

	// Token: 0x0600AC65 RID: 44133 RVA: 0x0026AA5C File Offset: 0x00268C5C
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x0600AC66 RID: 44134 RVA: 0x0026AA5F File Offset: 0x00268C5F
	protected override void OnExtendToggleClicked()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null);
	}

	// Token: 0x04004E34 RID: 20020
	private int ConfigId;
}
