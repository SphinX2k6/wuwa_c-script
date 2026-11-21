using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000805 RID: 2053
	public class IThrowCfg
	{
		// Token: 0x06002C09 RID: 11273 RVA: 0x0007346C File Offset: 0x0007166C
		private IThrowCfg_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IThrowCfg 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IThrowCfg_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IThrowCfg_SetValue());
			}
			return result;
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x000734A4 File Offset: 0x000716A4
		public static IThrowCfg Create([Nullable(2)] IThrowCfg instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IThrowCfg
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x000734B7 File Offset: 0x000716B7
		public static IThrowCfg CreateFromSetValue([Nullable(2)] IThrowCfg_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IThrowCfg
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x000734CA File Offset: 0x000716CA
		public IThrowCfg_SetValue ToSetValue()
		{
			return new IThrowCfg_SetValue
			{
				MotionConfig = this.MotionConfig
			};
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06002C0D RID: 11277 RVA: 0x000734DD File Offset: 0x000716DD
		// (set) Token: 0x06002C0E RID: 11278 RVA: 0x00073504 File Offset: 0x00071704
		public virtual IThrowMotion MotionConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MotionConfig;
				}
				IThrowCfg_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MotionConfig;
			}
			set
			{
				this.GetOrCreatePoco().MotionConfig = value;
			}
		}

		// Token: 0x04001D83 RID: 7555
		[Nullable(2)]
		protected IThrowCfg FbInstance;

		// Token: 0x04001D84 RID: 7556
		[Nullable(2)]
		protected IThrowCfg_SetValue PocoInterface;
	}
}
