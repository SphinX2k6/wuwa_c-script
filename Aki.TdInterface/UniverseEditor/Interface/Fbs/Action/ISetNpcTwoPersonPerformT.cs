using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007810 RID: 30736
	public class ISetNpcTwoPersonPerformT
	{
		// Token: 0x1700E156 RID: 57686
		// (get) Token: 0x0603603F RID: 221247 RVA: 0x0073C475 File Offset: 0x0073A675
		// (set) Token: 0x06036040 RID: 221248 RVA: 0x0073C47D File Offset: 0x0073A67D
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700E157 RID: 57687
		// (get) Token: 0x06036041 RID: 221249 RVA: 0x0073C486 File Offset: 0x0073A686
		// (set) Token: 0x06036042 RID: 221250 RVA: 0x0073C48E File Offset: 0x0073A68E
		public IPlayerInitiatorT Initiator { get; set; }

		// Token: 0x1700E158 RID: 57688
		// (get) Token: 0x06036043 RID: 221251 RVA: 0x0073C497 File Offset: 0x0073A697
		// (set) Token: 0x06036044 RID: 221252 RVA: 0x0073C49F File Offset: 0x0073A69F
		public int Target { get; set; }

		// Token: 0x1700E159 RID: 57689
		// (get) Token: 0x06036045 RID: 221253 RVA: 0x0073C4A8 File Offset: 0x0073A6A8
		// (set) Token: 0x06036046 RID: 221254 RVA: 0x0073C4B0 File Offset: 0x0073A6B0
		public string GroupPerformMark { get; set; }

		// Token: 0x1700E15A RID: 57690
		// (get) Token: 0x06036047 RID: 221255 RVA: 0x0073C4B9 File Offset: 0x0073A6B9
		// (set) Token: 0x06036048 RID: 221256 RVA: 0x0073C4C1 File Offset: 0x0073A6C1
		public ENpcGroupPerformNpcType NpcType { get; set; }

		// Token: 0x1700E15B RID: 57691
		// (get) Token: 0x06036049 RID: 221257 RVA: 0x0073C4CA File Offset: 0x0073A6CA
		// (set) Token: 0x0603604A RID: 221258 RVA: 0x0073C4D2 File Offset: 0x0073A6D2
		public EWaitInteractNpcMontageWaitType WaitInteractNpcType { get; set; }

		// Token: 0x1700E15C RID: 57692
		// (get) Token: 0x0603604B RID: 221259 RVA: 0x0073C4DB File Offset: 0x0073A6DB
		// (set) Token: 0x0603604C RID: 221260 RVA: 0x0073C4E3 File Offset: 0x0073A6E3
		public byte NullMask { get; set; }

		// Token: 0x0603604D RID: 221261 RVA: 0x0073C4EC File Offset: 0x0073A6EC
		public ISetNpcTwoPersonPerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Initiator = null;
			this.Target = 0;
			this.GroupPerformMark = null;
			this.NpcType = ENpcGroupPerformNpcType.LevelBCommonMale;
			this.WaitInteractNpcType = EWaitInteractNpcMontageWaitType.WaitForMontage;
			this.NullMask = 0;
		}
	}
}
