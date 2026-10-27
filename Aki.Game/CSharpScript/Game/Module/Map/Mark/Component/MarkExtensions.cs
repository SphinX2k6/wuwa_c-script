using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Map.Mark.Component
{
	// Token: 0x020054C9 RID: 21705
	public static class MarkExtensions
	{
		// Token: 0x0603769B RID: 226971 RVA: 0x00D29298 File Offset: 0x00D27498
		public static int? TrackHudEnable(this OneOf<MapMark, DynamicMapMark, TreasureBoxDetectorMark> Config)
		{
			if (!Config.HasValue)
			{
				return null;
			}
			if (Config.IsT1)
			{
				return new int?(Config.AsT1.TrackHudEnable);
			}
			if (Config.IsT2)
			{
				return new int?(Config.AsT2.TrackHudEnable);
			}
			if (Config.IsT3)
			{
				return new int?(Config.AsT3.TrackHudEnable);
			}
			return null;
		}

		// Token: 0x0603769C RID: 226972 RVA: 0x00D2931C File Offset: 0x00D2751C
		public static float? TrackAutoCancelDistance(this OneOf<MapMark, DynamicMapMark, TreasureBoxDetectorMark> Config)
		{
			if (!Config.HasValue)
			{
				return null;
			}
			if (Config.IsT1)
			{
				return new float?(Config.AsT1.TrackAutoCancelDistance);
			}
			if (Config.IsT2)
			{
				return new float?(Config.AsT2.TrackAutoCancelDistance);
			}
			if (Config.IsT3)
			{
				return new float?(Config.AsT3.TrackAutoCancelDistance);
			}
			return null;
		}
	}
}
