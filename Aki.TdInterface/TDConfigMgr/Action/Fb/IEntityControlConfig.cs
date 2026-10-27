using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025C9 RID: 9673
	public class IEntityControlConfig
	{
		// Token: 0x0600D971 RID: 55665 RVA: 0x00206DC6 File Offset: 0x00204FC6
		[NullableContext(1)]
		public static IEntityControlConfig Create(IEntityControlConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityControlConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003FA1 RID: 16289
		// (get) Token: 0x0600D972 RID: 55666 RVA: 0x00206DE8 File Offset: 0x00204FE8
		public virtual bool? IsControlPlayer
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsControlPlayer);
			}
		}

		// Token: 0x17003FA2 RID: 16290
		// (get) Token: 0x0600D973 RID: 55667 RVA: 0x00206E20 File Offset: 0x00205020
		public virtual bool? HideSkipButton
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.HideSkipButton);
			}
		}

		// Token: 0x17003FA3 RID: 16291
		// (get) Token: 0x0600D974 RID: 55668 RVA: 0x00206E58 File Offset: 0x00205058
		public virtual EEntityControlCameraMode? CameraMode
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new EEntityControlCameraMode?((EEntityControlCameraMode)this.Instance.CameraMode);
			}
		}

		// Token: 0x040078C1 RID: 30913
		private IEntityControlConfig Instance;
	}
}
