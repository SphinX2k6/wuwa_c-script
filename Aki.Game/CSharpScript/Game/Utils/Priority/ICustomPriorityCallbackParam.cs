using System;

namespace CSharpScript.Game.Utils.Priority
{
	// Token: 0x0200455C RID: 17756
	public interface ICustomPriorityCallbackParam
	{
		// Token: 0x17007555 RID: 30037
		// (get) Token: 0x0602DDC2 RID: 187842
		// (set) Token: 0x0602DDC3 RID: 187843
		bool? IsReentrant { get; set; }

		// Token: 0x17007556 RID: 30038
		// (get) Token: 0x0602DDC4 RID: 187844
		// (set) Token: 0x0602DDC5 RID: 187845
		bool IsForce { get; set; }
	}
}
