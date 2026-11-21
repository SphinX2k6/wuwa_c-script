using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C83 RID: 11395
	public class ClientFollowShooterLeisureInteract : ActionParams
	{
		// Token: 0x0600FA3D RID: 64061 RVA: 0x00244EA8 File Offset: 0x002430A8
		public static ClientFollowShooterLeisureInteract Create(IClientFollowShooterLeisureInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientFollowShooterLeisureInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DE5 RID: 19941
		// (get) Token: 0x0600FA3E RID: 64062 RVA: 0x00244EC7 File Offset: 0x002430C7
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004DE6 RID: 19942
		// (get) Token: 0x0600FA3F RID: 64063 RVA: 0x00244ED4 File Offset: 0x002430D4
		public virtual IClientFollowShooterLeisureInteractType InteractType
		{
			get
			{
				if (this._InteractTypeInited)
				{
					return this._InteractTypeCache;
				}
				this._InteractTypeInited = true;
				this._InteractTypeCache = ActionReadHelper.ReadClientFollowShooterLeisureInteract_InteractType(this.Instance);
				return this._InteractTypeCache;
			}
		}

		// Token: 0x040088B5 RID: 34997
		private IClientFollowShooterLeisureInteract Instance;

		// Token: 0x040088B6 RID: 34998
		private IClientFollowShooterLeisureInteractType _InteractTypeCache;

		// Token: 0x040088B7 RID: 34999
		private bool _InteractTypeInited;
	}
}
