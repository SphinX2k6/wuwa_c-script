using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029D7 RID: 10711
	public class IUnlockAchievementSystemItem : IUnlockSystemItemType
	{
		// Token: 0x0600ED05 RID: 60677 RVA: 0x0022DAFC File Offset: 0x0022BCFC
		public static IUnlockAchievementSystemItem Create(IUnlockAchievementSystemItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnlockAchievementSystemItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004605 RID: 17925
		// (get) Token: 0x0600ED06 RID: 60678 RVA: 0x0022DB1B File Offset: 0x0022BD1B
		public override EUnlockSystemItemType Type
		{
			get
			{
				return (EUnlockSystemItemType)this.Instance.Type;
			}
		}

		// Token: 0x17004606 RID: 17926
		// (get) Token: 0x0600ED07 RID: 60679 RVA: 0x0022DB28 File Offset: 0x0022BD28
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04008275 RID: 33397
		private IUnlockAchievementSystemItem Instance;
	}
}
