using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.SceneInspection
{
	// Token: 0x02005BFA RID: 23546
	[RequiredMember]
	public class CheckInteractionOpenParam
	{
		// Token: 0x06039D3D RID: 236861 RVA: 0x0103D4FF File Offset: 0x0103B6FF
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CheckInteractionOpenParam()
		{
		}

		// Token: 0x0401E8BC RID: 125116
		[Nullable(1)]
		[RequiredMember]
		public ISceneInspection Config;

		// Token: 0x0401E8BD RID: 125117
		[Nullable(2)]
		public GeneralContext Context;
	}
}
