using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x02004208 RID: 16904
	[NullableContext(1)]
	public interface IPhantomArenaBattleDetailsTipsData
	{
		// Token: 0x170055F5 RID: 22005
		// (get) Token: 0x0602AB4F RID: 174927
		// (set) Token: 0x0602AB50 RID: 174928
		UUIItem AttachItem { get; set; }

		// Token: 0x170055F6 RID: 22006
		// (get) Token: 0x0602AB51 RID: 174929
		// (set) Token: 0x0602AB52 RID: 174930
		UUIItem TriggerItem { get; set; }

		// Token: 0x170055F7 RID: 22007
		// (get) Token: 0x0602AB53 RID: 174931
		// (set) Token: 0x0602AB54 RID: 174932
		EPhantomArenaBattleDetailsPositionType PositionType { get; set; }

		// Token: 0x170055F8 RID: 22008
		// (get) Token: 0x0602AB55 RID: 174933
		// (set) Token: 0x0602AB56 RID: 174934
		EPhantomArenaBattleDetailsTipsShowType ShowType { get; set; }
	}
}
