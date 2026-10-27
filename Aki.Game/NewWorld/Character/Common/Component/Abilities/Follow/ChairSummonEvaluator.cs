using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;
using UnrealEngine;

namespace Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x020044C1 RID: 17601
	[NullableContext(1)]
	[Nullable(0)]
	public class ChairSummonEvaluator
	{
		// Token: 0x17007399 RID: 29593
		// (get) Token: 0x0602D5F5 RID: 185845 RVA: 0x00A3C2CA File Offset: 0x00A3A4CA
		// (set) Token: 0x0602D5F6 RID: 185846 RVA: 0x00A3C2D1 File Offset: 0x00A3A4D1
		[StaticVariableRuleIgnore]
		public static bool DebugDraw { get; set; }

		// Token: 0x1700739A RID: 29594
		// (get) Token: 0x0602D5F7 RID: 185847 RVA: 0x00A3C2D9 File Offset: 0x00A3A4D9
		// (set) Token: 0x0602D5F8 RID: 185848 RVA: 0x00A3C2E0 File Offset: 0x00A3A4E0
		[StaticVariableRuleIgnore]
		public static float DebugDrawDuration { get; private set; }

		// Token: 0x0602D5F9 RID: 185849 RVA: 0x00A3C2E8 File Offset: 0x00A3A4E8
		public static void SetDebugDraw(bool enable, float duration = 5f)
		{
			ChairSummonEvaluator.DebugDraw = enable;
			ChairSummonEvaluator.DebugDrawDuration = (enable ? duration : 0f);
		}

		// Token: 0x0602D5FA RID: 185850 RVA: 0x00A3C300 File Offset: 0x00A3A500
		public IChairSummonResult Evaluate(Entity chairEntity, ChairFollowerConfig chairConfig)
		{
			FKuroPerfSightHelper.BeginExtTag("ChairSummon.Evaluate");
			IChairSummonResult result = this.EvaluateInternal(chairEntity, chairConfig);
			FKuroPerfSightHelper.EndExtTag("ChairSummon.Evaluate");
			return result;
		}

		// Token: 0x0602D5FB RID: 185851 RVA: 0x00A3C320 File Offset: 0x00A3A520
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
			return this.CheckGroundByDownRays(characterActorComponent, chairEntity, vector, chairConfig, result, false);
		}

		// Token: 0x0602D5FC RID: 185852 RVA: 0x00A3C3F8 File Offset: 0x00A3A5F8
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

		// Token: 0x0602D5FD RID: 185853 RVA: 0x00A3C480 File Offset: 0x00A3A680
		private IChairSummonResult EvaluateAtPlayerLocation(Entity chairEntity, CharacterActorComponent playerActorComp, Vector gravityUp, ChairFollowerConfig chairConfig)
		{
			IChairSummonResult chairSummonResult = ChairSummonEvaluator.CreateSummonResult();
			chairSummonResult.Yaw = playerActorComp.ActorRotationProxy.Yaw - chairConfig.ChairFrontYawOffset;
			Vector vector = Vector.Create(playerActorComp.ActorLocationProxy);
			ValueTuple<bool, Vector> valueTuple = SkillBehaviorMisc.TraceGroundWithGravity(playerActorComp, vector, false, 2500f);
			bool item = valueTuple.Item1;
			Vector item2 = valueTuple.Item2;
			if (!item || item2 == null)
			{
				chairSummonResult.FailReason = "地检未命中地面";
				return chairSummonResult;
			}
			Vector vector2 = Vector.Create(item2);
			Vector vector3 = Vector.Create(gravityUp);
			vector3.MultiplyEqual((double)playerActorComp.ScaledHalfHeight);
			vector2.SubtractionEqual(vector3);
			Vector vector4 = Vector.Create(playerActorComp.ActorLocationProxy);
			vector4.SubtractionEqual(vector3);
			Vector vector5 = Vector.Create(vector2);
			vector5.SubtractionEqual(vector4);
			double num = vector5.DotProduct(gravityUp);
			if (num > (double)chairConfig.MaxSummonHeightUp)
			{
				chairSummonResult.FailReason = "落点比玩家高出过多(防坐下卡点)";
				return chairSummonResult;
			}
			if (num < (double)(-(double)chairConfig.MaxSummonHeightDown))
			{
				chairSummonResult.FailReason = "落点比玩家低出过多(悬崖下/深坑)";
				return chairSummonResult;
			}
			string text = this.CheckWaterDepth(playerActorComp, chairEntity, vector, vector2, gravityUp, chairConfig);
			if (text != null)
			{
				chairSummonResult.FailReason = text;
				return chairSummonResult;
			}
			ChairSummonEvaluator.FillDownRayGeometry(chairSummonResult, chairSummonResult.Yaw, vector2, gravityUp, chairConfig);
			string text2 = this.CheckGroundByDownRays(playerActorComp, chairEntity, gravityUp, chairConfig, chairSummonResult, chairConfig.CheckGroundMobility);
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
			Vector vector6 = Vector.Create(vector2);
			Vector vector7 = Vector.Create(gravityUp);
			vector7.MultiplyEqual((double)chairConfig.SummonHeightOffset);
			vector6.AdditionEqual(vector7);
			chairSummonResult.FinalLocation.Set(vector6.X, vector6.Y, vector6.Z);
			chairSummonResult.Success = true;
			return chairSummonResult;
		}

		// Token: 0x0602D5FE RID: 185854 RVA: 0x00A3C66C File Offset: 0x00A3A86C
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

		// Token: 0x0602D5FF RID: 185855 RVA: 0x00A3C82B File Offset: 0x00A3AA2B
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

		// Token: 0x0602D600 RID: 185856 RVA: 0x00A3C865 File Offset: 0x00A3AA65
		private static Vector ComputeBoxCenter(Vector realGround, Vector gravityUp, ChairFollowerConfig chairConfig)
		{
			Vector vector = Vector.Create(gravityUp);
			vector.MultiplyEqual((double)(chairConfig.SummonHeightOffset + chairConfig.BoxCenterOffsetZ));
			vector.AdditionEqual(realGround);
			return vector;
		}

		// Token: 0x0602D601 RID: 185857 RVA: 0x00A3C88C File Offset: 0x00A3AA8C
		private static void FillDownRayGeometry(IChairSummonResult result, float chairYaw, Vector realGround, Vector gravityUp, ChairFollowerConfig chairConfig)
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
				Vector vector = Vector.Create(realGround);
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

		// Token: 0x0602D602 RID: 185858 RVA: 0x00A3C9F0 File Offset: 0x00A3ABF0
		[return: Nullable(2)]
		private string CheckGroundByDownRays(CharacterActorComponent playerActorComp, Entity chairEntity, Vector gravityUp, ChairFollowerConfig chairConfig, IChairSummonResult result, bool checkGroundMobility)
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
			foreach (ValueTuple<Vector, Vector> valueTuple in result.DownRayLines)
			{
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

		// Token: 0x0602D603 RID: 185859 RVA: 0x00A3CC40 File Offset: 0x00A3AE40
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

		// Token: 0x0602D604 RID: 185860 RVA: 0x00A3CCC0 File Offset: 0x00A3AEC0
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

		// Token: 0x0602D605 RID: 185861 RVA: 0x00A3CD7C File Offset: 0x00A3AF7C
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

		// Token: 0x0602D606 RID: 185862 RVA: 0x00A3CE94 File Offset: 0x00A3B094
		private bool IsProfileBoxBlocked(CharacterActorComponent playerActorComp, Entity chairEntity, Vector realGround, Vector gravityUp, ChairFollowerConfig chairConfig)
		{
			if (!chairConfig.EnableBlockProfileCheck)
			{
				return false;
			}
			FKuroPerfSightHelper.BeginExtTag("ChairSummon.Trace.BlockProfile");
			UTraceBoxElement utraceBoxElement;
			if ((utraceBoxElement = this.ProfileBoxElement) == null)
			{
				utraceBoxElement = (this.ProfileBoxElement = new UTraceBoxElement());
			}
			UTraceBoxElement utraceBoxElement2 = utraceBoxElement;
			utraceBoxElement2.WorldContextObject = GlobalData.World;
			utraceBoxElement2.bIsSingle = true;
			utraceBoxElement2.bIgnoreSelf = true;
			utraceBoxElement2.bIsProfile = true;
			utraceBoxElement2.ProfileName = chairConfig.BlockCheckProfileName;
			utraceBoxElement2.bTraceComplex = false;
			ChairSummonEvaluator.ApplyDebugDrawSettings(utraceBoxElement2);
			bool result;
			try
			{
				ChairSummonEvaluator.ConfigureBlockBoxElement(utraceBoxElement2, playerActorComp, chairEntity, realGround, gravityUp, chairConfig);
				result = ChairSummonEvaluator.HasBlockingActor(utraceBoxElement2, playerActorComp.Actor, chairEntity, "ChairSummon.BlockProfileBox");
			}
			finally
			{
				utraceBoxElement2.ClearCacheData(true);
				FKuroPerfSightHelper.EndExtTag("ChairSummon.Trace.BlockProfile");
			}
			return result;
		}

		// Token: 0x0602D607 RID: 185863 RVA: 0x00A3CF50 File Offset: 0x00A3B150
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

		// Token: 0x0602D608 RID: 185864 RVA: 0x00A3D060 File Offset: 0x00A3B260
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

		// Token: 0x0602D609 RID: 185865 RVA: 0x00A3D0F4 File Offset: 0x00A3B2F4
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

		// Token: 0x0602D60A RID: 185866 RVA: 0x00A3D364 File Offset: 0x00A3B564
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
			if (objectTypeBoxElement != null)
			{
				objectTypeBoxElement.SetDrawDebugTrace(EDrawDebugTrace.None);
			}
			UTraceBoxElement profileBoxElement = this.ProfileBoxElement;
			if (profileBoxElement == null)
			{
				return;
			}
			profileBoxElement.SetDrawDebugTrace(EDrawDebugTrace.None);
		}

		// Token: 0x0602D60B RID: 185867 RVA: 0x00A3D3CA File Offset: 0x00A3B5CA
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

		// Token: 0x0602D60C RID: 185868 RVA: 0x00A3D408 File Offset: 0x00A3B608
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
			UTraceBoxElement profileBoxElement = this.ProfileBoxElement;
			if (profileBoxElement != null)
			{
				profileBoxElement.Dispose();
			}
			this.ProfileBoxElement = null;
		}

		// Token: 0x040183F8 RID: 99320
		private const string TRACE_KEY_DOWN_RAY = "ChairSummon.DownRay";

		// Token: 0x040183F9 RID: 99321
		private const string TRACE_KEY_WATER = "ChairSummon.Water";

		// Token: 0x040183FA RID: 99322
		private const string TRACE_KEY_BLOCK_TRACE_BOX = "ChairSummon.BlockTraceBox";

		// Token: 0x040183FB RID: 99323
		private const string TRACE_KEY_BLOCK_OBJECT_BOX = "ChairSummon.BlockObjectBox";

		// Token: 0x040183FC RID: 99324
		private const string TRACE_KEY_BLOCK_PROFILE_BOX = "ChairSummon.BlockProfileBox";

		// Token: 0x040183FD RID: 99325
		private const float BLOCK_BOX_TRACE_HALF_DISTANCE = 0.5f;

		// Token: 0x040183FE RID: 99326
		private const float WATER_PROBE_END_TOLERANCE = 1f;

		// Token: 0x040183FF RID: 99327
		private const string PERF_TAG_EVALUATE = "ChairSummon.Evaluate";

		// Token: 0x04018400 RID: 99328
		private const string PERF_TAG_DOWN_RAY = "ChairSummon.Trace.DownRay";

		// Token: 0x04018401 RID: 99329
		private const string PERF_TAG_WATER = "ChairSummon.Trace.Water";

		// Token: 0x04018402 RID: 99330
		private const string PERF_TAG_BLOCK_TRACE = "ChairSummon.Trace.BlockTrace";

		// Token: 0x04018403 RID: 99331
		private const string PERF_TAG_BLOCK_OBJECT = "ChairSummon.Trace.BlockObject";

		// Token: 0x04018404 RID: 99332
		private const string PERF_TAG_BLOCK_PROFILE = "ChairSummon.Trace.BlockProfile";

		// Token: 0x04018405 RID: 99333
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

		// Token: 0x04018406 RID: 99334
		[Nullable(2)]
		private UTraceLineElement DownRayLineElement;

		// Token: 0x04018407 RID: 99335
		[Nullable(2)]
		private UTraceBoxElement ObjectTypeBoxElement;

		// Token: 0x04018408 RID: 99336
		[Nullable(2)]
		private UTraceBoxElement ProfileBoxElement;

		// Token: 0x04018409 RID: 99337
		[Nullable(2)]
		private UTraceBoxElement TraceTypeBoxElement;

		// Token: 0x0401840A RID: 99338
		[Nullable(2)]
		private UTraceLineElement WaterLineElement;
	}
}
