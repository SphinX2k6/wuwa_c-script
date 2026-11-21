using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02005F83 RID: 24451
	[NullableContext(2)]
	public interface IGuaranteeActionComparer
	{
		// Token: 0x0603ACA0 RID: 240800
		bool IsSameAction(ActionParams left, ActionParams right);
	}
}
