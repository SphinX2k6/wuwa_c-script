using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007350 RID: 29520
	public class ITalkOptionRogueRandomEventT
	{
		// Token: 0x1700E024 RID: 57380
		// (get) Token: 0x0603591E RID: 219422 RVA: 0x0074BA86 File Offset: 0x00749C86
		// (set) Token: 0x0603591F RID: 219423 RVA: 0x0074BA8E File Offset: 0x00749C8E
		public ETalkOptionParamType Type { get; set; }

		// Token: 0x1700E025 RID: 57381
		// (get) Token: 0x06035920 RID: 219424 RVA: 0x0074BA97 File Offset: 0x00749C97
		// (set) Token: 0x06035921 RID: 219425 RVA: 0x0074BA9F File Offset: 0x00749C9F
		public int OptionId { get; set; }

		// Token: 0x1700E026 RID: 57382
		// (get) Token: 0x06035922 RID: 219426 RVA: 0x0074BAA8 File Offset: 0x00749CA8
		// (set) Token: 0x06035923 RID: 219427 RVA: 0x0074BAB0 File Offset: 0x00749CB0
		public byte NullMask { get; set; }

		// Token: 0x06035924 RID: 219428 RVA: 0x0074BAB9 File Offset: 0x00749CB9
		public ITalkOptionRogueRandomEventT()
		{
			this.Type = ETalkOptionParamType.QteSucceed;
			this.OptionId = 0;
			this.NullMask = 0;
		}
	}
}
