using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005CA RID: 1482
	[NullableContext(1)]
	[Nullable(0)]
	public class IPasserbyNpcSource
	{
		// Token: 0x06001F60 RID: 8032 RVA: 0x000581DC File Offset: 0x000563DC
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

		// Token: 0x06001F61 RID: 8033 RVA: 0x00058214 File Offset: 0x00056414
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

		// Token: 0x06001F62 RID: 8034 RVA: 0x00058227 File Offset: 0x00056427
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

		// Token: 0x06001F63 RID: 8035 RVA: 0x0005823A File Offset: 0x0005643A
		public IPasserbyNpcSource_SetValue ToSetValue()
		{
			return new IPasserbyNpcSource_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x0005824D File Offset: 0x0005644D
		// (set) Token: 0x06001F65 RID: 8037 RVA: 0x00058278 File Offset: 0x00056478
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

		// Token: 0x04001632 RID: 5682
		[Nullable(2)]
		protected IPasserbyNpcSource FbInstance;

		// Token: 0x04001633 RID: 5683
		[Nullable(2)]
		protected IPasserbyNpcSource_SetValue PocoInterface;
	}
}
