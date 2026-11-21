using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A00 RID: 27136
	public class IClientDisableAllPlayerOperationT
	{
		// Token: 0x1700C78A RID: 51082
		// (get) Token: 0x0602E8CA RID: 190666 RVA: 0x0065920E File Offset: 0x0065740E
		// (set) Token: 0x0602E8CB RID: 190667 RVA: 0x00659216 File Offset: 0x00657416
		public EPlayerOperationType Type { get; set; }

		// Token: 0x1700C78B RID: 51083
		// (get) Token: 0x0602E8CC RID: 190668 RVA: 0x0065921F File Offset: 0x0065741F
		// (set) Token: 0x0602E8CD RID: 190669 RVA: 0x00659227 File Offset: 0x00657427
		public EDisplayModeInPlayerOp DisplayMode { get; set; }

		// Token: 0x1700C78C RID: 51084
		// (get) Token: 0x0602E8CE RID: 190670 RVA: 0x00659230 File Offset: 0x00657430
		// (set) Token: 0x0602E8CF RID: 190671 RVA: 0x00659238 File Offset: 0x00657438
		public byte NullMask { get; set; }

		// Token: 0x0602E8D0 RID: 190672 RVA: 0x00659241 File Offset: 0x00657441
		public IClientDisableAllPlayerOperationT()
		{
			this.Type = EPlayerOperationType.EnableAll;
			this.DisplayMode = EDisplayModeInPlayerOp.ShowUi;
			this.NullMask = 0;
		}
	}
}
