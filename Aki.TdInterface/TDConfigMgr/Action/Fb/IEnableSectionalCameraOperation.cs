using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C2D RID: 11309
	public class IEnableSectionalCameraOperation : ICameraOperationType
	{
		// Token: 0x0600F8DD RID: 63709 RVA: 0x00242B76 File Offset: 0x00240D76
		public static IEnableSectionalCameraOperation Create(IEnableSectionalCameraOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableSectionalCameraOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D31 RID: 19761
		// (get) Token: 0x0600F8DE RID: 63710 RVA: 0x00242B95 File Offset: 0x00240D95
		public override ECameraOperationType Type
		{
			get
			{
				return (ECameraOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004D32 RID: 19762
		// (get) Token: 0x0600F8DF RID: 63711 RVA: 0x00242BA4 File Offset: 0x00240DA4
		public virtual bool? EnableRotate
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.EnableRotate);
			}
		}

		// Token: 0x17004D33 RID: 19763
		// (get) Token: 0x0600F8E0 RID: 63712 RVA: 0x00242BDC File Offset: 0x00240DDC
		public virtual bool? EnableZoom
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.EnableZoom);
			}
		}

		// Token: 0x04008817 RID: 34839
		private IEnableSectionalCameraOperation Instance;
	}
}
