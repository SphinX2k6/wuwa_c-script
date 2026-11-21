using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014B8 RID: 5304
	public class IUseSkillCheckByFollowShooterSkillId : IUseSkillCheckBase
	{
		// Token: 0x0600784B RID: 30795 RVA: 0x001201AE File Offset: 0x0011E3AE
		public static IUseSkillCheckByFollowShooterSkillId Create(IUseSkillCheckByFollowShooterSkillId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseSkillCheckByFollowShooterSkillId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700267D RID: 9853
		// (get) Token: 0x0600784C RID: 30796 RVA: 0x001201CD File Offset: 0x0011E3CD
		public override EUseSkillCheckType Type
		{
			get
			{
				return (EUseSkillCheckType)this.Instance.Type;
			}
		}

		// Token: 0x1700267E RID: 9854
		// (get) Token: 0x0600784D RID: 30797 RVA: 0x001201DA File Offset: 0x0011E3DA
		public virtual int SkillId
		{
			get
			{
				return this.Instance.SkillId;
			}
		}

		// Token: 0x04004524 RID: 17700
		private IUseSkillCheckByFollowShooterSkillId Instance;
	}
}
