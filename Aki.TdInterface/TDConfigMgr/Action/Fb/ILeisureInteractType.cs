using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AA5 RID: 10917
	public class ILeisureInteractType
	{
		// Token: 0x0600F0BE RID: 61630 RVA: 0x0023426F File Offset: 0x0023246F
		public static ILeisureInteractType Create(ILeisureInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILeisureInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004822 RID: 18466
		// (get) Token: 0x0600F0BF RID: 61631 RVA: 0x0023428E File Offset: 0x0023248E
		public virtual ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x0400845B RID: 33883
		private ILeisureInteractType Instance;
	}
}
