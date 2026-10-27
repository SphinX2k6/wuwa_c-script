using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A8D RID: 10893
	public class ITrapDefensePlayerOperationSpawnMonster : ITrapDefensePlayerOperationType
	{
		// Token: 0x0600EF54 RID: 61268 RVA: 0x0022CC2C File Offset: 0x0022AE2C
		[NullableContext(1)]
		public static ITrapDefensePlayerOperationSpawnMonster Create(ITrapDefensePlayerOperationSpawnMonster? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationSpawnMonster
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BFC RID: 19452
		// (get) Token: 0x0600EF55 RID: 61269 RVA: 0x0022CC4B File Offset: 0x0022AE4B
		public override ETrapDefensePlayerOperationType Type
		{
			get
			{
				return (ETrapDefensePlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x040083AD RID: 33709
		private ITrapDefensePlayerOperationSpawnMonster Instance;
	}
}
