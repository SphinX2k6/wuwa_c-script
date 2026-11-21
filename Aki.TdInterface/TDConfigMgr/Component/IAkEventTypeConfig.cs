using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001DC RID: 476
	public class IAkEventTypeConfig
	{
		// Token: 0x0600074C RID: 1868 RVA: 0x00025420 File Offset: 0x00023620
		private IAkEventTypeConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAkEventTypeConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAkEventTypeConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAkEventTypeConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00025458 File Offset: 0x00023658
		public static IAkEventTypeConfig Create([Nullable(2)] IAkEventTypeConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAkEventTypeConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0002546B File Offset: 0x0002366B
		public static IAkEventTypeConfig CreateFromSetValue([Nullable(2)] IAkEventTypeConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAkEventTypeConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0002547E File Offset: 0x0002367E
		public IAkEventTypeConfig_SetValue ToSetValue()
		{
			return new IAkEventTypeConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00025491 File Offset: 0x00023691
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x000254BC File Offset: 0x000236BC
		public virtual EAkEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAkEventType.Point;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040008D8 RID: 2264
		[Nullable(2)]
		protected IAkEventTypeConfig FbInstance;

		// Token: 0x040008D9 RID: 2265
		[Nullable(2)]
		protected IAkEventTypeConfig_SetValue PocoInterface;
	}
}
