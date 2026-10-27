using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002543 RID: 9539
	public class ICameraSetting
	{
		// Token: 0x0600D4A9 RID: 54441 RVA: 0x001F7DD7 File Offset: 0x001F5FD7
		[NullableContext(1)]
		public static ICameraSetting Create(ICameraSetting? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraSetting
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003BE5 RID: 15333
		// (get) Token: 0x0600D4AA RID: 54442 RVA: 0x001F7DF6 File Offset: 0x001F5FF6
		public virtual float Aperture
		{
			get
			{
				return this.Instance.Aperture;
			}
		}

		// Token: 0x17003BE6 RID: 15334
		// (get) Token: 0x0600D4AB RID: 54443 RVA: 0x001F7E03 File Offset: 0x001F6003
		public virtual float FocalLength
		{
			get
			{
				return this.Instance.FocalLength;
			}
		}

		// Token: 0x17003BE7 RID: 15335
		// (get) Token: 0x0600D4AC RID: 54444 RVA: 0x001F7E10 File Offset: 0x001F6010
		public virtual float FocusDistance
		{
			get
			{
				return this.Instance.FocusDistance;
			}
		}

		// Token: 0x17003BE8 RID: 15336
		// (get) Token: 0x0600D4AD RID: 54445 RVA: 0x001F7E1D File Offset: 0x001F601D
		public virtual float FocalRegion
		{
			get
			{
				return this.Instance.FocalRegion;
			}
		}

		// Token: 0x17003BE9 RID: 15337
		// (get) Token: 0x0600D4AE RID: 54446 RVA: 0x001F7E2C File Offset: 0x001F602C
		public virtual float? Fov
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Fov);
			}
		}

		// Token: 0x04007491 RID: 29841
		private ICameraSetting Instance;
	}
}
