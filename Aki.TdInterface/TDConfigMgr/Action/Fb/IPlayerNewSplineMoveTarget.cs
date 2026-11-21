using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F1 RID: 10737
	public class IPlayerNewSplineMoveTarget : INewSplineMoveTarget
	{
		// Token: 0x0600ED7D RID: 60797 RVA: 0x0022E9DF File Offset: 0x0022CBDF
		public static IPlayerNewSplineMoveTarget Create(IPlayerNewSplineMoveTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerNewSplineMoveTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004649 RID: 17993
		// (get) Token: 0x0600ED7E RID: 60798 RVA: 0x0022E9FE File Offset: 0x0022CBFE
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x040082B9 RID: 33465
		private IPlayerNewSplineMoveTarget Instance;
	}
}
