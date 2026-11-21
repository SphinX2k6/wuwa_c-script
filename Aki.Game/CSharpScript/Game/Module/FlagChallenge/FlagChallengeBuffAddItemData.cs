using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A13 RID: 18963
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeBuffAddItemData : IFlagChallengeBuffAddItemData
	{
		// Token: 0x17005FB5 RID: 24501
		// (get) Token: 0x0602F8AE RID: 194734 RVA: 0x00D41865 File Offset: 0x00D3FA65
		// (set) Token: 0x0602F8AF RID: 194735 RVA: 0x00D4186D File Offset: 0x00D3FA6D
		public string IconPath { get; set; }

		// Token: 0x17005FB6 RID: 24502
		// (get) Token: 0x0602F8B0 RID: 194736 RVA: 0x00D41876 File Offset: 0x00D3FA76
		// (set) Token: 0x0602F8B1 RID: 194737 RVA: 0x00D4187E File Offset: 0x00D3FA7E
		public string NameKey { get; set; }

		// Token: 0x17005FB7 RID: 24503
		// (get) Token: 0x0602F8B2 RID: 194738 RVA: 0x00D41887 File Offset: 0x00D3FA87
		// (set) Token: 0x0602F8B3 RID: 194739 RVA: 0x00D4188F File Offset: 0x00D3FA8F
		public string Value { get; set; }
	}
}
