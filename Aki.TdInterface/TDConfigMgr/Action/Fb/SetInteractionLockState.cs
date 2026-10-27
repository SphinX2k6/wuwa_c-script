using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002987 RID: 10631
	public class SetInteractionLockState : ActionParams
	{
		// Token: 0x0600EB75 RID: 60277 RVA: 0x002270BC File Offset: 0x002252BC
		[NullableContext(1)]
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

		// Token: 0x17004A29 RID: 18985
		// (get) Token: 0x0600EB76 RID: 60278 RVA: 0x002270DB File Offset: 0x002252DB
		public virtual bool IsLock
		{
			get
			{
				return this.Instance.IsLock;
			}
		}

		// Token: 0x040081AD RID: 33197
		private ISetInteractionLockState Instance;
	}
}
