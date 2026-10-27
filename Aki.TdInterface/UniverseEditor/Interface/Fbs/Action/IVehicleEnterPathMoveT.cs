using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007512 RID: 29970
	public class IVehicleEnterPathMoveT
	{
		// Token: 0x1700E36C RID: 58220
		// (get) Token: 0x0603681E RID: 223262 RVA: 0x007678B5 File Offset: 0x00765AB5
		// (set) Token: 0x0603681F RID: 223263 RVA: 0x007678BD File Offset: 0x00765ABD
		public EVehicleControlType Type { get; set; }

		// Token: 0x1700E36D RID: 58221
		// (get) Token: 0x06036820 RID: 223264 RVA: 0x007678C6 File Offset: 0x00765AC6
		// (set) Token: 0x06036821 RID: 223265 RVA: 0x007678CE File Offset: 0x00765ACE
		public IVehicleCruisingParamsT ControlParams { get; set; }

		// Token: 0x1700E36E RID: 58222
		// (get) Token: 0x06036822 RID: 223266 RVA: 0x007678D7 File Offset: 0x00765AD7
		// (set) Token: 0x06036823 RID: 223267 RVA: 0x007678DF File Offset: 0x00765ADF
		public TSplineMovePatternUnion Pattern { get; set; }

		// Token: 0x06036824 RID: 223268 RVA: 0x007678E8 File Offset: 0x00765AE8
		public IVehicleEnterPathMoveT()
		{
			this.Type = EVehicleControlType.EnterPathMoving;
			this.ControlParams = null;
			this.Pattern = null;
		}
	}
}
