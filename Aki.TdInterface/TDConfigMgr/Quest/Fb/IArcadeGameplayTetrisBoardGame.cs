using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001473 RID: 5235
	public class IArcadeGameplayTetrisBoardGame : IArcadeGameplayBase
	{
		// Token: 0x06007716 RID: 30486 RVA: 0x0011C9B4 File Offset: 0x0011ABB4
		[NullableContext(1)]
		public static IArcadeGameplayTetrisBoardGame Create(IArcadeGameplayTetrisBoardGame? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IArcadeGameplayTetrisBoardGame
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002803 RID: 10243
		// (get) Token: 0x06007717 RID: 30487 RVA: 0x0011C9D3 File Offset: 0x0011ABD3
		public override EArcadeGameplayType Type
		{
			get
			{
				return (EArcadeGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17002804 RID: 10244
		// (get) Token: 0x06007718 RID: 30488 RVA: 0x0011C9E0 File Offset: 0x0011ABE0
		public virtual int LevelId
		{
			get
			{
				return this.Instance.LevelId;
			}
		}

		// Token: 0x04004541 RID: 17729
		private IArcadeGameplayTetrisBoardGame Instance;
	}
}
