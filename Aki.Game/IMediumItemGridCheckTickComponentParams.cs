using System;
using System.Runtime.CompilerServices;

// Token: 0x02001903 RID: 6403
[NullableContext(2)]
public interface IMediumItemGridCheckTickComponentParams
{
	// Token: 0x17000F9D RID: 3997
	// (get) Token: 0x0600BBBB RID: 48059
	// (set) Token: 0x0600BBBC RID: 48060
	bool? IsCheckTick { get; set; }

	// Token: 0x17000F9E RID: 3998
	// (get) Token: 0x0600BBBD RID: 48061
	// (set) Token: 0x0600BBBE RID: 48062
	string HexColor { get; set; }

	// Token: 0x17000F9F RID: 3999
	// (get) Token: 0x0600BBBF RID: 48063
	// (set) Token: 0x0600BBC0 RID: 48064
	float? Alpha { get; set; }

	// Token: 0x17000FA0 RID: 4000
	// (get) Token: 0x0600BBC1 RID: 48065
	// (set) Token: 0x0600BBC2 RID: 48066
	string TickHexColor { get; set; }
}
