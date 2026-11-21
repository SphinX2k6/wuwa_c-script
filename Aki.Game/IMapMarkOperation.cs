using System;
using CSharpScript.Game.Module.Map.MapDefine;

// Token: 0x020016CB RID: 5835
public interface IMapMarkOperation : IMapOperation
{
	// Token: 0x1700159D RID: 5533
	// (get) Token: 0x0600E2D2 RID: 58066
	// (set) Token: 0x0600E2D3 RID: 58067
	EMarkType MarkType { get; set; }

	// Token: 0x1700159E RID: 5534
	// (get) Token: 0x0600E2D4 RID: 58068
	// (set) Token: 0x0600E2D5 RID: 58069
	int? MarkId { get; set; }
}
