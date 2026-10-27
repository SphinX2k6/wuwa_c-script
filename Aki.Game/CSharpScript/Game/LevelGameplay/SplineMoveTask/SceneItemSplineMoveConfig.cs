using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02006A28 RID: 27176
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemSplineMoveConfig : ISceneItemSplineMoveConfig
	{
		// Token: 0x170098D5 RID: 39125
		// (get) Token: 0x06043987 RID: 276871 RVA: 0x0108B009 File Offset: 0x01089209
		// (set) Token: 0x06043988 RID: 276872 RVA: 0x0108B011 File Offset: 0x01089211
		public ISceneItemSplineMoveSegmentConfig GlobalConfig { get; set; }

		// Token: 0x170098D6 RID: 39126
		// (get) Token: 0x06043989 RID: 276873 RVA: 0x0108B01A File Offset: 0x0108921A
		// (set) Token: 0x0604398A RID: 276874 RVA: 0x0108B022 File Offset: 0x01089222
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

		// Token: 0x170098D7 RID: 39127
		// (get) Token: 0x0604398B RID: 276875 RVA: 0x0108B02B File Offset: 0x0108922B
		// (set) Token: 0x0604398C RID: 276876 RVA: 0x0108B033 File Offset: 0x01089233
		public ISceneItemSplineMoveRange SplineMoveRange { get; set; }

		// Token: 0x170098D8 RID: 39128
		// (get) Token: 0x0604398D RID: 276877 RVA: 0x0108B03C File Offset: 0x0108923C
		// (set) Token: 0x0604398E RID: 276878 RVA: 0x0108B044 File Offset: 0x01089244
		public int MoveCount { get; set; }

		// Token: 0x170098D9 RID: 39129
		// (get) Token: 0x0604398F RID: 276879 RVA: 0x0108B04D File Offset: 0x0108924D
		// (set) Token: 0x06043990 RID: 276880 RVA: 0x0108B055 File Offset: 0x01089255
		public bool IsClosedLoop { get; set; }

		// Token: 0x170098DA RID: 39130
		// (get) Token: 0x06043991 RID: 276881 RVA: 0x0108B05E File Offset: 0x0108925E
		// (set) Token: 0x06043992 RID: 276882 RVA: 0x0108B066 File Offset: 0x01089266
		public bool IsLookDir { get; set; }
	}
}
