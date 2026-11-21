using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020010D2 RID: 4306
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SlotPresenter2D : SlotPresenterBase<FormationRoleSlot>
{
	// Token: 0x170011D7 RID: 4567
	// (get) Token: 0x0600AB9A RID: 43930 RVA: 0x00329BF7 File Offset: 0x00327DF7
	public List<FormationRoleSlot> RoleSlots
	{
		get
		{
			return this.Items;
		}
	}

	// Token: 0x0600AB9B RID: 43931 RVA: 0x00329BFF File Offset: 0x00327DFF
	protected override FormationRoleSlot CreateSlotView(int position, IFormationProvider provider)
	{
		return new FormationRoleSlot(position, provider);
	}

	// Token: 0x0600AB9C RID: 43932 RVA: 0x00329C08 File Offset: 0x00327E08
	protected override FormationRoleDragItem CreateDragRoleItem()
	{
		return new FormationRoleDragItem();
	}

	// Token: 0x0600AB9D RID: 43933 RVA: 0x00329C0F File Offset: 0x00327E0F
	protected override void DestroyItem(FormationRoleSlot slot)
	{
		slot.Reset();
	}
}
