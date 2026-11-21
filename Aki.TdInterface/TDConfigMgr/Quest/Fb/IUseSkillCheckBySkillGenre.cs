using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014B4 RID: 5300
	public class IUseSkillCheckBySkillGenre : IUseSkillCheckBase
	{
		// Token: 0x0600783B RID: 30779 RVA: 0x001200AA File Offset: 0x0011E2AA
		public static IUseSkillCheckBySkillGenre Create(IUseSkillCheckBySkillGenre? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseSkillCheckBySkillGenre
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002675 RID: 9845
		// (get) Token: 0x0600783C RID: 30780 RVA: 0x001200C9 File Offset: 0x0011E2C9
		public override EUseSkillCheckType Type
		{
			get
			{
				return (EUseSkillCheckType)this.Instance.Type;
			}
		}

		// Token: 0x17002676 RID: 9846
		// (get) Token: 0x0600783D RID: 30781 RVA: 0x001200D6 File Offset: 0x0011E2D6
		public virtual ESkillCategory SkillGenre
		{
			get
			{
				return (ESkillCategory)this.Instance.SkillGenre;
			}
		}

		// Token: 0x04004520 RID: 17696
		private IUseSkillCheckBySkillGenre Instance;
	}
}
