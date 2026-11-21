using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F78 RID: 20344
	public class ICheckIsUsingVehicleT
	{
		// Token: 0x17009173 RID: 37235
		// (get) Token: 0x0601FAD1 RID: 129745 RVA: 0x0046767E File Offset: 0x0046587E
		// (set) Token: 0x0601FAD2 RID: 129746 RVA: 0x00467686 File Offset: 0x00465886
		public EVehicleConditionType Type { get; set; }

		// Token: 0x17009174 RID: 37236
		// (get) Token: 0x0601FAD3 RID: 129747 RVA: 0x0046768F File Offset: 0x0046588F
		// (set) Token: 0x0601FAD4 RID: 129748 RVA: 0x00467697 File Offset: 0x00465897
		public int TargetVehicle { get; set; }

		// Token: 0x17009175 RID: 37237
		// (get) Token: 0x0601FAD5 RID: 129749 RVA: 0x004676A0 File Offset: 0x004658A0
		// (set) Token: 0x0601FAD6 RID: 129750 RVA: 0x004676A8 File Offset: 0x004658A8
		public EVehicleSeat Seat { get; set; }

		// Token: 0x17009176 RID: 37238
		// (get) Token: 0x0601FAD7 RID: 129751 RVA: 0x004676B1 File Offset: 0x004658B1
		// (set) Token: 0x0601FAD8 RID: 129752 RVA: 0x004676B9 File Offset: 0x004658B9
		public bool CheckIsBeingUsed { get; set; }

		// Token: 0x17009177 RID: 37239
		// (get) Token: 0x0601FAD9 RID: 129753 RVA: 0x004676C2 File Offset: 0x004658C2
		// (set) Token: 0x0601FADA RID: 129754 RVA: 0x004676CA File Offset: 0x004658CA
		public byte NullMask { get; set; }

		// Token: 0x0601FADB RID: 129755 RVA: 0x004676D3 File Offset: 0x004658D3
		public ICheckIsUsingVehicleT()
		{
			this.Type = EVehicleConditionType.UsingVehicle;
			this.TargetVehicle = 0;
			this.Seat = EVehicleSeat.Seat0;
			this.CheckIsBeingUsed = false;
			this.NullMask = 0;
		}
	}
}
