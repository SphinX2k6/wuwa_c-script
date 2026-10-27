using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024DB RID: 9435
	public class ResetEntityPos : ActionParams
	{
		// Token: 0x0600D2AE RID: 53934 RVA: 0x001F40B4 File Offset: 0x001F22B4
		[NullableContext(1)]
		public static ResetEntityPos Create(IResetEntityPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ResetEntityPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003ABA RID: 15034
		// (get) Token: 0x0600D2AF RID: 53935 RVA: 0x001F40D3 File Offset: 0x001F22D3
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x0400738F RID: 29583
		private IResetEntityPos Instance;
	}
}
