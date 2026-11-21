using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B5B RID: 2907
	public class IStateRepPerfSkillId : IStateRepPerfBase
	{
		// Token: 0x06004263 RID: 16995 RVA: 0x000A8B7A File Offset: 0x000A6D7A
		public static IStateRepPerfSkillId Create(IStateRepPerfSkillId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateRepPerfSkillId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06004264 RID: 16996 RVA: 0x000A8B99 File Offset: 0x000A6D99
		public override EStateRepPerfType Type
		{
			get
			{
				return (EStateRepPerfType)this.Instance.Type;
			}
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06004265 RID: 16997 RVA: 0x000A8BA6 File Offset: 0x000A6DA6
		public virtual long SkillId
		{
			get
			{
				return this.Instance.SkillId;
			}
		}

		// Token: 0x040024C6 RID: 9414
		private IStateRepPerfSkillId Instance;
	}
}
