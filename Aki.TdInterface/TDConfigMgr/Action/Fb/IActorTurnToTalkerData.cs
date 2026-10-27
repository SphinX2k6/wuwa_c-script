using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025A6 RID: 9638
	public class IActorTurnToTalkerData : IActorTurnToData
	{
		// Token: 0x0600D8E0 RID: 55520 RVA: 0x00205E42 File Offset: 0x00204042
		[NullableContext(1)]
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

		// Token: 0x17003F56 RID: 16214
		// (get) Token: 0x0600D8E1 RID: 55521 RVA: 0x00205E61 File Offset: 0x00204061
		public override EActorTurnToMode Type
		{
			get
			{
				return (EActorTurnToMode)this.Instance.Type;
			}
		}

		// Token: 0x04007880 RID: 30848
		private IActorTurnToTalkerData Instance;
	}
}
