using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.SeamlessTravel
{
	// Token: 0x02004C86 RID: 19590
	[NullableContext(2)]
	[Nullable(0)]
	public class SeamlessTravelContext
	{
		// Token: 0x06032A2A RID: 207402 RVA: 0x00BCE140 File Offset: 0x00BCC340
		[NullableContext(1)]
		public void ParseParamsByProto(TransitionInSeamlessPb config)
		{
			this.EffectPath = config.EffectDaPath;
			this.EffectExpandTime = config.EffectExpandTime;
			this.EffectCollapseTime = Math.Max(config.EffectCollapseTime, 0.5f);
			this.LeastTime = config.LeastTime;
			this.IsTeleportInPlace = config.IsTeleportInPlace;
			this.TransitionWeatherDaPath = config.TransitionWeatherDaPath;
			this.SceneEffectDaPath = config.SceneEffectDaPath;
			if (config.KeepStates.Count > 0)
			{
				this.KeepMovementStateFeatures = new KeepMovementStateFeatures();
				foreach (KeepMovementState keepMovementState in config.KeepStates)
				{
					if (keepMovementState != KeepMovementState.Kite)
					{
						if (keepMovementState == KeepMovementState.Soar)
						{
							this.KeepMovementStateFeatures.KeepSoar = true;
						}
					}
					else
					{
						this.KeepMovementStateFeatures.KeepKite = true;
					}
				}
			}
			if (config.HasFloorSettings)
			{
				this.FloorParams = new SeamlessTravelFloorParams();
				this.FloorParams.ParseFloorParamsByProto(config.FloorSettings);
			}
			if (config.SeamlessTeleportFinishConfig != null)
			{
				this.FinishParams = new SeamlessTravelFinishParams();
				this.FinishParams.ParseFinishParamsByProto(config.SeamlessTeleportFinishConfig);
			}
		}

		// Token: 0x06032A2B RID: 207403 RVA: 0x00BCE26C File Offset: 0x00BCC46C
		[NullableContext(1)]
		public void ParseParamsByConfig(ITeleportTransitionInSeamlessType config)
		{
			this.EffectPath = config.EffectDaPath;
			this.EffectExpandTime = config.EffectExpandTime;
			this.EffectCollapseTime = Math.Max(config.EffectCollapseTime, 0.5f);
			this.LeastTime = config.LeastTime;
			this.IsTeleportInPlace = config.IsTeleportInPlace.GetValueOrDefault();
			this.TransitionWeatherDaPath = config.TransitionWeatherDaPath;
			this.SceneEffectDaPath = config.SceneEffectDaPath;
			if (config.KeepMovementStates != null && config.KeepMovementStates.Count > 0)
			{
				this.KeepMovementStateFeatures = new KeepMovementStateFeatures();
				foreach (EKeepMovementState ekeepMovementState in config.KeepMovementStates)
				{
					if (ekeepMovementState != EKeepMovementState.Kite)
					{
						if (ekeepMovementState == EKeepMovementState.Soar)
						{
							this.KeepMovementStateFeatures.KeepSoar = true;
						}
					}
					else
					{
						this.KeepMovementStateFeatures.KeepKite = true;
					}
				}
			}
			if (config.FloorSettings != null)
			{
				this.FloorParams = new SeamlessTravelFloorParams();
				this.FloorParams.ParseFloorParamsByConfig(config.FloorSettings);
			}
			if (config.SeamlessTeleportFinishConfig != null)
			{
				this.FinishParams = new SeamlessTravelFinishParams();
				this.FinishParams.ParseFinishParamsByConfig(config.SeamlessTeleportFinishConfig);
			}
		}

		// Token: 0x0401AEEB RID: 110315
		public string EffectPath;

		// Token: 0x0401AEEC RID: 110316
		public float EffectExpandTime;

		// Token: 0x0401AEED RID: 110317
		public float EffectCollapseTime;

		// Token: 0x0401AEEE RID: 110318
		public float LeastTime;

		// Token: 0x0401AEEF RID: 110319
		public SeamlessTravelFloorParams FloorParams;

		// Token: 0x0401AEF0 RID: 110320
		public bool IsTeleportInPlace;

		// Token: 0x0401AEF1 RID: 110321
		public string TransitionWeatherDaPath;

		// Token: 0x0401AEF2 RID: 110322
		public string SceneEffectDaPath;

		// Token: 0x0401AEF3 RID: 110323
		public KeepMovementStateFeatures KeepMovementStateFeatures;

		// Token: 0x0401AEF4 RID: 110324
		public SeamlessTravelFinishParams FinishParams;
	}
}
