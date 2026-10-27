using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000444 RID: 1092
	[NullableContext(1)]
	[Nullable(0)]
	public class IHookPerformanceConfig
	{
		// Token: 0x0600160B RID: 5643 RVA: 0x00044690 File Offset: 0x00042890
		private IHookPerformanceConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHookPerformanceConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHookPerformanceConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHookPerformanceConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x000446C8 File Offset: 0x000428C8
		public static IHookPerformanceConfig Create([Nullable(2)] IHookPerformanceConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookPerformanceConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x000446DB File Offset: 0x000428DB
		public static IHookPerformanceConfig CreateFromSetValue([Nullable(2)] IHookPerformanceConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHookPerformanceConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x000446EE File Offset: 0x000428EE
		public IHookPerformanceConfig_SetValue ToSetValue()
		{
			return new IHookPerformanceConfig_SetValue
			{
				HookEffectBuffId = this.HookEffectBuffId
			};
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x00044704 File Offset: 0x00042904
		// (set) Token: 0x06001610 RID: 5648 RVA: 0x0004473E File Offset: 0x0004293E
		public virtual long? HookEffectBuffId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HookEffectBuffId;
				}
				IHookPerformanceConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HookEffectBuffId;
			}
			set
			{
				this.GetOrCreatePoco().HookEffectBuffId = value;
			}
		}

		// Token: 0x040010E6 RID: 4326
		[Nullable(2)]
		protected IHookPerformanceConfig FbInstance;

		// Token: 0x040010E7 RID: 4327
		[Nullable(2)]
		protected IHookPerformanceConfig_SetValue PocoInterface;
	}
}
