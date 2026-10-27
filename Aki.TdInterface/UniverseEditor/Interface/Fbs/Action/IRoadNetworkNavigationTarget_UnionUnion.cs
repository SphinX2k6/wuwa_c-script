using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ED7 RID: 28375
	public class IRoadNetworkNavigationTarget_UnionUnion
	{
		// Token: 0x1700D323 RID: 54051
		// (get) Token: 0x0603224B RID: 205387 RVA: 0x006C724D File Offset: 0x006C544D
		// (set) Token: 0x0603224C RID: 205388 RVA: 0x006C7255 File Offset: 0x006C5455
		public IRoadNetworkNavigationTarget_Union Type { get; set; }

		// Token: 0x1700D324 RID: 54052
		// (get) Token: 0x0603224D RID: 205389 RVA: 0x006C725E File Offset: 0x006C545E
		// (set) Token: 0x0603224E RID: 205390 RVA: 0x006C7266 File Offset: 0x006C5466
		public object Value { get; set; }

		// Token: 0x0603224F RID: 205391 RVA: 0x006C726F File Offset: 0x006C546F
		public IRoadNetworkNavigationTarget_UnionUnion()
		{
			this.Type = IRoadNetworkNavigationTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032250 RID: 205392 RVA: 0x006C7285 File Offset: 0x006C5485
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032251 RID: 205393 RVA: 0x006C7297 File Offset: 0x006C5497
		public IRoadNetworkNavigationTargetT AsIRoadNetworkNavigationTarget()
		{
			return this.As<IRoadNetworkNavigationTargetT>();
		}

		// Token: 0x06032252 RID: 205394 RVA: 0x006C729F File Offset: 0x006C549F
		public static IRoadNetworkNavigationTarget_UnionUnion FromIRoadNetworkNavigationTarget(IRoadNetworkNavigationTargetT _iroadnetworknavigationtarget)
		{
			return new IRoadNetworkNavigationTarget_UnionUnion
			{
				Type = IRoadNetworkNavigationTarget_Union.IRoadNetworkNavigationTarget,
				Value = _iroadnetworknavigationtarget
			};
		}

		// Token: 0x06032253 RID: 205395 RVA: 0x006C72B4 File Offset: 0x006C54B4
		public ISceneItemRoadNetworkNavigationT AsISceneItemRoadNetworkNavigation()
		{
			return this.As<ISceneItemRoadNetworkNavigationT>();
		}

		// Token: 0x06032254 RID: 205396 RVA: 0x006C72BC File Offset: 0x006C54BC
		public static IRoadNetworkNavigationTarget_UnionUnion FromISceneItemRoadNetworkNavigation(ISceneItemRoadNetworkNavigationT _isceneitemroadnetworknavigation)
		{
			return new IRoadNetworkNavigationTarget_UnionUnion
			{
				Type = IRoadNetworkNavigationTarget_Union.ISceneItemRoadNetworkNavigation,
				Value = _isceneitemroadnetworknavigation
			};
		}

		// Token: 0x06032255 RID: 205397 RVA: 0x006C72D4 File Offset: 0x006C54D4
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
