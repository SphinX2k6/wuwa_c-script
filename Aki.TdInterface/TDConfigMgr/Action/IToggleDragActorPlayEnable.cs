using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FCE RID: 8142
	[NullableContext(2)]
	[Nullable(0)]
	public class IToggleDragActorPlayEnable : IToggleDragActorPlayType
	{
		// Token: 0x0600B318 RID: 45848 RVA: 0x001A115C File Offset: 0x0019F35C
		[NullableContext(1)]
		private IToggleDragActorPlayEnable_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IToggleDragActorPlayEnable 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IToggleDragActorPlayEnable_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IToggleDragActorPlayEnable_SetValue());
			}
			return result;
		}

		// Token: 0x0600B319 RID: 45849 RVA: 0x001A1194 File Offset: 0x0019F394
		[NullableContext(1)]
		public static IToggleDragActorPlayEnable Create([Nullable(2)] IToggleDragActorPlayEnable instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IToggleDragActorPlayEnable
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B31A RID: 45850 RVA: 0x001A11A7 File Offset: 0x0019F3A7
		[NullableContext(1)]
		public static IToggleDragActorPlayEnable CreateFromSetValue([Nullable(2)] IToggleDragActorPlayEnable_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IToggleDragActorPlayEnable
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B31B RID: 45851 RVA: 0x001A11BC File Offset: 0x0019F3BC
		[NullableContext(1)]
		public new IToggleDragActorPlayEnable_SetValue ToSetValue()
		{
			return new IToggleDragActorPlayEnable_SetValue
			{
				Type = this.Type,
				CameraConfig = this.CameraConfig,
				TidMainText = this.TidMainText,
				TidSubText = this.TidSubText,
				TidHintText = this.TidHintText,
				KeepDialog = this.KeepDialog,
				DisableExit = this.DisableExit,
				EdTidMainText = this.EdTidMainText,
				EdTidSubText = this.EdTidSubText,
				EdTidHintText = this.EdTidHintText
			};
		}

		// Token: 0x1700372F RID: 14127
		// (get) Token: 0x0600B31C RID: 45852 RVA: 0x001A1246 File Offset: 0x0019F446
		// (set) Token: 0x0600B31D RID: 45853 RVA: 0x001A1271 File Offset: 0x0019F471
		public override EToggleDragActorPlayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EToggleDragActorPlayType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003730 RID: 14128
		// (get) Token: 0x0600B31E RID: 45854 RVA: 0x001A1280 File Offset: 0x0019F480
		// (set) Token: 0x0600B31F RID: 45855 RVA: 0x001A12E1 File Offset: 0x0019F4E1
		[Nullable(1)]
		public virtual IFixedCameraConfig CameraConfig
		{
			[NullableContext(1)]
			get
			{
				if (this._CameraConfigInited)
				{
					return this._CameraConfigCache;
				}
				this._CameraConfigInited = true;
				if (this.FbInstance != null)
				{
					this._CameraConfigCache = IFixedCameraConfig.Create(this.FbInstance.CameraConfig);
				}
				else
				{
					IToggleDragActorPlayEnable_SetValue pocoInterface = this.PocoInterface;
					this._CameraConfigCache = ((pocoInterface != null) ? pocoInterface.CameraConfig : null);
				}
				return this._CameraConfigCache;
			}
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().CameraConfig = value;
				this._CameraConfigInited = false;
			}
		}

		// Token: 0x17003731 RID: 14129
		// (get) Token: 0x0600B320 RID: 45856 RVA: 0x001A12F6 File Offset: 0x0019F4F6
		// (set) Token: 0x0600B321 RID: 45857 RVA: 0x001A131D File Offset: 0x0019F51D
		public virtual string TidMainText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidMainText;
				}
				IToggleDragActorPlayEnable_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidMainText;
			}
			set
			{
				this.GetOrCreatePoco().TidMainText = value;
			}
		}

		// Token: 0x17003732 RID: 14130
		// (get) Token: 0x0600B322 RID: 45858 RVA: 0x001A132B File Offset: 0x0019F52B
		// (set) Token: 0x0600B323 RID: 45859 RVA: 0x001A1352 File Offset: 0x0019F552
		public virtual string TidSubText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidSubText;
				}
				IToggleDragActorPlayEnable_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidSubText;
			}
			set
			{
				this.GetOrCreatePoco().TidSubText = value;
			}
		}

		// Token: 0x17003733 RID: 14131
		// (get) Token: 0x0600B324 RID: 45860 RVA: 0x001A1360 File Offset: 0x0019F560
		// (set) Token: 0x0600B325 RID: 45861 RVA: 0x001A1387 File Offset: 0x0019F587
		public virtual string TidHintText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidHintText;
				}
				IToggleDragActorPlayEnable_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidHintText;
			}
			set
			{
				this.GetOrCreatePoco().TidHintText = value;
			}
		}

		// Token: 0x17003734 RID: 14132
		// (get) Token: 0x0600B326 RID: 45862 RVA: 0x001A1398 File Offset: 0x0019F598
		// (set) Token: 0x0600B327 RID: 45863 RVA: 0x001A13D2 File Offset: 0x0019F5D2
		public virtual bool? KeepDialog
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepDialog;
				}
				IToggleDragActorPlayEnable_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepDialog;
			}
			set
			{
				this.GetOrCreatePoco().KeepDialog = value;
			}
		}

		// Token: 0x17003735 RID: 14133
		// (get) Token: 0x0600B328 RID: 45864 RVA: 0x001A13E0 File Offset: 0x0019F5E0
		// (set) Token: 0x0600B329 RID: 45865 RVA: 0x001A141A File Offset: 0x0019F61A
		public virtual bool? DisableExit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableExit;
				}
				IToggleDragActorPlayEnable_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableExit;
			}
			set
			{
				this.GetOrCreatePoco().DisableExit = value;
			}
		}

		// Token: 0x17003736 RID: 14134
		// (get) Token: 0x0600B32A RID: 45866 RVA: 0x001A1428 File Offset: 0x0019F628
		// (set) Token: 0x0600B32B RID: 45867 RVA: 0x001A143F File Offset: 0x0019F63F
		public virtual string EdTidMainText
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidMainText;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidMainText = value;
			}
		}

		// Token: 0x17003737 RID: 14135
		// (get) Token: 0x0600B32C RID: 45868 RVA: 0x001A144D File Offset: 0x0019F64D
		// (set) Token: 0x0600B32D RID: 45869 RVA: 0x001A1464 File Offset: 0x0019F664
		public virtual string EdTidSubText
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidSubText;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidSubText = value;
			}
		}

		// Token: 0x17003738 RID: 14136
		// (get) Token: 0x0600B32E RID: 45870 RVA: 0x001A1472 File Offset: 0x0019F672
		// (set) Token: 0x0600B32F RID: 45871 RVA: 0x001A1489 File Offset: 0x0019F689
		public virtual string EdTidHintText
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidHintText;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidHintText = value;
			}
		}

		// Token: 0x04006C14 RID: 27668
		protected new IToggleDragActorPlayEnable FbInstance;

		// Token: 0x04006C15 RID: 27669
		protected new IToggleDragActorPlayEnable_SetValue PocoInterface;

		// Token: 0x04006C16 RID: 27670
		[Nullable(1)]
		private IFixedCameraConfig _CameraConfigCache;

		// Token: 0x04006C17 RID: 27671
		private bool _CameraConfigInited;
	}
}
