using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD5 RID: 10965
	public class IMoneHackingDoorInteract : ILeisureInteractType
	{
		// Token: 0x0600F176 RID: 61814 RVA: 0x00235227 File Offset: 0x00233427
		public static IMoneHackingDoorInteract Create(IMoneHackingDoorInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMoneHackingDoorInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700487A RID: 18554
		// (get) Token: 0x0600F177 RID: 61815 RVA: 0x00235246 File Offset: 0x00233446
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x040084A3 RID: 33955
		private IMoneHackingDoorInteract Instance;
	}
}
