using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025A5 RID: 9637
	public class IActorTurnToData
	{
		// Token: 0x0600D8DD RID: 55517 RVA: 0x00205E0E File Offset: 0x0020400E
		[NullableContext(1)]
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

		// Token: 0x17003F55 RID: 16213
		// (get) Token: 0x0600D8DE RID: 55518 RVA: 0x00205E2D File Offset: 0x0020402D
		public virtual EActorTurnToMode Type
		{
			get
			{
				return (EActorTurnToMode)this.Instance.Type;
			}
		}

		// Token: 0x0400787F RID: 30847
		private IActorTurnToData Instance;
	}
}
