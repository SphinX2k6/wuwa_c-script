using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029E6 RID: 10726
	public class IEntitySplineMoveTarget : ISplineMoveTargetType
	{
		// Token: 0x0600ED48 RID: 60744 RVA: 0x0022E36E File Offset: 0x0022C56E
		public static IEntitySplineMoveTarget Create(IEntitySplineMoveTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntitySplineMoveTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700462A RID: 17962
		// (get) Token: 0x0600ED49 RID: 60745 RVA: 0x0022E38D File Offset: 0x0022C58D
		public override ESplineMoveTargetType Type
		{
			get
			{
				return (ESplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x1700462B RID: 17963
		// (get) Token: 0x0600ED4A RID: 60746 RVA: 0x0022E39A File Offset: 0x0022C59A
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x1700462C RID: 17964
		// (get) Token: 0x0600ED4B RID: 60747 RVA: 0x0022E3A7 File Offset: 0x0022C5A7
		public virtual ISplineMoveDriveMode MoveDriveMode
		{
			get
			{
				if (this._MoveDriveModeInited)
				{
					return this._MoveDriveModeCache;
				}
				this._MoveDriveModeInited = true;
				this._MoveDriveModeCache = ActionReadHelper.ReadIEntitySplineMoveTarget_MoveDriveMode(this.Instance);
				return this._MoveDriveModeCache;
			}
		}

		// Token: 0x04008298 RID: 33432
		private IEntitySplineMoveTarget Instance;

		// Token: 0x04008299 RID: 33433
		private ISplineMoveDriveMode _MoveDriveModeCache;

		// Token: 0x0400829A RID: 33434
		private bool _MoveDriveModeInited;
	}
}
