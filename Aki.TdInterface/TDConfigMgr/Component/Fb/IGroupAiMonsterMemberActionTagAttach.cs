using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D59 RID: 3417
	[NullableContext(1)]
	[Nullable(0)]
	public class IGroupAiMonsterMemberActionTagAttach
	{
		// Token: 0x06004DDF RID: 19935 RVA: 0x000C184A File Offset: 0x000BFA4A
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

		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x06004DE0 RID: 19936 RVA: 0x000C1869 File Offset: 0x000BFA69
		public virtual string ActionTag
		{
			get
			{
				return this.Instance.ActionTag;
			}
		}

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x06004DE1 RID: 19937 RVA: 0x000C1878 File Offset: 0x000BFA78
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

		// Token: 0x04002CA0 RID: 11424
		private IGroupAiMonsterMemberActionTagAttach Instance;
	}
}
