using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007A8 RID: 1960
	[NullableContext(1)]
	[Nullable(0)]
	public class ITriggerMatchConfig
	{
		// Token: 0x06002A84 RID: 10884 RVA: 0x0006F848 File Offset: 0x0006DA48
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

		// Token: 0x06002A85 RID: 10885 RVA: 0x0006F880 File Offset: 0x0006DA80
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

		// Token: 0x06002A86 RID: 10886 RVA: 0x0006F893 File Offset: 0x0006DA93
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

		// Token: 0x06002A87 RID: 10887 RVA: 0x0006F8A6 File Offset: 0x0006DAA6
		public ITriggerMatchConfig_SetValue ToSetValue()
		{
			return new ITriggerMatchConfig_SetValue
			{
				EntityMatch = this.EntityMatch,
				EntityMatchCount = this.EntityMatchCount
			};
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06002A88 RID: 10888 RVA: 0x0006F8C5 File Offset: 0x0006DAC5
		// (set) Token: 0x06002A89 RID: 10889 RVA: 0x0006F8EC File Offset: 0x0006DAEC
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

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06002A8A RID: 10890 RVA: 0x0006F8FC File Offset: 0x0006DAFC
		// (set) Token: 0x06002A8B RID: 10891 RVA: 0x0006F936 File Offset: 0x0006DB36
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

		// Token: 0x04001C62 RID: 7266
		[Nullable(2)]
		protected ITriggerMatchConfig FbInstance;

		// Token: 0x04001C63 RID: 7267
		[Nullable(2)]
		protected ITriggerMatchConfig_SetValue PocoInterface;
	}
}
