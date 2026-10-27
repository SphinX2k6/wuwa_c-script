using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004ABC RID: 19132
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseAttrItemData : ITrapDefenseAttrItemData
	{
		// Token: 0x17007AE5 RID: 31461
		// (get) Token: 0x06031917 RID: 203031 RVA: 0x00B7E87F File Offset: 0x00B7CA7F
		// (set) Token: 0x06031918 RID: 203032 RVA: 0x00B7E887 File Offset: 0x00B7CA87
		public string IconPath { get; set; }

		// Token: 0x17007AE6 RID: 31462
		// (get) Token: 0x06031919 RID: 203033 RVA: 0x00B7E890 File Offset: 0x00B7CA90
		// (set) Token: 0x0603191A RID: 203034 RVA: 0x00B7E898 File Offset: 0x00B7CA98
		[Nullable(1)]
		public string NameKey { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17007AE7 RID: 31463
		// (get) Token: 0x0603191B RID: 203035 RVA: 0x00B7E8A1 File Offset: 0x00B7CAA1
		// (set) Token: 0x0603191C RID: 203036 RVA: 0x00B7E8A9 File Offset: 0x00B7CAA9
		public string Value { get; set; }
	}
}
