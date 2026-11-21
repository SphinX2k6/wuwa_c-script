using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D08 RID: 3336
	public class TimelineTrackControlComponent : IComponentBase
	{
		// Token: 0x06004BFF RID: 19455 RVA: 0x000BE6D2 File Offset: 0x000BC8D2
		public static TimelineTrackControlComponent Create(ITimelineTrackControlComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TimelineTrackControlComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x06004C00 RID: 19456 RVA: 0x000BE6F4 File Offset: 0x000BC8F4
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x06004C01 RID: 19457 RVA: 0x000BE72C File Offset: 0x000BC92C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x06004C02 RID: 19458 RVA: 0x000BE744 File Offset: 0x000BC944
		public virtual List<ITimelineControlGroup> ControlGroups
		{
			get
			{
				if (this._ControlGroupsInited)
				{
					return this._ControlGroupsCache;
				}
				this._ControlGroupsInited = true;
				int controlGroupsLength = this.Instance.ControlGroupsLength;
				this._ControlGroupsCache = new List<ITimelineControlGroup>(controlGroupsLength);
				for (int i = 0; i < controlGroupsLength; i++)
				{
					this._ControlGroupsCache.Add(ITimelineControlGroup.Create(this.Instance.ControlGroups(i)));
				}
				return this._ControlGroupsCache;
			}
		}

		// Token: 0x04002AFD RID: 11005
		private ITimelineTrackControlComponent Instance;

		// Token: 0x04002AFE RID: 11006
		private List<ITimelineControlGroup> _ControlGroupsCache;

		// Token: 0x04002AFF RID: 11007
		private bool _ControlGroupsInited;
	}
}
