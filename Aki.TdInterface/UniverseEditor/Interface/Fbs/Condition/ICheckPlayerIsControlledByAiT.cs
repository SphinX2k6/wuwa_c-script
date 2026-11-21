using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FC6 RID: 20422
	public class ICheckPlayerIsControlledByAiT
	{
		// Token: 0x17009214 RID: 37396
		// (get) Token: 0x0601FD79 RID: 130425 RVA: 0x0046C3F0 File Offset: 0x0046A5F0
		// (set) Token: 0x0601FD7A RID: 130426 RVA: 0x0046C3F8 File Offset: 0x0046A5F8
		public ECondition Type { get; set; }

		// Token: 0x17009215 RID: 37397
		// (get) Token: 0x0601FD7B RID: 130427 RVA: 0x0046C401 File Offset: 0x0046A601
		// (set) Token: 0x0601FD7C RID: 130428 RVA: 0x0046C409 File Offset: 0x0046A609
		public bool IsControlledByAi { get; set; }

		// Token: 0x0601FD7D RID: 130429 RVA: 0x0046C412 File Offset: 0x0046A612
		public ICheckPlayerIsControlledByAiT()
		{
			this.Type = ECondition.CompareVar;
			this.IsControlledByAi = false;
		}
	}
}
