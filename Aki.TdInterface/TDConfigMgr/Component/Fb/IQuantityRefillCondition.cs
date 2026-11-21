using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C4B RID: 3147
	public class IQuantityRefillCondition : ISpawnMonsterCompleteCondition
	{
		// Token: 0x0600480F RID: 18447 RVA: 0x000B6766 File Offset: 0x000B4966
		public static IQuantityRefillCondition Create(IQuantityRefillCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuantityRefillCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06004810 RID: 18448 RVA: 0x000B6785 File Offset: 0x000B4985
		public override ESpawnMonsterCompleteCondition Type
		{
			get
			{
				return (ESpawnMonsterCompleteCondition)this.Instance.Type;
			}
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06004811 RID: 18449 RVA: 0x000B6792 File Offset: 0x000B4992
		public virtual int Quantity
		{
			get
			{
				return this.Instance.Quantity;
			}
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x06004812 RID: 18450 RVA: 0x000B67A0 File Offset: 0x000B49A0
		public virtual float? DelayRefill
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DelayRefill);
			}
		}

		// Token: 0x04002876 RID: 10358
		private IQuantityRefillCondition Instance;
	}
}
