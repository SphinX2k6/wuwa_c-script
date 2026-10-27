using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BAF RID: 2991
	public class INpcStandbyShowMode
	{
		// Token: 0x06004499 RID: 17561 RVA: 0x000AE2E4 File Offset: 0x000AC4E4
		[NullableContext(1)]
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

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x0600449A RID: 17562 RVA: 0x000AE303 File Offset: 0x000AC503
		public virtual ENpcStandbyShowMode Type
		{
			get
			{
				return (ENpcStandbyShowMode)this.Instance.Type;
			}
		}

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x0600449B RID: 17563 RVA: 0x000AE310 File Offset: 0x000AC510
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<INpcLookAtConfig> LookAtConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x040026C6 RID: 9926
		private INpcStandbyShowMode Instance;

		// Token: 0x040026C7 RID: 9927
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x040026C8 RID: 9928
		private bool _LookAtConfigsInited;
	}
}
