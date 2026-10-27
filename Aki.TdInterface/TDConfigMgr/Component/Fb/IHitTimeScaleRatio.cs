using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B6E RID: 2926
	public class IHitTimeScaleRatio
	{
		// Token: 0x06004361 RID: 17249 RVA: 0x000ABC69 File Offset: 0x000A9E69
		[NullableContext(1)]
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

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x06004362 RID: 17250 RVA: 0x000ABC88 File Offset: 0x000A9E88
		public virtual float TimeRatio
		{
			get
			{
				return this.Instance.TimeRatio;
			}
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x06004363 RID: 17251 RVA: 0x000ABC98 File Offset: 0x000A9E98
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

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x06004364 RID: 17252 RVA: 0x000ABCCE File Offset: 0x000A9ECE
		public virtual float ValueRatio
		{
			get
			{
				return this.Instance.ValueRatio;
			}
		}

		// Token: 0x040025FD RID: 9725
		private IHitTimeScaleRatio Instance;
	}
}
