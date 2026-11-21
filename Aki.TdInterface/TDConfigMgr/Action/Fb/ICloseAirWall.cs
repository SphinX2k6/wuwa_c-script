using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BED RID: 11245
	public class ICloseAirWall : IToggleAirWallType
	{
		// Token: 0x0600F7B4 RID: 63412 RVA: 0x00240B33 File Offset: 0x0023ED33
		public static ICloseAirWall Create(ICloseAirWall? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseAirWall
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C88 RID: 19592
		// (get) Token: 0x0600F7B5 RID: 63413 RVA: 0x00240B52 File Offset: 0x0023ED52
		public override EToggleAirWall Type
		{
			get
			{
				return (EToggleAirWall)this.Instance.Type;
			}
		}

		// Token: 0x0400879F RID: 34719
		private ICloseAirWall Instance;
	}
}
