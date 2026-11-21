using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C6D RID: 11373
	public class SetInteractionLockState : ActionParams
	{
		// Token: 0x0600F9F0 RID: 63984 RVA: 0x00244814 File Offset: 0x00242A14
		public static SetInteractionLockState Create(ISetInteractionLockState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetInteractionLockState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DC4 RID: 19908
		// (get) Token: 0x0600F9F1 RID: 63985 RVA: 0x00244833 File Offset: 0x00242A33
		public virtual bool IsLock
		{
			get
			{
				return this.Instance.IsLock;
			}
		}

		// Token: 0x04008891 RID: 34961
		private ISetInteractionLockState Instance;
	}
}
