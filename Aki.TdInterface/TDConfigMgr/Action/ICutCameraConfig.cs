using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AE7 RID: 6887
	public class ICutCameraConfig
	{
		// Token: 0x06009247 RID: 37447 RVA: 0x00156C90 File Offset: 0x00154E90
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

		// Token: 0x06009248 RID: 37448 RVA: 0x00156CC8 File Offset: 0x00154EC8
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

		// Token: 0x06009249 RID: 37449 RVA: 0x00156CDB File Offset: 0x00154EDB
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

		// Token: 0x0600924A RID: 37450 RVA: 0x00156CEE File Offset: 0x00154EEE
		public ICutCameraConfig_SetValue ToSetValue()
		{
			return new ICutCameraConfig_SetValue
			{
				CameraParams = this.CameraParams,
				CutFlow = this.CutFlow,
				CutTimeParams = this.CutTimeParams
			};
		}

		// Token: 0x17002ED5 RID: 11989
		// (get) Token: 0x0600924B RID: 37451 RVA: 0x00156D1C File Offset: 0x00154F1C
		// (set) Token: 0x0600924C RID: 37452 RVA: 0x00156D7D File Offset: 0x00154F7D
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

		// Token: 0x17002ED6 RID: 11990
		// (get) Token: 0x0600924D RID: 37453 RVA: 0x00156D94 File Offset: 0x00154F94
		// (set) Token: 0x0600924E RID: 37454 RVA: 0x00156DF5 File Offset: 0x00154FF5
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

		// Token: 0x17002ED7 RID: 11991
		// (get) Token: 0x0600924F RID: 37455 RVA: 0x00156E0C File Offset: 0x0015500C
		// (set) Token: 0x06009250 RID: 37456 RVA: 0x00156E6D File Offset: 0x0015506D
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

		// Token: 0x04005B22 RID: 23330
		[Nullable(2)]
		protected ICutCameraConfig FbInstance;

		// Token: 0x04005B23 RID: 23331
		[Nullable(2)]
		protected ICutCameraConfig_SetValue PocoInterface;

		// Token: 0x04005B24 RID: 23332
		private ICameraParams _CameraParamsCache;

		// Token: 0x04005B25 RID: 23333
		private bool _CameraParamsInited;

		// Token: 0x04005B26 RID: 23334
		private PlayFlow _CutFlowCache;

		// Token: 0x04005B27 RID: 23335
		private bool _CutFlowInited;

		// Token: 0x04005B28 RID: 23336
		private ICutCameraTimeParams _CutTimeParamsCache;

		// Token: 0x04005B29 RID: 23337
		private bool _CutTimeParamsInited;
	}
}
