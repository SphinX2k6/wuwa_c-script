using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027D4 RID: 10196
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAutoPlayConfig
	{
		// Token: 0x0600E18B RID: 57739 RVA: 0x002124E2 File Offset: 0x002106E2
		[NullableContext(0)]
		public static ITalkItemAutoPlayConfig Create(ITalkItemAutoPlayConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAutoPlayConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E91 RID: 16017
		// (get) Token: 0x0600E18C RID: 57740 RVA: 0x00212501 File Offset: 0x00210701
		public virtual ITalkItemDisableAutoSelectOptionGroup DisableAutoSelectOptionGroup
		{
			get
			{
				if (this._DisableAutoSelectOptionGroupInited)
				{
					return this._DisableAutoSelectOptionGroupCache;
				}
				this._DisableAutoSelectOptionGroupInited = true;
				this._DisableAutoSelectOptionGroupCache = ITalkItemDisableAutoSelectOptionGroup.Create(this.Instance.DisableAutoSelectOptionGroup);
				return this._DisableAutoSelectOptionGroupCache;
			}
		}

		// Token: 0x04007A8C RID: 31372
		private ITalkItemAutoPlayConfig Instance;

		// Token: 0x04007A8D RID: 31373
		private ITalkItemDisableAutoSelectOptionGroup _DisableAutoSelectOptionGroupCache;

		// Token: 0x04007A8E RID: 31374
		private bool _DisableAutoSelectOptionGroupInited;
	}
}
