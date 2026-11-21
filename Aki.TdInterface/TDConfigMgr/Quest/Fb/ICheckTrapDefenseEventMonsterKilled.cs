using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001532 RID: 5426
	public class ICheckTrapDefenseEventMonsterKilled : ICheckTrapDefenseEventBase
	{
		// Token: 0x06007AB4 RID: 31412 RVA: 0x00124806 File Offset: 0x00122A06
		public static ICheckTrapDefenseEventMonsterKilled Create(ICheckTrapDefenseEventMonsterKilled? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckTrapDefenseEventMonsterKilled
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027F2 RID: 10226
		// (get) Token: 0x06007AB5 RID: 31413 RVA: 0x00124825 File Offset: 0x00122A25
		public override ECheckTrapDefenseEvent Type
		{
			get
			{
				return (ECheckTrapDefenseEvent)this.Instance.Type;
			}
		}

		// Token: 0x170027F3 RID: 10227
		// (get) Token: 0x06007AB6 RID: 31414 RVA: 0x00124832 File Offset: 0x00122A32
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040046B0 RID: 18096
		private ICheckTrapDefenseEventMonsterKilled Instance;
	}
}
