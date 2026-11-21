using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C7D RID: 3197
	public class INpcStandbyShowMode
	{
		// Token: 0x060048F2 RID: 18674 RVA: 0x000B83A8 File Offset: 0x000B65A8
		public static INpcStandbyShowMode Create(INpcStandbyShowMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcStandbyShowMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x060048F3 RID: 18675 RVA: 0x000B83C7 File Offset: 0x000B65C7
		public virtual ENpcStandbyShowMode Type
		{
			get
			{
				return (ENpcStandbyShowMode)this.Instance.Type;
			}
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x060048F4 RID: 18676 RVA: 0x000B83D4 File Offset: 0x000B65D4
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<INpcLookAtConfig> LookAtConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._LookAtConfigsInited)
				{
					return this._LookAtConfigsCache;
				}
				this._LookAtConfigsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int lookAtConfigsLength = this.Instance.LookAtConfigsLength;
				this._LookAtConfigsCache = new List<INpcLookAtConfig>(lookAtConfigsLength);
				for (int i = 0; i < lookAtConfigsLength; i++)
				{
					this._LookAtConfigsCache.Add(INpcLookAtConfig.Create(this.Instance.LookAtConfigs(i)));
				}
				return this._LookAtConfigsCache;
			}
		}

		// Token: 0x0400290E RID: 10510
		private INpcStandbyShowMode Instance;

		// Token: 0x0400290F RID: 10511
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x04002910 RID: 10512
		private bool _LookAtConfigsInited;
	}
}
