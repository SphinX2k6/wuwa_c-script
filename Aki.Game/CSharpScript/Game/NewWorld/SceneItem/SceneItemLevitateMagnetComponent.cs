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
	// Token: 0x02007183 RID: 29059
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemLevitateMagnetComponent : EntityComponent, IStaticVariableResetter
	{
		// Token: 0x06047071 RID: 290929 RVA: 0x011FDE67 File Offset: 0x011FC067
		static SceneItemLevitateMagnetComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneItemLevitateMagnetComponent.CreateStaticDefaultValue), new Action(SceneItemLevitateMagnetComponent.ResetStaticDefaultValue));
		}

		// Token: 0x06047072 RID: 290930 RVA: 0x011FDE9F File Offset: 0x011FC09F
		public static void CreateStaticDefaultValue()
		{
			SceneItemLevitateMagnetComponent.TraceDebug = false;
		}

		// Token: 0x06047073 RID: 290931 RVA: 0x011FDEA7 File Offset: 0x011FC0A7
		public static void ResetStaticDefaultValue()
		{
			SceneItemLevitateMagnetComponent.TraceDebug = false;
		}

		// Token: 0x06047074 RID: 290932 RVA: 0x011FDEB0 File Offset: 0x011FC0B0
		protected override bool OnInitData(IEntityArgs args = null)
		{
			LevitateMagnetComponent config = args.GetP1<CreateEntityData>().GetParam<SceneItemLevitateMagnetComponent>() as LevitateMagnetComponent;
			this.Config = config;
			BaseInfoComponent baseInfo = base.Entity.GetComponent<CreatureDataComponent>().GetBaseInfo();
			this.OnlineType = baseInfo.OnlineInteractType;
			return true;
		}

		// Token: 0x06047075 RID: 290933 RVA: 0x011FDEF4 File Offset: 0x011FC0F4
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

		// Token: 0x06047076 RID: 290934 RVA: 0x011FE048 File Offset: 0x011FC248
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

		// Token: 0x06047077 RID: 290935 RVA: 0x011FE144 File Offset: 0x011FC344
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

		// Token: 0x06047078 RID: 290936 RVA: 0x011FE1BC File Offset: 0x011FC3BC
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

		// Token: 0x06047079 RID: 290937 RVA: 0x011FE234 File Offset: 0x011FC434
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

		// Token: 0x0604707A RID: 290938 RVA: 0x011FE3EC File Offset: 0x011FC5EC
		private void OnSilent(int tagId, bool tagExist)
		{
			if (tagExist)
			{
				EventSystem.Instance.RemoveWithTarget<HitInformation>(this, EEventName.OnSceneItemHitByHitData, new Action<HitInformation>(this.OnHit));
				EventSystem.Instance.RemoveWithTarget<HitInformation>(base.Entity, EEventName.OnSceneItemEntityHitAlways, new Action<HitInformation>(this.OnHitAlways));
			}
		}

		// Token: 0x0604707B RID: 290939 RVA: 0x011FE43C File Offset: 0x011FC63C
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

		// Token: 0x0604707C RID: 290940 RVA: 0x011FE61C File Offset: 0x011FC81C
		private void RemoveMovingTags()
		{
			this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.悬浮磁石.磁石.移动.前"]));
			this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.悬浮磁石.磁石.移动.后"]));
			this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.悬浮磁石.磁石.移动.左"]));
			this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.悬浮磁石.磁石.移动.右"]));
		}

		// Token: 0x0604707D RID: 290941 RVA: 0x011FE6AC File Offset: 0x011FC8AC
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

		// Token: 0x0604707E RID: 290942 RVA: 0x011FE8BC File Offset: 0x011FCABC
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

		// Token: 0x0604707F RID: 290943 RVA: 0x011FE9D8 File Offset: 0x011FCBD8
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

		// Token: 0x06047080 RID: 290944 RVA: 0x011FEA9C File Offset: 0x011FCC9C
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemLevitateMagnetComponent sceneItemLevitateMagnetComponent = (SceneItemLevitateMagnetComponent)componentTemplate;
			if (base.CanResetComponentProperty("Config"))
			{
				if (sceneItemLevitateMagnetComponent.Config == null)
				{
					this.Config = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<LevitateMagnetComponent>(this.Config), "Config"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (sceneItemLevitateMagnetComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MoveComp"))
			{
				if (sceneItemLevitateMagnetComponent.MoveComp == null)
				{
					this.MoveComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemMoveComponent>(this.MoveComp), "MoveComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("HitComp"))
			{
				if (sceneItemLevitateMagnetComponent.HitComp == null)
				{
					this.HitComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemHitComponent>(this.HitComp), "HitComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ItemComp"))
			{
				if (sceneItemLevitateMagnetComponent.ItemComp == null)
				{
					this.ItemComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemJigsawItemComponent>(this.ItemComp), "ItemComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TagComp"))
			{
				if (sceneItemLevitateMagnetComponent.TagComp == null)
				{
					this.TagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<LevelTagComponent>(this.TagComp), "TagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TargetIndex"))
			{
				if (sceneItemLevitateMagnetComponent.TargetIndex == null)
				{
					this.TargetIndex = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<JigsawIndex>(this.TargetIndex), "TargetIndex"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DisableKey"))
			{
				this.DisableKey = sceneItemLevitateMagnetComponent.DisableKey;
			}
			if (base.CanResetComponentProperty("BoxTrace"))
			{
				if (sceneItemLevitateMagnetComponent.BoxTrace == null)
				{
					this.BoxTrace = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceBoxElement>(this.BoxTrace), "BoxTrace"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("OnlineType"))
			{
				this.OnlineType = sceneItemLevitateMagnetComponent.OnlineType;
			}
			if (base.CanResetComponentProperty("Extent"))
			{
				this.Extent = sceneItemLevitateMagnetComponent.Extent;
			}
			if (base.CanResetComponentProperty("OffsetHeight"))
			{
				this.OffsetHeight = sceneItemLevitateMagnetComponent.OffsetHeight;
			}
			if (base.CanResetComponentProperty("MainActor"))
			{
				if (sceneItemLevitateMagnetComponent.MainActor == null)
				{
					this.MainActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.MainActor), "MainActor"))
				{
					return false;
				}
			}
			return !base.CanResetComponentProperty("LastLoc") || sceneItemLevitateMagnetComponent.LastLoc == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.LastLoc), "LastLoc");
		}

		// Token: 0x04025540 RID: 152896
		[StaticVariableRuleIgnore]
		private static readonly double COS_45 = Math.Cos(0.7853981633974483);

		// Token: 0x04025541 RID: 152897
		public LevitateMagnetComponent Config;

		// Token: 0x04025542 RID: 152898
		private SceneItemActorComponent ActorComp;

		// Token: 0x04025543 RID: 152899
		private SceneItemMoveComponent MoveComp;

		// Token: 0x04025544 RID: 152900
		private SceneItemHitComponent HitComp;

		// Token: 0x04025545 RID: 152901
		private SceneItemJigsawItemComponent ItemComp;

		// Token: 0x04025546 RID: 152902
		private LevelTagComponent TagComp;

		// Token: 0x04025547 RID: 152903
		private JigsawIndex TargetIndex;

		// Token: 0x04025548 RID: 152904
		private int DisableKey = -1;

		// Token: 0x04025549 RID: 152905
		private UTraceBoxElement BoxTrace;

		// Token: 0x0402554A RID: 152906
		private EOnlineInteractType OnlineType;

		// Token: 0x0402554B RID: 152907
		private FVector Extent = new FVector();

		// Token: 0x0402554C RID: 152908
		public static bool TraceDebug = false;

		// Token: 0x0402554D RID: 152909
		private float OffsetHeight;

		// Token: 0x0402554E RID: 152910
		private AActor MainActor;

		// Token: 0x0402554F RID: 152911
		[Nullable(1)]
		private readonly Vector LastLoc = Vector.Create();
	}
}
