using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200276E RID: 10094
	public class IQuestActionContext : IActionContextType
	{
		// Token: 0x0600DFBA RID: 57274 RVA: 0x0020F0FE File Offset: 0x0020D2FE
		public static IQuestActionContext Create(IQuestActionContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestActionContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003D8C RID: 15756
		// (get) Token: 0x0600DFBB RID: 57275 RVA: 0x0020F11D File Offset: 0x0020D31D
		public new virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x17003D8D RID: 15757
		// (get) Token: 0x0600DFBC RID: 57276 RVA: 0x0020F12C File Offset: 0x0020D32C
		public virtual bool? IsChildQuestOfDungeon
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsChildQuestOfDungeon);
			}
		}

		// Token: 0x040079BE RID: 31166
		private IQuestActionContext Instance;
	}
}
