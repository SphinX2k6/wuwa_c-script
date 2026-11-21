using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200290E RID: 10510
	public class ModifyEntityDecoration : ActionParams
	{
		// Token: 0x0600E9B4 RID: 59828 RVA: 0x002280B0 File Offset: 0x002262B0
		public static ModifyEntityDecoration Create(IModifyEntityDecoration? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ModifyEntityDecoration
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004446 RID: 17478
		// (get) Token: 0x0600E9B5 RID: 59829 RVA: 0x002280CF File Offset: 0x002262CF
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004447 RID: 17479
		// (get) Token: 0x0600E9B6 RID: 59830 RVA: 0x002280DC File Offset: 0x002262DC
		public virtual IEntityDecorationConfig Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadModifyEntityDecoration_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x040080CE RID: 32974
		private IModifyEntityDecoration Instance;

		// Token: 0x040080CF RID: 32975
		private IEntityDecorationConfig _ConfigCache;

		// Token: 0x040080D0 RID: 32976
		private bool _ConfigInited;
	}
}
