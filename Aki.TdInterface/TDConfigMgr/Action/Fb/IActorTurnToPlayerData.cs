using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025AA RID: 9642
	public class IActorTurnToPlayerData : IActorTurnToData
	{
		// Token: 0x0600D8EE RID: 55534 RVA: 0x00205F53 File Offset: 0x00204153
		[NullableContext(1)]
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

		// Token: 0x17003F5C RID: 16220
		// (get) Token: 0x0600D8EF RID: 55535 RVA: 0x00205F72 File Offset: 0x00204172
		public override EActorTurnToMode Type
		{
			get
			{
				return (EActorTurnToMode)this.Instance.Type;
			}
		}

		// Token: 0x04007886 RID: 30854
		private IActorTurnToPlayerData Instance;
	}
}
