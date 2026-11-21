using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E37 RID: 7735
	public class IMovieCameraConfig
	{
		// Token: 0x0600A47F RID: 42111 RVA: 0x00177B40 File Offset: 0x00175D40
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

		// Token: 0x0600A480 RID: 42112 RVA: 0x00177B78 File Offset: 0x00175D78
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

		// Token: 0x0600A481 RID: 42113 RVA: 0x00177B8B File Offset: 0x00175D8B
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

		// Token: 0x0600A482 RID: 42114 RVA: 0x00177B9E File Offset: 0x00175D9E
		public IMovieCameraConfig_SetValue ToSetValue()
		{
			return new IMovieCameraConfig_SetValue
			{
				MovieCameraType = this.MovieCameraType
			};
		}

		// Token: 0x170032FB RID: 13051
		// (get) Token: 0x0600A483 RID: 42115 RVA: 0x00177BB1 File Offset: 0x00175DB1
		// (set) Token: 0x0600A484 RID: 42116 RVA: 0x00177BD8 File Offset: 0x00175DD8
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

		// Token: 0x0400637E RID: 25470
		[Nullable(2)]
		protected IMovieCameraConfig FbInstance;

		// Token: 0x0400637F RID: 25471
		[Nullable(2)]
		protected IMovieCameraConfig_SetValue PocoInterface;
	}
}
