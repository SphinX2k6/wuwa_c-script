using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E53 RID: 3667
	public class IGroupAiMonsterMemberActionTagAttach
	{
		// Token: 0x060052FB RID: 21243 RVA: 0x000CCF8E File Offset: 0x000CB18E
		public static IGroupAiMonsterMemberActionTagAttach Create(IGroupAiMonsterMemberActionTagAttach? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiMonsterMemberActionTagAttach
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x060052FC RID: 21244 RVA: 0x000CCFAD File Offset: 0x000CB1AD
		public virtual string ActionTag
		{
			get
			{
				return this.Instance.ActionTag;
			}
		}

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x060052FD RID: 21245 RVA: 0x000CCFBC File Offset: 0x000CB1BC
		public virtual int? AttachEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.AttachEntityId);
			}
		}

		// Token: 0x04002F60 RID: 12128
		private IGroupAiMonsterMemberActionTagAttach Instance;
	}
}
