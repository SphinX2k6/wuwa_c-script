using System;
using System.Runtime.CompilerServices;

// Token: 0x020018E9 RID: 6377
[NullableContext(1)]
public interface IButtonInfo
{
	// Token: 0x17000F88 RID: 3976
	// (get) Token: 0x0600BAD5 RID: 47829
	// (set) Token: 0x0600BAD6 RID: 47830
	Action<int> Function { get; set; }

	// Token: 0x17000F89 RID: 3977
	// (get) Token: 0x0600BAD7 RID: 47831
	// (set) Token: 0x0600BAD8 RID: 47832
	string Text { get; set; }

	// Token: 0x17000F8A RID: 3978
	// (get) Token: 0x0600BAD9 RID: 47833
	// (set) Token: 0x0600BADA RID: 47834
	int Index { get; set; }

	// Token: 0x17000F8B RID: 3979
	// (get) Token: 0x0600BADB RID: 47835
	// (set) Token: 0x0600BADC RID: 47836
	ERedDotName? RedDotName { get; set; }

	// Token: 0x17000F8C RID: 3980
	// (get) Token: 0x0600BADD RID: 47837
	// (set) Token: 0x0600BADE RID: 47838
	int? RedDotId { get; set; }
}
