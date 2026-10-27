using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072D7 RID: 29399
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneCameraFollowConfig
	{
		// Token: 0x0604824E RID: 295502 RVA: 0x012826C9 File Offset: 0x012808C9
		public SceneCameraFollowConfig Set(ESceneCameraFollowTargetType targetType, int entityId = 0)
		{
			this.TargetType = targetType;
			this.EntityId = entityId;
			return this;
		}

		// Token: 0x0604824F RID: 295503 RVA: 0x012826DA File Offset: 0x012808DA
		public void DeepCopy(SceneCameraFollowConfig source)
		{
			this.TargetType = source.TargetType;
			this.EntityId = source.EntityId;
		}

		// Token: 0x06048250 RID: 295504 RVA: 0x012826F4 File Offset: 0x012808F4
		public void Reset()
		{
			this.TargetType = ESceneCameraFollowTargetType.Player;
			this.EntityId = 0;
		}

		// Token: 0x04026121 RID: 155937
		public ESceneCameraFollowTargetType TargetType;

		// Token: 0x04026122 RID: 155938
		public int EntityId;
	}
}
