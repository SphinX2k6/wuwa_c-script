using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008C4 RID: 2244
	[NullableContext(1)]
	[Nullable(0)]
	public class TimeScheduleComponent : IComponentBase
	{
		// Token: 0x06003283 RID: 12931 RVA: 0x000818BC File Offset: 0x0007FABC
		private TimeScheduleComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TimeScheduleComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TimeScheduleComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TimeScheduleComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x000818F4 File Offset: 0x0007FAF4
		public static TimeScheduleComponent Create([Nullable(2)] TimeScheduleComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TimeScheduleComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x00081907 File Offset: 0x0007FB07
		public static TimeScheduleComponent CreateFromSetValue([Nullable(2)] TimeScheduleComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TimeScheduleComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003286 RID: 12934 RVA: 0x0008191A File Offset: 0x0007FB1A
		public new TimeScheduleComponent_SetValue ToSetValue()
		{
			return new TimeScheduleComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				TimeScheduleConfigs = this.TimeScheduleConfigs
			};
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06003287 RID: 12935 RVA: 0x00081948 File Offset: 0x0007FB48
		// (set) Token: 0x06003288 RID: 12936 RVA: 0x00081982 File Offset: 0x0007FB82
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				TimeScheduleComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06003289 RID: 12937 RVA: 0x00081990 File Offset: 0x0007FB90
		// (set) Token: 0x0600328A RID: 12938 RVA: 0x000819BA File Offset: 0x0007FBBA
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

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x0600328B RID: 12939 RVA: 0x000819C8 File Offset: 0x0007FBC8
		// (set) Token: 0x0600328C RID: 12940 RVA: 0x00081A5B File Offset: 0x0007FC5B
		public virtual List<ITimeScheduleConfig> TimeScheduleConfigs
		{
			get
			{
				if (this._TimeScheduleConfigsInited)
				{
					return this._TimeScheduleConfigsCache;
				}
				this._TimeScheduleConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<ITimeScheduleConfig> timeScheduleConfigs = this.FbInstance.TimeScheduleConfigs;
					if (timeScheduleConfigs != null)
					{
						this._TimeScheduleConfigsCache = new List<ITimeScheduleConfig>(timeScheduleConfigs.Count);
						for (int i = 0; i < timeScheduleConfigs.Count; i++)
						{
							this._TimeScheduleConfigsCache.Add(ITimeScheduleConfig.Create(timeScheduleConfigs[i]));
						}
					}
				}
				else
				{
					TimeScheduleComponent_SetValue pocoInterface = this.PocoInterface;
					this._TimeScheduleConfigsCache = ((pocoInterface != null) ? pocoInterface.TimeScheduleConfigs : null);
				}
				return this._TimeScheduleConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().TimeScheduleConfigs = value;
				this._TimeScheduleConfigsInited = false;
			}
		}

		// Token: 0x04002126 RID: 8486
		[Nullable(2)]
		protected new TimeScheduleComponent FbInstance;

		// Token: 0x04002127 RID: 8487
		[Nullable(2)]
		protected new TimeScheduleComponent_SetValue PocoInterface;

		// Token: 0x04002128 RID: 8488
		private List<ITimeScheduleConfig> _TimeScheduleConfigsCache;

		// Token: 0x04002129 RID: 8489
		private bool _TimeScheduleConfigsInited;
	}
}
