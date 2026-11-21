using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C4C RID: 3148
	public class ISpawnMonsterPreConditonType
	{
		// Token: 0x06004814 RID: 18452 RVA: 0x000B67DE File Offset: 0x000B49DE
		public static ISpawnMonsterPreConditonType Create(ISpawnMonsterPreConditonType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnMonsterPreConditonType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x06004815 RID: 18453 RVA: 0x000B67FD File Offset: 0x000B49FD
		public virtual ESpawnMonsterPreCondition Type
		{
			get
			{
				return (ESpawnMonsterPreCondition)this.Instance.Type;
			}
		}

		// Token: 0x04002877 RID: 10359
		private ISpawnMonsterPreConditonType Instance;
	}
}
