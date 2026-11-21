using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014B7 RID: 5303
	public class IUseSkillCheckByVisionShowId : IUseSkillCheckBase
	{
		// Token: 0x06007847 RID: 30791 RVA: 0x0012016D File Offset: 0x0011E36D
		public static IUseSkillCheckByVisionShowId Create(IUseSkillCheckByVisionShowId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseSkillCheckByVisionShowId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700267B RID: 9851
		// (get) Token: 0x06007848 RID: 30792 RVA: 0x0012018C File Offset: 0x0011E38C
		public override EUseSkillCheckType Type
		{
			get
			{
				return (EUseSkillCheckType)this.Instance.Type;
			}
		}

		// Token: 0x1700267C RID: 9852
		// (get) Token: 0x06007849 RID: 30793 RVA: 0x00120199 File Offset: 0x0011E399
		public virtual int VisionId
		{
			get
			{
				return this.Instance.VisionId;
			}
		}

		// Token: 0x04004523 RID: 17699
		private IUseSkillCheckByVisionShowId Instance;
	}
}
