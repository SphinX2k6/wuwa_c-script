using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A31 RID: 6705
	public class IClientEventFlyingFlowerEvent
	{
		// Token: 0x06008EA1 RID: 36513 RVA: 0x00150A50 File Offset: 0x0014EC50
		private IClientEventFlyingFlowerEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientEventFlyingFlowerEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientEventFlyingFlowerEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientEventFlyingFlowerEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06008EA2 RID: 36514 RVA: 0x00150A88 File Offset: 0x0014EC88
		public static IClientEventFlyingFlowerEvent Create([Nullable(2)] IClientEventFlyingFlowerEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventFlyingFlowerEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008EA3 RID: 36515 RVA: 0x00150A9B File Offset: 0x0014EC9B
		public static IClientEventFlyingFlowerEvent CreateFromSetValue([Nullable(2)] IClientEventFlyingFlowerEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientEventFlyingFlowerEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008EA4 RID: 36516 RVA: 0x00150AAE File Offset: 0x0014ECAE
		public IClientEventFlyingFlowerEvent_SetValue ToSetValue()
		{
			return new IClientEventFlyingFlowerEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E13 RID: 11795
		// (get) Token: 0x06008EA5 RID: 36517 RVA: 0x00150AC1 File Offset: 0x0014ECC1
		// (set) Token: 0x06008EA6 RID: 36518 RVA: 0x00150AEC File Offset: 0x0014ECEC
		public virtual EClientEventFlyingFlowerEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientEventFlyingFlowerEventType.UpdateSubtitle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400598E RID: 22926
		[Nullable(2)]
		protected IClientEventFlyingFlowerEvent FbInstance;

		// Token: 0x0400598F RID: 22927
		[Nullable(2)]
		protected IClientEventFlyingFlowerEvent_SetValue PocoInterface;
	}
}
