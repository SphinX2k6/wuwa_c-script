using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F02 RID: 3842
	public class IWuWaGoEntityBase
	{
		// Token: 0x0600566E RID: 22126 RVA: 0x000D4195 File Offset: 0x000D2395
		public static IWuWaGoEntityBase Create(IWuWaGoEntityBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoEntityBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x0600566F RID: 22127 RVA: 0x000D41B4 File Offset: 0x000D23B4
		public virtual EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x0400318F RID: 12687
		private IWuWaGoEntityBase Instance;
	}
}
