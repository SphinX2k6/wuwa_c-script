using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004538 RID: 17720
	[NullableContext(1)]
	public interface IBoxMark
	{
		// Token: 0x0602CAB7 RID: 182967
		string GetTitleText();

		// Token: 0x0602CAB8 RID: 182968
		string GetDescText();

		// Token: 0x17005996 RID: 22934
		// (get) Token: 0x0602CAB9 RID: 182969
		string IconPath { get; }
	}
}
