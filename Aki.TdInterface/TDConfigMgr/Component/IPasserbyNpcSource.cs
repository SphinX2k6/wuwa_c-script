using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000657 RID: 1623
	public class IPasserbyNpcSource
	{
		// Token: 0x0600221A RID: 8730 RVA: 0x0005E66C File Offset: 0x0005C86C
		private IPasserbyNpcSource_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcSource 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcSource_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcSource_SetValue());
			}
			return result;
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x0005E6A4 File Offset: 0x0005C8A4
		public static IPasserbyNpcSource Create([Nullable(2)] IPasserbyNpcSource instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcSource
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x0005E6B7 File Offset: 0x0005C8B7
		public static IPasserbyNpcSource CreateFromSetValue([Nullable(2)] IPasserbyNpcSource_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcSource
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x0005E6CA File Offset: 0x0005C8CA
		public IPasserbyNpcSource_SetValue ToSetValue()
		{
			return new IPasserbyNpcSource_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x0005E6DD File Offset: 0x0005C8DD
		// (set) Token: 0x0600221F RID: 8735 RVA: 0x0005E708 File Offset: 0x0005C908
		public virtual EPasserbyNpcSource Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcSource.Template;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001800 RID: 6144
		[Nullable(2)]
		protected IPasserbyNpcSource FbInstance;

		// Token: 0x04001801 RID: 6145
		[Nullable(2)]
		protected IPasserbyNpcSource_SetValue PocoInterface;
	}
}
