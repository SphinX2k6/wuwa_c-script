using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002847 RID: 10311
	public class IDestroyDynamicEntitiesType
	{
		// Token: 0x0600E623 RID: 58915 RVA: 0x002215A2 File Offset: 0x0021F7A2
		public static IDestroyDynamicEntitiesType Create(IDestroyDynamicEntitiesType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDestroyDynamicEntitiesType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004243 RID: 16963
		// (get) Token: 0x0600E624 RID: 58916 RVA: 0x002215C1 File Offset: 0x0021F7C1
		public virtual EDynamicEntityType Type
		{
			get
			{
				return (EDynamicEntityType)this.Instance.Type;
			}
		}

		// Token: 0x04007ED3 RID: 32467
		private IDestroyDynamicEntitiesType Instance;
	}
}
