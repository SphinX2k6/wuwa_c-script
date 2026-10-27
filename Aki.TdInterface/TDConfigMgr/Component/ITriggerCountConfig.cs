using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007A2 RID: 1954
	[NullableContext(1)]
	[Nullable(0)]
	public class ITriggerCountConfig
	{
		// Token: 0x06002A58 RID: 10840 RVA: 0x0006F18C File Offset: 0x0006D38C
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

		// Token: 0x06002A59 RID: 10841 RVA: 0x0006F1C4 File Offset: 0x0006D3C4
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

		// Token: 0x06002A5A RID: 10842 RVA: 0x0006F1D7 File Offset: 0x0006D3D7
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

		// Token: 0x06002A5B RID: 10843 RVA: 0x0006F1EA File Offset: 0x0006D3EA
		public ITriggerCountConfig_SetValue ToSetValue()
		{
			return new ITriggerCountConfig_SetValue
			{
				TriggerCount = this.TriggerCount,
				TriggerInterval = this.TriggerInterval
			};
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x0006F209 File Offset: 0x0006D409
		// (set) Token: 0x06002A5D RID: 10845 RVA: 0x0006F234 File Offset: 0x0006D434
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

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x0006F242 File Offset: 0x0006D442
		// (set) Token: 0x06002A5F RID: 10847 RVA: 0x0006F271 File Offset: 0x0006D471
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

		// Token: 0x04001C47 RID: 7239
		[Nullable(2)]
		protected ITriggerCountConfig FbInstance;

		// Token: 0x04001C48 RID: 7240
		[Nullable(2)]
		protected ITriggerCountConfig_SetValue PocoInterface;
	}
}
