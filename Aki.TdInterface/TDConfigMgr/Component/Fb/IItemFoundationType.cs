using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C24 RID: 3108
	public class IItemFoundationType
	{
		// Token: 0x0600472E RID: 18222 RVA: 0x000B4979 File Offset: 0x000B2B79
		public static IItemFoundationType Create(IItemFoundationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemFoundationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x0600472F RID: 18223 RVA: 0x000B4998 File Offset: 0x000B2B98
		public virtual EItemFoundation Type
		{
			get
			{
				return (EItemFoundation)this.Instance.Type;
			}
		}

		// Token: 0x040027F3 RID: 10227
		private IItemFoundationType Instance;
	}
}
