using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02006A1C RID: 27164
	public class SceneItemSplineMoveSegmentConstantTimeConfig : ISceneItemSplineMoveSegmentConfig
	{
		// Token: 0x170098B2 RID: 39090
		// (get) Token: 0x0604392B RID: 276779 RVA: 0x01089EEC File Offset: 0x010880EC
		[Obsolete]
		public ESceneItemSplineMoveSegmentConfigType Type
		{
			get
			{
				return ESceneItemSplineMoveSegmentConfigType.ConstantTime;
			}
		}

		// Token: 0x170098B3 RID: 39091
		// (get) Token: 0x0604392C RID: 276780 RVA: 0x01089EEF File Offset: 0x010880EF
		// (set) Token: 0x0604392D RID: 276781 RVA: 0x01089EF7 File Offset: 0x010880F7
		public float? WaitTime { get; set; }

		// Token: 0x0402349C RID: 144540
		public float Time;

		// Token: 0x0402349D RID: 144541
		[Nullable(2)]
		public string TimeDisCurve;
	}
}
