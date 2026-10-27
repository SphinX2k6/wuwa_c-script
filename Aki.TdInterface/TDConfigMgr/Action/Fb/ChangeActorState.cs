using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025BC RID: 9660
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeActorState : ActionParams
	{
		// Token: 0x0600D949 RID: 55625 RVA: 0x00206A98 File Offset: 0x00204C98
		public static ChangeActorState Create(IChangeActorState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeActorState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F93 RID: 16275
		// (get) Token: 0x0600D94A RID: 55626 RVA: 0x00206AB7 File Offset: 0x00204CB7
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x040078B2 RID: 30898
		private IChangeActorState Instance;
	}
}
