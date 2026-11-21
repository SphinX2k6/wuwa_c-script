using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Core.Utils;
using CSharpScript.Typing;
using UnrealEngine;

namespace Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02002F93 RID: 12179
	[NullableContext(1)]
	[Nullable(0)]
	public class ChairSummonEvaluator
	{
		// Token: 0x17002DB7 RID: 11703
		// (get) Token: 0x0601CE1B RID: 118299 RVA: 0x008D2A6A File Offset: 0x008D0C6A
		// (set) Token: 0x0601CE1C RID: 118300 RVA: 0x008D2A71 File Offset: 0x008D0C71
		[StaticVariableRuleIgnore]
		public static bool DebugDraw { get; set; }

		// Token: 0x17002DB8 RID: 11704
		// (get) Token: 0x0601CE1D RID: 118301 RVA: 0x008D2A79 File Offset: 0x008D0C79
		// (set) Token: 0x0601CE1E RID: 118302 RVA: 0x008D2A80 File Offset: 0x008D0C80
		[StaticVariableRuleIgnore]
		public static float DebugDrawDuration { get; private set; }

		// Token: 0x0601CE1F RID: 118303 RVA: 0x008D2A88 File Offset: 0x008D0C88
		public static void SetDebugDraw(bool enable, float duration = 5f)
		{
			ChairSummonEvaluator.DebugDraw = enable;
			ChairSummonEvaluator.DebugDrawDuration = (enable ? duration : 0f);
		}

		// Token: 0x0601CE20 RID: 118304 RVA: 0x008D2AA0 File Offset: 0x008D0CA0
		public IChairSummonResult Evaluate(Entity chairEntity, ChairFollowerConfig chairConfig)
		{
			FKuroPerfSightHelper.BeginExtTag("ChairSummon.Evaluate");
			IChairSummonResult result = this.EvaluateInternal(chairEntity, chairConfig);
			FKuroPerfSightHelper.EndExtTag("ChairSummon.Evaluate");
			return result;
		}

		// Token: 0x0601CE21 RID: 118305 RVA: 0x008D2AC0 File Offset: 0x008D0CC0
		[return: Nullable(2)]
		public string EvaluateTickGroundCheck(Entity chairEntity, ChairFollowerConfig chairConfig)
		{
			SceneTeamModel instance = SceneTeamModel.Instance;
			object obj;
			if (instance == null)
			{
				obj = null;
			}
			else
			{
				EntityHandle getCurrentEntity = instance.GetCurrentEntity;
				obj = ((getCurrentEntity != null) ? getCurrentEntity.Entity : null);
			}
			object obj2 = obj;
			CharacterActorComponent characterActorComponent = (obj2 != null) ? obj2.GetComponent<CharacterActorComponent>() : null;
			CharacterMoveComponent characterMoveComponent = (obj2 != null) ? obj2.GetComponent<CharacterMoveComponent>() : null;
			BaseActorComponent component = chairEntity.GetComponent<BaseActorComponent>();
			AActor aactor = (component != null) ? component.Owner : null;
			if (characterActorComponent == null || characterMoveComponent == null || component == null || aactor == null)
			{
				return "缺少玩家或椅子的组件(ActorComponent/MoveComponent)";
			}
			Vector vector = Vector.Create(characterMoveComponent.GravityUp);
			Vector vector2 = Vector.Create(component.ActorLocationProxy);
			Vector vector3 = Vector.Create(vector);
			vector3.MultiplyEqual((double)chairConfig.SummonHeightOffset);
			vector2.SubtractionEqual(vector3);
			float yaw = component.ActorRotationProxy.Yaw;
			IChairSummonResult result = ChairSummonEvaluator.CreateSummonResult();
			ChairSummonEvaluator.FillDownRayGeometry(result, yaw, vector2, vector, chairConfig);
			Vector vector4;
			return this.CheckGroundByDownRays(characterActorComponent, chairEntity, vector, chairConfig, result, false, out vector4);
		}

		// Token: 0x0601CE22 RID: 118306 RVA: 0x008D2B9C File Offset: 0x008D0D9C
		private IChairSummonResult EvaluateInternal(Entity chairEntity, ChairFollowerConfig chairConfig)
		{
			SceneTeamModel instance = SceneTeamModel.Instance;
			object obj;
			if (instance == null)
			{
				obj = null;
			}
			else
			{
				EntityHandle getCurrentEntity = instance.GetCurrentEntity;
				obj = ((getCurrentEntity != null) ? getCurrentEntity.Entity : null);
			}
			object obj2 = obj;
			CharacterActorComponent characterActorComponent = (obj2 != null) ? obj2.GetComponent<CharacterActorComponent>() : null;
			CharacterMoveComponent characterMoveComponent = (obj2 != null) ? obj2.GetComponent<CharacterMoveComponent>() : null;
			BaseActorComponent component = chairEntity.GetComponent<BaseActorComponent>();
			AActor aactor = (component != null) ? component.Owner : null;
			if (characterActorComponent == null || characterMoveComponent == null || aactor == null)
			{
				IChairSummonResult chairSummonResult = ChairSummonEvaluator.CreateSummonResult();
				chairSummonResult.FailReason = "缺少玩家或椅子的组件(ActorComponent/MoveComponent)";
				return chairSummonResult;
			}
			Vector gravityUp = Vector.Create(characterMoveComponent.GravityUp);
			return this.EvaluateAtPlayerLocation(chairEntity, characterActorComponent, gravityUp, chairConfig);
		}

		// Token: 0x0601CE23 RID: 118307 RVA: 0x008D2C24 File Offset: 0x008D0E24
		private IChairSummonResult EvaluateAtPlayerLocation(Entity chairEntity, CharacterActorComponent playerActorComp, Vector gravityUp, ChairFollowerConfig chairConfig)
		{
			IChairSummonResult chairSummonResult = ChairSummonEvaluator.CreateSummonResult();
			chairSummonResult.Yaw = playerActorComp.ActorRotationProxy.Yaw - chairConfig.ChairFrontYawOffset;
			Vector targetLoc = Vector.Create(playerActorComp.ActorLocationProxy);
			Vector vector = Vector.Create(playerActorComp.FloorLocation);
			ChairSummonEvaluator.FillDownRayGeometry(chairSummonResult, chairSummonResult.Yaw, vector, gravityUp, chairConfig);
			Vector vector2;
			string text = this.CheckGroundByDownRays(playerActorComp, chairEntity, gravityUp, chairConfig, chairSummonResult, chairConfig.CheckGroundMobility, out vector2);
			if (text != null)
			{
				chairSummonResult.FailReason = text;
				return chairSummonResult;
			}
			Vector vector3 = Vector.Create(vector2);
			vector3.SubtractionEqual(vector);
			float num = (float)vector3.DotProduct(gravityUp);
			if (num > chairConfig.MaxSummonHeightUp)
			{
				chairSummonResult.FailReason = "落点比玩家高出过多(防坐下卡点)";
				return chairSummonResult;
			}
			if (num < -chairConfig.MaxSummonHeightDown)
			{
				chairSummonResult.FailReason = "落点比玩家低出过多(悬崖下/深坑)";
				return chairSummonResult;
			}
			string text2 = this.CheckWaterDepth(playerActorComp, chairEntity, targetLoc, vector2, gravityUp, chairConfig);
			if (text2 != null)
			{
				chairSummonResult.FailReason = text2;
				return chairSummonResult;
			}
			if (this.IsTraceTypeBoxBlocked(playerActorComp, chairEntity, vector2, gravityUp, chairConfig))
			{
				chairSummonResult.FailReason = "椅子占用空间被阻挡(TraceType)";
				return chairSummonResult;
			}
			if (this.IsObjectTypeBoxBlocked(playerActorComp, chairEntity, vector2, gravityUp, chairConfig))
			{
				chairSummonResult.FailReason = "椅子占用空间被阻挡(ObjectType)";
				return chairSummonResult;
			}
			if (this.IsProfileBoxBlocked(playerActorComp, chairEntity, vector2, gravityUp, chairConfig))
			{
				chairSummonResult.FailReason = "椅子占用空间被阻挡(Profile)";
				return chairSummonResult;
			}
			Vector vector4 = Vector.Create(vector2);
			Vector vector5 = Vector.Create(gravityUp);
			vector5.MultiplyEqual((double)chairConfig.SummonHeightOffset);
			vector4.AdditionEqual(vector5);
			chairSummonResult.FinalLocation.Set(vector4.X, vector4.Y, vector4.Z);
			chairSummonResult.Success = true;
			return chairSummonResult;
		}

		// Token: 0x0601CE24 RID: 118308 RVA: 0x008D2DA8 File Offset: 0x008D0FA8
		[return: Nullable(2)]
		private string CheckWaterDepth(CharacterActorComponent playerActorComp, Entity chairEntity, Vector targetLoc, Vector realGround, Vector gravityUp, ChairFollowerConfig chairConfig)
		{
			if (chairConfig.MaxWaterDepth <= 0f)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[ChairSummonEvaluator] MaxWaterDepth 小于等于 0,跳过水深检测";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MaxWaterDepth", chairConfig.MaxWaterDepth);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			FKuroPerfSightHelper.BeginExtTag("ChairSummon.Trace.Water");
			UTraceLineElement utraceLineElement;
			if ((utraceLineElement = this.WaterLineElement) == null)
			{
				utraceLineElement = (this.WaterLineElement = new UTraceLineElement());
			}
			UTraceLineElement utraceLineElement2 = utraceLineElement;
			utraceLineElement2.WorldContextObject = GlobalData.World;
			utraceLineElement2.bIsSingle = true;
			utraceLineElement2.bIgnoreSelf = true;
			utraceLineElement2.bIsProfile = false;
			utraceLineElement2.SetTraceTypeQuery(KuroTraceTypeQuery.Water);
			ChairSummonEvaluator.ApplyDebugDrawSettings(utraceLineElement2);
			utraceLineElement2.ActorsToIgnore.Empty(true);
			utraceLineElement2.ActorsToIgnore.Add(playerActorComp.Actor);
			List<AActor> list = ChairSummonEvaluator.CollectChairIgnoreActors(chairEntity);
			for (int i = 0; i < list.Count; i++)
			{
				utraceLineElement2.ActorsToIgnore.Add(list[i]);
			}
			Vector vector = Vector.Create(gravityUp);
			vector.MultiplyEqual((double)playerActorComp.ScaledHalfHeight);
			vector.AdditionEqual(targetLoc);
			Vector vector2 = Vector.Create(gravityUp);
			vector2.MultiplyEqual(-1.0);
			vector2.AdditionEqual(realGround);
			TraceElementCommon.Instance.SetStartLocation(utraceLineElement2, vector);
			TraceElementCommon.Instance.SetEndLocation(utraceLineElement2, vector2);
			bool flag = TraceElementCommon.Instance.LineTrace(utraceLineElement2, "ChairSummon.Water");
			UKuroHitResult hitResult = utraceLineElement2.HitResult;
			string result = null;
			if (flag && hitResult != null && hitResult.bBlockingHit)
			{
				Vector vector3 = Vector.Create();
				TraceElementCommon.Instance.GetHitLocation(hitResult, 0, vector3);
				vector3.SubtractionEqual(realGround);
				if (vector3.DotProduct(gravityUp) > (double)chairConfig.MaxWaterDepth)
				{
					result = "水深超过椅子召唤上限";
				}
			}
			utraceLineElement2.ClearCacheData(true);
			FKuroPerfSightHelper.EndExtTag("ChairSummon.Trace.Water");
			return result;
		}

		// Token: 0x0601CE25 RID: 118309 RVA: 0x008D2F67 File Offset: 0x008D1167
		private static IChairSummonResult CreateSummonResult()
		{
			return new ChairSummonResult
			{
				Success = false,
				FailReason = "",
				FinalLocation = Vector.Create(),
				Yaw = 0f,
				DownRayLines = new List<ValueTuple<Vector, Vector>>()
			};
		}

		// Token: 0x0601CE26 RID: 118310 RVA: 0x008D2FA1 File Offset: 0x008D11A1
		private static Vector ComputeBoxCenter(Vector realGround, Vector gravityUp, ChairFollowerConfig chairConfig)
		{
			Vector vector = Vector.Create(gravityUp);
			vector.MultiplyEqual((double)(chairConfig.SummonHeightOffset + chairConfig.BoxCenterOffsetZ));
			vector.AdditionEqual(realGround);
			return vector;
		}

		// Token: 0x0601CE27 RID: 118311 RVA: 0x008D2FC8 File Offset: 0x008D11C8
		private static void FillDownRayGeometry(IChairSummonResult result, float chairYaw, Vector groundRef, Vector gravityUp, ChairFollowerConfig chairConfig)
		{
			double num = (double)chairYaw * 3.141592653589793 / 180.0;
			double num2 = Math.Cos(num);
			double num3 = Math.Sin(num);
			Vector inV = Vector.Create(num2, num3, 0.0);
			Vector inV2 = Vector.Create(-num3, num2, 0.0);
			float num4 = chairConfig.SummonHeightOffset + chairConfig.BoxCenterOffsetZ + chairConfig.BoxHalfSizeZ;
			float groundProbeDepth = chairConfig.GroundProbeDepth;
			ValueTuple<int, int>[] fivePointSigns = ChairSummonEvaluator.FivePointSigns;
			result.DownRayLines.Clear();
			foreach (ValueTuple<int, int> valueTuple in fivePointSigns)
			{
				int item = valueTuple.Item1;
				int item2 = valueTuple.Item2;
				Vector vector = Vector.Create(groundRef);
				if (item != 0 || item2 != 0)
				{
					Vector vector2 = Vector.Create(inV);
					vector2.MultiplyEqual((double)((float)item * chairConfig.BoxHalfSizeX));
					Vector vector3 = Vector.Create(inV2);
					vector3.MultiplyEqual((double)((float)item2 * chairConfig.BoxHalfSizeY));
					vector.AdditionEqual(vector2);
					vector.AdditionEqual(vector3);
				}
				Vector vector4 = Vector.Create(gravityUp);
				vector4.MultiplyEqual((double)num4);
				vector4.AdditionEqual(vector);
				Vector vector5 = Vector.Create(gravityUp);
				vector5.MultiplyEqual((double)(-(double)groundProbeDepth));
				vector5.AdditionEqual(vector);
				result.DownRayLines.Add(new ValueTuple<Vector, Vector>(vector4, vector5));
			}
		}

		// Token: 0x0601CE28 RID: 118312 RVA: 0x008D312C File Offset: 0x008D132C
		[return: Nullable(2)]
		private string CheckGroundByDownRays(CharacterActorComponent playerActorComp, Entity chairEntity, Vector gravityUp, ChairFollowerConfig chairConfig, IChairSummonResult result, bool checkGroundMobility, out Vector centerHitLocation)
		{
			FKuroPerfSightHelper.BeginExtTag("ChairSummon.Trace.DownRay");
			UTraceLineElement utraceLineElement;
			if ((utraceLineElement = this.DownRayLineElement) == null)
			{
				utraceLineElement = (this.DownRayLineElement = new UTraceLineElement());
			}
			UTraceLineElement utraceLineElement2 = utraceLineElement;
			utraceLineElement2.WorldContextObject = GlobalData.World;
			utraceLineElement2.bIsSingle = true;
			utraceLineElement2.bIgnoreSelf = true;
			utraceLineElement2.bIsProfile = false;
			utraceLineElement2.SetTraceTypeQuery(KuroTraceTypeQuery.Visible);
			ChairSummonEvaluator.ApplyDebugDrawSettings(utraceLineElement2);
			List<AActor> list = ChairSummonEvaluator.CollectChairIgnoreActors(chairEntity);
			float num = float.PositiveInfinity;
			float num2 = float.NegativeInfinity;
			string text = null;
			centerHitLocation = Vector.Create();
			List<ValueTuple<Vector, Vector>> downRayLines = result.DownRayLines;
			for (int i = 0; i < downRayLines.Count; i++)
			{
				ValueTuple<Vector, Vector> valueTuple = downRayLines[i];
				Vector item = valueTuple.Item1;
				Vector item2 = valueTuple.Item2;
				utraceLineElement2.ActorsToIgnore.Empty(true);
				utraceLineElement2.ActorsToIgnore.Add(playerActorComp.Actor);
				foreach (AActor value in list)
				{
					utraceLineElement2.ActorsToIgnore.Add(value);
				}
				TraceElementCommon.Instance.SetStartLocation(utraceLineElement2, item);
				TraceElementCommon.Instance.SetEndLocation(utraceLineElement2, item2);
				bool flag = TraceElementCommon.Instance.LineTrace(utraceLineElement2, "ChairSummon.DownRay");
				UKuroHitResult hitResult = utraceLineElement2.HitResult;
				if (!flag || (hitResult == null || !hitResult.bBlockingHit))
				{
					utraceLineElement2.ClearCacheData(true);
					text = "向下五点射线: 存在未命中地面的点(悬空)";
					break;
				}
				if (checkGroundMobility)
				{
					UPrimitiveComponent uprimitiveComponent = (hitResult != null) ? hitResult.Components.Get(0).Get() : null;
					if (uprimitiveComponent != null && uprimitiveComponent.Mobility == EComponentMobility.Movable)
					{
						utraceLineElement2.ClearCacheData(true);
						text = "向下五点射线: 地面为可移动物体(Movable)";
						break;
					}
				}
				Vector vector = Vector.Create();
				TraceElementCommon.Instance.GetHitLocation(hitResult, 0, vector);
				if (i == 0)
				{
					centerHitLocation.Set(vector.X, vector.Y, vector.Z);
				}
				float num3 = (float)vector.DotProduct(gravityUp);
				if (num3 < num)
				{
					num = num3;
				}
				if (num3 > num2)
				{
					num2 = num3;
				}
				utraceLineElement2.ClearCacheData(false);
			}
			if (text == null && num2 - num > chairConfig.GroundFlatTolerance)
			{
				text = "向下五点射线: 地面不平整(五点高度差过大)";
			}
			utraceLineElement2.ClearCacheData(true);
			FKuroPerfSightHelper.EndExtTag("ChairSummon.Trace.DownRay");
			return text;
		}

		// Token: 0x0601CE29 RID: 118313 RVA: 0x008D3378 File Offset: 0x008D1578
		private static List<AActor> CollectChairIgnoreActors(Entity chairEntity)
		{
			List<AActor> list = new List<AActor>();
			BaseActorComponent component = chairEntity.GetComponent<BaseActorComponent>();
			AActor aactor = (component != null) ? component.Owner : null;
			if (aactor != null && aactor.IsValid())
			{
				list.Add(aactor);
			}
			SceneItemActorComponent component2 = chairEntity.GetComponent<SceneItemActorComponent>();
			TArray<AActor> tarray = (component2 != null) ? component2.GetAllActorsInSceneInteractionLevel() : null;
			if (tarray == null)
			{
				return list;
			}
			for (int i = 0; i < tarray.Num(); i++)
			{
				AActor aactor2 = tarray.Get(i);
				if (aactor2 != null && aactor2.IsValid())
				{
					list.Add(aactor2);
				}
			}
			return list;
		}

		// Token: 0x0601CE2A RID: 118314 RVA: 0x008D33F8 File Offset: 0x008D15F8
		private bool IsTraceTypeBoxBlocked(CharacterActorComponent playerActorComp, Entity chairEntity, Vector realGround, Vector gravityUp, ChairFollowerConfig chairConfig)
		{
			if (!chairConfig.EnableBlockTraceCheck)
			{
				return false;
			}
			FKuroPerfSightHelper.BeginExtTag("ChairSummon.Trace.BlockTrace");
			UTraceBoxElement utraceBoxElement;
			if ((utraceBoxElement = this.TraceTypeBoxElement) == null)
			{
				utraceBoxElement = (this.TraceTypeBoxElement = new UTraceBoxElement());
			}
			UTraceBoxElement utraceBoxElement2 = utraceBoxElement;
			utraceBoxElement2.WorldContextObject = GlobalData.World;
			utraceBoxElement2.bIsSingle = true;
			utraceBoxElement2.bIgnoreSelf = true;
			utraceBoxElement2.bIsProfile = false;
			utraceBoxElement2.bTraceComplex = false;
			utraceBoxElement2.SetTraceTypeQuery(chairConfig.BlockCheckTraceType);
			ChairSummonEvaluator.ApplyDebugDrawSettings(utraceBoxElement2);
			bool result;
			try
			{
				ChairSummonEvaluator.ConfigureBlockBoxElement(utraceBoxElement2, playerActorComp, chairEntity, realGround, gravityUp, chairConfig);
				result = ChairSummonEvaluator.HasBlockingActor(utraceBoxElement2, playerActorComp.Actor, chairEntity, "ChairSummon.BlockTraceBox");
			}
			finally
			{
				utraceBoxElement2.ClearCacheData(true);
				FKuroPerfSightHelper.EndExtTag("ChairSummon.Trace.BlockTrace");
			}
			return result;
		}

		// Token: 0x0601CE2B RID: 118315 RVA: 0x008D34B4 File Offset: 0x008D16B4
		private bool IsObjectTypeBoxBlocked(CharacterActorComponent playerActorComp, Entity chairEntity, Vector realGround, Vector gravityUp, ChairFollowerConfig chairConfig)
		{
			if (!chairConfig.EnableBlockObjectCheck)
			{
				return false;
			}
			if (chairConfig.BlockCheckObjectTypes.Length == 0)
			{
				Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CK, "[ChairSummonEvaluator] 已开启ObjectType检测,但BlockCheckObjectTypes为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			FKuroPerfSightHelper.BeginExtTag("ChairSummon.Trace.BlockObject");
			UTraceBoxElement utraceBoxElement;
			if ((utraceBoxElement = this.ObjectTypeBoxElement) == null)
			{
				utraceBoxElement = (this.ObjectTypeBoxElement = new UTraceBoxElement());
			}
			UTraceBoxElement utraceBoxElement2 = utraceBoxElement;
			utraceBoxElement2.WorldContextObject = GlobalData.World;
			utraceBoxElement2.bIsSingle = true;
			utraceBoxElement2.bIgnoreSelf = true;
			utraceBoxElement2.bIsProfile = false;
			utraceBoxElement2.bTraceComplex = false;
			TArray<TEnumAsByte<EObjectTypeQuery>> tarray = new TArray<TEnumAsByte<EObjectTypeQuery>>();
			foreach (EObjectTypeQuery value in chairConfig.BlockCheckObjectTypes)
			{
				tarray.Add(value);
			}
			utraceBoxElement2.SetObjectTypesQuery(ref tarray);
			ChairSummonEvaluator.ApplyDebugDrawSettings(utraceBoxElement2);
			bool result;
			try
			{
				ChairSummonEvaluator.ConfigureBlockBoxElement(utraceBoxElement2, playerActorComp, chairEntity, realGround, gravityUp, chairConfig);
				result = ChairSummonEvaluator.HasBlockingActor(utraceBoxElement2, playerActorComp.Actor, chairEntity, "ChairSummon.BlockObjectBox");
			}
			finally
			{
				utraceBoxElement2.ClearCacheData(true);
				FKuroPerfSightHelper.EndExtTag("ChairSummon.Trace.BlockObject");
			}
			return result;
		}

		// Token: 0x0601CE2C RID: 118316 RVA: 0x008D35CC File Offset: 0x008D17CC
		private bool IsProfileBoxBlocked(CharacterActorComponent playerActorComp, Entity chairEntity, Vector realGround, Vector gravityUp, ChairFollowerConfig chairConfig)
		{
			if (!chairConfig.EnableBlockProfileCheck)
			{
				return false;
			}
			FKuroPerfSightHelper.BeginExtTag("ChairSummon.Trace.BlockProfile");
			bool result;
			try
			{
				Vector boxPosition = ChairSummonEvaluator.ComputeBoxCenter(realGround, gravityUp, chairConfig);
				float yaw = playerActorComp.ActorRotationProxy.Yaw - chairConfig.ChairFrontYawOffset;
				TArray<AActor> tarray = new TArray<AActor>();
				tarray.Add(playerActorComp.Actor);
				foreach (AActor value in ChairSummonEvaluator.CollectChairIgnoreActors(chairEntity))
				{
					tarray.Add(value);
				}
				result = OverlapTestUtils.BoxOverlapAnyTestByProfile(GlobalData.World, boxPosition, new FVector(chairConfig.BoxHalfSizeX, chairConfig.BoxHalfSizeY, chairConfig.BoxHalfSizeZ), Rotator.Create(0f, yaw, 0f).ToUeRotator(), chairConfig.BlockCheckProfileName, false, tarray, "ChairSummon.BlockProfileBox");
			}
			finally
			{
				FKuroPerfSightHelper.EndExtTag("ChairSummon.Trace.BlockProfile");
			}
			return result;
		}

		// Token: 0x0601CE2D RID: 118317 RVA: 0x008D36CC File Offset: 0x008D18CC
		private static void ConfigureBlockBoxElement(UTraceBoxElement element, CharacterActorComponent playerActorComp, Entity chairEntity, Vector realGround, Vector gravityUp, ChairFollowerConfig chairConfig)
		{
			Vector inV = ChairSummonEvaluator.ComputeBoxCenter(realGround, gravityUp, chairConfig);
			element.ActorsToIgnore.Empty(true);
			element.ActorsToIgnore.Add(playerActorComp.Actor);
			List<AActor> list = ChairSummonEvaluator.CollectChairIgnoreActors(chairEntity);
			for (int i = 0; i < list.Count; i++)
			{
				element.ActorsToIgnore.Add(list[i]);
			}
			element.HalfSizeX = chairConfig.BoxHalfSizeX;
			element.HalfSizeY = chairConfig.BoxHalfSizeY;
			element.HalfSizeZ = chairConfig.BoxHalfSizeZ;
			Vector vector = Vector.Create(gravityUp);
			vector.MultiplyEqual(0.5);
			Vector vector2 = Vector.Create(inV);
			vector2.AdditionEqual(vector);
			Vector vector3 = Vector.Create(inV);
			vector3.SubtractionEqual(vector);
			TraceElementCommon.Instance.SetStartLocation(element, vector2);
			TraceElementCommon.Instance.SetEndLocation(element, vector3);
			float yaw = playerActorComp.ActorRotationProxy.Yaw - chairConfig.ChairFrontYawOffset;
			TraceElementCommon.Instance.SetBoxOrientation(element, Rotator.Create(0f, yaw, 0f));
		}

		// Token: 0x0601CE2E RID: 118318 RVA: 0x008D37DC File Offset: 0x008D19DC
		private static bool HasBlockingActor(UTraceBoxElement element, AActor playerActor, Entity chairEntity, string traceKey)
		{
			bool flag = TraceElementCommon.Instance.BoxTrace(element, traceKey);
			UKuroHitResult hitResult = element.HitResult;
			if (!flag || (hitResult == null || !hitResult.bBlockingHit))
			{
				return false;
			}
			int hitCount = hitResult.GetHitCount();
			List<AActor> list = ChairSummonEvaluator.CollectChairIgnoreActors(chairEntity);
			bool result = false;
			for (int i = 0; i < hitCount; i++)
			{
				AActor aactor = hitResult.Actors.Get(i).Get();
				if (aactor != null && aactor != playerActor && !list.Contains(aactor))
				{
					result = true;
					if (!ChairSummonEvaluator.DebugDraw)
					{
						break;
					}
					ChairSummonEvaluator.LogHitActorCollisionResponses(traceKey, hitResult, i);
				}
			}
			return result;
		}

		// Token: 0x0601CE2F RID: 118319 RVA: 0x008D3870 File Offset: 0x008D1A70
		private unsafe static void LogHitActorCollisionResponses(string traceKey, UKuroHitResult hitResult, int hitIndex)
		{
			AActor aactor = hitResult.Actors.Get(hitIndex).Get();
			UPrimitiveComponent uprimitiveComponent = hitResult.Components.Get(hitIndex).Get();
			if (aactor == null || uprimitiveComponent == null)
			{
				return;
			}
			int num = hitResult.ItemArray.Get(hitIndex);
			FBodyInstance bodyInstance = UKuroCollisionLibrary.GetBodyInstance(hitResult, hitIndex);
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			for (int i = 0; i < 33; i++)
			{
				ECollisionChannel ecollisionChannel = (ECollisionChannel)i;
				string item = Enum.GetName<ECollisionChannel>(ecollisionChannel) ?? i.ToString();
				switch (UKuroCollisionLibrary.GetCollisionResponseToChannel(uprimitiveComponent, ecollisionChannel, num))
				{
				case ECollisionResponse.ECR_Ignore:
					list3.Add(item);
					break;
				case ECollisionResponse.ECR_Overlap:
					list2.Add(item);
					break;
				case ECollisionResponse.ECR_Block:
					list.Add(item);
					break;
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[ChairSummonEvaluator] 椅子占用空间检测命中Actor";
			<>y__InlineArray12<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray12<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TraceKey", traceKey);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Actor", aactor);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ActorName", aactor.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ActorClass", aactor.GetClass().GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("Component", uprimitiveComponent);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("ComponentName", uprimitiveComponent.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("HitItem", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("CollisionEnabled", bodyInstance.CollisionEnabled);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("CollisionObjectType", bodyInstance.ObjectType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 9) = new ValueTuple<string, object>("BlockChannels", string.Join(",", list));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 10) = new ValueTuple<string, object>("OverlapChannels", string.Join(",", list2));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 11) = new ValueTuple<string, object>("IgnoreChannels", string.Join(",", list3));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 12));
		}

		// Token: 0x0601CE30 RID: 118320 RVA: 0x008D3AE0 File Offset: 0x008D1CE0
		public void StopDebugDraw()
		{
			UTraceLineElement waterLineElement = this.WaterLineElement;
			if (waterLineElement != null)
			{
				waterLineElement.SetDrawDebugTrace(EDrawDebugTrace.None);
			}
			UTraceLineElement downRayLineElement = this.DownRayLineElement;
			if (downRayLineElement != null)
			{
				downRayLineElement.SetDrawDebugTrace(EDrawDebugTrace.None);
			}
			UTraceBoxElement traceTypeBoxElement = this.TraceTypeBoxElement;
			if (traceTypeBoxElement != null)
			{
				traceTypeBoxElement.SetDrawDebugTrace(EDrawDebugTrace.None);
			}
			UTraceBoxElement objectTypeBoxElement = this.ObjectTypeBoxElement;
			if (objectTypeBoxElement == null)
			{
				return;
			}
			objectTypeBoxElement.SetDrawDebugTrace(EDrawDebugTrace.None);
		}

		// Token: 0x0601CE31 RID: 118321 RVA: 0x008D3B34 File Offset: 0x008D1D34
		[NullableContext(2)]
		private static void ApplyDebugDrawSettings(UTraceBaseElement element)
		{
			if (element == null)
			{
				return;
			}
			if (!ChairSummonEvaluator.DebugDraw)
			{
				element.SetDrawDebugTrace(EDrawDebugTrace.None);
				return;
			}
			if (ChairSummonEvaluator.DebugDrawDuration < 0f)
			{
				element.SetDrawDebugTrace(EDrawDebugTrace.Persistent);
				return;
			}
			element.DrawTime = ChairSummonEvaluator.DebugDrawDuration;
			element.SetDrawDebugTrace(EDrawDebugTrace.ForDuration);
		}

		// Token: 0x0601CE32 RID: 118322 RVA: 0x008D3B70 File Offset: 0x008D1D70
		public void Dispose()
		{
			this.StopDebugDraw();
			UTraceLineElement waterLineElement = this.WaterLineElement;
			if (waterLineElement != null)
			{
				waterLineElement.Dispose();
			}
			this.WaterLineElement = null;
			UTraceLineElement downRayLineElement = this.DownRayLineElement;
			if (downRayLineElement != null)
			{
				downRayLineElement.Dispose();
			}
			this.DownRayLineElement = null;
			UTraceBoxElement traceTypeBoxElement = this.TraceTypeBoxElement;
			if (traceTypeBoxElement != null)
			{
				traceTypeBoxElement.Dispose();
			}
			this.TraceTypeBoxElement = null;
			UTraceBoxElement objectTypeBoxElement = this.ObjectTypeBoxElement;
			if (objectTypeBoxElement != null)
			{
				objectTypeBoxElement.Dispose();
			}
			this.ObjectTypeBoxElement = null;
		}

		// Token: 0x0400F382 RID: 62338
		private const string TRACE_KEY_DOWN_RAY = "ChairSummon.DownRay";

		// Token: 0x0400F383 RID: 62339
		private const string TRACE_KEY_WATER = "ChairSummon.Water";

		// Token: 0x0400F384 RID: 62340
		private const string TRACE_KEY_BLOCK_TRACE_BOX = "ChairSummon.BlockTraceBox";

		// Token: 0x0400F385 RID: 62341
		private const string TRACE_KEY_BLOCK_OBJECT_BOX = "ChairSummon.BlockObjectBox";

		// Token: 0x0400F386 RID: 62342
		private const string TRACE_KEY_BLOCK_PROFILE_BOX = "ChairSummon.BlockProfileBox";

		// Token: 0x0400F387 RID: 62343
		private const float BLOCK_BOX_TRACE_HALF_DISTANCE = 0.5f;

		// Token: 0x0400F388 RID: 62344
		private const float WATER_PROBE_END_TOLERANCE = 1f;

		// Token: 0x0400F389 RID: 62345
		private const string PERF_TAG_EVALUATE = "ChairSummon.Evaluate";

		// Token: 0x0400F38A RID: 62346
		private const string PERF_TAG_DOWN_RAY = "ChairSummon.Trace.DownRay";

		// Token: 0x0400F38B RID: 62347
		private const string PERF_TAG_WATER = "ChairSummon.Trace.Water";

		// Token: 0x0400F38C RID: 62348
		private const string PERF_TAG_BLOCK_TRACE = "ChairSummon.Trace.BlockTrace";

		// Token: 0x0400F38D RID: 62349
		private const string PERF_TAG_BLOCK_OBJECT = "ChairSummon.Trace.BlockObject";

		// Token: 0x0400F38E RID: 62350
		private const string PERF_TAG_BLOCK_PROFILE = "ChairSummon.Trace.BlockProfile";

		// Token: 0x0400F38F RID: 62351
		[Nullable(new byte[]
		{
			1,
			0
		})]
		[StaticVariableRuleIgnore]
		private static readonly ValueTuple<int, int>[] FivePointSigns = new ValueTuple<int, int>[]
		{
			new ValueTuple<int, int>(0, 0),
			new ValueTuple<int, int>(1, 1),
			new ValueTuple<int, int>(1, -1),
			new ValueTuple<int, int>(-1, 1),
			new ValueTuple<int, int>(-1, -1)
		};

		// Token: 0x0400F390 RID: 62352
		[Nullable(2)]
		private UTraceLineElement DownRayLineElement;

		// Token: 0x0400F391 RID: 62353
		[Nullable(2)]
		private UTraceBoxElement ObjectTypeBoxElement;

		// Token: 0x0400F392 RID: 62354
		[Nullable(2)]
		private UTraceBoxElement TraceTypeBoxElement;

		// Token: 0x0400F393 RID: 62355
		[Nullable(2)]
		private UTraceLineElement WaterLineElement;
	}
}
