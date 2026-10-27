using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C40 RID: 7232
	[NullableContext(1)]
	[Nullable(0)]
	public class IMovieCameraConfig
	{
		// Token: 0x06009B27 RID: 39719 RVA: 0x00164800 File Offset: 0x00162A00
		private IMovieCameraConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMovieCameraConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMovieCameraConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMovieCameraConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009B28 RID: 39720 RVA: 0x00164838 File Offset: 0x00162A38
		public static IMovieCameraConfig Create([Nullable(2)] IMovieCameraConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovieCameraConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B29 RID: 39721 RVA: 0x0016484B File Offset: 0x00162A4B
		public static IMovieCameraConfig CreateFromSetValue([Nullable(2)] IMovieCameraConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMovieCameraConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B2A RID: 39722 RVA: 0x0016485E File Offset: 0x00162A5E
		public IMovieCameraConfig_SetValue ToSetValue()
		{
			return new IMovieCameraConfig_SetValue
			{
				MovieCameraType = this.MovieCameraType
			};
		}

		// Token: 0x1700308A RID: 12426
		// (get) Token: 0x06009B2B RID: 39723 RVA: 0x00164871 File Offset: 0x00162A71
		// (set) Token: 0x06009B2C RID: 39724 RVA: 0x00164898 File Offset: 0x00162A98
		public virtual IEnterMovieCameraType MovieCameraType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MovieCameraType;
				}
				IMovieCameraConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MovieCameraType;
			}
			set
			{
				this.GetOrCreatePoco().MovieCameraType = value;
			}
		}

		// Token: 0x04005E47 RID: 24135
		[Nullable(2)]
		protected IMovieCameraConfig FbInstance;

		// Token: 0x04005E48 RID: 24136
		[Nullable(2)]
		protected IMovieCameraConfig_SetValue PocoInterface;
	}
}
