using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200225C RID: 8796
	[NullableContext(1)]
	[Nullable(0)]
	public class TriggerSpecificScanEffect : ActionParams
	{
		// Token: 0x0600C102 RID: 49410 RVA: 0x001BB1FC File Offset: 0x001B93FC
		private TriggerSpecificScanEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TriggerSpecificScanEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TriggerSpecificScanEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TriggerSpecificScanEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600C103 RID: 49411 RVA: 0x001BB234 File Offset: 0x001B9434
		public static TriggerSpecificScanEffect Create([Nullable(2)] TriggerSpecificScanEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TriggerSpecificScanEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C104 RID: 49412 RVA: 0x001BB247 File Offset: 0x001B9447
		public static TriggerSpecificScanEffect CreateFromSetValue([Nullable(2)] TriggerSpecificScanEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TriggerSpecificScanEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C105 RID: 49413 RVA: 0x001BB25A File Offset: 0x001B945A
		public TriggerSpecificScanEffect_SetValue ToSetValue()
		{
			return new TriggerSpecificScanEffect_SetValue
			{
				ScanEffect = this.ScanEffect
			};
		}

		// Token: 0x17003A64 RID: 14948
		// (get) Token: 0x0600C106 RID: 49414 RVA: 0x001BB26D File Offset: 0x001B946D
		// (set) Token: 0x0600C107 RID: 49415 RVA: 0x001BB294 File Offset: 0x001B9494
		public virtual ISpecificScanEffect ScanEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScanEffect;
				}
				TriggerSpecificScanEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ScanEffect;
			}
			set
			{
				this.GetOrCreatePoco().ScanEffect = value;
			}
		}

		// Token: 0x0400730A RID: 29450
		[Nullable(2)]
		protected new TriggerSpecificScanEffect FbInstance;

		// Token: 0x0400730B RID: 29451
		[Nullable(2)]
		protected TriggerSpecificScanEffect_SetValue PocoInterface;
	}
}
