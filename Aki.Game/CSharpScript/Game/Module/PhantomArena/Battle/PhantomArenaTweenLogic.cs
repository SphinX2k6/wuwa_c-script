using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x0200420C RID: 16908
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class PhantomArenaTweenLogic
	{
		// Token: 0x0602AB81 RID: 174977 RVA: 0x00C075D8 File Offset: 0x00C057D8
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public PhantomArenaTweenLogic()
		{
		}

		// Token: 0x04017260 RID: 94816
		[Nullable(2)]
		public Action StartCallback;

		// Token: 0x04017261 RID: 94817
		[RequiredMember]
		public Action CompleteCallback;

		// Token: 0x04017262 RID: 94818
		[RequiredMember]
		public UCurveFloat LocationCurveX;

		// Token: 0x04017263 RID: 94819
		[RequiredMember]
		public UCurveFloat LocationCurveY;

		// Token: 0x04017264 RID: 94820
		public float? DurationTime;
	}
}
