using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200288D RID: 10381
	public class ModifySceneUiSubtitle : ActionParams
	{
		// Token: 0x0600E754 RID: 59220 RVA: 0x0022379F File Offset: 0x0022199F
		public static ModifySceneUiSubtitle Create(IModifySceneUiSubtitle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ModifySceneUiSubtitle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042E8 RID: 17128
		// (get) Token: 0x0600E755 RID: 59221 RVA: 0x002237BE File Offset: 0x002219BE
		public virtual ISceneUiSubtitleOperationBase Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadModifySceneUiSubtitle_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x04007F61 RID: 32609
		private IModifySceneUiSubtitle Instance;

		// Token: 0x04007F62 RID: 32610
		private ISceneUiSubtitleOperationBase _ConfigCache;

		// Token: 0x04007F63 RID: 32611
		private bool _ConfigInited;
	}
}
