using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B10 RID: 11024
	public class ISunSpiritDifficultyReduction
	{
		// Token: 0x0600F285 RID: 62085 RVA: 0x00236C07 File Offset: 0x00234E07
		public static ISunSpiritDifficultyReduction Create(ISunSpiritDifficultyReduction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunSpiritDifficultyReduction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004913 RID: 18707
		// (get) Token: 0x0600F286 RID: 62086 RVA: 0x00236C26 File Offset: 0x00234E26
		public virtual int LoseTimes
		{
			get
			{
				return this.Instance.LoseTimes;
			}
		}

		// Token: 0x17004914 RID: 18708
		// (get) Token: 0x0600F287 RID: 62087 RVA: 0x00236C33 File Offset: 0x00234E33
		public virtual int SubstituteId
		{
			get
			{
				return this.Instance.SubstituteId;
			}
		}

		// Token: 0x04008516 RID: 34070
		private ISunSpiritDifficultyReduction Instance;
	}
}
