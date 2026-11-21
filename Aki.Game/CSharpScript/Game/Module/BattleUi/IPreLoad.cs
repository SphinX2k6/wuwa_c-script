using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C7D RID: 19581
	[NullableContext(1)]
	public interface IPreLoad
	{
		// Token: 0x170061BF RID: 25023
		// (get) Token: 0x06030DAC RID: 200108
		string ResourceId { get; }

		// Token: 0x170061C0 RID: 25024
		// (get) Token: 0x06030DAD RID: 200109
		int PreloadCount { get; }
	}
}
