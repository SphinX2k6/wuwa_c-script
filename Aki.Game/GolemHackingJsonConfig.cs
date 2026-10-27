using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000FF4 RID: 4084
[NullableContext(1)]
[Nullable(0)]
public class GolemHackingJsonConfig
{
	// Token: 0x1700087B RID: 2171
	// (get) Token: 0x060068E7 RID: 26855 RVA: 0x0014DD60 File Offset: 0x0014BF60
	// (set) Token: 0x060068E8 RID: 26856 RVA: 0x0014DD68 File Offset: 0x0014BF68
	public int MatrixSize { get; set; }

	// Token: 0x1700087C RID: 2172
	// (get) Token: 0x060068E9 RID: 26857 RVA: 0x0014DD71 File Offset: 0x0014BF71
	// (set) Token: 0x060068EA RID: 26858 RVA: 0x0014DD79 File Offset: 0x0014BF79
	public List<GolemHackingGridJsonConfig> PresetCodes { get; set; }
}
