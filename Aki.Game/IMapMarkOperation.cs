using System;
using CSharpScript.Game.Module.Map.MapDefine;

// Token: 0x020021E7 RID: 8679
public interface IMapMarkOperation : IMapOperation
{
	// Token: 0x17001566 RID: 5478
	// (get) Token: 0x06010E41 RID: 69185
	// (set) Token: 0x06010E42 RID: 69186
	EMarkType MarkType { get; set; }

	// Token: 0x17001567 RID: 5479
	// (get) Token: 0x06010E43 RID: 69187
	// (set) Token: 0x06010E44 RID: 69188
	int? MarkId { get; set; }
}
