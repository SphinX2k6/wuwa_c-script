using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002600 RID: 9728
	[NullableContext(1)]
	[Nullable(0)]
	public class SyncVarToActorState : ActionParams
	{
		// Token: 0x0600DA86 RID: 55942 RVA: 0x00208F77 File Offset: 0x00207177
		public static SyncVarToActorState Create(ISyncVarToActorState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SyncVarToActorState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004048 RID: 16456
		// (get) Token: 0x0600DA87 RID: 55943 RVA: 0x00208F96 File Offset: 0x00207196
		public virtual string VarName
		{
			get
			{
				return this.Instance.VarName;
			}
		}

		// Token: 0x17004049 RID: 16457
		// (get) Token: 0x0600DA88 RID: 55944 RVA: 0x00208FA3 File Offset: 0x002071A3
		public virtual string StateKey
		{
			get
			{
				return this.Instance.StateKey;
			}
		}

		// Token: 0x0400795A RID: 31066
		private ISyncVarToActorState Instance;
	}
}
