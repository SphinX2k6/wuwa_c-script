using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B87 RID: 11143
	public class IAdjustFixedCameraRotateConfig
	{
		// Token: 0x0600F530 RID: 62768 RVA: 0x0023BD42 File Offset: 0x00239F42
		public static IAdjustFixedCameraRotateConfig Create(IAdjustFixedCameraRotateConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAdjustFixedCameraRotateConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AD0 RID: 19152
		// (get) Token: 0x0600F531 RID: 62769 RVA: 0x0023BD61 File Offset: 0x00239F61
		public virtual float YawLimitMin
		{
			get
			{
				return this.Instance.YawLimitMin;
			}
		}

		// Token: 0x17004AD1 RID: 19153
		// (get) Token: 0x0600F532 RID: 62770 RVA: 0x0023BD6E File Offset: 0x00239F6E
		public virtual float YawLimitMax
		{
			get
			{
				return this.Instance.YawLimitMax;
			}
		}

		// Token: 0x17004AD2 RID: 19154
		// (get) Token: 0x0600F533 RID: 62771 RVA: 0x0023BD7B File Offset: 0x00239F7B
		public virtual float PitchLimitMin
		{
			get
			{
				return this.Instance.PitchLimitMin;
			}
		}

		// Token: 0x17004AD3 RID: 19155
		// (get) Token: 0x0600F534 RID: 62772 RVA: 0x0023BD88 File Offset: 0x00239F88
		public virtual float PitchLimitMax
		{
			get
			{
				return this.Instance.PitchLimitMax;
			}
		}

		// Token: 0x17004AD4 RID: 19156
		// (get) Token: 0x0600F535 RID: 62773 RVA: 0x0023BD95 File Offset: 0x00239F95
		public virtual float YawRotateSpeed
		{
			get
			{
				return this.Instance.YawRotateSpeed;
			}
		}

		// Token: 0x17004AD5 RID: 19157
		// (get) Token: 0x0600F536 RID: 62774 RVA: 0x0023BDA2 File Offset: 0x00239FA2
		public virtual float PitchRotateSpeed
		{
			get
			{
				return this.Instance.PitchRotateSpeed;
			}
		}

		// Token: 0x04008669 RID: 34409
		private IAdjustFixedCameraRotateConfig Instance;
	}
}
