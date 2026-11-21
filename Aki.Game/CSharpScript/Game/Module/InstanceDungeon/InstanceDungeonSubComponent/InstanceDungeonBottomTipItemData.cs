using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x0200486C RID: 18540
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonBottomTipItemData
	{
		// Token: 0x17005E59 RID: 24153
		// (get) Token: 0x0602EA66 RID: 191078 RVA: 0x00D0579F File Offset: 0x00D0399F
		// (set) Token: 0x0602EA67 RID: 191079 RVA: 0x00D057A7 File Offset: 0x00D039A7
		public string TextId { get; set; } = "";

		// Token: 0x17005E5A RID: 24154
		// (get) Token: 0x0602EA68 RID: 191080 RVA: 0x00D057B0 File Offset: 0x00D039B0
		// (set) Token: 0x0602EA69 RID: 191081 RVA: 0x00D057B8 File Offset: 0x00D039B8
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] TextArgs { [return: Nullable(new byte[]
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
