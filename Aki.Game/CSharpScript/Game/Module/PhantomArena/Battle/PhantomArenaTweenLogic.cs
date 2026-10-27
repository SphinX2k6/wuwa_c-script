using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x0200523C RID: 21052
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class PhantomArenaTweenLogic
	{
		// Token: 0x06035C86 RID: 220294 RVA: 0x00CB9F98 File Offset: 0x00CB8198
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public PhantomArenaTweenLogic()
		{
		}

		// Token: 0x0401C82B RID: 116779
		[Nullable(2)]
		public Action StartCallback;

		// Token: 0x0401C82C RID: 116780
		[RequiredMember]
		public Action CompleteCallback;

		// Token: 0x0401C82D RID: 116781
		[RequiredMember]
		public UCurveFloat LocationCurveX;

		// Token: 0x0401C82E RID: 116782
		[RequiredMember]
		public UCurveFloat LocationCurveY;

		// Token: 0x0401C82F RID: 116783
		public float? DurationTime;
	}
}
