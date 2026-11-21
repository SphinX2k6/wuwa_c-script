using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02004817 RID: 18455
	public class InteractionDefine
	{
		// Token: 0x04018B0C RID: 101132
		public const int LERP_TIME = 500;

		// Token: 0x04018B0D RID: 101133
		public const int AUTO_PICKUP_TIME_INTERVAL = 300;

		// Token: 0x04018B0E RID: 101134
		public static readonly FName autoPickUpTag = new FName("AutoPickUp");

		// Token: 0x04018B0F RID: 101135
		[Nullable(1)]
		public const string BASE_QUALITY_COLOR = "c7c7c7";

		// Token: 0x04018B10 RID: 101136
		public const int INTERACT_GUIDE_MAX_TEXT_WIDTH = 760;
	}
}
