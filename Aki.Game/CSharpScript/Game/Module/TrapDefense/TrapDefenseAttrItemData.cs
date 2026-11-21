using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A64 RID: 14948
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseAttrItemData : ITrapDefenseAttrItemData
	{
		// Token: 0x17004E92 RID: 20114
		// (get) Token: 0x060266A7 RID: 157351 RVA: 0x00AC2833 File Offset: 0x00AC0A33
		// (set) Token: 0x060266A8 RID: 157352 RVA: 0x00AC283B File Offset: 0x00AC0A3B
		public string IconPath { get; set; }

		// Token: 0x17004E93 RID: 20115
		// (get) Token: 0x060266A9 RID: 157353 RVA: 0x00AC2844 File Offset: 0x00AC0A44
		// (set) Token: 0x060266AA RID: 157354 RVA: 0x00AC284C File Offset: 0x00AC0A4C
		[Nullable(1)]
		public string NameKey { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17004E94 RID: 20116
		// (get) Token: 0x060266AB RID: 157355 RVA: 0x00AC2855 File Offset: 0x00AC0A55
		// (set) Token: 0x060266AC RID: 157356 RVA: 0x00AC285D File Offset: 0x00AC0A5D
		public string Value { get; set; }
	}
}
