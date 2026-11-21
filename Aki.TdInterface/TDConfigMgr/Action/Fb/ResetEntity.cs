using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C67 RID: 11367
	public class ResetEntity : ActionParams
	{
		// Token: 0x0600F9DC RID: 63964 RVA: 0x002445D0 File Offset: 0x002427D0
		public static ResetEntity Create(IResetEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ResetEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DBC RID: 19900
		// (get) Token: 0x0600F9DD RID: 63965 RVA: 0x002445EF File Offset: 0x002427EF
		public virtual IResetEntityConfig ResetEntityConfig
		{
			get
			{
				if (this._ResetEntityConfigInited)
				{
					return this._ResetEntityConfigCache;
				}
				this._ResetEntityConfigInited = true;
				this._ResetEntityConfigCache = ActionReadHelper.ReadResetEntity_ResetEntityConfig(this.Instance);
				return this._ResetEntityConfigCache;
			}
		}

		// Token: 0x04008885 RID: 34949
		private IResetEntity Instance;

		// Token: 0x04008886 RID: 34950
		private IResetEntityConfig _ResetEntityConfigCache;

		// Token: 0x04008887 RID: 34951
		private bool _ResetEntityConfigInited;
	}
}
