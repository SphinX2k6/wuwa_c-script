using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C7E RID: 11390
	public class FollowShooterLeisureInteract : ActionParams
	{
		// Token: 0x0600FA2B RID: 64043 RVA: 0x00244D5B File Offset: 0x00242F5B
		public static FollowShooterLeisureInteract Create(IFollowShooterLeisureInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FollowShooterLeisureInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DDD RID: 19933
		// (get) Token: 0x0600FA2C RID: 64044 RVA: 0x00244D7A File Offset: 0x00242F7A
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004DDE RID: 19934
		// (get) Token: 0x0600FA2D RID: 64045 RVA: 0x00244D87 File Offset: 0x00242F87
		public virtual IFollowShooterLeisureInteractType InteractType
		{
			get
			{
				if (this._InteractTypeInited)
				{
					return this._InteractTypeCache;
				}
				this._InteractTypeInited = true;
				this._InteractTypeCache = ActionReadHelper.ReadFollowShooterLeisureInteract_InteractType(this.Instance);
				return this._InteractTypeCache;
			}
		}

		// Token: 0x040088AE RID: 34990
		private IFollowShooterLeisureInteract Instance;

		// Token: 0x040088AF RID: 34991
		private IFollowShooterLeisureInteractType _InteractTypeCache;

		// Token: 0x040088B0 RID: 34992
		private bool _InteractTypeInited;
	}
}
