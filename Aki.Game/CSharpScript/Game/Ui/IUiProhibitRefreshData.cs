using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035C8 RID: 13768
	[NullableContext(1)]
	public interface IUiProhibitRefreshData
	{
		// Token: 0x0602310A RID: 143626
		bool CheckCondition();

		// Token: 0x0602310B RID: 143627
		string[] GetDistributeTags();
	}
}
