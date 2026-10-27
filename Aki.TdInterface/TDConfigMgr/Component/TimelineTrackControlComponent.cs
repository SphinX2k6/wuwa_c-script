using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008C2 RID: 2242
	[NullableContext(1)]
	[Nullable(0)]
	public class TimelineTrackControlComponent : IComponentBase
	{
		// Token: 0x06003277 RID: 12919 RVA: 0x000816F8 File Offset: 0x0007F8F8
		private TimelineTrackControlComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TimelineTrackControlComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TimelineTrackControlComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TimelineTrackControlComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x00081730 File Offset: 0x0007F930
		public static TimelineTrackControlComponent Create([Nullable(2)] TimelineTrackControlComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TimelineTrackControlComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x00081743 File Offset: 0x0007F943
		public static TimelineTrackControlComponent CreateFromSetValue([Nullable(2)] TimelineTrackControlComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TimelineTrackControlComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x00081756 File Offset: 0x0007F956
		public new TimelineTrackControlComponent_SetValue ToSetValue()
		{
			return new TimelineTrackControlComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				ControlGroups = this.ControlGroups
			};
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x0600327B RID: 12923 RVA: 0x00081784 File Offset: 0x0007F984
		// (set) Token: 0x0600327C RID: 12924 RVA: 0x000817BE File Offset: 0x0007F9BE
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				TimelineTrackControlComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x0600327D RID: 12925 RVA: 0x000817CC File Offset: 0x0007F9CC
		// (set) Token: 0x0600327E RID: 12926 RVA: 0x000817F6 File Offset: 0x0007F9F6
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x0600327F RID: 12927 RVA: 0x00081804 File Offset: 0x0007FA04
		// (set) Token: 0x06003280 RID: 12928 RVA: 0x00081897 File Offset: 0x0007FA97
		public virtual List<ITimelineControlGroup> ControlGroups
		{
			get
			{
				if (this._ControlGroupsInited)
				{
					return this._ControlGroupsCache;
				}
				this._ControlGroupsInited = true;
				if (this.FbInstance != null)
				{
					List<ITimelineControlGroup> controlGroups = this.FbInstance.ControlGroups;
					if (controlGroups != null)
					{
						this._ControlGroupsCache = new List<ITimelineControlGroup>(controlGroups.Count);
						for (int i = 0; i < controlGroups.Count; i++)
						{
							this._ControlGroupsCache.Add(ITimelineControlGroup.Create(controlGroups[i]));
						}
					}
				}
				else
				{
					TimelineTrackControlComponent_SetValue pocoInterface = this.PocoInterface;
					this._ControlGroupsCache = ((pocoInterface != null) ? pocoInterface.ControlGroups : null);
				}
				return this._ControlGroupsCache;
			}
			set
			{
				this.GetOrCreatePoco().ControlGroups = value;
				this._ControlGroupsInited = false;
			}
		}

		// Token: 0x0400211F RID: 8479
		[Nullable(2)]
		protected new TimelineTrackControlComponent FbInstance;

		// Token: 0x04002120 RID: 8480
		[Nullable(2)]
		protected new TimelineTrackControlComponent_SetValue PocoInterface;

		// Token: 0x04002121 RID: 8481
		private List<ITimelineControlGroup> _ControlGroupsCache;

		// Token: 0x04002122 RID: 8482
		private bool _ControlGroupsInited;
	}
}
