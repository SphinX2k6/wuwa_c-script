using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200252B RID: 9515
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeLimitOptionGroup
	{
		// Token: 0x0600D424 RID: 54308 RVA: 0x001F69BB File Offset: 0x001F4BBB
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

		// Token: 0x17003B90 RID: 15248
		// (get) Token: 0x0600D425 RID: 54309 RVA: 0x001F69DA File Offset: 0x001F4BDA
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

		// Token: 0x04007433 RID: 29747
		private ITimeLimitOptionGroup Instance;

		// Token: 0x04007434 RID: 29748
		[Nullable(2)]
		private ITimeLimitOptionGroupDefault _StyleCache;

		// Token: 0x04007435 RID: 29749
		private bool _StyleInited;
	}
}
