using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Enum;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200635C RID: 25436
	[NullableContext(1)]
	[Nullable(0)]
	public class FollowShooterAttachStrategies : IStaticVariableResetter
	{
		// Token: 0x0603DA2F RID: 252463 RVA: 0x011DB436 File Offset: 0x011D9636
		private static void registerFollowShooterAttachStrategy(BPEFollowShooterAttachStrategy strategyEnum, IFollowShooterAttachStrategy strategy)
		{
			FollowShooterAttachStrategies.strategyRegistry[strategyEnum] = strategy;
		}

		// Token: 0x0603DA30 RID: 252464 RVA: 0x011DB444 File Offset: 0x011D9644
		public static IFollowShooterAttachStrategy getFollowShooterAttachStrategy(BPEFollowShooterAttachStrategy strategyEnum)
		{
			Dictionary<BPEFollowShooterAttachStrategy, IFollowShooterAttachStrategy> dictionary = FollowShooterAttachStrategies.strategyRegistry;
			IFollowShooterAttachStrategy result;
			if (dictionary != null && dictionary.TryGetValue(strategyEnum, out result))
			{
				return result;
			}
			return FollowShooterAttachStrategies.strategyRegistry[BPEFollowShooterAttachStrategy.DirectAttach];
		}

		// Token: 0x0603DA31 RID: 252465 RVA: 0x011DB474 File Offset: 0x011D9674
		public static List<IFollowShooterAttachStrategy> getAllFollowShooterAttachStrategies()
		{
			return new List<IFollowShooterAttachStrategy>(FollowShooterAttachStrategies.strategyRegistry.Values);
		}

		// Token: 0x0603DA32 RID: 252466 RVA: 0x011DB485 File Offset: 0x011D9685
		public static void setSceneComponentAttachStrategy(USceneComponent sceneComponent, BPEFollowShooterAttachStrategy strategyEnum)
		{
			FollowShooterAttachStrategies.sceneComponentAttachStrategyMap[sceneComponent] = strategyEnum;
		}

		// Token: 0x0603DA33 RID: 252467 RVA: 0x011DB493 File Offset: 0x011D9693
		public static BPEFollowShooterAttachStrategy getSceneComponentAttachStrategy(USceneComponent sceneComponent)
		{
			return FollowShooterAttachStrategies.sceneComponentAttachStrategyMap.GetValueOrDefault(sceneComponent, BPEFollowShooterAttachStrategy.DirectAttach);
		}

		// Token: 0x0603DA34 RID: 252468 RVA: 0x011DB4A4 File Offset: 0x011D96A4
		public static void clearFollowShooterAttachStrategiesStateForSceneComponent(USceneComponent sceneComponent)
		{
			foreach (IFollowShooterAttachStrategy followShooterAttachStrategy in FollowShooterAttachStrategies.strategyRegistry.Values)
			{
				SocketTrackingStrategy socketTrackingStrategy = followShooterAttachStrategy as SocketTrackingStrategy;
				if (socketTrackingStrategy != null)
				{
					socketTrackingStrategy.ClearForSceneComponent(sceneComponent);
				}
			}
			FollowShooterAttachStrategies.sceneComponentAttachStrategyMap.Remove(sceneComponent);
		}

		// Token: 0x0603DA35 RID: 252469 RVA: 0x011DB510 File Offset: 0x011D9710
		public static void CreateStaticDefaultValue()
		{
			FollowShooterAttachStrategies.strategyRegistry = new Dictionary<BPEFollowShooterAttachStrategy, IFollowShooterAttachStrategy>();
			FollowShooterAttachStrategies.sceneComponentAttachStrategyMap = new Dictionary<USceneComponent, BPEFollowShooterAttachStrategy>();
			FollowShooterAttachStrategies.registerFollowShooterAttachStrategy(BPEFollowShooterAttachStrategy.DirectAttach, new DirectAttachStrategy());
			FollowShooterAttachStrategies.registerFollowShooterAttachStrategy(BPEFollowShooterAttachStrategy.SocketTracking, new SocketTrackingStrategy());
		}

		// Token: 0x0603DA36 RID: 252470 RVA: 0x011DB53C File Offset: 0x011D973C
		public static void ResetStaticDefaultValue()
		{
			FollowShooterAttachStrategies.strategyRegistry = null;
			FollowShooterAttachStrategies.sceneComponentAttachStrategyMap = null;
		}

		// Token: 0x0603DA37 RID: 252471 RVA: 0x011DB54A File Offset: 0x011D974A
		static FollowShooterAttachStrategies()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FollowShooterAttachStrategies.CreateStaticDefaultValue), new Action(FollowShooterAttachStrategies.ResetStaticDefaultValue));
		}

		// Token: 0x04020B27 RID: 133927
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<BPEFollowShooterAttachStrategy, IFollowShooterAttachStrategy> strategyRegistry;

		// Token: 0x04020B28 RID: 133928
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<USceneComponent, BPEFollowShooterAttachStrategy> sceneComponentAttachStrategyMap;
	}
}
