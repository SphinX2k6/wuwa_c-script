using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AD6 RID: 15062
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefensePhantomSkillItemData : ITowerDefensePhantomSkillItemData
	{
		// Token: 0x17004F0E RID: 20238
		// (get) Token: 0x06026B0C RID: 158476 RVA: 0x00AD66C7 File Offset: 0x00AD48C7
		// (set) Token: 0x06026B0D RID: 158477 RVA: 0x00AD66CF File Offset: 0x00AD48CF
		public string SkillTextId { get; set; }

		// Token: 0x17004F0F RID: 20239
		// (get) Token: 0x06026B0E RID: 158478 RVA: 0x00AD66D8 File Offset: 0x00AD48D8
		// (set) Token: 0x06026B0F RID: 158479 RVA: 0x00AD66E0 File Offset: 0x00AD48E0
		public string Level { get; set; }

		// Token: 0x17004F10 RID: 20240
		// (get) Token: 0x06026B10 RID: 158480 RVA: 0x00AD66E9 File Offset: 0x00AD48E9
		// (set) Token: 0x06026B11 RID: 158481 RVA: 0x00AD66F1 File Offset: 0x00AD48F1
		public string DescriptionTextId { get; set; }

		// Token: 0x17004F11 RID: 20241
		// (get) Token: 0x06026B12 RID: 158482 RVA: 0x00AD66FA File Offset: 0x00AD48FA
		// (set) Token: 0x06026B13 RID: 158483 RVA: 0x00AD6702 File Offset: 0x00AD4902
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> DescriptionArgs { [return: Nullable(new byte[]
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
