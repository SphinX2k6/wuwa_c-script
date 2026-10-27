using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019CE RID: 6606
	[NullableContext(1)]
	[Nullable(0)]
	public class IEasterEggTrackingEvent : ITrackingEventTypeBase
	{
		// Token: 0x06008D7B RID: 36219 RVA: 0x0014B720 File Offset: 0x00149920
		private IEasterEggTrackingEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEasterEggTrackingEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEasterEggTrackingEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEasterEggTrackingEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06008D7C RID: 36220 RVA: 0x0014B758 File Offset: 0x00149958
		public static IEasterEggTrackingEvent Create([Nullable(2)] IEasterEggTrackingEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEasterEggTrackingEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008D7D RID: 36221 RVA: 0x0014B76B File Offset: 0x0014996B
		public static IEasterEggTrackingEvent CreateFromSetValue([Nullable(2)] IEasterEggTrackingEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEasterEggTrackingEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008D7E RID: 36222 RVA: 0x0014B77E File Offset: 0x0014997E
		public new IEasterEggTrackingEvent_SetValue ToSetValue()
		{
			return new IEasterEggTrackingEvent_SetValue
			{
				Type = this.Type,
				EasterEggId = this.EasterEggId
			};
		}

		// Token: 0x17002D5D RID: 11613
		// (get) Token: 0x06008D7F RID: 36223 RVA: 0x0014B79D File Offset: 0x0014999D
		// (set) Token: 0x06008D80 RID: 36224 RVA: 0x0014B7C8 File Offset: 0x001499C8
		public override ETrackingEventType Type
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

		// Token: 0x17002D5E RID: 11614
		// (get) Token: 0x06008D81 RID: 36225 RVA: 0x0014B7D6 File Offset: 0x001499D6
		// (set) Token: 0x06008D82 RID: 36226 RVA: 0x0014B801 File Offset: 0x00149A01
		public virtual int EasterEggId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EasterEggId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EasterEggId;
			}
			set
			{
				this.GetOrCreatePoco().EasterEggId = value;
			}
		}

		// Token: 0x040057E0 RID: 22496
		[Nullable(2)]
		protected new IEasterEggTrackingEvent FbInstance;

		// Token: 0x040057E1 RID: 22497
		[Nullable(2)]
		protected new IEasterEggTrackingEvent_SetValue PocoInterface;
	}
}
