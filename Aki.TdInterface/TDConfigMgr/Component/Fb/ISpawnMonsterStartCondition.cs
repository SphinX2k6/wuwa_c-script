using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B77 RID: 2935
	public class ISpawnMonsterStartCondition
	{
		// Token: 0x060043A1 RID: 17313 RVA: 0x000AC517 File Offset: 0x000AA717
		[NullableContext(1)]
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

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x060043A2 RID: 17314 RVA: 0x000AC536 File Offset: 0x000AA736
		public virtual ESpawnMonsterStartCondition Type
		{
			get
			{
				return (ESpawnMonsterStartCondition)this.Instance.Type;
			}
		}

		// Token: 0x04002628 RID: 9768
		private ISpawnMonsterStartCondition Instance;
	}
}
