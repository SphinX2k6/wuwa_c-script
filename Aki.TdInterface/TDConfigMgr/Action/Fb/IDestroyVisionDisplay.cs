using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002848 RID: 10312
	public class IDestroyVisionDisplay : IDestroyDynamicEntitiesType
	{
		// Token: 0x0600E626 RID: 58918 RVA: 0x002215D6 File Offset: 0x0021F7D6
		public static IDestroyVisionDisplay Create(IDestroyVisionDisplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDestroyVisionDisplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004244 RID: 16964
		// (get) Token: 0x0600E627 RID: 58919 RVA: 0x002215F5 File Offset: 0x0021F7F5
		public override EDynamicEntityType Type
		{
			get
			{
				return (EDynamicEntityType)this.Instance.Type;
			}
		}

		// Token: 0x04007ED4 RID: 32468
		private IDestroyVisionDisplay Instance;
	}
}
