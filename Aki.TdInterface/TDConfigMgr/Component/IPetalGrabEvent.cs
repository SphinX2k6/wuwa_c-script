using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005F4 RID: 1524
	[NullableContext(1)]
	[Nullable(0)]
	public class IPetalGrabEvent
	{
		// Token: 0x0600205E RID: 8286 RVA: 0x0005A268 File Offset: 0x00058468
		private IPetalGrabEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPetalGrabEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPetalGrabEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPetalGrabEvent_SetValue());
			}
			return result;
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x0005A2A0 File Offset: 0x000584A0
		public static IPetalGrabEvent Create([Nullable(2)] IPetalGrabEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPetalGrabEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x0005A2B3 File Offset: 0x000584B3
		public static IPetalGrabEvent CreateFromSetValue([Nullable(2)] IPetalGrabEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPetalGrabEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x0005A2C6 File Offset: 0x000584C6
		public IPetalGrabEvent_SetValue ToSetValue()
		{
			return new IPetalGrabEvent_SetValue
			{
				EventType = this.EventType,
				State = this.State
			};
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x0005A2E5 File Offset: 0x000584E5
		// (set) Token: 0x06002063 RID: 8291 RVA: 0x0005A310 File Offset: 0x00058510
		public virtual EPetalGrabEventType EventType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EventType;
				}
				if (this.PocoInterface == null)
				{
					return EPetalGrabEventType.Grabbed;
				}
				return this.PocoInterface.EventType;
			}
			set
			{
				this.GetOrCreatePoco().EventType = value;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06002064 RID: 8292 RVA: 0x0005A31E File Offset: 0x0005851E
		// (set) Token: 0x06002065 RID: 8293 RVA: 0x0005A349 File Offset: 0x00058549
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x040016B6 RID: 5814
		[Nullable(2)]
		protected IPetalGrabEvent FbInstance;

		// Token: 0x040016B7 RID: 5815
		[Nullable(2)]
		protected IPetalGrabEvent_SetValue PocoInterface;
	}
}
