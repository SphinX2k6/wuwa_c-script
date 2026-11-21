using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200616D RID: 24941
	[NullableContext(1)]
	internal interface IInputAxisData
	{
		// Token: 0x170070D3 RID: 28883
		// (get) Token: 0x0603BCD6 RID: 244950
		// (set) Token: 0x0603BCD7 RID: 244951
		string KeyName { get; set; }

		// Token: 0x170070D4 RID: 28884
		// (get) Token: 0x0603BCD8 RID: 244952
		// (set) Token: 0x0603BCD9 RID: 244953
		float Scale { get; set; }
	}
}
