using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E2C RID: 11820
	public class ILiveClearScConfig : ILiveScOperation
	{
		// Token: 0x060100A5 RID: 65701 RVA: 0x0024E909 File Offset: 0x0024CB09
		public static ILiveClearScConfig Create(ILiveClearScConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveClearScConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050FB RID: 20731
		// (get) Token: 0x060100A6 RID: 65702 RVA: 0x0024E928 File Offset: 0x0024CB28
		public override ELiveScOperationType Type
		{
			get
			{
				return (ELiveScOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008BFE RID: 35838
		private ILiveClearScConfig Instance;
	}
}
