using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BD4 RID: 11220
	public class IModifyMaterialConfig
	{
		// Token: 0x0600F73F RID: 63295 RVA: 0x0023FE62 File Offset: 0x0023E062
		public static IModifyMaterialConfig Create(IModifyMaterialConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyMaterialConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C45 RID: 19525
		// (get) Token: 0x0600F740 RID: 63296 RVA: 0x0023FE81 File Offset: 0x0023E081
		public virtual EModifyActorMaterialType Type
		{
			get
			{
				return (EModifyActorMaterialType)this.Instance.Type;
			}
		}

		// Token: 0x04008762 RID: 34658
		private IModifyMaterialConfig Instance;
	}
}
