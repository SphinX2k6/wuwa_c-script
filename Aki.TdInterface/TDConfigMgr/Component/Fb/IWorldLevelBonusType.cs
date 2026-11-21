using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B61 RID: 2913
	public class IWorldLevelBonusType
	{
		// Token: 0x06004285 RID: 17029 RVA: 0x000A8FC7 File Offset: 0x000A71C7
		public static IWorldLevelBonusType Create(IWorldLevelBonusType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWorldLevelBonusType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x06004286 RID: 17030 RVA: 0x000A8FE6 File Offset: 0x000A71E6
		public virtual EWorldLevelBonus Type
		{
			get
			{
				return (EWorldLevelBonus)this.Instance.Type;
			}
		}

		// Token: 0x040024DA RID: 9434
		private IWorldLevelBonusType Instance;
	}
}
