using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000965 RID: 2405
	public class TimelineTrackControlComponent : IComponentBase
	{
		// Token: 0x060035B3 RID: 13747 RVA: 0x00088BE0 File Offset: 0x00086DE0
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

		// Token: 0x060035B4 RID: 13748 RVA: 0x00088C18 File Offset: 0x00086E18
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

		// Token: 0x060035B5 RID: 13749 RVA: 0x00088C2B File Offset: 0x00086E2B
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

		// Token: 0x060035B6 RID: 13750 RVA: 0x00088C3E File Offset: 0x00086E3E
		public new TimelineTrackControlComponent_SetValue ToSetValue()
		{
			return new TimelineTrackControlComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				ControlGroups = this.ControlGroups
			};
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x060035B7 RID: 13751 RVA: 0x00088C6C File Offset: 0x00086E6C
		// (set) Token: 0x060035B8 RID: 13752 RVA: 0x00088CA6 File Offset: 0x00086EA6
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

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x060035B9 RID: 13753 RVA: 0x00088CB4 File Offset: 0x00086EB4
		// (set) Token: 0x060035BA RID: 13754 RVA: 0x00088CDE File Offset: 0x00086EDE
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

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x060035BB RID: 13755 RVA: 0x00088CEC File Offset: 0x00086EEC
		// (set) Token: 0x060035BC RID: 13756 RVA: 0x00088D7F File Offset: 0x00086F7F
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

		// Token: 0x04002331 RID: 9009
		[Nullable(2)]
		protected new TimelineTrackControlComponent FbInstance;

		// Token: 0x04002332 RID: 9010
		[Nullable(2)]
		protected new TimelineTrackControlComponent_SetValue PocoInterface;

		// Token: 0x04002333 RID: 9011
		private List<ITimelineControlGroup> _ControlGroupsCache;

		// Token: 0x04002334 RID: 9012
		private bool _ControlGroupsInited;
	}
}
