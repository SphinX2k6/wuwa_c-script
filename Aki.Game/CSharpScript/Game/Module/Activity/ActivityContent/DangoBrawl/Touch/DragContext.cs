using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x020057AA RID: 22442
	[NullableContext(2)]
	[Nullable(0)]
	public class DragContext
	{
		// Token: 0x06037692 RID: 226962 RVA: 0x00F7AB08 File Offset: 0x00F78D08
		public void Start()
		{
		}

		// Token: 0x06037693 RID: 226963 RVA: 0x00F7AB0A File Offset: 0x00F78D0A
		public void Stop()
		{
			this.DragLayer = null;
			this.Selection = null;
			this.HoveredItem = null;
		}

		// Token: 0x06037694 RID: 226964 RVA: 0x00F7AB21 File Offset: 0x00F78D21
		public DangoBrawlSelection GetHoveredItem()
		{
			return this.HoveredItem;
		}

		// Token: 0x06037695 RID: 226965 RVA: 0x00F7AB29 File Offset: 0x00F78D29
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

		// Token: 0x06037696 RID: 226966 RVA: 0x00F7AB58 File Offset: 0x00F78D58
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

		// Token: 0x06037697 RID: 226967 RVA: 0x00F7AB90 File Offset: 0x00F78D90
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

		// Token: 0x06037698 RID: 226968 RVA: 0x00F7ABCB File Offset: 0x00F78DCB
		public void ClearHoveredItemIfMatch(EDragSourceKind source, int uid)
		{
			if (!this.IsHovered(source, uid))
			{
				return;
			}
			this.HoveredItem = null;
			EventSystem.Instance.Emit<int, EDragSourceKind>(EEventName.OnDangoBrawlItemHoveredChange, 0, source);
		}

		// Token: 0x06037699 RID: 226969 RVA: 0x00F7ABF1 File Offset: 0x00F78DF1
		public DangoBrawlSelection GetSelection()
		{
			return this.Selection;
		}

		// Token: 0x0603769A RID: 226970 RVA: 0x00F7ABF9 File Offset: 0x00F78DF9
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

		// Token: 0x0603769B RID: 226971 RVA: 0x00F7AC28 File Offset: 0x00F78E28
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

		// Token: 0x0603769C RID: 226972 RVA: 0x00F7AC74 File Offset: 0x00F78E74
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

		// Token: 0x0603769D RID: 226973 RVA: 0x00F7ACAF File Offset: 0x00F78EAF
		public void ClearSelectionIfMatch(EDragSourceKind source, int id)
		{
			if (!this.IsSelected(source, id))
			{
				return;
			}
			this.Selection = null;
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlSelectionChanged);
		}

		// Token: 0x0603769E RID: 226974 RVA: 0x00F7ACD3 File Offset: 0x00F78ED3
		public void ClearSelection()
		{
			if (this.Selection == null)
			{
				return;
			}
			this.Selection = null;
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlSelectionChanged);
		}

		// Token: 0x0401D3F9 RID: 119801
		public UUIItem DragLayer;

		// Token: 0x0401D3FA RID: 119802
		private DangoBrawlSelection HoveredItem;

		// Token: 0x0401D3FB RID: 119803
		private DangoBrawlSelection Selection;
	}
}
