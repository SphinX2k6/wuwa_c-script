using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DAA RID: 11690
	public class IDeadeyeCameraConfig
	{
		// Token: 0x0600FEB2 RID: 65202 RVA: 0x0024BA99 File Offset: 0x00249C99
		public static IDeadeyeCameraConfig Create(IDeadeyeCameraConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeadeyeCameraConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700500C RID: 20492
		// (get) Token: 0x0600FEB3 RID: 65203 RVA: 0x0024BAB8 File Offset: 0x00249CB8
		public virtual int LookAtPointId
		{
			get
			{
				return this.Instance.LookAtPointId;
			}
		}

		// Token: 0x1700500D RID: 20493
		// (get) Token: 0x0600FEB4 RID: 65204 RVA: 0x0024BAC8 File Offset: 0x00249CC8
		public virtual int? SubLensTag
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SubLensTag);
			}
		}

		// Token: 0x1700500E RID: 20494
		// (get) Token: 0x0600FEB5 RID: 65205 RVA: 0x0024BAFE File Offset: 0x00249CFE
		public virtual float TransitionTime
		{
			get
			{
				return this.Instance.TransitionTime;
			}
		}

		// Token: 0x04008B08 RID: 35592
		private IDeadeyeCameraConfig Instance;
	}
}
