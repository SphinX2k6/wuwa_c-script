using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002714 RID: 10004
	public class ClientUnlockAchievementSystemItem : ActionParams
	{
		// Token: 0x0600DF28 RID: 57128 RVA: 0x0021126D File Offset: 0x0020F46D
		[NullableContext(1)]
		public static ClientUnlockAchievementSystemItem Create(IClientUnlockAchievementSystemItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientUnlockAchievementSystemItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042C2 RID: 17090
		// (get) Token: 0x0600DF29 RID: 57129 RVA: 0x0021128C File Offset: 0x0020F48C
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04007BD6 RID: 31702
		private IClientUnlockAchievementSystemItem Instance;
	}
}
