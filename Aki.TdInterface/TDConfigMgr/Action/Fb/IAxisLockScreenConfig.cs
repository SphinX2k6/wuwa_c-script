using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028B4 RID: 10420
	public class IAxisLockScreenConfig : ActionParams
	{
		// Token: 0x0600E729 RID: 59177 RVA: 0x0021F33A File Offset: 0x0021D53A
		[NullableContext(1)]
		public static IAxisLockScreenConfig Create(IAxisLockScreenConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAxisLockScreenConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004783 RID: 18307
		// (get) Token: 0x0600E72A RID: 59178 RVA: 0x0021F359 File Offset: 0x0021D559
		public virtual float TriggerAngle
		{
			get
			{
				return this.Instance.TriggerAngle;
			}
		}

		// Token: 0x17004784 RID: 18308
		// (get) Token: 0x0600E72B RID: 59179 RVA: 0x0021F366 File Offset: 0x0021D566
		public virtual float FadeInTime
		{
			get
			{
				return this.Instance.FadeInTime;
			}
		}

		// Token: 0x17004785 RID: 18309
		// (get) Token: 0x0600E72C RID: 59180 RVA: 0x0021F373 File Offset: 0x0021D573
		public virtual float FadeOutTime
		{
			get
			{
				return this.Instance.FadeOutTime;
			}
		}

		// Token: 0x04007FC4 RID: 32708
		private IAxisLockScreenConfig Instance;
	}
}
