using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Map;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x020019D1 RID: 6609
[NullableContext(1)]
[Nullable(0)]
public static class WorldNavigation
{
	// Token: 0x0600C106 RID: 49414 RVA: 0x002B89DF File Offset: 0x002B6BDF
	public static void SetEnableDebug(bool enable)
	{
		WorldNavigation.EnableDebug = enable;
	}

	// Token: 0x0600C107 RID: 49415 RVA: 0x002B89E8 File Offset: 0x002B6BE8
	public static void FindPath(IWorldNavigationConfig config)
	{
		NavigationFindPathRequest navigationFindPathRequest = NavigationFindPathRequest.Create();
		navigationFindPathRequest.StartPos = new Aki.Protocol.Vector
		{
			X = (float)config.SourcePosition.X,
			Y = (float)config.SourcePosition.Y,
			Z = (float)config.SourcePosition.Z
		};
		navigationFindPathRequest.EndPos = new Aki.Protocol.Vector
		{
			X = (float)config.DestPosition.X,
			Y = (float)config.DestPosition.Y,
			Z = (float)config.DestPosition.Z
		};
		navigationFindPathRequest.MapId = config.MapId;
		Net.Instance.Call(ERequestMessageId.NavigationFindPathRequest, navigationFindPathRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			NavigationFindPathResponse navigationFindPathResponse = (NavigationFindPathResponse)msg;
			bool flag = navigationFindPathResponse != null && navigationFindPathResponse.ErrorCode == ErrorCode.Success;
			if (flag)
			{
				WorldNavigation.DoFindPath(navigationFindPathResponse, config);
			}
			if (config.Callback != null)
			{
				config.Callback(flag);
			}
		}, 0);
	}

	// Token: 0x0600C108 RID: 49416 RVA: 0x002B8AD8 File Offset: 0x002B6CD8
	private static void DoFindPath([Nullable(2)] NavigationFindPathResponse data, IWorldNavigationConfig config)
	{
		List<MoveCharacterPoint> list = new List<MoveCharacterPoint>();
		List<global::Vector> list2 = new List<global::Vector>();
		if (data != null)
		{
			for (int i = 0; i < data.PosList.Count; i++)
			{
				Aki.Protocol.Vector vector = data.PosList[i];
				global::Vector vector2 = new global::Vector((double)vector.X, (double)vector.Y, (double)vector.Z);
				MoveCharacterPoint item = new MoveCharacterPoint
				{
					Index = i,
					Position = vector2
				};
				list.Add(item);
				list2.Add(vector2);
			}
			WorldNavigation.DrawNavigationPoint(list2);
			WorldNavigation.GoNextPoint(config, list, 0, 3);
		}
	}

	// Token: 0x0600C109 RID: 49417 RVA: 0x002B8B68 File Offset: 0x002B6D68
	private static void GoNextPoint(IWorldNavigationConfig config, List<MoveCharacterPoint> movePointList, int startIndex, int endIndex)
	{
		List<MoveCharacterPoint> range;
		if (endIndex >= movePointList.Count - 1)
		{
			range = movePointList.GetRange(startIndex, movePointList.Count - startIndex);
		}
		else
		{
			range = movePointList.GetRange(startIndex, endIndex - startIndex);
		}
		MoveCharacterConfig config2 = new MoveCharacterConfig
		{
			Points = range,
			Navigation = true,
			ReturnFalseWhenNavigationFailed = true,
			IsFly = false,
			DebugMode = true,
			Loop = false,
			Callback = delegate(ELevelEventState state)
			{
				if (endIndex >= movePointList.Count)
				{
					WorldNavigation.CheckIsCloseEnoughToDest(config);
					return;
				}
				WorldNavigation.GoNextPoint(config, movePointList, endIndex, endIndex + 3);
			}
		};
		BaseMoveComponent moveComponent = config.MoveComponent;
		if (moveComponent == null)
		{
			return;
		}
		moveComponent.MoveAlongPath(config2, null);
	}

	// Token: 0x0600C10A RID: 49418 RVA: 0x002B8C38 File Offset: 0x002B6E38
	private static void CheckIsCloseEnoughToDest(IWorldNavigationConfig config)
	{
		if (config.DistanceThreshold != null && config.TryFindPathTimes != null)
		{
			int? num = config.TryFindPathTimes;
			int num2 = 0;
			if (!(num.GetValueOrDefault() <= num2 & num != null))
			{
				config.TryFindPathTimes--;
				BaseMoveComponent moveComponent = config.MoveComponent;
				FVectorDouble? fvectorDouble;
				if (moveComponent == null)
				{
					fvectorDouble = null;
				}
				else
				{
					CharacterActorComponent actorComp = moveComponent.ActorComp;
					fvectorDouble = ((actorComp != null) ? new FVectorDouble?(actorComp.ActorLocation) : null);
				}
				FVectorDouble? fvectorDouble2 = fvectorDouble;
				if (fvectorDouble2 != null)
				{
					FVectorDouble value = fvectorDouble2.Value;
					FVectorDouble fvectorDouble3 = config.DestPosition.ToUeVector(false);
					double num3 = FVectorDouble.Dist(value, fvectorDouble3);
					num = config.DistanceThreshold;
					double? num4 = (num != null) ? new double?((double)num.GetValueOrDefault()) : null;
					if (num3 > num4.GetValueOrDefault() & num4 != null)
					{
						config.SourcePosition = new global::Vector(fvectorDouble2.Value.X, fvectorDouble2.Value.Y, fvectorDouble2.Value.Z);
						WorldNavigation.FindPath(config);
					}
				}
				return;
			}
		}
	}

	// Token: 0x0600C10B RID: 49419 RVA: 0x002B8D90 File Offset: 0x002B6F90
	public static void TestFindPath(global::Vector worldPosition, TWorldNavigationCallback callback)
	{
		if (!WorldNavigation.EnableDebug)
		{
			return;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		BaseMoveComponent baseMoveComponent;
		if (getCurrentEntity == null)
		{
			baseMoveComponent = null;
		}
		else
		{
			WorldEntity entity = getCurrentEntity.Entity;
			baseMoveComponent = ((entity != null) ? entity.GetComponent<BaseMoveComponent>() : null);
		}
		BaseMoveComponent moveComponent = baseMoveComponent;
		EntityHandle getCurrentEntity2 = SceneTeamModel.Instance.GetCurrentEntity;
		object obj;
		if (getCurrentEntity2 == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity2 = getCurrentEntity2.Entity;
			obj = ((entity2 != null) ? entity2.GetComponent<CharacterActorComponent>() : null);
		}
		object obj2 = obj;
		FVectorDouble? fvectorDouble = (obj2 != null) ? new FVectorDouble?(obj2.ActorLocation) : null;
		if (fvectorDouble == null)
		{
			return;
		}
		WorldNavigation.FindPath(new WorldNavigationConfig
		{
			SourcePosition = new global::Vector(fvectorDouble.Value.X, fvectorDouble.Value.Y, fvectorDouble.Value.Z),
			DestPosition = worldPosition,
			MapId = MapModel.Instance.CurrentWorldMapConfigId,
			MoveComponent = moveComponent,
			DistanceThreshold = new int?(2000),
			TryFindPathTimes = new int?(5),
			Callback = callback
		});
	}

	// Token: 0x0600C10C RID: 49420 RVA: 0x002B8E88 File Offset: 0x002B7088
	private static void DrawNavigationPoint(List<global::Vector> posList)
	{
		int num = 30;
		int num2 = 180;
		FLinearColor value = new FLinearColor(1f, 0f, 0f, 0f);
		foreach (global::Vector vector in posList)
		{
			UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, vector.ToUeVector(false), (float)num, 30, new FLinearColor?(value), (float)num2, 0f);
		}
	}

	// Token: 0x040056CA RID: 22218
	private const int DEBUG_SPHERE_DEFAULT_RADIUS = 30;

	// Token: 0x040056CB RID: 22219
	private const int DEBUG_SPHERE_DEFAULT_SEGMENTS = 30;

	// Token: 0x040056CC RID: 22220
	private const int DEBUG_SPHERE_DEFAULT_DURATION = 180;

	// Token: 0x040056CD RID: 22221
	[StaticVariableRuleIgnore]
	public static bool EnableDebug;
}
