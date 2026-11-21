using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014B5 RID: 5301
	public class IUseSkillCheckBySkillId : IUseSkillCheckBase
	{
		// Token: 0x0600783F RID: 30783 RVA: 0x001200EB File Offset: 0x0011E2EB
		public static IUseSkillCheckBySkillId Create(IUseSkillCheckBySkillId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseSkillCheckBySkillId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002677 RID: 9847
		// (get) Token: 0x06007840 RID: 30784 RVA: 0x0012010A File Offset: 0x0011E30A
		public override EUseSkillCheckType Type
		{
			get
			{
				return (EUseSkillCheckType)this.Instance.Type;
			}
		}

		// Token: 0x17002678 RID: 9848
		// (get) Token: 0x06007841 RID: 30785 RVA: 0x00120117 File Offset: 0x0011E317
		public virtual int SkillId
		{
			get
			{
				return this.Instance.SkillId;
			}
		}

		// Token: 0x04004521 RID: 17697
		private IUseSkillCheckBySkillId Instance;
	}
}
