using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BC0 RID: 11200
	public class ICloseRacingTrackMove : ICloseSplineMovePattern
	{
		// Token: 0x0600F6EA RID: 63210 RVA: 0x0023F622 File Offset: 0x0023D822
		public static ICloseRacingTrackMove Create(ICloseRacingTrackMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseRacingTrackMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C18 RID: 19480
		// (get) Token: 0x0600F6EB RID: 63211 RVA: 0x0023F641 File Offset: 0x0023D841
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004C19 RID: 19481
		// (get) Token: 0x0600F6EC RID: 63212 RVA: 0x0023F650 File Offset: 0x0023D850
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

		// Token: 0x04008736 RID: 34614
		private ICloseRacingTrackMove Instance;
	}
}
