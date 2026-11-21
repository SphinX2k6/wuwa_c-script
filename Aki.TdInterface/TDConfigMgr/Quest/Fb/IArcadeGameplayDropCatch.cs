using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015CB RID: 5579
	public class IArcadeGameplayDropCatch : IArcadeGameplayBase
	{
		// Token: 0x06007DE0 RID: 32224 RVA: 0x0012B58B File Offset: 0x0012978B
		public static IArcadeGameplayDropCatch Create(IArcadeGameplayDropCatch? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IArcadeGameplayDropCatch
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170029EC RID: 10732
		// (get) Token: 0x06007DE1 RID: 32225 RVA: 0x0012B5AA File Offset: 0x001297AA
		public override EArcadeGameplayType Type
		{
			get
			{
				return (EArcadeGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x170029ED RID: 10733
		// (get) Token: 0x06007DE2 RID: 32226 RVA: 0x0012B5B7 File Offset: 0x001297B7
		public virtual int LevelId
		{
			get
			{
				return this.Instance.LevelId;
			}
		}

		// Token: 0x040048DB RID: 18651
		private IArcadeGameplayDropCatch Instance;
	}
}
