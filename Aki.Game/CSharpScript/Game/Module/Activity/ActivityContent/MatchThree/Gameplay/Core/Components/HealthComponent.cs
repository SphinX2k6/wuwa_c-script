using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x02006533 RID: 25907
	public sealed class HealthComponent : IPieceComponent
	{
		// Token: 0x06040F1A RID: 266010 RVA: 0x00FBCC20 File Offset: 0x00FBAE20
		public HealthComponent(int count)
		{
		}

		// Token: 0x1700952D RID: 38189
		// (get) Token: 0x06040F1B RID: 266011 RVA: 0x00FBCC2F File Offset: 0x00FBAE2F
		public EPieceCaps Caps
		{
			get
			{
				return EPieceCaps.Health;
			}
		}

		// Token: 0x06040F1C RID: 266012 RVA: 0x00FBCC36 File Offset: 0x00FBAE36
		public void OnAttach(ref PieceComponentState state)
		{
			state.Val1 = this.<count>P;
		}

		// Token: 0x04021DFE RID: 138750
		[CompilerGenerated]
		private int <count>P = count;
	}
}
