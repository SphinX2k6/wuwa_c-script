using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060C5 RID: 24773
	[NullableContext(1)]
	[Nullable(0)]
	public class AbyssRolePanelData : SolarSpeedRolePanelData, IAbyssRolePanelData, ISolarSpeedRolePanelData
	{
		// Token: 0x1700911F RID: 37151
		// (get) Token: 0x0603EA26 RID: 256550 RVA: 0x00F2075E File Offset: 0x00F1E95E
		// (set) Token: 0x0603EA27 RID: 256551 RVA: 0x00F20766 File Offset: 0x00F1E966
		public List<IAbyssDescData> MainDescData { get; set; }

		// Token: 0x17009120 RID: 37152
		// (get) Token: 0x0603EA28 RID: 256552 RVA: 0x00F2076F File Offset: 0x00F1E96F
		// (set) Token: 0x0603EA29 RID: 256553 RVA: 0x00F20777 File Offset: 0x00F1E977
		public List<IAbyssDescData> SubDescData { get; set; }

		// Token: 0x17009121 RID: 37153
		// (get) Token: 0x0603EA2A RID: 256554 RVA: 0x00F20780 File Offset: 0x00F1E980
		// (set) Token: 0x0603EA2B RID: 256555 RVA: 0x00F20788 File Offset: 0x00F1E988
		public int LikeCount { get; set; }

		// Token: 0x17009122 RID: 37154
		// (get) Token: 0x0603EA2C RID: 256556 RVA: 0x00F20791 File Offset: 0x00F1E991
		// (set) Token: 0x0603EA2D RID: 256557 RVA: 0x00F20799 File Offset: 0x00F1E999
		public int? PlayerTitle { get; set; }

		// Token: 0x17009123 RID: 37155
		// (get) Token: 0x0603EA2E RID: 256558 RVA: 0x00F207A2 File Offset: 0x00F1E9A2
		// (set) Token: 0x0603EA2F RID: 256559 RVA: 0x00F207AA File Offset: 0x00F1E9AA
		public int? PlayerTitleStarLevel { get; set; }

		// Token: 0x17009124 RID: 37156
		// (get) Token: 0x0603EA30 RID: 256560 RVA: 0x00F207B3 File Offset: 0x00F1E9B3
		// (set) Token: 0x0603EA31 RID: 256561 RVA: 0x00F207BB File Offset: 0x00F1E9BB
		public int Sex { get; set; }
	}
}
