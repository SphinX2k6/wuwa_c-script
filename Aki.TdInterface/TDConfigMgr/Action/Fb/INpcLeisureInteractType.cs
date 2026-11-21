using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AE9 RID: 10985
	public class INpcLeisureInteractType
	{
		// Token: 0x0600F1CB RID: 61899 RVA: 0x00235982 File Offset: 0x00233B82
		public static INpcLeisureInteractType Create(INpcLeisureInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcLeisureInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048A7 RID: 18599
		// (get) Token: 0x0600F1CC RID: 61900 RVA: 0x002359A1 File Offset: 0x00233BA1
		public virtual ENpcLeisureInteract Type
		{
			get
			{
				return (ENpcLeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x170048A8 RID: 18600
		// (get) Token: 0x0600F1CD RID: 61901 RVA: 0x002359B0 File Offset: 0x00233BB0
		public virtual bool? KeepState
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepState);
			}
		}

		// Token: 0x040084C7 RID: 33991
		private INpcLeisureInteractType Instance;
	}
}
