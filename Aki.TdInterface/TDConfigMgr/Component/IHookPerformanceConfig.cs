using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200049D RID: 1181
	public class IHookPerformanceConfig
	{
		// Token: 0x060017A5 RID: 6053 RVA: 0x000483D8 File Offset: 0x000465D8
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

		// Token: 0x060017A6 RID: 6054 RVA: 0x00048410 File Offset: 0x00046610
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

		// Token: 0x060017A7 RID: 6055 RVA: 0x00048423 File Offset: 0x00046623
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

		// Token: 0x060017A8 RID: 6056 RVA: 0x00048436 File Offset: 0x00046636
		public IHookPerformanceConfig_SetValue ToSetValue()
		{
			return new IHookPerformanceConfig_SetValue
			{
				HookEffectBuffId = this.HookEffectBuffId
			};
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x0004844C File Offset: 0x0004664C
		// (set) Token: 0x060017AA RID: 6058 RVA: 0x00048486 File Offset: 0x00046686
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

		// Token: 0x04001208 RID: 4616
		[Nullable(2)]
		protected IHookPerformanceConfig FbInstance;

		// Token: 0x04001209 RID: 4617
		[Nullable(2)]
		protected IHookPerformanceConfig_SetValue PocoInterface;
	}
}
