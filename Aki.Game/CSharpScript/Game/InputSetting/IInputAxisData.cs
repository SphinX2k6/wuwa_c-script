using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006FEC RID: 28652
	[NullableContext(1)]
	internal interface IInputAxisData
	{
		// Token: 0x17009B93 RID: 39827
		// (get) Token: 0x06045B25 RID: 285477
		// (set) Token: 0x06045B26 RID: 285478
		string KeyName { get; set; }

		// Token: 0x17009B94 RID: 39828
		// (get) Token: 0x06045B27 RID: 285479
		// (set) Token: 0x06045B28 RID: 285480
		float Scale { get; set; }
	}
}
