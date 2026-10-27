using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B79 RID: 2937
	public class ITriggerRangeStartCondition : ISpawnMonsterStartCondition
	{
		// Token: 0x060043A7 RID: 17319 RVA: 0x000AC57F File Offset: 0x000AA77F
		[NullableContext(1)]
		public static ITriggerRangeStartCondition Create(ITriggerRangeStartCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggerRangeStartCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x060043A8 RID: 17320 RVA: 0x000AC59E File Offset: 0x000AA79E
		public override ESpawnMonsterStartCondition Type
		{
			get
			{
				return (ESpawnMonsterStartCondition)this.Instance.Type;
			}
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x060043A9 RID: 17321 RVA: 0x000AC5AB File Offset: 0x000AA7AB
		public virtual int Range
		{
			get
			{
				return this.Instance.Range;
			}
		}

		// Token: 0x0400262A RID: 9770
		private ITriggerRangeStartCondition Instance;
	}
}
