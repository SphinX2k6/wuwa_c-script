using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D63 RID: 11619
	public class ILookAtTarget : IDefaultLookAtType
	{
		// Token: 0x0600FD97 RID: 64919 RVA: 0x00249D70 File Offset: 0x00247F70
		public static ILookAtTarget Create(ILookAtTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILookAtTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F7F RID: 20351
		// (get) Token: 0x0600FD98 RID: 64920 RVA: 0x00249D8F File Offset: 0x00247F8F
		public override EDefaultLookAtType Type
		{
			get
			{
				return (EDefaultLookAtType)this.Instance.Type;
			}
		}

		// Token: 0x17004F80 RID: 20352
		// (get) Token: 0x0600FD99 RID: 64921 RVA: 0x00249D9C File Offset: 0x00247F9C
		public virtual List<INpcLookAtConfig> LookAtConfigs
		{
			get
			{
				if (this._LookAtConfigsInited)
				{
					return this._LookAtConfigsCache;
				}
				this._LookAtConfigsInited = true;
				int lookAtConfigsLength = this.Instance.LookAtConfigsLength;
				this._LookAtConfigsCache = new List<INpcLookAtConfig>(lookAtConfigsLength);
				for (int i = 0; i < lookAtConfigsLength; i++)
				{
					this._LookAtConfigsCache.Add(INpcLookAtConfig.Create(this.Instance.LookAtConfigs(i)));
				}
				return this._LookAtConfigsCache;
			}
		}

		// Token: 0x04008A6D RID: 35437
		private ILookAtTarget Instance;

		// Token: 0x04008A6E RID: 35438
		private List<INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x04008A6F RID: 35439
		private bool _LookAtConfigsInited;
	}
}
