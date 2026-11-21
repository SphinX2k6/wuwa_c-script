using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000843 RID: 2115
	public class ITriggerCountConfig
	{
		// Token: 0x06002D80 RID: 11648 RVA: 0x00076434 File Offset: 0x00074634
		private ITriggerCountConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITriggerCountConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITriggerCountConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITriggerCountConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x0007646C File Offset: 0x0007466C
		public static ITriggerCountConfig Create([Nullable(2)] ITriggerCountConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggerCountConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x0007647F File Offset: 0x0007467F
		public static ITriggerCountConfig CreateFromSetValue([Nullable(2)] ITriggerCountConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITriggerCountConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x00076492 File Offset: 0x00074692
		public ITriggerCountConfig_SetValue ToSetValue()
		{
			return new ITriggerCountConfig_SetValue
			{
				TriggerCount = this.TriggerCount,
				TriggerInterval = this.TriggerInterval
			};
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06002D84 RID: 11652 RVA: 0x000764B1 File Offset: 0x000746B1
		// (set) Token: 0x06002D85 RID: 11653 RVA: 0x000764DC File Offset: 0x000746DC
		public virtual int TriggerCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TriggerCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TriggerCount;
			}
			set
			{
				this.GetOrCreatePoco().TriggerCount = value;
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06002D86 RID: 11654 RVA: 0x000764EA File Offset: 0x000746EA
		// (set) Token: 0x06002D87 RID: 11655 RVA: 0x00076519 File Offset: 0x00074719
		public virtual float TriggerInterval
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TriggerInterval;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TriggerInterval;
			}
			set
			{
				this.GetOrCreatePoco().TriggerInterval = value;
			}
		}

		// Token: 0x04001E50 RID: 7760
		[Nullable(2)]
		protected ITriggerCountConfig FbInstance;

		// Token: 0x04001E51 RID: 7761
		[Nullable(2)]
		protected ITriggerCountConfig_SetValue PocoInterface;
	}
}
