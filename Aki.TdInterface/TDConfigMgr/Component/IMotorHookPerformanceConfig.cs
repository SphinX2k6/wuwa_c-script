using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000591 RID: 1425
	public class IMotorHookPerformanceConfig
	{
		// Token: 0x06001CE0 RID: 7392 RVA: 0x00052E1C File Offset: 0x0005101C
		private IMotorHookPerformanceConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorHookPerformanceConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorHookPerformanceConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorHookPerformanceConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x00052E54 File Offset: 0x00051054
		public static IMotorHookPerformanceConfig Create([Nullable(2)] IMotorHookPerformanceConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorHookPerformanceConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x00052E67 File Offset: 0x00051067
		public static IMotorHookPerformanceConfig CreateFromSetValue([Nullable(2)] IMotorHookPerformanceConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorHookPerformanceConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x00052E7A File Offset: 0x0005107A
		public IMotorHookPerformanceConfig_SetValue ToSetValue()
		{
			return new IMotorHookPerformanceConfig_SetValue
			{
				HookEffectBuffId = this.HookEffectBuffId
			};
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x00052E90 File Offset: 0x00051090
		// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x00052ECA File Offset: 0x000510CA
		public virtual long? HookEffectBuffId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HookEffectBuffId;
				}
				IMotorHookPerformanceConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040014D4 RID: 5332
		[Nullable(2)]
		protected IMotorHookPerformanceConfig FbInstance;

		// Token: 0x040014D5 RID: 5333
		[Nullable(2)]
		protected IMotorHookPerformanceConfig_SetValue PocoInterface;
	}
}
