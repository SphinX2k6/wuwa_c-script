using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DDA RID: 3546
	[NullableContext(1)]
	[Nullable(0)]
	public class TimeScheduleComponent : IComponentBase
	{
		// Token: 0x06005071 RID: 20593 RVA: 0x000C6B9C File Offset: 0x000C4D9C
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

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x06005072 RID: 20594 RVA: 0x000C6BBC File Offset: 0x000C4DBC
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

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x06005073 RID: 20595 RVA: 0x000C6BF4 File Offset: 0x000C4DF4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x06005074 RID: 20596 RVA: 0x000C6C0C File Offset: 0x000C4E0C
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

		// Token: 0x04002E31 RID: 11825
		private ITimeScheduleComponent Instance;

		// Token: 0x04002E32 RID: 11826
		private List<ITimeScheduleConfig> _TimeScheduleConfigsCache;

		// Token: 0x04002E33 RID: 11827
		private bool _TimeScheduleConfigsInited;
	}
}
