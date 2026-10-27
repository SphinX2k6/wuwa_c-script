using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002883 RID: 10371
	[NullableContext(1)]
	[Nullable(0)]
	public class CloseSimpleGameplay : ActionParams
	{
		// Token: 0x0600E5B8 RID: 58808 RVA: 0x0021C37C File Offset: 0x0021A57C
		public static CloseSimpleGameplay Create(ICloseSimpleGameplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CloseSimpleGameplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004674 RID: 18036
		// (get) Token: 0x0600E5B9 RID: 58809 RVA: 0x0021C39B File Offset: 0x0021A59B
		public virtual ICloseUiGame GameplayConfig
		{
			get
			{
				if (this._GameplayConfigInited)
				{
					return this._GameplayConfigCache;
				}
				this._GameplayConfigInited = true;
				this._GameplayConfigCache = ActionReadHelper.ReadCloseSimpleGameplay_GameplayConfig(this.Instance);
				return this._GameplayConfigCache;
			}
		}

		// Token: 0x04007F05 RID: 32517
		private ICloseSimpleGameplay Instance;

		// Token: 0x04007F06 RID: 32518
		private ICloseUiGame _GameplayConfigCache;

		// Token: 0x04007F07 RID: 32519
		private bool _GameplayConfigInited;
	}
}
