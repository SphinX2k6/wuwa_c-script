using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007488 RID: 29832
	public class ITriggerMotorSkillT
	{
		// Token: 0x1700E27B RID: 57979
		// (get) Token: 0x06036376 RID: 222070 RVA: 0x0075EEA0 File Offset: 0x0075D0A0
		// (set) Token: 0x06036377 RID: 222071 RVA: 0x0075EEA8 File Offset: 0x0075D0A8
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700E27C RID: 57980
		// (get) Token: 0x06036378 RID: 222072 RVA: 0x0075EEB1 File Offset: 0x0075D0B1
		// (set) Token: 0x06036379 RID: 222073 RVA: 0x0075EEB9 File Offset: 0x0075D0B9
		public int MotorSkillId { get; set; }

		// Token: 0x0603637A RID: 222074 RVA: 0x0075EEC2 File Offset: 0x0075D0C2
		public ITriggerMotorSkillT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.MotorSkillId = 0;
		}
	}
}
