using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BBD RID: 11197
	public class ICloseAirPassageMove : ICloseSplineMovePattern
	{
		// Token: 0x0600F6DE RID: 63198 RVA: 0x0023F4DE File Offset: 0x0023D6DE
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

		// Token: 0x17004C12 RID: 19474
		// (get) Token: 0x0600F6DF RID: 63199 RVA: 0x0023F4FD File Offset: 0x0023D6FD
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004C13 RID: 19475
		// (get) Token: 0x0600F6E0 RID: 63200 RVA: 0x0023F50C File Offset: 0x0023D70C
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

		// Token: 0x04008733 RID: 34611
		private ICloseAirPassageMove Instance;
	}
}
