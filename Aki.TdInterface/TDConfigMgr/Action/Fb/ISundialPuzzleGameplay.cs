using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B2D RID: 11053
	public class ISundialPuzzleGameplay : IUiGame
	{
		// Token: 0x0600F324 RID: 62244 RVA: 0x00237EF0 File Offset: 0x002360F0
		public static ISundialPuzzleGameplay Create(ISundialPuzzleGameplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISundialPuzzleGameplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004978 RID: 18808
		// (get) Token: 0x0600F325 RID: 62245 RVA: 0x00237F0F File Offset: 0x0023610F
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x0400856B RID: 34155
		private ISundialPuzzleGameplay Instance;
	}
}
