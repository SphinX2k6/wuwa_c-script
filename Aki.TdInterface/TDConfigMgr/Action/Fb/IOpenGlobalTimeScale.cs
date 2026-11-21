using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027A3 RID: 10147
	public class IOpenGlobalTimeScale : ISetGlobalTimeScaleType
	{
		// Token: 0x0600E0B9 RID: 57529 RVA: 0x00211056 File Offset: 0x0020F256
		public static IOpenGlobalTimeScale Create(IOpenGlobalTimeScale? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenGlobalTimeScale
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E21 RID: 15905
		// (get) Token: 0x0600E0BA RID: 57530 RVA: 0x00211075 File Offset: 0x0020F275
		public override ESetTimeScaleType Type
		{
			get
			{
				return (ESetTimeScaleType)this.Instance.Type;
			}
		}

		// Token: 0x17003E22 RID: 15906
		// (get) Token: 0x0600E0BB RID: 57531 RVA: 0x00211082 File Offset: 0x0020F282
		public virtual float TimeScale
		{
			get
			{
				return this.Instance.TimeScale;
			}
		}

		// Token: 0x17003E23 RID: 15907
		// (get) Token: 0x0600E0BC RID: 57532 RVA: 0x0021108F File Offset: 0x0020F28F
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x04007A35 RID: 31285
		private IOpenGlobalTimeScale Instance;
	}
}
