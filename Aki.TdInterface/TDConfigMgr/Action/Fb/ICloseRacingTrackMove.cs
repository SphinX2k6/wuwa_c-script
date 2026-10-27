using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028E8 RID: 10472
	public class ICloseRacingTrackMove : ICloseSplineMovePattern
	{
		// Token: 0x0600E8A9 RID: 59561 RVA: 0x0022246A File Offset: 0x0022066A
		[NullableContext(1)]
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

		// Token: 0x1700489B RID: 18587
		// (get) Token: 0x0600E8AA RID: 59562 RVA: 0x00222489 File Offset: 0x00220689
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x1700489C RID: 18588
		// (get) Token: 0x0600E8AB RID: 59563 RVA: 0x00222498 File Offset: 0x00220698
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

		// Token: 0x04008072 RID: 32882
		private ICloseRacingTrackMove Instance;
	}
}
