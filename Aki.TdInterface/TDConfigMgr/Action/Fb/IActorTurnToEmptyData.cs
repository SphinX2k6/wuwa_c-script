using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002856 RID: 10326
	public class IActorTurnToEmptyData : IActorTurnToData
	{
		// Token: 0x0600E65D RID: 58973 RVA: 0x00221B4A File Offset: 0x0021FD4A
		public static IActorTurnToEmptyData Create(IActorTurnToEmptyData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorTurnToEmptyData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700425F RID: 16991
		// (get) Token: 0x0600E65E RID: 58974 RVA: 0x00221B69 File Offset: 0x0021FD69
		public override EActorTurnToMode Type
		{
			get
			{
				return (EActorTurnToMode)this.Instance.Type;
			}
		}

		// Token: 0x04007EE8 RID: 32488
		private IActorTurnToEmptyData Instance;
	}
}
