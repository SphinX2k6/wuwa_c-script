using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A97 RID: 2711
	public class IWorldLevelBonusType
	{
		// Token: 0x06003E5C RID: 15964 RVA: 0x0009FA0F File Offset: 0x0009DC0F
		[NullableContext(1)]
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

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06003E5D RID: 15965 RVA: 0x0009FA2E File Offset: 0x0009DC2E
		public virtual EWorldLevelBonus Type
		{
			get
			{
				return (EWorldLevelBonus)this.Instance.Type;
			}
		}

		// Token: 0x040022BE RID: 8894
		private IWorldLevelBonusType Instance;
	}
}
