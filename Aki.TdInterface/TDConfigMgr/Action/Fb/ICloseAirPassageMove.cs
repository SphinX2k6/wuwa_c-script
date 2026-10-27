using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028E5 RID: 10469
	public class ICloseAirPassageMove : ICloseSplineMovePattern
	{
		// Token: 0x0600E89D RID: 59549 RVA: 0x00222326 File Offset: 0x00220526
		[NullableContext(1)]
		public static ICloseAirPassageMove Create(ICloseAirPassageMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseAirPassageMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004895 RID: 18581
		// (get) Token: 0x0600E89E RID: 59550 RVA: 0x00222345 File Offset: 0x00220545
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004896 RID: 18582
		// (get) Token: 0x0600E89F RID: 59551 RVA: 0x00222354 File Offset: 0x00220554
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

		// Token: 0x0400806F RID: 32879
		private ICloseAirPassageMove Instance;
	}
}
