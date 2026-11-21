using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002878 RID: 10360
	public class IEntityControlConfig
	{
		// Token: 0x0600E6EB RID: 59115 RVA: 0x00222A9A File Offset: 0x00220C9A
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

		// Token: 0x170042A9 RID: 17065
		// (get) Token: 0x0600E6EC RID: 59116 RVA: 0x00222ABC File Offset: 0x00220CBC
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

		// Token: 0x170042AA RID: 17066
		// (get) Token: 0x0600E6ED RID: 59117 RVA: 0x00222AF4 File Offset: 0x00220CF4
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

		// Token: 0x170042AB RID: 17067
		// (get) Token: 0x0600E6EE RID: 59118 RVA: 0x00222B2C File Offset: 0x00220D2C
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

		// Token: 0x04007F28 RID: 32552
		private IEntityControlConfig Instance;
	}
}
