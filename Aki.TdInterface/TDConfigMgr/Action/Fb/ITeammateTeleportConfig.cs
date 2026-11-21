using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200297D RID: 10621
	public class ITeammateTeleportConfig
	{
		// Token: 0x0600EB9E RID: 60318 RVA: 0x0022B562 File Offset: 0x00229762
		public static ITeammateTeleportConfig Create(ITeammateTeleportConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeammateTeleportConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004552 RID: 17746
		// (get) Token: 0x0600EB9F RID: 60319 RVA: 0x0022B581 File Offset: 0x00229781
		public virtual ETeammateTeleportType Type
		{
			get
			{
				return (ETeammateTeleportType)this.Instance.Type;
			}
		}

		// Token: 0x040081BD RID: 33213
		private ITeammateTeleportConfig Instance;
	}
}
