using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DFE RID: 3582
	public class INoRenderPortalMode
	{
		// Token: 0x0600512A RID: 20778 RVA: 0x000C9152 File Offset: 0x000C7352
		public static INoRenderPortalMode Create(INoRenderPortalMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INoRenderPortalMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x0600512B RID: 20779 RVA: 0x000C9171 File Offset: 0x000C7371
		public virtual ENoRenderPortalType Type
		{
			get
			{
				return (ENoRenderPortalType)this.Instance.Type;
			}
		}

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x0600512C RID: 20780 RVA: 0x000C917E File Offset: 0x000C737E
		public virtual EPortalModel PortalModel
		{
			get
			{
				return (EPortalModel)this.Instance.PortalModel;
			}
		}

		// Token: 0x04002E43 RID: 11843
		private INoRenderPortalMode Instance;
	}
}
