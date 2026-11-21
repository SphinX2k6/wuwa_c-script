using System;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02005B78 RID: 23416
	public class SceneItemSplineMoveSegmentConstantSpeedConfig : ISceneItemSplineMoveSegmentConfig
	{
		// Token: 0x17006D95 RID: 28053
		// (get) Token: 0x06039975 RID: 235893 RVA: 0x0102E701 File Offset: 0x0102C901
		[Obsolete]
		public ESceneItemSplineMoveSegmentConfigType Type
		{
			get
			{
				return ESceneItemSplineMoveSegmentConfigType.ConstantSpeed;
			}
		}

		// Token: 0x17006D96 RID: 28054
		// (get) Token: 0x06039976 RID: 235894 RVA: 0x0102E704 File Offset: 0x0102C904
		// (set) Token: 0x06039977 RID: 235895 RVA: 0x0102E70C File Offset: 0x0102C90C
		public float? WaitTime { get; set; }

		// Token: 0x0401E68C RID: 124556
		public float Speed;
	}
}
