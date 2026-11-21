using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002223 RID: 8739
	public class ITrackingEventTypeBase
	{
		// Token: 0x0600BE88 RID: 48776 RVA: 0x001B81A4 File Offset: 0x001B63A4
		private ITrackingEventTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrackingEventTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrackingEventTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrackingEventTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600BE89 RID: 48777 RVA: 0x001B81DC File Offset: 0x001B63DC
		public static ITrackingEventTypeBase Create([Nullable(2)] ITrackingEventTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackingEventTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BE8A RID: 48778 RVA: 0x001B81EF File Offset: 0x001B63EF
		public static ITrackingEventTypeBase CreateFromSetValue([Nullable(2)] ITrackingEventTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrackingEventTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BE8B RID: 48779 RVA: 0x001B8202 File Offset: 0x001B6402
		public ITrackingEventTypeBase_SetValue ToSetValue()
		{
			return new ITrackingEventTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A1F RID: 14879
		// (get) Token: 0x0600BE8C RID: 48780 RVA: 0x001B8215 File Offset: 0x001B6415
		// (set) Token: 0x0600BE8D RID: 48781 RVA: 0x001B8240 File Offset: 0x001B6440
		public virtual ETrackingEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrackingEventType.EasterEgg;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007244 RID: 29252
		[Nullable(2)]
		protected ITrackingEventTypeBase FbInstance;

		// Token: 0x04007245 RID: 29253
		[Nullable(2)]
		protected ITrackingEventTypeBase_SetValue PocoInterface;
	}
}
