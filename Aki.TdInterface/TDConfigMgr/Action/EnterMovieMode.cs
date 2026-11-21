using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017C9 RID: 6089
	[NullableContext(2)]
	[Nullable(0)]
	public class EnterMovieMode : ActionParams
	{
		// Token: 0x06008397 RID: 33687 RVA: 0x0013AB3C File Offset: 0x00138D3C
		[NullableContext(0)]
		private EnterMovieMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnterMovieMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnterMovieMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnterMovieMode_SetValue());
			}
			return result;
		}

		// Token: 0x06008398 RID: 33688 RVA: 0x0013AB74 File Offset: 0x00138D74
		[NullableContext(0)]
		public static EnterMovieMode Create([Nullable(2)] EnterMovieMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnterMovieMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008399 RID: 33689 RVA: 0x0013AB87 File Offset: 0x00138D87
		[NullableContext(0)]
		public static EnterMovieMode CreateFromSetValue([Nullable(2)] EnterMovieMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnterMovieMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600839A RID: 33690 RVA: 0x0013AB9C File Offset: 0x00138D9C
		[NullableContext(0)]
		public EnterMovieMode_SetValue ToSetValue()
		{
			return new EnterMovieMode_SetValue
			{
				MovieCameraConfig = this.MovieCameraConfig,
				EnableFuncConfig = this.EnableFuncConfig,
				BorderAnimDuration = this.BorderAnimDuration,
				DurationType = this.DurationType,
				AutoExitInFlow = this.AutoExitInFlow
			};
		}

		// Token: 0x17002B1C RID: 11036
		// (get) Token: 0x0600839B RID: 33691 RVA: 0x0013ABEC File Offset: 0x00138DEC
		// (set) Token: 0x0600839C RID: 33692 RVA: 0x0013AC4D File Offset: 0x00138E4D
		public virtual IMovieCameraConfig MovieCameraConfig
		{
			get
			{
				if (this._MovieCameraConfigInited)
				{
					return this._MovieCameraConfigCache;
				}
				this._MovieCameraConfigInited = true;
				if (this.FbInstance != null)
				{
					this._MovieCameraConfigCache = IMovieCameraConfig.Create(this.FbInstance.MovieCameraConfig);
				}
				else
				{
					EnterMovieMode_SetValue pocoInterface = this.PocoInterface;
					this._MovieCameraConfigCache = ((pocoInterface != null) ? pocoInterface.MovieCameraConfig : null);
				}
				return this._MovieCameraConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().MovieCameraConfig = value;
				this._MovieCameraConfigInited = false;
			}
		}

		// Token: 0x17002B1D RID: 11037
		// (get) Token: 0x0600839D RID: 33693 RVA: 0x0013AC64 File Offset: 0x00138E64
		// (set) Token: 0x0600839E RID: 33694 RVA: 0x0013ACC5 File Offset: 0x00138EC5
		public virtual IEnableFuncConfig EnableFuncConfig
		{
			get
			{
				if (this._EnableFuncConfigInited)
				{
					return this._EnableFuncConfigCache;
				}
				this._EnableFuncConfigInited = true;
				if (this.FbInstance != null)
				{
					this._EnableFuncConfigCache = IEnableFuncConfig.Create(this.FbInstance.EnableFuncConfig);
				}
				else
				{
					EnterMovieMode_SetValue pocoInterface = this.PocoInterface;
					this._EnableFuncConfigCache = ((pocoInterface != null) ? pocoInterface.EnableFuncConfig : null);
				}
				return this._EnableFuncConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().EnableFuncConfig = value;
				this._EnableFuncConfigInited = false;
			}
		}

		// Token: 0x17002B1E RID: 11038
		// (get) Token: 0x0600839F RID: 33695 RVA: 0x0013ACDC File Offset: 0x00138EDC
		// (set) Token: 0x060083A0 RID: 33696 RVA: 0x0013AD16 File Offset: 0x00138F16
		public virtual float? BorderAnimDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BorderAnimDuration;
				}
				EnterMovieMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BorderAnimDuration;
			}
			set
			{
				this.GetOrCreatePoco().BorderAnimDuration = value;
			}
		}

		// Token: 0x17002B1F RID: 11039
		// (get) Token: 0x060083A1 RID: 33697 RVA: 0x0013AD24 File Offset: 0x00138F24
		// (set) Token: 0x060083A2 RID: 33698 RVA: 0x0013AD4B File Offset: 0x00138F4B
		public virtual IEnterMovieModeDurationType DurationType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DurationType;
				}
				EnterMovieMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DurationType;
			}
			set
			{
				this.GetOrCreatePoco().DurationType = value;
			}
		}

		// Token: 0x17002B20 RID: 11040
		// (get) Token: 0x060083A3 RID: 33699 RVA: 0x0013AD5C File Offset: 0x00138F5C
		// (set) Token: 0x060083A4 RID: 33700 RVA: 0x0013AD96 File Offset: 0x00138F96
		public virtual bool? AutoExitInFlow
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoExitInFlow;
				}
				EnterMovieMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AutoExitInFlow;
			}
			set
			{
				this.GetOrCreatePoco().AutoExitInFlow = value;
			}
		}

		// Token: 0x0400509F RID: 20639
		protected new EnterMovieMode FbInstance;

		// Token: 0x040050A0 RID: 20640
		protected EnterMovieMode_SetValue PocoInterface;

		// Token: 0x040050A1 RID: 20641
		[Nullable(0)]
		private IMovieCameraConfig _MovieCameraConfigCache;

		// Token: 0x040050A2 RID: 20642
		private bool _MovieCameraConfigInited;

		// Token: 0x040050A3 RID: 20643
		[Nullable(0)]
		private IEnableFuncConfig _EnableFuncConfigCache;

		// Token: 0x040050A4 RID: 20644
		private bool _EnableFuncConfigInited;
	}
}
