using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002981 RID: 10625
	[NullableContext(1)]
	[Nullable(0)]
	public class ResetEntity : ActionParams
	{
		// Token: 0x0600EB61 RID: 60257 RVA: 0x00226E78 File Offset: 0x00225078
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

		// Token: 0x17004A21 RID: 18977
		// (get) Token: 0x0600EB62 RID: 60258 RVA: 0x00226E97 File Offset: 0x00225097
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

		// Token: 0x040081A1 RID: 33185
		private IResetEntity Instance;

		// Token: 0x040081A2 RID: 33186
		private IResetEntityConfig _ResetEntityConfigCache;

		// Token: 0x040081A3 RID: 33187
		private bool _ResetEntityConfigInited;
	}
}
