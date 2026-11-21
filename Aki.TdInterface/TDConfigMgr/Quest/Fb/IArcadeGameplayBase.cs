using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015CA RID: 5578
	public class IArcadeGameplayBase
	{
		// Token: 0x06007DDD RID: 32221 RVA: 0x0012B557 File Offset: 0x00129757
		public static IArcadeGameplayBase Create(IArcadeGameplayBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IArcadeGameplayBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170029EB RID: 10731
		// (get) Token: 0x06007DDE RID: 32222 RVA: 0x0012B576 File Offset: 0x00129776
		public virtual EArcadeGameplayType Type
		{
			get
			{
				return (EArcadeGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x040048DA RID: 18650
		private IArcadeGameplayBase Instance;
	}
}
