using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C49 RID: 3145
	public class IAllKillCondition : ISpawnMonsterCompleteCondition
	{
		// Token: 0x06004807 RID: 18439 RVA: 0x000B66B8 File Offset: 0x000B48B8
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

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x06004808 RID: 18440 RVA: 0x000B66D7 File Offset: 0x000B48D7
		public override ESpawnMonsterCompleteCondition Type
		{
			get
			{
				return (ESpawnMonsterCompleteCondition)this.Instance.Type;
			}
		}

		// Token: 0x04002874 RID: 10356
		private IAllKillCondition Instance;
	}
}
