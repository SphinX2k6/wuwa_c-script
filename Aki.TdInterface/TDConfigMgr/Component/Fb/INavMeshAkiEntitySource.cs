using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E21 RID: 3617
	public class INavMeshAkiEntitySource : INavMeshSourceTypeBase
	{
		// Token: 0x060051F2 RID: 20978 RVA: 0x000CAADE File Offset: 0x000C8CDE
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

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x060051F3 RID: 20979 RVA: 0x000CAAFD File Offset: 0x000C8CFD
		public override ENavMeshSourceType Type
		{
			get
			{
				return (ENavMeshSourceType)this.Instance.Type;
			}
		}

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x060051F4 RID: 20980 RVA: 0x000CAB0A File Offset: 0x000C8D0A
		public virtual int SourceId
		{
			get
			{
				return this.Instance.SourceId;
			}
		}

		// Token: 0x04002EBA RID: 11962
		private INavMeshAkiEntitySource Instance;
	}
}
