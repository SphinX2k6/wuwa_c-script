using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B7C RID: 2940
	public class IDurationCondition : ISpawnMonsterCompleteCondition
	{
		// Token: 0x060043B1 RID: 17329 RVA: 0x000AC628 File Offset: 0x000AA828
		[NullableContext(1)]
		public static IDurationCondition Create(IDurationCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDurationCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x060043B2 RID: 17330 RVA: 0x000AC647 File Offset: 0x000AA847
		public override ESpawnMonsterCompleteCondition Type
		{
			get
			{
				return (ESpawnMonsterCompleteCondition)this.Instance.Type;
			}
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x060043B3 RID: 17331 RVA: 0x000AC654 File Offset: 0x000AA854
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x060043B4 RID: 17332 RVA: 0x000AC664 File Offset: 0x000AA864
		public virtual bool? Refill
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Refill);
			}
		}

		// Token: 0x0400262D RID: 9773
		private IDurationCondition Instance;
	}
}
