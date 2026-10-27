using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200195C RID: 6492
	[NullableContext(1)]
	[Nullable(0)]
	public class ICutCameraConfig
	{
		// Token: 0x06008B11 RID: 35601 RVA: 0x00147254 File Offset: 0x00145454
		private ICutCameraConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICutCameraConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICutCameraConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICutCameraConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008B12 RID: 35602 RVA: 0x0014728C File Offset: 0x0014548C
		public static ICutCameraConfig Create([Nullable(2)] ICutCameraConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICutCameraConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008B13 RID: 35603 RVA: 0x0014729F File Offset: 0x0014549F
		public static ICutCameraConfig CreateFromSetValue([Nullable(2)] ICutCameraConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICutCameraConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008B14 RID: 35604 RVA: 0x001472B2 File Offset: 0x001454B2
		public ICutCameraConfig_SetValue ToSetValue()
		{
			return new ICutCameraConfig_SetValue
			{
				CameraParams = this.CameraParams,
				CutFlow = this.CutFlow,
				CutTimeParams = this.CutTimeParams
			};
		}

		// Token: 0x17002CD3 RID: 11475
		// (get) Token: 0x06008B15 RID: 35605 RVA: 0x001472E0 File Offset: 0x001454E0
		// (set) Token: 0x06008B16 RID: 35606 RVA: 0x00147341 File Offset: 0x00145541
		public virtual ICameraParams CameraParams
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
					this._CameraParamsCache = ICameraParams.Create(this.FbInstance.CameraParams);
				}
				else
				{
					ICutCameraConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002CD4 RID: 11476
		// (get) Token: 0x06008B17 RID: 35607 RVA: 0x00147358 File Offset: 0x00145558
		// (set) Token: 0x06008B18 RID: 35608 RVA: 0x001473B9 File Offset: 0x001455B9
		[Nullable(2)]
		public virtual PlayFlow CutFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._CutFlowInited)
				{
					return this._CutFlowCache;
				}
				this._CutFlowInited = true;
				if (this.FbInstance != null)
				{
					this._CutFlowCache = PlayFlow.Create(this.FbInstance.CutFlow);
				}
				else
				{
					ICutCameraConfig_SetValue pocoInterface = this.PocoInterface;
					this._CutFlowCache = ((pocoInterface != null) ? pocoInterface.CutFlow : null);
				}
				return this._CutFlowCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CutFlow = value;
				this._CutFlowInited = false;
			}
		}

		// Token: 0x17002CD5 RID: 11477
		// (get) Token: 0x06008B19 RID: 35609 RVA: 0x001473D0 File Offset: 0x001455D0
		// (set) Token: 0x06008B1A RID: 35610 RVA: 0x00147431 File Offset: 0x00145631
		[Nullable(2)]
		public virtual ICutCameraTimeParams CutTimeParams
		{
			[NullableContext(2)]
			get
			{
				if (this._CutTimeParamsInited)
				{
					return this._CutTimeParamsCache;
				}
				this._CutTimeParamsInited = true;
				if (this.FbInstance != null)
				{
					this._CutTimeParamsCache = ICutCameraTimeParams.Create(this.FbInstance.CutTimeParams);
				}
				else
				{
					ICutCameraConfig_SetValue pocoInterface = this.PocoInterface;
					this._CutTimeParamsCache = ((pocoInterface != null) ? pocoInterface.CutTimeParams : null);
				}
				return this._CutTimeParamsCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CutTimeParams = value;
				this._CutTimeParamsInited = false;
			}
		}

		// Token: 0x040056CE RID: 22222
		[Nullable(2)]
		protected ICutCameraConfig FbInstance;

		// Token: 0x040056CF RID: 22223
		[Nullable(2)]
		protected ICutCameraConfig_SetValue PocoInterface;

		// Token: 0x040056D0 RID: 22224
		private ICameraParams _CameraParamsCache;

		// Token: 0x040056D1 RID: 22225
		private bool _CameraParamsInited;

		// Token: 0x040056D2 RID: 22226
		private PlayFlow _CutFlowCache;

		// Token: 0x040056D3 RID: 22227
		private bool _CutFlowInited;

		// Token: 0x040056D4 RID: 22228
		private ICutCameraTimeParams _CutTimeParamsCache;

		// Token: 0x040056D5 RID: 22229
		private bool _CutTimeParamsInited;
	}
}
