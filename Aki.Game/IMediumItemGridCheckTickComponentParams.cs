using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DBC RID: 3516
[NullableContext(2)]
public interface IMediumItemGridCheckTickComponentParams
{
	// Token: 0x17000FC0 RID: 4032
	// (get) Token: 0x06008FA5 RID: 36773
	// (set) Token: 0x06008FA6 RID: 36774
	bool? IsCheckTick { get; set; }

	// Token: 0x17000FC1 RID: 4033
	// (get) Token: 0x06008FA7 RID: 36775
	// (set) Token: 0x06008FA8 RID: 36776
	string HexColor { get; set; }

	// Token: 0x17000FC2 RID: 4034
	// (get) Token: 0x06008FA9 RID: 36777
	// (set) Token: 0x06008FAA RID: 36778
	float? Alpha { get; set; }

	// Token: 0x17000FC3 RID: 4035
	// (get) Token: 0x06008FAB RID: 36779
	// (set) Token: 0x06008FAC RID: 36780
	string TickHexColor { get; set; }
}
