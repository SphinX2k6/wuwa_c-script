using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BBE RID: 11198
	public class ICloseMotorcycleTrackMove : ICloseSplineMovePattern
	{
		// Token: 0x0600F6E2 RID: 63202 RVA: 0x0023F54A File Offset: 0x0023D74A
		public static ICloseMotorcycleTrackMove Create(ICloseMotorcycleTrackMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseMotorcycleTrackMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C14 RID: 19476
		// (get) Token: 0x0600F6E3 RID: 63203 RVA: 0x0023F569 File Offset: 0x0023D769
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004C15 RID: 19477
		// (get) Token: 0x0600F6E4 RID: 63204 RVA: 0x0023F578 File Offset: 0x0023D778
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.GravitySwitchAngularVelocity);
			}
		}

		// Token: 0x04008734 RID: 34612
		private ICloseMotorcycleTrackMove Instance;
	}
}
