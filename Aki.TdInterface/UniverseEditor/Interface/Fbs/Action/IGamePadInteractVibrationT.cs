using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F0C RID: 28428
	public class IGamePadInteractVibrationT
	{
		// Token: 0x1700D079 RID: 53369
		// (get) Token: 0x06031329 RID: 201513 RVA: 0x006AAD0E File Offset: 0x006A8F0E
		// (set) Token: 0x0603132A RID: 201514 RVA: 0x006AAD16 File Offset: 0x006A8F16
		public string LongPressingEffect { get; set; }

		// Token: 0x1700D07A RID: 53370
		// (get) Token: 0x0603132B RID: 201515 RVA: 0x006AAD1F File Offset: 0x006A8F1F
		// (set) Token: 0x0603132C RID: 201516 RVA: 0x006AAD27 File Offset: 0x006A8F27
		public string LongPressFinishedEffect { get; set; }

		// Token: 0x0603132D RID: 201517 RVA: 0x006AAD30 File Offset: 0x006A8F30
		public IGamePadInteractVibrationT()
		{
			this.LongPressingEffect = null;
			this.LongPressFinishedEffect = null;
		}
	}
}
