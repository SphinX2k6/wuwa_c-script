using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200225A RID: 8794
	[JsonConverter(typeof(IUiOperationTypeConverter))]
	public class IUiOperationType
	{
		// Token: 0x0600BFA6 RID: 49062 RVA: 0x001BA2A4 File Offset: 0x001B84A4
		private IUiOperationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUiOperationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUiOperationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUiOperationType_SetValue());
			}
			return result;
		}

		// Token: 0x0600BFA7 RID: 49063 RVA: 0x001BA2DC File Offset: 0x001B84DC
		public static IUiOperationType Create([Nullable(2)] IUiOperationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUiOperationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BFA8 RID: 49064 RVA: 0x001BA2EF File Offset: 0x001B84EF
		public static IUiOperationType CreateFromSetValue([Nullable(2)] IUiOperationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUiOperationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BFA9 RID: 49065 RVA: 0x001BA302 File Offset: 0x001B8502
		public IUiOperationType_SetValue ToSetValue()
		{
			return new IUiOperationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A5C RID: 14940
		// (get) Token: 0x0600BFAA RID: 49066 RVA: 0x001BA315 File Offset: 0x001B8515
		// (set) Token: 0x0600BFAB RID: 49067 RVA: 0x001BA340 File Offset: 0x001B8540
		public virtual EUiOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUiOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040072CD RID: 29389
		[Nullable(2)]
		protected IUiOperationType FbInstance;

		// Token: 0x040072CE RID: 29390
		[Nullable(2)]
		protected IUiOperationType_SetValue PocoInterface;
	}
}
