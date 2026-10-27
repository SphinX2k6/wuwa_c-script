using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E18 RID: 3608
	public class IPathDrivenActorMoveBase
	{
		// Token: 0x060051AA RID: 20906 RVA: 0x000C9675 File Offset: 0x000C7875
		[NullableContext(1)]
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

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x060051AB RID: 20907 RVA: 0x000C9694 File Offset: 0x000C7894
		public virtual EPathDrivenActorMoveType Type
		{
			get
			{
				return (EPathDrivenActorMoveType)this.Instance.Type;
			}
		}

		// Token: 0x04002F0B RID: 12043
		private IPathDrivenActorMoveBase Instance;
	}
}
