using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing.Components.TearItem
{
	// Token: 0x02005228 RID: 21032
	[NullableContext(1)]
	[Nullable(0)]
	internal static class PrizeDrawingTearCoverItemConstants
	{
		// Token: 0x0401BCA7 RID: 113831
		public static readonly float[] ShineDissolve = new float[]
		{
			0.2f,
			0.3f,
			0.4f,
			0.5f,
			1f
		};

		// Token: 0x0401BCA8 RID: 113832
		public static readonly float[] GlowMaskOffsetV = new float[]
		{
			-2.5f,
			-2f,
			-1.5f,
			-1.3f,
			-0.6f
		};

		// Token: 0x0401BCA9 RID: 113833
		public static readonly float[] GlowAlpha = new float[]
		{
			1f,
			0.9f,
			0.7f,
			0.5f,
			0.25f
		};

		// Token: 0x0401BCAA RID: 113834
		public static readonly FName GLOW_MASK_UV_NAME = new FName("MaskUV");

		// Token: 0x0401BCAB RID: 113835
		public const float DEFAULT_GLOW_MASK_UV_OFFSET = -4f;

		// Token: 0x0401BCAC RID: 113836
		public const string AUDIO_TEAR_FIRST = "play_ui_prizedrawing_ticket_tear_new_click";

		// Token: 0x0401BCAD RID: 113837
		public const string AUDIO_TEAR_AGAIN = "play_ui_prizedrawing_ticket_tear_torn_click";

		// Token: 0x0401BCAE RID: 113838
		public const string AUDIO_TEAR_BACK = "play_ui_prizedrawing_ticket_tear_back";

		// Token: 0x0401BCAF RID: 113839
		public const string AUDIO_TEAR_LOOP = "play_ui_prizedrawing_ticket_bigprize_light_loop";

		// Token: 0x0401BCB0 RID: 113840
		public const string AUDIO_TEAR_LOOP_STOP = "stop_ui_prizedrawing_ticket_bigprize_light_loop";

		// Token: 0x0401BCB1 RID: 113841
		public const string AUDIO_TEAR_OPEN = "play_ui_prizedrawing_ticket_bigprize_light_finish";

		// Token: 0x0401BCB2 RID: 113842
		public const string AUDIO_TEAR_OPEN_MINOR = "play_ui_prizedrawing_ticket_normalprize_light_finish";

		// Token: 0x0401BCB3 RID: 113843
		public const string AUDIO_TEAR_START = "play_ui_prizedrawing_ticket_bigprize_light_start";

		// Token: 0x0401BCB4 RID: 113844
		public const string AUDIO_RTPC_TEAR = "sys_game_prizedrawing_ticket_torn";

		// Token: 0x0401BCB5 RID: 113845
		public const int AUDIO_FADE_OUT_TIME = 1000;

		// Token: 0x0401BCB6 RID: 113846
		public const float DRAG_START_DISTANCE = 0.1f;
	}
}
