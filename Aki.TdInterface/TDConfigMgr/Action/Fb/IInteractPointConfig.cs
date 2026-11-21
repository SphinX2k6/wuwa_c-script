using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B17 RID: 11031
	public class IInteractPointConfig
	{
		// Token: 0x0600F2AC RID: 62124 RVA: 0x00237056 File Offset: 0x00235256
		public static IInteractPointConfig Create(IInteractPointConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractPointConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700492C RID: 18732
		// (get) Token: 0x0600F2AD RID: 62125 RVA: 0x00237075 File Offset: 0x00235275
		public virtual EInteractUnlockType Type
		{
			get
			{
				return (EInteractUnlockType)this.Instance.Type;
			}
		}

		// Token: 0x0400852B RID: 34091
		private IInteractPointConfig Instance;
	}
}
