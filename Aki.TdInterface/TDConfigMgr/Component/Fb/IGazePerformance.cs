using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BDE RID: 3038
	public class IGazePerformance
	{
		// Token: 0x060045C3 RID: 17859 RVA: 0x000B2016 File Offset: 0x000B0216
		public static IGazePerformance Create(IGazePerformance? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGazePerformance
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x060045C4 RID: 17860 RVA: 0x000B2035 File Offset: 0x000B0235
		public virtual float FadeInTime
		{
			get
			{
				return this.Instance.FadeInTime;
			}
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x060045C5 RID: 17861 RVA: 0x000B2042 File Offset: 0x000B0242
		public virtual float StayTime
		{
			get
			{
				return this.Instance.StayTime;
			}
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x060045C6 RID: 17862 RVA: 0x000B2050 File Offset: 0x000B0250
		public virtual float? FadeOutTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.FadeOutTime);
			}
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x060045C7 RID: 17863 RVA: 0x000B2088 File Offset: 0x000B0288
		public virtual bool? LockCamera
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.LockCamera);
			}
		}

		// Token: 0x04002721 RID: 10017
		private IGazePerformance Instance;
	}
}
