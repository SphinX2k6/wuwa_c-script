using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017C7 RID: 6087
	public class EnterMovieCamera : ActionParams
	{
		// Token: 0x0600838F RID: 33679 RVA: 0x0013AA84 File Offset: 0x00138C84
		private EnterMovieCamera_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnterMovieCamera 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnterMovieCamera_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnterMovieCamera_SetValue());
			}
			return result;
		}

		// Token: 0x06008390 RID: 33680 RVA: 0x0013AABC File Offset: 0x00138CBC
		public static EnterMovieCamera Create([Nullable(2)] EnterMovieCamera instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnterMovieCamera
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008391 RID: 33681 RVA: 0x0013AACF File Offset: 0x00138CCF
		public static EnterMovieCamera CreateFromSetValue([Nullable(2)] EnterMovieCamera_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnterMovieCamera
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008392 RID: 33682 RVA: 0x0013AAE2 File Offset: 0x00138CE2
		public EnterMovieCamera_SetValue ToSetValue()
		{
			return new EnterMovieCamera_SetValue
			{
				MovieCameraConfig = this.MovieCameraConfig
			};
		}

		// Token: 0x17002B1B RID: 11035
		// (get) Token: 0x06008393 RID: 33683 RVA: 0x0013AAF5 File Offset: 0x00138CF5
		// (set) Token: 0x06008394 RID: 33684 RVA: 0x0013AB1C File Offset: 0x00138D1C
		public virtual IEnterMovieCameraType MovieCameraConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MovieCameraConfig;
				}
				EnterMovieCamera_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MovieCameraConfig;
			}
			set
			{
				this.GetOrCreatePoco().MovieCameraConfig = value;
			}
		}

		// Token: 0x0400509C RID: 20636
		[Nullable(2)]
		protected new EnterMovieCamera FbInstance;

		// Token: 0x0400509D RID: 20637
		[Nullable(2)]
		protected EnterMovieCamera_SetValue PocoInterface;
	}
}
