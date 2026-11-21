using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B54 RID: 11092
	public class OpenSimpleGameplay : ActionParams
	{
		// Token: 0x0600F3D7 RID: 62423 RVA: 0x00239183 File Offset: 0x00237383
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

		// Token: 0x170049DD RID: 18909
		// (get) Token: 0x0600F3D8 RID: 62424 RVA: 0x002391A2 File Offset: 0x002373A2
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

		// Token: 0x170049DE RID: 18910
		// (get) Token: 0x0600F3D9 RID: 62425 RVA: 0x002391D1 File Offset: 0x002373D1
		[Nullable(2)]
		public virtual string FinishSendSelfEvent
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.FinishSendSelfEvent;
			}
		}

		// Token: 0x170049DF RID: 18911
		// (get) Token: 0x0600F3DA RID: 62426 RVA: 0x002391DE File Offset: 0x002373DE
		[Nullable(2)]
		public virtual string FailSendSelfEvent
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.FailSendSelfEvent;
			}
		}

		// Token: 0x040085BE RID: 34238
		private IOpenSimpleGameplay Instance;

		// Token: 0x040085BF RID: 34239
		private IUiGame _GameplayConfigCache;

		// Token: 0x040085C0 RID: 34240
		private bool _GameplayConfigInited;
	}
}
