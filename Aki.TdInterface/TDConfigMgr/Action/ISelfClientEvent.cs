using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DF0 RID: 7664
	[NullableContext(1)]
	[Nullable(0)]
	public class ISelfClientEvent : IClientEventTarget
	{
		// Token: 0x0600A407 RID: 41991 RVA: 0x00174294 File Offset: 0x00172494
		private ISelfClientEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISelfClientEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISelfClientEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISelfClientEvent_SetValue());
			}
			return result;
		}

		// Token: 0x0600A408 RID: 41992 RVA: 0x001742CC File Offset: 0x001724CC
		public static ISelfClientEvent Create([Nullable(2)] ISelfClientEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISelfClientEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A409 RID: 41993 RVA: 0x001742DF File Offset: 0x001724DF
		public static ISelfClientEvent CreateFromSetValue([Nullable(2)] ISelfClientEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISelfClientEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A40A RID: 41994 RVA: 0x001742F2 File Offset: 0x001724F2
		public new ISelfClientEvent_SetValue ToSetValue()
		{
			return new ISelfClientEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003272 RID: 12914
		// (get) Token: 0x0600A40B RID: 41995 RVA: 0x00174305 File Offset: 0x00172505
		// (set) Token: 0x0600A40C RID: 41996 RVA: 0x00174330 File Offset: 0x00172530
		public override EClientEventTarget Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientEventTarget.Self;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006243 RID: 25155
		[Nullable(2)]
		protected new ISelfClientEvent FbInstance;

		// Token: 0x04006244 RID: 25156
		[Nullable(2)]
		protected new ISelfClientEvent_SetValue PocoInterface;
	}
}
