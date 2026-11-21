using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005D3 RID: 1491
	public class INpcPerformStateConfig
	{
		// Token: 0x06001E6C RID: 7788 RVA: 0x0005634C File Offset: 0x0005454C
		private INpcPerformStateConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcPerformStateConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcPerformStateConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcPerformStateConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00056384 File Offset: 0x00054584
		public static INpcPerformStateConfig Create([Nullable(2)] INpcPerformStateConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcPerformStateConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00056397 File Offset: 0x00054597
		public static INpcPerformStateConfig CreateFromSetValue([Nullable(2)] INpcPerformStateConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcPerformStateConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x000563AA File Offset: 0x000545AA
		public INpcPerformStateConfig_SetValue ToSetValue()
		{
			return new INpcPerformStateConfig_SetValue
			{
				State = this.State,
				MaterialDa = this.MaterialDa,
				BuffEffectIds = this.BuffEffectIds
			};
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x000563D5 File Offset: 0x000545D5
		// (set) Token: 0x06001E71 RID: 7793 RVA: 0x00056400 File Offset: 0x00054600
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x0005640E File Offset: 0x0005460E
		// (set) Token: 0x06001E73 RID: 7795 RVA: 0x00056435 File Offset: 0x00054635
		[Nullable(2)]
		public virtual string MaterialDa
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaterialDa;
				}
				INpcPerformStateConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaterialDa;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MaterialDa = value;
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x00056443 File Offset: 0x00054643
		// (set) Token: 0x06001E75 RID: 7797 RVA: 0x0005646A File Offset: 0x0005466A
		[Nullable(2)]
		public virtual List<int> BuffEffectIds
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BuffEffectIds;
				}
				INpcPerformStateConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BuffEffectIds;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().BuffEffectIds = value;
			}
		}

		// Token: 0x040015B7 RID: 5559
		[Nullable(2)]
		protected INpcPerformStateConfig FbInstance;

		// Token: 0x040015B8 RID: 5560
		[Nullable(2)]
		protected INpcPerformStateConfig_SetValue PocoInterface;
	}
}
