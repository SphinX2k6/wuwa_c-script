using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053A6 RID: 21414
	[NullableContext(1)]
	public interface IMoraleBuffAddItemData
	{
		// Token: 0x170083AC RID: 33708
		// (get) Token: 0x06036B91 RID: 224145
		string IconPath { get; }

		// Token: 0x170083AD RID: 33709
		// (get) Token: 0x06036B92 RID: 224146
		string NameKey { get; }

		// Token: 0x170083AE RID: 33710
		// (get) Token: 0x06036B93 RID: 224147
		string Value { get; }
	}
}
