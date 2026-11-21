using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BFB RID: 11259
	public class IGamepadShakeInTalk
	{
		// Token: 0x0600F7F4 RID: 63476 RVA: 0x00241169 File Offset: 0x0023F369
		public static IGamepadShakeInTalk Create(IGamepadShakeInTalk? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGamepadShakeInTalk
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CAC RID: 19628
		// (get) Token: 0x0600F7F5 RID: 63477 RVA: 0x00241188 File Offset: 0x0023F388
		public virtual float DelayTime
		{
			get
			{
				return this.Instance.DelayTime;
			}
		}

		// Token: 0x17004CAD RID: 19629
		// (get) Token: 0x0600F7F6 RID: 63478 RVA: 0x00241195 File Offset: 0x0023F395
		public virtual IGamepadShakeOptions Options
		{
			get
			{
				if (this._OptionsInited)
				{
					return this._OptionsCache;
				}
				this._OptionsInited = true;
				this._OptionsCache = IGamepadShakeOptions.Create(this.Instance.Options);
				return this._OptionsCache;
			}
		}

		// Token: 0x040087B9 RID: 34745
		private IGamepadShakeInTalk Instance;

		// Token: 0x040087BA RID: 34746
		[Nullable(2)]
		private IGamepadShakeOptions _OptionsCache;

		// Token: 0x040087BB RID: 34747
		private bool _OptionsInited;
	}
}
