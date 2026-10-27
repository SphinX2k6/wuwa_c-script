using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025A7 RID: 9639
	public class IActorTurnToEmptyData : IActorTurnToData
	{
		// Token: 0x0600D8E3 RID: 55523 RVA: 0x00205E76 File Offset: 0x00204076
		[NullableContext(1)]
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

		// Token: 0x17003F57 RID: 16215
		// (get) Token: 0x0600D8E4 RID: 55524 RVA: 0x00205E95 File Offset: 0x00204095
		public override EActorTurnToMode Type
		{
			get
			{
				return (EActorTurnToMode)this.Instance.Type;
			}
		}

		// Token: 0x04007881 RID: 30849
		private IActorTurnToEmptyData Instance;
	}
}
