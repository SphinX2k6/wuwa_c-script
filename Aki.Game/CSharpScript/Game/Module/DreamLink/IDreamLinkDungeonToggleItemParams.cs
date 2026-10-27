using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005A99 RID: 23193
	[NullableContext(1)]
	public interface IDreamLinkDungeonToggleItemParams
	{
		// Token: 0x17008C06 RID: 35846
		// (get) Token: 0x0603AC14 RID: 240660
		// (set) Token: 0x0603AC15 RID: 240661
		string TextureBgPath { get; set; }

		// Token: 0x17008C07 RID: 35847
		// (get) Token: 0x0603AC16 RID: 240662
		// (set) Token: 0x0603AC17 RID: 240663
		string TextureLightPath { get; set; }

		// Token: 0x17008C08 RID: 35848
		// (get) Token: 0x0603AC18 RID: 240664
		// (set) Token: 0x0603AC19 RID: 240665
		string EffectColor { get; set; }
	}
}
