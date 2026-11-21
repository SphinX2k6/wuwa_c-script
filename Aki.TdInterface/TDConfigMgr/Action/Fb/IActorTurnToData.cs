using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002854 RID: 10324
	public class IActorTurnToData
	{
		// Token: 0x0600E657 RID: 58967 RVA: 0x00221AE2 File Offset: 0x0021FCE2
		public static IActorTurnToData Create(IActorTurnToData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorTurnToData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700425D RID: 16989
		// (get) Token: 0x0600E658 RID: 58968 RVA: 0x00221B01 File Offset: 0x0021FD01
		public virtual EActorTurnToMode Type
		{
			get
			{
				return (EActorTurnToMode)this.Instance.Type;
			}
		}

		// Token: 0x04007EE6 RID: 32486
		private IActorTurnToData Instance;
	}
}
