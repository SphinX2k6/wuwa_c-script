using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006D6 RID: 1750
	[NullableContext(1)]
	[Nullable(0)]
	public class ISkyboxTrigger
	{
		// Token: 0x060025A6 RID: 9638 RVA: 0x000653BC File Offset: 0x000635BC
		private ISkyboxTrigger_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISkyboxTrigger 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISkyboxTrigger_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISkyboxTrigger_SetValue());
			}
			return result;
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x000653F4 File Offset: 0x000635F4
		public static ISkyboxTrigger Create([Nullable(2)] ISkyboxTrigger instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkyboxTrigger
			{
				FbInstance = instance
			};
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x00065407 File Offset: 0x00063607
		public static ISkyboxTrigger CreateFromSetValue([Nullable(2)] ISkyboxTrigger_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISkyboxTrigger
			{
				PocoInterface = value
			};
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x0006541A File Offset: 0x0006361A
		public ISkyboxTrigger_SetValue ToSetValue()
		{
			return new ISkyboxTrigger_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x0006542D File Offset: 0x0006362D
		// (set) Token: 0x060025AB RID: 9643 RVA: 0x00065458 File Offset: 0x00063658
		public virtual ETriggerMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETriggerMode.Distance;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040019A9 RID: 6569
		[Nullable(2)]
		protected ISkyboxTrigger FbInstance;

		// Token: 0x040019AA RID: 6570
		[Nullable(2)]
		protected ISkyboxTrigger_SetValue PocoInterface;
	}
}
