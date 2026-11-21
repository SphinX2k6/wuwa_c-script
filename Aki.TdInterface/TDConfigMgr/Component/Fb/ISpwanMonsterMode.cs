using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C4F RID: 3151
	public class ISpwanMonsterMode
	{
		// Token: 0x06004822 RID: 18466 RVA: 0x000B69C8 File Offset: 0x000B4BC8
		public static ISpwanMonsterMode Create(ISpwanMonsterMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpwanMonsterMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x06004823 RID: 18467 RVA: 0x000B69E7 File Offset: 0x000B4BE7
		public virtual ESpawnMonsterConstraint Type
		{
			get
			{
				return (ESpawnMonsterConstraint)this.Instance.Type;
			}
		}

		// Token: 0x04002882 RID: 10370
		private ISpwanMonsterMode Instance;
	}
}
