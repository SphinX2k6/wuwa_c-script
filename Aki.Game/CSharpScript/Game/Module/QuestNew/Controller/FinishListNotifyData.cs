using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuestNew.Controller
{
	// Token: 0x02003F62 RID: 16226
	[NullableContext(1)]
	[Nullable(0)]
	public class FinishListNotifyData
	{
		// Token: 0x17005313 RID: 21267
		// (get) Token: 0x06029151 RID: 168273 RVA: 0x00B89D1E File Offset: 0x00B87F1E
		// (set) Token: 0x06029152 RID: 168274 RVA: 0x00B89D26 File Offset: 0x00B87F26
		public List<int> QuestIds { get; set; } = new List<int>();

		// Token: 0x17005314 RID: 21268
		// (get) Token: 0x06029153 RID: 168275 RVA: 0x00B89D2F File Offset: 0x00B87F2F
		// (set) Token: 0x06029154 RID: 168276 RVA: 0x00B89D37 File Offset: 0x00B87F37
		public EEventName EmitEventName { get; set; }

		// Token: 0x17005315 RID: 21269
		// (get) Token: 0x06029155 RID: 168277 RVA: 0x00B89D40 File Offset: 0x00B87F40
		// (set) Token: 0x06029156 RID: 168278 RVA: 0x00B89D48 File Offset: 0x00B87F48
		[Nullable(2)]
		public Action TryChangeTrackedQuest { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
