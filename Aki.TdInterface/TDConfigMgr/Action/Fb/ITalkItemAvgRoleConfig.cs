using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002802 RID: 10242
	public class ITalkItemAvgRoleConfig
	{
		// Token: 0x0600E362 RID: 58210 RVA: 0x002187EE File Offset: 0x002169EE
		public static ITalkItemAvgRoleConfig Create(ITalkItemAvgRoleConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAvgRoleConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700400C RID: 16396
		// (get) Token: 0x0600E363 RID: 58211 RVA: 0x00218810 File Offset: 0x00216A10
		public virtual EAvgVisualEffect? VisualEffect
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EAvgVisualEffect?((EAvgVisualEffect)this.Instance.VisualEffect);
			}
		}

		// Token: 0x1700400D RID: 16397
		// (get) Token: 0x0600E364 RID: 58212 RVA: 0x00218846 File Offset: 0x00216A46
		public virtual EAvgRoleAnimationType AnimationType
		{
			get
			{
				return (EAvgRoleAnimationType)this.Instance.AnimationType;
			}
		}

		// Token: 0x1700400E RID: 16398
		// (get) Token: 0x0600E365 RID: 58213 RVA: 0x00218854 File Offset: 0x00216A54
		public virtual bool? IsAnimationLoop
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAnimationLoop);
			}
		}

		// Token: 0x04007C52 RID: 31826
		private ITalkItemAvgRoleConfig Instance;
	}
}
