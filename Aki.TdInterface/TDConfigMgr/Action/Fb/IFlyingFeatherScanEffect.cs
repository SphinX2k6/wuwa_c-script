using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D29 RID: 11561
	public class IFlyingFeatherScanEffect : ISpecificScanEffect
	{
		// Token: 0x0600FCB2 RID: 64690 RVA: 0x0024884A File Offset: 0x00246A4A
		public static IFlyingFeatherScanEffect Create(IFlyingFeatherScanEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlyingFeatherScanEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F0E RID: 20238
		// (get) Token: 0x0600FCB3 RID: 64691 RVA: 0x00248869 File Offset: 0x00246A69
		public override ESpecificScanType Type
		{
			get
			{
				return (ESpecificScanType)this.Instance.Type;
			}
		}

		// Token: 0x17004F0F RID: 20239
		// (get) Token: 0x0600FCB4 RID: 64692 RVA: 0x00248876 File Offset: 0x00246A76
		public virtual int TriggerPosEntityId
		{
			get
			{
				return this.Instance.TriggerPosEntityId;
			}
		}

		// Token: 0x040089FB RID: 35323
		private IFlyingFeatherScanEffect Instance;
	}
}
