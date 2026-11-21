using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD4 RID: 10964
	public class IGetOffMotorcycleInteract : ILeisureInteractType
	{
		// Token: 0x0600F173 RID: 61811 RVA: 0x002351F3 File Offset: 0x002333F3
		public static IGetOffMotorcycleInteract Create(IGetOffMotorcycleInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGetOffMotorcycleInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004879 RID: 18553
		// (get) Token: 0x0600F174 RID: 61812 RVA: 0x00235212 File Offset: 0x00233412
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x040084A2 RID: 33954
		private IGetOffMotorcycleInteract Instance;
	}
}
