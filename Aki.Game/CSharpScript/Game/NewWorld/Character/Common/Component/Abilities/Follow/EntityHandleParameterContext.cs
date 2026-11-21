using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils.ResponsibilityChain;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200636E RID: 25454
	public class EntityHandleParameterContext : IParameterContext
	{
		// Token: 0x0603DAC9 RID: 252617 RVA: 0x011DEB18 File Offset: 0x011DCD18
		[NullableContext(1)]
		public EntityHandleParameterContext(EntityHandle entityHandle)
		{
		}

		// Token: 0x0603DACA RID: 252618 RVA: 0x011DEB27 File Offset: 0x011DCD27
		public bool IsValid()
		{
			return this.EntityHandle.Valid;
		}

		// Token: 0x04020B5D RID: 133981
		[Nullable(1)]
		public EntityHandle EntityHandle = entityHandle;

		// Token: 0x04020B5E RID: 133982
		public EPlayerFollowerHandlerType? OutPlayerFollowerHandlerType;
	}
}
