using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B7B RID: 2939
	public class IAllKillCondition : ISpawnMonsterCompleteCondition
	{
		// Token: 0x060043AE RID: 17326 RVA: 0x000AC5F4 File Offset: 0x000AA7F4
		[NullableContext(1)]
		public static IAllKillCondition Create(IAllKillCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAllKillCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x060043AF RID: 17327 RVA: 0x000AC613 File Offset: 0x000AA813
		public override ESpawnMonsterCompleteCondition Type
		{
			get
			{
				return (ESpawnMonsterCompleteCondition)this.Instance.Type;
			}
		}

		// Token: 0x0400262C RID: 9772
		private IAllKillCondition Instance;
	}
}
