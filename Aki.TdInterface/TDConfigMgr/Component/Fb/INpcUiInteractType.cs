using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C8A RID: 3210
	public class INpcUiInteractType
	{
		// Token: 0x06004939 RID: 18745 RVA: 0x000B8CAA File Offset: 0x000B6EAA
		public static INpcUiInteractType Create(INpcUiInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x0600493A RID: 18746 RVA: 0x000B8CC9 File Offset: 0x000B6EC9
		public virtual ENpcUiInteractType Type
		{
			get
			{
				return (ENpcUiInteractType)this.Instance.Type;
			}
		}

		// Token: 0x0400293D RID: 10557
		private INpcUiInteractType Instance;
	}
}
