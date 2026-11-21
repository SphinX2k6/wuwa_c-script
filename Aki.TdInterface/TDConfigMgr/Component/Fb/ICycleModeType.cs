using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D1A RID: 3354
	public class ICycleModeType
	{
		// Token: 0x06004C6C RID: 19564 RVA: 0x000BF577 File Offset: 0x000BD777
		public static ICycleModeType Create(ICycleModeType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICycleModeType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06004C6D RID: 19565 RVA: 0x000BF596 File Offset: 0x000BD796
		public virtual EPatrolCycleMode Type
		{
			get
			{
				return (EPatrolCycleMode)this.Instance.Type;
			}
		}

		// Token: 0x04002B4F RID: 11087
		private ICycleModeType Instance;
	}
}
