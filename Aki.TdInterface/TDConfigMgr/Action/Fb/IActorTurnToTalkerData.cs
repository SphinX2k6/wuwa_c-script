using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002855 RID: 10325
	public class IActorTurnToTalkerData : IActorTurnToData
	{
		// Token: 0x0600E65A RID: 58970 RVA: 0x00221B16 File Offset: 0x0021FD16
		public static IActorTurnToTalkerData Create(IActorTurnToTalkerData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorTurnToTalkerData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700425E RID: 16990
		// (get) Token: 0x0600E65B RID: 58971 RVA: 0x00221B35 File Offset: 0x0021FD35
		public override EActorTurnToMode Type
		{
			get
			{
				return (EActorTurnToMode)this.Instance.Type;
			}
		}

		// Token: 0x04007EE7 RID: 32487
		private IActorTurnToTalkerData Instance;
	}
}
