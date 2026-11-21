using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002213 RID: 8723
	[NullableContext(2)]
	[Nullable(0)]
	public class IToggleDragActorPlayEnable : IToggleDragActorPlayType
	{
		// Token: 0x0600BE26 RID: 48678 RVA: 0x001B760C File Offset: 0x001B580C
		[NullableContext(0)]
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

		// Token: 0x0600BE27 RID: 48679 RVA: 0x001B7644 File Offset: 0x001B5844
		[NullableContext(0)]
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

		// Token: 0x0600BE28 RID: 48680 RVA: 0x001B7657 File Offset: 0x001B5857
		[NullableContext(0)]
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

		// Token: 0x0600BE29 RID: 48681 RVA: 0x001B766C File Offset: 0x001B586C
		[NullableContext(0)]
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

		// Token: 0x17003A06 RID: 14854
		// (get) Token: 0x0600BE2A RID: 48682 RVA: 0x001B76F6 File Offset: 0x001B58F6
		// (set) Token: 0x0600BE2B RID: 48683 RVA: 0x001B7721 File Offset: 0x001B5921
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

		// Token: 0x17003A07 RID: 14855
		// (get) Token: 0x0600BE2C RID: 48684 RVA: 0x001B7730 File Offset: 0x001B5930
		// (set) Token: 0x0600BE2D RID: 48685 RVA: 0x001B7791 File Offset: 0x001B5991
		[Nullable(0)]
		public virtual IFixedCameraConfig CameraConfig
		{
			[NullableContext(0)]
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
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().CameraConfig = value;
				this._CameraConfigInited = false;
			}
		}

		// Token: 0x17003A08 RID: 14856
		// (get) Token: 0x0600BE2E RID: 48686 RVA: 0x001B77A6 File Offset: 0x001B59A6
		// (set) Token: 0x0600BE2F RID: 48687 RVA: 0x001B77CD File Offset: 0x001B59CD
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

		// Token: 0x17003A09 RID: 14857
		// (get) Token: 0x0600BE30 RID: 48688 RVA: 0x001B77DB File Offset: 0x001B59DB
		// (set) Token: 0x0600BE31 RID: 48689 RVA: 0x001B7802 File Offset: 0x001B5A02
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

		// Token: 0x17003A0A RID: 14858
		// (get) Token: 0x0600BE32 RID: 48690 RVA: 0x001B7810 File Offset: 0x001B5A10
		// (set) Token: 0x0600BE33 RID: 48691 RVA: 0x001B7837 File Offset: 0x001B5A37
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

		// Token: 0x17003A0B RID: 14859
		// (get) Token: 0x0600BE34 RID: 48692 RVA: 0x001B7848 File Offset: 0x001B5A48
		// (set) Token: 0x0600BE35 RID: 48693 RVA: 0x001B7882 File Offset: 0x001B5A82
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

		// Token: 0x17003A0C RID: 14860
		// (get) Token: 0x0600BE36 RID: 48694 RVA: 0x001B7890 File Offset: 0x001B5A90
		// (set) Token: 0x0600BE37 RID: 48695 RVA: 0x001B78CA File Offset: 0x001B5ACA
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

		// Token: 0x17003A0D RID: 14861
		// (get) Token: 0x0600BE38 RID: 48696 RVA: 0x001B78D8 File Offset: 0x001B5AD8
		// (set) Token: 0x0600BE39 RID: 48697 RVA: 0x001B78EF File Offset: 0x001B5AEF
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

		// Token: 0x17003A0E RID: 14862
		// (get) Token: 0x0600BE3A RID: 48698 RVA: 0x001B78FD File Offset: 0x001B5AFD
		// (set) Token: 0x0600BE3B RID: 48699 RVA: 0x001B7914 File Offset: 0x001B5B14
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

		// Token: 0x17003A0F RID: 14863
		// (get) Token: 0x0600BE3C RID: 48700 RVA: 0x001B7922 File Offset: 0x001B5B22
		// (set) Token: 0x0600BE3D RID: 48701 RVA: 0x001B7939 File Offset: 0x001B5B39
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

		// Token: 0x04007213 RID: 29203
		protected new IToggleDragActorPlayEnable FbInstance;

		// Token: 0x04007214 RID: 29204
		protected new IToggleDragActorPlayEnable_SetValue PocoInterface;

		// Token: 0x04007215 RID: 29205
		[Nullable(0)]
		private IFixedCameraConfig _CameraConfigCache;

		// Token: 0x04007216 RID: 29206
		private bool _CameraConfigInited;
	}
}
