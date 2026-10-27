using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200290F RID: 10511
	public class IToggleAirWallType
	{
		// Token: 0x0600E955 RID: 59733 RVA: 0x0022369B File Offset: 0x0022189B
		[NullableContext(1)]
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

		// Token: 0x170048F9 RID: 18681
		// (get) Token: 0x0600E956 RID: 59734 RVA: 0x002236BA File Offset: 0x002218BA
		public virtual EToggleAirWall Type
		{
			get
			{
				return (EToggleAirWall)this.Instance.Type;
			}
		}

		// Token: 0x040080CF RID: 32975
		private IToggleAirWallType Instance;
	}
}
