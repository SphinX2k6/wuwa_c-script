using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014DB RID: 5339
	public class IEnterDungeonSubTypeCondition : IEnterDungeon
	{
		// Token: 0x06007915 RID: 30997 RVA: 0x00121A15 File Offset: 0x0011FC15
		public static IEnterDungeonSubTypeCondition Create(IEnterDungeonSubTypeCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterDungeonSubTypeCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002701 RID: 9985
		// (get) Token: 0x06007916 RID: 30998 RVA: 0x00121A34 File Offset: 0x0011FC34
		public override EDungeonConditionType Type
		{
			get
			{
				return (EDungeonConditionType)this.Instance.Type;
			}
		}

		// Token: 0x17002702 RID: 9986
		// (get) Token: 0x06007917 RID: 30999 RVA: 0x00121A41 File Offset: 0x0011FC41
		public virtual EDungeonSubType DungeonSubType
		{
			get
			{
				return (EDungeonSubType)this.Instance.DungeonSubType;
			}
		}

		// Token: 0x040045A3 RID: 17827
		private IEnterDungeonSubTypeCondition Instance;
	}
}
