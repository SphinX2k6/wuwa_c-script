using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200427B RID: 17019
	public class IVisionSystemQuestSetActivatedT
	{
		// Token: 0x170078CB RID: 30923
		// (get) Token: 0x06019316 RID: 103190 RVA: 0x0039EA5C File Offset: 0x0039CC5C
		// (set) Token: 0x06019317 RID: 103191 RVA: 0x0039EA64 File Offset: 0x0039CC64
		public EVisionSystemQuestType Type { get; set; }

		// Token: 0x170078CC RID: 30924
		// (get) Token: 0x06019318 RID: 103192 RVA: 0x0039EA6D File Offset: 0x0039CC6D
		// (set) Token: 0x06019319 RID: 103193 RVA: 0x0039EA75 File Offset: 0x0039CC75
		public EVisionSetType SetType { get; set; }

		// Token: 0x0601931A RID: 103194 RVA: 0x0039EA7E File Offset: 0x0039CC7E
		public IVisionSystemQuestSetActivatedT()
		{
			this.Type = EVisionSystemQuestType.HasVisionGetTargetLevel;
			this.SetType = EVisionSetType.None;
		}
	}
}
