using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200283D RID: 10301
	public class ISunSpiritDifficultyReduction
	{
		// Token: 0x0600E460 RID: 58464 RVA: 0x00219DA3 File Offset: 0x00217FA3
		[NullableContext(1)]
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

		// Token: 0x170045A8 RID: 17832
		// (get) Token: 0x0600E461 RID: 58465 RVA: 0x00219DC2 File Offset: 0x00217FC2
		public virtual int LoseTimes
		{
			get
			{
				return this.Instance.LoseTimes;
			}
		}

		// Token: 0x170045A9 RID: 17833
		// (get) Token: 0x0600E462 RID: 58466 RVA: 0x00219DCF File Offset: 0x00217FCF
		public virtual int SubstituteId
		{
			get
			{
				return this.Instance.SubstituteId;
			}
		}

		// Token: 0x04007E59 RID: 32345
		private ISunSpiritDifficultyReduction Instance;
	}
}
