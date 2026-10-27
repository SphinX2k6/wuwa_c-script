using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020018B9 RID: 6329
[NullableContext(2)]
[Nullable(0)]
public class CommonItemSmallItemGrid : LoopScrollSmallItemGrid<TItem>
{
	// Token: 0x0600B97E RID: 47486 RVA: 0x002A1177 File Offset: 0x0029F377
	protected override void OnRefresh(TItem data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x0600B97F RID: 47487 RVA: 0x002A1180 File Offset: 0x0029F380
	public void Refresh(TItem data)
	{
		InventoryDefine.IGetItemData itemData = data.ItemData;
		int count = data.Count;
		this.ConfigId = itemData.ItemId;
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(this.ConfigId));
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleItem)
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.ConfigId);
			CharacterSmallItemGrid characterSmallItemGrid = new CharacterSmallItemGrid();
			characterSmallItemGrid.Data = data;
			characterSmallItemGrid.ElementId = new int?(roleConfig.Value.ElementId);
			characterSmallItemGrid.ItemConfigId = new int?(this.ConfigId);
			string bottomText;
			if (count <= 0)
			{
				bottomText = "";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(count);
				bottomText = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			characterSmallItemGrid.BottomText = bottomText;
			characterSmallItemGrid.QualityId = new int?(roleConfig.Value.QualityId);
			Func<TItem, bool> showReceivedCallBack = this.ShowReceivedCallBack;
			characterSmallItemGrid.IsReceivedVisible = ((showReceivedCallBack != null) ? new bool?(showReceivedCallBack(data)) : null);
			Func<TItem, bool> showReceivableCallBack = this.ShowReceivableCallBack;
			characterSmallItemGrid.IsReceivableVisible = ((showReceivableCallBack != null) ? new bool?(showReceivableCallBack(data)) : null);
			CharacterSmallItemGrid parameters = characterSmallItemGrid;
			base.Apply<CharacterSmallItemGrid>(parameters);
			return;
		}
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.PhantomItem)
		{
			PhantomSmallItemGrid phantomSmallItemGrid = new PhantomSmallItemGrid();
			phantomSmallItemGrid.Data = data;
			phantomSmallItemGrid.ItemConfigId = new int?(this.ConfigId);
			string bottomText2;
			if (count <= 1)
			{
				if (count <= 0)
				{
					bottomText2 = "";
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(count);
					bottomText2 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("x");
				defaultInterpolatedStringHandler.AppendFormatted<int>(count);
				bottomText2 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			phantomSmallItemGrid.BottomText = bottomText2;
			Func<TItem, bool> showReceivedCallBack2 = this.ShowReceivedCallBack;
			phantomSmallItemGrid.IsReceivedVisible = ((showReceivedCallBack2 != null) ? new bool?(showReceivedCallBack2(data)) : null);
			Func<TItem, bool> showReceivableCallBack2 = this.ShowReceivableCallBack;
			phantomSmallItemGrid.IsReceivableVisible = ((showReceivableCallBack2 != null) ? new bool?(showReceivableCallBack2(data)) : null);
			PhantomSmallItemGrid parameters2 = phantomSmallItemGrid;
			base.Apply<PhantomSmallItemGrid>(parameters2);
			return;
		}
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.OrnamentItem)
		{
			CharacterOrnamentSmallItemGrid characterOrnamentSmallItemGrid = new CharacterOrnamentSmallItemGrid();
			characterOrnamentSmallItemGrid.Data = data;
			characterOrnamentSmallItemGrid.ItemConfigId = new int?(this.ConfigId);
			string bottomText3;
			if (count <= 0)
			{
				bottomText3 = "";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(count);
				bottomText3 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			characterOrnamentSmallItemGrid.BottomText = bottomText3;
			Func<TItem, bool> showReceivedCallBack3 = this.ShowReceivedCallBack;
			characterOrnamentSmallItemGrid.IsReceivedVisible = ((showReceivedCallBack3 != null) ? new bool?(showReceivedCallBack3(data)) : null);
			Func<TItem, bool> showReceivableCallBack3 = this.ShowReceivableCallBack;
			characterOrnamentSmallItemGrid.IsReceivableVisible = ((showReceivableCallBack3 != null) ? new bool?(showReceivableCallBack3(data)) : null);
			CharacterOrnamentSmallItemGrid parameters3 = characterOrnamentSmallItemGrid;
			base.Apply<CharacterOrnamentSmallItemGrid>(parameters3);
			return;
		}
		PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid();
		propSmallItemGrid.Data = data;
		propSmallItemGrid.ItemConfigId = new int?(this.ConfigId);
		string bottomText4;
		if (count <= 0)
		{
			bottomText4 = "";
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(count);
			bottomText4 = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		propSmallItemGrid.BottomText = bottomText4;
		Func<TItem, bool> showReceivedCallBack4 = this.ShowReceivedCallBack;
		propSmallItemGrid.IsReceivedVisible = ((showReceivedCallBack4 != null) ? new bool?(showReceivedCallBack4(data)) : null);
		Func<TItem, bool> showReceivableCallBack4 = this.ShowReceivableCallBack;
		propSmallItemGrid.IsReceivableVisible = ((showReceivableCallBack4 != null) ? new bool?(showReceivableCallBack4(data)) : null);
		PropSmallItemGrid parameters4 = propSmallItemGrid;
		base.Apply<PropSmallItemGrid>(parameters4);
	}

	// Token: 0x0600B980 RID: 47488 RVA: 0x002A14D4 File Offset: 0x0029F6D4
	public void RefreshByConfigId(int itemConfigId, int? count = null, object data = null, bool showReceived = false, bool isDoubleRewardVisible = false)
	{
		this.ConfigId = itemConfigId;
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(this.ConfigId));
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleItem)
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.ConfigId);
			CharacterSmallItemGrid characterSmallItemGrid = new CharacterSmallItemGrid();
			characterSmallItemGrid.Data = data;
			characterSmallItemGrid.ItemConfigId = new int?(this.ConfigId);
			string bottomText;
			if (count != null)
			{
				int? num = count;
				int num2 = 0;
				if (num.GetValueOrDefault() > num2 & num != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int?>(count);
					bottomText = defaultInterpolatedStringHandler.ToStringAndClear();
					goto IL_95;
				}
			}
			bottomText = "";
			IL_95:
			characterSmallItemGrid.BottomText = bottomText;
			characterSmallItemGrid.QualityId = new int?(roleConfig.Value.QualityId);
			characterSmallItemGrid.IsReceivedVisible = new bool?(showReceived);
			CharacterSmallItemGrid parameters = characterSmallItemGrid;
			base.Apply<CharacterSmallItemGrid>(parameters);
			return;
		}
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.PhantomItem)
		{
			PhantomSmallItemGrid phantomSmallItemGrid = new PhantomSmallItemGrid();
			phantomSmallItemGrid.Data = data;
			string bottomText2;
			if (count != null)
			{
				int? num = count;
				int num2 = 0;
				if (num.GetValueOrDefault() > num2 & num != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int?>(count);
					bottomText2 = defaultInterpolatedStringHandler.ToStringAndClear();
					goto IL_11E;
				}
			}
			bottomText2 = "";
			IL_11E:
			phantomSmallItemGrid.BottomText = bottomText2;
			phantomSmallItemGrid.ItemConfigId = new int?(this.ConfigId);
			phantomSmallItemGrid.IsReceivedVisible = new bool?(showReceived);
			PhantomSmallItemGrid parameters2 = phantomSmallItemGrid;
			base.Apply<PhantomSmallItemGrid>(parameters2);
			return;
		}
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.OrnamentItem)
		{
			CharacterOrnamentSmallItemGrid characterOrnamentSmallItemGrid = new CharacterOrnamentSmallItemGrid();
			characterOrnamentSmallItemGrid.Data = data;
			characterOrnamentSmallItemGrid.ItemConfigId = new int?(this.ConfigId);
			string bottomText3;
			if (count != null)
			{
				int? num = count;
				int num2 = 0;
				if (num.GetValueOrDefault() > num2 & num != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int?>(count);
					bottomText3 = defaultInterpolatedStringHandler.ToStringAndClear();
					goto IL_1B1;
				}
			}
			bottomText3 = "";
			IL_1B1:
			characterOrnamentSmallItemGrid.BottomText = bottomText3;
			characterOrnamentSmallItemGrid.IsReceivedVisible = new bool?(showReceived);
			CharacterOrnamentSmallItemGrid parameters3 = characterOrnamentSmallItemGrid;
			base.Apply<CharacterOrnamentSmallItemGrid>(parameters3);
			return;
		}
		PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid();
		propSmallItemGrid.Data = data;
		propSmallItemGrid.ItemConfigId = new int?(this.ConfigId);
		string bottomText4;
		if (count != null)
		{
			int? num = count;
			int num2 = 0;
			if (num.GetValueOrDefault() > num2 & num != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int?>(count);
				bottomText4 = defaultInterpolatedStringHandler.ToStringAndClear();
				goto IL_22E;
			}
		}
		bottomText4 = "";
		IL_22E:
		propSmallItemGrid.BottomText = bottomText4;
		propSmallItemGrid.IsReceivedVisible = new bool?(showReceived);
		propSmallItemGrid.IsDoubleRewardVisible = new bool?(isDoubleRewardVisible);
		PropSmallItemGrid parameters4 = propSmallItemGrid;
		base.Apply<PropSmallItemGrid>(parameters4);
	}

	// Token: 0x0600B981 RID: 47489 RVA: 0x002A1738 File Offset: 0x0029F938
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x0600B982 RID: 47490 RVA: 0x002A173B File Offset: 0x0029F93B
	public void SetAllowClickBack(bool isAllow)
	{
		this.AllowClickBack = isAllow;
	}

	// Token: 0x0600B983 RID: 47491 RVA: 0x002A1744 File Offset: 0x0029F944
	protected override void OnExtendToggleClicked()
	{
		if (!this.AllowClickBack)
		{
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null);
	}

	// Token: 0x04005427 RID: 21543
	protected int ConfigId;

	// Token: 0x04005428 RID: 21544
	private bool AllowClickBack = true;

	// Token: 0x04005429 RID: 21545
	public Func<TItem, bool> ShowReceivedCallBack;

	// Token: 0x0400542A RID: 21546
	public Func<TItem, bool> ShowReceivableCallBack;
}
