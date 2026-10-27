using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001389 RID: 5001
	public class IEnterDungeonIdCondition : IEnterDungeon
	{
		// Token: 0x0600726B RID: 29291 RVA: 0x00113350 File Offset: 0x00111550
		[NullableContext(1)]
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

		// Token: 0x1700252C RID: 9516
		// (get) Token: 0x0600726C RID: 29292 RVA: 0x0011336F File Offset: 0x0011156F
		public override EDungeonConditionType Type
		{
			get
			{
				return (EDungeonConditionType)this.Instance.Type;
			}
		}

		// Token: 0x1700252D RID: 9517
		// (get) Token: 0x0600726D RID: 29293 RVA: 0x0011337C File Offset: 0x0011157C
		public virtual int DungeonId
		{
			get
			{
				return this.Instance.DungeonId;
			}
		}

		// Token: 0x04004221 RID: 16929
		private IEnterDungeonIdCondition Instance;
	}
}
