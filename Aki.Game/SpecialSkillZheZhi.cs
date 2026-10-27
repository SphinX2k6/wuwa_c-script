using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol.Summon;
using CSharpScript.Game;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x020031A0 RID: 12704
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillZheZhi : SpecialSkillBase
{
	// Token: 0x0601B5EB RID: 112107 RVA: 0x0077B128 File Offset: 0x00779328
	public SpecialSkillZheZhi(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601B5EC RID: 112108 RVA: 0x0077B160 File Offset: 0x00779360
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

	// Token: 0x0601B5ED RID: 112109 RVA: 0x0077B341 File Offset: 0x00779541
	public override void OnDisable()
	{
		this.ClearSelectTargetState();
	}

	// Token: 0x0601B5EE RID: 112110 RVA: 0x0077B349 File Offset: 0x00779549
	public override void OnEnd()
	{
		this.ClearSelectTargetState();
		this.HeInRangeSet.Clear();
		this.HeEntityMap.Clear();
		this.IsInit = false;
	}

	// Token: 0x0601B5EF RID: 112111 RVA: 0x0077B36E File Offset: 0x0077956E
	public override void OnTick(float delta)
	{
		if (!this.IsInit)
		{
			return;
		}
		this.UpdateTargetHe();
	}

	// Token: 0x0601B5F0 RID: 112112 RVA: 0x0077B380 File Offset: 0x00779580
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

	// Token: 0x0601B5F1 RID: 112113 RVA: 0x0077B594 File Offset: 0x00779794
	private void UpdateScreenSize()
	{
		if (Global.CharacterController != null)
		{
			Global.CharacterController.GetViewportSize(ref this.SizeX, ref this.SizeY);
		}
	}

	// Token: 0x0601B5F2 RID: 112114 RVA: 0x0077B5B4 File Offset: 0x007797B4
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

	// Token: 0x0601B5F3 RID: 112115 RVA: 0x0077B668 File Offset: 0x00779868
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

	// Token: 0x0601B5F4 RID: 112116 RVA: 0x0077B6D8 File Offset: 0x007798D8
	private void SetMarkCue(EntityHandle targetEntityHandle)
	{
		CharacterGameplayCueComponent component = targetEntityHandle.Entity.GetComponent<CharacterGameplayCueComponent>();
		this.MarkCueHandle = component.AddCue(1105001040L, null);
		this.MarkCue = (component.GetCueByHandle((long)this.MarkCueHandle) as GameplayCueEffect);
	}

	// Token: 0x0601B5F5 RID: 112117 RVA: 0x0077B724 File Offset: 0x00779924
	private void SetLineCue(EntityHandle targetEntityHandle)
	{
		CharacterGameplayCueComponent component = this.ZheZhiEntity.GetComponent<CharacterGameplayCueComponent>();
		this.LineCueHandle = component.AddCue(1105001041L, new GameplayCueParam?(new GameplayCueParam
		{
			Instigator = targetEntityHandle
		}));
	}

	// Token: 0x0601B5F6 RID: 112118 RVA: 0x0077B768 File Offset: 0x00779968
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

	// Token: 0x0601B5F7 RID: 112119 RVA: 0x0077B7FC File Offset: 0x007799FC
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

	// Token: 0x0400D657 RID: 54871
	private const int HE_MAX_COUNT = 3;

	// Token: 0x0400D658 RID: 54872
	private const float HE_ACTIVE_DIS = 3000f;

	// Token: 0x0400D659 RID: 54873
	private const string BLACKBOARD_KEY = "FlyTargetHe";

	// Token: 0x0400D65A RID: 54874
	private static readonly int activeTag = GameplayTagDefine.EGameplayTagId["角色.R2T1ZhezhiMd10011.状态.飞鹤可触发"];

	// Token: 0x0400D65B RID: 54875
	private const long MARK_CUE_ID = 1105001040L;

	// Token: 0x0400D65C RID: 54876
	private const long LINE_CUE_ID = 1105001041L;

	// Token: 0x0400D65D RID: 54877
	[Nullable(2)]
	private Entity ZheZhiEntity;

	// Token: 0x0400D65E RID: 54878
	[Nullable(2)]
	private CharacterActorComponent ActorComponent;

	// Token: 0x0400D65F RID: 54879
	private readonly Dictionary<int, EntityHandle> HeEntityMap = new Dictionary<int, EntityHandle>();

	// Token: 0x0400D660 RID: 54880
	private readonly HashSet<EntityHandle> HeInRangeSet = new HashSet<EntityHandle>();

	// Token: 0x0400D661 RID: 54881
	[Nullable(2)]
	private BaseTagComponent TagComponent;

	// Token: 0x0400D662 RID: 54882
	[Nullable(2)]
	private GameplayCueEffect MarkCue;

	// Token: 0x0400D663 RID: 54883
	private int MarkCueHandle;

	// Token: 0x0400D664 RID: 54884
	private bool LastMarkCueVisiblity;

	// Token: 0x0400D665 RID: 54885
	private int LineCueHandle;

	// Token: 0x0400D666 RID: 54886
	private int CurSelectHePos;

	// Token: 0x0400D667 RID: 54887
	private bool IsInit;

	// Token: 0x0400D668 RID: 54888
	private FVector2D ResultPositionRef = new FVector2D();

	// Token: 0x0400D669 RID: 54889
	private readonly Vector2D ViewPortCenter = Vector2D.Create();

	// Token: 0x0400D66A RID: 54890
	private int SizeX;

	// Token: 0x0400D66B RID: 54891
	private int SizeY;
}
