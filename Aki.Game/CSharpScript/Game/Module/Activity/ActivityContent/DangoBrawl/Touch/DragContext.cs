using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x0200685A RID: 26714
	[NullableContext(2)]
	[Nullable(0)]
	public class DragContext
	{
		// Token: 0x06042B3D RID: 273213 RVA: 0x010395BC File Offset: 0x010377BC
		public void Start()
		{
		}

		// Token: 0x06042B3E RID: 273214 RVA: 0x010395BE File Offset: 0x010377BE
		public void Stop()
		{
			this.DragLayer = null;
			this.Selection = null;
			this.HoveredItem = null;
		}

		// Token: 0x06042B3F RID: 273215 RVA: 0x010395D5 File Offset: 0x010377D5
		public DangoBrawlSelection GetHoveredItem()
		{
			return this.HoveredItem;
		}

		// Token: 0x06042B40 RID: 273216 RVA: 0x010395DD File Offset: 0x010377DD
		public bool IsHovered(EDragSourceKind source, int uid)
		{
			DangoBrawlSelection hoveredItem = this.HoveredItem;
			if (hoveredItem != null && hoveredItem.Source == source)
			{
				DangoBrawlSelection hoveredItem2 = this.HoveredItem;
				return hoveredItem2 != null && hoveredItem2.Id == uid;
			}
			return false;
		}

		// Token: 0x06042B41 RID: 273217 RVA: 0x0103960C File Offset: 0x0103780C
		public void SetHoveredItem(EDragSourceKind source, int uid)
		{
			if (this.IsHovered(source, uid))
			{
				return;
			}
			this.HoveredItem = new DangoBrawlSelection
			{
				Source = source,
				Id = uid
			};
			EventSystem.Instance.Emit<int, EDragSourceKind>(EEventName.OnDangoBrawlItemHoveredChange, uid, source);
		}

		// Token: 0x06042B42 RID: 273218 RVA: 0x01039644 File Offset: 0x01037844
		public void ClearHoveredItem()
		{
			if (this.HoveredItem == null)
			{
				return;
			}
			EDragSourceKind source = this.HoveredItem.Source;
			this.HoveredItem = null;
			EventSystem.Instance.Emit<int, EDragSourceKind>(EEventName.OnDangoBrawlItemHoveredChange, 0, source);
		}

		// Token: 0x06042B43 RID: 273219 RVA: 0x0103967F File Offset: 0x0103787F
		public void ClearHoveredItemIfMatch(EDragSourceKind source, int uid)
		{
			if (!this.IsHovered(source, uid))
			{
				return;
			}
			this.HoveredItem = null;
			EventSystem.Instance.Emit<int, EDragSourceKind>(EEventName.OnDangoBrawlItemHoveredChange, 0, source);
		}

		// Token: 0x06042B44 RID: 273220 RVA: 0x010396A5 File Offset: 0x010378A5
		public DangoBrawlSelection GetSelection()
		{
			return this.Selection;
		}

		// Token: 0x06042B45 RID: 273221 RVA: 0x010396AD File Offset: 0x010378AD
		public bool IsSelected(EDragSourceKind source, int id)
		{
			DangoBrawlSelection selection = this.Selection;
			if (selection != null && selection.Source == source)
			{
				DangoBrawlSelection selection2 = this.Selection;
				return selection2 != null && selection2.Id == id;
			}
			return false;
		}

		// Token: 0x06042B46 RID: 273222 RVA: 0x010396DC File Offset: 0x010378DC
		public void ToggleSelection(EDragSourceKind source, int id)
		{
			if (id < 0)
			{
				return;
			}
			if (this.IsSelected(source, id))
			{
				this.ClearSelection();
				return;
			}
			this.Selection = new DangoBrawlSelection
			{
				Source = source,
				Id = id
			};
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlSelectionChanged);
		}

		// Token: 0x06042B47 RID: 273223 RVA: 0x01039728 File Offset: 0x01037928
		public void SetSelection(EDragSourceKind source, int id)
		{
			if (id < 0)
			{
				return;
			}
			if (this.IsSelected(source, id))
			{
				return;
			}
			this.Selection = new DangoBrawlSelection
			{
				Source = source,
				Id = id
			};
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlSelectionChanged);
		}

		// Token: 0x06042B48 RID: 273224 RVA: 0x01039763 File Offset: 0x01037963
		public void ClearSelectionIfMatch(EDragSourceKind source, int id)
		{
			if (!this.IsSelected(source, id))
			{
				return;
			}
			this.Selection = null;
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlSelectionChanged);
		}

		// Token: 0x06042B49 RID: 273225 RVA: 0x01039787 File Offset: 0x01037987
		public void ClearSelection()
		{
			if (this.Selection == null)
			{
				return;
			}
			this.Selection = null;
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlSelectionChanged);
		}

		// Token: 0x04022B9C RID: 142236
		public UUIItem DragLayer;

		// Token: 0x04022B9D RID: 142237
		private DangoBrawlSelection HoveredItem;

		// Token: 0x04022B9E RID: 142238
		private DangoBrawlSelection Selection;
	}
}
