using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C35 RID: 3125
	[NullableContext(1)]
	[Nullable(0)]
	public class TimelineTrackControlComponent : IComponentBase
	{
		// Token: 0x0600478F RID: 18319 RVA: 0x000B4322 File Offset: 0x000B2522
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

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x06004790 RID: 18320 RVA: 0x000B4344 File Offset: 0x000B2544
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

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x06004791 RID: 18321 RVA: 0x000B437C File Offset: 0x000B257C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x06004792 RID: 18322 RVA: 0x000B4394 File Offset: 0x000B2594
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

		// Token: 0x040028A8 RID: 10408
		private ITimelineTrackControlComponent Instance;

		// Token: 0x040028A9 RID: 10409
		private List<ITimelineControlGroup> _ControlGroupsCache;

		// Token: 0x040028AA RID: 10410
		private bool _ControlGroupsInited;
	}
}
