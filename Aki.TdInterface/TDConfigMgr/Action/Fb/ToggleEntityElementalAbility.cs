using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B03 RID: 11011
	public class ToggleEntityElementalAbility : ActionParams
	{
		// Token: 0x0600F126 RID: 61734 RVA: 0x0022FB28 File Offset: 0x0022DD28
		[NullableContext(1)]
		public static ToggleEntityElementalAbility Create(IToggleEntityElementalAbility? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleEntityElementalAbility
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CE2 RID: 19682
		// (get) Token: 0x0600F127 RID: 61735 RVA: 0x0022FB47 File Offset: 0x0022DD47
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004CE3 RID: 19683
		// (get) Token: 0x0600F128 RID: 61736 RVA: 0x0022FB54 File Offset: 0x0022DD54
		public virtual bool Enable
		{
			get
			{
				return this.Instance.Enable;
			}
		}

		// Token: 0x040084A3 RID: 33955
		private IToggleEntityElementalAbility Instance;
	}
}
