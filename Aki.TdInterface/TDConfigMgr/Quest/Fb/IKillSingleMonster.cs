using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200158F RID: 5519
	public class IKillSingleMonster
	{
		// Token: 0x06007C6E RID: 31854 RVA: 0x00127AA9 File Offset: 0x00125CA9
		public static IKillSingleMonster Create(IKillSingleMonster? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKillSingleMonster
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170028F2 RID: 10482
		// (get) Token: 0x06007C6F RID: 31855 RVA: 0x00127AC8 File Offset: 0x00125CC8
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170028F3 RID: 10483
		// (get) Token: 0x06007C70 RID: 31856 RVA: 0x00127AD5 File Offset: 0x00125CD5
		public virtual int AddTime
		{
			get
			{
				return this.Instance.AddTime;
			}
		}

		// Token: 0x040047C1 RID: 18369
		private IKillSingleMonster Instance;
	}
}
