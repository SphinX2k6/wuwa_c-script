using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200653B RID: 25915
	public class IDartGameplayT
	{
		// Token: 0x1700C0A4 RID: 49316
		// (get) Token: 0x0602CF5A RID: 184154 RVA: 0x0062C489 File Offset: 0x0062A689
		// (set) Token: 0x0602CF5B RID: 184155 RVA: 0x0062C491 File Offset: 0x0062A691
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700C0A5 RID: 49317
		// (get) Token: 0x0602CF5C RID: 184156 RVA: 0x0062C49A File Offset: 0x0062A69A
		// (set) Token: 0x0602CF5D RID: 184157 RVA: 0x0062C4A2 File Offset: 0x0062A6A2
		public int MachineEntityId { get; set; }

		// Token: 0x1700C0A6 RID: 49318
		// (get) Token: 0x0602CF5E RID: 184158 RVA: 0x0062C4AB File Offset: 0x0062A6AB
		// (set) Token: 0x0602CF5F RID: 184159 RVA: 0x0062C4B3 File Offset: 0x0062A6B3
		public TDartInteractTypeUnion InteractType { get; set; }

		// Token: 0x0602CF60 RID: 184160 RVA: 0x0062C4BC File Offset: 0x0062A6BC
		public IDartGameplayT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.MachineEntityId = 0;
			this.InteractType = null;
		}
	}
}
