using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027D2 RID: 10194
	public class ITimeLimitOptionGroup
	{
		// Token: 0x0600E184 RID: 57732 RVA: 0x0021241B File Offset: 0x0021061B
		public static ITimeLimitOptionGroup Create(ITimeLimitOptionGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeLimitOptionGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E8E RID: 16014
		// (get) Token: 0x0600E185 RID: 57733 RVA: 0x0021243A File Offset: 0x0021063A
		public virtual ITimeLimitOptionGroupDefault Style
		{
			get
			{
				if (this._StyleInited)
				{
					return this._StyleCache;
				}
				this._StyleInited = true;
				this._StyleCache = ITimeLimitOptionGroupDefault.Create(this.Instance.Style);
				return this._StyleCache;
			}
		}

		// Token: 0x04007A88 RID: 31368
		private ITimeLimitOptionGroup Instance;

		// Token: 0x04007A89 RID: 31369
		[Nullable(2)]
		private ITimeLimitOptionGroupDefault _StyleCache;

		// Token: 0x04007A8A RID: 31370
		private bool _StyleInited;
	}
}
