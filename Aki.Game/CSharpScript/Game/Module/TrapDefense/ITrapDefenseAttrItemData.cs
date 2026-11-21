using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A63 RID: 14947
	[NullableContext(2)]
	public interface ITrapDefenseAttrItemData
	{
		// Token: 0x17004E8F RID: 20111
		// (get) Token: 0x060266A4 RID: 157348
		string IconPath { get; }

		// Token: 0x17004E90 RID: 20112
		// (get) Token: 0x060266A5 RID: 157349
		[Nullable(1)]
		string NameKey { [NullableContext(1)] get; }

		// Token: 0x17004E91 RID: 20113
		// (get) Token: 0x060266A6 RID: 157350
		string Value { get; }
	}
}
