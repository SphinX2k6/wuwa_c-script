using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001471 RID: 5233
	public class IArcadeGameplayBase
	{
		// Token: 0x0600770F RID: 30479 RVA: 0x0011C93F File Offset: 0x0011AB3F
		[NullableContext(1)]
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

		// Token: 0x17002800 RID: 10240
		// (get) Token: 0x06007710 RID: 30480 RVA: 0x0011C95E File Offset: 0x0011AB5E
		public virtual EArcadeGameplayType Type
		{
			get
			{
				return (EArcadeGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x0400453F RID: 17727
		private IArcadeGameplayBase Instance;
	}
}
