using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C1C RID: 11292
	public class IEnableAllPlayerOperation : SetPlayerOperationRestriction
	{
		// Token: 0x0600F880 RID: 63616 RVA: 0x00241EDF File Offset: 0x002400DF
		public static IEnableAllPlayerOperation Create(IEnableAllPlayerOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableAllPlayerOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CF6 RID: 19702
		// (get) Token: 0x0600F881 RID: 63617 RVA: 0x00241EFE File Offset: 0x002400FE
		public override EPlayerOperationType Type
		{
			get
			{
				return (EPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004CF7 RID: 19703
		// (get) Token: 0x0600F882 RID: 63618 RVA: 0x00241F0C File Offset: 0x0024010C
		public virtual bool? IsUiFadeEffect
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsUiFadeEffect);
			}
		}

		// Token: 0x040087F4 RID: 34804
		private IEnableAllPlayerOperation Instance;
	}
}
