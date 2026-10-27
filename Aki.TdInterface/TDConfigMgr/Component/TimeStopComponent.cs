using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008C6 RID: 2246
	[NullableContext(1)]
	[Nullable(0)]
	public class TimeStopComponent : IComponentBase
	{
		// Token: 0x0600328F RID: 12943 RVA: 0x00081A80 File Offset: 0x0007FC80
		private TimeStopComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TimeStopComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TimeStopComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TimeStopComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x00081AB8 File Offset: 0x0007FCB8
		public static TimeStopComponent Create([Nullable(2)] TimeStopComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TimeStopComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x00081ACB File Offset: 0x0007FCCB
		public static TimeStopComponent CreateFromSetValue([Nullable(2)] TimeStopComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TimeStopComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x00081AE0 File Offset: 0x0007FCE0
		public new TimeStopComponent_SetValue ToSetValue()
		{
			return new TimeStopComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				ActiveState = this.ActiveState,
				StopTime = this.StopTime,
				Target = this.Target
			};
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x06003293 RID: 12947 RVA: 0x00081B30 File Offset: 0x0007FD30
		// (set) Token: 0x06003294 RID: 12948 RVA: 0x00081B6A File Offset: 0x0007FD6A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				TimeStopComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06003295 RID: 12949 RVA: 0x00081B78 File Offset: 0x0007FD78
		// (set) Token: 0x06003296 RID: 12950 RVA: 0x00081BA2 File Offset: 0x0007FDA2
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

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06003297 RID: 12951 RVA: 0x00081BB0 File Offset: 0x0007FDB0
		// (set) Token: 0x06003298 RID: 12952 RVA: 0x00081BDB File Offset: 0x0007FDDB
		public virtual string ActiveState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActiveState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ActiveState;
			}
			set
			{
				this.GetOrCreatePoco().ActiveState = value;
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06003299 RID: 12953 RVA: 0x00081BE9 File Offset: 0x0007FDE9
		// (set) Token: 0x0600329A RID: 12954 RVA: 0x00081C14 File Offset: 0x0007FE14
		public virtual int StopTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StopTime;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.StopTime;
			}
			set
			{
				this.GetOrCreatePoco().StopTime = value;
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x0600329B RID: 12955 RVA: 0x00081C24 File Offset: 0x0007FE24
		// (set) Token: 0x0600329C RID: 12956 RVA: 0x00081C85 File Offset: 0x0007FE85
		public virtual ITimeStopTarget Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				if (this.FbInstance != null)
				{
					this._TargetCache = ITimeStopTarget.Create(this.FbInstance.Target);
				}
				else
				{
					TimeStopComponent_SetValue pocoInterface = this.PocoInterface;
					this._TargetCache = ((pocoInterface != null) ? pocoInterface.Target : null);
				}
				return this._TargetCache;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
				this._TargetInited = false;
			}
		}

		// Token: 0x0400212D RID: 8493
		[Nullable(2)]
		protected new TimeStopComponent FbInstance;

		// Token: 0x0400212E RID: 8494
		[Nullable(2)]
		protected new TimeStopComponent_SetValue PocoInterface;

		// Token: 0x0400212F RID: 8495
		private ITimeStopTarget _TargetCache;

		// Token: 0x04002130 RID: 8496
		private bool _TargetInited;
	}
}
