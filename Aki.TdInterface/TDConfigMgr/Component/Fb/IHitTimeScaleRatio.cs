using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C3C RID: 3132
	public class IHitTimeScaleRatio
	{
		// Token: 0x060047BA RID: 18362 RVA: 0x000B5D2D File Offset: 0x000B3F2D
		public static IHitTimeScaleRatio Create(IHitTimeScaleRatio? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitTimeScaleRatio
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x060047BB RID: 18363 RVA: 0x000B5D4C File Offset: 0x000B3F4C
		public virtual float TimeRatio
		{
			get
			{
				return this.Instance.TimeRatio;
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x060047BC RID: 18364 RVA: 0x000B5D5C File Offset: 0x000B3F5C
		public virtual float? MaxExtraTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.MaxExtraTime);
			}
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x060047BD RID: 18365 RVA: 0x000B5D92 File Offset: 0x000B3F92
		public virtual float ValueRatio
		{
			get
			{
				return this.Instance.ValueRatio;
			}
		}

		// Token: 0x04002845 RID: 10309
		private IHitTimeScaleRatio Instance;
	}
}
