using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007CE RID: 1998
	public class IStreamingWaitConfig
	{
		// Token: 0x06002ACD RID: 10957 RVA: 0x00070878 File Offset: 0x0006EA78
		private IStreamingWaitConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStreamingWaitConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStreamingWaitConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStreamingWaitConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x000708B0 File Offset: 0x0006EAB0
		public static IStreamingWaitConfig Create([Nullable(2)] IStreamingWaitConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStreamingWaitConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x000708C3 File Offset: 0x0006EAC3
		public static IStreamingWaitConfig CreateFromSetValue([Nullable(2)] IStreamingWaitConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStreamingWaitConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x000708D6 File Offset: 0x0006EAD6
		public IStreamingWaitConfig_SetValue ToSetValue()
		{
			return new IStreamingWaitConfig_SetValue
			{
				MinWaitStreamDuration = this.MinWaitStreamDuration,
				MaxWaitStreamDuration = this.MaxWaitStreamDuration
			};
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002AD1 RID: 10961 RVA: 0x000708F5 File Offset: 0x0006EAF5
		// (set) Token: 0x06002AD2 RID: 10962 RVA: 0x00070924 File Offset: 0x0006EB24
		public virtual float MinWaitStreamDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinWaitStreamDuration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MinWaitStreamDuration;
			}
			set
			{
				this.GetOrCreatePoco().MinWaitStreamDuration = value;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x00070932 File Offset: 0x0006EB32
		// (set) Token: 0x06002AD4 RID: 10964 RVA: 0x00070961 File Offset: 0x0006EB61
		public virtual float MaxWaitStreamDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxWaitStreamDuration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxWaitStreamDuration;
			}
			set
			{
				this.GetOrCreatePoco().MaxWaitStreamDuration = value;
			}
		}

		// Token: 0x04001CC4 RID: 7364
		[Nullable(2)]
		protected IStreamingWaitConfig FbInstance;

		// Token: 0x04001CC5 RID: 7365
		[Nullable(2)]
		protected IStreamingWaitConfig_SetValue PocoInterface;
	}
}
