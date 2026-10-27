using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B47 RID: 19271
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseLockedHint : ITowerDefenseLockedHint
	{
		// Token: 0x17007BD7 RID: 31703
		// (get) Token: 0x06031E75 RID: 204405 RVA: 0x00B92AD8 File Offset: 0x00B90CD8
		// (set) Token: 0x06031E76 RID: 204406 RVA: 0x00B92AE0 File Offset: 0x00B90CE0
		public string TextId { get; set; }

		// Token: 0x17007BD8 RID: 31704
		// (get) Token: 0x06031E77 RID: 204407 RVA: 0x00B92AE9 File Offset: 0x00B90CE9
		// (set) Token: 0x06031E78 RID: 204408 RVA: 0x00B92AF1 File Offset: 0x00B90CF1
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
