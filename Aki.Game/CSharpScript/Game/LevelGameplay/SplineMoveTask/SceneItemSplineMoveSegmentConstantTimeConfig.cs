using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02005B79 RID: 23417
	public class SceneItemSplineMoveSegmentConstantTimeConfig : ISceneItemSplineMoveSegmentConfig
	{
		// Token: 0x17006D97 RID: 28055
		// (get) Token: 0x06039979 RID: 235897 RVA: 0x0102E71D File Offset: 0x0102C91D
		[Obsolete]
		public ESceneItemSplineMoveSegmentConfigType Type
		{
			get
			{
				return ESceneItemSplineMoveSegmentConfigType.ConstantTime;
			}
		}

		// Token: 0x17006D98 RID: 28056
		// (get) Token: 0x0603997A RID: 235898 RVA: 0x0102E720 File Offset: 0x0102C920
		// (set) Token: 0x0603997B RID: 235899 RVA: 0x0102E728 File Offset: 0x0102C928
		public float? WaitTime { get; set; }

		// Token: 0x0401E68E RID: 124558
		public float Time;

		// Token: 0x0401E68F RID: 124559
		[Nullable(2)]
		public string TimeDisCurve;
	}
}
