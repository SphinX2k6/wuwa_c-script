using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x020054B5 RID: 21685
	public interface IPieceComponent
	{
		// Token: 0x17006892 RID: 26770
		// (get) Token: 0x06035BE9 RID: 220137 RVA: 0x00F03D1C File Offset: 0x00F01F1C
		EPieceCaps Caps
		{
			get
			{
				return EPieceCaps.None;
			}
		}

		// Token: 0x06035BEA RID: 220138 RVA: 0x00F03D1F File Offset: 0x00F01F1F
		void OnAttach(ref PieceComponentState state)
		{
		}
	}
}
