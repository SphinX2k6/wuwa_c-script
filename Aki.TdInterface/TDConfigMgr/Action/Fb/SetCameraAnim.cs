using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A8B RID: 10891
	public class SetCameraAnim : ActionParams
	{
		// Token: 0x0600F05C RID: 61532 RVA: 0x002339E6 File Offset: 0x00231BE6
		public static SetCameraAnim Create(ISetCameraAnim? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetCameraAnim
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047F4 RID: 18420
		// (get) Token: 0x0600F05D RID: 61533 RVA: 0x00233A05 File Offset: 0x00231C05
		public virtual string CameraAnimDataAsset
		{
			get
			{
				return this.Instance.CameraAnimDataAsset;
			}
		}

		// Token: 0x170047F5 RID: 18421
		// (get) Token: 0x0600F05E RID: 61534 RVA: 0x00233A12 File Offset: 0x00231C12
		public virtual float Speed
		{
			get
			{
				return this.Instance.Speed;
			}
		}

		// Token: 0x170047F6 RID: 18422
		// (get) Token: 0x0600F05F RID: 61535 RVA: 0x00233A20 File Offset: 0x00231C20
		public virtual bool? UseNoise
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.UseNoise);
			}
		}

		// Token: 0x0400842F RID: 33839
		private ISetCameraAnim Instance;
	}
}
