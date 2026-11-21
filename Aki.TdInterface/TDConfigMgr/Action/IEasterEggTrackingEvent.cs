using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B5B RID: 7003
	public class IEasterEggTrackingEvent : ITrackingEventTypeBase
	{
		// Token: 0x060094BD RID: 38077 RVA: 0x0015B22C File Offset: 0x0015942C
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

		// Token: 0x060094BE RID: 38078 RVA: 0x0015B264 File Offset: 0x00159464
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

		// Token: 0x060094BF RID: 38079 RVA: 0x0015B277 File Offset: 0x00159477
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

		// Token: 0x060094C0 RID: 38080 RVA: 0x0015B28A File Offset: 0x0015948A
		public new IEasterEggTrackingEvent_SetValue ToSetValue()
		{
			return new IEasterEggTrackingEvent_SetValue
			{
				Type = this.Type,
				EasterEggId = this.EasterEggId
			};
		}

		// Token: 0x17002F62 RID: 12130
		// (get) Token: 0x060094C1 RID: 38081 RVA: 0x0015B2A9 File Offset: 0x001594A9
		// (set) Token: 0x060094C2 RID: 38082 RVA: 0x0015B2D4 File Offset: 0x001594D4
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

		// Token: 0x17002F63 RID: 12131
		// (get) Token: 0x060094C3 RID: 38083 RVA: 0x0015B2E2 File Offset: 0x001594E2
		// (set) Token: 0x060094C4 RID: 38084 RVA: 0x0015B30D File Offset: 0x0015950D
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

		// Token: 0x04005C35 RID: 23605
		[Nullable(2)]
		protected new IEasterEggTrackingEvent FbInstance;

		// Token: 0x04005C36 RID: 23606
		[Nullable(2)]
		protected new IEasterEggTrackingEvent_SetValue PocoInterface;
	}
}
