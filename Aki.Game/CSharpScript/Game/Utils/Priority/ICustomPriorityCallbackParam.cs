using System;

namespace CSharpScript.Game.Utils.Priority
{
	// Token: 0x02003484 RID: 13444
	public interface ICustomPriorityCallbackParam
	{
		// Token: 0x1700480C RID: 18444
		// (get) Token: 0x060224A4 RID: 140452
		// (set) Token: 0x060224A5 RID: 140453
		bool? IsReentrant { get; set; }

		// Token: 0x1700480D RID: 18445
		// (get) Token: 0x060224A6 RID: 140454
		// (set) Token: 0x060224A7 RID: 140455
		bool IsForce { get; set; }
	}
}
