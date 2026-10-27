using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018A6 RID: 6310
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientEventFlyingFlowerEvent
	{
		// Token: 0x06008779 RID: 34681 RVA: 0x0014121C File Offset: 0x0013F41C
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

		// Token: 0x0600877A RID: 34682 RVA: 0x00141254 File Offset: 0x0013F454
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

		// Token: 0x0600877B RID: 34683 RVA: 0x00141267 File Offset: 0x0013F467
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

		// Token: 0x0600877C RID: 34684 RVA: 0x0014127A File Offset: 0x0013F47A
		public IClientEventFlyingFlowerEvent_SetValue ToSetValue()
		{
			return new IClientEventFlyingFlowerEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C18 RID: 11288
		// (get) Token: 0x0600877D RID: 34685 RVA: 0x0014128D File Offset: 0x0013F48D
		// (set) Token: 0x0600877E RID: 34686 RVA: 0x001412B8 File Offset: 0x0013F4B8
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

		// Token: 0x04005541 RID: 21825
		[Nullable(2)]
		protected IClientEventFlyingFlowerEvent FbInstance;

		// Token: 0x04005542 RID: 21826
		[Nullable(2)]
		protected IClientEventFlyingFlowerEvent_SetValue PocoInterface;
	}
}
