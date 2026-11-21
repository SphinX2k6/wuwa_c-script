using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem.Jigsaw;
using CSharpScript.Game.Render;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02006237 RID: 25143
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemLevitateMagnetComponent : EntityComponent, IStaticVariableResetter
	{
		// Token: 0x0603C90E RID: 248078 RVA: 0x01158517 File Offset: 0x01156717
		static SceneItemLevitateMagnetComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneItemLevitateMagnetComponent.CreateStaticDefaultValue), new Action(SceneItemLevitateMagnetComponent.ResetStaticDefaultValue));
		}

		// Token: 0x0603C90F RID: 248079 RVA: 0x0115854F File Offset: 0x0115674F
		public static void CreateStaticDefaultValue()
		{
			SceneItemLevitateMagnetComponent.TraceDebug = false;
		}

		// Token: 0x0603C910 RID: 248080 RVA: 0x01158557 File Offset: 0x01156757
		public static void ResetStaticDefaultValue()
		{
			SceneItemLevitateMagnetComponent.TraceDebug = false;
		}

		// Token: 0x0603C911 RID: 248081 RVA: 0x01158560 File Offset: 0x01156760
		protected override bool OnInitData(IEntityArgs args = null)
		{
			LevitateMagnetComponent config = args.GetP1<CreateEntityData>().GetParam<SceneItemLevitateMagnetComponent>() as LevitateMagnetComponent;
			this.Config = config;
			BaseInfoComponent baseInfo = base.Entity.GetComponent<CreatureDataComponent>().GetBaseInfo();
			this.OnlineType = baseInfo.OnlineInteractType;
			return true;
		}

		// Token: 0x0603C912 RID: 248082 RVA: 0x011585A4 File Offset: 0x011567A4
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			this.MoveComp = base.Entity.GetComponent<SceneItemMoveComponent>();
			this.HitComp = base.Entity.GetComponent<SceneItemHitComponent>();
			this.HitComp.RegisterComponent(this, null);
			this.ItemComp = base.Entity.GetComponent<SceneItemJigsawItemComponent>();
			this.TagComp = base.Entity.GetComponent<LevelTagComponent>();
			this.TagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.悬浮磁石.磁石.静止"]));
			this.TagComp.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["关卡.Common.状态.静默"], new BaseTagComponent.TTagSwitchedCallback(this.OnSilent), null);
			if (!this.TagComp.ContainsTag(GameplayTagUtils.GetGameplayTagById(GameplayTagDefine.EGameplayTagId["关卡.Common.状态.静默"]).Value))
			{
				EventSystem.Instance.AddWithTarget<HitInformation>(this, EEventName.OnSceneItemHitByHitData, new Action<HitInformation>(this.OnHit));
				EventSystem.Instance.AddWithTarget<HitInformation>(base.Entity, EEventName.OnSceneItemEntityHitAlways, new Action<HitInformation>(this.OnHitAlways));
			}
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.InitBoxTrace));
			this.DisableKey = base.Disable("[SceneItemHitMoveComp]初始化关闭Tick");
			return true;
		}

		// Token: 0x0603C913 RID: 248083 RVA: 0x011586F8 File Offset: 0x011568F8
		protected override bool OnEnd()
		{
			this.TagComp.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["关卡.Common.状态.静默"], new BaseTagComponent.TTagSwitchedCallback(this.OnSilent));
			if (EventSystem.Instance.HasWithTarget<HitInformation>(this, EEventName.OnSceneItemHitByHitData, new Action<HitInformation>(this.OnHit)))
			{
				EventSystem.Instance.RemoveWithTarget<HitInformation>(this, EEventName.OnSceneItemHitByHitData, new Action<HitInformation>(this.OnHit));
			}
			if (EventSystem.Instance.HasWithTarget<HitInformation>(base.Entity, EEventName.OnSceneItemEntityHitAlways, new Action<HitInformation>(this.OnHitAlways)))
			{
				EventSystem.Instance.RemoveWithTarget<HitInformation>(base.Entity, EEventName.OnSceneItemEntityHitAlways, new Action<HitInformation>(this.OnHitAlways));
			}
			if (EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.InitBoxTrace)))
			{
				EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnSceneInteractionLoadCompleted, new Action(this.InitBoxTrace));
			}
			return true;
		}

		// Token: 0x0603C914 RID: 248084 RVA: 0x011587F4 File Offset: 0x011569F4
		protected override void OnTick(float delta)
		{
			if (this.MoveComp.IsMoving)
			{
				return;
			}
			this.DisableKey = base.Disable("[SceneItemHitMoveComp]运动结束关闭Tick");
			SceneItemJigsawItemComponent itemComp = this.ItemComp;
			if (itemComp != null && itemComp.Valid)
			{
				this.ItemComp.OnMove(this.TargetIndex);
			}
			this.RemoveMovingTags();
			this.TagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.悬浮磁石.磁石.静止"]));
		}

		// Token: 0x0603C915 RID: 248085 RVA: 0x0115886C File Offset: 0x01156A6C
		[NullableContext(1)]
		private void OnHitAlways(HitInformation hitData)
		{
			int id = hitData.Attacker.Id;
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			int? num;
			if (baseCharacter == null)
			{
				num = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				num = ((characterActorComponent != null) ? new int?(characterActorComponent.Entity.Id) : null);
			}
			int? num2 = num;
			if (!(id == num2.GetValueOrDefault() & num2 != null))
			{
				return;
			}
			LevelGamePlayController.Instance.MultiplayerLimitTypeCheck(this.OnlineType, true);
		}

		// Token: 0x0603C916 RID: 248086 RVA: 0x011588E4 File Offset: 0x01156AE4
		[NullableContext(1)]
		private void OnHit(HitInformation hitData)
		{
			if (this.MoveComp.IsMoving)
			{
				return;
			}
			SceneItemActorComponent actorComp = this.ActorComp;
			if (actorComp == null || !actorComp.IsAutonomousProxy)
			{
				return;
			}
			if (GameModeModel.Instance.IsMulti)
			{
				switch (this.OnlineType)
				{
				case EOnlineInteractType.HostOnly:
				{
					SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)hitData.Attacker.Id, new GetTeamItemOptions
					{
						ParamType = ETeamParamType.EntityId
					});
					if (teamItem != null && !teamItem.IsMyRole())
					{
						return;
					}
					if (!hitData.Attacker.GetComponent<CharacterActorComponent>().IsAutonomousProxy)
					{
						return;
					}
					break;
				}
				case EOnlineInteractType.NoOne:
					return;
				}
			}
			Vector actorLocationProxy = hitData.Attacker.GetComponent<BaseActorComponent>().ActorLocationProxy;
			Vector vector = Vector.Create();
			this.ActorComp.ActorLocationProxy.Subtraction(actorLocationProxy, vector);
			vector.Normalize(9.99999993922529E-09);
			SceneItemJigsawItemComponent itemComp = this.ItemComp;
			if (itemComp != null && itemComp.Valid)
			{
				ValueTuple<bool, Vector, JigsawIndex> value = this.ItemComp.GetNextMoveTargetOnHit(vector).Value;
				bool item = value.Item1;
				Vector item2 = value.Item2;
				JigsawIndex item3 = value.Item3;
				if (item)
				{
					double num = Vector.Dist2D(item2, this.ActorComp.ActorLocationProxy) / (double)this.Config.MoveSpeed;
					this.MoveComp.AddMoveTarget(new SceneItemMoveComponent.MoveTarget(item2, (float)num, 0f, -1f, -1f));
					this.TargetIndex = item3;
					base.Enable(new int?(this.DisableKey), "SceneItemLevitateMagnetComponent.OnHit");
					this.ItemComp.RemoveMagnetTipsTag();
					this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.悬浮磁石.磁石.静止"]));
					this.AddMovingTagByDirection(vector);
				}
			}
		}

		// Token: 0x0603C917 RID: 248087 RVA: 0x01158A9C File Offset: 0x01156C9C
		private void OnSilent(int tagId, bool tagExist)
		{
			if (tagExist)
			{
				EventSystem.Instance.RemoveWithTarget<HitInformation>(this, EEventName.OnSceneItemHitByHitData, new Action<HitInformation>(this.OnHit));
				EventSystem.Instance.RemoveWithTarget<HitInformation>(base.Entity, EEventName.OnSceneItemEntityHitAlways, new Action<HitInformation>(this.OnHitAlways));
			}
		}

		// Token: 0x0603C918 RID: 248088 RVA: 0x01158AEC File Offset: 0x01156CEC
		[NullableContext(1)]
		private unsafe void AddMovingTagByDirection(Vector direction)
		{
			Vector vector = Vector.Create(direction);
			Vector vector2 = Vector.Create(this.ActorComp.ActorUpProxy);
			vector2.Normalize(9.99999993922529E-09);
			Vector vector3 = Vector.Create();
			double inB = direction.DotProduct(vector2);
			vector2.Multiply(inB, vector3);
			vector.SubtractionEqual(vector3);
			vector.Normalize(9.99999993922529E-09);
			Vector vector4 = Vector.Create(0.0, 0.0, 0.0);
			this.ActorComp.ActorQuatProxy.RotateVector(Vector.BackwardVectorProxy, vector4);
			Vector vector5 = Vector.Create(0.0, 0.0, 0.0);
			this.ActorComp.ActorQuatProxy.RotateVector(Vector.LeftVectorProxy, vector5);
			<>y__InlineArray4<ValueTuple<Vector, int>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<Vector, int>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<Vector, int>>, ValueTuple<Vector, int>>(ref <>y__InlineArray, 0) = new ValueTuple<Vector, int>(this.ActorComp.ActorForwardProxy, GameplayTagDefine.EGameplayTagId["关卡.Common.表现.悬浮磁石.磁石.移动.前"]);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<Vector, int>>, ValueTuple<Vector, int>>(ref <>y__InlineArray, 1) = new ValueTuple<Vector, int>(this.ActorComp.ActorRightProxy, GameplayTagDefine.EGameplayTagId["关卡.Common.表现.悬浮磁石.磁石.移动.右"]);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<Vector, int>>, ValueTuple<Vector, int>>(ref <>y__InlineArray, 2) = new ValueTuple<Vector, int>(vector4, GameplayTagDefine.EGameplayTagId["关卡.Common.表现.悬浮磁石.磁石.移动.后"]);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<Vector, int>>, ValueTuple<Vector, int>>(ref <>y__InlineArray, 3) = new ValueTuple<Vector, int>(vector5, GameplayTagDefine.EGameplayTagId["关卡.Common.表现.悬浮磁石.磁石.移动.左"]);
			Span<ValueTuple<Vector, int>> span = <PrivateImplementationDetails>.InlineArrayAsSpan<<>y__InlineArray4<ValueTuple<Vector, int>>, ValueTuple<Vector, int>>(ref <>y__InlineArray, 4);
			for (int i = 0; i < span.Length; i++)
			{
				ValueTuple<Vector, int> valueTuple = *span[i];
				if (MathUtils.Instance.DotProduct(vector, valueTuple.Item1) > SceneItemLevitateMagnetComponent.COS_45)
				{
					this.TagComp.AddTag(new int?(valueTuple.Item2));
					return;
				}
			}
		}

		// Token: 0x0603C919 RID: 248089 RVA: 0x01158CCC File Offset: 0x01156ECC
		private void RemoveMovingTags()
		{
			this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.悬浮磁石.磁石.移动.前"]));
			this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.悬浮磁石.磁石.移动.后"]));
			this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.悬浮磁石.磁石.移动.左"]));
			this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.悬浮磁石.磁石.移动.右"]));
		}

		// Token: 0x0603C91A RID: 248090 RVA: 0x01158D5C File Offset: 0x01156F5C
		private void InitBoxTrace()
		{
			this.BoxTrace = new UTraceBoxElement();
			this.BoxTrace.WorldContextObject = this.ActorComp.Owner;
			this.BoxTrace.bIsSingle = true;
			this.BoxTrace.bIgnoreSelf = true;
			this.BoxTrace.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStatic);
			this.BoxTrace.AddObjectTypeQuery(KuroObjectTypeQuery.WorldDynamic);
			this.BoxTrace.AddObjectTypeQuery(KuroObjectTypeQuery.PawnMonster);
			this.BoxTrace.AddObjectTypeQuery(KuroObjectTypeQuery.Destructible);
			this.BoxTrace.DrawTime = 0.5f;
			this.MainActor = SceneInteractionManager.Get().GetMainCollisionActor(this.ActorComp.GetSceneInteractionLevelHandleId());
			TArray<AActor> sceneInteractionAllActorsInLevel = SceneInteractionManager.Get().GetSceneInteractionAllActorsInLevel(this.ActorComp.GetSceneInteractionLevelHandleId());
			for (int i = 0; i < sceneInteractionAllActorsInLevel.Num(); i++)
			{
				this.BoxTrace.ActorsToIgnore.Add(sceneInteractionAllActorsInLevel.Get(i));
			}
			this.OffsetHeight = (float)(this.MainActor.D_K2_GetActorLocation().Z - this.ActorComp.ActorLocationProxy.Z);
			Vector vector = Vector.Create();
			SceneItemActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.ActorUpProxy.Multiply((double)this.OffsetHeight, vector);
			}
			Vector lastLoc = this.LastLoc;
			SceneItemActorComponent actorComp2 = this.ActorComp;
			lastLoc.DeepCopy(((actorComp2 != null) ? actorComp2.ActorLocationProxy : null) ?? Vector.ZeroVectorProxy);
			this.LastLoc.AdditionEqual(vector);
			FRotator actorRotation = this.ActorComp.ActorRotation;
			this.ActorComp.SetActorRotation(Rotator.ZeroRotator, "unknown", true);
			FVectorDouble fvectorDouble = new FVectorDouble();
			this.MainActor.D_GetActorBounds(false, ref fvectorDouble, ref this.Extent, false);
			TraceElementCommon.Instance.SetBoxHalfSize(this.BoxTrace, this.Extent);
			TraceElementCommon.Instance.SetStartLocation(this.BoxTrace, this.LastLoc);
			TraceElementCommon.Instance.SetBoxOrientation(this.BoxTrace, actorRotation);
			this.ActorComp.SetActorRotation(actorRotation, "unknown", true);
		}

		// Token: 0x0603C91B RID: 248091 RVA: 0x01158F6C File Offset: 0x0115716C
		[NullableContext(1)]
		public void UpdateBoxTrace(SceneItemJigsawBaseComponent baseComp, JigsawIndex socketIndex)
		{
			if (this.BoxTrace == null)
			{
				return;
			}
			AActor mainCollisionActor = SceneInteractionManager.Get().GetMainCollisionActor(this.ActorComp.GetSceneInteractionLevelHandleId());
			Vector vector = Vector.Create(baseComp.GetBlockLocationByIndex(socketIndex, true));
			Vector vector2 = Vector.Create();
			SceneItemActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.ActorUpProxy.Multiply((double)this.OffsetHeight, vector2);
			}
			if (vector != null)
			{
				vector.AdditionEqual(vector2);
			}
			Rotator rotator = Rotator.Create(this.ActorComp.ActorRotation);
			this.ActorComp.SetActorRotation(Rotator.ZeroRotator, "unknown", true);
			FVectorDouble fvectorDouble = new FVectorDouble();
			mainCollisionActor.D_GetActorBounds(false, ref fvectorDouble, ref this.Extent, false);
			TraceElementCommon.Instance.SetBoxHalfSize(this.BoxTrace, this.Extent);
			TraceElementCommon.Instance.SetStartLocation(this.BoxTrace, vector);
			TraceElementCommon.Instance.SetBoxOrientation(this.BoxTrace, rotator);
			this.ActorComp.SetActorRotation(rotator.ToUeRotator(), "unknown", true);
			Vector lastLoc = this.LastLoc;
			FVectorDouble fvectorDouble2 = this.MainActor.D_K2_GetActorLocation();
			lastLoc.DeepCopy(fvectorDouble2);
		}

		// Token: 0x0603C91C RID: 248092 RVA: 0x01159088 File Offset: 0x01157288
		[NullableContext(1)]
		public bool StartBoxTrace(Vector end)
		{
			if (this.BoxTrace == null)
			{
				return false;
			}
			if (SceneItemLevitateMagnetComponent.TraceDebug)
			{
				this.BoxTrace.SetDrawDebugTrace(EDrawDebugTrace.ForDuration);
			}
			Vector vector = Vector.Create(this.LastLoc);
			Vector vector2 = Vector.Create(end);
			vector2.SubtractionEqual(vector);
			Vector vector3 = Vector.Create(vector2);
			Vector vector4 = Vector.Create(this.ActorComp.ActorUpProxy);
			vector4.Normalize(9.99999993922529E-09);
			Vector vector5 = Vector.Create();
			double inB = vector3.DotProduct(vector4);
			vector4.Multiply(inB, vector5);
			vector3.SubtractionEqual(vector5);
			Vector vector6 = Vector.Create(vector);
			vector6.AdditionEqual(vector3);
			TraceElementCommon.Instance.SetEndLocation(this.BoxTrace, vector6);
			return TraceElementCommon.Instance.BoxTrace(this.BoxTrace, "[SceneItemLevitateMagnetComponent.StartBoxTrace]");
		}

		// Token: 0x0603C91D RID: 248093 RVA: 0x0115914C File Offset: 0x0115734C
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemLevitateMagnetComponent sceneItemLevitateMagnetComponent = (SceneItemLevitateMagnetComponent)componentTemplate;
			if (sceneItemLevitateMagnetComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			if (sceneItemLevitateMagnetComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (sceneItemLevitateMagnetComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
			{
				return false;
			}
			if (sceneItemLevitateMagnetComponent.HitComp == null)
			{
				this.HitComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.HitComp), "HitComp"))
			{
				return false;
			}
			if (sceneItemLevitateMagnetComponent.ItemComp == null)
			{
				this.ItemComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ItemComp), "ItemComp"))
			{
				return false;
			}
			if (sceneItemLevitateMagnetComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			if (sceneItemLevitateMagnetComponent.TargetIndex == null)
			{
				this.TargetIndex = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TargetIndex), "TargetIndex"))
			{
				return false;
			}
			this.DisableKey = sceneItemLevitateMagnetComponent.DisableKey;
			if (sceneItemLevitateMagnetComponent.BoxTrace == null)
			{
				this.BoxTrace = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BoxTrace), "BoxTrace"))
			{
				return false;
			}
			this.OnlineType = sceneItemLevitateMagnetComponent.OnlineType;
			this.Extent = sceneItemLevitateMagnetComponent.Extent;
			this.OffsetHeight = sceneItemLevitateMagnetComponent.OffsetHeight;
			if (sceneItemLevitateMagnetComponent.MainActor == null)
			{
				this.MainActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MainActor), "MainActor"))
			{
				return false;
			}
			return sceneItemLevitateMagnetComponent.LastLoc == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastLoc), "LastLoc");
		}

		// Token: 0x1700727F RID: 29311
		// (get) Token: 0x0603C91E RID: 248094 RVA: 0x01159341 File Offset: 0x01157541
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007280 RID: 29312
		// (get) Token: 0x0603C91F RID: 248095 RVA: 0x01159344 File Offset: 0x01157544
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007281 RID: 29313
		// (get) Token: 0x0603C920 RID: 248096 RVA: 0x01159347 File Offset: 0x01157547
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040201A7 RID: 131495
		[StaticVariableRuleIgnore]
		private static readonly double COS_45 = Math.Cos(0.7853981633974483);

		// Token: 0x040201A8 RID: 131496
		public LevitateMagnetComponent Config;

		// Token: 0x040201A9 RID: 131497
		private SceneItemActorComponent ActorComp;

		// Token: 0x040201AA RID: 131498
		private SceneItemMoveComponent MoveComp;

		// Token: 0x040201AB RID: 131499
		private SceneItemHitComponent HitComp;

		// Token: 0x040201AC RID: 131500
		private SceneItemJigsawItemComponent ItemComp;

		// Token: 0x040201AD RID: 131501
		private LevelTagComponent TagComp;

		// Token: 0x040201AE RID: 131502
		private JigsawIndex TargetIndex;

		// Token: 0x040201AF RID: 131503
		private int DisableKey = -1;

		// Token: 0x040201B0 RID: 131504
		private UTraceBoxElement BoxTrace;

		// Token: 0x040201B1 RID: 131505
		private EOnlineInteractType OnlineType;

		// Token: 0x040201B2 RID: 131506
		private FVector Extent = new FVector();

		// Token: 0x040201B3 RID: 131507
		public static bool TraceDebug = false;

		// Token: 0x040201B4 RID: 131508
		private float OffsetHeight;

		// Token: 0x040201B5 RID: 131509
		private AActor MainActor;

		// Token: 0x040201B6 RID: 131510
		[Nullable(1)]
		private readonly Vector LastLoc = Vector.Create();
	}
}
