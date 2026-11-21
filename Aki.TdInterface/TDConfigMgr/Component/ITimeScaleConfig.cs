using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000820 RID: 2080
	public class ITimeScaleConfig
	{
		// Token: 0x06002CC6 RID: 11462 RVA: 0x00074E70 File Offset: 0x00073070
		private ITimeScaleConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeScaleConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeScaleConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeScaleConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x00074EA8 File Offset: 0x000730A8
		public static ITimeScaleConfig Create([Nullable(2)] ITimeScaleConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScaleConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x00074EBB File Offset: 0x000730BB
		public static ITimeScaleConfig CreateFromSetValue([Nullable(2)] ITimeScaleConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeScaleConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x00074ECE File Offset: 0x000730CE
		public ITimeScaleConfig_SetValue ToSetValue()
		{
			return new ITimeScaleConfig_SetValue
			{
				IgnoreGlobalTimeScale = this.IgnoreGlobalTimeScale
			};
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06002CCA RID: 11466 RVA: 0x00074EE1 File Offset: 0x000730E1
		// (set) Token: 0x06002CCB RID: 11467 RVA: 0x00074F0C File Offset: 0x0007310C
		public virtual bool IgnoreGlobalTimeScale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IgnoreGlobalTimeScale;
				}
				return this.PocoInterface != null && this.PocoInterface.IgnoreGlobalTimeScale;
			}
			set
			{
				this.GetOrCreatePoco().IgnoreGlobalTimeScale = value;
			}
		}

		// Token: 0x04001DF0 RID: 7664
		[Nullable(2)]
		protected ITimeScaleConfig FbInstance;

		// Token: 0x04001DF1 RID: 7665
		[Nullable(2)]
		protected ITimeScaleConfig_SetValue PocoInterface;
	}
}
