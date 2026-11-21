using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000571 RID: 1393
	public class IMonsterNpcInteractionEnableConfig
	{
		// Token: 0x06001C2E RID: 7214 RVA: 0x000517D8 File Offset: 0x0004F9D8
		private IMonsterNpcInteractionEnableConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterNpcInteractionEnableConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterNpcInteractionEnableConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterNpcInteractionEnableConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x00051810 File Offset: 0x0004FA10
		public static IMonsterNpcInteractionEnableConfig Create([Nullable(2)] IMonsterNpcInteractionEnableConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionEnableConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x00051823 File Offset: 0x0004FA23
		public static IMonsterNpcInteractionEnableConfig CreateFromSetValue([Nullable(2)] IMonsterNpcInteractionEnableConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionEnableConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x00051836 File Offset: 0x0004FA36
		public IMonsterNpcInteractionEnableConfig_SetValue ToSetValue()
		{
			return new IMonsterNpcInteractionEnableConfig_SetValue
			{
				Interactions = this.Interactions
			};
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x00051849 File Offset: 0x0004FA49
		// (set) Token: 0x06001C33 RID: 7219 RVA: 0x00051870 File Offset: 0x0004FA70
		public virtual List<IMonsterNpcInteractionConfig> Interactions
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Interactions;
				}
				IMonsterNpcInteractionEnableConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Interactions;
			}
			set
			{
				this.GetOrCreatePoco().Interactions = value;
			}
		}

		// Token: 0x04001475 RID: 5237
		[Nullable(2)]
		protected IMonsterNpcInteractionEnableConfig FbInstance;

		// Token: 0x04001476 RID: 5238
		[Nullable(2)]
		protected IMonsterNpcInteractionEnableConfig_SetValue PocoInterface;
	}
}
