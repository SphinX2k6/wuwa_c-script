using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B7A RID: 2938
	public class ISpawnMonsterCompleteCondition
	{
		// Token: 0x060043AB RID: 17323 RVA: 0x000AC5C0 File Offset: 0x000AA7C0
		[NullableContext(1)]
		public static ISpawnMonsterCompleteCondition Create(ISpawnMonsterCompleteCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnMonsterCompleteCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x060043AC RID: 17324 RVA: 0x000AC5DF File Offset: 0x000AA7DF
		public virtual ESpawnMonsterCompleteCondition Type
		{
			get
			{
				return (ESpawnMonsterCompleteCondition)this.Instance.Type;
			}
		}

		// Token: 0x0400262B RID: 9771
		private ISpawnMonsterCompleteCondition Instance;
	}
}
