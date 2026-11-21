using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AEC RID: 10988
	public class INpcSwingGetUp : INpcLeisureInteractType
	{
		// Token: 0x0600F1DE RID: 61918 RVA: 0x00235B72 File Offset: 0x00233D72
		public static INpcSwingGetUp Create(INpcSwingGetUp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSwingGetUp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048B4 RID: 18612
		// (get) Token: 0x0600F1DF RID: 61919 RVA: 0x00235B91 File Offset: 0x00233D91
		public override ENpcLeisureInteract Type
		{
			get
			{
				return (ENpcLeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x170048B5 RID: 18613
		// (get) Token: 0x0600F1E0 RID: 61920 RVA: 0x00235BA0 File Offset: 0x00233DA0
		public override bool? KeepState
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepState);
			}
		}

		// Token: 0x170048B6 RID: 18614
		// (get) Token: 0x0600F1E1 RID: 61921 RVA: 0x00235BD6 File Offset: 0x00233DD6
		public virtual int TargetNpcId
		{
			get
			{
				return this.Instance.TargetNpcId;
			}
		}

		// Token: 0x040084CC RID: 33996
		private INpcSwingGetUp Instance;
	}
}
