using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A99 RID: 10905
	public class RotatorEntity : ActionParams
	{
		// Token: 0x0600F095 RID: 61589 RVA: 0x00233F51 File Offset: 0x00232151
		public static RotatorEntity Create(IRotatorEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RotatorEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004811 RID: 18449
		// (get) Token: 0x0600F096 RID: 61590 RVA: 0x00233F70 File Offset: 0x00232170
		public virtual ITargetEntityType Entity
		{
			get
			{
				if (this._EntityInited)
				{
					return this._EntityCache;
				}
				this._EntityInited = true;
				this._EntityCache = ActionReadHelper.ReadRotatorEntity_Entity(this.Instance);
				return this._EntityCache;
			}
		}

		// Token: 0x0400844B RID: 33867
		private IRotatorEntity Instance;

		// Token: 0x0400844C RID: 33868
		private ITargetEntityType _EntityCache;

		// Token: 0x0400844D RID: 33869
		private bool _EntityInited;
	}
}
