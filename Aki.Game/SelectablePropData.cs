using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x0200195C RID: 6492
[NullableContext(1)]
[Nullable(0)]
public class SelectablePropData : ISelectedData
{
	// Token: 0x17000FD9 RID: 4057
	// (get) Token: 0x0600BDC9 RID: 48585 RVA: 0x002AECA8 File Offset: 0x002ACEA8
	// (set) Token: 0x0600BDCA RID: 48586 RVA: 0x002AECB0 File Offset: 0x002ACEB0
	public int IncId { get; set; }

	// Token: 0x17000FDA RID: 4058
	// (get) Token: 0x0600BDCB RID: 48587 RVA: 0x002AECB9 File Offset: 0x002ACEB9
	// (set) Token: 0x0600BDCC RID: 48588 RVA: 0x002AECC1 File Offset: 0x002ACEC1
	public int ItemId { get; set; }

	// Token: 0x17000FDB RID: 4059
	// (get) Token: 0x0600BDCD RID: 48589 RVA: 0x002AECCA File Offset: 0x002ACECA
	// (set) Token: 0x0600BDCE RID: 48590 RVA: 0x002AECD2 File Offset: 0x002ACED2
	public int Count { get; set; } = 1;

	// Token: 0x17000FDC RID: 4060
	// (get) Token: 0x0600BDCF RID: 48591 RVA: 0x002AECDB File Offset: 0x002ACEDB
	// (set) Token: 0x0600BDD0 RID: 48592 RVA: 0x002AECE3 File Offset: 0x002ACEE3
	public int SelectedCount { get; set; }

	// Token: 0x17000FDD RID: 4061
	// (get) Token: 0x0600BDD1 RID: 48593 RVA: 0x002AECEC File Offset: 0x002ACEEC
	// (set) Token: 0x0600BDD2 RID: 48594 RVA: 0x002AECF4 File Offset: 0x002ACEF4
	public InventoryDefine.EItemDataType ItemDataType { get; set; }

	// Token: 0x17000FDE RID: 4062
	// (get) Token: 0x0600BDD3 RID: 48595 RVA: 0x002AECFD File Offset: 0x002ACEFD
	// (set) Token: 0x0600BDD4 RID: 48596 RVA: 0x002AED05 File Offset: 0x002ACF05
	public int RoleId { get; set; }

	// Token: 0x17000FDF RID: 4063
	// (get) Token: 0x0600BDD5 RID: 48597 RVA: 0x002AED0E File Offset: 0x002ACF0E
	// (set) Token: 0x0600BDD6 RID: 48598 RVA: 0x002AED16 File Offset: 0x002ACF16
	public int ResonanceLevel { get; set; }

	// Token: 0x17000FE0 RID: 4064
	// (get) Token: 0x0600BDD7 RID: 48599 RVA: 0x002AED1F File Offset: 0x002ACF1F
	// (set) Token: 0x0600BDD8 RID: 48600 RVA: 0x002AED27 File Offset: 0x002ACF27
	public string LevelText { get; set; } = "";

	// Token: 0x17000FE1 RID: 4065
	// (get) Token: 0x0600BDD9 RID: 48601 RVA: 0x002AED30 File Offset: 0x002ACF30
	// (set) Token: 0x0600BDDA RID: 48602 RVA: 0x002AED38 File Offset: 0x002ACF38
	public string ChipPath { get; set; } = "";

	// Token: 0x17000FE2 RID: 4066
	// (get) Token: 0x0600BDDB RID: 48603 RVA: 0x002AED41 File Offset: 0x002ACF41
	// (set) Token: 0x0600BDDC RID: 48604 RVA: 0x002AED49 File Offset: 0x002ACF49
	public bool OnlyGold { get; set; }

	// Token: 0x17000FE3 RID: 4067
	// (get) Token: 0x0600BDDD RID: 48605 RVA: 0x002AED52 File Offset: 0x002ACF52
	// (set) Token: 0x0600BDDE RID: 48606 RVA: 0x002AED5A File Offset: 0x002ACF5A
	public bool IsSelectFrameFollowClick { get; set; }

	// Token: 0x17000FE4 RID: 4068
	// (get) Token: 0x0600BDDF RID: 48607 RVA: 0x002AED63 File Offset: 0x002ACF63
	// (set) Token: 0x0600BDE0 RID: 48608 RVA: 0x002AED6B File Offset: 0x002ACF6B
	public bool? OnlyTextFlag { get; set; }

	// Token: 0x0600BDE1 RID: 48609 RVA: 0x002AED74 File Offset: 0x002ACF74
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
