using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E27 RID: 11815
	public class ILiveLikeParam : ILiveParamConfig
	{
		// Token: 0x06010093 RID: 65683 RVA: 0x0024E75D File Offset: 0x0024C95D
		public static ILiveLikeParam Create(ILiveLikeParam? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveLikeParam
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050F3 RID: 20723
		// (get) Token: 0x06010094 RID: 65684 RVA: 0x0024E77C File Offset: 0x0024C97C
		public override ELiveParamType Type
		{
			get
			{
				return (ELiveParamType)this.Instance.Type;
			}
		}

		// Token: 0x170050F4 RID: 20724
		// (get) Token: 0x06010095 RID: 65685 RVA: 0x0024E789 File Offset: 0x0024C989
		public virtual ELiveLikeState State
		{
			get
			{
				return (ELiveLikeState)this.Instance.State;
			}
		}

		// Token: 0x04008BF5 RID: 35829
		private ILiveLikeParam Instance;
	}
}
