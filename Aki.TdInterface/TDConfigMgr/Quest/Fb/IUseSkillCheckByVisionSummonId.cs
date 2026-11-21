using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014B6 RID: 5302
	public class IUseSkillCheckByVisionSummonId : IUseSkillCheckBase
	{
		// Token: 0x06007843 RID: 30787 RVA: 0x0012012C File Offset: 0x0011E32C
		public static IUseSkillCheckByVisionSummonId Create(IUseSkillCheckByVisionSummonId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseSkillCheckByVisionSummonId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002679 RID: 9849
		// (get) Token: 0x06007844 RID: 30788 RVA: 0x0012014B File Offset: 0x0011E34B
		public override EUseSkillCheckType Type
		{
			get
			{
				return (EUseSkillCheckType)this.Instance.Type;
			}
		}

		// Token: 0x1700267A RID: 9850
		// (get) Token: 0x06007845 RID: 30789 RVA: 0x00120158 File Offset: 0x0011E358
		public virtual int VisionId
		{
			get
			{
				return this.Instance.VisionId;
			}
		}

		// Token: 0x04004522 RID: 17698
		private IUseSkillCheckByVisionSummonId Instance;
	}
}
