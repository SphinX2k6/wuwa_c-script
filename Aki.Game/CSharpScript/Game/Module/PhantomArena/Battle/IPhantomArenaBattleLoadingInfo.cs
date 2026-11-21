using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x0200420D RID: 16909
	[NullableContext(1)]
	public interface IPhantomArenaBattleLoadingInfo
	{
		// Token: 0x1700560D RID: 22029
		// (get) Token: 0x0602AB82 RID: 174978
		// (set) Token: 0x0602AB83 RID: 174979
		int Index { get; set; }

		// Token: 0x1700560E RID: 22030
		// (get) Token: 0x0602AB84 RID: 174980
		// (set) Token: 0x0602AB85 RID: 174981
		bool IsMe { get; set; }

		// Token: 0x1700560F RID: 22031
		// (get) Token: 0x0602AB86 RID: 174982
		// (set) Token: 0x0602AB87 RID: 174983
		PhantomCardData CardData { get; set; }
	}
}
