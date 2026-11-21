using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DC7 RID: 7623
	public class IMinAlertValue : ISetAlertValueType
	{
		// Token: 0x0600A1D9 RID: 41433 RVA: 0x00172B50 File Offset: 0x00170D50
		private IMinAlertValue_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMinAlertValue 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMinAlertValue_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMinAlertValue_SetValue());
			}
			return result;
		}

		// Token: 0x0600A1DA RID: 41434 RVA: 0x00172B88 File Offset: 0x00170D88
		public static IMinAlertValue Create([Nullable(2)] IMinAlertValue instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMinAlertValue
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A1DB RID: 41435 RVA: 0x00172B9B File Offset: 0x00170D9B
		public static IMinAlertValue CreateFromSetValue([Nullable(2)] IMinAlertValue_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMinAlertValue
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A1DC RID: 41436 RVA: 0x00172BAE File Offset: 0x00170DAE
		public new IMinAlertValue_SetValue ToSetValue()
		{
			return new IMinAlertValue_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003250 RID: 12880
		// (get) Token: 0x0600A1DD RID: 41437 RVA: 0x00172BC1 File Offset: 0x00170DC1
		// (set) Token: 0x0600A1DE RID: 41438 RVA: 0x00172BEC File Offset: 0x00170DEC
		public override EValueChangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EValueChangeType.AddOrSub;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400623B RID: 25147
		[Nullable(2)]
		protected new IMinAlertValue FbInstance;

		// Token: 0x0400623C RID: 25148
		[Nullable(2)]
		protected new IMinAlertValue_SetValue PocoInterface;
	}
}
