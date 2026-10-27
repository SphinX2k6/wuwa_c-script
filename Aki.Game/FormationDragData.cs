using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02001BC3 RID: 7107
[NullableContext(1)]
[Nullable(0)]
public class FormationDragData
{
	// Token: 0x1700116D RID: 4461
	// (get) Token: 0x0600D3F7 RID: 54263 RVA: 0x0030C5EC File Offset: 0x0030A7EC
	// (set) Token: 0x0600D3F8 RID: 54264 RVA: 0x0030C5F4 File Offset: 0x0030A7F4
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

	// Token: 0x0600D3F9 RID: 54265 RVA: 0x0030C600 File Offset: 0x0030A800
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

	// Token: 0x040060E2 RID: 24802
	public List<IDraggableSlot> DraggableSlots = new List<IDraggableSlot>();

	// Token: 0x040060E3 RID: 24803
	[Nullable(2)]
	public FormationRoleDragItem DragRoleItem;

	// Token: 0x040060E4 RID: 24804
	[Nullable(2)]
	public Func<UniTask> PrepareDragVisuals;

	// Token: 0x040060E5 RID: 24805
	public HashSet<int> CustomShieldHotKeyComponentSet = new HashSet<int>();

	// Token: 0x040060E6 RID: 24806
	[Nullable(2)]
	public Action<int, int, int, int> ExchangeRoleCallBack;

	// Token: 0x040060E7 RID: 24807
	public int DragItemPosition;

	// Token: 0x040060E8 RID: 24808
	public Vector2D CurDragPos = Vector2D.Create();

	// Token: 0x040060E9 RID: 24809
	public Vector2D LastDragPos = Vector2D.Create();

	// Token: 0x040060EA RID: 24810
	public Vector2D TempAnchorOffset = Vector2D.Create();

	// Token: 0x040060EB RID: 24811
	public Vector TempPointerPosition = Vector.Create();
}
