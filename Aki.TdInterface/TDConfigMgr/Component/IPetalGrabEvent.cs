using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000691 RID: 1681
	public class IPetalGrabEvent
	{
		// Token: 0x06002360 RID: 9056 RVA: 0x00060EE4 File Offset: 0x0005F0E4
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

		// Token: 0x06002361 RID: 9057 RVA: 0x00060F1C File Offset: 0x0005F11C
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

		// Token: 0x06002362 RID: 9058 RVA: 0x00060F2F File Offset: 0x0005F12F
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

		// Token: 0x06002363 RID: 9059 RVA: 0x00060F42 File Offset: 0x0005F142
		public IPetalGrabEvent_SetValue ToSetValue()
		{
			return new IPetalGrabEvent_SetValue
			{
				EventType = this.EventType,
				State = this.State
			};
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06002364 RID: 9060 RVA: 0x00060F61 File Offset: 0x0005F161
		// (set) Token: 0x06002365 RID: 9061 RVA: 0x00060F8C File Offset: 0x0005F18C
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

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x00060F9A File Offset: 0x0005F19A
		// (set) Token: 0x06002367 RID: 9063 RVA: 0x00060FC5 File Offset: 0x0005F1C5
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

		// Token: 0x040018A6 RID: 6310
		[Nullable(2)]
		protected IPetalGrabEvent FbInstance;

		// Token: 0x040018A7 RID: 6311
		[Nullable(2)]
		protected IPetalGrabEvent_SetValue PocoInterface;
	}
}
