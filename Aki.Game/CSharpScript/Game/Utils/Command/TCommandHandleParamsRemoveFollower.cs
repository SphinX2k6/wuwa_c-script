using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x02003499 RID: 13465
	[RequiredMember]
	public class TCommandHandleParamsRemoveFollower : TCommandHandleParams<ICommandTypeRemoveFollower>
	{
		// Token: 0x06022533 RID: 140595 RVA: 0x009B916B File Offset: 0x009B736B
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public TCommandHandleParamsRemoveFollower()
		{
		}

		// Token: 0x04012E6F RID: 77423
		[RequiredMember]
		public long CreatureDataId;
	}
}
