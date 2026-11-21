using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CB4 RID: 3252
	public class ILifeStageConfig
	{
		// Token: 0x06004A4E RID: 19022 RVA: 0x000BAE7B File Offset: 0x000B907B
		public static ILifeStageConfig Create(ILifeStageConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILifeStageConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x06004A4F RID: 19023 RVA: 0x000BAE9C File Offset: 0x000B909C
		public virtual float? PerformDuration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.PerformDuration);
			}
		}

		// Token: 0x04002A1B RID: 10779
		private ILifeStageConfig Instance;
	}
}
