using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A0E RID: 14862
	[NullableContext(1)]
	public interface ITrapDefenseLevelTargetInfo
	{
		// Token: 0x17004E4F RID: 20047
		// (get) Token: 0x060263CB RID: 156619
		ETrapDefenseLevelTarget TargetType { get; }

		// Token: 0x17004E50 RID: 20048
		// (get) Token: 0x060263CC RID: 156620
		string NameKey { get; }

		// Token: 0x17004E51 RID: 20049
		// (get) Token: 0x060263CD RID: 156621
		string IconKey { get; }
	}
}
