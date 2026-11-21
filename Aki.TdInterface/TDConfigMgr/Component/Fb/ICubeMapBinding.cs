using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E01 RID: 3585
	public class ICubeMapBinding
	{
		// Token: 0x06005139 RID: 20793 RVA: 0x000C931F File Offset: 0x000C751F
		public static ICubeMapBinding Create(ICubeMapBinding? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICubeMapBinding
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x0600513A RID: 20794 RVA: 0x000C933E File Offset: 0x000C753E
		public virtual string CubeMapActorKey
		{
			get
			{
				return this.Instance.CubeMapActorKey;
			}
		}

		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x0600513B RID: 20795 RVA: 0x000C934B File Offset: 0x000C754B
		public virtual string CubeMapPath
		{
			get
			{
				return this.Instance.CubeMapPath;
			}
		}

		// Token: 0x04002E4C RID: 11852
		private ICubeMapBinding Instance;
	}
}
