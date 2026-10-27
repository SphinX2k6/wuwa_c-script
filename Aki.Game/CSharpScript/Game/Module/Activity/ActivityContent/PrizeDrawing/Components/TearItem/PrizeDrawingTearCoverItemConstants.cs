using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing.Components.TearItem
{
	// Token: 0x020062AA RID: 25258
	[NullableContext(1)]
	[Nullable(0)]
	internal static class PrizeDrawingTearCoverItemConstants
	{
		// Token: 0x04021378 RID: 136056
		public static readonly float[] ShineDissolve = new float[]
		{
			0.2f,
			0.3f,
			0.4f,
			0.5f,
			1f
		};

		// Token: 0x04021379 RID: 136057
		public static readonly float[] GlowMaskOffsetV = new float[]
		{
			-2.5f,
			-2f,
			-1.5f,
			-1.3f,
			-0.6f
		};

		// Token: 0x0402137A RID: 136058
		public static readonly float[] GlowAlpha = new float[]
		{
			1f,
			0.9f,
			0.7f,
			0.5f,
			0.25f
		};

		// Token: 0x0402137B RID: 136059
		public static readonly FName GLOW_MASK_UV_NAME = new FName("MaskUV");

		// Token: 0x0402137C RID: 136060
		public const float DEFAULT_GLOW_MASK_UV_OFFSET = -4f;

		// Token: 0x0402137D RID: 136061
		public const string AUDIO_TEAR_FIRST = "play_ui_prizedrawing_ticket_tear_new_click";

		// Token: 0x0402137E RID: 136062
		public const string AUDIO_TEAR_AGAIN = "play_ui_prizedrawing_ticket_tear_torn_click";

		// Token: 0x0402137F RID: 136063
		public const string AUDIO_TEAR_BACK = "play_ui_prizedrawing_ticket_tear_back";

		// Token: 0x04021380 RID: 136064
		public const string AUDIO_TEAR_LOOP = "play_ui_prizedrawing_ticket_bigprize_light_loop";

		// Token: 0x04021381 RID: 136065
		public const string AUDIO_TEAR_LOOP_STOP = "stop_ui_prizedrawing_ticket_bigprize_light_loop";

		// Token: 0x04021382 RID: 136066
		public const string AUDIO_TEAR_OPEN = "play_ui_prizedrawing_ticket_bigprize_light_finish";

		// Token: 0x04021383 RID: 136067
		public const string AUDIO_TEAR_OPEN_MINOR = "play_ui_prizedrawing_ticket_normalprize_light_finish";

		// Token: 0x04021384 RID: 136068
		public const string AUDIO_TEAR_START = "play_ui_prizedrawing_ticket_bigprize_light_start";

		// Token: 0x04021385 RID: 136069
		public const string AUDIO_RTPC_TEAR = "sys_game_prizedrawing_ticket_torn";

		// Token: 0x04021386 RID: 136070
		public const int AUDIO_FADE_OUT_TIME = 1000;

		// Token: 0x04021387 RID: 136071
		public const float DRAG_START_DISTANCE = 0.1f;
	}
}
