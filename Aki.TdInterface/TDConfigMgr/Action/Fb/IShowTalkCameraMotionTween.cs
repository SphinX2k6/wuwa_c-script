using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002545 RID: 9541
	[NullableContext(1)]
	[Nullable(0)]
	public class IShowTalkCameraMotionTween : IShowTalkCameraMotion
	{
		// Token: 0x0600D4B9 RID: 54457 RVA: 0x001F8013 File Offset: 0x001F6213
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

		// Token: 0x17003BF1 RID: 15345
		// (get) Token: 0x0600D4BA RID: 54458 RVA: 0x001F8032 File Offset: 0x001F6232
		public override EShowTalkCameraMotionType Type
		{
			get
			{
				return (EShowTalkCameraMotionType)this.Instance.Type;
			}
		}

		// Token: 0x17003BF2 RID: 15346
		// (get) Token: 0x0600D4BB RID: 54459 RVA: 0x001F803F File Offset: 0x001F623F
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

		// Token: 0x17003BF3 RID: 15347
		// (get) Token: 0x0600D4BC RID: 54460 RVA: 0x001F8073 File Offset: 0x001F6273
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

		// Token: 0x17003BF4 RID: 15348
		// (get) Token: 0x0600D4BD RID: 54461 RVA: 0x001F80A7 File Offset: 0x001F62A7
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x17003BF5 RID: 15349
		// (get) Token: 0x0600D4BE RID: 54462 RVA: 0x001F80B4 File Offset: 0x001F62B4
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

		// Token: 0x17003BF6 RID: 15350
		// (get) Token: 0x0600D4BF RID: 54463 RVA: 0x001F80EA File Offset: 0x001F62EA
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

		// Token: 0x04007497 RID: 29847
		private IShowTalkCameraMotionTween Instance;

		// Token: 0x04007498 RID: 29848
		[Nullable(2)]
		private ICameraParams _StartCache;

		// Token: 0x04007499 RID: 29849
		private bool _StartInited;

		// Token: 0x0400749A RID: 29850
		[Nullable(2)]
		private ICameraParams _EndCache;

		// Token: 0x0400749B RID: 29851
		private bool _EndInited;

		// Token: 0x0400749C RID: 29852
		[Nullable(2)]
		private IFlowCameraShake _CamShakeCache;

		// Token: 0x0400749D RID: 29853
		private bool _CamShakeInited;
	}
}
