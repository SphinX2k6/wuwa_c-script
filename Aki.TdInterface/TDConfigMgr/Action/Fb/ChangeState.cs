using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025B8 RID: 9656
	public class ChangeState : ActionParams
	{
		// Token: 0x0600D93C RID: 55612 RVA: 0x00206961 File Offset: 0x00204B61
		[NullableContext(1)]
		public static ChangeState Create(IChangeState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F8E RID: 16270
		// (get) Token: 0x0600D93D RID: 55613 RVA: 0x00206980 File Offset: 0x00204B80
		public virtual int StateId
		{
			get
			{
				return this.Instance.StateId;
			}
		}

		// Token: 0x040078AC RID: 30892
		private IChangeState Instance;
	}
}
