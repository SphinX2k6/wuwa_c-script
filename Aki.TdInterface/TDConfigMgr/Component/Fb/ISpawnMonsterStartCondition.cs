using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C45 RID: 3141
	public class ISpawnMonsterStartCondition
	{
		// Token: 0x060047FA RID: 18426 RVA: 0x000B65DB File Offset: 0x000B47DB
		public static ISpawnMonsterStartCondition Create(ISpawnMonsterStartCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnMonsterStartCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x060047FB RID: 18427 RVA: 0x000B65FA File Offset: 0x000B47FA
		public virtual ESpawnMonsterStartCondition Type
		{
			get
			{
				return (ESpawnMonsterStartCondition)this.Instance.Type;
			}
		}

		// Token: 0x04002870 RID: 10352
		private ISpawnMonsterStartCondition Instance;
	}
}
