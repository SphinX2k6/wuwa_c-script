using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A7B RID: 10875
	[NullableContext(2)]
	[Nullable(0)]
	public class IToggleDragActorPlayEnable : IToggleDragActorPlayType
	{
		// Token: 0x0600F001 RID: 61441 RVA: 0x00232C16 File Offset: 0x00230E16
		[NullableContext(0)]
		public static IToggleDragActorPlayEnable Create(IToggleDragActorPlayEnable? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IToggleDragActorPlayEnable
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047B9 RID: 18361
		// (get) Token: 0x0600F002 RID: 61442 RVA: 0x00232C35 File Offset: 0x00230E35
		public override EToggleDragActorPlayType Type
		{
			get
			{
				return (EToggleDragActorPlayType)this.Instance.Type;
			}
		}

		// Token: 0x170047BA RID: 18362
		// (get) Token: 0x0600F003 RID: 61443 RVA: 0x00232C42 File Offset: 0x00230E42
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
				this._CameraConfigCache = IFixedCameraConfig.Create(this.Instance.CameraConfig);
				return this._CameraConfigCache;
			}
		}

		// Token: 0x170047BB RID: 18363
		// (get) Token: 0x0600F004 RID: 61444 RVA: 0x00232C76 File Offset: 0x00230E76
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x170047BC RID: 18364
		// (get) Token: 0x0600F005 RID: 61445 RVA: 0x00232C83 File Offset: 0x00230E83
		public virtual string TidSubText
		{
			get
			{
				return this.Instance.TidSubText;
			}
		}

		// Token: 0x170047BD RID: 18365
		// (get) Token: 0x0600F006 RID: 61446 RVA: 0x00232C90 File Offset: 0x00230E90
		public virtual string TidHintText
		{
			get
			{
				return this.Instance.TidHintText;
			}
		}

		// Token: 0x170047BE RID: 18366
		// (get) Token: 0x0600F007 RID: 61447 RVA: 0x00232CA0 File Offset: 0x00230EA0
		public virtual bool? KeepDialog
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepDialog);
			}
		}

		// Token: 0x170047BF RID: 18367
		// (get) Token: 0x0600F008 RID: 61448 RVA: 0x00232CD8 File Offset: 0x00230ED8
		public virtual bool? DisableExit
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableExit);
			}
		}

		// Token: 0x170047C0 RID: 18368
		// (get) Token: 0x0600F009 RID: 61449 RVA: 0x00232D0E File Offset: 0x00230F0E
		public virtual string EdTidMainText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047C1 RID: 18369
		// (get) Token: 0x0600F00A RID: 61450 RVA: 0x00232D11 File Offset: 0x00230F11
		public virtual string EdTidSubText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047C2 RID: 18370
		// (get) Token: 0x0600F00B RID: 61451 RVA: 0x00232D14 File Offset: 0x00230F14
		public virtual string EdTidHintText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040083FB RID: 33787
		private IToggleDragActorPlayEnable Instance;

		// Token: 0x040083FC RID: 33788
		private IFixedCameraConfig _CameraConfigCache;

		// Token: 0x040083FD RID: 33789
		private bool _CameraConfigInited;
	}
}
