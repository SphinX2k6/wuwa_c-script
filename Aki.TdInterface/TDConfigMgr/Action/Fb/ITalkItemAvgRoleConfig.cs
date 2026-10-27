using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002559 RID: 9561
	public class ITalkItemAvgRoleConfig
	{
		// Token: 0x0600D5F8 RID: 54776 RVA: 0x001FCBF2 File Offset: 0x001FADF2
		[NullableContext(1)]
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

		// Token: 0x17003D08 RID: 15624
		// (get) Token: 0x0600D5F9 RID: 54777 RVA: 0x001FCC14 File Offset: 0x001FAE14
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

		// Token: 0x17003D09 RID: 15625
		// (get) Token: 0x0600D5FA RID: 54778 RVA: 0x001FCC4A File Offset: 0x001FAE4A
		public virtual EAvgRoleAnimationType AnimationType
		{
			get
			{
				return (EAvgRoleAnimationType)this.Instance.AnimationType;
			}
		}

		// Token: 0x17003D0A RID: 15626
		// (get) Token: 0x0600D5FB RID: 54779 RVA: 0x001FCC58 File Offset: 0x001FAE58
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

		// Token: 0x040075F5 RID: 30197
		private ITalkItemAvgRoleConfig Instance;
	}
}
