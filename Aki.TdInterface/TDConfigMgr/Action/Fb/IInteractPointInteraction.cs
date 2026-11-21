using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B20 RID: 11040
	public class IInteractPointInteraction
	{
		// Token: 0x0600F2D6 RID: 62166 RVA: 0x002375DE File Offset: 0x002357DE
		public static IInteractPointInteraction Create(IInteractPointInteraction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractPointInteraction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004944 RID: 18756
		// (get) Token: 0x0600F2D7 RID: 62167 RVA: 0x002375FD File Offset: 0x002357FD
		public virtual EInteractPointInteractionType Type
		{
			get
			{
				return (EInteractPointInteractionType)this.Instance.Type;
			}
		}

		// Token: 0x04008544 RID: 34116
		private IInteractPointInteraction Instance;
	}
}
