using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200138F RID: 5007
	public class ITargetBattleAttribute
	{
		// Token: 0x06007285 RID: 29317 RVA: 0x0011358A File Offset: 0x0011178A
		[NullableContext(1)]
		public static ITargetBattleAttribute Create(ITargetBattleAttribute? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetBattleAttribute
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700253A RID: 9530
		// (get) Token: 0x06007286 RID: 29318 RVA: 0x001135A9 File Offset: 0x001117A9
		public virtual ETargetBattleAttribute Type
		{
			get
			{
				return (ETargetBattleAttribute)this.Instance.Type;
			}
		}

		// Token: 0x0400422D RID: 16941
		private ITargetBattleAttribute Instance;
	}
}
