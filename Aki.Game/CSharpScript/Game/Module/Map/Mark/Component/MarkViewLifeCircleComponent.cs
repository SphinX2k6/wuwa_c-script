using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Base;

namespace CSharpScript.Game.Module.Map.Mark.Component
{
	// Token: 0x020054D0 RID: 21712
	public class MarkViewLifeCircleComponent : MapComponent
	{
		// Token: 0x060376E9 RID: 227049 RVA: 0x00D2A535 File Offset: 0x00D28735
		public MarkViewLifeCircleComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x1700850B RID: 34059
		// (get) Token: 0x060376EA RID: 227050 RVA: 0x00D2A549 File Offset: 0x00D28749
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.MarkViewLifeCircle;
			}
		}

		// Token: 0x060376EB RID: 227051 RVA: 0x00D2A54D File Offset: 0x00D2874D
		public void SetChildViewVisibility(EMarkViewComponentType childViewType, bool visible)
		{
			this.ChildViewVisibleStateMap.Set(childViewType, visible);
		}

		// Token: 0x060376EC RID: 227052 RVA: 0x00D2A55D File Offset: 0x00D2875D
		public bool IsChildViewVisible(EMarkViewComponentType childViewType, bool defaultValue = false)
		{
			return this.ChildViewVisibleStateMap.TryGet(childViewType, defaultValue, false);
		}

		// Token: 0x060376ED RID: 227053 RVA: 0x00D2A56D File Offset: 0x00D2876D
		public void SetChildViewVisibleClean(EMarkViewComponentType childViewType)
		{
			this.ChildViewVisibleStateMap.CleanDirty(childViewType);
		}

		// Token: 0x060376EE RID: 227054 RVA: 0x00D2A57B File Offset: 0x00D2877B
		public bool IsChildViewStateDirty(EMarkViewComponentType childViewType)
		{
			return this.ChildViewVisibleStateMap.IsDirty(childViewType);
		}

		// Token: 0x060376EF RID: 227055 RVA: 0x00D2A58C File Offset: 0x00D2878C
		public void SetAllChildViewStateDirty()
		{
			foreach (KeyValuePair<EMarkViewComponentType, bool> keyValuePair in this.ChildViewVisibleStateMap)
			{
				if (keyValuePair.Key != EMarkViewComponentType.MarkView)
				{
					this.ChildViewVisibleStateMap.SetDirty(keyValuePair.Key);
				}
			}
		}

		// Token: 0x060376F0 RID: 227056 RVA: 0x00D2A5F0 File Offset: 0x00D287F0
		protected override void OnRemove()
		{
			this.ChildViewVisibleStateMap.Clear();
		}

		// Token: 0x1700850C RID: 34060
		// (get) Token: 0x060376F2 RID: 227058 RVA: 0x00D2A618 File Offset: 0x00D28818
		// (set) Token: 0x060376F1 RID: 227057 RVA: 0x00D2A5FD File Offset: 0x00D287FD
		public bool EnableVerticalPointer
		{
			get
			{
				OneOf<Vector2D, bool, int, string, float> oneOf;
				return !base.PropertyMap.TryGetValue(0, out oneOf) || oneOf.AsT2;
			}
			set
			{
				base.PropertyMap[0] = value;
			}
		}

		// Token: 0x1700850D RID: 34061
		// (get) Token: 0x060376F4 RID: 227060 RVA: 0x00D2A65C File Offset: 0x00D2885C
		// (set) Token: 0x060376F3 RID: 227059 RVA: 0x00D2A643 File Offset: 0x00D28843
		public EVerticalPointerType VerticalPointerType
		{
			get
			{
				OneOf<Vector2D, bool, int, string, float> oneOf;
				if (base.PropertyMap.TryGetValue(1, out oneOf))
				{
					return (EVerticalPointerType)oneOf.AsT3;
				}
				return EVerticalPointerType.None;
			}
			set
			{
				base.PropertyMap[1] = (int)value;
			}
		}

		// Token: 0x1700850E RID: 34062
		// (get) Token: 0x060376F5 RID: 227061 RVA: 0x00D2A687 File Offset: 0x00D28887
		public bool IsVerticalPointerTypeDirty
		{
			get
			{
				return base.PropertyMap.IsDirty(1);
			}
		}

		// Token: 0x060376F6 RID: 227062 RVA: 0x00D2A69A File Offset: 0x00D2889A
		public void SetVerticalPointerTypeClean()
		{
			base.PropertyMap.CleanDirty(1);
		}

		// Token: 0x1700850F RID: 34063
		// (get) Token: 0x060376F8 RID: 227064 RVA: 0x00D2A6C0 File Offset: 0x00D288C0
		// (set) Token: 0x060376F7 RID: 227063 RVA: 0x00D2A6AD File Offset: 0x00D288AD
		public bool IsInAoiRange
		{
			get
			{
				return this._isInAoiRangeInner;
			}
			set
			{
				if (this._isInAoiRangeInner == value)
				{
					return;
				}
				this._isInAoiRangeInner = value;
			}
		}

		// Token: 0x17008510 RID: 34064
		// (get) Token: 0x060376FA RID: 227066 RVA: 0x00D2A6E2 File Offset: 0x00D288E2
		// (set) Token: 0x060376F9 RID: 227065 RVA: 0x00D2A6C8 File Offset: 0x00D288C8
		public bool IsSelected
		{
			get
			{
				return this._isSelectedInner;
			}
			set
			{
				if (this._isSelectedInner == value)
				{
					return;
				}
				this._isSelectedInner = value;
				this._isSelectedDirtyInner = true;
			}
		}

		// Token: 0x17008511 RID: 34065
		// (get) Token: 0x060376FB RID: 227067 RVA: 0x00D2A6EA File Offset: 0x00D288EA
		public bool IsSelectedDirty
		{
			get
			{
				return this._isSelectedDirtyInner;
			}
		}

		// Token: 0x17008512 RID: 34066
		// (get) Token: 0x060376FD RID: 227069 RVA: 0x00D2A70C File Offset: 0x00D2890C
		// (set) Token: 0x060376FC RID: 227068 RVA: 0x00D2A6F2 File Offset: 0x00D288F2
		public bool IsTracked
		{
			get
			{
				return this._isTrackedInner;
			}
			set
			{
				if (this._isTrackedInner == value)
				{
					return;
				}
				this._isTrackedInner = value;
				this._isTrackedDirtyInner = true;
			}
		}

		// Token: 0x17008513 RID: 34067
		// (get) Token: 0x060376FE RID: 227070 RVA: 0x00D2A714 File Offset: 0x00D28914
		public bool IsTrackedDirty
		{
			get
			{
				return this._isTrackedDirtyInner;
			}
		}

		// Token: 0x17008514 RID: 34068
		// (get) Token: 0x06037700 RID: 227072 RVA: 0x00D2A736 File Offset: 0x00D28936
		// (set) Token: 0x060376FF RID: 227071 RVA: 0x00D2A71C File Offset: 0x00D2891C
		public bool IsAutoPilotTracked
		{
			get
			{
				return this._isAutoPilotTrackedInner;
			}
			set
			{
				if (this._isAutoPilotTrackedInner == value)
				{
					return;
				}
				this._isAutoPilotTrackedInner = value;
				this._isAutoPilotTrackedDirtyInner = true;
			}
		}

		// Token: 0x17008515 RID: 34069
		// (get) Token: 0x06037701 RID: 227073 RVA: 0x00D2A73E File Offset: 0x00D2893E
		public bool IsAutoPilotTrackedDirty
		{
			get
			{
				return this._isAutoPilotTrackedDirtyInner;
			}
		}

		// Token: 0x0401D37C RID: 119676
		private bool _isInAoiRangeInner;

		// Token: 0x0401D37D RID: 119677
		private bool _isSelectedInner;

		// Token: 0x0401D37E RID: 119678
		private bool _isSelectedDirtyInner;

		// Token: 0x0401D37F RID: 119679
		private bool _isTrackedInner;

		// Token: 0x0401D380 RID: 119680
		private bool _isTrackedDirtyInner;

		// Token: 0x0401D381 RID: 119681
		private bool _isAutoPilotTrackedInner;

		// Token: 0x0401D382 RID: 119682
		private bool _isAutoPilotTrackedDirtyInner;

		// Token: 0x0401D383 RID: 119683
		[Nullable(1)]
		protected PropertyMap<EMarkViewComponentType, bool> ChildViewVisibleStateMap = new PropertyMap<EMarkViewComponentType, bool>();

		// Token: 0x0200B73F RID: 46911
		private enum EPropertyType
		{
			// Token: 0x040377D9 RID: 227289
			EnableVerticalPointer,
			// Token: 0x040377DA RID: 227290
			VerticalPointerType
		}
	}
}
