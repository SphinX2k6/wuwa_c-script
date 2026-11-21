using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AEF RID: 15087
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseLockedHint : ITowerDefenseLockedHint
	{
		// Token: 0x17004F84 RID: 20356
		// (get) Token: 0x06026C05 RID: 158725 RVA: 0x00AD6B3C File Offset: 0x00AD4D3C
		// (set) Token: 0x06026C06 RID: 158726 RVA: 0x00AD6B44 File Offset: 0x00AD4D44
		public string TextId { get; set; }

		// Token: 0x17004F85 RID: 20357
		// (get) Token: 0x06026C07 RID: 158727 RVA: 0x00AD6B4D File Offset: 0x00AD4D4D
		// (set) Token: 0x06026C08 RID: 158728 RVA: 0x00AD6B55 File Offset: 0x00AD4D55
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] Args { [return: Nullable(new byte[]
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
