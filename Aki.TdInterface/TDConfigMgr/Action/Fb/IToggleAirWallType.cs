using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BEB RID: 11243
	public class IToggleAirWallType
	{
		// Token: 0x0600F7A6 RID: 63398 RVA: 0x002409BB File Offset: 0x0023EBBB
		public static IToggleAirWallType Create(IToggleAirWallType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IToggleAirWallType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C7E RID: 19582
		// (get) Token: 0x0600F7A7 RID: 63399 RVA: 0x002409DA File Offset: 0x0023EBDA
		public virtual EToggleAirWall Type
		{
			get
			{
				return (EToggleAirWall)this.Instance.Type;
			}
		}

		// Token: 0x0400879D RID: 34717
		private IToggleAirWallType Instance;
	}
}
