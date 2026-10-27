using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028B2 RID: 10418
	public class IAdjustFixedCameraRotateConfig
	{
		// Token: 0x0600E701 RID: 59137 RVA: 0x0021EDC2 File Offset: 0x0021CFC2
		[NullableContext(1)]
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

		// Token: 0x1700475F RID: 18271
		// (get) Token: 0x0600E702 RID: 59138 RVA: 0x0021EDE1 File Offset: 0x0021CFE1
		public virtual float YawLimitMin
		{
			get
			{
				return this.Instance.YawLimitMin;
			}
		}

		// Token: 0x17004760 RID: 18272
		// (get) Token: 0x0600E703 RID: 59139 RVA: 0x0021EDEE File Offset: 0x0021CFEE
		public virtual float YawLimitMax
		{
			get
			{
				return this.Instance.YawLimitMax;
			}
		}

		// Token: 0x17004761 RID: 18273
		// (get) Token: 0x0600E704 RID: 59140 RVA: 0x0021EDFB File Offset: 0x0021CFFB
		public virtual float PitchLimitMin
		{
			get
			{
				return this.Instance.PitchLimitMin;
			}
		}

		// Token: 0x17004762 RID: 18274
		// (get) Token: 0x0600E705 RID: 59141 RVA: 0x0021EE08 File Offset: 0x0021D008
		public virtual float PitchLimitMax
		{
			get
			{
				return this.Instance.PitchLimitMax;
			}
		}

		// Token: 0x17004763 RID: 18275
		// (get) Token: 0x0600E706 RID: 59142 RVA: 0x0021EE15 File Offset: 0x0021D015
		public virtual float YawRotateSpeed
		{
			get
			{
				return this.Instance.YawRotateSpeed;
			}
		}

		// Token: 0x17004764 RID: 18276
		// (get) Token: 0x0600E707 RID: 59143 RVA: 0x0021EE22 File Offset: 0x0021D022
		public virtual float PitchRotateSpeed
		{
			get
			{
				return this.Instance.PitchRotateSpeed;
			}
		}

		// Token: 0x04007FAA RID: 32682
		private IAdjustFixedCameraRotateConfig Instance;
	}
}
