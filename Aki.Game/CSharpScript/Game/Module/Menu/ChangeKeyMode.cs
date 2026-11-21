using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043E2 RID: 17378
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeKeyMode : IChangeKeyMode
	{
		// Token: 0x170057EE RID: 22510
		// (get) Token: 0x0602BE8D RID: 179853 RVA: 0x00C54365 File Offset: 0x00C52565
		// (set) Token: 0x0602BE8E RID: 179854 RVA: 0x00C5436D File Offset: 0x00C5256D
		public string TitleName { get; set; } = "";

		// Token: 0x170057EF RID: 22511
		// (get) Token: 0x0602BE8F RID: 179855 RVA: 0x00C54376 File Offset: 0x00C52576
		// (set) Token: 0x0602BE90 RID: 179856 RVA: 0x00C5437E File Offset: 0x00C5257E
		public int DefaultGroupIndex { get; set; }

		// Token: 0x170057F0 RID: 22512
		// (get) Token: 0x0602BE91 RID: 179857 RVA: 0x00C54387 File Offset: 0x00C52587
		// (set) Token: 0x0602BE92 RID: 179858 RVA: 0x00C5438F File Offset: 0x00C5258F
		public IChangeKeyModeGroup[] ChangeKeyModeGroupList { get; set; } = new IChangeKeyModeGroup[0];

		// Token: 0x170057F1 RID: 22513
		// (get) Token: 0x0602BE93 RID: 179859 RVA: 0x00C54398 File Offset: 0x00C52598
		// (set) Token: 0x0602BE94 RID: 179860 RVA: 0x00C543A0 File Offset: 0x00C525A0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<Dictionary<int, int>> OnConfirmCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
