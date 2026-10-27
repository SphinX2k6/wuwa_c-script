using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B7D RID: 2941
	public class IQuantityRefillCondition : ISpawnMonsterCompleteCondition
	{
		// Token: 0x060043B6 RID: 17334 RVA: 0x000AC6A2 File Offset: 0x000AA8A2
		[NullableContext(1)]
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

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x060043B7 RID: 17335 RVA: 0x000AC6C1 File Offset: 0x000AA8C1
		public override ESpawnMonsterCompleteCondition Type
		{
			get
			{
				return (ESpawnMonsterCompleteCondition)this.Instance.Type;
			}
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x060043B8 RID: 17336 RVA: 0x000AC6CE File Offset: 0x000AA8CE
		public virtual int Quantity
		{
			get
			{
				return this.Instance.Quantity;
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x060043B9 RID: 17337 RVA: 0x000AC6DC File Offset: 0x000AA8DC
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

		// Token: 0x0400262E RID: 9774
		private IQuantityRefillCondition Instance;
	}
}
