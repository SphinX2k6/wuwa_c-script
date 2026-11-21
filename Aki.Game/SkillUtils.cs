using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020026D0 RID: 9936
[NullableContext(1)]
[Nullable(0)]
public class SkillUtils : IStaticVariableResetter
{
	// Token: 0x06018E30 RID: 101936 RVA: 0x00790722 File Offset: 0x0078E922
	static SkillUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SkillUtils.CreateStaticDefaultValue), new Action(SkillUtils.ResetStaticDefaultValue));
	}

	// Token: 0x06018E31 RID: 101937 RVA: 0x0079074C File Offset: 0x0078E94C
	public static ESkillGenre[] GetSkillGenres([Nullable(2)] SSkillInfo info)
	{
		if (info == null)
		{
			return Array.Empty<ESkillGenre>();
		}
		TArray<TEnumAsByte<ESkillGenre>> skillGenreGroup = info.SkillGenreGroup;
		if (skillGenreGroup != null && skillGenreGroup.Num() > 0)
		{
			ESkillGenre[] array = new ESkillGenre[skillGenreGroup.Num()];
			for (int i = 0; i < skillGenreGroup.Num(); i++)
			{
				array[i] = skillGenreGroup.Get(i);
			}
			return array;
		}
		return new ESkillGenre[]
		{
			info.SkillGenre
		};
	}

	// Token: 0x06018E32 RID: 101938 RVA: 0x007907C0 File Offset: 0x0078E9C0
	public static bool HasSkillGenre(SSkillInfo info, ESkillGenre genre)
	{
		TArray<TEnumAsByte<ESkillGenre>> skillGenreGroup = info.SkillGenreGroup;
		if (skillGenreGroup != null && skillGenreGroup.Num() > 0)
		{
			return skillGenreGroup.Contains(genre);
		}
		return info.SkillGenre == genre;
	}

	// Token: 0x06018E33 RID: 101939 RVA: 0x007907FC File Offset: 0x0078E9FC
	[NullableContext(2)]
	public static void GetSkillRotateDirect(EntityHandle entityHandle, SkillRotateTarget skillRotateTarget, AnimNotifyStateSkillRotateStyle skillRotateStyle, [Nullable(1)] global::Vector outVector)
	{
		outVector.Reset();
		if (entityHandle == null || !entityHandle.Valid || skillRotateTarget == null)
		{
			return;
		}
		BaseActorComponent component = entityHandle.Entity.GetComponent<BaseActorComponent>();
		if (component == null || !component.Valid)
		{
			return;
		}
		BaseSkillComponent component2 = entityHandle.Entity.GetComponent<BaseSkillComponent>();
		if (component2 == null || !component2.Valid)
		{
			return;
		}
		global::Vector actorLocationProxy = component.ActorLocationProxy;
		switch (skillRotateTarget.Type)
		{
		case ESkillRotateType.None:
			if (component2.SkillTarget != null && component2.SkillTarget.Valid)
			{
				BaseActorComponent target = component2.SkillTarget.Entity.CheckGetComponent<BaseActorComponent>();
				global::Vector currentSkillRotateTargetDirect = component2.GetCurrentSkillRotateTargetDirect(target, actorLocationProxy);
				outVector.DeepCopy(currentSkillRotateTargetDirect);
			}
			break;
		case ESkillRotateType.Location:
		{
			global::Vector targetVector = skillRotateTarget.TargetVector;
			if (targetVector != null)
			{
				SkillUtils.TmpVector.DeepCopy(targetVector);
				SkillUtils.TmpVector.SubtractionEqual(actorLocationProxy);
				outVector.DeepCopy(SkillUtils.TmpVector);
			}
			break;
		}
		case ESkillRotateType.Direct:
		{
			global::Vector targetVector2 = skillRotateTarget.TargetVector;
			if (targetVector2 != null)
			{
				outVector.DeepCopy(targetVector2);
			}
			break;
		}
		case ESkillRotateType.BlackBoardEntityId:
		case ESkillRotateType.BlackBoardInt:
		{
			int? num = null;
			if (skillRotateTarget.Type == ESkillRotateType.BlackBoardEntityId)
			{
				num = BlackboardController.Instance.GetEntityIdByEntity(entityHandle.Entity.Id, skillRotateTarget.TargetString);
			}
			else
			{
				num = BlackboardController.Instance.GetIntValueByEntity(entityHandle.Entity.Id, skillRotateTarget.TargetString);
			}
			if (num != null)
			{
				Entity entity = EntitySystem.Instance.Get(num.Value);
				BaseActorComponent baseActorComponent = (entity != null) ? entity.CheckGetComponent<BaseActorComponent>() : null;
				if (baseActorComponent != null && baseActorComponent.Valid)
				{
					SkillUtils.TmpVector.DeepCopy(baseActorComponent.ActorLocationProxy);
					SkillUtils.TmpVector.SubtractionEqual(actorLocationProxy);
					outVector.DeepCopy(SkillUtils.TmpVector);
				}
			}
			break;
		}
		case ESkillRotateType.BlackBoardLocation:
		{
			Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(entityHandle.Entity.Id, skillRotateTarget.TargetString);
			if (vectorValueByEntity != null)
			{
				SkillUtils.TmpVector.DeepCopy(vectorValueByEntity);
				SkillUtils.TmpVector.SubtractionEqual(actorLocationProxy);
				outVector.DeepCopy(SkillUtils.TmpVector);
			}
			break;
		}
		case ESkillRotateType.BlackBoardDirect:
		{
			Aki.Protocol.Vector vectorValueByEntity2 = BlackboardController.Instance.GetVectorValueByEntity(entityHandle.Entity.Id, skillRotateTarget.TargetString);
			if (vectorValueByEntity2 != null)
			{
				outVector.DeepCopy(vectorValueByEntity2);
			}
			break;
		}
		case ESkillRotateType.StandBy:
			outVector.DeepCopy(component.ActorForwardProxy);
			break;
		}
		if (skillRotateStyle != null)
		{
			if (skillRotateStyle.IsUseAnsRotateOffset && skillRotateStyle.AnsRotateOffset != 0f)
			{
				MathUtils.Instance.CommonTempRotator.Set(0f, skillRotateStyle.AnsRotateOffset, 0f);
				GravityUtils.Instance.ConvertToPlanarVectorForActor(component, outVector);
				GravityUtils.Instance.RotateDirectInGravityForActor(component, MathUtils.Instance.CommonTempRotator, outVector);
			}
			global::Vector actorForwardProxy = component.ActorForwardProxy;
			float angleOffsetInGravityAbsForActor = GravityUtils.Instance.GetAngleOffsetInGravityAbsForActor(component, outVector, actorForwardProxy);
			if (skillRotateStyle.IsPaused)
			{
				if (skillRotateStyle.ResumeRotateThreshold > 0f)
				{
					if (angleOffsetInGravityAbsForActor < skillRotateStyle.ResumeRotateThreshold)
					{
						outVector.DeepCopy(actorForwardProxy);
						return;
					}
					skillRotateStyle.IsPaused = false;
					return;
				}
			}
			else if (skillRotateStyle.PauseRotateThreshold > 0f && angleOffsetInGravityAbsForActor < skillRotateStyle.PauseRotateThreshold)
			{
				skillRotateStyle.IsPaused = true;
				outVector.DeepCopy(actorForwardProxy);
			}
		}
	}

	// Token: 0x06018E34 RID: 101940 RVA: 0x00790B1C File Offset: 0x0078ED1C
	public static UTraceLineElement GetStaticLineTrace()
	{
		if (SkillUtils._lineTrace == null)
		{
			SkillUtils._lineTrace = new UTraceLineElement();
			SkillUtils._lineTrace.bIsSingle = true;
			SkillUtils._lineTrace.bIgnoreSelf = true;
			SkillUtils._lineTrace.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStatic);
			SkillUtils._lineTrace.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStaticIgnoreBullet);
		}
		SkillUtils._lineTrace.WorldContextObject = GlobalData.World;
		SkillUtils._lineTrace.ClearCacheData(false);
		return SkillUtils._lineTrace;
	}

	// Token: 0x06018E35 RID: 101941 RVA: 0x00790B90 File Offset: 0x0078ED90
	public static FTransformDouble? GetTargetSocketTransform(Entity target, string socketName, ERelativeTransformSpace space, string reason, ESocketTransformDefault defaultTransform = ESocketTransformDefault.None)
	{
		CharacterActorComponent component = target.GetComponent<CharacterActorComponent>();
		TsBaseCharacter tsBaseCharacter = (component != null) ? component.Actor : null;
		if (tsBaseCharacter != null && tsBaseCharacter.IsValid() && !string.IsNullOrEmpty(socketName))
		{
			USkeletalMeshComponent mesh = tsBaseCharacter.Mesh;
			FName? dynamicFName = FNameUtil.GetDynamicFName(socketName);
			if (mesh != null && dynamicFName != null && mesh.DoesSocketExist(dynamicFName.Value))
			{
				return new FTransformDouble?(mesh.D_GetSocketTransform(dynamicFName.Value, space));
			}
		}
		if (defaultTransform == ESocketTransformDefault.BaseActor)
		{
			BaseActorComponent component2 = target.GetComponent<BaseActorComponent>();
			if (component2 == null)
			{
				return null;
			}
			return new FTransformDouble?(component2.ActorTransform);
		}
		else
		{
			if (defaultTransform != ESocketTransformDefault.CharacterActor)
			{
				return null;
			}
			if (component == null)
			{
				return null;
			}
			return new FTransformDouble?(component.ActorTransform);
		}
	}

	// Token: 0x06018E36 RID: 101942 RVA: 0x00790C50 File Offset: 0x0078EE50
	private static void AddRemoveEntityListener(EntityHandle myHandle)
	{
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.RemoveEntity;
		Action<ERemoveEntityType, EntityHandle> handle;
		if ((handle = SkillUtils.<>O.<0>__OnRemoveEntity) == null)
		{
			handle = (SkillUtils.<>O.<0>__OnRemoveEntity = new Action<ERemoveEntityType, EntityHandle>(SkillUtils.OnRemoveEntity));
		}
		if (!instance.HasWithTarget(myHandle, name, handle))
		{
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.RemoveEntity;
			Action<ERemoveEntityType, EntityHandle> handle2;
			if ((handle2 = SkillUtils.<>O.<0>__OnRemoveEntity) == null)
			{
				handle2 = (SkillUtils.<>O.<0>__OnRemoveEntity = new Action<ERemoveEntityType, EntityHandle>(SkillUtils.OnRemoveEntity));
			}
			instance2.AddWithTarget<ERemoveEntityType, EntityHandle>(myHandle, name2, handle2);
		}
	}

	// Token: 0x06018E37 RID: 101943 RVA: 0x00790CB8 File Offset: 0x0078EEB8
	private static void RemoveRemoveEntityListener(EntityHandle myHandle)
	{
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.RemoveEntity;
		Action<ERemoveEntityType, EntityHandle> handle;
		if ((handle = SkillUtils.<>O.<0>__OnRemoveEntity) == null)
		{
			handle = (SkillUtils.<>O.<0>__OnRemoveEntity = new Action<ERemoveEntityType, EntityHandle>(SkillUtils.OnRemoveEntity));
		}
		if (instance.HasWithTarget(myHandle, name, handle))
		{
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.RemoveEntity;
			Action<ERemoveEntityType, EntityHandle> handle2;
			if ((handle2 = SkillUtils.<>O.<0>__OnRemoveEntity) == null)
			{
				handle2 = (SkillUtils.<>O.<0>__OnRemoveEntity = new Action<ERemoveEntityType, EntityHandle>(SkillUtils.OnRemoveEntity));
			}
			instance2.RemoveWithTarget(myHandle, name2, handle2);
		}
	}

	// Token: 0x06018E38 RID: 101944 RVA: 0x00790D1E File Offset: 0x0078EF1E
	private static void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		SkillUtils.EndAbsoluteTimeStop(handle.Id);
		SkillUtils.EndTimeStopRequest(handle.Id);
	}

	// Token: 0x06018E39 RID: 101945 RVA: 0x00790D38 File Offset: 0x0078EF38
	public static void BeginAbsoluteTimeStop(int entityId, float duration, bool stopMove, float timeScale = 0f)
	{
		if (GameModeModel.Instance.IsMulti)
		{
			return;
		}
		CharacterModel instance = CharacterModel.Instance;
		EntityHandle entityHandle = (instance != null) ? instance.GetHandle(entityId) : null;
		if (entityHandle == null || !entityHandle.Valid)
		{
			return;
		}
		WorldEntity entity = entityHandle.Entity;
		if (!CharacterUtils.CanCharacterMonsterOrSummonedDisplayEffect(entityHandle))
		{
			return;
		}
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		if ((component == null || !component.IsRole()) && (component == null || !component.IsAutoRole()))
		{
			CombatLog.Instance.Error(CombatLog.EDebugModule.Skill, entity, "只有角色才能使用动画和子弹冻结功能", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!TimeController.Instance.AddLock(entityId, stopMove, timeScale))
		{
			CombatLog.Instance.Error(CombatLog.EDebugModule.Skill, entity, "重复调用动画和子弹冻结功能，将不做处理", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		CombatLog.Instance.Info(CombatLog.EDebugModule.Skill, entity, "开启大招时停", default(ReadOnlySpan<ValueTuple<string, object>>));
		SkillUtils.AddRemoveEntityListener(entityHandle);
		RTimeStopAnimPush rtimeStopAnimPush = new RTimeStopAnimPush();
		rtimeStopAnimPush.Dilation = (int)(timeScale * 100f);
		rtimeStopAnimPush.Duration = (int)(duration * (float)TimeUtil.Instance.InverseMillisecond);
		CombatNet.Instance.Send(EPushMessageId.RTimeStopAnimPush, entity, rtimeStopAnimPush, null, null, null);
		EventSystem.Instance.Emit<bool, float>(EEventName.OnAbsoluteTimeStop, true, duration);
		EventSystem.Instance.EmitWithTarget<bool, float>(entity, EEventName.OnAbsoluteTimeStop, true, duration);
	}

	// Token: 0x06018E3A RID: 101946 RVA: 0x00790E8C File Offset: 0x0078F08C
	public static void EndAbsoluteTimeStop(int entityId)
	{
		if (!TimeController.Instance.RemoveLock(entityId))
		{
			return;
		}
		CharacterModel instance = CharacterModel.Instance;
		EntityHandle entityHandle = (instance != null) ? instance.GetHandle(entityId) : null;
		if (entityHandle == null || !entityHandle.Valid)
		{
			return;
		}
		WorldEntity entity = entityHandle.Entity;
		CombatLog.Instance.Info(CombatLog.EDebugModule.Skill, entity, "结束大招时停", default(ReadOnlySpan<ValueTuple<string, object>>));
		SkillUtils.RemoveRemoveEntityListener(entityHandle);
		RTimeStopAnimPush rtimeStopAnimPush = new RTimeStopAnimPush();
		rtimeStopAnimPush.Dilation = 100;
		rtimeStopAnimPush.Duration = 0;
		CombatNet.Instance.Send(EPushMessageId.RTimeStopAnimPush, entity, rtimeStopAnimPush, null, null, null);
		EventSystem.Instance.Emit<bool, float>(EEventName.OnAbsoluteTimeStop, false, 0f);
		EventSystem.Instance.EmitWithTarget<bool, float>(entity, EEventName.OnAbsoluteTimeStop, false, 0f);
	}

	// Token: 0x06018E3B RID: 101947 RVA: 0x00790F60 File Offset: 0x0078F160
	public static void BeginTimeStopRequest(int entityId, float duration, float timeScale = 0f)
	{
		CharacterModel instance = CharacterModel.Instance;
		EntityHandle entityHandle = (instance != null) ? instance.GetHandle(entityId) : null;
		if (entityHandle == null || !entityHandle.Valid)
		{
			return;
		}
		WorldEntity entity = entityHandle.Entity;
		if (GameModeModel.Instance.IsMulti)
		{
			return;
		}
		if (!CharacterUtils.CanCharacterMonsterOrSummonedDisplayEffect(entityHandle))
		{
			return;
		}
		if (!TimeController.Instance.AddTimeStopRequestLock(entityId, timeScale))
		{
			CombatLog.Instance.Error(CombatLog.EDebugModule.Skill, entity, "重复进入副本时停，将不做处理", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		CombatLog.Instance.Info(CombatLog.EDebugModule.Skill, entity, "开启副本时停", default(ReadOnlySpan<ValueTuple<string, object>>));
		SkillUtils.AddRemoveEntityListener(entityHandle);
		RTimeStopPush rtimeStopPush = new RTimeStopPush();
		rtimeStopPush.Dilation = (int)(timeScale * 100f);
		rtimeStopPush.Duration = (int)(duration * (float)TimeUtil.Instance.InverseMillisecond);
		CombatNet.Instance.Send(EPushMessageId.RTimeStopPush, entity, rtimeStopPush, null, null, null);
		EventSystem.Instance.Emit<bool, float>(EEventName.OnTimeStopRequest, true, duration);
		EventSystem.Instance.EmitWithTarget<bool, float>(entity, EEventName.OnTimeStopRequest, true, duration);
	}

	// Token: 0x06018E3C RID: 101948 RVA: 0x00791070 File Offset: 0x0078F270
	public static void EndTimeStopRequest(int entityId)
	{
		if (!TimeController.Instance.RemoveTimeStopRequestLock(entityId))
		{
			return;
		}
		CharacterModel instance = CharacterModel.Instance;
		EntityHandle entityHandle = (instance != null) ? instance.GetHandle(entityId) : null;
		if (entityHandle == null || !entityHandle.Valid)
		{
			return;
		}
		WorldEntity entity = entityHandle.Entity;
		CombatLog.Instance.Info(CombatLog.EDebugModule.Skill, entity, "结束副本时停", default(ReadOnlySpan<ValueTuple<string, object>>));
		SkillUtils.RemoveRemoveEntityListener(entityHandle);
		RTimeStopPush rtimeStopPush = new RTimeStopPush();
		rtimeStopPush.Dilation = 100;
		rtimeStopPush.Duration = 0;
		CombatNet.Instance.Send(EPushMessageId.RTimeStopPush, entity, rtimeStopPush, null, null, null);
		EventSystem.Instance.Emit<bool, float>(EEventName.OnTimeStopRequest, false, 0f);
		EventSystem.Instance.EmitWithTarget<bool, float>(entity, EEventName.OnTimeStopRequest, false, 0f);
	}

	// Token: 0x06018E3D RID: 101949 RVA: 0x00791144 File Offset: 0x0078F344
	[NullableContext(2)]
	public static bool IsTsActor(EntityHandle skillTarget)
	{
		EEntityType? eentityType;
		if (skillTarget == null)
		{
			eentityType = null;
		}
		else
		{
			WorldEntity entity = skillTarget.Entity;
			if (entity == null)
			{
				eentityType = null;
			}
			else
			{
				CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
				eentityType = ((component != null) ? new EEntityType?(component.GetEntityType()) : null);
			}
		}
		EEntityType? eentityType2 = eentityType;
		EEntityType? eentityType3 = eentityType2;
		EEntityType eentityType4 = EEntityType.Player;
		return (eentityType3.GetValueOrDefault() == eentityType4 & eentityType3 != null) || eentityType2.GetValueOrDefault() == EEntityType.Npc || eentityType2.GetValueOrDefault() == EEntityType.Monster || eentityType2.GetValueOrDefault() == EEntityType.Vision;
	}

	// Token: 0x06018E3E RID: 101950 RVA: 0x007911CC File Offset: 0x0078F3CC
	public static void Log(CombatLog.ELogType logType, ESkillLogType skillLogType, Entity entity, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		switch (logType)
		{
		case CombatLog.ELogType.Info:
			CombatLog.Instance.Info(CombatLog.EDebugModule.Skill, entity, message, pairs);
			return;
		case CombatLog.ELogType.Debug:
			break;
		case CombatLog.ELogType.Warn:
			CombatLog.Instance.Warn(CombatLog.EDebugModule.Skill, entity, message, pairs);
			return;
		case CombatLog.ELogType.Error:
			CombatLog.Instance.Error(CombatLog.EDebugModule.Skill, entity, message, pairs);
			break;
		default:
			return;
		}
	}

	// Token: 0x06018E3F RID: 101951 RVA: 0x0079121F File Offset: 0x0078F41F
	public static void CreateStaticDefaultValue()
	{
		SkillUtils._lineTrace = null;
	}

	// Token: 0x06018E40 RID: 101952 RVA: 0x00791227 File Offset: 0x0078F427
	public static void ResetStaticDefaultValue()
	{
		SkillUtils._lineTrace = null;
	}

	// Token: 0x0400D820 RID: 55328
	[StaticVariableRuleIgnore]
	private static readonly global::Vector TmpVector = global::Vector.Create();

	// Token: 0x0400D821 RID: 55329
	[Nullable(2)]
	private static UTraceLineElement _lineTrace;

	// Token: 0x020088DE RID: 35038
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402BB87 RID: 179079
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<ERemoveEntityType, EntityHandle> <0>__OnRemoveEntity;
	}
}
