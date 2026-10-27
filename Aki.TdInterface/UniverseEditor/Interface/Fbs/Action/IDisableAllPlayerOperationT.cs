using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065D4 RID: 26068
	public class IDisableAllPlayerOperationT
	{
		// Token: 0x1700C174 RID: 49524
		// (get) Token: 0x0602D35E RID: 185182 RVA: 0x00632710 File Offset: 0x00630910
		// (set) Token: 0x0602D35F RID: 185183 RVA: 0x00632718 File Offset: 0x00630918
		public EPlayerOperationType Type { get; set; }

		// Token: 0x1700C175 RID: 49525
		// (get) Token: 0x0602D360 RID: 185184 RVA: 0x00632721 File Offset: 0x00630921
		// (set) Token: 0x0602D361 RID: 185185 RVA: 0x00632729 File Offset: 0x00630929
		public EDisplayModeInPlayerOp DisplayMode { get; set; }

		// Token: 0x1700C176 RID: 49526
		// (get) Token: 0x0602D362 RID: 185186 RVA: 0x00632732 File Offset: 0x00630932
		// (set) Token: 0x0602D363 RID: 185187 RVA: 0x0063273A File Offset: 0x0063093A
		public bool IsUiFadeEffect { get; set; }

		// Token: 0x1700C177 RID: 49527
		// (get) Token: 0x0602D364 RID: 185188 RVA: 0x00632743 File Offset: 0x00630943
		// (set) Token: 0x0602D365 RID: 185189 RVA: 0x0063274B File Offset: 0x0063094B
		public byte NullMask { get; set; }

		// Token: 0x0602D366 RID: 185190 RVA: 0x00632754 File Offset: 0x00630954
		public IDisableAllPlayerOperationT()
		{
			this.Type = EPlayerOperationType.EnableAll;
			this.DisplayMode = EDisplayModeInPlayerOp.ShowUi;
			this.IsUiFadeEffect = false;
			this.NullMask = 0;
		}
	}
}
