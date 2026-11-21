using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.SeamlessTravel
{
	// Token: 0x02003C37 RID: 15415
	[NullableContext(2)]
	[Nullable(0)]
	public class SeamlessTravelContext
	{
		// Token: 0x060277DD RID: 161757 RVA: 0x00B12DA4 File Offset: 0x00B10FA4
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

		// Token: 0x060277DE RID: 161758 RVA: 0x00B12ED0 File Offset: 0x00B110D0
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

		// Token: 0x04015848 RID: 88136
		public string EffectPath;

		// Token: 0x04015849 RID: 88137
		public float EffectExpandTime;

		// Token: 0x0401584A RID: 88138
		public float EffectCollapseTime;

		// Token: 0x0401584B RID: 88139
		public float LeastTime;

		// Token: 0x0401584C RID: 88140
		public SeamlessTravelFloorParams FloorParams;

		// Token: 0x0401584D RID: 88141
		public bool IsTeleportInPlace;

		// Token: 0x0401584E RID: 88142
		public string TransitionWeatherDaPath;

		// Token: 0x0401584F RID: 88143
		public string SceneEffectDaPath;

		// Token: 0x04015850 RID: 88144
		public KeepMovementStateFeatures KeepMovementStateFeatures;

		// Token: 0x04015851 RID: 88145
		public SeamlessTravelFinishParams FinishParams;
	}
}
