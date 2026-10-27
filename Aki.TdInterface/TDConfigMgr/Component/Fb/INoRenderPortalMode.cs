using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D06 RID: 3334
	public class INoRenderPortalMode
	{
		// Token: 0x06004C1C RID: 19484 RVA: 0x000BDC22 File Offset: 0x000BBE22
		[NullableContext(1)]
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

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06004C1D RID: 19485 RVA: 0x000BDC41 File Offset: 0x000BBE41
		public virtual ENoRenderPortalType Type
		{
			get
			{
				return (ENoRenderPortalType)this.Instance.Type;
			}
		}

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x06004C1E RID: 19486 RVA: 0x000BDC4E File Offset: 0x000BBE4E
		public virtual EPortalModel PortalModel
		{
			get
			{
				return (EPortalModel)this.Instance.PortalModel;
			}
		}

		// Token: 0x04002B89 RID: 11145
		private INoRenderPortalMode Instance;
	}
}
