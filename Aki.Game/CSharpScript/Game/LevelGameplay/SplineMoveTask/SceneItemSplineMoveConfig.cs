using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02005B85 RID: 23429
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemSplineMoveConfig : ISceneItemSplineMoveConfig
	{
		// Token: 0x17006DBA RID: 28090
		// (get) Token: 0x060399D5 RID: 235989 RVA: 0x0102F839 File Offset: 0x0102DA39
		// (set) Token: 0x060399D6 RID: 235990 RVA: 0x0102F841 File Offset: 0x0102DA41
		public ISceneItemSplineMoveSegmentConfig GlobalConfig { get; set; }

		// Token: 0x17006DBB RID: 28091
		// (get) Token: 0x060399D7 RID: 235991 RVA: 0x0102F84A File Offset: 0x0102DA4A
		// (set) Token: 0x060399D8 RID: 235992 RVA: 0x0102F852 File Offset: 0x0102DA52
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ISceneItemSplineMoveSegmentConfig> PointConfigs { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17006DBC RID: 28092
		// (get) Token: 0x060399D9 RID: 235993 RVA: 0x0102F85B File Offset: 0x0102DA5B
		// (set) Token: 0x060399DA RID: 235994 RVA: 0x0102F863 File Offset: 0x0102DA63
		public ISceneItemSplineMoveRange SplineMoveRange { get; set; }

		// Token: 0x17006DBD RID: 28093
		// (get) Token: 0x060399DB RID: 235995 RVA: 0x0102F86C File Offset: 0x0102DA6C
		// (set) Token: 0x060399DC RID: 235996 RVA: 0x0102F874 File Offset: 0x0102DA74
		public int MoveCount { get; set; }

		// Token: 0x17006DBE RID: 28094
		// (get) Token: 0x060399DD RID: 235997 RVA: 0x0102F87D File Offset: 0x0102DA7D
		// (set) Token: 0x060399DE RID: 235998 RVA: 0x0102F885 File Offset: 0x0102DA85
		public bool IsClosedLoop { get; set; }

		// Token: 0x17006DBF RID: 28095
		// (get) Token: 0x060399DF RID: 235999 RVA: 0x0102F88E File Offset: 0x0102DA8E
		// (set) Token: 0x060399E0 RID: 236000 RVA: 0x0102F896 File Offset: 0x0102DA96
		public bool IsLookDir { get; set; }
	}
}
