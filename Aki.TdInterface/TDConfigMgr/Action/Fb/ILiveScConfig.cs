using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E29 RID: 11817
	public class ILiveScConfig
	{
		// Token: 0x0601009A RID: 65690 RVA: 0x0024E7F4 File Offset: 0x0024C9F4
		public static ILiveScConfig Create(ILiveScConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveScConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050F6 RID: 20726
		// (get) Token: 0x0601009B RID: 65691 RVA: 0x0024E813 File Offset: 0x0024CA13
		public virtual int ScId
		{
			get
			{
				return this.Instance.ScId;
			}
		}

		// Token: 0x170050F7 RID: 20727
		// (get) Token: 0x0601009C RID: 65692 RVA: 0x0024E820 File Offset: 0x0024CA20
		public virtual float DelayTime
		{
			get
			{
				return this.Instance.DelayTime;
			}
		}

		// Token: 0x04008BF9 RID: 35833
		private ILiveScConfig Instance;
	}
}
