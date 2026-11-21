using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B18 RID: 11032
	public class IInteractEffect
	{
		// Token: 0x0600F2AF RID: 62127 RVA: 0x0023708A File Offset: 0x0023528A
		public static IInteractEffect Create(IInteractEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700492D RID: 18733
		// (get) Token: 0x0600F2B0 RID: 62128 RVA: 0x002370A9 File Offset: 0x002352A9
		public virtual EInteractEffectType Type
		{
			get
			{
				return (EInteractEffectType)this.Instance.Type;
			}
		}

		// Token: 0x1700492E RID: 18734
		// (get) Token: 0x0600F2B1 RID: 62129 RVA: 0x002370B8 File Offset: 0x002352B8
		public virtual float? DelayTime
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

		// Token: 0x0400852C RID: 34092
		private IInteractEffect Instance;
	}
}
