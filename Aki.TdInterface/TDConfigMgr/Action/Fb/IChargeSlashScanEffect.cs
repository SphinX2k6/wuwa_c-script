using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D28 RID: 11560
	public class IChargeSlashScanEffect : ISpecificScanEffect
	{
		// Token: 0x0600FCAE RID: 64686 RVA: 0x00248809 File Offset: 0x00246A09
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

		// Token: 0x17004F0C RID: 20236
		// (get) Token: 0x0600FCAF RID: 64687 RVA: 0x00248828 File Offset: 0x00246A28
		public override ESpecificScanType Type
		{
			get
			{
				return (ESpecificScanType)this.Instance.Type;
			}
		}

		// Token: 0x17004F0D RID: 20237
		// (get) Token: 0x0600FCB0 RID: 64688 RVA: 0x00248835 File Offset: 0x00246A35
		public virtual int TriggerPosEntityId
		{
			get
			{
				return this.Instance.TriggerPosEntityId;
			}
		}

		// Token: 0x040089FA RID: 35322
		private IChargeSlashScanEffect Instance;
	}
}
