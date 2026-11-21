using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028EF RID: 10479
	public class PlayerLookTowards : ActionParams
	{
		// Token: 0x0600E928 RID: 59688 RVA: 0x00226FA6 File Offset: 0x002251A6
		public static PlayerLookTowards Create(IPlayerLookTowards? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayerLookTowards
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043F8 RID: 17400
		// (get) Token: 0x0600E929 RID: 59689 RVA: 0x00226FC5 File Offset: 0x002251C5
		public virtual ICharacterLookAtData Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadPlayerLookTowards_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x04008075 RID: 32885
		private IPlayerLookTowards Instance;

		// Token: 0x04008076 RID: 32886
		private ICharacterLookAtData _TargetCache;

		// Token: 0x04008077 RID: 32887
		private bool _TargetInited;
	}
}
