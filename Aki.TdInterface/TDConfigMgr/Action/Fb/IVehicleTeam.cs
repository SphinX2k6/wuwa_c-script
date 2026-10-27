using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029C8 RID: 10696
	public class IVehicleTeam : ITargetVehicle
	{
		// Token: 0x0600EC6E RID: 60526 RVA: 0x00228639 File Offset: 0x00226839
		[NullableContext(1)]
		public static IVehicleTeam Create(IVehicleTeam? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleTeam
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AA0 RID: 19104
		// (get) Token: 0x0600EC6F RID: 60527 RVA: 0x00228658 File Offset: 0x00226858
		public override ETargetVehicle Type
		{
			get
			{
				return (ETargetVehicle)this.Instance.Type;
			}
		}

		// Token: 0x17004AA1 RID: 19105
		// (get) Token: 0x0600EC70 RID: 60528 RVA: 0x00228665 File Offset: 0x00226865
		public virtual int TeamId
		{
			get
			{
				return this.Instance.TeamId;
			}
		}

		// Token: 0x04008228 RID: 33320
		private IVehicleTeam Instance;
	}
}
