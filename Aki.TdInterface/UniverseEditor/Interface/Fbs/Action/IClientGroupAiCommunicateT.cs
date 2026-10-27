using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063CE RID: 25550
	public class IClientGroupAiCommunicateT
	{
		// Token: 0x1700BE5C RID: 48732
		// (get) Token: 0x0602C329 RID: 181033 RVA: 0x006115F1 File Offset: 0x0060F7F1
		// (set) Token: 0x0602C32A RID: 181034 RVA: 0x006115F9 File Offset: 0x0060F7F9
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700BE5D RID: 48733
		// (get) Token: 0x0602C32B RID: 181035 RVA: 0x00611602 File Offset: 0x0060F802
		// (set) Token: 0x0602C32C RID: 181036 RVA: 0x0061160A File Offset: 0x0060F80A
		public int GroupEntityId { get; set; }

		// Token: 0x1700BE5E RID: 48734
		// (get) Token: 0x0602C32D RID: 181037 RVA: 0x00611613 File Offset: 0x0060F813
		// (set) Token: 0x0602C32E RID: 181038 RVA: 0x0061161B File Offset: 0x0060F81B
		public TGroupAiCommunicateOptionUnion Option { get; set; }

		// Token: 0x0602C32F RID: 181039 RVA: 0x00611624 File Offset: 0x0060F824
		public IClientGroupAiCommunicateT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.GroupEntityId = 0;
			this.Option = null;
		}
	}
}
