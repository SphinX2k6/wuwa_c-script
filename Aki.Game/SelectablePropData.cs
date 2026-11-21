using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02000E19 RID: 3609
[NullableContext(1)]
[Nullable(0)]
public class SelectablePropData : ISelectedData
{
	// Token: 0x17000FFD RID: 4093
	// (get) Token: 0x060091CC RID: 37324 RVA: 0x002B9AEC File Offset: 0x002B7CEC
	// (set) Token: 0x060091CD RID: 37325 RVA: 0x002B9AF4 File Offset: 0x002B7CF4
	public int IncId { get; set; }

	// Token: 0x17000FFE RID: 4094
	// (get) Token: 0x060091CE RID: 37326 RVA: 0x002B9AFD File Offset: 0x002B7CFD
	// (set) Token: 0x060091CF RID: 37327 RVA: 0x002B9B05 File Offset: 0x002B7D05
	public int ItemId { get; set; }

	// Token: 0x17000FFF RID: 4095
	// (get) Token: 0x060091D0 RID: 37328 RVA: 0x002B9B0E File Offset: 0x002B7D0E
	// (set) Token: 0x060091D1 RID: 37329 RVA: 0x002B9B16 File Offset: 0x002B7D16
	public int Count { get; set; } = 1;

	// Token: 0x17001000 RID: 4096
	// (get) Token: 0x060091D2 RID: 37330 RVA: 0x002B9B1F File Offset: 0x002B7D1F
	// (set) Token: 0x060091D3 RID: 37331 RVA: 0x002B9B27 File Offset: 0x002B7D27
	public int SelectedCount { get; set; }

	// Token: 0x17001001 RID: 4097
	// (get) Token: 0x060091D4 RID: 37332 RVA: 0x002B9B30 File Offset: 0x002B7D30
	// (set) Token: 0x060091D5 RID: 37333 RVA: 0x002B9B38 File Offset: 0x002B7D38
	public InventoryDefine.EItemDataType ItemDataType { get; set; }

	// Token: 0x17001002 RID: 4098
	// (get) Token: 0x060091D6 RID: 37334 RVA: 0x002B9B41 File Offset: 0x002B7D41
	// (set) Token: 0x060091D7 RID: 37335 RVA: 0x002B9B49 File Offset: 0x002B7D49
	public int RoleId { get; set; }

	// Token: 0x17001003 RID: 4099
	// (get) Token: 0x060091D8 RID: 37336 RVA: 0x002B9B52 File Offset: 0x002B7D52
	// (set) Token: 0x060091D9 RID: 37337 RVA: 0x002B9B5A File Offset: 0x002B7D5A
	public int ResonanceLevel { get; set; }

	// Token: 0x17001004 RID: 4100
	// (get) Token: 0x060091DA RID: 37338 RVA: 0x002B9B63 File Offset: 0x002B7D63
	// (set) Token: 0x060091DB RID: 37339 RVA: 0x002B9B6B File Offset: 0x002B7D6B
	public string LevelText { get; set; } = "";

	// Token: 0x17001005 RID: 4101
	// (get) Token: 0x060091DC RID: 37340 RVA: 0x002B9B74 File Offset: 0x002B7D74
	// (set) Token: 0x060091DD RID: 37341 RVA: 0x002B9B7C File Offset: 0x002B7D7C
	public string ChipPath { get; set; } = "";

	// Token: 0x17001006 RID: 4102
	// (get) Token: 0x060091DE RID: 37342 RVA: 0x002B9B85 File Offset: 0x002B7D85
	// (set) Token: 0x060091DF RID: 37343 RVA: 0x002B9B8D File Offset: 0x002B7D8D
	public bool OnlyGold { get; set; }

	// Token: 0x17001007 RID: 4103
	// (get) Token: 0x060091E0 RID: 37344 RVA: 0x002B9B96 File Offset: 0x002B7D96
	// (set) Token: 0x060091E1 RID: 37345 RVA: 0x002B9B9E File Offset: 0x002B7D9E
	public bool IsSelectFrameFollowClick { get; set; }

	// Token: 0x17001008 RID: 4104
	// (get) Token: 0x060091E2 RID: 37346 RVA: 0x002B9BA7 File Offset: 0x002B7DA7
	// (set) Token: 0x060091E3 RID: 37347 RVA: 0x002B9BAF File Offset: 0x002B7DAF
	public bool? OnlyTextFlag { get; set; }

	// Token: 0x060091E4 RID: 37348 RVA: 0x002B9BB8 File Offset: 0x002B7DB8
	public bool GetIsLock()
	{
		if (this.IncId < 0)
		{
			return false;
		}
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.IncId);
		return attributeItemData != null && attributeItemData.GetIsLock();
	}
}
