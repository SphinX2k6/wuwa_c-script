using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200143F RID: 5183
	public class IDarkTideMechaAssemblyBossEvent : IDarkTideBossEvent
	{
		// Token: 0x06007543 RID: 30019 RVA: 0x00119A05 File Offset: 0x00117C05
		public static IDarkTideMechaAssemblyBossEvent Create(IDarkTideMechaAssemblyBossEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideMechaAssemblyBossEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002467 RID: 9319
		// (get) Token: 0x06007544 RID: 30020 RVA: 0x00119A24 File Offset: 0x00117C24
		public override EDarkTideBossEventType Type
		{
			get
			{
				return (EDarkTideBossEventType)this.Instance.Type;
			}
		}

		// Token: 0x040042E5 RID: 17125
		private IDarkTideMechaAssemblyBossEvent Instance;
	}
}
