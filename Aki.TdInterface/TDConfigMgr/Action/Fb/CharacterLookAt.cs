using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028EE RID: 10478
	public class CharacterLookAt : ActionParams
	{
		// Token: 0x0600E924 RID: 59684 RVA: 0x00226F43 File Offset: 0x00225143
		public static CharacterLookAt Create(ICharacterLookAt? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CharacterLookAt
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043F6 RID: 17398
		// (get) Token: 0x0600E925 RID: 59685 RVA: 0x00226F62 File Offset: 0x00225162
		public virtual int CharEntityId
		{
			get
			{
				return this.Instance.CharEntityId;
			}
		}

		// Token: 0x170043F7 RID: 17399
		// (get) Token: 0x0600E926 RID: 59686 RVA: 0x00226F6F File Offset: 0x0022516F
		public virtual ICharacterLookAtData Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadCharacterLookAt_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x04008072 RID: 32882
		private ICharacterLookAt Instance;

		// Token: 0x04008073 RID: 32883
		private ICharacterLookAtData _TargetCache;

		// Token: 0x04008074 RID: 32884
		private bool _TargetInited;
	}
}
