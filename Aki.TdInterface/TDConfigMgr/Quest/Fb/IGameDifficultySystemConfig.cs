using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001425 RID: 5157
	public class IGameDifficultySystemConfig : IEnableSystemConfig
	{
		// Token: 0x060074E3 RID: 29923 RVA: 0x00118FA5 File Offset: 0x001171A5
		public static IGameDifficultySystemConfig Create(IGameDifficultySystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGameDifficultySystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700243B RID: 9275
		// (get) Token: 0x060074E4 RID: 29924 RVA: 0x00118FC4 File Offset: 0x001171C4
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x040042AB RID: 17067
		private IGameDifficultySystemConfig Instance;
	}
}
