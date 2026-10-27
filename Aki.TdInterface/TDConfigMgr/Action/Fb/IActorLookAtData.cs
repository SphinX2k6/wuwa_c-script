using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200259B RID: 9627
	public class IActorLookAtData
	{
		// Token: 0x0600D8B2 RID: 55474 RVA: 0x00205991 File Offset: 0x00203B91
		[NullableContext(1)]
		public static IActorLookAtData Create(IActorLookAtData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F3E RID: 16190
		// (get) Token: 0x0600D8B3 RID: 55475 RVA: 0x002059B0 File Offset: 0x00203BB0
		public virtual EActorLookAtMode Type
		{
			get
			{
				return (EActorLookAtMode)this.Instance.Type;
			}
		}

		// Token: 0x04007871 RID: 30833
		private IActorLookAtData Instance;
	}
}
