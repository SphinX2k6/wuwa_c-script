using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CA3 RID: 11427
	public class IVehicleEnteringTarget
	{
		// Token: 0x0600FAC2 RID: 64194 RVA: 0x002459BF File Offset: 0x00243BBF
		public static IVehicleEnteringTarget Create(IVehicleEnteringTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleEnteringTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E2A RID: 20010
		// (get) Token: 0x0600FAC3 RID: 64195 RVA: 0x002459DE File Offset: 0x00243BDE
		public virtual EVehicleEnteringTarget Type
		{
			get
			{
				return (EVehicleEnteringTarget)this.Instance.Type;
			}
		}

		// Token: 0x17004E2B RID: 20011
		// (get) Token: 0x0600FAC4 RID: 64196 RVA: 0x002459EC File Offset: 0x00243BEC
		public virtual int? TargetVehicle
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TargetVehicle);
			}
		}

		// Token: 0x040088FB RID: 35067
		private IVehicleEnteringTarget Instance;
	}
}
