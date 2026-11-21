using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001513 RID: 5395
	public class IVisionSystemQuestTargetLevel : IVisionSystemQuestBase
	{
		// Token: 0x06007A24 RID: 31268 RVA: 0x00123901 File Offset: 0x00121B01
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

		// Token: 0x170027A0 RID: 10144
		// (get) Token: 0x06007A25 RID: 31269 RVA: 0x00123920 File Offset: 0x00121B20
		public override EVisionSystemQuestType Type
		{
			get
			{
				return (EVisionSystemQuestType)this.Instance.Type;
			}
		}

		// Token: 0x170027A1 RID: 10145
		// (get) Token: 0x06007A26 RID: 31270 RVA: 0x0012392D File Offset: 0x00121B2D
		public virtual int TargetLevel
		{
			get
			{
				return this.Instance.TargetLevel;
			}
		}

		// Token: 0x04004657 RID: 18007
		private IVisionSystemQuestTargetLevel Instance;
	}
}
