using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004C6 RID: 1222
	[NullableContext(1)]
	[Nullable(0)]
	public class ILifeStageConfig
	{
		// Token: 0x060018D4 RID: 6356 RVA: 0x0004A07C File Offset: 0x0004827C
		private ILifeStageConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILifeStageConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILifeStageConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILifeStageConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0004A0B4 File Offset: 0x000482B4
		public static ILifeStageConfig Create([Nullable(2)] ILifeStageConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILifeStageConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0004A0C7 File Offset: 0x000482C7
		public static ILifeStageConfig CreateFromSetValue([Nullable(2)] ILifeStageConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILifeStageConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0004A0DA File Offset: 0x000482DA
		public ILifeStageConfig_SetValue ToSetValue()
		{
			return new ILifeStageConfig_SetValue
			{
				PerformDuration = this.PerformDuration
			};
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x0004A0F0 File Offset: 0x000482F0
		// (set) Token: 0x060018D9 RID: 6361 RVA: 0x0004A12A File Offset: 0x0004832A
		public virtual float? PerformDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformDuration;
				}
				ILifeStageConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PerformDuration;
			}
			set
			{
				this.GetOrCreatePoco().PerformDuration = value;
			}
		}

		// Token: 0x0400125E RID: 4702
		[Nullable(2)]
		protected ILifeStageConfig FbInstance;

		// Token: 0x0400125F RID: 4703
		[Nullable(2)]
		protected ILifeStageConfig_SetValue PocoInterface;
	}
}
