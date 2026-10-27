using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E62 RID: 7778
	[NullableContext(1)]
	[Nullable(0)]
	public class IShowTalkCameraMotionTween : IShowTalkCameraMotion
	{
		// Token: 0x0600A677 RID: 42615 RVA: 0x00178AA4 File Offset: 0x00176CA4
		private IShowTalkCameraMotionTween_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowTalkCameraMotionTween 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowTalkCameraMotionTween_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowTalkCameraMotionTween_SetValue());
			}
			return result;
		}

		// Token: 0x0600A678 RID: 42616 RVA: 0x00178ADC File Offset: 0x00176CDC
		public static IShowTalkCameraMotionTween Create([Nullable(2)] IShowTalkCameraMotionTween instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowTalkCameraMotionTween
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A679 RID: 42617 RVA: 0x00178AEF File Offset: 0x00176CEF
		public static IShowTalkCameraMotionTween CreateFromSetValue([Nullable(2)] IShowTalkCameraMotionTween_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowTalkCameraMotionTween
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A67A RID: 42618 RVA: 0x00178B04 File Offset: 0x00176D04
		public new IShowTalkCameraMotionTween_SetValue ToSetValue()
		{
			return new IShowTalkCameraMotionTween_SetValue
			{
				Type = this.Type,
				Start = this.Start,
				End = this.End,
				Duration = this.Duration,
				EaseType = this.EaseType,
				CamShake = this.CamShake
			};
		}

		// Token: 0x170032FF RID: 13055
		// (get) Token: 0x0600A67B RID: 42619 RVA: 0x00178B5E File Offset: 0x00176D5E
		// (set) Token: 0x0600A67C RID: 42620 RVA: 0x00178B89 File Offset: 0x00176D89
		public override EShowTalkCameraMotionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EShowTalkCameraMotionType.Preset;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003300 RID: 13056
		// (get) Token: 0x0600A67D RID: 42621 RVA: 0x00178B98 File Offset: 0x00176D98
		// (set) Token: 0x0600A67E RID: 42622 RVA: 0x00178BF9 File Offset: 0x00176DF9
		public virtual ICameraParams Start
		{
			get
			{
				if (this._StartInited)
				{
					return this._StartCache;
				}
				this._StartInited = true;
				if (this.FbInstance != null)
				{
					this._StartCache = ICameraParams.Create(this.FbInstance.Start);
				}
				else
				{
					IShowTalkCameraMotionTween_SetValue pocoInterface = this.PocoInterface;
					this._StartCache = ((pocoInterface != null) ? pocoInterface.Start : null);
				}
				return this._StartCache;
			}
			set
			{
				this.GetOrCreatePoco().Start = value;
				this._StartInited = false;
			}
		}

		// Token: 0x17003301 RID: 13057
		// (get) Token: 0x0600A67F RID: 42623 RVA: 0x00178C10 File Offset: 0x00176E10
		// (set) Token: 0x0600A680 RID: 42624 RVA: 0x00178C71 File Offset: 0x00176E71
		public virtual ICameraParams End
		{
			get
			{
				if (this._EndInited)
				{
					return this._EndCache;
				}
				this._EndInited = true;
				if (this.FbInstance != null)
				{
					this._EndCache = ICameraParams.Create(this.FbInstance.End);
				}
				else
				{
					IShowTalkCameraMotionTween_SetValue pocoInterface = this.PocoInterface;
					this._EndCache = ((pocoInterface != null) ? pocoInterface.End : null);
				}
				return this._EndCache;
			}
			set
			{
				this.GetOrCreatePoco().End = value;
				this._EndInited = false;
			}
		}

		// Token: 0x17003302 RID: 13058
		// (get) Token: 0x0600A681 RID: 42625 RVA: 0x00178C86 File Offset: 0x00176E86
		// (set) Token: 0x0600A682 RID: 42626 RVA: 0x00178CB5 File Offset: 0x00176EB5
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x17003303 RID: 13059
		// (get) Token: 0x0600A683 RID: 42627 RVA: 0x00178CC4 File Offset: 0x00176EC4
		// (set) Token: 0x0600A684 RID: 42628 RVA: 0x00178CFE File Offset: 0x00176EFE
		public virtual EEaseType? EaseType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EaseType;
				}
				IShowTalkCameraMotionTween_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EaseType;
			}
			set
			{
				this.GetOrCreatePoco().EaseType = value;
			}
		}

		// Token: 0x17003304 RID: 13060
		// (get) Token: 0x0600A685 RID: 42629 RVA: 0x00178D0C File Offset: 0x00176F0C
		// (set) Token: 0x0600A686 RID: 42630 RVA: 0x00178D6D File Offset: 0x00176F6D
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
				if (this.FbInstance != null)
				{
					this._CamShakeCache = IFlowCameraShake.Create(this.FbInstance.CamShake);
				}
				else
				{
					IShowTalkCameraMotionTween_SetValue pocoInterface = this.PocoInterface;
					this._CamShakeCache = ((pocoInterface != null) ? pocoInterface.CamShake : null);
				}
				return this._CamShakeCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CamShake = value;
				this._CamShakeInited = false;
			}
		}

		// Token: 0x0400636A RID: 25450
		[Nullable(2)]
		protected new IShowTalkCameraMotionTween FbInstance;

		// Token: 0x0400636B RID: 25451
		[Nullable(2)]
		protected new IShowTalkCameraMotionTween_SetValue PocoInterface;

		// Token: 0x0400636C RID: 25452
		private ICameraParams _StartCache;

		// Token: 0x0400636D RID: 25453
		private bool _StartInited;

		// Token: 0x0400636E RID: 25454
		private ICameraParams _EndCache;

		// Token: 0x0400636F RID: 25455
		private bool _EndInited;

		// Token: 0x04006370 RID: 25456
		private IFlowCameraShake _CamShakeCache;

		// Token: 0x04006371 RID: 25457
		private bool _CamShakeInited;
	}
}
