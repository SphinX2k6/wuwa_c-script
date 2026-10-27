using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F42 RID: 24386
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerResultViewButtonData : IWheelTowerResultViewButtonData
	{
		// Token: 0x17008F85 RID: 36741
		// (get) Token: 0x0603DF34 RID: 253748 RVA: 0x00EF5A44 File Offset: 0x00EF3C44
		// (set) Token: 0x0603DF35 RID: 253749 RVA: 0x00EF5A4C File Offset: 0x00EF3C4C
		public string Name { get; set; } = string.Empty;

		// Token: 0x17008F86 RID: 36742
		// (get) Token: 0x0603DF36 RID: 253750 RVA: 0x00EF5A55 File Offset: 0x00EF3C55
		// (set) Token: 0x0603DF37 RID: 253751 RVA: 0x00EF5A5D File Offset: 0x00EF3C5D
		public Action OnClick { get; set; } = delegate()
		{
		};

		// Token: 0x17008F87 RID: 36743
		// (get) Token: 0x0603DF38 RID: 253752 RVA: 0x00EF5A66 File Offset: 0x00EF3C66
		// (set) Token: 0x0603DF39 RID: 253753 RVA: 0x00EF5A6E File Offset: 0x00EF3C6E
		public EConfirmBoxConfigId? ConfirmBoxId { get; set; }
	}
}
