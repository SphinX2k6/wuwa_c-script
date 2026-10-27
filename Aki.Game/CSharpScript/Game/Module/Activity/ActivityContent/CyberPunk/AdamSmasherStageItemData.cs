using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020068A9 RID: 26793
	[NullableContext(1)]
	[Nullable(0)]
	public class AdamSmasherStageItemData : IAdamSmasherStageItemData
	{
		// Token: 0x170097C1 RID: 38849
		// (get) Token: 0x06042DD3 RID: 273875 RVA: 0x0104786C File Offset: 0x01045A6C
		// (set) Token: 0x06042DD4 RID: 273876 RVA: 0x01047874 File Offset: 0x01045A74
		public int StageId { get; set; }

		// Token: 0x170097C2 RID: 38850
		// (get) Token: 0x06042DD5 RID: 273877 RVA: 0x0104787D File Offset: 0x01045A7D
		// (set) Token: 0x06042DD6 RID: 273878 RVA: 0x01047885 File Offset: 0x01045A85
		public string IndexText { get; set; } = "";

		// Token: 0x170097C3 RID: 38851
		// (get) Token: 0x06042DD7 RID: 273879 RVA: 0x0104788E File Offset: 0x01045A8E
		// (set) Token: 0x06042DD8 RID: 273880 RVA: 0x01047896 File Offset: 0x01045A96
		public string Name { get; set; } = "";

		// Token: 0x170097C4 RID: 38852
		// (get) Token: 0x06042DD9 RID: 273881 RVA: 0x0104789F File Offset: 0x01045A9F
		// (set) Token: 0x06042DDA RID: 273882 RVA: 0x010478A7 File Offset: 0x01045AA7
		public bool IsUnlocked { get; set; }

		// Token: 0x170097C5 RID: 38853
		// (get) Token: 0x06042DDB RID: 273883 RVA: 0x010478B0 File Offset: 0x01045AB0
		// (set) Token: 0x06042DDC RID: 273884 RVA: 0x010478B8 File Offset: 0x01045AB8
		public bool IsHard { get; set; }
	}
}
