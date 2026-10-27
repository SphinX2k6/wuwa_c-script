using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.PopupItemDetail
{
	// Token: 0x02005739 RID: 22329
	[NullableContext(1)]
	public interface IInfoItemData
	{
		// Token: 0x17008864 RID: 34916
		// (get) Token: 0x06038C4C RID: 232524
		// (set) Token: 0x06038C4D RID: 232525
		int Level { get; set; }

		// Token: 0x17008865 RID: 34917
		// (get) Token: 0x06038C4E RID: 232526
		// (set) Token: 0x06038C4F RID: 232527
		string Description { get; set; }

		// Token: 0x17008866 RID: 34918
		// (get) Token: 0x06038C50 RID: 232528
		// (set) Token: 0x06038C51 RID: 232529
		int BuildLevel { get; set; }

		// Token: 0x17008867 RID: 34919
		// (get) Token: 0x06038C52 RID: 232530
		// (set) Token: 0x06038C53 RID: 232531
		bool IsArrowLevel { get; set; }
	}
}
