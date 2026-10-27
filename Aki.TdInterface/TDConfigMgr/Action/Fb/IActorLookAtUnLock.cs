using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025A3 RID: 9635
	public class IActorLookAtUnLock : IActorLookAtData
	{
		// Token: 0x0600D8D4 RID: 55508 RVA: 0x00205D07 File Offset: 0x00203F07
		[NullableContext(1)]
		public static IActorLookAtUnLock Create(IActorLookAtUnLock? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtUnLock
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F50 RID: 16208
		// (get) Token: 0x0600D8D5 RID: 55509 RVA: 0x00205D26 File Offset: 0x00203F26
		public override EActorLookAtMode Type
		{
			get
			{
				return (EActorLookAtMode)this.Instance.Type;
			}
		}

		// Token: 0x0400787B RID: 30843
		private IActorLookAtUnLock Instance;
	}
}
