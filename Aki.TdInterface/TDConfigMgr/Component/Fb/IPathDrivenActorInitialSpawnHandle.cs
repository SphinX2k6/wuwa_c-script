using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F16 RID: 3862
	public class IPathDrivenActorInitialSpawnHandle
	{
		// Token: 0x060056DC RID: 22236 RVA: 0x000D50EA File Offset: 0x000D32EA
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

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x060056DD RID: 22237 RVA: 0x000D5109 File Offset: 0x000D3309
		public virtual int Index
		{
			get
			{
				return this.Instance.Index;
			}
		}

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x060056DE RID: 22238 RVA: 0x000D5116 File Offset: 0x000D3316
		public virtual EPathDrivenActorInitialSpawnHandleType HandleType
		{
			get
			{
				return (EPathDrivenActorInitialSpawnHandleType)this.Instance.HandleType;
			}
		}

		// Token: 0x040031D7 RID: 12759
		private IPathDrivenActorInitialSpawnHandle Instance;
	}
}
