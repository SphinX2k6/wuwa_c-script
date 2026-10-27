using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004ABB RID: 19131
	[NullableContext(2)]
	public interface ITrapDefenseAttrItemData
	{
		// Token: 0x17007AE2 RID: 31458
		// (get) Token: 0x06031914 RID: 203028
		string IconPath { get; }

		// Token: 0x17007AE3 RID: 31459
		// (get) Token: 0x06031915 RID: 203029
		[Nullable(1)]
		string NameKey { [NullableContext(1)] get; }

		// Token: 0x17007AE4 RID: 31460
		// (get) Token: 0x06031916 RID: 203030
		string Value { get; }
	}
}
