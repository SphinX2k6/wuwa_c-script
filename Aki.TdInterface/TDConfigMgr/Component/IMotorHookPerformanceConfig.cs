using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200052A RID: 1322
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorHookPerformanceConfig
	{
		// Token: 0x06001AE4 RID: 6884 RVA: 0x0004E060 File Offset: 0x0004C260
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

		// Token: 0x06001AE5 RID: 6885 RVA: 0x0004E098 File Offset: 0x0004C298
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

		// Token: 0x06001AE6 RID: 6886 RVA: 0x0004E0AB File Offset: 0x0004C2AB
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

		// Token: 0x06001AE7 RID: 6887 RVA: 0x0004E0BE File Offset: 0x0004C2BE
		public IMotorHookPerformanceConfig_SetValue ToSetValue()
		{
			return new IMotorHookPerformanceConfig_SetValue
			{
				HookEffectBuffId = this.HookEffectBuffId
			};
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x0004E0D4 File Offset: 0x0004C2D4
		// (set) Token: 0x06001AE9 RID: 6889 RVA: 0x0004E10E File Offset: 0x0004C30E
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

		// Token: 0x0400136A RID: 4970
		[Nullable(2)]
		protected IMotorHookPerformanceConfig FbInstance;

		// Token: 0x0400136B RID: 4971
		[Nullable(2)]
		protected IMotorHookPerformanceConfig_SetValue PocoInterface;
	}
}
