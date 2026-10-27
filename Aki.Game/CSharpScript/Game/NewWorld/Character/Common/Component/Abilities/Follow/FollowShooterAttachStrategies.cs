using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Enum;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200712E RID: 28974
	[NullableContext(1)]
	[Nullable(0)]
	public class FollowShooterAttachStrategies : IStaticVariableResetter
	{
		// Token: 0x06046BE1 RID: 289761 RVA: 0x011D28D6 File Offset: 0x011D0AD6
		private static void registerFollowShooterAttachStrategy(BPEFollowShooterAttachStrategy strategyEnum, IFollowShooterAttachStrategy strategy)
		{
			FollowShooterAttachStrategies.strategyRegistry[strategyEnum] = strategy;
		}

		// Token: 0x06046BE2 RID: 289762 RVA: 0x011D28E4 File Offset: 0x011D0AE4
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

		// Token: 0x06046BE3 RID: 289763 RVA: 0x011D2914 File Offset: 0x011D0B14
		public static List<IFollowShooterAttachStrategy> getAllFollowShooterAttachStrategies()
		{
			return new List<IFollowShooterAttachStrategy>(FollowShooterAttachStrategies.strategyRegistry.Values);
		}

		// Token: 0x06046BE4 RID: 289764 RVA: 0x011D2925 File Offset: 0x011D0B25
		public static void setSceneComponentAttachStrategy(USceneComponent sceneComponent, BPEFollowShooterAttachStrategy strategyEnum)
		{
			FollowShooterAttachStrategies.sceneComponentAttachStrategyMap[sceneComponent] = strategyEnum;
		}

		// Token: 0x06046BE5 RID: 289765 RVA: 0x011D2933 File Offset: 0x011D0B33
		public static BPEFollowShooterAttachStrategy getSceneComponentAttachStrategy(USceneComponent sceneComponent)
		{
			return FollowShooterAttachStrategies.sceneComponentAttachStrategyMap.GetValueOrDefault(sceneComponent, BPEFollowShooterAttachStrategy.DirectAttach);
		}

		// Token: 0x06046BE6 RID: 289766 RVA: 0x011D2944 File Offset: 0x011D0B44
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

		// Token: 0x06046BE7 RID: 289767 RVA: 0x011D29B0 File Offset: 0x011D0BB0
		public static void CreateStaticDefaultValue()
		{
			FollowShooterAttachStrategies.strategyRegistry = new Dictionary<BPEFollowShooterAttachStrategy, IFollowShooterAttachStrategy>();
			FollowShooterAttachStrategies.sceneComponentAttachStrategyMap = new Dictionary<USceneComponent, BPEFollowShooterAttachStrategy>();
			FollowShooterAttachStrategies.registerFollowShooterAttachStrategy(BPEFollowShooterAttachStrategy.DirectAttach, new DirectAttachStrategy());
			FollowShooterAttachStrategies.registerFollowShooterAttachStrategy(BPEFollowShooterAttachStrategy.SocketTracking, new SocketTrackingStrategy());
		}

		// Token: 0x06046BE8 RID: 289768 RVA: 0x011D29DC File Offset: 0x011D0BDC
		public static void ResetStaticDefaultValue()
		{
			FollowShooterAttachStrategies.strategyRegistry = null;
			FollowShooterAttachStrategies.sceneComponentAttachStrategyMap = null;
		}

		// Token: 0x06046BE9 RID: 289769 RVA: 0x011D29EA File Offset: 0x011D0BEA
		static FollowShooterAttachStrategies()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FollowShooterAttachStrategies.CreateStaticDefaultValue), new Action(FollowShooterAttachStrategies.ResetStaticDefaultValue));
		}

		// Token: 0x04025247 RID: 152135
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<BPEFollowShooterAttachStrategy, IFollowShooterAttachStrategy> strategyRegistry;

		// Token: 0x04025248 RID: 152136
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<USceneComponent, BPEFollowShooterAttachStrategy> sceneComponentAttachStrategyMap;
	}
}
