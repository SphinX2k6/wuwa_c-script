using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200283A RID: 10298
	public class IVisualNovelRoleIntroductionSolarSchool : IVisualNovelRoleIntroductionConfigBase
	{
		// Token: 0x0600E52C RID: 58668 RVA: 0x0021DB1E File Offset: 0x0021BD1E
		public static IVisualNovelRoleIntroductionSolarSchool Create(IVisualNovelRoleIntroductionSolarSchool? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelRoleIntroductionSolarSchool
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004166 RID: 16742
		// (get) Token: 0x0600E52D RID: 58669 RVA: 0x0021DB3D File Offset: 0x0021BD3D
		public override EVisualNovelSubType Type
		{
			get
			{
				return (EVisualNovelSubType)this.Instance.Type;
			}
		}

		// Token: 0x17004167 RID: 16743
		// (get) Token: 0x0600E52E RID: 58670 RVA: 0x0021DB4A File Offset: 0x0021BD4A
		public virtual int IntroductionId
		{
			get
			{
				return this.Instance.IntroductionId;
			}
		}

		// Token: 0x17004168 RID: 16744
		// (get) Token: 0x0600E52F RID: 58671 RVA: 0x0021DB58 File Offset: 0x0021BD58
		public virtual float? Duration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Duration);
			}
		}

		// Token: 0x04007DBE RID: 32190
		private IVisualNovelRoleIntroductionSolarSchool Instance;
	}
}
