using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C48 RID: 3144
	public class ISpawnMonsterCompleteCondition
	{
		// Token: 0x06004804 RID: 18436 RVA: 0x000B6684 File Offset: 0x000B4884
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

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x06004805 RID: 18437 RVA: 0x000B66A3 File Offset: 0x000B48A3
		public virtual ESpawnMonsterCompleteCondition Type
		{
			get
			{
				return (ESpawnMonsterCompleteCondition)this.Instance.Type;
			}
		}

		// Token: 0x04002873 RID: 10355
		private ISpawnMonsterCompleteCondition Instance;
	}
}
