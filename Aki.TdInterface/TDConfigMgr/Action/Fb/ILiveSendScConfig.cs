using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E2B RID: 11819
	public class ILiveSendScConfig : ILiveScOperation
	{
		// Token: 0x060100A1 RID: 65697 RVA: 0x0024E869 File Offset: 0x0024CA69
		public static ILiveSendScConfig Create(ILiveSendScConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveSendScConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050F9 RID: 20729
		// (get) Token: 0x060100A2 RID: 65698 RVA: 0x0024E888 File Offset: 0x0024CA88
		public override ELiveScOperationType Type
		{
			get
			{
				return (ELiveScOperationType)this.Instance.Type;
			}
		}

		// Token: 0x170050FA RID: 20730
		// (get) Token: 0x060100A3 RID: 65699 RVA: 0x0024E898 File Offset: 0x0024CA98
		public virtual List<ILiveScConfig> ScList
		{
			get
			{
				if (this._ScListInited)
				{
					return this._ScListCache;
				}
				this._ScListInited = true;
				int scListLength = this.Instance.ScListLength;
				this._ScListCache = new List<ILiveScConfig>(scListLength);
				for (int i = 0; i < scListLength; i++)
				{
					this._ScListCache.Add(ILiveScConfig.Create(this.Instance.ScList(i)));
				}
				return this._ScListCache;
			}
		}

		// Token: 0x04008BFB RID: 35835
		private ILiveSendScConfig Instance;

		// Token: 0x04008BFC RID: 35836
		private List<ILiveScConfig> _ScListCache;

		// Token: 0x04008BFD RID: 35837
		private bool _ScListInited;
	}
}
