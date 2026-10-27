using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027A9 RID: 10153
	[NullableContext(2)]
	[Nullable(0)]
	public class IToggleDragActorPlayEnable : IToggleDragActorPlayType
	{
		// Token: 0x0600E1E3 RID: 57827 RVA: 0x00215E82 File Offset: 0x00214082
		[NullableContext(1)]
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

		// Token: 0x17004453 RID: 17491
		// (get) Token: 0x0600E1E4 RID: 57828 RVA: 0x00215EA1 File Offset: 0x002140A1
		public override EToggleDragActorPlayType Type
		{
			get
			{
				return (EToggleDragActorPlayType)this.Instance.Type;
			}
		}

		// Token: 0x17004454 RID: 17492
		// (get) Token: 0x0600E1E5 RID: 57829 RVA: 0x00215EAE File Offset: 0x002140AE
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
				this._CameraConfigCache = IFixedCameraConfig.Create(this.Instance.CameraConfig);
				return this._CameraConfigCache;
			}
		}

		// Token: 0x17004455 RID: 17493
		// (get) Token: 0x0600E1E6 RID: 57830 RVA: 0x00215EE2 File Offset: 0x002140E2
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x17004456 RID: 17494
		// (get) Token: 0x0600E1E7 RID: 57831 RVA: 0x00215EEF File Offset: 0x002140EF
		public virtual string TidSubText
		{
			get
			{
				return this.Instance.TidSubText;
			}
		}

		// Token: 0x17004457 RID: 17495
		// (get) Token: 0x0600E1E8 RID: 57832 RVA: 0x00215EFC File Offset: 0x002140FC
		public virtual string TidHintText
		{
			get
			{
				return this.Instance.TidHintText;
			}
		}

		// Token: 0x17004458 RID: 17496
		// (get) Token: 0x0600E1E9 RID: 57833 RVA: 0x00215F0C File Offset: 0x0021410C
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

		// Token: 0x17004459 RID: 17497
		// (get) Token: 0x0600E1EA RID: 57834 RVA: 0x00215F44 File Offset: 0x00214144
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

		// Token: 0x1700445A RID: 17498
		// (get) Token: 0x0600E1EB RID: 57835 RVA: 0x00215F7A File Offset: 0x0021417A
		public virtual string EdTidMainText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700445B RID: 17499
		// (get) Token: 0x0600E1EC RID: 57836 RVA: 0x00215F7D File Offset: 0x0021417D
		public virtual string EdTidSubText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700445C RID: 17500
		// (get) Token: 0x0600E1ED RID: 57837 RVA: 0x00215F80 File Offset: 0x00214180
		public virtual string EdTidHintText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04007D45 RID: 32069
		private IToggleDragActorPlayEnable Instance;

		// Token: 0x04007D46 RID: 32070
		private IFixedCameraConfig _CameraConfigCache;

		// Token: 0x04007D47 RID: 32071
		private bool _CameraConfigInited;
	}
}
