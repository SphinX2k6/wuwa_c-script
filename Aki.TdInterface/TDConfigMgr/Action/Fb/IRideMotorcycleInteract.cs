using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD3 RID: 10963
	public class IRideMotorcycleInteract : ILeisureInteractType
	{
		// Token: 0x0600F16F RID: 61807 RVA: 0x002351B2 File Offset: 0x002333B2
		public static IRideMotorcycleInteract Create(IRideMotorcycleInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRideMotorcycleInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004877 RID: 18551
		// (get) Token: 0x0600F170 RID: 61808 RVA: 0x002351D1 File Offset: 0x002333D1
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x17004878 RID: 18552
		// (get) Token: 0x0600F171 RID: 61809 RVA: 0x002351DE File Offset: 0x002333DE
		public virtual int MotorcycleEntityId
		{
			get
			{
				return this.Instance.MotorcycleEntityId;
			}
		}

		// Token: 0x040084A1 RID: 33953
		private IRideMotorcycleInteract Instance;
	}
}
