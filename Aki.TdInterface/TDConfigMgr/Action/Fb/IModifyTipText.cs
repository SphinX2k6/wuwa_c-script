using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B19 RID: 11033
	public class IModifyTipText : IInteractEffect
	{
		// Token: 0x0600F2B3 RID: 62131 RVA: 0x002370F6 File Offset: 0x002352F6
		public static IModifyTipText Create(IModifyTipText? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyTipText
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700492F RID: 18735
		// (get) Token: 0x0600F2B4 RID: 62132 RVA: 0x00237115 File Offset: 0x00235315
		public override EInteractEffectType Type
		{
			get
			{
				return (EInteractEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17004930 RID: 18736
		// (get) Token: 0x0600F2B5 RID: 62133 RVA: 0x00237124 File Offset: 0x00235324
		public override float? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DelayTime);
			}
		}

		// Token: 0x17004931 RID: 18737
		// (get) Token: 0x0600F2B6 RID: 62134 RVA: 0x0023715A File Offset: 0x0023535A
		public virtual string TipText
		{
			get
			{
				return this.Instance.TipText;
			}
		}

		// Token: 0x0400852D RID: 34093
		private IModifyTipText Instance;
	}
}
