using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D26 RID: 3366
	public class INavMeshSourceTypeBase
	{
		// Token: 0x06004CD3 RID: 19667 RVA: 0x000BF366 File Offset: 0x000BD566
		[NullableContext(1)]
		public static INavMeshSourceTypeBase Create(INavMeshSourceTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INavMeshSourceTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x06004CD4 RID: 19668 RVA: 0x000BF385 File Offset: 0x000BD585
		public virtual ENavMeshSourceType Type
		{
			get
			{
				return (ENavMeshSourceType)this.Instance.Type;
			}
		}

		// Token: 0x04002BF9 RID: 11257
		private INavMeshSourceTypeBase Instance;
	}
}
