using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002997 RID: 10647
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientFollowShooterLeisureInteract : ActionParams
	{
		// Token: 0x0600EBAE RID: 60334 RVA: 0x002275DC File Offset: 0x002257DC
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

		// Token: 0x17004A42 RID: 19010
		// (get) Token: 0x0600EBAF RID: 60335 RVA: 0x002275FB File Offset: 0x002257FB
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004A43 RID: 19011
		// (get) Token: 0x0600EBB0 RID: 60336 RVA: 0x00227608 File Offset: 0x00225808
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

		// Token: 0x040081C9 RID: 33225
		private IClientFollowShooterLeisureInteract Instance;

		// Token: 0x040081CA RID: 33226
		private IClientFollowShooterLeisureInteractType _InteractTypeCache;

		// Token: 0x040081CB RID: 33227
		private bool _InteractTypeInited;
	}
}
