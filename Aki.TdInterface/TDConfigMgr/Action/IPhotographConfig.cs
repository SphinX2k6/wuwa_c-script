using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EFB RID: 7931
	[NullableContext(2)]
	[Nullable(0)]
	public class IPhotographConfig
	{
		// Token: 0x0600A8C5 RID: 43205 RVA: 0x0017F5A0 File Offset: 0x0017D7A0
		[NullableContext(0)]
		private IPhotographConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhotographConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhotographConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhotographConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A8C6 RID: 43206 RVA: 0x0017F5D8 File Offset: 0x0017D7D8
		[NullableContext(0)]
		public static IPhotographConfig Create([Nullable(2)] IPhotographConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A8C7 RID: 43207 RVA: 0x0017F5EB File Offset: 0x0017D7EB
		[NullableContext(0)]
		public static IPhotographConfig CreateFromSetValue([Nullable(2)] IPhotographConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhotographConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A8C8 RID: 43208 RVA: 0x0017F5FE File Offset: 0x0017D7FE
		[NullableContext(0)]
		public IPhotographConfig_SetValue ToSetValue()
		{
			return new IPhotographConfig_SetValue
			{
				PhotoTargets = this.PhotoTargets,
				PlayerPerform = this.PlayerPerform,
				CameraParams = this.CameraParams
			};
		}

		// Token: 0x170033F8 RID: 13304
		// (get) Token: 0x0600A8C9 RID: 43209 RVA: 0x0017F629 File Offset: 0x0017D829
		// (set) Token: 0x0600A8CA RID: 43210 RVA: 0x0017F650 File Offset: 0x0017D850
		public virtual List<int> PhotoTargets
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PhotoTargets;
				}
				IPhotographConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PhotoTargets;
			}
			set
			{
				this.GetOrCreatePoco().PhotoTargets = value;
			}
		}

		// Token: 0x170033F9 RID: 13305
		// (get) Token: 0x0600A8CB RID: 43211 RVA: 0x0017F660 File Offset: 0x0017D860
		// (set) Token: 0x0600A8CC RID: 43212 RVA: 0x0017F6C1 File Offset: 0x0017D8C1
		public virtual IPhotographPlayerPerform PlayerPerform
		{
			get
			{
				if (this._PlayerPerformInited)
				{
					return this._PlayerPerformCache;
				}
				this._PlayerPerformInited = true;
				if (this.FbInstance != null)
				{
					this._PlayerPerformCache = IPhotographPlayerPerform.Create(this.FbInstance.PlayerPerform);
				}
				else
				{
					IPhotographConfig_SetValue pocoInterface = this.PocoInterface;
					this._PlayerPerformCache = ((pocoInterface != null) ? pocoInterface.PlayerPerform : null);
				}
				return this._PlayerPerformCache;
			}
			set
			{
				this.GetOrCreatePoco().PlayerPerform = value;
				this._PlayerPerformInited = false;
			}
		}

		// Token: 0x170033FA RID: 13306
		// (get) Token: 0x0600A8CD RID: 43213 RVA: 0x0017F6D8 File Offset: 0x0017D8D8
		// (set) Token: 0x0600A8CE RID: 43214 RVA: 0x0017F739 File Offset: 0x0017D939
		public virtual IPhotographCameraParams CameraParams
		{
			get
			{
				if (this._CameraParamsInited)
				{
					return this._CameraParamsCache;
				}
				this._CameraParamsInited = true;
				if (this.FbInstance != null)
				{
					this._CameraParamsCache = IPhotographCameraParams.Create(this.FbInstance.CameraParams);
				}
				else
				{
					IPhotographConfig_SetValue pocoInterface = this.PocoInterface;
					this._CameraParamsCache = ((pocoInterface != null) ? pocoInterface.CameraParams : null);
				}
				return this._CameraParamsCache;
			}
			set
			{
				this.GetOrCreatePoco().CameraParams = value;
				this._CameraParamsInited = false;
			}
		}

		// Token: 0x0400656B RID: 25963
		protected IPhotographConfig FbInstance;

		// Token: 0x0400656C RID: 25964
		protected IPhotographConfig_SetValue PocoInterface;

		// Token: 0x0400656D RID: 25965
		[Nullable(0)]
		private IPhotographPlayerPerform _PlayerPerformCache;

		// Token: 0x0400656E RID: 25966
		private bool _PlayerPerformInited;

		// Token: 0x0400656F RID: 25967
		[Nullable(0)]
		private IPhotographCameraParams _CameraParamsCache;

		// Token: 0x04006570 RID: 25968
		private bool _CameraParamsInited;
	}
}
