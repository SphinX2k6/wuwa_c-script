using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DF0 RID: 3568
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuickHackSkill
	{
		// Token: 0x060050D5 RID: 20693 RVA: 0x000C7975 File Offset: 0x000C5B75
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

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x060050D6 RID: 20694 RVA: 0x000C7994 File Offset: 0x000C5B94
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x060050D7 RID: 20695 RVA: 0x000C79A4 File Offset: 0x000C5BA4
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

		// Token: 0x04002E75 RID: 11893
		private IQuickHackSkill Instance;

		// Token: 0x04002E76 RID: 11894
		private List<IQuickHackSkillContent> _ContentCache;

		// Token: 0x04002E77 RID: 11895
		private bool _ContentInited;
	}
}
