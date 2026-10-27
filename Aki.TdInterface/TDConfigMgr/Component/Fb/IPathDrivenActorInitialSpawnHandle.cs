using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E1A RID: 3610
	public class IPathDrivenActorInitialSpawnHandle
	{
		// Token: 0x060051B5 RID: 20917 RVA: 0x000C9822 File Offset: 0x000C7A22
		[NullableContext(1)]
		public static IPathDrivenActorInitialSpawnHandle Create(IPathDrivenActorInitialSpawnHandle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathDrivenActorInitialSpawnHandle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x060051B6 RID: 20918 RVA: 0x000C9841 File Offset: 0x000C7A41
		public virtual int Index
		{
			get
			{
				return this.Instance.Index;
			}
		}

		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x060051B7 RID: 20919 RVA: 0x000C984E File Offset: 0x000C7A4E
		public virtual EPathDrivenActorInitialSpawnHandleType HandleType
		{
			get
			{
				return (EPathDrivenActorInitialSpawnHandleType)this.Instance.HandleType;
			}
		}

		// Token: 0x04002F0F RID: 12047
		private IPathDrivenActorInitialSpawnHandle Instance;
	}
}
