using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics
{
	// Token: 0x020064F0 RID: 25840
	[NullableContext(1)]
	[Nullable(0)]
	public static class LevelMechanicProvider
	{
		// Token: 0x06040DAF RID: 265647 RVA: 0x00FB5AA4 File Offset: 0x00FB3CA4
		public unsafe static IReadOnlyList<LevelMechanic> GetLevelMechanics(int level)
		{
			List<LevelMechanic> list = new List<LevelMechanic>();
			RecycleSpecialPieceMechanic recycleSpecialPieceMechanic = null;
			RecycleSpecialPieceMechanic recycleSpecialPieceMechanic2 = null;
			MatchThreeGameplay? gameplayConfig = MatchThreeConfig.Instance.GetGameplayConfig(level);
			if (gameplayConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MatchThree;
				ELogAuthor author = ELogAuthor.CB;
				string message = "关卡机制缺失: MatchThreeGameplay";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", level);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return list;
			}
			MatchThreeGameplay value = gameplayConfig.Value;
			for (int i = 0; i < value.EnviromentsLength; i++)
			{
				DicIntInt? dicIntInt = value.Enviroments(i);
				if (dicIntInt != null)
				{
					int key = dicIntInt.Value.Key;
					int value2 = dicIntInt.Value.Value;
					MatchThreeEnviroment? enviromentConfig = MatchThreeConfig.Instance.GetEnviromentConfig(value2);
					if (enviromentConfig == null)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.MatchThree;
						ELogAuthor author2 = ELogAuthor.CB;
						string message2 = "关卡机制缺失: MatchThreeEnviroment";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Id", value2);
						instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					}
					else
					{
						MatchThreeEnviroment value3 = enviromentConfig.Value;
						int[] paramsArray = value3.GetParamsArray();
						ELevelMechanicType type = (ELevelMechanicType)value3.Type;
						if (type - ELevelMechanicType.GenerateCharger > 1)
						{
							if (type - ELevelMechanicType.RecycleCharger > 1)
							{
								Log instance3 = Log.Instance;
								ELogModule module3 = ELogModule.MatchThree;
								ELogAuthor author3 = ELogAuthor.CB;
								string message3 = "未知关卡机制类型 EnvType";
								<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", value2);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EnvType", value3.Type);
								instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
							}
							else
							{
								EPieceType epieceType = (value3.Type == 3) ? EPieceType.Charger : EPieceType.Hourglass;
								CellZone[] zones = LevelMechanicProvider.CreateGenerateZones(epieceType);
								RecycleSpecialPieceMechanic candidate = new RecycleSpecialPieceMechanic(value2, key, epieceType, zones, value3.Tip);
								if (epieceType == EPieceType.Charger)
								{
									recycleSpecialPieceMechanic = LevelMechanicProvider.SelectEarliestRecycleMechanic(level, recycleSpecialPieceMechanic, candidate);
								}
								else
								{
									recycleSpecialPieceMechanic2 = LevelMechanicProvider.SelectEarliestRecycleMechanic(level, recycleSpecialPieceMechanic2, candidate);
								}
							}
						}
						else if (paramsArray == null || paramsArray.Length < 2)
						{
							Log instance4 = Log.Instance;
							ELogModule module4 = ELogModule.MatchThree;
							ELogAuthor author4 = ELogAuthor.CB;
							string message4 = "关卡机制参数不足: 需 2 项";
							<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Id", value2);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EnvType", value3.Type);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("参数数", (paramsArray != null) ? paramsArray.Length : 0);
							instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
						}
						else
						{
							EPieceType targetType;
							CellZone[] zones2;
							if (value3.Type == 1)
							{
								targetType = EPieceType.Charger;
								zones2 = new CellZone[]
								{
									new CellZone(1, 5, 1, 6),
									new CellZone(0, 6, 0, 7)
								};
							}
							else
							{
								targetType = EPieceType.Hourglass;
								zones2 = new CellZone[]
								{
									new CellZone(0, 1, 1, 6),
									new CellZone(0, 3, 0, 7),
									new CellZone(0, 5, 0, 7)
								};
							}
							list.Add(new GenerateSpecialPieceMechanic(value2, key, paramsArray[0], paramsArray[1], targetType, zones2, value3.Tip));
						}
					}
				}
			}
			if (recycleSpecialPieceMechanic != null)
			{
				list.Add(recycleSpecialPieceMechanic);
			}
			if (recycleSpecialPieceMechanic2 != null)
			{
				list.Add(recycleSpecialPieceMechanic2);
			}
			return list;
		}

		// Token: 0x06040DB0 RID: 265648 RVA: 0x00FB5DE0 File Offset: 0x00FB3FE0
		private unsafe static RecycleSpecialPieceMechanic SelectEarliestRecycleMechanic(int level, [Nullable(2)] RecycleSpecialPieceMechanic current, RecycleSpecialPieceMechanic candidate)
		{
			if (current == null)
			{
				return candidate;
			}
			RecycleSpecialPieceMechanic recycleSpecialPieceMechanic = current;
			RecycleSpecialPieceMechanic recycleSpecialPieceMechanic2 = candidate;
			if (candidate.MountRound < current.MountRound)
			{
				recycleSpecialPieceMechanic = candidate;
				recycleSpecialPieceMechanic2 = current;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MatchThree;
			ELogAuthor author = ELogAuthor.HMQ;
			string message = "[SelectEarliestRecycleMechanic] 同类型持续天气重复配置，忽略非最早挂载项";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Level", level);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TargetType", candidate.TargetType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("KeptEnvId", recycleSpecialPieceMechanic.EnvId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("KeptMountRound", recycleSpecialPieceMechanic.MountRound);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("IgnoredEnvId", recycleSpecialPieceMechanic2.EnvId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("IgnoredMountRound", recycleSpecialPieceMechanic2.MountRound);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			return recycleSpecialPieceMechanic;
		}

		// Token: 0x06040DB1 RID: 265649 RVA: 0x00FB5EF8 File Offset: 0x00FB40F8
		private static CellZone[] CreateGenerateZones(EPieceType targetType)
		{
			if (targetType == EPieceType.Charger)
			{
				return new CellZone[]
				{
					new CellZone(1, 5, 1, 6),
					new CellZone(0, 6, 0, 7)
				};
			}
			return new CellZone[]
			{
				new CellZone(0, 1, 1, 6),
				new CellZone(0, 3, 0, 7),
				new CellZone(0, 5, 0, 7)
			};
		}
	}
}
