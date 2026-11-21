using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028F0 RID: 10480
	public class EntityTurnTo : ActionParams
	{
		// Token: 0x0600E92B RID: 59691 RVA: 0x00226FFC File Offset: 0x002251FC
		public static EntityTurnTo Create(IEntityTurnTo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EntityTurnTo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043F9 RID: 17401
		// (get) Token: 0x0600E92C RID: 59692 RVA: 0x0022701B File Offset: 0x0022521B
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170043FA RID: 17402
		// (get) Token: 0x0600E92D RID: 59693 RVA: 0x00227028 File Offset: 0x00225228
		public virtual IActorTurnToData Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadEntityTurnTo_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x170043FB RID: 17403
		// (get) Token: 0x0600E92E RID: 59694 RVA: 0x00227058 File Offset: 0x00225258
		public virtual bool? UseLookAtForSmallAngle
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.UseLookAtForSmallAngle);
			}
		}

		// Token: 0x04008078 RID: 32888
		private IEntityTurnTo Instance;

		// Token: 0x04008079 RID: 32889
		private IActorTurnToData _TargetCache;

		// Token: 0x0400807A RID: 32890
		private bool _TargetInited;
	}
}
