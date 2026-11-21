using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F41 RID: 3905
	public class IFireBoxFishEffect : IGraph3dEffectBase
	{
		// Token: 0x060057AB RID: 22443 RVA: 0x000D6ACE File Offset: 0x000D4CCE
		public static IFireBoxFishEffect Create(IFireBoxFishEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFireBoxFishEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x060057AC RID: 22444 RVA: 0x000D6AED File Offset: 0x000D4CED
		public override EGraph3dEffectType Type
		{
			get
			{
				return (EGraph3dEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x060057AD RID: 22445 RVA: 0x000D6AFA File Offset: 0x000D4CFA
		public virtual string Effect
		{
			get
			{
				return this.Instance.Effect;
			}
		}

		// Token: 0x04003258 RID: 12888
		private IFireBoxFishEffect Instance;
	}
}
