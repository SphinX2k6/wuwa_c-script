using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils.ResponsibilityChain;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02007140 RID: 28992
	public class EntityHandleParameterContext : IParameterContext
	{
		// Token: 0x06046C78 RID: 289912 RVA: 0x011D6103 File Offset: 0x011D4303
		[NullableContext(1)]
		public EntityHandleParameterContext(EntityHandle entityHandle)
		{
		}

		// Token: 0x06046C79 RID: 289913 RVA: 0x011D6112 File Offset: 0x011D4312
		public bool IsValid()
		{
			return this.EntityHandle.Valid;
		}

		// Token: 0x0402527D RID: 152189
		[Nullable(1)]
		public EntityHandle EntityHandle = entityHandle;

		// Token: 0x0402527E RID: 152190
		public EPlayerFollowerHandlerType? OutPlayerFollowerHandlerType;
	}
}
