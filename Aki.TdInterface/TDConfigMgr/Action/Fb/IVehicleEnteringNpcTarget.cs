using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CA5 RID: 11429
	public class IVehicleEnteringNpcTarget : IVehicleEnteringTarget
	{
		// Token: 0x0600FACA RID: 64202 RVA: 0x00245A96 File Offset: 0x00243C96
		public static IVehicleEnteringNpcTarget Create(IVehicleEnteringNpcTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleEnteringNpcTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E2E RID: 20014
		// (get) Token: 0x0600FACB RID: 64203 RVA: 0x00245AB5 File Offset: 0x00243CB5
		public override EVehicleEnteringTarget Type
		{
			get
			{
				return (EVehicleEnteringTarget)this.Instance.Type;
			}
		}

		// Token: 0x17004E2F RID: 20015
		// (get) Token: 0x0600FACC RID: 64204 RVA: 0x00245AC4 File Offset: 0x00243CC4
		public override int? TargetVehicle
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

		// Token: 0x17004E30 RID: 20016
		// (get) Token: 0x0600FACD RID: 64205 RVA: 0x00245AFA File Offset: 0x00243CFA
		public virtual int TargetNpc
		{
			get
			{
				return this.Instance.TargetNpc;
			}
		}

		// Token: 0x040088FD RID: 35069
		private IVehicleEnteringNpcTarget Instance;
	}
}
