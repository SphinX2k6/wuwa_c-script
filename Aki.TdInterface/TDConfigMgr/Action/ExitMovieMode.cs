using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001893 RID: 6291
	[NullableContext(2)]
	[Nullable(0)]
	public class ExitMovieMode : ActionParams
	{
		// Token: 0x0600840F RID: 33807 RVA: 0x0013B844 File Offset: 0x00139A44
		[NullableContext(0)]
		private ExitMovieMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ExitMovieMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ExitMovieMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ExitMovieMode_SetValue());
			}
			return result;
		}

		// Token: 0x06008410 RID: 33808 RVA: 0x0013B87C File Offset: 0x00139A7C
		[NullableContext(0)]
		public static ExitMovieMode Create([Nullable(2)] ExitMovieMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExitMovieMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008411 RID: 33809 RVA: 0x0013B88F File Offset: 0x00139A8F
		[NullableContext(0)]
		public static ExitMovieMode CreateFromSetValue([Nullable(2)] ExitMovieMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ExitMovieMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008412 RID: 33810 RVA: 0x0013B8A2 File Offset: 0x00139AA2
		[NullableContext(0)]
		public ExitMovieMode_SetValue ToSetValue()
		{
			return new ExitMovieMode_SetValue
			{
				BorderAnimDuration = this.BorderAnimDuration,
				DurationType = this.DurationType,
				FadeOutMaskConfig = this.FadeOutMaskConfig
			};
		}

		// Token: 0x17002B32 RID: 11058
		// (get) Token: 0x06008413 RID: 33811 RVA: 0x0013B8D0 File Offset: 0x00139AD0
		// (set) Token: 0x06008414 RID: 33812 RVA: 0x0013B90A File Offset: 0x00139B0A
		public virtual float? BorderAnimDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BorderAnimDuration;
				}
				ExitMovieMode_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002B33 RID: 11059
		// (get) Token: 0x06008415 RID: 33813 RVA: 0x0013B918 File Offset: 0x00139B18
		// (set) Token: 0x06008416 RID: 33814 RVA: 0x0013B93F File Offset: 0x00139B3F
		public virtual IEnterMovieModeDurationType DurationType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DurationType;
				}
				ExitMovieMode_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002B34 RID: 11060
		// (get) Token: 0x06008417 RID: 33815 RVA: 0x0013B950 File Offset: 0x00139B50
		// (set) Token: 0x06008418 RID: 33816 RVA: 0x0013B9B1 File Offset: 0x00139BB1
		public virtual IMovieModeFadeOutMaskConfig FadeOutMaskConfig
		{
			get
			{
				if (this._FadeOutMaskConfigInited)
				{
					return this._FadeOutMaskConfigCache;
				}
				this._FadeOutMaskConfigInited = true;
				if (this.FbInstance != null)
				{
					this._FadeOutMaskConfigCache = IMovieModeFadeOutMaskConfig.Create(this.FbInstance.FadeOutMaskConfig);
				}
				else
				{
					ExitMovieMode_SetValue pocoInterface = this.PocoInterface;
					this._FadeOutMaskConfigCache = ((pocoInterface != null) ? pocoInterface.FadeOutMaskConfig : null);
				}
				return this._FadeOutMaskConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutMaskConfig = value;
				this._FadeOutMaskConfigInited = false;
			}
		}

		// Token: 0x0400541B RID: 21531
		protected new ExitMovieMode FbInstance;

		// Token: 0x0400541C RID: 21532
		protected ExitMovieMode_SetValue PocoInterface;

		// Token: 0x0400541D RID: 21533
		[Nullable(0)]
		private IMovieModeFadeOutMaskConfig _FadeOutMaskConfigCache;

		// Token: 0x0400541E RID: 21534
		private bool _FadeOutMaskConfigInited;
	}
}
