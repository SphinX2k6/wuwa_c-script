using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002710 RID: 10000
	public class IUnlockAchievementSystemItem : IUnlockSystemItemType
	{
		// Token: 0x0600DF19 RID: 57113 RVA: 0x00211154 File Offset: 0x0020F354
		[NullableContext(1)]
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

		// Token: 0x170042BB RID: 17083
		// (get) Token: 0x0600DF1A RID: 57114 RVA: 0x00211173 File Offset: 0x0020F373
		public override EUnlockSystemItemType Type
		{
			get
			{
				return (EUnlockSystemItemType)this.Instance.Type;
			}
		}

		// Token: 0x170042BC RID: 17084
		// (get) Token: 0x0600DF1B RID: 57115 RVA: 0x00211180 File Offset: 0x0020F380
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04007BD0 RID: 31696
		private IUnlockAchievementSystemItem Instance;
	}
}
