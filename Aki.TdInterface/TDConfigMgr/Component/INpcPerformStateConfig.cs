using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200056C RID: 1388
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcPerformStateConfig
	{
		// Token: 0x06001C70 RID: 7280 RVA: 0x00051590 File Offset: 0x0004F790
		[NullableContext(1)]
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

		// Token: 0x06001C71 RID: 7281 RVA: 0x000515C8 File Offset: 0x0004F7C8
		[NullableContext(1)]
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

		// Token: 0x06001C72 RID: 7282 RVA: 0x000515DB File Offset: 0x0004F7DB
		[NullableContext(1)]
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

		// Token: 0x06001C73 RID: 7283 RVA: 0x000515EE File Offset: 0x0004F7EE
		[NullableContext(1)]
		public INpcPerformStateConfig_SetValue ToSetValue()
		{
			return new INpcPerformStateConfig_SetValue
			{
				State = this.State,
				MaterialDa = this.MaterialDa,
				BuffEffectIds = this.BuffEffectIds
			};
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x00051619 File Offset: 0x0004F819
		// (set) Token: 0x06001C75 RID: 7285 RVA: 0x00051644 File Offset: 0x0004F844
		[Nullable(1)]
		public virtual string State
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001C76 RID: 7286 RVA: 0x00051652 File Offset: 0x0004F852
		// (set) Token: 0x06001C77 RID: 7287 RVA: 0x00051679 File Offset: 0x0004F879
		public virtual string MaterialDa
		{
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
			set
			{
				this.GetOrCreatePoco().MaterialDa = value;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x00051687 File Offset: 0x0004F887
		// (set) Token: 0x06001C79 RID: 7289 RVA: 0x000516AE File Offset: 0x0004F8AE
		public virtual List<int> BuffEffectIds
		{
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
			set
			{
				this.GetOrCreatePoco().BuffEffectIds = value;
			}
		}

		// Token: 0x0400144D RID: 5197
		protected INpcPerformStateConfig FbInstance;

		// Token: 0x0400144E RID: 5198
		protected INpcPerformStateConfig_SetValue PocoInterface;
	}
}
