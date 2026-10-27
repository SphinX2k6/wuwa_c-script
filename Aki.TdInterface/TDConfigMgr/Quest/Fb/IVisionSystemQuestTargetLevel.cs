using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013BD RID: 5053
	public class IVisionSystemQuestTargetLevel : IVisionSystemQuestBase
	{
		// Token: 0x0600736A RID: 29546 RVA: 0x00115099 File Offset: 0x00113299
		[NullableContext(1)]
		public static IVisionSystemQuestTargetLevel Create(IVisionSystemQuestTargetLevel? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisionSystemQuestTargetLevel
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025C3 RID: 9667
		// (get) Token: 0x0600736B RID: 29547 RVA: 0x001150B8 File Offset: 0x001132B8
		public override EVisionSystemQuestType Type
		{
			get
			{
				return (EVisionSystemQuestType)this.Instance.Type;
			}
		}

		// Token: 0x170025C4 RID: 9668
		// (get) Token: 0x0600736C RID: 29548 RVA: 0x001150C5 File Offset: 0x001132C5
		public virtual int TargetLevel
		{
			get
			{
				return this.Instance.TargetLevel;
			}
		}

		// Token: 0x040042CD RID: 17101
		private IVisionSystemQuestTargetLevel Instance;
	}
}
