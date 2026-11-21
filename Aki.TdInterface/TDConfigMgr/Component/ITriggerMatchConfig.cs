using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000849 RID: 2121
	public class ITriggerMatchConfig
	{
		// Token: 0x06002DAC RID: 11692 RVA: 0x00076AF0 File Offset: 0x00074CF0
		private ITriggerMatchConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITriggerMatchConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITriggerMatchConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITriggerMatchConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x00076B28 File Offset: 0x00074D28
		public static ITriggerMatchConfig Create([Nullable(2)] ITriggerMatchConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggerMatchConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x00076B3B File Offset: 0x00074D3B
		public static ITriggerMatchConfig CreateFromSetValue([Nullable(2)] ITriggerMatchConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITriggerMatchConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x00076B4E File Offset: 0x00074D4E
		public ITriggerMatchConfig_SetValue ToSetValue()
		{
			return new ITriggerMatchConfig_SetValue
			{
				EntityMatch = this.EntityMatch,
				EntityMatchCount = this.EntityMatchCount
			};
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06002DB0 RID: 11696 RVA: 0x00076B6D File Offset: 0x00074D6D
		// (set) Token: 0x06002DB1 RID: 11697 RVA: 0x00076B94 File Offset: 0x00074D94
		public virtual IEntityMatchConfig EntityMatch
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityMatch;
				}
				ITriggerMatchConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityMatch;
			}
			set
			{
				this.GetOrCreatePoco().EntityMatch = value;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06002DB2 RID: 11698 RVA: 0x00076BA4 File Offset: 0x00074DA4
		// (set) Token: 0x06002DB3 RID: 11699 RVA: 0x00076BDE File Offset: 0x00074DDE
		public virtual int? EntityMatchCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityMatchCount;
				}
				ITriggerMatchConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityMatchCount;
			}
			set
			{
				this.GetOrCreatePoco().EntityMatchCount = value;
			}
		}

		// Token: 0x04001E6B RID: 7787
		[Nullable(2)]
		protected ITriggerMatchConfig FbInstance;

		// Token: 0x04001E6C RID: 7788
		[Nullable(2)]
		protected ITriggerMatchConfig_SetValue PocoInterface;
	}
}
