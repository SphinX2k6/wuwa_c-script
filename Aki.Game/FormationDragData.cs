using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02001082 RID: 4226
[NullableContext(1)]
[Nullable(0)]
public class FormationDragData
{
	// Token: 0x17001192 RID: 4498
	// (get) Token: 0x0600A809 RID: 43017 RVA: 0x00317760 File Offset: 0x00315960
	// (set) Token: 0x0600A80A RID: 43018 RVA: 0x00317768 File Offset: 0x00315968
	public List<IDraggableSlot> FormationRoleViewList
	{
		get
		{
			return this.DraggableSlots;
		}
		set
		{
			this.DraggableSlots = value;
		}
	}

	// Token: 0x0600A80B RID: 43019 RVA: 0x00317774 File Offset: 0x00315974
	public void ClearData()
	{
		this.DragRoleItem = null;
		this.PrepareDragVisuals = null;
		foreach (IDraggableSlot draggableSlot in this.DraggableSlots)
		{
			draggableSlot.Reset();
		}
		this.DraggableSlots = new List<IDraggableSlot>();
		this.CustomShieldHotKeyComponentSet.Clear();
	}

	// Token: 0x040061B1 RID: 25009
	public List<IDraggableSlot> DraggableSlots = new List<IDraggableSlot>();

	// Token: 0x040061B2 RID: 25010
	[Nullable(2)]
	public FormationRoleDragItem DragRoleItem;

	// Token: 0x040061B3 RID: 25011
	[Nullable(2)]
	public Func<UniTask> PrepareDragVisuals;

	// Token: 0x040061B4 RID: 25012
	public HashSet<int> CustomShieldHotKeyComponentSet = new HashSet<int>();

	// Token: 0x040061B5 RID: 25013
	[Nullable(2)]
	public Action<int, int, int, int> ExchangeRoleCallBack;

	// Token: 0x040061B6 RID: 25014
	public int DragItemPosition;

	// Token: 0x040061B7 RID: 25015
	public Vector2D CurDragPos = Vector2D.Create();

	// Token: 0x040061B8 RID: 25016
	public Vector2D LastDragPos = Vector2D.Create();

	// Token: 0x040061B9 RID: 25017
	public Vector2D TempAnchorOffset = Vector2D.Create();

	// Token: 0x040061BA RID: 25018
	public Vector TempPointerPosition = Vector.Create();
}
