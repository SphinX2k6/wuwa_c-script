using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200591F RID: 22815
	[NullableContext(1)]
	[Nullable(0)]
	internal static class SolarSchoolPrizeDrawingTearCoverItemConstants
	{
		// Token: 0x0401D9B3 RID: 121267
		public static readonly float[] ShineDissolve = new float[]
		{
			0.2f,
			0.3f,
			0.4f,
			0.5f,
			1f
		};

		// Token: 0x0401D9B4 RID: 121268
		public static readonly float[] GlowMaskOffsetV = new float[]
		{
			-2.5f,
			-2f,
			-1.5f,
			-1.3f,
			-0.6f
		};

		// Token: 0x0401D9B5 RID: 121269
		public static readonly float[] GlowAlpha = new float[]
		{
			1f,
			0.9f,
			0.7f,
			0.5f,
			0.25f
		};

		// Token: 0x0401D9B6 RID: 121270
		public static readonly FName GLOW_MASK_UV_NAME = new FName("MaskUV");

		// Token: 0x0401D9B7 RID: 121271
		public const float DEFAULT_GLOW_MASK_UV_OFFSET = -4f;

		// Token: 0x0401D9B8 RID: 121272
		public const string AUDIO_TEAR_FIRST = "play_ui_prizedrawing_ticket_tear_new_click";

		// Token: 0x0401D9B9 RID: 121273
		public const string AUDIO_TEAR_AGAIN = "play_ui_prizedrawing_ticket_tear_torn_click";

		// Token: 0x0401D9BA RID: 121274
		public const string AUDIO_TEAR_BACK = "play_ui_prizedrawing_ticket_tear_back";

		// Token: 0x0401D9BB RID: 121275
		public const string AUDIO_TEAR_LOOP = "play_ui_prizedrawing_ticket_bigprize_light_loop";

		// Token: 0x0401D9BC RID: 121276
		public const string AUDIO_TEAR_LOOP_STOP = "stop_ui_prizedrawing_ticket_bigprize_light_loop";

		// Token: 0x0401D9BD RID: 121277
		public const string AUDIO_TEAR_OPEN = "play_ui_prizedrawing_ticket_bigprize_light_finish";

		// Token: 0x0401D9BE RID: 121278
		public const string AUDIO_TEAR_OPEN_MINOR = "play_ui_prizedrawing_ticket_normalprize_light_finish";

		// Token: 0x0401D9BF RID: 121279
		public const string AUDIO_TEAR_START = "play_ui_prizedrawing_ticket_bigprize_light_start";

		// Token: 0x0401D9C0 RID: 121280
		public const string AUDIO_RTPC_TEAR = "sys_game_prizedrawing_ticket_torn";

		// Token: 0x0401D9C1 RID: 121281
		public const int AUDIO_FADE_OUT_TIME = 1000;

		// Token: 0x0401D9C2 RID: 121282
		public const float DRAG_START_DISTANCE = 0.1f;
	}
}
