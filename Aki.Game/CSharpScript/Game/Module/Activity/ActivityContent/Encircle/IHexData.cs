using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02006658 RID: 26200
	[NullableContext(1)]
	public interface IHexData
	{
		// Token: 0x17009622 RID: 38434
		// (get) Token: 0x06041AB9 RID: 268985
		// (set) Token: 0x06041ABA RID: 268986
		IHexPos HexPos { get; set; }

		// Token: 0x17009623 RID: 38435
		// (get) Token: 0x06041ABB RID: 268987
		// (set) Token: 0x06041ABC RID: 268988
		EncircleHexType Type { get; set; }

		// Token: 0x17009624 RID: 38436
		// (get) Token: 0x06041ABD RID: 268989
		// (set) Token: 0x06041ABE RID: 268990
		int MapId { get; set; }
	}
}
