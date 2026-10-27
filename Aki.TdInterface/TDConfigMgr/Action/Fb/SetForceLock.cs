using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002672 RID: 9842
	public class SetForceLock : ActionParams
	{
		// Token: 0x0600DC99 RID: 56473 RVA: 0x0020CFC4 File Offset: 0x0020B1C4
		[NullableContext(1)]
		public static SetForceLock Create(ISetForceLock? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetForceLock
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004177 RID: 16759
		// (get) Token: 0x0600DC9A RID: 56474 RVA: 0x0020CFE3 File Offset: 0x0020B1E3
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004178 RID: 16760
		// (get) Token: 0x0600DC9B RID: 56475 RVA: 0x0020CFF0 File Offset: 0x0020B1F0
		public virtual bool IsLocked
		{
			get
			{
				return this.Instance.IsLocked;
			}
		}

		// Token: 0x04007A9C RID: 31388
		private ISetForceLock Instance;
	}
}
