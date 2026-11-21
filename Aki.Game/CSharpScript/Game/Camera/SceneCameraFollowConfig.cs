using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006459 RID: 25689
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneCameraFollowConfig
	{
		// Token: 0x0603E662 RID: 255586 RVA: 0x01224EB1 File Offset: 0x012230B1
		public SceneCameraFollowConfig Set(ESceneCameraFollowTargetType targetType, int entityId = 0)
		{
			this.TargetType = targetType;
			this.EntityId = entityId;
			return this;
		}

		// Token: 0x0603E663 RID: 255587 RVA: 0x01224EC2 File Offset: 0x012230C2
		public void DeepCopy(SceneCameraFollowConfig source)
		{
			this.TargetType = source.TargetType;
			this.EntityId = source.EntityId;
		}

		// Token: 0x0603E664 RID: 255588 RVA: 0x01224EDC File Offset: 0x012230DC
		public void Reset()
		{
			this.TargetType = ESceneCameraFollowTargetType.Player;
			this.EntityId = 0;
		}

		// Token: 0x04021404 RID: 136196
		public ESceneCameraFollowTargetType TargetType;

		// Token: 0x04021405 RID: 136197
		public int EntityId;
	}
}
