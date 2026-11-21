using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000641 RID: 1601
	public class IPasserbyNpcLiftStopExitTiming : IPasserbyNpcExitTimingBase
	{
		// Token: 0x060021A0 RID: 8608 RVA: 0x0005D700 File Offset: 0x0005B900
		private IPasserbyNpcLiftStopExitTiming_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcLiftStopExitTiming 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcLiftStopExitTiming_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcLiftStopExitTiming_SetValue());
			}
			return result;
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x0005D738 File Offset: 0x0005B938
		public static IPasserbyNpcLiftStopExitTiming Create([Nullable(2)] IPasserbyNpcLiftStopExitTiming instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcLiftStopExitTiming
			{
				FbInstance = instance
			};
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x0005D74B File Offset: 0x0005B94B
		public static IPasserbyNpcLiftStopExitTiming CreateFromSetValue([Nullable(2)] IPasserbyNpcLiftStopExitTiming_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcLiftStopExitTiming
			{
				PocoInterface = value
			};
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x0005D75E File Offset: 0x0005B95E
		public new IPasserbyNpcLiftStopExitTiming_SetValue ToSetValue()
		{
			return new IPasserbyNpcLiftStopExitTiming_SetValue
			{
				Type = this.Type,
				IntervalExit = this.IntervalExit
			};
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x060021A4 RID: 8612 RVA: 0x0005D77D File Offset: 0x0005B97D
		// (set) Token: 0x060021A5 RID: 8613 RVA: 0x0005D7A8 File Offset: 0x0005B9A8
		public override EPasserbyNpcExitTimingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcExitTimingType.LiftStop;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x0005D7B8 File Offset: 0x0005B9B8
		// (set) Token: 0x060021A7 RID: 8615 RVA: 0x0005D819 File Offset: 0x0005BA19
		[Nullable(2)]
		public virtual IPasserbyNpcIntervalExit IntervalExit
		{
			[NullableContext(2)]
			get
			{
				if (this._IntervalExitInited)
				{
					return this._IntervalExitCache;
				}
				this._IntervalExitInited = true;
				if (this.FbInstance != null)
				{
					this._IntervalExitCache = IPasserbyNpcIntervalExit.Create(this.FbInstance.IntervalExit);
				}
				else
				{
					IPasserbyNpcLiftStopExitTiming_SetValue pocoInterface = this.PocoInterface;
					this._IntervalExitCache = ((pocoInterface != null) ? pocoInterface.IntervalExit : null);
				}
				return this._IntervalExitCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().IntervalExit = value;
				this._IntervalExitInited = false;
			}
		}

		// Token: 0x040017BE RID: 6078
		[Nullable(2)]
		protected new IPasserbyNpcLiftStopExitTiming FbInstance;

		// Token: 0x040017BF RID: 6079
		[Nullable(2)]
		protected new IPasserbyNpcLiftStopExitTiming_SetValue PocoInterface;

		// Token: 0x040017C0 RID: 6080
		private IPasserbyNpcIntervalExit _IntervalExitCache;

		// Token: 0x040017C1 RID: 6081
		private bool _IntervalExitInited;
	}
}
