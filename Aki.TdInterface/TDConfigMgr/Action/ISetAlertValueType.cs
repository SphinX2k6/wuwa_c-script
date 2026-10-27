using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E08 RID: 7688
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetAlertValueType
	{
		// Token: 0x0600A47D RID: 42109 RVA: 0x001750DC File Offset: 0x001732DC
		private ISetAlertValueType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetAlertValueType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetAlertValueType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetAlertValueType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A47E RID: 42110 RVA: 0x00175114 File Offset: 0x00173314
		public static ISetAlertValueType Create([Nullable(2)] ISetAlertValueType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetAlertValueType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A47F RID: 42111 RVA: 0x00175127 File Offset: 0x00173327
		public static ISetAlertValueType CreateFromSetValue([Nullable(2)] ISetAlertValueType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetAlertValueType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A480 RID: 42112 RVA: 0x0017513A File Offset: 0x0017333A
		public ISetAlertValueType_SetValue ToSetValue()
		{
			return new ISetAlertValueType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003289 RID: 12937
		// (get) Token: 0x0600A481 RID: 42113 RVA: 0x0017514D File Offset: 0x0017334D
		// (set) Token: 0x0600A482 RID: 42114 RVA: 0x00175178 File Offset: 0x00173378
		public virtual EValueChangeType Type
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

		// Token: 0x0400627E RID: 25214
		[Nullable(2)]
		protected ISetAlertValueType FbInstance;

		// Token: 0x0400627F RID: 25215
		[Nullable(2)]
		protected ISetAlertValueType_SetValue PocoInterface;
	}
}
