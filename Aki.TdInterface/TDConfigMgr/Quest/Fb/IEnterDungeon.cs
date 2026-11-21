using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014D9 RID: 5337
	public class IEnterDungeon
	{
		// Token: 0x0600790E RID: 30990 RVA: 0x001219A0 File Offset: 0x0011FBA0
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

		// Token: 0x170026FE RID: 9982
		// (get) Token: 0x0600790F RID: 30991 RVA: 0x001219BF File Offset: 0x0011FBBF
		public virtual EDungeonConditionType Type
		{
			get
			{
				return (EDungeonConditionType)this.Instance.Type;
			}
		}

		// Token: 0x040045A1 RID: 17825
		private IEnterDungeon Instance;
	}
}
