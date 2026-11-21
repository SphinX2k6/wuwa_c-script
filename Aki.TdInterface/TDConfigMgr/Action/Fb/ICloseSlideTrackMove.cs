using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BC1 RID: 11201
	public class ICloseSlideTrackMove : ICloseSplineMovePattern
	{
		// Token: 0x0600F6EE RID: 63214 RVA: 0x0023F68E File Offset: 0x0023D88E
		public static ICloseSlideTrackMove Create(ICloseSlideTrackMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseSlideTrackMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C1A RID: 19482
		// (get) Token: 0x0600F6EF RID: 63215 RVA: 0x0023F6AD File Offset: 0x0023D8AD
		public override ESplineMovePattern Type
		{
			get
			{
				return (ESplineMovePattern)this.Instance.Type;
			}
		}

		// Token: 0x17004C1B RID: 19483
		// (get) Token: 0x0600F6F0 RID: 63216 RVA: 0x0023F6BC File Offset: 0x0023D8BC
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

		// Token: 0x04008737 RID: 34615
		private ICloseSlideTrackMove Instance;
	}
}
