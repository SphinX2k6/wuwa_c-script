using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002673 RID: 9843
	public class SetAreaState : ActionParams
	{
		// Token: 0x0600DC9D RID: 56477 RVA: 0x0020D005 File Offset: 0x0020B205
		[NullableContext(1)]
		public static SetAreaState Create(ISetAreaState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetAreaState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004179 RID: 16761
		// (get) Token: 0x0600DC9E RID: 56478 RVA: 0x0020D024 File Offset: 0x0020B224
		public virtual int AreaId
		{
			get
			{
				return this.Instance.AreaId;
			}
		}

		// Token: 0x1700417A RID: 16762
		// (get) Token: 0x0600DC9F RID: 56479 RVA: 0x0020D031 File Offset: 0x0020B231
		public virtual int State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x04007A9D RID: 31389
		private ISetAreaState Instance;
	}
}
