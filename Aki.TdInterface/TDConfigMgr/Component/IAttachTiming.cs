using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001F4 RID: 500
	public class IAttachTiming
	{
		// Token: 0x060007C8 RID: 1992 RVA: 0x00026298 File Offset: 0x00024498
		private IAttachTiming_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAttachTiming 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAttachTiming_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAttachTiming_SetValue());
			}
			return result;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x000262D0 File Offset: 0x000244D0
		public static IAttachTiming Create([Nullable(2)] IAttachTiming instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAttachTiming
			{
				FbInstance = instance
			};
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x000262E3 File Offset: 0x000244E3
		public static IAttachTiming CreateFromSetValue([Nullable(2)] IAttachTiming_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAttachTiming
			{
				PocoInterface = value
			};
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x000262F6 File Offset: 0x000244F6
		public IAttachTiming_SetValue ToSetValue()
		{
			return new IAttachTiming_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x00026309 File Offset: 0x00024509
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x00026334 File Offset: 0x00024534
		public virtual EAttachTimingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAttachTimingType.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000918 RID: 2328
		[Nullable(2)]
		protected IAttachTiming FbInstance;

		// Token: 0x04000919 RID: 2329
		[Nullable(2)]
		protected IAttachTiming_SetValue PocoInterface;
	}
}
