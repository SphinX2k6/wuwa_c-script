using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.SmallItemGrid
{
	// Token: 0x02004B29 RID: 19241
	public class SmallItemGridWeaponFlagComponent : SmallItemGridVisibleComponent
	{
		// Token: 0x06030203 RID: 197123 RVA: 0x00D6C0CD File Offset: 0x00D6A2CD
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemRoleDevEquipped";
		}

		// Token: 0x06030204 RID: 197124 RVA: 0x00D6C0D4 File Offset: 0x00D6A2D4
		public override EItemGridComponentLayoutLevel GetLayoutLevel()
		{
			return EItemGridComponentLayoutLevel.Bottom;
		}
	}
}
