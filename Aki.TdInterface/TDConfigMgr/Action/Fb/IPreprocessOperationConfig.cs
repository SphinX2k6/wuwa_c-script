using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BE7 RID: 11239
	public class IPreprocessOperationConfig
	{
		// Token: 0x0600F78E RID: 63374 RVA: 0x00240698 File Offset: 0x0023E898
		public static IPreprocessOperationConfig Create(IPreprocessOperationConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreprocessOperationConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C6E RID: 19566
		// (get) Token: 0x0600F78F RID: 63375 RVA: 0x002406B7 File Offset: 0x0023E8B7
		public virtual EPreprocessOperation Type
		{
			get
			{
				return (EPreprocessOperation)this.Instance.Type;
			}
		}

		// Token: 0x0400878F RID: 34703
		private IPreprocessOperationConfig Instance;
	}
}
