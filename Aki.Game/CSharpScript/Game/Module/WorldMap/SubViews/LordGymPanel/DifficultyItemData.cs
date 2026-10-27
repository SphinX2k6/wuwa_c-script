using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.LordGymPanel
{
	// Token: 0x0200480E RID: 18446
	[NullableContext(1)]
	[Nullable(0)]
	public class DifficultyItemData : IDifficultyItemData
	{
		// Token: 0x170078E3 RID: 30947
		// (get) Token: 0x060304AD RID: 197805 RVA: 0x00B33C64 File Offset: 0x00B31E64
		// (set) Token: 0x060304AE RID: 197806 RVA: 0x00B33C6C File Offset: 0x00B31E6C
		public string NameTextId { get; set; } = "";

		// Token: 0x170078E4 RID: 30948
		// (get) Token: 0x060304AF RID: 197807 RVA: 0x00B33C75 File Offset: 0x00B31E75
		// (set) Token: 0x060304B0 RID: 197808 RVA: 0x00B33C7D File Offset: 0x00B31E7D
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public object[] NameTextArg { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170078E5 RID: 30949
		// (get) Token: 0x060304B1 RID: 197809 RVA: 0x00B33C86 File Offset: 0x00B31E86
		// (set) Token: 0x060304B2 RID: 197810 RVA: 0x00B33C8E File Offset: 0x00B31E8E
		public List<ELordGymDifficultyState> StateList { get; set; }
	}
}
