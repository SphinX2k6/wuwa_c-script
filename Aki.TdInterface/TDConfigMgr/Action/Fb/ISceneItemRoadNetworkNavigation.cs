using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD5 RID: 10965
	public class ISceneItemRoadNetworkNavigation : IRoadNetworkNavigationTarget
	{
		// Token: 0x0600F07A RID: 61562 RVA: 0x0022EAE9 File Offset: 0x0022CCE9
		[NullableContext(1)]
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

		// Token: 0x17004C92 RID: 19602
		// (get) Token: 0x0600F07B RID: 61563 RVA: 0x0022EB08 File Offset: 0x0022CD08
		public override ERoadNetworkNavigationTarget Type
		{
			get
			{
				return (ERoadNetworkNavigationTarget)this.Instance.Type;
			}
		}

		// Token: 0x17004C93 RID: 19603
		// (get) Token: 0x0600F07C RID: 61564 RVA: 0x0022EB15 File Offset: 0x0022CD15
		public virtual int TargetId
		{
			get
			{
				return this.Instance.TargetId;
			}
		}

		// Token: 0x04008447 RID: 33863
		private ISceneItemRoadNetworkNavigation Instance;
	}
}
