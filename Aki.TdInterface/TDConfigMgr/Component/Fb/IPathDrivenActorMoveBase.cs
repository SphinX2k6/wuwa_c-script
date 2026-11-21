using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F14 RID: 3860
	public class IPathDrivenActorMoveBase
	{
		// Token: 0x060056D1 RID: 22225 RVA: 0x000D4F3D File Offset: 0x000D313D
		public static IPathDrivenActorMoveBase Create(IPathDrivenActorMoveBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathDrivenActorMoveBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001CA4 RID: 7332
		// (get) Token: 0x060056D2 RID: 22226 RVA: 0x000D4F5C File Offset: 0x000D315C
		public virtual EPathDrivenActorMoveType Type
		{
			get
			{
				return (EPathDrivenActorMoveType)this.Instance.Type;
			}
		}

		// Token: 0x040031D3 RID: 12755
		private IPathDrivenActorMoveBase Instance;
	}
}
