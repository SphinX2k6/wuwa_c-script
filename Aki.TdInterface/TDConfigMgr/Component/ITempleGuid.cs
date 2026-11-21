using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000803 RID: 2051
	public class ITempleGuid
	{
		// Token: 0x06002C01 RID: 11265 RVA: 0x000733B0 File Offset: 0x000715B0
		private ITempleGuid_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITempleGuid 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITempleGuid_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITempleGuid_SetValue());
			}
			return result;
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x000733E8 File Offset: 0x000715E8
		public static ITempleGuid Create([Nullable(2)] ITempleGuid instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITempleGuid
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x000733FB File Offset: 0x000715FB
		public static ITempleGuid CreateFromSetValue([Nullable(2)] ITempleGuid_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITempleGuid
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x0007340E File Offset: 0x0007160E
		public ITempleGuid_SetValue ToSetValue()
		{
			return new ITempleGuid_SetValue
			{
				TempleGuid = this.TempleGuid
			};
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06002C05 RID: 11269 RVA: 0x00073421 File Offset: 0x00071621
		// (set) Token: 0x06002C06 RID: 11270 RVA: 0x0007344C File Offset: 0x0007164C
		public virtual int TempleGuid
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TempleGuid;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TempleGuid;
			}
			set
			{
				this.GetOrCreatePoco().TempleGuid = value;
			}
		}

		// Token: 0x04001D80 RID: 7552
		[Nullable(2)]
		protected ITempleGuid FbInstance;

		// Token: 0x04001D81 RID: 7553
		[Nullable(2)]
		protected ITempleGuid_SetValue PocoInterface;
	}
}
