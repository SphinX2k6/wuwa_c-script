using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002097 RID: 8343
	public class IShowTalkCameraMotionTween : IShowTalkCameraMotion
	{
		// Token: 0x0600B12F RID: 45359 RVA: 0x0018E7A4 File Offset: 0x0018C9A4
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

		// Token: 0x0600B130 RID: 45360 RVA: 0x0018E7DC File Offset: 0x0018C9DC
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

		// Token: 0x0600B131 RID: 45361 RVA: 0x0018E7EF File Offset: 0x0018C9EF
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

		// Token: 0x0600B132 RID: 45362 RVA: 0x0018E804 File Offset: 0x0018CA04
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

		// Token: 0x170035C3 RID: 13763
		// (get) Token: 0x0600B133 RID: 45363 RVA: 0x0018E85E File Offset: 0x0018CA5E
		// (set) Token: 0x0600B134 RID: 45364 RVA: 0x0018E889 File Offset: 0x0018CA89
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

		// Token: 0x170035C4 RID: 13764
		// (get) Token: 0x0600B135 RID: 45365 RVA: 0x0018E898 File Offset: 0x0018CA98
		// (set) Token: 0x0600B136 RID: 45366 RVA: 0x0018E8F9 File Offset: 0x0018CAF9
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

		// Token: 0x170035C5 RID: 13765
		// (get) Token: 0x0600B137 RID: 45367 RVA: 0x0018E910 File Offset: 0x0018CB10
		// (set) Token: 0x0600B138 RID: 45368 RVA: 0x0018E971 File Offset: 0x0018CB71
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

		// Token: 0x170035C6 RID: 13766
		// (get) Token: 0x0600B139 RID: 45369 RVA: 0x0018E986 File Offset: 0x0018CB86
		// (set) Token: 0x0600B13A RID: 45370 RVA: 0x0018E9B5 File Offset: 0x0018CBB5
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

		// Token: 0x170035C7 RID: 13767
		// (get) Token: 0x0600B13B RID: 45371 RVA: 0x0018E9C4 File Offset: 0x0018CBC4
		// (set) Token: 0x0600B13C RID: 45372 RVA: 0x0018E9FE File Offset: 0x0018CBFE
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

		// Token: 0x170035C8 RID: 13768
		// (get) Token: 0x0600B13D RID: 45373 RVA: 0x0018EA0C File Offset: 0x0018CC0C
		// (set) Token: 0x0600B13E RID: 45374 RVA: 0x0018EA6D File Offset: 0x0018CC6D
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

		// Token: 0x0400694E RID: 26958
		[Nullable(2)]
		protected new IShowTalkCameraMotionTween FbInstance;

		// Token: 0x0400694F RID: 26959
		[Nullable(2)]
		protected new IShowTalkCameraMotionTween_SetValue PocoInterface;

		// Token: 0x04006950 RID: 26960
		private ICameraParams _StartCache;

		// Token: 0x04006951 RID: 26961
		private bool _StartInited;

		// Token: 0x04006952 RID: 26962
		private ICameraParams _EndCache;

		// Token: 0x04006953 RID: 26963
		private bool _EndInited;

		// Token: 0x04006954 RID: 26964
		private IFlowCameraShake _CamShakeCache;

		// Token: 0x04006955 RID: 26965
		private bool _CamShakeInited;
	}
}
