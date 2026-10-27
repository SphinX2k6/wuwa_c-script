using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02005840 RID: 22592
	public class InteractionDefine
	{
		// Token: 0x0401E073 RID: 122995
		public const int LERP_TIME = 500;

		// Token: 0x0401E074 RID: 122996
		public const int AUTO_PICKUP_TIME_INTERVAL = 300;

		// Token: 0x0401E075 RID: 122997
		public static readonly FName autoPickUpTag = new FName("AutoPickUp");

		// Token: 0x0401E076 RID: 122998
		[Nullable(1)]
		public const string BASE_QUALITY_COLOR = "c7c7c7";

		// Token: 0x0401E077 RID: 122999
		public const int INTERACT_GUIDE_MAX_TEXT_WIDTH = 760;
	}
}
