using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A3B RID: 10811
	public class IChargeSlashScanEffect : ISpecificScanEffect
	{
		// Token: 0x0600EE16 RID: 60950 RVA: 0x0022AE55 File Offset: 0x00229055
		[NullableContext(1)]
		public static IChargeSlashScanEffect Create(IChargeSlashScanEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChargeSlashScanEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B62 RID: 19298
		// (get) Token: 0x0600EE17 RID: 60951 RVA: 0x0022AE74 File Offset: 0x00229074
		public override ESpecificScanType Type
		{
			get
			{
				return (ESpecificScanType)this.Instance.Type;
			}
		}

		// Token: 0x17004B63 RID: 19299
		// (get) Token: 0x0600EE18 RID: 60952 RVA: 0x0022AE81 File Offset: 0x00229081
		public virtual int TriggerPosEntityId
		{
			get
			{
				return this.Instance.TriggerPosEntityId;
			}
		}

		// Token: 0x04008307 RID: 33543
		private IChargeSlashScanEffect Instance;
	}
}
