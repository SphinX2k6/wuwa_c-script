using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x0200551D RID: 21789
	public class PlayerMarkItemView : MarkItemView
	{
		// Token: 0x06037A56 RID: 227926 RVA: 0x00D35817 File Offset: 0x00D33A17
		[NullableContext(1)]
		public PlayerMarkItemView(PlayerMarkItem holder) : base(holder)
		{
		}

		// Token: 0x06037A57 RID: 227927 RVA: 0x00D35820 File Offset: 0x00D33A20
		public override bool GetInteractiveFlag()
		{
			return false;
		}
	}
}
