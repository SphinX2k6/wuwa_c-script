using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002859 RID: 10329
	public class IActorTurnToPlayerData : IActorTurnToData
	{
		// Token: 0x0600E668 RID: 58984 RVA: 0x00221C27 File Offset: 0x0021FE27
		public static IActorTurnToPlayerData Create(IActorTurnToPlayerData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorTurnToPlayerData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004264 RID: 16996
		// (get) Token: 0x0600E669 RID: 58985 RVA: 0x00221C46 File Offset: 0x0021FE46
		public override EActorTurnToMode Type
		{
			get
			{
				return (EActorTurnToMode)this.Instance.Type;
			}
		}

		// Token: 0x04007EED RID: 32493
		private IActorTurnToPlayerData Instance;
	}
}
