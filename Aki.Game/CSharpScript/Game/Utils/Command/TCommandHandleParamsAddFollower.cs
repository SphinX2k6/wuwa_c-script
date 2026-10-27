using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x02004570 RID: 17776
	[RequiredMember]
	public class TCommandHandleParamsAddFollower : TCommandHandleParams<ICommandTypeAddFollower>
	{
		// Token: 0x0602DE50 RID: 187984 RVA: 0x00A8DA4B File Offset: 0x00A8BC4B
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public TCommandHandleParamsAddFollower()
		{
		}

		// Token: 0x04018834 RID: 100404
		[Nullable(1)]
		[RequiredMember]
		public PlayerFollowerInfo PlayerFollowerInfo;
	}
}
