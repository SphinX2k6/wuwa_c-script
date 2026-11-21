using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DC9 RID: 11721
	public class ISceneItemRoadNetworkNavigation : IRoadNetworkNavigationTarget
	{
		// Token: 0x0600FF30 RID: 65328 RVA: 0x0024C7F5 File Offset: 0x0024A9F5
		public static ISceneItemRoadNetworkNavigation Create(ISceneItemRoadNetworkNavigation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemRoadNetworkNavigation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700504C RID: 20556
		// (get) Token: 0x0600FF31 RID: 65329 RVA: 0x0024C814 File Offset: 0x0024AA14
		public override ERoadNetworkNavigationTarget Type
		{
			get
			{
				return (ERoadNetworkNavigationTarget)this.Instance.Type;
			}
		}

		// Token: 0x1700504D RID: 20557
		// (get) Token: 0x0600FF32 RID: 65330 RVA: 0x0024C821 File Offset: 0x0024AA21
		public virtual int TargetId
		{
			get
			{
				return this.Instance.TargetId;
			}
		}

		// Token: 0x04008B4B RID: 35659
		private ISceneItemRoadNetworkNavigation Instance;
	}
}
