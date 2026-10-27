using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001657 RID: 5719
	[NullableContext(1)]
	[Nullable(0)]
	public class EnterMovieCamera : ActionParams
	{
		// Token: 0x06007CB1 RID: 31921 RVA: 0x0012B9D8 File Offset: 0x00129BD8
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

		// Token: 0x06007CB2 RID: 31922 RVA: 0x0012BA10 File Offset: 0x00129C10
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

		// Token: 0x06007CB3 RID: 31923 RVA: 0x0012BA23 File Offset: 0x00129C23
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

		// Token: 0x06007CB4 RID: 31924 RVA: 0x0012BA36 File Offset: 0x00129C36
		public EnterMovieCamera_SetValue ToSetValue()
		{
			return new EnterMovieCamera_SetValue
			{
				MovieCameraConfig = this.MovieCameraConfig
			};
		}

		// Token: 0x17002930 RID: 10544
		// (get) Token: 0x06007CB5 RID: 31925 RVA: 0x0012BA49 File Offset: 0x00129C49
		// (set) Token: 0x06007CB6 RID: 31926 RVA: 0x0012BA70 File Offset: 0x00129C70
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

		// Token: 0x04004CA1 RID: 19617
		[Nullable(2)]
		protected new EnterMovieCamera FbInstance;

		// Token: 0x04004CA2 RID: 19618
		[Nullable(2)]
		protected EnterMovieCamera_SetValue PocoInterface;
	}
}
