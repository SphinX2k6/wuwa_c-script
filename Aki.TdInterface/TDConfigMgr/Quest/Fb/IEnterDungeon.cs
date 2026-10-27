using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001388 RID: 5000
	public class IEnterDungeon
	{
		// Token: 0x06007268 RID: 29288 RVA: 0x0011331C File Offset: 0x0011151C
		[NullableContext(1)]
		public static IEnterDungeon Create(IEnterDungeon? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterDungeon
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700252B RID: 9515
		// (get) Token: 0x06007269 RID: 29289 RVA: 0x0011333B File Offset: 0x0011153B
		public virtual EDungeonConditionType Type
		{
			get
			{
				return (EDungeonConditionType)this.Instance.Type;
			}
		}

		// Token: 0x04004220 RID: 16928
		private IEnterDungeon Instance;
	}
}
