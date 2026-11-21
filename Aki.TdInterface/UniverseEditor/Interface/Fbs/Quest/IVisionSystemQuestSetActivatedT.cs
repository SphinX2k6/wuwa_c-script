using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046D7 RID: 18135
	public class IVisionSystemQuestSetActivatedT
	{
		// Token: 0x17007EFC RID: 32508
		// (get) Token: 0x0601AA82 RID: 109186 RVA: 0x003CA134 File Offset: 0x003C8334
		// (set) Token: 0x0601AA83 RID: 109187 RVA: 0x003CA13C File Offset: 0x003C833C
		public EVisionSystemQuestType Type { get; set; }

		// Token: 0x17007EFD RID: 32509
		// (get) Token: 0x0601AA84 RID: 109188 RVA: 0x003CA145 File Offset: 0x003C8345
		// (set) Token: 0x0601AA85 RID: 109189 RVA: 0x003CA14D File Offset: 0x003C834D
		public EVisionSetType SetType { get; set; }

		// Token: 0x0601AA86 RID: 109190 RVA: 0x003CA156 File Offset: 0x003C8356
		public IVisionSystemQuestSetActivatedT()
		{
			this.Type = EVisionSystemQuestType.HasVisionGetTargetLevel;
			this.SetType = EVisionSetType.None;
		}
	}
}
