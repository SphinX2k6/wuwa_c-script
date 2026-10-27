using System;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003B7F RID: 15231
	public class IPlaceholderRefT
	{
		// Token: 0x17006871 RID: 26737
		// (get) Token: 0x06014DD5 RID: 85461 RVA: 0x003076AC File Offset: 0x003058AC
		// (set) Token: 0x06014DD6 RID: 85462 RVA: 0x003076B4 File Offset: 0x003058B4
		public TPlaceholderType Type { get; set; }

		// Token: 0x17006872 RID: 26738
		// (get) Token: 0x06014DD7 RID: 85463 RVA: 0x003076BD File Offset: 0x003058BD
		// (set) Token: 0x06014DD8 RID: 85464 RVA: 0x003076C5 File Offset: 0x003058C5
		public string Name { get; set; }

		// Token: 0x17006873 RID: 26739
		// (get) Token: 0x06014DD9 RID: 85465 RVA: 0x003076CE File Offset: 0x003058CE
		// (set) Token: 0x06014DDA RID: 85466 RVA: 0x003076D6 File Offset: 0x003058D6
		public string FieldName { get; set; }

		// Token: 0x06014DDB RID: 85467 RVA: 0x003076DF File Offset: 0x003058DF
		public IPlaceholderRefT()
		{
			this.Type = TPlaceholderType.BuffIdList;
			this.Name = null;
			this.FieldName = null;
		}
	}
}
