using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005599 RID: 21913
	public class IConveyorBeltStateT
	{
		// Token: 0x17009CEA RID: 40170
		// (get) Token: 0x06022DA3 RID: 142755 RVA: 0x004CCFC6 File Offset: 0x004CB1C6
		// (set) Token: 0x06022DA4 RID: 142756 RVA: 0x004CCFCE File Offset: 0x004CB1CE
		public string EntityState { get; set; }

		// Token: 0x17009CEB RID: 40171
		// (get) Token: 0x06022DA5 RID: 142757 RVA: 0x004CCFD7 File Offset: 0x004CB1D7
		// (set) Token: 0x06022DA6 RID: 142758 RVA: 0x004CCFDF File Offset: 0x004CB1DF
		public TConveyorBeltFieldTypeUnion FieldType { get; set; }

		// Token: 0x17009CEC RID: 40172
		// (get) Token: 0x06022DA7 RID: 142759 RVA: 0x004CCFE8 File Offset: 0x004CB1E8
		// (set) Token: 0x06022DA8 RID: 142760 RVA: 0x004CCFF0 File Offset: 0x004CB1F0
		public IFixSpeedT MoveType { get; set; }

		// Token: 0x06022DA9 RID: 142761 RVA: 0x004CCFF9 File Offset: 0x004CB1F9
		public IConveyorBeltStateT()
		{
			this.EntityState = null;
			this.FieldType = null;
			this.MoveType = null;
		}
	}
}
