using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004697 RID: 18071
	[NullableContext(1)]
	public interface IUiProhibitRefreshData
	{
		// Token: 0x0602E9BE RID: 190910
		bool CheckCondition();

		// Token: 0x0602E9BF RID: 190911
		string[] GetDistributeTags();
	}
}
