using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ACA RID: 10954
	[NullableContext(1)]
	[Nullable(0)]
	public class PhoneSystemInteract : ActionParams
	{
		// Token: 0x0600F050 RID: 61520 RVA: 0x0022E5E2 File Offset: 0x0022C7E2
		public static PhoneSystemInteract Create(IPhoneSystemInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PhoneSystemInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C7E RID: 19582
		// (get) Token: 0x0600F051 RID: 61521 RVA: 0x0022E601 File Offset: 0x0022C801
		public virtual IPhoneSystemInteractBase InteractType
		{
			get
			{
				if (this._InteractTypeInited)
				{
					return this._InteractTypeCache;
				}
				this._InteractTypeInited = true;
				this._InteractTypeCache = ActionReadHelper.ReadPhoneSystemInteract_InteractType(this.Instance);
				return this._InteractTypeCache;
			}
		}

		// Token: 0x0400842E RID: 33838
		private IPhoneSystemInteract Instance;

		// Token: 0x0400842F RID: 33839
		private IPhoneSystemInteractBase _InteractTypeCache;

		// Token: 0x04008430 RID: 33840
		private bool _InteractTypeInited;
	}
}
