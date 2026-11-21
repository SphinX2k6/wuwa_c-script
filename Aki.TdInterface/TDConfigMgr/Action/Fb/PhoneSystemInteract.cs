using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DBE RID: 11710
	public class PhoneSystemInteract : ActionParams
	{
		// Token: 0x0600FF06 RID: 65286 RVA: 0x0024C2EE File Offset: 0x0024A4EE
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

		// Token: 0x17005038 RID: 20536
		// (get) Token: 0x0600FF07 RID: 65287 RVA: 0x0024C30D File Offset: 0x0024A50D
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

		// Token: 0x04008B32 RID: 35634
		private IPhoneSystemInteract Instance;

		// Token: 0x04008B33 RID: 35635
		private IPhoneSystemInteractBase _InteractTypeCache;

		// Token: 0x04008B34 RID: 35636
		private bool _InteractTypeInited;
	}
}
