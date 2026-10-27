using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D27 RID: 3367
	public class INavMeshAkiEntitySource : INavMeshSourceTypeBase
	{
		// Token: 0x06004CD6 RID: 19670 RVA: 0x000BF39A File Offset: 0x000BD59A
		[NullableContext(1)]
		public static INavMeshAkiEntitySource Create(INavMeshAkiEntitySource? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INavMeshAkiEntitySource
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x06004CD7 RID: 19671 RVA: 0x000BF3B9 File Offset: 0x000BD5B9
		public override ENavMeshSourceType Type
		{
			get
			{
				return (ENavMeshSourceType)this.Instance.Type;
			}
		}

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x06004CD8 RID: 19672 RVA: 0x000BF3C6 File Offset: 0x000BD5C6
		public virtual int SourceId
		{
			get
			{
				return this.Instance.SourceId;
			}
		}

		// Token: 0x04002BFA RID: 11258
		private INavMeshAkiEntitySource Instance;
	}
}
