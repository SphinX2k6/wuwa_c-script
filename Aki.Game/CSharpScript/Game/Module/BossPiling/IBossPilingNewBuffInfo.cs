using System;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02005C09 RID: 23561
	public interface IBossPilingNewBuffInfo
	{
		// Token: 0x17008DA1 RID: 36257
		// (get) Token: 0x0603B8A5 RID: 243877
		// (set) Token: 0x0603B8A6 RID: 243878
		int BuffId { get; set; }

		// Token: 0x17008DA2 RID: 36258
		// (get) Token: 0x0603B8A7 RID: 243879
		// (set) Token: 0x0603B8A8 RID: 243880
		int OldValue { get; set; }

		// Token: 0x17008DA3 RID: 36259
		// (get) Token: 0x0603B8A9 RID: 243881
		// (set) Token: 0x0603B8AA RID: 243882
		int NewValue { get; set; }

		// Token: 0x17008DA4 RID: 36260
		// (get) Token: 0x0603B8AB RID: 243883
		// (set) Token: 0x0603B8AC RID: 243884
		bool NeedAccelerate { get; set; }
	}
}
