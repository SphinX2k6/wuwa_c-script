using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EEC RID: 3820
	public class IQuickHackSkill
	{
		// Token: 0x060055FC RID: 22012 RVA: 0x000D323D File Offset: 0x000D143D
		public static IQuickHackSkill Create(IQuickHackSkill? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuickHackSkill
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x060055FD RID: 22013 RVA: 0x000D325C File Offset: 0x000D145C
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x060055FE RID: 22014 RVA: 0x000D326C File Offset: 0x000D146C
		public virtual List<IQuickHackSkillContent> Content
		{
			get
			{
				if (this._ContentInited)
				{
					return this._ContentCache;
				}
				this._ContentInited = true;
				int contentLength = this.Instance.ContentLength;
				this._ContentCache = new List<IQuickHackSkillContent>(contentLength);
				for (int i = 0; i < contentLength; i++)
				{
					this._ContentCache.Add(IQuickHackSkillContent.Create(this.Instance.Content(i)));
				}
				return this._ContentCache;
			}
		}

		// Token: 0x0400313D RID: 12605
		private IQuickHackSkill Instance;

		// Token: 0x0400313E RID: 12606
		private List<IQuickHackSkillContent> _ContentCache;

		// Token: 0x0400313F RID: 12607
		private bool _ContentInited;
	}
}
