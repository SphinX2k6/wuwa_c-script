using System;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02006A1B RID: 27163
	public class SceneItemSplineMoveSegmentConstantSpeedConfig : ISceneItemSplineMoveSegmentConfig
	{
		// Token: 0x170098B0 RID: 39088
		// (get) Token: 0x06043927 RID: 276775 RVA: 0x01089ED0 File Offset: 0x010880D0
		[Obsolete]
		public ESceneItemSplineMoveSegmentConfigType Type
		{
			get
			{
				return ESceneItemSplineMoveSegmentConfigType.ConstantSpeed;
			}
		}

		// Token: 0x170098B1 RID: 39089
		// (get) Token: 0x06043928 RID: 276776 RVA: 0x01089ED3 File Offset: 0x010880D3
		// (set) Token: 0x06043929 RID: 276777 RVA: 0x01089EDB File Offset: 0x010880DB
		public float? WaitTime { get; set; }

		// Token: 0x0402349A RID: 144538
		public float Speed;
	}
}
