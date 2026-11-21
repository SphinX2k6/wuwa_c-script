using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024C9 RID: 9417
	public class TriggerSpecificScanEffect : ActionParams
	{
		// Token: 0x0600CCC8 RID: 52424 RVA: 0x001D2980 File Offset: 0x001D0B80
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

		// Token: 0x0600CCC9 RID: 52425 RVA: 0x001D29B8 File Offset: 0x001D0BB8
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

		// Token: 0x0600CCCA RID: 52426 RVA: 0x001D29CB File Offset: 0x001D0BCB
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

		// Token: 0x0600CCCB RID: 52427 RVA: 0x001D29DE File Offset: 0x001D0BDE
		public TriggerSpecificScanEffect_SetValue ToSetValue()
		{
			return new TriggerSpecificScanEffect_SetValue
			{
				ScanEffect = this.ScanEffect
			};
		}

		// Token: 0x17003D5B RID: 15707
		// (get) Token: 0x0600CCCC RID: 52428 RVA: 0x001D29F1 File Offset: 0x001D0BF1
		// (set) Token: 0x0600CCCD RID: 52429 RVA: 0x001D2A18 File Offset: 0x001D0C18
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

		// Token: 0x04007957 RID: 31063
		[Nullable(2)]
		protected new TriggerSpecificScanEffect FbInstance;

		// Token: 0x04007958 RID: 31064
		[Nullable(2)]
		protected TriggerSpecificScanEffect_SetValue PocoInterface;
	}
}
