using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001437 RID: 5175
	public class IKillSingleMonster
	{
		// Token: 0x060075A9 RID: 30121 RVA: 0x0011905D File Offset: 0x0011725D
		[NullableContext(1)]
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

		// Token: 0x1700270E RID: 9998
		// (get) Token: 0x060075AA RID: 30122 RVA: 0x0011907C File Offset: 0x0011727C
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x1700270F RID: 9999
		// (get) Token: 0x060075AB RID: 30123 RVA: 0x00119089 File Offset: 0x00117289
		public virtual int AddTime
		{
			get
			{
				return this.Instance.AddTime;
			}
		}

		// Token: 0x0400442D RID: 17453
		private IKillSingleMonster Instance;
	}
}
