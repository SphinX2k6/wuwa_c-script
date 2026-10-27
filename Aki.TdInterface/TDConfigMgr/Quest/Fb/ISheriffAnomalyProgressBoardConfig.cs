using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001418 RID: 5144
	public class ISheriffAnomalyProgressBoardConfig
	{
		// Token: 0x060074E8 RID: 29928 RVA: 0x0011768E File Offset: 0x0011588E
		[NullableContext(1)]
		public static ISheriffAnomalyProgressBoardConfig Create(ISheriffAnomalyProgressBoardConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffAnomalyProgressBoardConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700268B RID: 9867
		// (get) Token: 0x060074E9 RID: 29929 RVA: 0x001176AD File Offset: 0x001158AD
		public virtual int AnomalyId
		{
			get
			{
				return this.Instance.AnomalyId;
			}
		}

		// Token: 0x040043B0 RID: 17328
		private ISheriffAnomalyProgressBoardConfig Instance;
	}
}
