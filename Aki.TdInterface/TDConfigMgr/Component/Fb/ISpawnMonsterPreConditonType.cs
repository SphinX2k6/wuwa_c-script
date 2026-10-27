using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B7E RID: 2942
	public class ISpawnMonsterPreConditonType
	{
		// Token: 0x060043BB RID: 17339 RVA: 0x000AC71A File Offset: 0x000AA91A
		[NullableContext(1)]
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

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x060043BC RID: 17340 RVA: 0x000AC739 File Offset: 0x000AA939
		public virtual ESpawnMonsterPreCondition Type
		{
			get
			{
				return (ESpawnMonsterPreCondition)this.Instance.Type;
			}
		}

		// Token: 0x0400262F RID: 9775
		private ISpawnMonsterPreConditonType Instance;
	}
}
