using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200765B RID: 30299
	public class IRoadNetworkNavigationTarget_UnionUnion
	{
		// Token: 0x1700DE7A RID: 56954
		// (get) Token: 0x0603528B RID: 217739 RVA: 0x00722F81 File Offset: 0x00721181
		// (set) Token: 0x0603528C RID: 217740 RVA: 0x00722F89 File Offset: 0x00721189
		public IRoadNetworkNavigationTarget_Union Type { get; set; }

		// Token: 0x1700DE7B RID: 56955
		// (get) Token: 0x0603528D RID: 217741 RVA: 0x00722F92 File Offset: 0x00721192
		// (set) Token: 0x0603528E RID: 217742 RVA: 0x00722F9A File Offset: 0x0072119A
		public object Value { get; set; }

		// Token: 0x0603528F RID: 217743 RVA: 0x00722FA3 File Offset: 0x007211A3
		public IRoadNetworkNavigationTarget_UnionUnion()
		{
			this.Type = IRoadNetworkNavigationTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035290 RID: 217744 RVA: 0x00722FB9 File Offset: 0x007211B9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035291 RID: 217745 RVA: 0x00722FCB File Offset: 0x007211CB
		public IRoadNetworkNavigationTargetT AsIRoadNetworkNavigationTarget()
		{
			return this.As<IRoadNetworkNavigationTargetT>();
		}

		// Token: 0x06035292 RID: 217746 RVA: 0x00722FD3 File Offset: 0x007211D3
		public static IRoadNetworkNavigationTarget_UnionUnion FromIRoadNetworkNavigationTarget(IRoadNetworkNavigationTargetT _iroadnetworknavigationtarget)
		{
			return new IRoadNetworkNavigationTarget_UnionUnion
			{
				Type = IRoadNetworkNavigationTarget_Union.IRoadNetworkNavigationTarget,
				Value = _iroadnetworknavigationtarget
			};
		}

		// Token: 0x06035293 RID: 217747 RVA: 0x00722FE8 File Offset: 0x007211E8
		public ISceneItemRoadNetworkNavigationT AsISceneItemRoadNetworkNavigation()
		{
			return this.As<ISceneItemRoadNetworkNavigationT>();
		}

		// Token: 0x06035294 RID: 217748 RVA: 0x00722FF0 File Offset: 0x007211F0
		public static IRoadNetworkNavigationTarget_UnionUnion FromISceneItemRoadNetworkNavigation(ISceneItemRoadNetworkNavigationT _isceneitemroadnetworknavigation)
		{
			return new IRoadNetworkNavigationTarget_UnionUnion
			{
				Type = IRoadNetworkNavigationTarget_Union.ISceneItemRoadNetworkNavigation,
				Value = _isceneitemroadnetworknavigation
			};
		}

		// Token: 0x06035295 RID: 217749 RVA: 0x00723008 File Offset: 0x00721208
		public static int Pack(FlatBufferBuilder builder, IRoadNetworkNavigationTarget_UnionUnion _o)
		{
			IRoadNetworkNavigationTarget_Union type = _o.Type;
			if (type == IRoadNetworkNavigationTarget_Union.IRoadNetworkNavigationTarget)
			{
				return IRoadNetworkNavigationTarget.Pack(builder, _o.AsIRoadNetworkNavigationTarget()).Value;
			}
			if (type != IRoadNetworkNavigationTarget_Union.ISceneItemRoadNetworkNavigation)
			{
				return 0;
			}
			return ISceneItemRoadNetworkNavigation.Pack(builder, _o.AsISceneItemRoadNetworkNavigation()).Value;
		}
	}
}
