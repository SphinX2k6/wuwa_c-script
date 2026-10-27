using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025B9 RID: 9657
	public class ChangeBehaviorState : ActionParams
	{
		// Token: 0x0600D93F RID: 55615 RVA: 0x00206995 File Offset: 0x00204B95
		[NullableContext(1)]
		public static ChangeBehaviorState Create(IChangeBehaviorState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeBehaviorState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F8F RID: 16271
		// (get) Token: 0x0600D940 RID: 55616 RVA: 0x002069B4 File Offset: 0x00204BB4
		public virtual int StateId
		{
			get
			{
				return this.Instance.StateId;
			}
		}

		// Token: 0x17003F90 RID: 16272
		// (get) Token: 0x0600D941 RID: 55617 RVA: 0x002069C1 File Offset: 0x00204BC1
		public virtual bool IsInstant
		{
			get
			{
				return this.Instance.IsInstant;
			}
		}

		// Token: 0x040078AD RID: 30893
		private IChangeBehaviorState Instance;
	}
}
