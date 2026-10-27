using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x02005238 RID: 21048
	[NullableContext(1)]
	public interface IPhantomArenaBattleDetailsTipsData
	{
		// Token: 0x17008235 RID: 33333
		// (get) Token: 0x06035C54 RID: 220244
		// (set) Token: 0x06035C55 RID: 220245
		UUIItem AttachItem { get; set; }

		// Token: 0x17008236 RID: 33334
		// (get) Token: 0x06035C56 RID: 220246
		// (set) Token: 0x06035C57 RID: 220247
		UUIItem TriggerItem { get; set; }

		// Token: 0x17008237 RID: 33335
		// (get) Token: 0x06035C58 RID: 220248
		// (set) Token: 0x06035C59 RID: 220249
		EPhantomArenaBattleDetailsPositionType PositionType { get; set; }

		// Token: 0x17008238 RID: 33336
		// (get) Token: 0x06035C5A RID: 220250
		// (set) Token: 0x06035C5B RID: 220251
		EPhantomArenaBattleDetailsTipsShowType ShowType { get; set; }
	}
}
