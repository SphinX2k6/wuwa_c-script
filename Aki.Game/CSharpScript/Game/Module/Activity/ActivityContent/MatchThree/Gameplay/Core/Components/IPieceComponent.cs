using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x02006537 RID: 25911
	public interface IPieceComponent
	{
		// Token: 0x17009530 RID: 38192
		// (get) Token: 0x06040F24 RID: 266020 RVA: 0x00FBCCD8 File Offset: 0x00FBAED8
		EPieceCaps Caps
		{
			get
			{
				return EPieceCaps.None;
			}
		}

		// Token: 0x06040F25 RID: 266021 RVA: 0x00FBCCDB File Offset: 0x00FBAEDB
		void OnAttach(ref PieceComponentState state)
		{
		}
	}
}
