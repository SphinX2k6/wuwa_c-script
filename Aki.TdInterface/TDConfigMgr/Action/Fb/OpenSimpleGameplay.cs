using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200287E RID: 10366
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSimpleGameplay : ActionParams
	{
		// Token: 0x0600E5A6 RID: 58790 RVA: 0x0021C22F File Offset: 0x0021A42F
		public static OpenSimpleGameplay Create(IOpenSimpleGameplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new OpenSimpleGameplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700466C RID: 18028
		// (get) Token: 0x0600E5A7 RID: 58791 RVA: 0x0021C24E File Offset: 0x0021A44E
		public virtual IUiGame GameplayConfig
		{
			get
			{
				if (this._GameplayConfigInited)
				{
					return this._GameplayConfigCache;
				}
				this._GameplayConfigInited = true;
				this._GameplayConfigCache = ActionReadHelper.ReadOpenSimpleGameplay_GameplayConfig(this.Instance);
				return this._GameplayConfigCache;
			}
		}

		// Token: 0x1700466D RID: 18029
		// (get) Token: 0x0600E5A8 RID: 58792 RVA: 0x0021C27D File Offset: 0x0021A47D
		[Nullable(2)]
		public virtual string FinishSendSelfEvent
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.FinishSendSelfEvent;
			}
		}

		// Token: 0x1700466E RID: 18030
		// (get) Token: 0x0600E5A9 RID: 58793 RVA: 0x0021C28A File Offset: 0x0021A48A
		[Nullable(2)]
		public virtual string FailSendSelfEvent
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.FailSendSelfEvent;
			}
		}

		// Token: 0x04007EFE RID: 32510
		private IOpenSimpleGameplay Instance;

		// Token: 0x04007EFF RID: 32511
		private IUiGame _GameplayConfigCache;

		// Token: 0x04007F00 RID: 32512
		private bool _GameplayConfigInited;
	}
}
