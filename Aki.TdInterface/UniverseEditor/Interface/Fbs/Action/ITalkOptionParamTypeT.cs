using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B0A RID: 31498
	public class ITalkOptionParamTypeT
	{
		// Token: 0x1700EBFC RID: 60412
		// (get) Token: 0x06038B7F RID: 232319 RVA: 0x007AC26A File Offset: 0x007AA46A
		// (set) Token: 0x06038B80 RID: 232320 RVA: 0x007AC272 File Offset: 0x007AA472
		public ETalkOptionParamType Type { get; set; }

		// Token: 0x06038B81 RID: 232321 RVA: 0x007AC27B File Offset: 0x007AA47B
		public ITalkOptionParamTypeT()
		{
			this.Type = ETalkOptionParamType.QteSucceed;
		}
	}
}
