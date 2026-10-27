using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x02004571 RID: 17777
	[RequiredMember]
	public class TCommandHandleParamsRemoveFollower : TCommandHandleParams<ICommandTypeRemoveFollower>
	{
		// Token: 0x0602DE51 RID: 187985 RVA: 0x00A8DA53 File Offset: 0x00A8BC53
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public TCommandHandleParamsRemoveFollower()
		{
		}

		// Token: 0x04018835 RID: 100405
		[RequiredMember]
		public long CreatureDataId;
	}
}
