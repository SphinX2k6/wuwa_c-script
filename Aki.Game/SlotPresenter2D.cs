using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001C13 RID: 7187
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SlotPresenter2D : SlotPresenterBase<FormationRoleSlot>
{
	// Token: 0x170011B1 RID: 4529
	// (get) Token: 0x0600D786 RID: 55174 RVA: 0x0031E8A7 File Offset: 0x0031CAA7
	public List<FormationRoleSlot> RoleSlots
	{
		get
		{
			return this.Items;
		}
	}

	// Token: 0x0600D787 RID: 55175 RVA: 0x0031E8AF File Offset: 0x0031CAAF
	protected override FormationRoleSlot CreateSlotView(int position, IFormationProvider provider)
	{
		return new FormationRoleSlot(position, provider);
	}

	// Token: 0x0600D788 RID: 55176 RVA: 0x0031E8B8 File Offset: 0x0031CAB8
	protected override FormationRoleDragItem CreateDragRoleItem()
	{
		return new FormationRoleDragItem();
	}

	// Token: 0x0600D789 RID: 55177 RVA: 0x0031E8BF File Offset: 0x0031CABF
	protected override void DestroyItem(FormationRoleSlot slot)
	{
		slot.Reset();
	}
}
