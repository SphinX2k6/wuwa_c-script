using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026CB RID: 9931
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeSelfEntityState : ActionParams
	{
		// Token: 0x0600DE0B RID: 56843 RVA: 0x0020F532 File Offset: 0x0020D732
		public static ChangeSelfEntityState Create(IChangeSelfEntityState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeSelfEntityState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004237 RID: 16951
		// (get) Token: 0x0600DE0C RID: 56844 RVA: 0x0020F551 File Offset: 0x0020D751
		public virtual string EntityState
		{
			get
			{
				return this.Instance.EntityState;
			}
		}

		// Token: 0x04007B49 RID: 31561
		private IChangeSelfEntityState Instance;
	}
}
