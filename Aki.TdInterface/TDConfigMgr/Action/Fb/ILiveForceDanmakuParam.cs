using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E26 RID: 11814
	public class ILiveForceDanmakuParam : ILiveParamConfig
	{
		// Token: 0x0601008F RID: 65679 RVA: 0x0024E71C File Offset: 0x0024C91C
		public static ILiveForceDanmakuParam Create(ILiveForceDanmakuParam? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveForceDanmakuParam
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050F1 RID: 20721
		// (get) Token: 0x06010090 RID: 65680 RVA: 0x0024E73B File Offset: 0x0024C93B
		public override ELiveParamType Type
		{
			get
			{
				return (ELiveParamType)this.Instance.Type;
			}
		}

		// Token: 0x170050F2 RID: 20722
		// (get) Token: 0x06010091 RID: 65681 RVA: 0x0024E748 File Offset: 0x0024C948
		public virtual ELiveForceDanmakuState State
		{
			get
			{
				return (ELiveForceDanmakuState)this.Instance.State;
			}
		}

		// Token: 0x04008BF4 RID: 35828
		private ILiveForceDanmakuParam Instance;
	}
}
