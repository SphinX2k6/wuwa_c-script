using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A6F RID: 10863
	[NullableContext(1)]
	[Nullable(0)]
	public class ILookAtTarget : IDefaultLookAtType
	{
		// Token: 0x0600EEE1 RID: 61153 RVA: 0x0022C064 File Offset: 0x0022A264
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

		// Token: 0x17004BC5 RID: 19397
		// (get) Token: 0x0600EEE2 RID: 61154 RVA: 0x0022C083 File Offset: 0x0022A283
		public override EDefaultLookAtType Type
		{
			get
			{
				return (EDefaultLookAtType)this.Instance.Type;
			}
		}

		// Token: 0x17004BC6 RID: 19398
		// (get) Token: 0x0600EEE3 RID: 61155 RVA: 0x0022C090 File Offset: 0x0022A290
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

		// Token: 0x04008369 RID: 33641
		private ILookAtTarget Instance;

		// Token: 0x0400836A RID: 33642
		private List<INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x0400836B RID: 33643
		private bool _LookAtConfigsInited;
	}
}
