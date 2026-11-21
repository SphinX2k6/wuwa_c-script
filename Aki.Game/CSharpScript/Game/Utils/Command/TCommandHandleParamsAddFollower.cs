using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x02003498 RID: 13464
	[RequiredMember]
	public class TCommandHandleParamsAddFollower : TCommandHandleParams<ICommandTypeAddFollower>
	{
		// Token: 0x06022532 RID: 140594 RVA: 0x009B9163 File Offset: 0x009B7363
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public TCommandHandleParamsAddFollower()
		{
		}

		// Token: 0x04012E6E RID: 77422
		[Nullable(1)]
		[RequiredMember]
		public PlayerFollowerInfo PlayerFollowerInfo;
	}
}
