using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol.Summon;
using CSharpScript.Game;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x0200270E RID: 9998
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillZheZhi : SpecialSkillBase
{
	// Token: 0x0601910B RID: 102667 RVA: 0x007A33B4 File Offset: 0x007A15B4
	public SpecialSkillZheZhi(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601910C RID: 102668 RVA: 0x007A33EC File Offset: 0x007A15EC
	public unsafe override void OnStart()
	{
		this.ZheZhiEntity = this.SpecialSkillComponent.Entity;
		this.ActorComponent = this.ZheZhiEntity.GetComponent<CharacterActorComponent>();
		CreatureDataComponent component = this.ZheZhiEntity.GetComponent<CreatureDataComponent>();
		if (component.GetPlayerId() != CreatureModel.Instance.GetPlayerId())
		{
			return;
		}
		this.TagComponent = this.ZheZhiEntity.GetComponent<BaseTagComponent>();
		for (int i = 1; i < 4; i++)
		{
			EntityHandle customEntity = PhantomUtil.GetSummonedEntity(this.ZheZhiEntity, ESummonType.ConcomitantCustom, i);
			EntityHandle customEntity2 = customEntity;
			if (customEntity2 == null || !customEntity2.Valid)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.YZ;
				string message = "折枝伴生物初始化失败";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CurGetPosition", i);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ZhezhiEntityId", this.ZheZhiEntity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ZhezhiCreatureDataId", (component != null) ? new long?(component.GetCreatureDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("CustomServerEntityIds", (component != null) ? component.CustomServerEntityIds : null);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return;
			}
			this.HeEntityMap[i] = customEntity;
			PawnSensoryInfoComponent component2 = customEntity.Entity.GetComponent<PawnSensoryInfoComponent>();
			component2.SetLogicRange(3000f);
			float enterDistance = 3000f;
			WorldEntity entity = customEntity.Entity;
			component2.CreatePerceptionEvent(enterDistance, (entity != null) ? entity.GameBudgetManagedToken : 0U, delegate
			{
				this.HeInRangeSet.Add(customEntity);
			}, delegate
			{
				if (this.HeInRangeSet.Contains(customEntity))
				{
					this.HeInRangeSet.Remove(customEntity);
				}
			}, null, null, -1f, null);
		}
		this.IsInit = true;
	}

	// Token: 0x0601910D RID: 102669 RVA: 0x007A35CD File Offset: 0x007A17CD
	public override void OnDisable()
	{
		this.ClearSelectTargetState();
	}

	// Token: 0x0601910E RID: 102670 RVA: 0x007A35D5 File Offset: 0x007A17D5
	public override void OnEnd()
	{
		this.ClearSelectTargetState();
		this.HeInRangeSet.Clear();
		this.HeEntityMap.Clear();
		this.IsInit = false;
	}

	// Token: 0x0601910F RID: 102671 RVA: 0x007A35FA File Offset: 0x007A17FA
	public override void OnTick(float delta)
	{
		if (!this.IsInit)
		{
			return;
		}
		this.UpdateTargetHe();
	}

	// Token: 0x06019110 RID: 102672 RVA: 0x007A360C File Offset: 0x007A180C
	private void UpdateTargetHe()
	{
		double num = double.MaxValue;
		int num2 = 0;
		double num3 = double.MaxValue;
		int num4 = 0;
		this.UpdateScreenSize();
		foreach (KeyValuePair<int, EntityHandle> keyValuePair in this.HeEntityMap)
		{
			int num5;
			EntityHandle entityHandle;
			keyValuePair.Deconstruct(out num5, out entityHandle);
			int num6 = num5;
			EntityHandle entityHandle2 = entityHandle;
			WorldEntity entity = entityHandle2.Entity;
			BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			if (entity != null && entity.Active && this.HeInRangeSet.Contains(entityHandle2) && baseTagComponent != null && baseTagComponent.HasTag(SpecialSkillZheZhi.activeTag))
			{
				CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
				APlayerController characterController = Global.CharacterController;
				FVectorDouble fvectorDouble = component.ActorLocationProxy.ToUeVector(false);
				bool flag = UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble, ref this.ResultPositionRef, true);
				FVector2D resultPositionRef = this.ResultPositionRef;
				if (flag && resultPositionRef.X > 0f && resultPositionRef.X < (float)this.SizeX && resultPositionRef.Y > 0f && resultPositionRef.Y < (float)this.SizeY)
				{
					this.ViewPortCenter.Set((double)(resultPositionRef.X - (float)this.SizeX / 2f), (double)((resultPositionRef.Y - (float)this.SizeY / 2f) / 10f));
					double num7 = this.ViewPortCenter.SizeSquared();
					if (num7 < num)
					{
						num2 = num6;
						num = num7;
					}
				}
				else
				{
					double num8 = Vector.DistSquared(component.ActorLocationProxy, this.ActorComponent.ActorLocationProxy);
					if (num8 < num3)
					{
						num4 = num6;
						num3 = num8;
					}
				}
			}
		}
		int num9 = (num2 > 0) ? num2 : num4;
		if (num9 == 0 && this.CurSelectHePos != 0)
		{
			this.ClearSelectTargetState();
		}
		if (num9 == 0)
		{
			return;
		}
		if (this.CurSelectHePos == num9)
		{
			this.UpdateSelectMark();
			return;
		}
		this.UpdateSelectEffect(num9);
	}

	// Token: 0x06019111 RID: 102673 RVA: 0x007A3820 File Offset: 0x007A1A20
	private void UpdateScreenSize()
	{
		if (Global.CharacterController != null)
		{
			Global.CharacterController.GetViewportSize(ref this.SizeX, ref this.SizeY);
		}
	}

	// Token: 0x06019112 RID: 102674 RVA: 0x007A3840 File Offset: 0x007A1A40
	private void UpdateSelectEffect(int newIndex)
	{
		EntityHandle entityHandle;
		if (this.HeEntityMap.TryGetValue(newIndex, out entityHandle))
		{
			this.ClearAllCues();
			this.SetMarkCue(entityHandle);
			this.SetLineCue(entityHandle);
			BlackboardController.Instance.SetIntValueByEntity(this.ZheZhiEntity.Id, "FlyTargetHe", entityHandle.Entity.Id);
		}
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent == null || !tagComponent.HasTag(SpecialSkillZheZhi.activeTag))
		{
			BaseTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 != null)
			{
				tagComponent2.AddTag(new int?(SpecialSkillZheZhi.activeTag));
			}
		}
		CharacterSkillComponent component = this.ZheZhiEntity.GetComponent<CharacterSkillComponent>();
		if (component != null && component.Valid)
		{
			component.CallAnimBreakPoint();
		}
		this.CurSelectHePos = newIndex;
	}

	// Token: 0x06019113 RID: 102675 RVA: 0x007A38F4 File Offset: 0x007A1AF4
	private void ClearSelectTargetState()
	{
		if (this.CurSelectHePos == 0)
		{
			return;
		}
		BlackboardController.Instance.SetIntValueByEntity(this.ZheZhiEntity.Id, "FlyTargetHe", 0);
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null && tagComponent.HasTag(SpecialSkillZheZhi.activeTag))
		{
			this.TagComponent.RemoveTag(new int?(SpecialSkillZheZhi.activeTag));
		}
		this.ClearAllCues();
		this.CurSelectHePos = 0;
	}

	// Token: 0x06019114 RID: 102676 RVA: 0x007A3964 File Offset: 0x007A1B64
	private void SetMarkCue(EntityHandle targetEntityHandle)
	{
		CharacterGameplayCueComponent component = targetEntityHandle.Entity.GetComponent<CharacterGameplayCueComponent>();
		this.MarkCueHandle = component.AddCue(1105001040L, null);
		this.MarkCue = (component.GetCueByHandle((long)this.MarkCueHandle) as GameplayCueEffect);
	}

	// Token: 0x06019115 RID: 102677 RVA: 0x007A39B0 File Offset: 0x007A1BB0
	private void SetLineCue(EntityHandle targetEntityHandle)
	{
		CharacterGameplayCueComponent component = this.ZheZhiEntity.GetComponent<CharacterGameplayCueComponent>();
		this.LineCueHandle = component.AddCue(1105001041L, new GameplayCueParam?(new GameplayCueParam
		{
			Instigator = targetEntityHandle
		}));
	}

	// Token: 0x06019116 RID: 102678 RVA: 0x007A39F4 File Offset: 0x007A1BF4
	private void UpdateSelectMark()
	{
		if (this.MarkCue == null || !EffectSystem.Instance.IsValid(this.MarkCue.EffectViewHandle))
		{
			return;
		}
		AActor sureEffectActor = EffectSystem.Instance.GetSureEffectActor(this.MarkCue.EffectViewHandle);
		if (sureEffectActor != null && sureEffectActor.IsValid())
		{
			bool flag = sureEffectActor.WasRecentlyRenderedOnScreen(0.2f);
			if (!this.LastMarkCueVisiblity && flag)
			{
				EffectSystem instance = EffectSystem.Instance;
				int effectViewHandle = this.MarkCue.EffectViewHandle;
				string reason = "UpdateHeSelectMark";
				FTransformDouble? ftransformDouble = null;
				instance.ReplayEffect(effectViewHandle, reason, ftransformDouble);
			}
			this.LastMarkCueVisiblity = flag;
		}
	}

	// Token: 0x06019117 RID: 102679 RVA: 0x007A3A88 File Offset: 0x007A1C88
	private void ClearAllCues()
	{
		EntityHandle entityHandle;
		if (this.HeEntityMap.TryGetValue(this.CurSelectHePos, out entityHandle) && entityHandle.Valid)
		{
			CharacterGameplayCueComponent component = entityHandle.Entity.GetComponent<CharacterGameplayCueComponent>();
			if (this.MarkCueHandle != 0 && component != null)
			{
				component.RemoveCueByHandle((long)this.MarkCueHandle);
			}
			this.MarkCueHandle = 0;
			this.MarkCue = null;
		}
		Entity zheZhiEntity = this.ZheZhiEntity;
		CharacterGameplayCueComponent characterGameplayCueComponent = (zheZhiEntity != null) ? zheZhiEntity.GetComponent<CharacterGameplayCueComponent>() : null;
		if (this.LineCueHandle != 0 && characterGameplayCueComponent != null)
		{
			characterGameplayCueComponent.RemoveCueByHandle((long)this.LineCueHandle);
		}
		this.LineCueHandle = 0;
	}

	// Token: 0x0400DADA RID: 56026
	private const int HE_MAX_COUNT = 3;

	// Token: 0x0400DADB RID: 56027
	private const float HE_ACTIVE_DIS = 3000f;

	// Token: 0x0400DADC RID: 56028
	private const string BLACKBOARD_KEY = "FlyTargetHe";

	// Token: 0x0400DADD RID: 56029
	private static readonly int activeTag = GameplayTagDefine.EGameplayTagId["角色.R2T1ZhezhiMd10011.状态.飞鹤可触发"];

	// Token: 0x0400DADE RID: 56030
	private const long MARK_CUE_ID = 1105001040L;

	// Token: 0x0400DADF RID: 56031
	private const long LINE_CUE_ID = 1105001041L;

	// Token: 0x0400DAE0 RID: 56032
	[Nullable(2)]
	private Entity ZheZhiEntity;

	// Token: 0x0400DAE1 RID: 56033
	[Nullable(2)]
	private CharacterActorComponent ActorComponent;

	// Token: 0x0400DAE2 RID: 56034
	private readonly Dictionary<int, EntityHandle> HeEntityMap = new Dictionary<int, EntityHandle>();

	// Token: 0x0400DAE3 RID: 56035
	private readonly HashSet<EntityHandle> HeInRangeSet = new HashSet<EntityHandle>();

	// Token: 0x0400DAE4 RID: 56036
	[Nullable(2)]
	private BaseTagComponent TagComponent;

	// Token: 0x0400DAE5 RID: 56037
	[Nullable(2)]
	private GameplayCueEffect MarkCue;

	// Token: 0x0400DAE6 RID: 56038
	private int MarkCueHandle;

	// Token: 0x0400DAE7 RID: 56039
	private bool LastMarkCueVisiblity;

	// Token: 0x0400DAE8 RID: 56040
	private int LineCueHandle;

	// Token: 0x0400DAE9 RID: 56041
	private int CurSelectHePos;

	// Token: 0x0400DAEA RID: 56042
	private bool IsInit;

	// Token: 0x0400DAEB RID: 56043
	private FVector2D ResultPositionRef = new FVector2D();

	// Token: 0x0400DAEC RID: 56044
	private readonly Vector2D ViewPortCenter = Vector2D.Create();

	// Token: 0x0400DAED RID: 56045
	private int SizeX;

	// Token: 0x0400DAEE RID: 56046
	private int SizeY;
}
