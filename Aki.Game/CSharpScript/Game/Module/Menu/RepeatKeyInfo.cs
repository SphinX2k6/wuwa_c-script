using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043D6 RID: 17366
	[NullableContext(1)]
	[Nullable(0)]
	public class RepeatKeyInfo : IRepeatKeyInfo
	{
		// Token: 0x170057CC RID: 22476
		// (get) Token: 0x0602BE44 RID: 179780 RVA: 0x00C541D9 File Offset: 0x00C523D9
		// (set) Token: 0x0602BE45 RID: 179781 RVA: 0x00C541E1 File Offset: 0x00C523E1
		public EInputControllerType InputControllerType { get; set; }

		// Token: 0x170057CD RID: 22477
		// (get) Token: 0x0602BE46 RID: 179782 RVA: 0x00C541EA File Offset: 0x00C523EA
		// (set) Token: 0x0602BE47 RID: 179783 RVA: 0x00C541F2 File Offset: 0x00C523F2
		public KeySettingRowData CurrentKeySettingRowData { get; set; }

		// Token: 0x170057CE RID: 22478
		// (get) Token: 0x0602BE48 RID: 179784 RVA: 0x00C541FB File Offset: 0x00C523FB
		// (set) Token: 0x0602BE49 RID: 179785 RVA: 0x00C54203 File Offset: 0x00C52403
		public KeySettingRowData RepeatKeySettingRowData { get; set; }

		// Token: 0x170057CF RID: 22479
		// (get) Token: 0x0602BE4A RID: 179786 RVA: 0x00C5420C File Offset: 0x00C5240C
		// (set) Token: 0x0602BE4B RID: 179787 RVA: 0x00C54214 File Offset: 0x00C52414
		[Nullable(2)]
		public Action<bool> OnCloseCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
