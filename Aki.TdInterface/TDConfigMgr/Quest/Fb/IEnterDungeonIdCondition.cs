using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014DA RID: 5338
	public class IEnterDungeonIdCondition : IEnterDungeon
	{
		// Token: 0x06007911 RID: 30993 RVA: 0x001219D4 File Offset: 0x0011FBD4
		public static IEnterDungeonIdCondition Create(IEnterDungeonIdCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterDungeonIdCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170026FF RID: 9983
		// (get) Token: 0x06007912 RID: 30994 RVA: 0x001219F3 File Offset: 0x0011FBF3
		public override EDungeonConditionType Type
		{
			get
			{
				return (EDungeonConditionType)this.Instance.Type;
			}
		}

		// Token: 0x17002700 RID: 9984
		// (get) Token: 0x06007913 RID: 30995 RVA: 0x00121A00 File Offset: 0x0011FC00
		public virtual int DungeonId
		{
			get
			{
				return this.Instance.DungeonId;
			}
		}

		// Token: 0x040045A2 RID: 17826
		private IEnterDungeonIdCondition Instance;
	}
}
