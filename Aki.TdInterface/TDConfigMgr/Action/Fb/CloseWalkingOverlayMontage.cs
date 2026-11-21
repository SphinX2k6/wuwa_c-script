using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D92 RID: 11666
	public class CloseWalkingOverlayMontage : ActionParams
	{
		// Token: 0x0600FE51 RID: 65105 RVA: 0x0024B0C9 File Offset: 0x002492C9
		public static CloseWalkingOverlayMontage Create(ICloseWalkingOverlayMontage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CloseWalkingOverlayMontage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FDB RID: 20443
		// (get) Token: 0x0600FE52 RID: 65106 RVA: 0x0024B0E8 File Offset: 0x002492E8
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04008AD0 RID: 35536
		private ICloseWalkingOverlayMontage Instance;
	}
}
