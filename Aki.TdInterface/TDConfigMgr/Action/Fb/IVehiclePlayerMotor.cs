using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CB6 RID: 11446
	public class IVehiclePlayerMotor : ITargetVehicle
	{
		// Token: 0x0600FB09 RID: 64265 RVA: 0x00245FFE File Offset: 0x002441FE
		public static IVehiclePlayerMotor Create(IVehiclePlayerMotor? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehiclePlayerMotor
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E4B RID: 20043
		// (get) Token: 0x0600FB0A RID: 64266 RVA: 0x0024601D File Offset: 0x0024421D
		public override ETargetVehicle Type
		{
			get
			{
				return (ETargetVehicle)this.Instance.Type;
			}
		}

		// Token: 0x17004E4C RID: 20044
		// (get) Token: 0x0600FB0B RID: 64267 RVA: 0x0024602C File Offset: 0x0024422C
		public virtual int? SummonPositionEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SummonPositionEntityId);
			}
		}

		// Token: 0x0400891A RID: 35098
		private IVehiclePlayerMotor Instance;
	}
}
