using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001472 RID: 5234
	public class IArcadeGameplayDropCatch : IArcadeGameplayBase
	{
		// Token: 0x06007712 RID: 30482 RVA: 0x0011C973 File Offset: 0x0011AB73
		[NullableContext(1)]
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

		// Token: 0x17002801 RID: 10241
		// (get) Token: 0x06007713 RID: 30483 RVA: 0x0011C992 File Offset: 0x0011AB92
		public override EArcadeGameplayType Type
		{
			get
			{
				return (EArcadeGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17002802 RID: 10242
		// (get) Token: 0x06007714 RID: 30484 RVA: 0x0011C99F File Offset: 0x0011AB9F
		public virtual int LevelId
		{
			get
			{
				return this.Instance.LevelId;
			}
		}

		// Token: 0x04004540 RID: 17728
		private IArcadeGameplayDropCatch Instance;
	}
}
