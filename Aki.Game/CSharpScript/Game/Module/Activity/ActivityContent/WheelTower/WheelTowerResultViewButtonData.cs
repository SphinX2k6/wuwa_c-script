using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F29 RID: 20265
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerResultViewButtonData : IWheelTowerResultViewButtonData
	{
		// Token: 0x17006357 RID: 25431
		// (get) Token: 0x06032ECF RID: 208591 RVA: 0x00E47770 File Offset: 0x00E45970
		// (set) Token: 0x06032ED0 RID: 208592 RVA: 0x00E47778 File Offset: 0x00E45978
		public string Name { get; set; } = string.Empty;

		// Token: 0x17006358 RID: 25432
		// (get) Token: 0x06032ED1 RID: 208593 RVA: 0x00E47781 File Offset: 0x00E45981
		// (set) Token: 0x06032ED2 RID: 208594 RVA: 0x00E47789 File Offset: 0x00E45989
		public Action OnClick { get; set; } = delegate()
		{
		};

		// Token: 0x17006359 RID: 25433
		// (get) Token: 0x06032ED3 RID: 208595 RVA: 0x00E47792 File Offset: 0x00E45992
		// (set) Token: 0x06032ED4 RID: 208596 RVA: 0x00E4779A File Offset: 0x00E4599A
		public EConfirmBoxConfigId? ConfirmBoxId { get; set; }
	}
}
