using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E20 RID: 3616
	public class INavMeshSourceTypeBase
	{
		// Token: 0x060051EF RID: 20975 RVA: 0x000CAAAA File Offset: 0x000C8CAA
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

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x060051F0 RID: 20976 RVA: 0x000CAAC9 File Offset: 0x000C8CC9
		public virtual ENavMeshSourceType Type
		{
			get
			{
				return (ENavMeshSourceType)this.Instance.Type;
			}
		}

		// Token: 0x04002EB9 RID: 11961
		private INavMeshSourceTypeBase Instance;
	}
}
