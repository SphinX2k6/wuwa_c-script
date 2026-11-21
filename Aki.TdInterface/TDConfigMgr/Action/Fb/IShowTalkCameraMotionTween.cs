using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027EC RID: 10220
	public class IShowTalkCameraMotionTween : IShowTalkCameraMotion
	{
		// Token: 0x0600E219 RID: 57881 RVA: 0x00213A73 File Offset: 0x00211C73
		public static IShowTalkCameraMotionTween Create(IShowTalkCameraMotionTween? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowTalkCameraMotionTween
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003EEF RID: 16111
		// (get) Token: 0x0600E21A RID: 57882 RVA: 0x00213A92 File Offset: 0x00211C92
		public override EShowTalkCameraMotionType Type
		{
			get
			{
				return (EShowTalkCameraMotionType)this.Instance.Type;
			}
		}

		// Token: 0x17003EF0 RID: 16112
		// (get) Token: 0x0600E21B RID: 57883 RVA: 0x00213A9F File Offset: 0x00211C9F
		public virtual ICameraParams Start
		{
			get
			{
				if (this._StartInited)
				{
					return this._StartCache;
				}
				this._StartInited = true;
				this._StartCache = ICameraParams.Create(this.Instance.Start);
				return this._StartCache;
			}
		}

		// Token: 0x17003EF1 RID: 16113
		// (get) Token: 0x0600E21C RID: 57884 RVA: 0x00213AD3 File Offset: 0x00211CD3
		public virtual ICameraParams End
		{
			get
			{
				if (this._EndInited)
				{
					return this._EndCache;
				}
				this._EndInited = true;
				this._EndCache = ICameraParams.Create(this.Instance.End);
				return this._EndCache;
			}
		}

		// Token: 0x17003EF2 RID: 16114
		// (get) Token: 0x0600E21D RID: 57885 RVA: 0x00213B07 File Offset: 0x00211D07
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x17003EF3 RID: 16115
		// (get) Token: 0x0600E21E RID: 57886 RVA: 0x00213B14 File Offset: 0x00211D14
		public virtual EEaseType? EaseType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EEaseType?((EEaseType)this.Instance.EaseType);
			}
		}

		// Token: 0x17003EF4 RID: 16116
		// (get) Token: 0x0600E21F RID: 57887 RVA: 0x00213B4A File Offset: 0x00211D4A
		[Nullable(2)]
		public virtual IFlowCameraShake CamShake
		{
			[NullableContext(2)]
			get
			{
				if (this._CamShakeInited)
				{
					return this._CamShakeCache;
				}
				this._CamShakeInited = true;
				this._CamShakeCache = IFlowCameraShake.Create(this.Instance.CamShake);
				return this._CamShakeCache;
			}
		}

		// Token: 0x04007AEC RID: 31468
		private IShowTalkCameraMotionTween Instance;

		// Token: 0x04007AED RID: 31469
		[Nullable(2)]
		private ICameraParams _StartCache;

		// Token: 0x04007AEE RID: 31470
		private bool _StartInited;

		// Token: 0x04007AEF RID: 31471
		[Nullable(2)]
		private ICameraParams _EndCache;

		// Token: 0x04007AF0 RID: 31472
		private bool _EndInited;

		// Token: 0x04007AF1 RID: 31473
		[Nullable(2)]
		private IFlowCameraShake _CamShakeCache;

		// Token: 0x04007AF2 RID: 31474
		private bool _CamShakeInited;
	}
}
