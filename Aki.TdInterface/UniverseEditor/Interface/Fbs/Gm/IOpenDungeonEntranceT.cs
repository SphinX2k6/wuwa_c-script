using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004679 RID: 18041
	public class IOpenDungeonEntranceT
	{
		// Token: 0x1700801E RID: 32798
		// (get) Token: 0x0601B63B RID: 112187 RVA: 0x003E4930 File Offset: 0x003E2B30
		// (set) Token: 0x0601B63C RID: 112188 RVA: 0x003E4938 File Offset: 0x003E2B38
		public EGmCommand Type { get; set; }

		// Token: 0x1700801F RID: 32799
		// (get) Token: 0x0601B63D RID: 112189 RVA: 0x003E4941 File Offset: 0x003E2B41
		// (set) Token: 0x0601B63E RID: 112190 RVA: 0x003E4949 File Offset: 0x003E2B49
		public int EntranceId { get; set; }

		// Token: 0x0601B63F RID: 112191 RVA: 0x003E4952 File Offset: 0x003E2B52
		public IOpenDungeonEntranceT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.EntranceId = 0;
		}
	}
}
