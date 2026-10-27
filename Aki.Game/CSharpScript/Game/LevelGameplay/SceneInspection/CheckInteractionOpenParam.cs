using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.SceneInspection
{
	// Token: 0x02006A9D RID: 27293
	[RequiredMember]
	public class CheckInteractionOpenParam
	{
		// Token: 0x06043CEF RID: 277743 RVA: 0x01098CB7 File Offset: 0x01096EB7
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CheckInteractionOpenParam()
		{
		}

		// Token: 0x040236CA RID: 145098
		[Nullable(1)]
		[RequiredMember]
		public ISceneInspection Config;

		// Token: 0x040236CB RID: 145099
		[Nullable(2)]
		public GeneralContext Context;
	}
}
