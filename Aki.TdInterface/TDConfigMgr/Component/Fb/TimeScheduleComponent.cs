using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ED6 RID: 3798
	public class TimeScheduleComponent : IComponentBase
	{
		// Token: 0x06005596 RID: 21910 RVA: 0x000D23EC File Offset: 0x000D05EC
		public static TimeScheduleComponent Create(ITimeScheduleComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TimeScheduleComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x06005597 RID: 21911 RVA: 0x000D240C File Offset: 0x000D060C
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

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x06005598 RID: 21912 RVA: 0x000D2444 File Offset: 0x000D0644
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x06005599 RID: 21913 RVA: 0x000D245C File Offset: 0x000D065C
		public virtual List<ITimeScheduleConfig> TimeScheduleConfigs
		{
			get
			{
				if (this._TimeScheduleConfigsInited)
				{
					return this._TimeScheduleConfigsCache;
				}
				this._TimeScheduleConfigsInited = true;
				int timeScheduleConfigsLength = this.Instance.TimeScheduleConfigsLength;
				this._TimeScheduleConfigsCache = new List<ITimeScheduleConfig>(timeScheduleConfigsLength);
				for (int i = 0; i < timeScheduleConfigsLength; i++)
				{
					this._TimeScheduleConfigsCache.Add(ITimeScheduleConfig.Create(this.Instance.TimeScheduleConfigs(i)));
				}
				return this._TimeScheduleConfigsCache;
			}
		}

		// Token: 0x040030F7 RID: 12535
		private ITimeScheduleComponent Instance;

		// Token: 0x040030F8 RID: 12536
		private List<ITimeScheduleConfig> _TimeScheduleConfigsCache;

		// Token: 0x040030F9 RID: 12537
		private bool _TimeScheduleConfigsInited;
	}
}
