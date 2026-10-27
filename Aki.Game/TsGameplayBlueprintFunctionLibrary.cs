using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Aki.Protocol;
using Aki.Protocol.Summon;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using AkiClient.Game.Aki.Character.Role.FemaleXL.Jiabeilina_FP.Data;
using AkiClient.Game.Aki.Character.Vision;
using AkiClient.Game.Aki.Core.Fight;
using AkiClient.Game.Aki.Core.World;
using AkiClient.Game.Aki.Data.Common.Struct;
using AkiClient.Game.Aki.Data.Fight.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelFlow;
using CSharpScript.Game.LevelFlow.Action;
using CSharpScript.Game.LevelGamePlay.SplineMoveTask;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.QuickHack;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem.Controller;
using CSharpScript.Game.Utils;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002E40 RID: 11840
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsGameplayBlueprintFunctionLibrary.TsGameplayBlueprintFunctionLibrary_C")]
public class TsGameplayBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06019040 RID: 102464 RVA: 0x006728AF File Offset: 0x00670AAF
	static TsGameplayBlueprintFunctionLibrary()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsGameplayBlueprintFunctionLibrary.CreateStaticDefaultValue), new Action(TsGameplayBlueprintFunctionLibrary.ResetStaticDefaultValue));
	}

	// Token: 0x06019041 RID: 102465 RVA: 0x006728D0 File Offset: 0x00670AD0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool ContainsTag(int entityId, FGameplayTag tag)
	{
		BaseTagComponent component = EntitySystem.Instance.GetComponent<BaseTagComponent>(entityId);
		return component != null && component.Valid && component.HasTag(tag.TagId());
	}

	// Token: 0x06019042 RID: 102466 RVA: 0x00672908 File Offset: 0x00670B08
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void AddTag(int entityId, FGameplayTag tag)
	{
		BaseTagComponent component = EntitySystem.Instance.GetComponent<BaseTagComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		component.AddTag(new int?(tag.TagId()));
	}

	// Token: 0x06019043 RID: 102467 RVA: 0x00672944 File Offset: 0x00670B44
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void AddTagWithDuration(int entityId, float duration, FGameplayTag tag)
	{
		CharacterBuffComponent component = EntitySystem.Instance.GetComponent<CharacterBuffComponent>(entityId);
		if (component == null || !component.Valid || duration <= 0f)
		{
			return;
		}
		component.AddTagWithReturnHandle(new int[]
		{
			tag.TagId()
		}, duration);
	}

	// Token: 0x06019044 RID: 102468 RVA: 0x00672990 File Offset: 0x00670B90
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void AddTagByName(int entityId, string tagName)
	{
		BaseTagComponent component = EntitySystem.Instance.GetComponent<BaseTagComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		int tagIdByName = GameplayTagUtils.GetTagIdByName(tagName);
		if (tagIdByName != 0)
		{
			component.AddTag(new int?(tagIdByName));
			string p = StringUtils.Format("GmAddTag {0} {1} 1", new string[]
			{
				CreatureModel.Instance.GetCreatureDataId(entityId).ToString(),
				tagIdByName.ToString()
			});
			EventSystem.Instance.Emit<string>(EEventName.RunGm, p);
		}
	}

	// Token: 0x06019045 RID: 102469 RVA: 0x00672A14 File Offset: 0x00670C14
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void RemoveTag(int entityId, FGameplayTag tag)
	{
		BaseTagComponent component = EntitySystem.Instance.GetComponent<BaseTagComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		component.RemoveTag(new int?(tag.TagId()));
	}

	// Token: 0x06019046 RID: 102470 RVA: 0x00672A54 File Offset: 0x00670C54
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void RemoveTagByName(int entityId, string tagName)
	{
		BaseTagComponent component = EntitySystem.Instance.GetComponent<BaseTagComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		int tagIdByName = GameplayTagUtils.GetTagIdByName(tagName);
		if (tagIdByName != 0)
		{
			component.RemoveTag(new int?(tagIdByName));
			string p = StringUtils.Format("GmRemoveTag {0} {1}", new string[]
			{
				CreatureModel.Instance.GetCreatureDataId(entityId).ToString(),
				tagIdByName.ToString()
			});
			EventSystem.Instance.Emit<string>(EEventName.RunGm, p);
		}
	}

	// Token: 0x06019047 RID: 102471 RVA: 0x00672AD8 File Offset: 0x00670CD8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void AddCue(int instigatorEntityId, int targetEntityId, long cueId)
	{
		BaseGameplayCueComponent component = EntitySystem.Instance.GetComponent<BaseGameplayCueComponent>(targetEntityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		EntityHandle entityById = CreatureModel.Instance.GetEntityById((instigatorEntityId != 0) ? instigatorEntityId : targetEntityId);
		component.AddCue(cueId, new GameplayCueParam?(new GameplayCueParam
		{
			Instigator = entityById
		}));
	}

	// Token: 0x06019048 RID: 102472 RVA: 0x00672B34 File Offset: 0x00670D34
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void RemoveCue(int entityId, long cueId)
	{
		BaseGameplayCueComponent component = EntitySystem.Instance.GetComponent<BaseGameplayCueComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		component.RemoveCue(cueId);
	}

	// Token: 0x06019049 RID: 102473 RVA: 0x00672B68 File Offset: 0x00670D68
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetGameplayCueEffectForceRecycle(int entityId, long cueId)
	{
		CharacterGameplayCueComponent component = EntitySystem.Instance.GetComponent<CharacterGameplayCueComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		GameplayCueEffect gameplayCueEffect = component.GetCueByCueId(cueId) as GameplayCueEffect;
		if (gameplayCueEffect != null)
		{
			gameplayCueEffect.IsForceRecycle = true;
		}
	}

	// Token: 0x0601904A RID: 102474 RVA: 0x00672BAA File Offset: 0x00670DAA
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsLogicAutonomousProxy(int entityId)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		return component != null && component.IsAutonomousProxy;
	}

	// Token: 0x0601904B RID: 102475 RVA: 0x00672BC4 File Offset: 0x00670DC4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool RemoveActiveGameplayEffect(int entityId, FActiveGameplayEffectHandle handle, float stacksToRemove = -1f)
	{
		CharacterBuffComponent component = EntitySystem.Instance.GetComponent<CharacterBuffComponent>(entityId);
		return component != null && component.Valid && component.RemoveBuffByHandle(handle.Handle, (int)stacksToRemove, null, null, null, null) > 0;
	}

	// Token: 0x0601904C RID: 102476 RVA: 0x00672C20 File Offset: 0x00670E20
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void RemoveBuffByTag(int entityId, FGameplayTag tag)
	{
		CharacterBuffComponent component = EntitySystem.Instance.GetComponent<CharacterBuffComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.RemoveBuffByTag(new int?(tag.TagId()), "蓝图通过Tag移除Buff", null);
		}
	}

	// Token: 0x0601904D RID: 102477 RVA: 0x00672C64 File Offset: 0x00670E64
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void AddPassiveSkill(int entityId, long passiveSkillId)
	{
		global::Log.Instance.Error(ELogModule.Battle, ELogAuthor.ZQR, "废弃接口已无效", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0601904E RID: 102478 RVA: 0x00672C90 File Offset: 0x00670E90
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void RemovePassiveSkill(int entityId, long passiveSkillId)
	{
		CharacterPassiveSkillComponent component = EntitySystem.Instance.GetComponent<CharacterPassiveSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.ForgetPassiveSkill(passiveSkillId, false);
		}
	}

	// Token: 0x0601904F RID: 102479 RVA: 0x00672CBC File Offset: 0x00670EBC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetPassiveGaSkillId(int entityId, UObject callObject)
	{
	}

	// Token: 0x06019050 RID: 102480 RVA: 0x00672CC0 File Offset: 0x00670EC0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected unsafe static void AddBuffForDebug(int instigatorEntityId, int targetEntityId, long buffId)
	{
		long creatureDataId = CreatureModel.Instance.GetCreatureDataId(instigatorEntityId);
		BaseBuffComponent component = EntitySystem.Instance.GetComponent<BaseBuffComponent>(targetEntityId);
		if (component != null)
		{
			component.AddBuffForDebug(buffId, new AddBuffParam
			{
				InstigatorId = creatureDataId,
				Reason = "AddBuffForDebug"
			});
			return;
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Battle;
		ELogAuthor author = ELogAuthor.ZQR;
		string message = "添加buff对象没有BuffComponent";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TargetEntityId", targetEntityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BuffId", buffId);
		instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x06019051 RID: 102481 RVA: 0x00672D64 File Offset: 0x00670F64
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SendCombatEventForDebug(int entityId, string tagName, bool needSave, bool isMainState)
	{
		int tagIdByName = GameplayTagUtils.GetTagIdByName(tagName);
		string text = isMainState ? "GmSendMainBattleStateToFsm" : "GmSendSubBattleStateToFsm";
		string p = StringUtils.Format("{0} {1} {2} {3}", new string[]
		{
			text,
			CreatureModel.Instance.GetCreatureDataId(entityId).ToString(),
			tagIdByName.ToString(),
			needSave ? "1" : "0"
		});
		EventSystem.Instance.Emit<string>(EEventName.RunGm, p);
	}

	// Token: 0x06019052 RID: 102482 RVA: 0x00672DE0 File Offset: 0x00670FE0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SendLevelEventForDebug(int entityId, string tagName)
	{
		int tagIdByName = GameplayTagUtils.GetTagIdByName(tagName);
		string p = StringUtils.Format("GmFsmSendFsmNotifyLevelPlayEvent {0} {1}", new string[]
		{
			CreatureModel.Instance.GetCreatureDataId(entityId).ToString(),
			tagIdByName.ToString()
		});
		EventSystem.Instance.Emit<string>(EEventName.RunGm, p);
	}

	// Token: 0x06019053 RID: 102483 RVA: 0x00672E38 File Offset: 0x00671038
	[NullableContext(1)]
	private static string GetSpecialBuffToSkillId(long buffId, string skillId)
	{
		if (skillId != "")
		{
			return skillId;
		}
		long num;
		if (SpecialBuffToSkillIdMap.Values.TryGetValue(buffId, out num))
		{
			return num.ToString();
		}
		return "";
	}

	// Token: 0x06019054 RID: 102484 RVA: 0x00672E70 File Offset: 0x00671070
	[NullableContext(2)]
	private static Skill TryGetSummonedEntitySkillInner(int entityId, int skillId, ESummonType type)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity == null)
		{
			return null;
		}
		EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(entity, type, 1);
		WorldEntity worldEntity = (summonedEntity != null) ? summonedEntity.Entity : null;
		CharacterSkillComponent characterSkillComponent = (worldEntity != null) ? worldEntity.GetComponent<CharacterSkillComponent>() : null;
		if (characterSkillComponent == null)
		{
			return null;
		}
		return characterSkillComponent.GetSkill(skillId);
	}

	// Token: 0x06019055 RID: 102485 RVA: 0x00672EBC File Offset: 0x006710BC
	[NullableContext(2)]
	private static Skill TryGetSummonedEntitySkill(int entityId, int skillId)
	{
		Skill skill = TsGameplayBlueprintFunctionLibrary.TryGetSummonedEntitySkillInner(entityId, skillId, ESummonType.ConcomitantCustom);
		if (skill == null)
		{
			skill = TsGameplayBlueprintFunctionLibrary.TryGetSummonedEntitySkillInner(entityId, skillId, ESummonType.ConcomitantVision);
		}
		if (skill == null)
		{
			skill = TsGameplayBlueprintFunctionLibrary.TryGetSummonedEntitySkillInner(entityId, skillId, ESummonType.ConcomitantPhantomRole);
		}
		return skill;
	}

	// Token: 0x06019056 RID: 102486 RVA: 0x00672EEC File Offset: 0x006710EC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected unsafe static void AddBuffFromGA(int entityId, TsBaseCharacter target, long buffId, string skillId, int addCount)
	{
		string specialBuffToSkillId = TsGameplayBlueprintFunctionLibrary.GetSpecialBuffToSkillId(buffId, skillId);
		int num = -1;
		for (int i = 0; i < SpecialIgnoreGaBuff.Values.Length; i++)
		{
			if (SpecialIgnoreGaBuff.Values[i] == buffId)
			{
				num = i;
				break;
			}
		}
		if (specialBuffToSkillId == "" && num == -1)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "AddBuffFromGA的SkillId为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("buffId", buffId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		long creatureDataId = CreatureModel.Instance.GetCreatureDataId(entityId);
		if (creatureDataId == 0L)
		{
			return;
		}
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		Skill skill = (component != null) ? component.GetSkill(int.Parse(specialBuffToSkillId)) : null;
		long? preMessageId = (skill != null) ? skill.CombatMessageId : null;
		string text;
		if (skill == null)
		{
			text = null;
		}
		else
		{
			UClass abilityClass = skill.AbilityClass;
			text = ((abilityClass != null) ? abilityClass.GetName() : null);
		}
		string value = text;
		if (preMessageId == null)
		{
			long summonerId = EntitySystem.Instance.GetComponent<CreatureDataComponent>(entityId).GetSummonerId();
			if (summonerId > 0L)
			{
				EntityHandle entity = CreatureModel.Instance.GetEntity(summonerId);
				WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
				BaseSkillComponent baseSkillComponent = (worldEntity != null) ? worldEntity.GetComponent<BaseSkillComponent>() : null;
				long? num2;
				if (baseSkillComponent == null)
				{
					num2 = null;
				}
				else
				{
					Skill skill2 = baseSkillComponent.GetSkill(int.Parse(specialBuffToSkillId));
					num2 = ((skill2 != null) ? skill2.CombatMessageId : null);
				}
				preMessageId = num2;
				string text2;
				if (baseSkillComponent == null)
				{
					text2 = null;
				}
				else
				{
					Skill skill3 = baseSkillComponent.GetSkill(int.Parse(specialBuffToSkillId));
					if (skill3 == null)
					{
						text2 = null;
					}
					else
					{
						UClass abilityClass2 = skill3.AbilityClass;
						text2 = ((abilityClass2 != null) ? abilityClass2.GetName() : null);
					}
				}
				value = text2;
			}
			else
			{
				Skill skill4 = TsGameplayBlueprintFunctionLibrary.TryGetSummonedEntitySkill(entityId, int.Parse(specialBuffToSkillId));
				preMessageId = ((skill4 != null) ? skill4.CombatMessageId : null);
				string text3;
				if (skill4 == null)
				{
					text3 = null;
				}
				else
				{
					UClass abilityClass3 = skill4.AbilityClass;
					text3 = ((abilityClass3 != null) ? abilityClass3.GetName() : null);
				}
				value = text3;
			}
		}
		if (target != null)
		{
			CharacterBuffComponent characterBuffComponent = target.CharacterActorComponent.Entity.CheckGetComponent<CharacterBuffComponent>();
			if (characterBuffComponent != null)
			{
				BaseBuffComponent baseBuffComponent = characterBuffComponent;
				AddBuffParam addBuffParam = new AddBuffParam();
				addBuffParam.InstigatorId = creatureDataId;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
				defaultInterpolatedStringHandler.AppendLiteral("技能");
				defaultInterpolatedStringHandler.AppendFormatted(specialBuffToSkillId);
				defaultInterpolatedStringHandler.AppendLiteral("GA");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral("的buff添加");
				addBuffParam.Reason = defaultInterpolatedStringHandler.ToStringAndClear();
				addBuffParam.PreMessageId = preMessageId;
				addBuffParam.OuterStackCount = new int?(addCount);
				baseBuffComponent.AddBuff(buffId, addBuffParam);
				return;
			}
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Battle;
			ELogAuthor author2 = ELogAuthor.ZQR;
			string message2 = "添加buff对象没有BuffComponent";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Target", target);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BuffId", buffId);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x06019057 RID: 102487 RVA: 0x0067319C File Offset: 0x0067139C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void RemoveBuffById(int entityId, long buffId, int stackCount)
	{
		BaseBuffComponent component = EntitySystem.Instance.GetComponent<BaseBuffComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		component.RemoveBuff(buffId, stackCount, "从蓝图移除Buff", null, null, null);
	}

	// Token: 0x06019058 RID: 102488 RVA: 0x006731F0 File Offset: 0x006713F0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static int GetBuffCountById(int entityId, long buffId, bool enforceOnGoingCheck)
	{
		BaseBuffComponent component = EntitySystem.Instance.GetComponent<BaseBuffComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return 0;
		}
		return component.GetBuffTotalStackById(buffId, enforceOnGoingCheck);
	}

	// Token: 0x06019059 RID: 102489 RVA: 0x00673224 File Offset: 0x00671424
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void AddGameplayCueLocal(int entityId, float duration, long cueId)
	{
		BaseBuffComponent component = EntitySystem.Instance.GetComponent<BaseBuffComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		long[] cueIds = new long[]
		{
			cueId
		};
		component.AddGameplayCue(cueIds, duration, "蓝图AddGameplayCueLocal");
	}

	// Token: 0x0601905A RID: 102490 RVA: 0x00673268 File Offset: 0x00671468
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetGeDebugString(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		return ((component != null) ? component.GetGeDebugStrings() : null) ?? "";
	}

	// Token: 0x0601905B RID: 102491 RVA: 0x0067328A File Offset: 0x0067148A
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetTagDebugStrings(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		return ((component != null) ? component.GetTagDebugStrings() : null) ?? "";
	}

	// Token: 0x0601905C RID: 102492 RVA: 0x006732AC File Offset: 0x006714AC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetBuffDebugStrings(int entityId, string buffStr)
	{
		return TsGameplayBlueprintFunctionLibrary.GetBuffDebugStringsNoBlueprint(entityId, buffStr);
	}

	// Token: 0x0601905D RID: 102493 RVA: 0x006732B5 File Offset: 0x006714B5
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetShieldDebugString(int entityId, string filterStr = "")
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		return ((component != null) ? component.GetShieldDebugString(filterStr).Trim() : null) ?? "";
	}

	// Token: 0x0601905E RID: 102494 RVA: 0x006732DD File Offset: 0x006714DD
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetPassiveSkillDebugString(int entityId)
	{
		return "";
	}

	// Token: 0x0601905F RID: 102495 RVA: 0x006732E4 File Offset: 0x006714E4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetShieldValue(int entityId, int shieldCid)
	{
		CharacterShieldComponent component = EntitySystem.Instance.GetComponent<CharacterShieldComponent>(entityId);
		return (float)((int)((component != null) ? component.GetShieldValue(shieldCid) : 0f));
	}

	// Token: 0x06019060 RID: 102496 RVA: 0x00673304 File Offset: 0x00671504
	[NullableContext(1)]
	public static string GetBuffDebugStringsNoBlueprint(int entityId, string buffStr = "")
	{
		CharacterBuffComponent component = EntitySystem.Instance.GetComponent<CharacterBuffComponent>(entityId);
		CharacterGasDebugComponent component2 = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		return (((component != null) ? component.GetDebugBuffString(buffStr) : null) ?? "未找到buff组件") + "\n" + ((component2 != null) ? component2.GetShieldDebugString("") : null);
	}

	// Token: 0x06019061 RID: 102497 RVA: 0x00673359 File Offset: 0x00671559
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetAttributeDebugString(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		return ((component != null) ? component.GetAttributeDebugStrings() : null) ?? "";
	}

	// Token: 0x06019062 RID: 102498 RVA: 0x0067337B File Offset: 0x0067157B
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetAllAttributeDebugStrings(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		return ((component != null) ? component.GetAllAttributeDebugStrings() : null) ?? "";
	}

	// Token: 0x06019063 RID: 102499 RVA: 0x0067339D File Offset: 0x0067159D
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetServerBuffString(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component == null)
		{
			return null;
		}
		return component.GetServerBuffString();
	}

	// Token: 0x06019064 RID: 102500 RVA: 0x006733B5 File Offset: 0x006715B5
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetServerTagString(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component == null)
		{
			return null;
		}
		return component.GetServerTagString();
	}

	// Token: 0x06019065 RID: 102501 RVA: 0x006733CD File Offset: 0x006715CD
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetServerAttributeString(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component == null)
		{
			return null;
		}
		return component.GetServerAttributeString();
	}

	// Token: 0x06019066 RID: 102502 RVA: 0x006733E5 File Offset: 0x006715E5
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetServerPartString(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component == null)
		{
			return null;
		}
		return component.GetServerPartString();
	}

	// Token: 0x06019067 RID: 102503 RVA: 0x006733FD File Offset: 0x006715FD
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetServerHateString(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component == null)
		{
			return null;
		}
		return component.GetServerHateString();
	}

	// Token: 0x06019068 RID: 102504 RVA: 0x00673415 File Offset: 0x00671615
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetServerShieldString(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component == null)
		{
			return null;
		}
		return component.GetServerShieldString();
	}

	// Token: 0x06019069 RID: 102505 RVA: 0x0067342D File Offset: 0x0067162D
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ServerDebugInfoRequest(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.ServerDebugInfoRequest();
	}

	// Token: 0x0601906A RID: 102506 RVA: 0x00673444 File Offset: 0x00671644
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetServerDebugInfoDirty(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		return component != null && component.ServerDebugInfoDirty;
	}

	// Token: 0x0601906B RID: 102507 RVA: 0x0067345C File Offset: 0x0067165C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetServerDebugInfoDirty(int entityId, bool val)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component != null)
		{
			component.ServerDebugInfoDirty = val;
		}
	}

	// Token: 0x0601906C RID: 102508 RVA: 0x00673480 File Offset: 0x00671680
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void DebugResetBaseVal(int entityId, float id, float val)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component != null && component != null)
		{
			component.DebugResetBaseValue((int)id, val);
		}
		string p = StringUtils.Format("GmSetAttribute {0} {1} {2}", new string[]
		{
			CreatureModel.Instance.GetCreatureDataId(entityId).ToString(),
			((int)id).ToString(),
			val.ToString()
		});
		EventSystem.Instance.Emit<string>(EEventName.RunGm, p);
	}

	// Token: 0x0601906D RID: 102509 RVA: 0x006734F7 File Offset: 0x006716F7
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void DebugResetFormationValue(int id, float val)
	{
		FormationAttributeController.Instance.SetValue((EFormationAttributeId)id, val);
	}

	// Token: 0x0601906E RID: 102510 RVA: 0x00673505 File Offset: 0x00671705
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string Record(int entityId, bool record)
	{
		if (!Info.Instance.IsBuildDevelopmentOrDebug)
		{
			return "";
		}
		if (record)
		{
			CharacterGasDebugComponent.BeginRecord();
			return "";
		}
		return CharacterGasDebugComponent.EndRecord();
	}

	// Token: 0x0601906F RID: 102511 RVA: 0x0067352C File Offset: 0x0067172C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void RefreshEntityListView(UListView listView)
	{
		TArray<UObject> listItems = listView.GetListItems();
		HashSet<int> hashSet = new HashSet<int>();
		for (int i = listItems.Num() - 1; i >= 0; i--)
		{
			UObject uobject = listItems.Get(i);
			string[] array = uobject.GetName().Split(',', StringSplitOptions.None);
			int item;
			if (array.Length != 0 && int.TryParse(array[0], out item))
			{
				if (!hashSet.Add(item))
				{
					listView.RemoveItem(uobject);
				}
			}
			else
			{
				listView.RemoveItem(uobject);
			}
		}
		IReadOnlyList<EntityHandle> allEntities = CreatureModel.Instance.GetAllEntities();
		if (allEntities != null)
		{
			foreach (EntityHandle entityHandle in allEntities)
			{
				if (!hashSet.Contains(entityHandle.Id))
				{
					string text;
					if (entityHandle == null)
					{
						text = null;
					}
					else
					{
						WorldEntity entity = entityHandle.Entity;
						if (entity == null)
						{
							text = null;
						}
						else
						{
							CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
							if (component == null)
							{
								text = null;
							}
							else
							{
								TsBaseCharacter actor = component.Actor;
								text = ((actor != null) ? actor.GetName() : null);
							}
						}
					}
					string text2 = text;
					string str;
					if (text2 != null)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 3);
						defaultInterpolatedStringHandler.AppendFormatted(entityHandle.GetType().Name);
						defaultInterpolatedStringHandler.AppendLiteral("_");
						defaultInterpolatedStringHandler.AppendFormatted<int>(entityHandle.Id);
						defaultInterpolatedStringHandler.AppendLiteral("[");
						defaultInterpolatedStringHandler.AppendFormatted(text2);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						str = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
						defaultInterpolatedStringHandler.AppendFormatted(entityHandle.GetType().Name);
						defaultInterpolatedStringHandler.AppendLiteral("_");
						defaultInterpolatedStringHandler.AppendFormatted<int>(entityHandle.Id);
						str = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					ULayer item2 = new ULayer(listView, entityHandle.Id.ToString() + "," + str, EObjectFlags.RF_NoFlags);
					listView.AddItem(item2);
				}
			}
		}
	}

	// Token: 0x06019070 RID: 102512 RVA: 0x00673714 File Offset: 0x00671914
	[NullableContext(2)]
	private static string GetEntityActorName(Entity entity)
	{
		if (entity == null)
		{
			return null;
		}
		if (entity.GetComponent<BaseBuffComponent>() == null || entity.GetComponent<BaseSkillComponent>() == null || entity.GetComponent<BaseActorComponent>() == null)
		{
			if (Info.Instance.IsPlayInEditor)
			{
				BaseBuffComponent component = entity.GetComponent<BaseBuffComponent>();
				if (component != null && component.IsTeamBuffComponent())
				{
					return "PlayerEntity";
				}
			}
			return null;
		}
		BaseActorComponent component2 = entity.GetComponent<BaseActorComponent>();
		if (component2 == null)
		{
			return null;
		}
		AActor owner = component2.Owner;
		if (owner == null)
		{
			return null;
		}
		return owner.GetName();
	}

	// Token: 0x06019071 RID: 102513 RVA: 0x00673784 File Offset: 0x00671984
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void RefreshEntityComboBox(UComboBoxString comboBox)
	{
		int optionCount = comboBox.GetOptionCount();
		HashSet<int> hashSet = new HashSet<int>();
		for (int i = optionCount - 1; i >= 0; i--)
		{
			string optionAtIndex = comboBox.GetOptionAtIndex(i);
			Match match = new Regex("^(?<actorName>.+?)_(?<handleId>\\d+)$").Match(optionAtIndex);
			int num = 0;
			if (match.Success && match.Groups["handleId"].Success)
			{
				int.TryParse(match.Groups["handleId"].Value, out num);
			}
			string a = (match.Success && match.Groups["actorName"].Success) ? match.Groups["actorName"].Value : null;
			Entity entity = EntitySystem.Instance.Get(num);
			if (num == 0 || hashSet.Contains(num) || entity == null || a != TsGameplayBlueprintFunctionLibrary.GetEntityActorName(entity))
			{
				comboBox.RemoveOption(optionAtIndex);
			}
			else
			{
				hashSet.Add(num);
			}
		}
		IReadOnlyList<EntityHandle> allEntities = CreatureModel.Instance.GetAllEntities();
		if (allEntities != null)
		{
			foreach (EntityHandle entityHandle in allEntities)
			{
				if (!hashSet.Contains((entityHandle != null) ? entityHandle.Id : 0))
				{
					string entityActorName = TsGameplayBlueprintFunctionLibrary.GetEntityActorName((entityHandle != null) ? entityHandle.Entity : null);
					if (entityActorName != null)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
						defaultInterpolatedStringHandler.AppendFormatted(entityActorName);
						defaultInterpolatedStringHandler.AppendLiteral("_");
						defaultInterpolatedStringHandler.AppendFormatted<int>(entityHandle.Id);
						comboBox.AddOption(defaultInterpolatedStringHandler.ToStringAndClear());
					}
				}
			}
		}
	}

	// Token: 0x06019072 RID: 102514 RVA: 0x00673940 File Offset: 0x00671B40
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetEntityComboBox(UComboBoxString comboBox, int entityId)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		string entityActorName = TsGameplayBlueprintFunctionLibrary.GetEntityActorName(entity);
		string selectedOption = comboBox.GetSelectedOption();
		if (entity == null || entityActorName == null)
		{
			if (!string.IsNullOrEmpty(selectedOption))
			{
				comboBox.ClearSelection();
			}
			return;
		}
		Match match = new Regex("_(?<entityId>\\d+)$").Match(selectedOption ?? "");
		int num = -1;
		if (match.Success && match.Groups["entityId"].Success)
		{
			int.TryParse(match.Groups["entityId"].Value, out num);
		}
		if (num != entityId)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(entityActorName);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(entityId);
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			if (comboBox.FindOptionIndex(text) < 0)
			{
				comboBox.AddOption(text);
			}
			comboBox.SetSelectedOption(text);
		}
	}

	// Token: 0x06019073 RID: 102515 RVA: 0x00673A1F File Offset: 0x00671C1F
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetDebugEntityId(int entityId)
	{
		CombatDebugController.Instance.DebugEntityId = ((CombatDebugController.Instance.DebugEntityId == entityId) ? 0 : entityId);
	}

	// Token: 0x06019074 RID: 102516 RVA: 0x00673A3C File Offset: 0x00671C3C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static int GetDebugEntityId()
	{
		CombatDebugController instance = CombatDebugController.Instance;
		if (instance == null)
		{
			return 0;
		}
		return instance.DebugEntityId;
	}

	// Token: 0x06019075 RID: 102517 RVA: 0x00673A50 File Offset: 0x00671C50
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void RefreshBuffListView(int entityId, UListView listView, string filterStr = "")
	{
		MatchCollection matchCollection = new Regex("[0-9]+").Matches(filterStr);
		List<string> list = new List<string>();
		foreach (object obj in matchCollection)
		{
			Match match = (Match)obj;
			if (match.Success)
			{
				list.Add(match.Value);
			}
		}
		Entity entity = EntitySystem.Instance.Get(entityId);
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		if (baseBuffComponent == null)
		{
			listView.ClearListItems();
			return;
		}
		RoleBuffComponent roleBuffComponent = baseBuffComponent as RoleBuffComponent;
		PlayerBuffComponent playerBuffComponent = (roleBuffComponent != null) ? roleBuffComponent.GetFormationBuffComp() : null;
		TArray<UObject> listItems = listView.GetListItems();
		HashSet<int> hashSet = new HashSet<int>();
		for (int i = listItems.Num() - 1; i >= 0; i--)
		{
			UObject uobject = listItems.Get(i);
			string[] array = uobject.GetName().Split(',', StringSplitOptions.None);
			int handle;
			if (array.Length > 1 && int.TryParse(array[1], out handle))
			{
				IActiveBuff activeBuff = baseBuffComponent.GetBuffByHandle(handle);
				if (activeBuff == null)
				{
					activeBuff = ((playerBuffComponent != null) ? playerBuffComponent.GetBuffByHandle(handle) : null);
				}
				bool flag = false;
				if (activeBuff == null || hashSet.Contains(activeBuff.Handle))
				{
					flag = true;
				}
				else if (list.Count > 0)
				{
					bool flag2 = false;
					foreach (string value in list)
					{
						if (activeBuff.Id.ToString().StartsWith(value))
						{
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						flag = true;
					}
				}
				if (flag)
				{
					listView.RemoveItem(uobject);
				}
				else
				{
					hashSet.Add(activeBuff.Handle);
				}
			}
			else
			{
				listView.RemoveItem(uobject);
			}
		}
		foreach (IActiveBuff activeBuff2 in baseBuffComponent.GetAllBuffs())
		{
			if (!hashSet.Contains(activeBuff2.Handle))
			{
				if (list.Count > 0)
				{
					bool flag3 = false;
					foreach (string value2 in list)
					{
						if (activeBuff2.Id.ToString().StartsWith(value2))
						{
							flag3 = true;
							break;
						}
					}
					if (!flag3)
					{
						goto IL_27D;
					}
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(entityId);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted<int>(activeBuff2.Handle);
				ULayer item = new ULayer(listView, defaultInterpolatedStringHandler.ToStringAndClear(), EObjectFlags.RF_NoFlags);
				listView.AddItem(item);
			}
			IL_27D:;
		}
		if (playerBuffComponent != null)
		{
			foreach (IActiveBuff activeBuff3 in playerBuffComponent.GetAllBuffs())
			{
				if (!hashSet.Contains(activeBuff3.Handle))
				{
					if (list.Count > 0)
					{
						bool flag4 = false;
						foreach (string value3 in list)
						{
							if (activeBuff3.Id.ToString().StartsWith(value3))
							{
								flag4 = true;
								break;
							}
						}
						if (!flag4)
						{
							goto IL_35B;
						}
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(entityId);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted<int>(activeBuff3.Handle);
					ULayer item2 = new ULayer(listView, defaultInterpolatedStringHandler.ToStringAndClear(), EObjectFlags.RF_NoFlags);
					listView.AddItem(item2);
				}
				IL_35B:;
			}
		}
	}

	// Token: 0x06019076 RID: 102518 RVA: 0x00673E00 File Offset: 0x00672000
	[NullableContext(2)]
	private static ActiveBuffInternal GetDebugBuff(int entityId, int handle)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		IActiveBuff activeBuff = (baseBuffComponent != null) ? baseBuffComponent.GetBuffByHandle(handle) : null;
		if (activeBuff != null)
		{
			return activeBuff as ActiveBuffInternal;
		}
		if (activeBuff == null)
		{
			RoleBuffComponent roleBuffComponent = baseBuffComponent as RoleBuffComponent;
			if (roleBuffComponent != null)
			{
				PlayerBuffComponent formationBuffComp = roleBuffComponent.GetFormationBuffComp();
				return ((formationBuffComp != null) ? formationBuffComp.GetBuffByHandle(handle) : null) as ActiveBuffInternal;
			}
		}
		return null;
	}

	// Token: 0x06019077 RID: 102519 RVA: 0x00673E64 File Offset: 0x00672064
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static long GetBuffIdByHandle(int entityId, int handle)
	{
		ActiveBuffInternal debugBuff = TsGameplayBlueprintFunctionLibrary.GetDebugBuff(entityId, handle);
		if (debugBuff != null)
		{
			long id = debugBuff.Id;
			return debugBuff.Id;
		}
		return -1L;
	}

	// Token: 0x06019078 RID: 102520 RVA: 0x00673E8E File Offset: 0x0067208E
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static int GetBuffServerIdByHandle(int entityId, int handle)
	{
		ActiveBuffInternal debugBuff = TsGameplayBlueprintFunctionLibrary.GetDebugBuff(entityId, handle);
		if (debugBuff == null)
		{
			return -1;
		}
		return debugBuff.ServerId;
	}

	// Token: 0x06019079 RID: 102521 RVA: 0x00673EA4 File Offset: 0x006720A4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetBuffDescByHandle(int entityId, int handle)
	{
		ActiveBuffInternal debugBuff = TsGameplayBlueprintFunctionLibrary.GetDebugBuff(entityId, handle);
		string text;
		if (debugBuff == null)
		{
			text = null;
		}
		else
		{
			BuffDefinition config = debugBuff.Config;
			text = ((config != null) ? config.Desc : null);
		}
		string text2 = text ?? "Invalid";
		if (((debugBuff != null) ? debugBuff.GetOwnerBuffComponent() : null) is PlayerBuffComponent)
		{
			return "【编队buff】\n" + text2;
		}
		return text2;
	}

	// Token: 0x0601907A RID: 102522 RVA: 0x00673EFB File Offset: 0x006720FB
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetBuffActivateByHandle(int entityId, int handle)
	{
		ActiveBuffInternal debugBuff = TsGameplayBlueprintFunctionLibrary.GetDebugBuff(entityId, handle);
		return debugBuff != null && debugBuff.IsActive();
	}

	// Token: 0x0601907B RID: 102523 RVA: 0x00673F0F File Offset: 0x0067210F
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetBuffInstigatorStringByHandle(int entityId, int handle)
	{
		ActiveBuffInternal debugBuff = TsGameplayBlueprintFunctionLibrary.GetDebugBuff(entityId, handle);
		string text;
		if (debugBuff == null)
		{
			text = null;
		}
		else
		{
			CharacterActorComponent instigatorActorComponent = debugBuff.GetInstigatorActorComponent();
			text = ((instigatorActorComponent != null) ? instigatorActorComponent.Actor.GetName() : null);
		}
		return text ?? "Invalid";
	}

	// Token: 0x0601907C RID: 102524 RVA: 0x00673F40 File Offset: 0x00672140
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetBuffPeriodStringByHandle(int entityId, int handle)
	{
		ActiveBuffInternal debugBuff = TsGameplayBlueprintFunctionLibrary.GetDebugBuff(entityId, handle);
		if (debugBuff == null || debugBuff.Period <= 0f)
		{
			return "无";
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<float>(debugBuff.GetRemainPeriod().Value, "F1");
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<float>(debugBuff.Period, "F1");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0601907D RID: 102525 RVA: 0x00673FB4 File Offset: 0x006721B4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetBuffDurationStringByHandle(int entityId, int handle)
	{
		ActiveBuffInternal debugBuff = TsGameplayBlueprintFunctionLibrary.GetDebugBuff(entityId, handle);
		if (debugBuff == null || debugBuff.Duration <= 0f)
		{
			return "无限";
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<float>(debugBuff.GetRemainDuration(), "F1");
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<float>(debugBuff.Duration, "F1");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0601907E RID: 102526 RVA: 0x00674020 File Offset: 0x00672220
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetBuffDurationProgress(int entityId, int handle)
	{
		ActiveBuffInternal debugBuff = TsGameplayBlueprintFunctionLibrary.GetDebugBuff(entityId, handle);
		if (debugBuff == null || debugBuff.Duration <= 0f)
		{
			return 1f;
		}
		return debugBuff.GetRemainDuration() / debugBuff.Duration;
	}

	// Token: 0x0601907F RID: 102527 RVA: 0x00674058 File Offset: 0x00672258
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetBuffLivingStatusStringByHandle(int entityId, int handle)
	{
		ActiveBuffInternal debugBuff = TsGameplayBlueprintFunctionLibrary.GetDebugBuff(entityId, handle);
		return ((debugBuff == null || !debugBuff.IsValid()) ? "销毁" : (debugBuff.IsActive() ? "激活" : "失效")) ?? "";
	}

	// Token: 0x06019080 RID: 102528 RVA: 0x006740A4 File Offset: 0x006722A4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetBuffLevelStringByHandle(int entityId, int handle)
	{
		ActiveBuffInternal debugBuff = TsGameplayBlueprintFunctionLibrary.GetDebugBuff(entityId, handle);
		return (((debugBuff != null) ? debugBuff.Level.ToString() : null) ?? "Invalid") ?? "";
	}

	// Token: 0x06019081 RID: 102529 RVA: 0x006740E0 File Offset: 0x006722E0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetBuffStackStringByHandle(int entityId, int handle)
	{
		ActiveBuffInternal debugBuff = TsGameplayBlueprintFunctionLibrary.GetDebugBuff(entityId, handle);
		return (((debugBuff != null) ? debugBuff.StackCount.ToString() : null) ?? "Invalid") ?? "";
	}

	// Token: 0x06019082 RID: 102530 RVA: 0x0067411C File Offset: 0x0067231C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetBuffDebugStringByHandle(int entityId, int handle)
	{
		string text = "";
		ActiveBuffInternal debugBuff = TsGameplayBlueprintFunctionLibrary.GetDebugBuff(entityId, handle);
		IBuffComponent buffComponent = (debugBuff != null) ? debugBuff.GetOwnerBuffComponent() : null;
		if (debugBuff == null || buffComponent == null)
		{
			return text;
		}
		if (debugBuff.Config.GrantedTags != null)
		{
			foreach (int tagId in debugBuff.Config.GrantedTags)
			{
				text = text + "附加标签 " + GameplayTagUtils.GetNameByTagId(tagId) + "\n";
			}
		}
		ExtraEffectManager buffEffectManager = buffComponent.BuffEffectManager;
		foreach (BuffEffect buffEffect in (((buffEffectManager != null) ? buffEffectManager.GetEffectsByHandle(debugBuff.Handle) : null) ?? new List<BuffEffect>()))
		{
			double value = buffComponent.GetBuffEffectCd(buffEffect.BuffId, buffEffect.Index) / 1000.0;
			string str = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 3);
			defaultInterpolatedStringHandler.AppendLiteral("持续效果 ");
			defaultInterpolatedStringHandler.AppendFormatted(buffEffect.GetDebugString());
			defaultInterpolatedStringHandler.AppendLiteral("(cd:");
			defaultInterpolatedStringHandler.AppendFormatted<double>(value, "F1");
			defaultInterpolatedStringHandler.AppendLiteral("s");
			defaultInterpolatedStringHandler.AppendFormatted(buffComponent.GetTargetCdDebugStr(buffEffect.BuffId, buffEffect.Index));
			defaultInterpolatedStringHandler.AppendLiteral(")\n");
			text = str + defaultInterpolatedStringHandler.ToStringAndClear();
		}
		if (debugBuff.Config.EffectInfos != null)
		{
			foreach (ExtraEffectParameters extraEffectParameters in debugBuff.Config.EffectInfos)
			{
				BuffExecution executionEffect = extraEffectParameters.ExecutionEffect;
				if (ExtraEffectIdSets.periodExecutionIds.Contains(extraEffectParameters.ExtraEffectId) && executionEffect != null)
				{
					text = text + "周期效果 " + executionEffect.GetDebugString() + "\n";
				}
			}
		}
		if (debugBuff.Config.Modifiers != null)
		{
			IBuffModifierData[] modifiers = debugBuff.Config.Modifiers;
			int i = 0;
			while (i < modifiers.Length)
			{
				IBuffModifierData buffModifierData = modifiers[i];
				float levelValue = AbilityUtils.GetLevelValue<float>(buffModifierData.Value1, debugBuff.Level, 0f);
				float levelValue2 = AbilityUtils.GetLevelValue<float>(buffModifierData.Value2, debugBuff.Level, 0f);
				string text2 = buffModifierData.AttributeId.ToString();
				switch (buffModifierData.CalculationPolicy[0])
				{
				case 0:
				{
					string str2 = text;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
					defaultInterpolatedStringHandler.AppendLiteral("属性");
					defaultInterpolatedStringHandler.AppendFormatted(text2);
					defaultInterpolatedStringHandler.AppendLiteral("增加");
					defaultInterpolatedStringHandler.AppendFormatted<float[]>(buffModifierData.Value1);
					defaultInterpolatedStringHandler.AppendLiteral("\n");
					text = str2 + defaultInterpolatedStringHandler.ToStringAndClear();
					break;
				}
				case 1:
				{
					string str3 = text;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 2);
					defaultInterpolatedStringHandler.AppendLiteral("属性");
					defaultInterpolatedStringHandler.AppendFormatted(text2);
					defaultInterpolatedStringHandler.AppendLiteral("增加");
					defaultInterpolatedStringHandler.AppendFormatted<float>(levelValue * 0.0001f * 100f, "F1");
					defaultInterpolatedStringHandler.AppendLiteral("%\n");
					text = str3 + defaultInterpolatedStringHandler.ToStringAndClear();
					break;
				}
				case 2:
				case 4:
				{
					string[] array = new string[]
					{
						"基础值",
						"当前值",
						"附加值"
					};
					string value2 = (buffModifierData.CalculationPolicy[3] < array.Length) ? array[buffModifierData.CalculationPolicy[3]] : "";
					string name = Enum.GetName(typeof(EAttributeType), buffModifierData.CalculationPolicy[1]);
					string str4 = text;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 8);
					defaultInterpolatedStringHandler.AppendLiteral("属性");
					defaultInterpolatedStringHandler.AppendFormatted(text2);
					defaultInterpolatedStringHandler.AppendFormatted((buffModifierData.CalculationPolicy[0] == 2) ? "增加" : "覆盖为");
					defaultInterpolatedStringHandler.AppendFormatted((buffModifierData.CalculationPolicy[2] == 1) ? "施加者" : "持有者");
					defaultInterpolatedStringHandler.AppendFormatted(name);
					defaultInterpolatedStringHandler.AppendFormatted(value2);
					defaultInterpolatedStringHandler.AppendLiteral("的");
					defaultInterpolatedStringHandler.AppendFormatted<double>((double)levelValue * 0.01, "F1");
					defaultInterpolatedStringHandler.AppendLiteral("%+");
					defaultInterpolatedStringHandler.AppendFormatted<float>(levelValue2);
					defaultInterpolatedStringHandler.AppendFormatted((buffModifierData.CalculationPolicy[4] != 0) ? "(快照)" : "");
					text = str4 + defaultInterpolatedStringHandler.ToStringAndClear();
					if (buffModifierData.CalculationPolicy[5] != 0)
					{
						string str5 = text;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
						defaultInterpolatedStringHandler.AppendLiteral("，下限");
						defaultInterpolatedStringHandler.AppendFormatted<int>(buffModifierData.CalculationPolicy[5]);
						text = str5 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
					if (buffModifierData.CalculationPolicy[6] != 0)
					{
						string str6 = text;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
						defaultInterpolatedStringHandler.AppendLiteral("，比例");
						defaultInterpolatedStringHandler.AppendFormatted<int>(buffModifierData.CalculationPolicy[6]);
						text = str6 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
					if (buffModifierData.CalculationPolicy[7] != 0)
					{
						string str7 = text;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
						defaultInterpolatedStringHandler.AppendLiteral("，上限");
						defaultInterpolatedStringHandler.AppendFormatted<int>(buffModifierData.CalculationPolicy[7]);
						text = str7 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
					text += "\n";
					break;
				}
				case 3:
				{
					string str8 = text;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 2);
					defaultInterpolatedStringHandler.AppendLiteral("属性");
					defaultInterpolatedStringHandler.AppendFormatted(text2);
					defaultInterpolatedStringHandler.AppendLiteral("覆盖为");
					defaultInterpolatedStringHandler.AppendFormatted<float[]>(buffModifierData.Value1);
					defaultInterpolatedStringHandler.AppendLiteral("\n");
					text = str8 + defaultInterpolatedStringHandler.ToStringAndClear();
					break;
				}
				case 5:
				case 6:
				case 7:
				case 8:
					goto IL_66E;
				case 9:
				{
					string[] array2 = new string[]
					{
						"基础值",
						"当前值",
						"附加值"
					};
					string value3 = (buffModifierData.CalculationPolicy[3] < array2.Length) ? array2[buffModifierData.CalculationPolicy[3]] : "";
					string name2 = Enum.GetName(typeof(EAttributeType), buffModifierData.CalculationPolicy[1]);
					string str9 = text;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 4);
					defaultInterpolatedStringHandler.AppendLiteral("属性");
					defaultInterpolatedStringHandler.AppendFormatted(text2);
					defaultInterpolatedStringHandler.AppendLiteral("以");
					defaultInterpolatedStringHandler.AppendFormatted(name2);
					defaultInterpolatedStringHandler.AppendFormatted(value3);
					defaultInterpolatedStringHandler.AppendLiteral("的");
					defaultInterpolatedStringHandler.AppendFormatted<float>(levelValue * 0.0001f * 100f, "F1");
					defaultInterpolatedStringHandler.AppendLiteral("%为万分比增加/减少\n");
					text = str9 + defaultInterpolatedStringHandler.ToStringAndClear();
					break;
				}
				default:
					goto IL_66E;
				}
				IL_67C:
				i++;
				continue;
				IL_66E:
				text = text + "修改属性" + text2;
				goto IL_67C;
			}
		}
		return text.TrimEnd();
	}

	// Token: 0x06019083 RID: 102531 RVA: 0x006747CC File Offset: 0x006729CC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetDistance(int entityId, float max)
	{
		CharacterGasDebugComponent.SetDistanceMax(max);
	}

	// Token: 0x06019084 RID: 102532 RVA: 0x006747D4 File Offset: 0x006729D4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetAllMovementHistory(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component == null)
		{
			return null;
		}
		return component.GetAllMovementHistory();
	}

	// Token: 0x06019085 RID: 102533 RVA: 0x006747EC File Offset: 0x006729EC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ResetBaseValueLocal(int entityId, int id, float val)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.DebugResetBaseValue(id, val);
	}

	// Token: 0x06019086 RID: 102534 RVA: 0x00674805 File Offset: 0x00672A05
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetAttributeCurrentValue(int entityId, int attributeId)
	{
		BaseAttributeComponent component = EntitySystem.Instance.GetComponent<BaseAttributeComponent>(entityId);
		if (component == null)
		{
			return 0f;
		}
		return component.GetCurrentValue((EAttributeType)attributeId);
	}

	// Token: 0x06019087 RID: 102535 RVA: 0x00674822 File Offset: 0x00672A22
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetAttributeBaseValue(int entityId, int attributeId)
	{
		BaseAttributeComponent component = EntitySystem.Instance.GetComponent<BaseAttributeComponent>(entityId);
		if (component == null)
		{
			return 0f;
		}
		return component.GetBaseValue((EAttributeType)attributeId);
	}

	// Token: 0x06019088 RID: 102536 RVA: 0x0067483F File Offset: 0x00672A3F
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetRageModeId(int entityId, int id)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetRageModeId(id);
	}

	// Token: 0x06019089 RID: 102537 RVA: 0x00674857 File Offset: 0x00672A57
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetHardnessModeId(int entityId, int id)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetHardnessModeId(id);
	}

	// Token: 0x0601908A RID: 102538 RVA: 0x00674870 File Offset: 0x00672A70
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void OnHit(int entityId, SHitInformation hitData)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		global::HitInformation hitData2 = global::HitInformation.FromUeHitInformation(hitData);
		if (component == null)
		{
			return;
		}
		component.OnHit(hitData2, null, false, false, null, null, null, null, false);
	}

	// Token: 0x0601908B RID: 102539 RVA: 0x006748A2 File Offset: 0x00672AA2
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetBeHitIgnoreRotate(int entityId, bool ignoreRotate)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetBeHitIgnoreRotate(ignoreRotate);
	}

	// Token: 0x0601908C RID: 102540 RVA: 0x006748BA File Offset: 0x00672ABA
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool CheckHasPart(int entityId)
	{
		CharacterPartComponent component = EntitySystem.Instance.GetComponent<CharacterPartComponent>(entityId);
		return component != null && component.IsMultiPart;
	}

	// Token: 0x0601908D RID: 102541 RVA: 0x006748D4 File Offset: 0x00672AD4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetPartRemainedLife(int entityId, FGameplayTag tag)
	{
		CharacterPartComponent component = EntitySystem.Instance.GetComponent<CharacterPartComponent>(entityId);
		if (component != null && component.IsMultiPart)
		{
			return component.GetPartByTag(tag).RemainedLife();
		}
		return -1f;
	}

	// Token: 0x0601908E RID: 102542 RVA: 0x0067490C File Offset: 0x00672B0C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ResetPartLife(int entityId, FGameplayTag tag)
	{
		CharacterPartComponent component = EntitySystem.Instance.GetComponent<CharacterPartComponent>(entityId);
		if (component != null && component.IsMultiPart)
		{
			component.GetPartByTag(tag).ResetLife();
		}
	}

	// Token: 0x0601908F RID: 102543 RVA: 0x0067493C File Offset: 0x00672B3C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ActiveStiff(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.ActiveStiff(1f);
	}

	// Token: 0x06019090 RID: 102544 RVA: 0x00674958 File Offset: 0x00672B58
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void DeActiveStiff(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.DeActiveStiff("蓝图退出硬直");
	}

	// Token: 0x06019091 RID: 102545 RVA: 0x00674974 File Offset: 0x00672B74
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetAcceptedNewBeHitAndReset(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		return component != null && component.GetAcceptedNewBeHitAndReset();
	}

	// Token: 0x06019092 RID: 102546 RVA: 0x0067498C File Offset: 0x00672B8C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetEnterFkAndReset(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		return component != null && component.GetEnterFkAndReset();
	}

	// Token: 0x06019093 RID: 102547 RVA: 0x006749A4 File Offset: 0x00672BA4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsStiff(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		return component != null && component.IsStiff();
	}

	// Token: 0x06019094 RID: 102548 RVA: 0x006749BC File Offset: 0x00672BBC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetRageModeId(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		return (float)((component != null) ? component.RageModeId : 0);
	}

	// Token: 0x06019095 RID: 102549 RVA: 0x006749D6 File Offset: 0x00672BD6
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetHardnessModeId(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		return (float)((component != null) ? component.HardnessModeId : 0);
	}

	// Token: 0x06019096 RID: 102550 RVA: 0x006749F0 File Offset: 0x00672BF0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FName GetBeHitBone(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (((component != null) ? component.BeHitBones : null) != null && component.BeHitBones.Length != 0)
		{
			return component.BeHitBones[0];
		}
		return FNameUtil.EMPTY;
	}

	// Token: 0x06019097 RID: 102551 RVA: 0x00674A32 File Offset: 0x00672C32
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetToughDecreaseValue(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (component == null)
		{
			return 0f;
		}
		return component.ToughDecreaseValue;
	}

	// Token: 0x06019098 RID: 102552 RVA: 0x00674A4E File Offset: 0x00672C4E
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static SCounterAttack GetCounterAttackInfoInternal(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (component == null)
		{
			return null;
		}
		return component.CounterAttackInfoInternal;
	}

	// Token: 0x06019099 RID: 102553 RVA: 0x00674A66 File Offset: 0x00672C66
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static SVisionCounterAttack GetVisionCounterAttackInfoInternal(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (component == null)
		{
			return null;
		}
		return component.VisionCounterAttackInfoInternal;
	}

	// Token: 0x0601909A RID: 102554 RVA: 0x00674A7E File Offset: 0x00672C7E
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetBeHitTime(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (component == null)
		{
			return 0f;
		}
		return component.BeHitTime;
	}

	// Token: 0x0601909B RID: 102555 RVA: 0x00674A9C File Offset: 0x00672C9C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static EHitAnim GetBeHitAnim(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (component == null)
		{
			return EHitAnim.轻左;
		}
		return component.BeHitAnim;
	}

	// Token: 0x0601909C RID: 102556 RVA: 0x00674AC0 File Offset: 0x00672CC0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetEnterFk(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		return component != null && component.EnterFk;
	}

	// Token: 0x0601909D RID: 102557 RVA: 0x00674AD8 File Offset: 0x00672CD8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVectorDouble GetBeHitDirect(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (component == null)
		{
			return default(FVectorDouble);
		}
		return component.BeHitDirect.ToUeVector(false);
	}

	// Token: 0x0601909E RID: 102558 RVA: 0x00674B0C File Offset: 0x00672D0C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVectorDouble GetBeHitLocation(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (component == null)
		{
			return default(FVectorDouble);
		}
		return component.BeHitLocation.ToUeVector(false);
	}

	// Token: 0x0601909F RID: 102559 RVA: 0x00674B3D File Offset: 0x00672D3D
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void AddCheckBuffList(int entityId, SCounterAttackBuff addValue)
	{
	}

	// Token: 0x060190A0 RID: 102560 RVA: 0x00674B3F File Offset: 0x00672D3F
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ClearCheckBuffList(int entityId)
	{
	}

	// Token: 0x060190A1 RID: 102561 RVA: 0x00674B41 File Offset: 0x00672D41
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void CounterAttackEnd(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.CounterAttackEnd();
	}

	// Token: 0x060190A2 RID: 102562 RVA: 0x00674B58 File Offset: 0x00672D58
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void VisionCounterAttackEnd(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.VisionCounterAttackEnd();
	}

	// Token: 0x060190A3 RID: 102563 RVA: 0x00674B6F File Offset: 0x00672D6F
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetCounterAttackEndTime(int entityId, float baseTime)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetCounterAttackEndTime(baseTime);
	}

	// Token: 0x060190A4 RID: 102564 RVA: 0x00674B87 File Offset: 0x00672D87
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsTriggerCounterAttack(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		return component != null && component.IsTriggerCounterAttack;
	}

	// Token: 0x060190A5 RID: 102565 RVA: 0x00674B9F File Offset: 0x00672D9F
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ResetTarget(int entityId)
	{
		CharacterLockOnComponent component = EntitySystem.Instance.GetComponent<CharacterLockOnComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.ResetTarget();
	}

	// Token: 0x060190A6 RID: 102566 RVA: 0x00674BB8 File Offset: 0x00672DB8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetShowTarget(int entityId, AActor actor)
	{
		CharacterLockOnComponent component = EntitySystem.Instance.GetComponent<CharacterLockOnComponent>(entityId);
		if (component != null && component.Valid)
		{
			if (actor != null)
			{
				EntityHandle entityByActor = ActorUtils.GetEntityByActor(actor, true);
				WorldEntity entity = (entityByActor != null) ? entityByActor.Entity : null;
				component.SetShowTarget(new EntityHandle(entity), "", false);
				return;
			}
			component.SetShowTarget(null, "", false);
		}
	}

	// Token: 0x060190A7 RID: 102567 RVA: 0x00674C18 File Offset: 0x00672E18
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ExitLockDirection(int entityId)
	{
		CharacterLockOnComponent component = EntitySystem.Instance.GetComponent<CharacterLockOnComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.ExitLockDirection();
		}
	}

	// Token: 0x060190A8 RID: 102568 RVA: 0x00674C44 File Offset: 0x00672E44
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EnterLockDirection(int entityId)
	{
		CharacterLockOnComponent component = EntitySystem.Instance.GetComponent<CharacterLockOnComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.EnterLockDirection();
		}
	}

	// Token: 0x060190A9 RID: 102569 RVA: 0x00674C70 File Offset: 0x00672E70
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static TsBaseCharacter GetCurrentTarget(int entityId)
	{
		CharacterLockOnComponent component = EntitySystem.Instance.GetComponent<CharacterLockOnComponent>(entityId);
		if (component != null && component.Valid)
		{
			EntityHandle currentTarget = component.GetCurrentTarget();
			object obj;
			if (currentTarget == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = currentTarget.Entity;
				if (entity == null)
				{
					obj = null;
				}
				else
				{
					BaseActorComponent component2 = entity.GetComponent<BaseActorComponent>();
					obj = ((component2 != null) ? component2.Owner : null);
				}
			}
			return obj as TsBaseCharacter;
		}
		return null;
	}

	// Token: 0x060190AA RID: 102570 RVA: 0x00674CC5 File Offset: 0x00672EC5
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetLockOnDebugLine(int entityId, bool isShow)
	{
		LockOnDebug.IsShowDebugLine = isShow;
	}

	// Token: 0x060190AB RID: 102571 RVA: 0x00674CCD File Offset: 0x00672ECD
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool ManipulateValid(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		return component != null && component.Valid;
	}

	// Token: 0x060190AC RID: 102572 RVA: 0x00674CE8 File Offset: 0x00672EE8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static AActor ManipulateGetDrawTarget(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		if (component != null && component.Valid)
		{
			return component.GetDrawTarget();
		}
		return null;
	}

	// Token: 0x060190AD RID: 102573 RVA: 0x00674D14 File Offset: 0x00672F14
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static AActor ManipulateGetCastTarget(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		if (component != null && component.Valid)
		{
			return component.GetCastTarget();
		}
		return null;
	}

	// Token: 0x060190AE RID: 102574 RVA: 0x00674D40 File Offset: 0x00672F40
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float ManipulateGetDrawTargetChantTime(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		if (component != null && component.Valid)
		{
			return component.GetDrawTargetChantTime();
		}
		return 0f;
	}

	// Token: 0x060190AF RID: 102575 RVA: 0x00674D70 File Offset: 0x00672F70
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool ManipulateChant(int entityId, UKuroBooleanEventBinder eventBinder)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		return component != null && component.Valid && component.Chant(eventBinder);
	}

	// Token: 0x060190B0 RID: 102576 RVA: 0x00674DA0 File Offset: 0x00672FA0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool ManipulateDraw(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		return component != null && component.Valid && component.Draw();
	}

	// Token: 0x060190B1 RID: 102577 RVA: 0x00674DCC File Offset: 0x00672FCC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool ManipulateCast(int entityId, float direction)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		return component != null && component.Valid && component.Precast((int)direction);
	}

	// Token: 0x060190B2 RID: 102578 RVA: 0x00674DFC File Offset: 0x00672FFC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ManipulateReset(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.Reset();
		}
	}

	// Token: 0x060190B3 RID: 102579 RVA: 0x00674E28 File Offset: 0x00673028
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool ManipulateChangeToProjectileState(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		return component != null && component.Valid && component.ChangeToProjectileState();
	}

	// Token: 0x060190B4 RID: 102580 RVA: 0x00674E54 File Offset: 0x00673054
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool ManipulateChangeToNormalState(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		return component != null && component.Valid && component.ChangeToNormalState();
	}

	// Token: 0x060190B5 RID: 102581 RVA: 0x00674E80 File Offset: 0x00673080
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static AActor GetHoldingActor(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		if (component != null && component.Valid)
		{
			return component.GetHoldingActor();
		}
		return null;
	}

	// Token: 0x060190B6 RID: 102582 RVA: 0x00674EAC File Offset: 0x006730AC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool HasHoldingActor(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		return component != null && component.Valid && component.HasHoldingActor();
	}

	// Token: 0x060190B7 RID: 102583 RVA: 0x00674ED8 File Offset: 0x006730D8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetDebugDraw(int entityId, bool isActive)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.DebugDrawSphereAndArrow = isActive;
		}
	}

	// Token: 0x060190B8 RID: 102584 RVA: 0x00674F04 File Offset: 0x00673104
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ExtraAction(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.ExtraAction();
		}
	}

	// Token: 0x060190B9 RID: 102585 RVA: 0x00674F30 File Offset: 0x00673130
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetQtePosition(int entityId, float rotate, float length, float height, bool referenceTarget, bool adjustWithMonster, float addHeight, int qteType = 0)
	{
		RoleQteComponent component = EntitySystem.Instance.GetComponent<RoleQteComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetQtePosition(new IOffsetParam
		{
			Rotate = rotate,
			Length = length,
			Height = height,
			ReferenceTarget = referenceTarget,
			QteType = (global::EQteType)qteType
		});
	}

	// Token: 0x060190BA RID: 102586 RVA: 0x00674F85 File Offset: 0x00673185
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static TsBaseCharacter GetGoBattleActor(int entityId)
	{
		RoleQteComponent component = EntitySystem.Instance.GetComponent<RoleQteComponent>(entityId);
		if (component == null)
		{
			return null;
		}
		return component.GoBattleActor;
	}

	// Token: 0x060190BB RID: 102587 RVA: 0x00674FA0 File Offset: 0x006731A0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static UDataTable GetDtSkillInfo(int entityId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			return component.GetFightDataTable(EFightDataTableKind.Skill, EFightDataTableSourceType.Self);
		}
		return null;
	}

	// Token: 0x060190BC RID: 102588 RVA: 0x00674FD0 File Offset: 0x006731D0
	[UFunction(EFunctionFlags.FUNC_None)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	protected static TMap<ECharacterLoadType, UDataTable> GetDtSkillInfoMapForDebug(int entityId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			TMap<ECharacterLoadType, UDataTable> tmap = new TMap<ECharacterLoadType, UDataTable>();
			foreach (KeyValuePair<ECharacterLoadType, UDataTable> keyValuePair in component.GetDebugFightDataTables(EFightDataTableKind.Skill))
			{
				tmap.Add(keyValuePair.Key, keyValuePair.Value);
			}
			return tmap;
		}
		return null;
	}

	// Token: 0x060190BD RID: 102589 RVA: 0x00675054 File Offset: 0x00673254
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetLastActivateSkillTime(int entityId)
	{
		CharacterSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			return component.LastActivateSkillTime;
		}
		return 0f;
	}

	// Token: 0x060190BE RID: 102590 RVA: 0x00675084 File Offset: 0x00673284
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetLastActivateSkillTime(int entityId, float time)
	{
		CharacterSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SetLastActivateSkillTime(time);
		}
	}

	// Token: 0x060190BF RID: 102591 RVA: 0x006750B0 File Offset: 0x006732B0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetSkillElevationAngle(int entityId)
	{
		CharacterSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			return component.SkillElevationAngle;
		}
		return 0f;
	}

	// Token: 0x060190C0 RID: 102592 RVA: 0x006750E0 File Offset: 0x006732E0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetSkillElevationAngle(int entityId, float angle)
	{
		CharacterSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SetSkillElevationAngle(angle);
		}
	}

	// Token: 0x060190C1 RID: 102593 RVA: 0x0067510C File Offset: 0x0067330C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string CurrentSkillId(int entityId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return "";
		}
		Skill currentSkill = component.CurrentSkill;
		if (currentSkill == null)
		{
			return null;
		}
		return currentSkill.SkillId.ToString();
	}

	// Token: 0x060190C2 RID: 102594 RVA: 0x00675150 File Offset: 0x00673350
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static int CurrentPriority(int entityId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			return component.CurrentPriority;
		}
		return 0;
	}

	// Token: 0x060190C3 RID: 102595 RVA: 0x0067517C File Offset: 0x0067337C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetCurrentPriority(int entityId, int priority)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SetCurrentPriority(priority);
		}
	}

	// Token: 0x060190C4 RID: 102596 RVA: 0x006751A8 File Offset: 0x006733A8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool HasAbility(int entityId, string skillId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		int skillId2;
		return component != null && component.Valid && int.TryParse(skillId, out skillId2) && component.HasAbility(skillId2);
	}

	// Token: 0x060190C5 RID: 102597 RVA: 0x006751E0 File Offset: 0x006733E0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	[return: Nullable(2)]
	protected static SSkillInfo GetSkillInfo(int entityId, string skillId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		int skillId2;
		if (component != null && component.Valid && int.TryParse(skillId, out skillId2))
		{
			return component.GetSkillInfo(skillId2);
		}
		return null;
	}

	// Token: 0x060190C6 RID: 102598 RVA: 0x00675218 File Offset: 0x00673418
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetSkillPriority(int entityId, string skillId, float priority)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		int skillId2;
		if (component != null && component.Valid && int.TryParse(skillId, out skillId2))
		{
			component.SetSkillPriority(skillId2, (int)priority);
		}
	}

	// Token: 0x060190C7 RID: 102599 RVA: 0x00675250 File Offset: 0x00673450
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EndSkill(int entityId, string skillId, bool isSyn, bool isNotEnd)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		int skillId2;
		if (component != null && component.Valid && int.TryParse(skillId, out skillId2))
		{
			component.EndSkill(skillId2, "TsGameplayBlueprintFunctionLibrary.EndSkill");
		}
	}

	// Token: 0x060190C8 RID: 102600 RVA: 0x0067528C File Offset: 0x0067348C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool BeginSkill(int entityId, FName skillId, bool isSyn, AActor target, FName socketName)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		int skillId2;
		return component != null && component.Valid && int.TryParse(skillId.ToString(), out skillId2) && component.BeginSkill(skillId2, new SkillParam
		{
			TargetActor = target,
			SocketName = socketName.ToString(),
			Reason = "TsGameplayBlueprintFunctionLibrary.BeginSkill"
		});
	}

	// Token: 0x060190C9 RID: 102601 RVA: 0x006752FC File Offset: 0x006734FC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected unsafe static void BeginSkillAsync(int entityId, FName skillId, [Nullable(2)] AActor target, FName socketName, UKuroBooleanEventBinder eventBinder)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			try
			{
				component.BeginSkillAsync(int.Parse(skillId.ToString()), new SkillParam
				{
					TargetActor = target,
					SocketName = socketName.ToString(),
					Reason = "TsGameplayBlueprintFunctionLibrary.BeginSkillAsync"
				}).ContinueWith(delegate(bool result)
				{
					UKuroBooleanEventBinder eventBinder2 = eventBinder;
					if (((eventBinder2 != null) ? eventBinder2.Callback : null) != null)
					{
						eventBinder.Callback.Broadcast(result);
						return;
					}
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.Battle;
					ELogAuthor author2 = ELogAuthor.HXY;
					string message2 = "BeginSkillAsync eventBinder 无效，无法广播结果";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("entityId", entityId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("skillId", skillId.ToString());
					instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				});
			}
			catch (Exception ex)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.HXY;
				string message = "BeginSkillAsync 异常";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entityId", entityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("skillId", skillId.ToString());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("error", ex.ToString());
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
		}
	}

	// Token: 0x060190CA RID: 102602 RVA: 0x00675444 File Offset: 0x00673644
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SkillBehaviorBegin(int entityId, GA_Base_C ga, SSkillBehaviorAction action)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		BaseSkillComponent baseSkillComponent = (entity != null) ? entity.GetComponent<BaseSkillComponent>() : null;
		Skill skill = (baseSkillComponent != null) ? baseSkillComponent.GetSkill(ga.SkillId) : null;
		if (entity != null && baseSkillComponent != null && baseSkillComponent.Valid && skill != null)
		{
			BeginSkillBehaviorActionParam param = new BeginSkillBehaviorActionParam
			{
				Entity = entity,
				SkillComponent = baseSkillComponent,
				Skill = skill
			};
			SkillBehaviorAction.Begin(action, param);
		}
	}

	// Token: 0x060190CB RID: 102603 RVA: 0x006754B0 File Offset: 0x006736B0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVectorDouble GetLocationByAction(int entityId, GA_Base_C ga, SSkillBehaviorAction action)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		BaseSkillComponent baseSkillComponent = (entity != null) ? entity.GetComponent<BaseSkillComponent>() : null;
		Skill skill = (baseSkillComponent != null) ? baseSkillComponent.GetSkill(ga.SkillId) : null;
		if (entity != null && baseSkillComponent != null && baseSkillComponent.Valid && skill != null)
		{
			BeginSkillBehaviorActionParam param = new BeginSkillBehaviorActionParam
			{
				Entity = entity,
				SkillComponent = baseSkillComponent,
				Skill = skill
			};
			return SkillBehaviorAction.CalculateLocation(action, param);
		}
		return global::Vector.ZeroVectorDouble;
	}

	// Token: 0x060190CC RID: 102604 RVA: 0x00675524 File Offset: 0x00673724
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FRotator GetRotationByAction(int entityId, GA_Base_C ga, SSkillBehaviorAction action)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		BaseSkillComponent baseSkillComponent = (entity != null) ? entity.GetComponent<BaseSkillComponent>() : null;
		Skill skill = (baseSkillComponent != null) ? baseSkillComponent.GetSkill(ga.SkillId) : null;
		if (entity != null && baseSkillComponent != null && baseSkillComponent.Valid && skill != null)
		{
			BeginSkillBehaviorActionParam param = new BeginSkillBehaviorActionParam
			{
				Entity = entity,
				SkillComponent = baseSkillComponent,
				Skill = skill
			};
			return SkillBehaviorAction.CalculateRotation(action, param);
		}
		return global::Rotator.ZeroRotator;
	}

	// Token: 0x060190CD RID: 102605 RVA: 0x00675598 File Offset: 0x00673798
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool SkillBehaviorSatisfy(int entityId, GA_Base_C ga, SSkillBehaviorCondition condition)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		BaseSkillComponent baseSkillComponent = (entity != null) ? entity.GetComponent<BaseSkillComponent>() : null;
		Skill skill = (baseSkillComponent != null) ? baseSkillComponent.GetSkill(ga.SkillId) : null;
		if (entity != null && baseSkillComponent != null && baseSkillComponent.Valid && skill != null)
		{
			BeginSkillBehaviorConditionParam param = new BeginSkillBehaviorConditionParam
			{
				Entity = entity,
				SkillComponent = baseSkillComponent,
				Skill = skill
			};
			return SkillBehaviorCondition.Satisfy(condition, param);
		}
		return false;
	}

	// Token: 0x060190CE RID: 102606 RVA: 0x00675608 File Offset: 0x00673808
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static AActor GetSkillTarget(int entityId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null)
		{
			EntityHandle skillTarget = component.SkillTarget;
			if (((skillTarget != null) ? new bool?(skillTarget.Valid) : null).GetValueOrDefault())
			{
				WorldEntity entity = component.SkillTarget.Entity;
				if (entity == null)
				{
					return null;
				}
				BaseActorComponent component2 = entity.GetComponent<BaseActorComponent>();
				if (component2 == null)
				{
					return null;
				}
				return component2.Owner;
			}
		}
		return null;
	}

	// Token: 0x060190CF RID: 102607 RVA: 0x00675670 File Offset: 0x00673870
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetSkillTarget(int entityId, AActor target)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SkillTarget = null;
			if (target != null)
			{
				EntityHandle entityByActor = ActorUtils.GetEntityByActor(target, true);
				WorldEntity worldEntity = (entityByActor != null) ? entityByActor.Entity : null;
				if (worldEntity != null)
				{
					component.SkillTarget = new EntityHandle(worldEntity);
				}
			}
		}
	}

	// Token: 0x060190D0 RID: 102608 RVA: 0x006756C4 File Offset: 0x006738C4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void LockOnTargetAndSetShow(int entityId, SSkillTarget config)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.LockOnTargetAndSetShow(config, true);
		}
	}

	// Token: 0x060190D1 RID: 102609 RVA: 0x006756F0 File Offset: 0x006738F0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsHasInputDir(int entityId)
	{
		CharacterSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSkillComponent>(entityId);
		return component != null && component.Valid && component.IsHasInputDir();
	}

	// Token: 0x060190D2 RID: 102610 RVA: 0x0067571C File Offset: 0x0067391C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetSkillIdWithGroupId(int entityId, int groupId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			return component.GetSkillIdWithGroupId(groupId).ToString();
		}
		return "";
	}

	// Token: 0x060190D3 RID: 102611 RVA: 0x00675758 File Offset: 0x00673958
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetSkillAcceptInput(int entityId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		return component != null && component.Valid && component.SkillAcceptInput;
	}

	// Token: 0x060190D4 RID: 102612 RVA: 0x00675784 File Offset: 0x00673984
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetSkillAcceptInput(int entityId, bool skillAcceptInput)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SetSkillAcceptInput(skillAcceptInput);
		}
	}

	// Token: 0x060190D5 RID: 102613 RVA: 0x006757B0 File Offset: 0x006739B0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetCommonSkillCanBeInterrupt(int entityId, bool canBeInterrupt)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.IsMainSkillReadyEnd = canBeInterrupt;
		}
	}

	// Token: 0x060190D6 RID: 102614 RVA: 0x006757DC File Offset: 0x006739DC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetCommonSkillCanBeInterrupt(int entityId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		return component != null && component.Valid && component.IsMainSkillReadyEnd;
	}

	// Token: 0x060190D7 RID: 102615 RVA: 0x00675808 File Offset: 0x00673A08
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float OnActivateAbility(int entityId, UGameplayAbility ga, bool isCommitSuccess)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			return (float)component.OnActivateAbility(ga, isCommitSuccess);
		}
		return -1f;
	}

	// Token: 0x060190D8 RID: 102616 RVA: 0x0067583C File Offset: 0x00673A3C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void OnEndAbility(int entityId, UGameplayAbility ga, bool wasCancelled)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.OnEndAbility(ga, wasCancelled);
		}
	}

	// Token: 0x060190D9 RID: 102617 RVA: 0x00675868 File Offset: 0x00673A68
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetPriority(int entityId, string skillId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		int skillId2;
		if (component != null && component.Valid && int.TryParse(skillId, out skillId2))
		{
			return (float)component.GetPriority(skillId2);
		}
		return -1f;
	}

	// Token: 0x060190DA RID: 102618 RVA: 0x006758A4 File Offset: 0x00673AA4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetActivePriority(int entityId, string skillId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		int skillId2;
		if (component != null && component.Valid && int.TryParse(skillId, out skillId2))
		{
			return (float)component.GetActivePriority(skillId2);
		}
		return -1f;
	}

	// Token: 0x060190DB RID: 102619 RVA: 0x006758E0 File Offset: 0x00673AE0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	[return: Nullable(2)]
	protected static UAnimMontage GetSkillMontageInstance(int entityId, string skillId, int index)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		int skillId2;
		if (component != null && component.Valid && int.TryParse(skillId, out skillId2))
		{
			return component.GetSkillMontageInstance(skillId2, index);
		}
		return null;
	}

	// Token: 0x060190DC RID: 102620 RVA: 0x00675918 File Offset: 0x00673B18
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static int GetSkillNeedPlayMontageIndex(int entityId, string skillId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		int skillId2;
		if (component != null && component.Valid && int.TryParse(skillId, out skillId2))
		{
			return component.GetSkillNeedPlayMontageIndex(skillId2);
		}
		return -1;
	}

	// Token: 0x060190DD RID: 102621 RVA: 0x00675950 File Offset: 0x00673B50
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void CreateSpecifiedTagPlayMontageAndWaitAbilityTask(GA_Base_C gameplayAbility, bool checkHit, FGameplayTag skeletalMeshComponentTag, int montageIndex, FName startSection, float startTimeSeconds, bool needTick, float animRootMotionTranslationScale = 1f)
	{
		TsBaseCharacter tsBaseCharacter = new TsBaseCharacter();
		gameplayAbility.获取施法者(ref tsBaseCharacter);
		int entityId = tsBaseCharacter.EntityId;
		if (checkHit)
		{
			FGameplayTagContainer fgameplayTagContainer = new FGameplayTagContainer();
			FGameplayTag? gameplayTagByName = GameplayTagUtils.GetGameplayTagByName("行为状态.动作状态.受击");
			if (gameplayTagByName != null)
			{
				fgameplayTagContainer.GameplayTags.Add(gameplayTagByName.Value);
				bool flag = false;
				gameplayAbility.是否拥有任意标签(tsBaseCharacter, fgameplayTagContainer, ref flag);
				return;
			}
		}
		else
		{
			TsGameplayBlueprintFunctionLibrary.ExitHitState(entityId);
			AActor owningActorFromActorInfo = gameplayAbility.GetOwningActorFromActorInfo();
			if (owningActorFromActorInfo != null && owningActorFromActorInfo.IsValid())
			{
				TsBaseCharacter tsBaseCharacter2 = owningActorFromActorInfo as TsBaseCharacter;
				if (tsBaseCharacter2 != null)
				{
					string skillId = "";
					gameplayAbility.获取当前GA的技能数据名(ref skillId);
					float rate = 1f;
					gameplayAbility.获取当前技能攻速(ref rate);
					TsGameplayBlueprintFunctionLibrary.PlaySkillMontage2Server(tsBaseCharacter2.EntityId, skillId, (float)montageIndex, rate, startSection.ToString(), startTimeSeconds);
					UAnimMontage uanimMontage = new UAnimMontage();
					gameplayAbility.获取技能动画(montageIndex, ref uanimMontage);
				}
			}
		}
	}

	// Token: 0x060190DE RID: 102622 RVA: 0x00675A2C File Offset: 0x00673C2C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetSkillRotateLocation(int entityId, FVectorDouble location)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			global::Vector target = global::Vector.Create(location);
			component.SetRotateTarget(target, ESkillRotateType.Location);
		}
	}

	// Token: 0x060190DF RID: 102623 RVA: 0x00675A64 File Offset: 0x00673C64
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetSkillRotateDirect(int entityId, FVectorDouble direct)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			global::Vector target = global::Vector.Create(direct);
			component.SetRotateTarget(target, ESkillRotateType.Direct);
		}
	}

	// Token: 0x060190E0 RID: 102624 RVA: 0x00675A9C File Offset: 0x00673C9C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void CallAnimBreakPoint(int entityId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.CallAnimBreakPoint();
		}
	}

	// Token: 0x060190E1 RID: 102625 RVA: 0x00675AC8 File Offset: 0x00673CC8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void RollingGround(int entityId)
	{
		CharacterSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.RollingGrounded();
		}
	}

	// Token: 0x060190E2 RID: 102626 RVA: 0x00675AF4 File Offset: 0x00673CF4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool ActivateAbilityVision(int entityId, EVisionType visionType)
	{
		CharacterVisionComponent component = EntitySystem.Instance.GetComponent<CharacterVisionComponent>(entityId);
		return component != null && component.Valid && component.ActivateAbilityVision(visionType);
	}

	// Token: 0x060190E3 RID: 102627 RVA: 0x00675B24 File Offset: 0x00673D24
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool EndAbilityVision(int entityId, EVisionType visionType)
	{
		CharacterVisionComponent component = EntitySystem.Instance.GetComponent<CharacterVisionComponent>(entityId);
		return component != null && component.Valid && component.EndAbilityVision(visionType);
	}

	// Token: 0x060190E4 RID: 102628 RVA: 0x00675B54 File Offset: 0x00673D54
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ActivateAbilityVisionPlayAudio(int entityId, EVisionType visionType)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component != null && component.Valid)
		{
			if (visionType != EVisionType.召唤)
			{
				if (visionType == EVisionType.变身)
				{
					RoleAudioController.Instance.PlayRoleAudio(component.Entity, ERoleAudioType.VisionMorph, null);
					return;
				}
			}
			else
			{
				RoleAudioController.Instance.PlayRoleAudio(component.Entity, ERoleAudioType.VisionSummon, null);
			}
		}
	}

	// Token: 0x060190E5 RID: 102629 RVA: 0x00675BB0 File Offset: 0x00673DB0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static TArray<int> GetVisionIdList(int entityId)
	{
		TArray<int> tarray = new TArray<int>();
		CharacterVisionComponent component = EntitySystem.Instance.GetComponent<CharacterVisionComponent>(entityId);
		if (component != null && component.Valid)
		{
			int visionId = component.GetVisionId(null);
			if (visionId != 0)
			{
				tarray.Add(visionId);
			}
		}
		return tarray;
	}

	// Token: 0x060190E6 RID: 102630 RVA: 0x00675BF5 File Offset: 0x00673DF5
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ExitMultiSkillStateOfMorphVision(int entityId)
	{
		EntityHandle summonedEntityByOwnerId = PhantomUtil.GetSummonedEntityByOwnerId(entityId, ESummonType.ConcomitantVision, 1);
		VisionSkillComponent visionSkillComponent = (summonedEntityByOwnerId != null) ? summonedEntityByOwnerId.Entity.GetComponent<VisionSkillComponent>() : null;
		if (visionSkillComponent == null)
		{
			return;
		}
		visionSkillComponent.ExitMultiSkillState();
	}

	// Token: 0x060190E7 RID: 102631 RVA: 0x00675C1A File Offset: 0x00673E1A
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetKeepMultiSkillState(int entityId, bool keepOnMorphEnd, bool keepOnGoDown)
	{
		EntityHandle summonedEntityByOwnerId = PhantomUtil.GetSummonedEntityByOwnerId(entityId, ESummonType.ConcomitantVision, 1);
		VisionSkillComponent visionSkillComponent = (summonedEntityByOwnerId != null) ? summonedEntityByOwnerId.Entity.GetComponent<VisionSkillComponent>() : null;
		if (visionSkillComponent == null)
		{
			return;
		}
		visionSkillComponent.SetKeepMultiSkillState(keepOnMorphEnd, keepOnGoDown);
	}

	// Token: 0x060190E8 RID: 102632 RVA: 0x00675C41 File Offset: 0x00673E41
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetEnableAttackInputActionOfMorphVision(int entityId, bool bEnable)
	{
		EntityHandle summonedEntityByOwnerId = PhantomUtil.GetSummonedEntityByOwnerId(entityId, ESummonType.ConcomitantVision, 1);
		VisionSkillComponent visionSkillComponent = (summonedEntityByOwnerId != null) ? summonedEntityByOwnerId.Entity.GetComponent<VisionSkillComponent>() : null;
		if (visionSkillComponent == null)
		{
			return;
		}
		visionSkillComponent.SetEnableAttackInputAction(bEnable);
	}

	// Token: 0x060190E9 RID: 102633 RVA: 0x00675C67 File Offset: 0x00673E67
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static TArray<int> GetVisionLevelList(int entityId)
	{
		return new TArray<int>();
	}

	// Token: 0x060190EA RID: 102634 RVA: 0x00675C6E File Offset: 0x00673E6E
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static int GetVisionSkillId(int entityId, float visionId, float level)
	{
		return PhantomUtil.GetEntityVisionSkillId(entityId, (int)visionId);
	}

	// Token: 0x060190EB RID: 102635 RVA: 0x00675C78 File Offset: 0x00673E78
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void InterruptSkill(int entityId, string skillId, bool isSyn)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		int skillId2;
		if (component != null && component.Valid && int.TryParse(skillId, out skillId2))
		{
			component.EndSkill(skillId2, "TsGameplayBlueprintFunctionLibrary.InterruptSkill");
		}
	}

	// Token: 0x060190EC RID: 102636 RVA: 0x00675CB4 File Offset: 0x00673EB4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void DeleteSkills(int entityId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.StopAllSkills("TsGameplayBlueprintFunctionLibrary.DeleteSkills");
		}
	}

	// Token: 0x060190ED RID: 102637 RVA: 0x00675CE4 File Offset: 0x00673EE4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetCurrentMontageCorrespondingSkillId(int entityId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			return component.GetCurrentMontageCorrespondingSkillId().ToString();
		}
		return "";
	}

	// Token: 0x060190EE RID: 102638 RVA: 0x00675D1C File Offset: 0x00673F1C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetSocketName(int entityId, string socketName)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SkillTargetSocket = socketName;
		}
	}

	// Token: 0x060190EF RID: 102639 RVA: 0x00675D48 File Offset: 0x00673F48
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetSocketName(int entityId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			return component.SkillTargetSocket;
		}
		return "";
	}

	// Token: 0x060190F0 RID: 102640 RVA: 0x00675D78 File Offset: 0x00673F78
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FTransformDouble GetPointTransform(int entityId, string boneName)
	{
		BaseActorComponent component = EntitySystem.Instance.GetComponent<BaseActorComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return default(FTransformDouble);
		}
		FName? dynamicFName = FNameUtil.GetDynamicFName(boneName);
		USkeletalMeshComponent skeletalMesh = component.SkeletalMesh;
		if (((skeletalMesh != null) ? new bool?(skeletalMesh.DoesSocketExist(dynamicFName.Value)) : null).GetValueOrDefault())
		{
			return skeletalMesh.D_GetSocketTransform(dynamicFName.Value, ERelativeTransformSpace.RTS_World);
		}
		return default(FTransformDouble);
	}

	// Token: 0x060190F1 RID: 102641 RVA: 0x00675E00 File Offset: 0x00674000
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void PlaySkillMontage2Server(int entityId, string skillId, float montageIndex, float rate, string startSection, float startTimeSeconds)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		int skillId2;
		if (component != null && component.Valid && int.TryParse(skillId, out skillId2))
		{
			component.PlaySkillMontage2Server(skillId2, (int)montageIndex, rate, startSection, startTimeSeconds);
		}
	}

	// Token: 0x060190F2 RID: 102642 RVA: 0x00675E3C File Offset: 0x0067403C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EndSkillMontage(int entityId, string skillId, float montageIndex)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		int skillId2;
		if (component != null && component.Valid && int.TryParse(skillId, out skillId2))
		{
			component.EndSkillMontage(skillId2, (int)montageIndex);
		}
	}

	// Token: 0x060190F3 RID: 102643 RVA: 0x00675E74 File Offset: 0x00674074
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void BeginAddMoveByInputDirect(int entityId, float maxSpeed, float accelerationTime, float decelerationTime, float delayTime)
	{
		CharacterSpecialSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSpecialSkillComponent>(entityId);
		SpecialSkillKanteleila specialSkillKanteleila = ((component != null) ? component.SpecialSkill : null) as SpecialSkillKanteleila;
		if (specialSkillKanteleila != null)
		{
			specialSkillKanteleila.BeginAddMoveByInputDirect(maxSpeed, accelerationTime, decelerationTime, delayTime);
		}
	}

	// Token: 0x060190F4 RID: 102644 RVA: 0x00675EAC File Offset: 0x006740AC
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void BeginAbsoluteTimeStop(int entityId, float duration, bool stopMove = true)
	{
		SkillUtils.BeginAbsoluteTimeStop(entityId, duration, stopMove, 0f);
	}

	// Token: 0x060190F5 RID: 102645 RVA: 0x00675EBB File Offset: 0x006740BB
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EndAbsoluteTimeStop(int entityId)
	{
		SkillUtils.EndAbsoluteTimeStop(entityId);
	}

	// Token: 0x060190F6 RID: 102646 RVA: 0x00675EC3 File Offset: 0x006740C3
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void BeginTimeStopRequest(int entityId, float duration)
	{
		SkillUtils.BeginTimeStopRequest(entityId, duration, 0f);
	}

	// Token: 0x060190F7 RID: 102647 RVA: 0x00675ED1 File Offset: 0x006740D1
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EndTimeStopRequest(int entityId)
	{
		SkillUtils.EndTimeStopRequest(entityId);
	}

	// Token: 0x060190F8 RID: 102648 RVA: 0x00675ED9 File Offset: 0x006740D9
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EndAddMoveByInputDirect(int entityId)
	{
		CharacterSpecialSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSpecialSkillComponent>(entityId);
		SpecialSkillBase specialSkillBase = (component != null) ? component.SpecialSkill : null;
		if (specialSkillBase == null)
		{
			return;
		}
		specialSkillBase.EndAddMoveByInputDirect();
	}

	// Token: 0x060190F9 RID: 102649 RVA: 0x00675EFC File Offset: 0x006740FC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool CanActivateFixHook(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		return component != null && component.Valid && component.CanActivateFixHook();
	}

	// Token: 0x060190FA RID: 102650 RVA: 0x00675F28 File Offset: 0x00674128
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVectorDouble FixHookTargetLocation(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		if (component != null && component.Valid)
		{
			return component.GetCurrentTargetLocation().ToUeVector(false);
		}
		return default(FVectorDouble);
	}

	// Token: 0x060190FB RID: 102651 RVA: 0x00675F64 File Offset: 0x00674164
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static TArray<FVectorDouble> FixHookTargetPathways(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		if (component != null && component.Valid)
		{
			List<ValueTuple<global::Vector, global::Vector>> currentPathways = component.GetCurrentPathways();
			if (currentPathways != null)
			{
				TArray<FVectorDouble> tarray = new TArray<FVectorDouble>();
				if (currentPathways.Count > 0)
				{
					using (List<ValueTuple<global::Vector, global::Vector>>.Enumerator enumerator = currentPathways.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							ValueTuple<global::Vector, global::Vector> valueTuple = enumerator.Current;
							tarray.Add(valueTuple.Item1.ToUeVector(false));
							tarray.Add(valueTuple.Item2.ToUeVector(false));
						}
						return tarray;
					}
				}
				tarray.Add(component.ActorComp.ActorLocationProxy.ToUeVector(false));
				tarray.Add(component.GetCurrentTargetLocation().ToUeVector(false));
				return tarray;
			}
		}
		return null;
	}

	// Token: 0x060190FC RID: 102652 RVA: 0x00676038 File Offset: 0x00674238
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static AActor FixHookTargetEnterPortalCapture(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		if (component != null && component.Valid)
		{
			return component.GetCurrentTargetEnterPortalCapture();
		}
		return null;
	}

	// Token: 0x060190FD RID: 102653 RVA: 0x00676064 File Offset: 0x00674264
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static AActor FixHookTargetActor(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		if (component != null && component.Valid)
		{
			return component.GetCurrentTargetActor();
		}
		return null;
	}

	// Token: 0x060190FE RID: 102654 RVA: 0x00676090 File Offset: 0x00674290
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool FixHookTargetIsSuiGuangType(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		return component != null && component.Valid && component.GetTargetIsSuiGuangType();
	}

	// Token: 0x060190FF RID: 102655 RVA: 0x006760BC File Offset: 0x006742BC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static EHookInteractTypeBp GetHookTargetType(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		if (component != null && component.Valid)
		{
			return component.GetTargetType();
		}
		return EHookInteractTypeBp.FixedPointHook;
	}

	// Token: 0x06019100 RID: 102656 RVA: 0x006760E8 File Offset: 0x006742E8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVectorDouble FixHookTargetForward(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		if (component != null && component.Valid)
		{
			return component.GetCurrentTargetForward();
		}
		return default(FVectorDouble);
	}

	// Token: 0x06019101 RID: 102657 RVA: 0x0067611C File Offset: 0x0067431C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVectorDouble NextFixHookTargetLocation(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		if (component != null && component.Valid)
		{
			return component.GetNextTargetLocation();
		}
		return default(FVectorDouble);
	}

	// Token: 0x06019102 RID: 102658 RVA: 0x00676150 File Offset: 0x00674350
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool FixHookTargetInheritSpeed(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		return component != null && component.Valid && component.GetInheritSpeed();
	}

	// Token: 0x06019103 RID: 102659 RVA: 0x0067617C File Offset: 0x0067437C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool FixHookTargetIsClimb(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		return component != null && component.Valid && component.GetIsClimb();
	}

	// Token: 0x06019104 RID: 102660 RVA: 0x006761A8 File Offset: 0x006743A8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetIsHookEndByInterrupt(int entityId, bool isInterrupt)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SetIsHookEndByInterrupt(isInterrupt);
		}
	}

	// Token: 0x06019105 RID: 102661 RVA: 0x006761D4 File Offset: 0x006743D4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool FixHookIsSummitPoint(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		if (component != null && component.Valid)
		{
			GrapplingHookPointComponent currentTarget = component.GetCurrentTarget();
			return currentTarget != null && currentTarget.IsSummitPoint;
		}
		return false;
	}

	// Token: 0x06019106 RID: 102662 RVA: 0x0067620C File Offset: 0x0067440C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool FixHookIsNormalPoint(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		if (component != null && component.Valid)
		{
			GrapplingHookPointComponent currentTarget = component.GetCurrentTarget();
			return currentTarget != null && currentTarget.IsNormalHookPoint;
		}
		return false;
	}

	// Token: 0x06019107 RID: 102663 RVA: 0x00676244 File Offset: 0x00674444
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static int GetHookOverrideSpeed(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		if (component != null && component.Valid)
		{
			GrapplingHookPointComponent currentTarget = component.GetCurrentTarget();
			return (int)((currentTarget != null) ? currentTarget.HookOverrideSpeed : -1f);
		}
		return -1;
	}

	// Token: 0x06019108 RID: 102664 RVA: 0x00676284 File Offset: 0x00674484
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool FixHookIsGravityPoint(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		if (component != null && component.Valid)
		{
			GrapplingHookPointComponent currentTarget = component.GetCurrentTarget();
			return currentTarget != null && currentTarget.IsGravityHookPoint;
		}
		return false;
	}

	// Token: 0x06019109 RID: 102665 RVA: 0x006762BC File Offset: 0x006744BC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool KiteHookSupportSwitchMidway(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		if (component != null && component.Valid)
		{
			GrapplingHookPointComponent currentTarget = component.GetCurrentTarget();
			return currentTarget != null && currentTarget.SupportSwitchHookMidway;
		}
		return false;
	}

	// Token: 0x0601910A RID: 102666 RVA: 0x006762F4 File Offset: 0x006744F4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static int FixHookTargetEntityId(int entityId)
	{
		BaseExploreComponent component = EntitySystem.Instance.GetComponent<BaseExploreComponent>(entityId);
		Entity entity;
		if (component == null)
		{
			entity = null;
		}
		else
		{
			GrapplingHookPointComponent interactingTarget = component.InteractingTarget;
			entity = ((interactingTarget != null) ? interactingTarget.Entity : null);
		}
		Entity entity2 = entity;
		if (entity2 != null)
		{
			return entity2.Id;
		}
		return 0;
	}

	// Token: 0x0601910B RID: 102667 RVA: 0x00676330 File Offset: 0x00674530
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool SlashHookPointHasLookAtConfig(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		if (component != null && component.Valid)
		{
			GrapplingHookPointComponent currentTarget = component.GetCurrentTarget();
			return ((currentTarget != null) ? currentTarget.GetSlashHookCharacterLookAtPoint() : null) != null;
		}
		return false;
	}

	// Token: 0x0601910C RID: 102668 RVA: 0x0067636C File Offset: 0x0067456C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVectorDouble SlashHookPointCharacterLookAtPoint(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		if (component != null && component.Valid)
		{
			GrapplingHookPointComponent currentTarget = component.GetCurrentTarget();
			return (((currentTarget != null) ? currentTarget.GetSlashHookCharacterLookAtPoint() : null) ?? global::Vector.ZeroVectorProxy).ToUeVector(false);
		}
		return global::Vector.ZeroVectorDouble;
	}

	// Token: 0x0601910D RID: 102669 RVA: 0x006763B8 File Offset: 0x006745B8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool SlashHookPointIsTakeOverCamera(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		if (component != null && component.Valid)
		{
			GrapplingHookPointComponent currentTarget = component.GetCurrentTarget();
			return currentTarget != null && currentTarget.GetLevelPlayTakeOverCamera();
		}
		return false;
	}

	// Token: 0x0601910E RID: 102670 RVA: 0x006763F0 File Offset: 0x006745F0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVectorDouble SlashHookPointSafePointLoc(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		FVectorDouble? fvectorDouble;
		if (component == null)
		{
			fvectorDouble = null;
		}
		else
		{
			GrapplingHookPointComponent currentTarget = component.GetCurrentTarget();
			fvectorDouble = ((currentTarget != null) ? new FVectorDouble?(currentTarget.GetSafePointLocation().ToUeVector(false)) : null);
		}
		FVectorDouble? fvectorDouble2 = fvectorDouble;
		if (fvectorDouble2 == null)
		{
			return global::Vector.ZeroVectorDouble;
		}
		return fvectorDouble2.GetValueOrDefault();
	}

	// Token: 0x0601910F RID: 102671 RVA: 0x00676454 File Offset: 0x00674654
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FRotator SlashHookPointSafePointRot(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		FRotator? frotator;
		if (component == null)
		{
			frotator = null;
		}
		else
		{
			GrapplingHookPointComponent currentTarget = component.GetCurrentTarget();
			frotator = ((currentTarget != null) ? new FRotator?(currentTarget.GetSafePointRotation().ToUeRotator()) : null);
		}
		FRotator? frotator2 = frotator;
		if (frotator2 == null)
		{
			return global::Rotator.ZeroRotator;
		}
		return frotator2.GetValueOrDefault();
	}

	// Token: 0x06019110 RID: 102672 RVA: 0x006764B8 File Offset: 0x006746B8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void StartChargeSlash(int entityId)
	{
		GrapplingHookPointComponent component = EntitySystem.Instance.GetComponent<GrapplingHookPointComponent>(entityId);
		if (component != null && component.Valid)
		{
			ChargeSlashGameplayController.Instance.StartChargeSlash(component);
		}
	}

	// Token: 0x06019111 RID: 102673 RVA: 0x006764E8 File Offset: 0x006746E8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void StopChargeSlash(int entityId)
	{
		GrapplingHookPointComponent component = EntitySystem.Instance.GetComponent<GrapplingHookPointComponent>(entityId);
		if (component != null && component.Valid)
		{
			ChargeSlashGameplayController.Instance.StopChargeSlash(component);
		}
	}

	// Token: 0x06019112 RID: 102674 RVA: 0x00676517 File Offset: 0x00674717
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsSlashGameplayIsSuccess()
	{
		return SlashGameplayController.Instance.CheckGroups();
	}

	// Token: 0x06019113 RID: 102675 RVA: 0x00676523 File Offset: 0x00674723
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static SGravityHookLockInfo GetGravityHookLockInfo(int entityId)
	{
		return GravityHookController.Instance.GetGravityHookLockInfo(entityId);
	}

	// Token: 0x06019114 RID: 102676 RVA: 0x00676530 File Offset: 0x00674730
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ChangeGravityByHook(int entityId, int angleRangeMin, int angleRangeMax, float smoothSecondMin, float smoothSecondMax, bool isLerpCamera)
	{
		GravityHookController.Instance.ChangeGravity(entityId, (float)angleRangeMin, (float)angleRangeMax, smoothSecondMin, smoothSecondMax, isLerpCamera);
	}

	// Token: 0x06019115 RID: 102677 RVA: 0x00676548 File Offset: 0x00674748
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetIgnoreSocketName(int entityId, string socketName)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SetIgnoreSocketName(FNameUtil.GetDynamicFName(socketName).Value);
		}
	}

	// Token: 0x06019116 RID: 102678 RVA: 0x00676580 File Offset: 0x00674780
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void DeleteIgnoreSocketName(int entityId, string socketName)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.DeleteIgnoreSocketName(FNameUtil.GetDynamicFName(socketName).Value);
		}
	}

	// Token: 0x06019117 RID: 102679 RVA: 0x006765B8 File Offset: 0x006747B8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetToTargetSocketDistance(int entityId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			return (float)component.GetTargetDistance();
		}
		return -1f;
	}

	// Token: 0x06019118 RID: 102680 RVA: 0x006765EC File Offset: 0x006747EC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetPredictProjectileInfo(int entityId, bool returnValue, ref TArray<FVector> outPathPosition, FVector outLastTraceDestination, FHitResult outHit)
	{
		CharacterThrowComponent component = EntitySystem.Instance.GetComponent<CharacterThrowComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		component.SetPredictProjectileInfo(returnValue, ref outPathPosition, outLastTraceDestination, outHit);
	}

	// Token: 0x06019119 RID: 102681 RVA: 0x00676624 File Offset: 0x00674824
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetVisible(int entityId, bool isShow)
	{
		CharacterThrowComponent component = EntitySystem.Instance.GetComponent<CharacterThrowComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		component.SetVisible(isShow);
	}

	// Token: 0x0601911A RID: 102682 RVA: 0x00676656 File Offset: 0x00674856
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static ECharState GetCharUnifiedMoveState(int entityId)
	{
		BaseUnifiedStateComponent component = EntitySystem.Instance.GetComponent<BaseUnifiedStateComponent>(entityId);
		return (ECharState)((component != null) ? component.MoveState : global::ECharMoveState.Other);
	}

	// Token: 0x0601911B RID: 102683 RVA: 0x00676670 File Offset: 0x00674870
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static ECharParentMoveState GetCharUnifiedPositionState(int entityId)
	{
		BaseUnifiedStateComponent component = EntitySystem.Instance.GetComponent<BaseUnifiedStateComponent>(entityId);
		return (ECharParentMoveState)((component != null) ? component.PositionState : global::ECharPositionState.Ground);
	}

	// Token: 0x0601911C RID: 102684 RVA: 0x0067668A File Offset: 0x0067488A
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ExitHitState(int entityId)
	{
		CharacterUnifiedStateComponent component = EntitySystem.Instance.GetComponent<CharacterUnifiedStateComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.ExitHitState("");
	}

	// Token: 0x0601911D RID: 102685 RVA: 0x006766A6 File Offset: 0x006748A6
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetDirectionState(int entityId, ECharViewDirectionState newViewState)
	{
		BaseUnifiedStateComponent component = EntitySystem.Instance.GetComponent<BaseUnifiedStateComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetDirectionState((ECharDirectionState)newViewState);
	}

	// Token: 0x0601911E RID: 102686 RVA: 0x006766BE File Offset: 0x006748BE
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static ECharViewDirectionState GetDirectionState(int entityId)
	{
		BaseUnifiedStateComponent component = EntitySystem.Instance.GetComponent<BaseUnifiedStateComponent>(entityId);
		return (ECharViewDirectionState)((component != null) ? component.DirectionState : ECharDirectionState.LockDirection);
	}

	// Token: 0x0601911F RID: 102687 RVA: 0x006766D8 File Offset: 0x006748D8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetIsInGame(int entityId)
	{
		BaseUnifiedStateComponent component = EntitySystem.Instance.GetComponent<BaseUnifiedStateComponent>(entityId);
		return ((component != null) ? component.IsInGame : null).GetValueOrDefault();
	}

	// Token: 0x06019120 RID: 102688 RVA: 0x0067670C File Offset: 0x0067490C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SprintPress(int entityId)
	{
		CharacterUnifiedStateComponent component = EntitySystem.Instance.GetComponent<CharacterUnifiedStateComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SprintPress();
	}

	// Token: 0x06019121 RID: 102689 RVA: 0x00676723 File Offset: 0x00674923
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SprintRelease(int entityId)
	{
		CharacterUnifiedStateComponent component = EntitySystem.Instance.GetComponent<CharacterUnifiedStateComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SprintRelease();
	}

	// Token: 0x06019122 RID: 102690 RVA: 0x0067673C File Offset: 0x0067493C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void StandPress(int entityId)
	{
		BaseUnifiedStateComponent component = EntitySystem.Instance.GetComponent<BaseUnifiedStateComponent>(entityId);
		if (component != null && component.PositionState == global::ECharPositionState.Ground)
		{
			CharacterActorComponent component2 = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
			if (component2 != null && component2.CreatureData.IsRole())
			{
				component.SetMoveState(global::ECharMoveState.Stand);
			}
		}
	}

	// Token: 0x06019123 RID: 102691 RVA: 0x00676785 File Offset: 0x00674985
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SwingPress(int entityId)
	{
		CharacterUnifiedStateComponent component = EntitySystem.Instance.GetComponent<CharacterUnifiedStateComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SwingPress();
	}

	// Token: 0x06019124 RID: 102692 RVA: 0x0067679C File Offset: 0x0067499C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SwingRelease(int entityId)
	{
		CharacterUnifiedStateComponent component = EntitySystem.Instance.GetComponent<CharacterUnifiedStateComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SwingRelease();
	}

	// Token: 0x06019125 RID: 102693 RVA: 0x006767B3 File Offset: 0x006749B3
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void CustomSetWalkOrRun(int entityId, bool isWalk)
	{
		CharacterUnifiedStateComponent component = EntitySystem.Instance.GetComponent<CharacterUnifiedStateComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.CustomSetWalkOrRun(isWalk);
	}

	// Token: 0x06019126 RID: 102694 RVA: 0x006767CC File Offset: 0x006749CC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EnterAimStatus(int entityId, EAimViewState aimViewState)
	{
		CharacterUnifiedStateComponent component = EntitySystem.Instance.GetComponent<CharacterUnifiedStateComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.EnterAimStatus(aimViewState);
	}

	// Token: 0x06019127 RID: 102695 RVA: 0x006767E4 File Offset: 0x006749E4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ExitAimStatus(int entityId)
	{
		CharacterUnifiedStateComponent component = EntitySystem.Instance.GetComponent<CharacterUnifiedStateComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.ExitAimStatus();
	}

	// Token: 0x06019128 RID: 102696 RVA: 0x006767FB File Offset: 0x006749FB
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EnableEntity(int entityId, bool isEnable)
	{
	}

	// Token: 0x06019129 RID: 102697 RVA: 0x00676800 File Offset: 0x00674A00
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void UpdateAnimInfoHit(int entityId, BP_ABPLogicParams_C animLogicParams)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		CharacterHitComponent component2 = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (component2 == null)
		{
			return;
		}
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		bool flag = component2.GetAcceptedNewBeHitAndReset();
		if (animLogicParamsSetter.AcceptedNewBeHit != flag)
		{
			animLogicParamsSetter.AcceptedNewBeHit = flag;
			animLogicParams.AcceptedNewBeHitRef = flag;
		}
		EHitAnim beHitAnim = component2.BeHitAnim;
		if (animLogicParamsSetter.BeHitAnim != beHitAnim)
		{
			animLogicParamsSetter.BeHitAnim = beHitAnim;
			animLogicParams.BeHitAnimRef = beHitAnim;
		}
		flag = component2.GetEnterFkAndReset();
		if (animLogicParamsSetter.EnterFk != flag)
		{
			animLogicParamsSetter.EnterFk = flag;
			animLogicParams.EnterFkRef = flag;
		}
		flag = component2.GetDoubleHitInAir();
		if (animLogicParamsSetter.DoubleHitInAir != flag)
		{
			animLogicParamsSetter.DoubleHitInAir = flag;
			animLogicParams.DoubleHitInAirRef = flag;
		}
	}

	// Token: 0x0601912A RID: 102698 RVA: 0x006768D4 File Offset: 0x00674AD4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void UpdateAnimInfoFk(int entityId, BP_ABPLogicParams_C animLogicParams)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		CharacterHitComponent component2 = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		if (component2 == null)
		{
			return;
		}
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		global::Vector vector = component2.BeHitDirect;
		if (!animLogicParamsSetter.BeHitDirect.Equals(vector, 9.999999747378752E-05))
		{
			animLogicParamsSetter.BeHitDirect.DeepCopy(vector);
			animLogicParams.BeHitDirectRef = vector.ToUeVectorOld();
		}
		vector = component2.BeHitLocation;
		if (!animLogicParamsSetter.BeHitLocation.Equals(vector, 9.999999747378752E-05))
		{
			animLogicParamsSetter.BeHitLocation.DeepCopy(vector);
			animLogicParams.BeHitLocationRef = vector.ToUeVectorOld();
		}
	}

	// Token: 0x0601912B RID: 102699 RVA: 0x0067698C File Offset: 0x00674B8C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void UpdateAnimInfoUnifiedState(int entityId, BP_ABPLogicParams_C animLogicParams)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		BaseUnifiedStateComponent component2 = EntitySystem.Instance.GetComponent<BaseUnifiedStateComponent>(entityId);
		if (component2 == null)
		{
			return;
		}
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		global::ECharMoveState moveState = component2.MoveState;
		if (animLogicParamsSetter.CharMoveState != moveState)
		{
			animLogicParamsSetter.CharMoveState = moveState;
			animLogicParams.CharMoveStateRef = (ECharState)moveState;
		}
		global::ECharPositionState positionState = component2.PositionState;
		if (animLogicParamsSetter.CharPositionState != positionState)
		{
			animLogicParamsSetter.CharPositionState = positionState;
			animLogicParams.CharPositionStateRef = (ECharParentMoveState)positionState;
		}
		ECharDirectionState directionState = component2.DirectionState;
		if (animLogicParamsSetter.CharCameraState != directionState)
		{
			animLogicParamsSetter.CharCameraState = directionState;
			animLogicParams.CharCameraStateRef = (ECharViewDirectionState)directionState;
		}
	}

	// Token: 0x0601912C RID: 102700 RVA: 0x00676A48 File Offset: 0x00674C48
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void UpdateAnimInfoUnifiedStateRoleNpc(int entityId, BP_ABPLogicParams_C animLogicParams)
	{
		CharacterAnimationComponent component = EntitySystem.Instance.GetComponent<CharacterAnimationComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return;
		}
		BaseUnifiedStateComponent component2 = EntitySystem.Instance.GetComponent<BaseUnifiedStateComponent>(entityId);
		if (component2 == null)
		{
			return;
		}
		AnimLogicParamsSetter animLogicParamsSetter = component.AnimLogicParamsSetter;
		global::ECharMoveState moveState = component2.MoveState;
		if (animLogicParamsSetter.CharMoveState != moveState)
		{
			animLogicParamsSetter.CharMoveState = moveState;
			animLogicParams.CharMoveStateRef = (ECharState)moveState;
		}
	}

	// Token: 0x0601912D RID: 102701 RVA: 0x00676AB4 File Offset: 0x00674CB4
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetIsCharRotateWithCameraWhenManipulate(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		return component != null && component.Valid && component.GetIsCharRotateWithCameraWhenManipulate();
	}

	// Token: 0x0601912E RID: 102702 RVA: 0x00676AE0 File Offset: 0x00674CE0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetIsUseCatapultUpAnim(int entityId)
	{
		CharacterActionComponent component = EntitySystem.Instance.GetComponent<CharacterActionComponent>(entityId);
		return component != null && component.Valid && component.IsUseCatapultUpAnim;
	}

	// Token: 0x0601912F RID: 102703 RVA: 0x00676B0C File Offset: 0x00674D0C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static float GetNextMultiSkillId(int entityId, int skillId)
	{
		CharacterSkillCdComponent component = EntitySystem.Instance.GetComponent<CharacterSkillCdComponent>(entityId);
		if (component != null && component.Valid)
		{
			return (float)component.GetNextMultiSkillId(skillId);
		}
		return 0f;
	}

	// Token: 0x06019130 RID: 102704 RVA: 0x00676B40 File Offset: 0x00674D40
	[UFunction(EFunctionFlags.FUNC_None)]
	public static int GetNextMultiSkillIdNew(int entityId, int skillId)
	{
		CharacterSkillCdComponent component = EntitySystem.Instance.GetComponent<CharacterSkillCdComponent>(entityId);
		if (component != null && component.Valid)
		{
			return (int)component.GetNextMultiSkillId(skillId);
		}
		return 0;
	}

	// Token: 0x06019131 RID: 102705 RVA: 0x00676B70 File Offset: 0x00674D70
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetManipulateInteractTargetCanInteract(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		return component == null || component.CheckCurrentTargetCanInteract();
	}

	// Token: 0x06019132 RID: 102706 RVA: 0x00676B94 File Offset: 0x00674D94
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetHookInteractTargetCanInteract(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		return component == null || component.CheckNextTargetCanInteract();
	}

	// Token: 0x06019133 RID: 102707 RVA: 0x00676BB8 File Offset: 0x00674DB8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetHookInteractTargetIsIgnorePlayerCollision(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		return component != null && component.GetNextTargetIsIgnorePlayerCollision();
	}

	// Token: 0x06019134 RID: 102708 RVA: 0x00676BDC File Offset: 0x00674DDC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool StartManipulateInteract(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		return component != null && component.StartPullGiantInteract();
	}

	// Token: 0x06019135 RID: 102709 RVA: 0x00676C00 File Offset: 0x00674E00
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EndManipulateInteract(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		if (component != null)
		{
			component.EndPullGiantInteract();
		}
	}

	// Token: 0x06019136 RID: 102710 RVA: 0x00676C24 File Offset: 0x00674E24
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool StartStatueInteract(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		return component != null && component.StartStatueInteract();
	}

	// Token: 0x06019137 RID: 102711 RVA: 0x00676C48 File Offset: 0x00674E48
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EndStatueInteract(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		if (component != null)
		{
			component.EndStatueInteract();
		}
	}

	// Token: 0x06019138 RID: 102712 RVA: 0x00676C6C File Offset: 0x00674E6C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool StartCustomInteract(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		return component != null && component.StartCustomInteract();
	}

	// Token: 0x06019139 RID: 102713 RVA: 0x00676C90 File Offset: 0x00674E90
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EndCustomInteract(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		if (component != null)
		{
			component.EndCustomInteract();
		}
	}

	// Token: 0x0601913A RID: 102714 RVA: 0x00676CB4 File Offset: 0x00674EB4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void QuantumDiffusionInteract(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		if (component != null)
		{
			component.QuantumDiffusionInteract();
		}
	}

	// Token: 0x0601913B RID: 102715 RVA: 0x00676CD8 File Offset: 0x00674ED8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static TArray<AActor> GetShootSwordManipulateInteractActors(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		TArray<AActor> tarray = new TArray<AActor>();
		if (component != null)
		{
			component.GetShootSwordManipulateInteractActors(tarray);
		}
		return tarray;
	}

	// Token: 0x0601913C RID: 102716 RVA: 0x00676D04 File Offset: 0x00674F04
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVectorDouble GetManipulateInteractLocation(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		if (component != null)
		{
			return component.GetTargetLocation().ToUeVector(false);
		}
		return default(FVectorDouble);
	}

	// Token: 0x0601913D RID: 102717 RVA: 0x00676D38 File Offset: 0x00674F38
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EnvironmentInfoDetect(int entityId, FVectorDouble location)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component != null)
		{
			WorldController.Instance.EnvironmentInfoUpdate(location, component.IsRoleAndCtrlByMe, false);
		}
	}

	// Token: 0x0601913E RID: 102718 RVA: 0x00676D68 File Offset: 0x00674F68
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void LockOnSpecifyTarget(int entityId, int targetEntityId)
	{
		CharacterLockOnComponent component = EntitySystem.Instance.GetComponent<CharacterLockOnComponent>(entityId);
		WorldEntity worldEntity = EntitySystem.Instance.Get<WorldEntity>(targetEntityId);
		if (component != null && component.Valid && worldEntity != null && worldEntity.Valid)
		{
			component.LockOnSpecifyTarget(new EntityHandle(worldEntity), "");
		}
	}

	// Token: 0x0601913F RID: 102719 RVA: 0x00676DB4 File Offset: 0x00674FB4
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsSkillInCd(int entityId, int skillId)
	{
		CharacterSkillCdComponent component = EntitySystem.Instance.GetComponent<CharacterSkillCdComponent>(entityId);
		return component != null && component.Valid && component.IsSkillInCd(skillId, true);
	}

	// Token: 0x06019140 RID: 102720 RVA: 0x00676DE4 File Offset: 0x00674FE4
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SendHookSkillUseLogData(int entityId, bool hasTarget)
	{
		HookSkillUseLogData hookSkillUseLogData = new HookSkillUseLogData();
		global::Vector actorLocationProxy = EntitySystem.Instance.GetComponent<BaseActorComponent>(entityId).ActorLocationProxy;
		hookSkillUseLogData.i_area_id = AreaModel.Instance.AreaInfo.Value.AreaId;
		hookSkillUseLogData.i_father_area_id = AreaModel.Instance.AreaInfo.Value.Father;
		hookSkillUseLogData.f_pos_x = (float)actorLocationProxy.X;
		hookSkillUseLogData.f_pos_y = (float)actorLocationProxy.Y;
		hookSkillUseLogData.f_pos_z = (float)actorLocationProxy.Z;
		hookSkillUseLogData.i_has_target = ((hasTarget > false) ? 1 : 0);
		LogReportController.Instance.UnitLogReport(hookSkillUseLogData);
	}

	// Token: 0x06019141 RID: 102721 RVA: 0x00676E84 File Offset: 0x00675084
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SendManipulateSkillUseLogData(int entityId, bool hasTarget)
	{
		ManipulateSkillUseLogData manipulateSkillUseLogData = new ManipulateSkillUseLogData();
		global::Vector actorLocationProxy = EntitySystem.Instance.GetComponent<BaseActorComponent>(entityId).ActorLocationProxy;
		manipulateSkillUseLogData.i_area_id = AreaModel.Instance.AreaInfo.Value.AreaId;
		manipulateSkillUseLogData.i_father_area_id = AreaModel.Instance.AreaInfo.Value.Father;
		manipulateSkillUseLogData.f_pos_x = (float)actorLocationProxy.X;
		manipulateSkillUseLogData.f_pos_y = (float)actorLocationProxy.Y;
		manipulateSkillUseLogData.f_pos_z = (float)actorLocationProxy.Z;
		manipulateSkillUseLogData.i_has_target = ((hasTarget > false) ? 1 : 0);
		LogReportController.Instance.UnitLogReport(manipulateSkillUseLogData);
	}

	// Token: 0x06019142 RID: 102722 RVA: 0x00676F24 File Offset: 0x00675124
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SendScanSkillUseLogData(int entityId, bool hasTarget)
	{
		ScanSkillUseLogData scanSkillUseLogData = new ScanSkillUseLogData();
		global::Vector actorLocationProxy = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId).ActorLocationProxy;
		scanSkillUseLogData.i_area_id = AreaModel.Instance.AreaInfo.Value.AreaId;
		scanSkillUseLogData.i_father_area_id = AreaModel.Instance.AreaInfo.Value.Father;
		scanSkillUseLogData.f_pos_x = (float)actorLocationProxy.X;
		scanSkillUseLogData.f_pos_y = (float)actorLocationProxy.Y;
		scanSkillUseLogData.f_pos_z = (float)actorLocationProxy.Z;
		scanSkillUseLogData.i_has_target = ((hasTarget > false) ? 1 : 0);
		LogReportController.Instance.UnitLogReport(scanSkillUseLogData);
	}

	// Token: 0x06019143 RID: 102723 RVA: 0x00676FC4 File Offset: 0x006751C4
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void DynamicAttachEntityToActor(int entityId, int targetEntityId, FName socketName)
	{
		WorldEntity worldEntity = EntitySystem.Instance.Get<WorldEntity>(entityId);
		SceneItemDynamicAttachTargetComponent component = EntitySystem.Instance.GetComponent<SceneItemDynamicAttachTargetComponent>(entityId);
		if (worldEntity == null || component == null)
		{
			return;
		}
		FTransformDouble ftransformDouble = new FTransformDouble();
		WorldEntity worldEntity2 = EntitySystem.Instance.Get<WorldEntity>(targetEntityId);
		AActor aactor;
		if (worldEntity2 == null)
		{
			aactor = null;
		}
		else
		{
			BaseActorComponent component2 = worldEntity2.GetComponent<BaseActorComponent>();
			aactor = ((component2 != null) ? component2.Owner : null);
		}
		AActor aactor2 = aactor;
		if (aactor2 == null)
		{
			return;
		}
		ACharacter acharacter = aactor2 as ACharacter;
		if (acharacter != null)
		{
			if (acharacter.Mesh.DoesSocketExist(socketName))
			{
				ftransformDouble = acharacter.Mesh.D_GetSocketTransform(socketName, ERelativeTransformSpace.RTS_World);
			}
		}
		else
		{
			ftransformDouble = aactor2.D_GetTransform();
		}
		if (worldEntity != null)
		{
			BaseActorComponent component3 = worldEntity.GetComponent<BaseActorComponent>();
			if (component3 != null)
			{
				component3.SetActorLocationAndRotation(ftransformDouble.GetLocation(), ftransformDouble.GetRotation().Rotator(), "unknown", false, null);
			}
		}
		long? num;
		if (worldEntity2 == null)
		{
			num = null;
		}
		else
		{
			CreatureDataComponent component4 = worldEntity2.GetComponent<CreatureDataComponent>();
			num = ((component4 != null) ? new long?(component4.GetCreatureDataId()) : null);
		}
		long? num2 = num;
		if (num2 == null)
		{
			return;
		}
		SceneItemDynamicAttachTargetComponent.AttachParam attachParam = new SceneItemDynamicAttachTargetComponent.AttachParam();
		attachParam.PosAttachType = SceneItemDynamicAttachTargetComponent.EAttachType.CalcUseCurrentRelation;
		attachParam.RotAttachType = SceneItemDynamicAttachTargetComponent.EAttachType.CalcUseCurrentRelation;
		component.RegEntityTargetByCreatureDataId(num2.Value, null, attachParam, "DynamicAttachEntityToActor");
	}

	// Token: 0x06019144 RID: 102724 RVA: 0x006770FC File Offset: 0x006752FC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetEntityEnable(int entityId, bool enable, UObject callObject, string reason)
	{
		if (callObject == null || !callObject.IsValid())
		{
			global::Log.Instance.Error(ELogModule.Entity, ELogAuthor.HXY, "调用SetEntityEnable失败，因为callObject为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		string reason2 = "[蓝图:" + callObject.GetName() + "] " + reason;
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity != null && entity.Valid)
		{
			CreatureController.Instance.SetEntityEnable(entity, enable, reason2, true);
		}
	}

	// Token: 0x06019145 RID: 102725 RVA: 0x00677174 File Offset: 0x00675374
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetActorVisible(int entityId, bool visible, bool collision, bool movable, string reason, bool sync = false)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity != null && entity.Valid)
		{
			CreatureController.Instance.SetActorVisible(entity, visible, collision, movable, reason, sync);
		}
	}

	// Token: 0x06019146 RID: 102726 RVA: 0x006771AC File Offset: 0x006753AC
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetSkillTargetDirection(int entityId, ESkillTargetDirection direction)
	{
		CharacterSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SetSkillTargetDirection(direction, ESkillTargetPriority.摇杆方向优先);
		}
	}

	// Token: 0x06019147 RID: 102727 RVA: 0x006771D8 File Offset: 0x006753D8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ChangeAiControllerDebugDraw(int entityId, bool debug)
	{
		CharacterAiComponent component = EntitySystem.Instance.GetComponent<CharacterAiComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SetDebugDraw(debug);
			return;
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.AI;
		ELogAuthor author = ELogAuthor.CWZ;
		string message = "实体不含AiComp";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", entityId);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06019148 RID: 102728 RVA: 0x00677230 File Offset: 0x00675430
	[UFunction(EFunctionFlags.FUNC_None)]
	public static EHitAnim GetBeHitAnimType(int typeId)
	{
		return (EHitAnim)typeId;
	}

	// Token: 0x06019149 RID: 102729 RVA: 0x00677234 File Offset: 0x00675434
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void StartInhalation(int entityId, float strength, float distance, bool isPowerfulMode, float checkAngle, ref TArray<FGameplayTag> tag)
	{
		RoleInhalationComponent component = EntitySystem.Instance.GetComponent<RoleInhalationComponent>(entityId);
		if (component != null && component.Valid)
		{
			List<FGameplayTag> list = new List<FGameplayTag>();
			for (int i = 0; i < tag.Num(); i++)
			{
				list.Add(tag.Get(i));
			}
			component.StartInhalation(strength, distance, isPowerfulMode, checkAngle, list.ToArray());
			component.StartInhalation(strength, distance, isPowerfulMode, checkAngle, list.ToArray());
			component.StartInhalation(strength, distance, isPowerfulMode, checkAngle, list.ToArray());
		}
	}

	// Token: 0x0601914A RID: 102730 RVA: 0x006772B4 File Offset: 0x006754B4
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void StopInhalation(int entityId)
	{
		RoleInhalationComponent component = EntitySystem.Instance.GetComponent<RoleInhalationComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.StopInhalation();
		}
	}

	// Token: 0x0601914B RID: 102731 RVA: 0x006772E0 File Offset: 0x006754E0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	[return: Nullable(2)]
	public static UKuroDebugMovementComponent TryGetDebugMovementComp(string pbDataId)
	{
		int num = 0;
		try
		{
			num = int.Parse(pbDataId);
		}
		catch
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "添加监听输入的PbDataId转number异常";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pbDataId", pbDataId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		if (num == 0)
		{
			return null;
		}
		List<EntityHandle> list = new List<EntityHandle>();
		CreatureModel.Instance.GetEntitiesWithPbDataId(num, ref list);
		if (list.Count == 0)
		{
			return null;
		}
		EntityHandle entityHandle = list[0];
		object obj;
		if (entityHandle == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = entityHandle.Entity;
			obj = ((entity != null) ? entity.GetComponent<CreatureDataComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 != null && obj2.IsVehicle())
		{
			EntityHandle entityHandle2 = list[0];
			object obj3;
			if (entityHandle2 == null)
			{
				obj3 = null;
			}
			else
			{
				WorldEntity entity2 = entityHandle2.Entity;
				if (entity2 == null)
				{
					obj3 = null;
				}
				else
				{
					VehicleActorComponent component = entity2.GetComponent<VehicleActorComponent>();
					obj3 = ((component != null) ? component.DebugMovementComp : null);
				}
			}
			object obj4 = obj3;
			if (obj4 != null)
			{
				obj4.SetDebug(true);
			}
			if (obj4 == null)
			{
				return null;
			}
			return obj4.UeDebugComp;
		}
		else
		{
			EntityHandle entityHandle3 = list[0];
			object obj5;
			if (entityHandle3 == null)
			{
				obj5 = null;
			}
			else
			{
				WorldEntity entity3 = entityHandle3.Entity;
				if (entity3 == null)
				{
					obj5 = null;
				}
				else
				{
					CharacterActorComponent component2 = entity3.GetComponent<CharacterActorComponent>();
					obj5 = ((component2 != null) ? component2.DebugMovementComp : null);
				}
			}
			object obj6 = obj5;
			if (obj6 != null)
			{
				obj6.SetDebug(true);
			}
			if (obj6 == null)
			{
				return null;
			}
			return obj6.UeDebugComp;
		}
		UKuroDebugMovementComponent result;
		return result;
	}

	// Token: 0x0601914C RID: 102732 RVA: 0x00677410 File Offset: 0x00675610
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void TryPlayLinkAnim()
	{
		BattleLinkController.Instance.TryPlaySplitScreen();
	}

	// Token: 0x0601914D RID: 102733 RVA: 0x0067741C File Offset: 0x0067561C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FVectorDouble TraceGround(int entityId, FVectorDouble start, FVectorDouble end, bool draw)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		CharacterActorComponent characterActorComponent = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
		if (characterActorComponent != null)
		{
			double num = FVectorDouble.Dist(start, end);
			ValueTuple<bool, global::Vector> valueTuple = SkillBehaviorMisc.TraceGroundWithGravity(characterActorComponent, global::Vector.Create(start), draw, (float)num);
			if (valueTuple.Item1 && valueTuple.Item2 != null)
			{
				global::Vector item = valueTuple.Item2;
				return new FVectorDouble(item.X, item.Y, item.Z);
			}
		}
		return default(FVectorDouble);
	}

	// Token: 0x0601914E RID: 102734 RVA: 0x0067749C File Offset: 0x0067569C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ChangePhantomTeam(int phantomFormationId, ref TArray<FGameplayTag> skillTriggerTags)
	{
		List<FGameplayTag> list = new List<FGameplayTag>();
		for (int i = 0; i < skillTriggerTags.Num(); i++)
		{
			list.Add(skillTriggerTags.Get(i));
		}
		SceneTeamController.Instance.ChangePhantomTeam(phantomFormationId, list.ToArray());
	}

	// Token: 0x0601914F RID: 102735 RVA: 0x006774E0 File Offset: 0x006756E0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void RevertPhantomTeam()
	{
		SceneTeamController.Instance.RevertPhantomTeam();
	}

	// Token: 0x06019150 RID: 102736 RVA: 0x006774EC File Offset: 0x006756EC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetFormationAttribute(int type)
	{
		FormationAttributeModel instance = FormationAttributeModel.Instance;
		if (instance == null)
		{
			return 0f;
		}
		return instance.GetValue((EFormationAttributeId)type);
	}

	// Token: 0x06019151 RID: 102737 RVA: 0x00677504 File Offset: 0x00675704
	[UFunction(EFunctionFlags.FUNC_None)]
	public static float GetEntityDeltaMillisecond(int entityId)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity != null)
		{
			float num = Time.Instance.DeltaTime * entity.TimeDilation;
			PawnTimeScaleComponent component = entity.GetComponent<PawnTimeScaleComponent>();
			return (float)((int)(num * ((component != null) ? component.CurrentTimeScale : 1f)));
		}
		return 1f;
	}

	// Token: 0x06019152 RID: 102738 RVA: 0x00677550 File Offset: 0x00675750
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SyncTwoEntityLocationAndRotation(int fromEntityId, int toEntityId)
	{
		CharacterModel instance = CharacterModel.Instance;
		EntityHandle entityHandle = (instance != null) ? instance.GetHandle(fromEntityId) : null;
		CharacterModel instance2 = CharacterModel.Instance;
		EntityHandle entityHandle2 = (instance2 != null) ? instance2.GetHandle(toEntityId) : null;
		if (entityHandle != null && entityHandle.Valid && entityHandle2 != null && entityHandle2.Valid)
		{
			WorldEntity entity = entityHandle.Entity;
			BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
			WorldEntity entity2 = entityHandle2.Entity;
			BaseActorComponent baseActorComponent2 = (entity2 != null) ? entity2.GetComponent<BaseActorComponent>() : null;
			if (baseActorComponent != null && baseActorComponent2 != null)
			{
				baseActorComponent2.SetActorLocationAndRotation(baseActorComponent.ActorLocation, baseActorComponent.ActorRotation, "SyncTwoEntityLocationAndRotation", false, null);
			}
		}
	}

	// Token: 0x06019153 RID: 102739 RVA: 0x006775E8 File Offset: 0x006757E8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static AActor GetFishingBoat()
	{
		EntityHandle entityHandle = FishingModel.Instance.GetShipData().GetEntityHandle();
		WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
		if (worldEntity == null || !worldEntity.IsInit)
		{
			return null;
		}
		BaseActorComponent component = worldEntity.GetComponent<BaseActorComponent>();
		if (component == null)
		{
			return null;
		}
		return component.Owner;
	}

	// Token: 0x06019154 RID: 102740 RVA: 0x00677630 File Offset: 0x00675830
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void FishingBoatSprint(int entityId, float maxSpeedRatio, int exceedLimitDuration, int duration)
	{
		FishingBoatPerformComponent component = EntitySystem.Instance.GetComponent<FishingBoatPerformComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.FishingBoatEnterSprint(maxSpeedRatio, (float)exceedLimitDuration, (float)duration);
		}
	}

	// Token: 0x06019155 RID: 102741 RVA: 0x0067765F File Offset: 0x0067585F
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void FishingBoatSkill(EFishingSkillType type)
	{
		FishingController.Instance.BeginFishingSkill(type);
	}

	// Token: 0x06019156 RID: 102742 RVA: 0x0067766C File Offset: 0x0067586C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static EMorphType GetCharacterMorphType(int entityId)
	{
		CharacterMorphComponent component = EntitySystem.Instance.GetComponent<CharacterMorphComponent>(entityId);
		if (component == null)
		{
			return EMorphType.默认形态;
		}
		return component.GetMorphType();
	}

	// Token: 0x06019157 RID: 102743 RVA: 0x00677684 File Offset: 0x00675884
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetCharacterMorphType(int entityId, EMorphType morphType)
	{
		CharacterMorphComponent component = EntitySystem.Instance.GetComponent<CharacterMorphComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetMorphType(morphType);
	}

	// Token: 0x06019158 RID: 102744 RVA: 0x0067769C File Offset: 0x0067589C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetSpecialEnergyAttrValue(int entityId, int attrId, int value)
	{
		AbilityUtils.SetSpecialEnergyAttrValue(entityId, attrId, (float)value);
	}

	// Token: 0x06019159 RID: 102745 RVA: 0x006776A8 File Offset: 0x006758A8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static int GetFuLuoLuoSpecialEnergyType(int entityId, int index)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity != null && entity.Valid)
		{
			return AbilityUtils.GetFuLuoLuoSpecialEnergyType(entity, index);
		}
		return 0;
	}

	// Token: 0x0601915A RID: 102746 RVA: 0x006776D8 File Offset: 0x006758D8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void StartBattleQte(int entityId, int skillId, int battleQteId)
	{
		EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
		CharacterSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSkillComponent>(entityId);
		long? num;
		if (component == null)
		{
			num = null;
		}
		else
		{
			Skill skill = component.GetSkill(skillId);
			num = ((skill != null) ? skill.CombatMessageId : null);
		}
		long? num2 = num;
		if (entityById != null && num2 != null)
		{
			BattleQteController.Instance.StartBattleQte(battleQteId, num2.Value, entityById, EBattleQteSource.Gameplay);
		}
	}

	// Token: 0x0601915B RID: 102747 RVA: 0x00677748 File Offset: 0x00675948
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void StopGroup1Skill(int entityId, string reason)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.StopGroup1Skill(reason);
		}
	}

	// Token: 0x0601915C RID: 102748 RVA: 0x00677773 File Offset: 0x00675973
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static SCharacterLocationsAndRadius GetCharactersLocationNearBy(FVectorDouble center, float distance, int maxCount)
	{
		return CreatureController.Instance.GetCharactersLocationNearBy(center, distance, maxCount);
	}

	// Token: 0x0601915D RID: 102749 RVA: 0x00677782 File Offset: 0x00675982
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static TsBaseCharacter GetCurrentPlayer()
	{
		return Global.BaseCharacter;
	}

	// Token: 0x0601915E RID: 102750 RVA: 0x0067778C File Offset: 0x0067598C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsEnemy(TsBaseCharacter owner, TsBaseCharacter other)
	{
		Entity entityNoBlueprint = other.GetEntityNoBlueprint();
		if (owner != null)
		{
			if (entityNoBlueprint != null)
			{
				BaseTagComponent component = entityNoBlueprint.GetComponent<BaseTagComponent>();
				if (((component != null) ? new bool?(component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.不被敌方子弹命中"])) : null).GetValueOrDefault())
				{
					return false;
				}
			}
			Entity entityNoBlueprint2 = owner.GetEntityNoBlueprint();
			CreatureDataComponent creatureDataComponent = (entityNoBlueprint2 != null) ? entityNoBlueprint2.GetComponent<CreatureDataComponent>() : null;
			if (creatureDataComponent == null)
			{
				return false;
			}
			CreatureDataComponent creatureDataComponent2 = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CreatureDataComponent>() : null;
			if (creatureDataComponent2 == null)
			{
				return false;
			}
			ECamp selfCamp = (creatureDataComponent.GetEntityType() != EEntityType.Player) ? creatureDataComponent.GetEntityCamp() : ECamp.Player;
			ECamp targetCamp = (creatureDataComponent2.GetEntityType() != EEntityType.Player) ? creatureDataComponent2.GetEntityCamp() : ECamp.Player;
			return ERelation.Enemy * CampUtils.GetCampRelationship(selfCamp, targetCamp) == (ERelation)4;
		}
		return false;
	}

	// Token: 0x0601915F RID: 102751 RVA: 0x00677840 File Offset: 0x00675A40
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetWalkOffLedge(int entityId, bool walkOff)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SetWalkOffLedgeRecord(walkOff);
		}
	}

	// Token: 0x06019160 RID: 102752 RVA: 0x0067786C File Offset: 0x00675A6C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void StartFlyingFeather(TsBaseCharacter owner, FVectorDouble initLocation, BP_FlyingFeatherConfig_C config)
	{
		if (owner == null)
		{
			return;
		}
		int entityId = owner.EntityId;
		long? contextId = BulletUtil.GetSkillContextId(owner.GetEntityNoBlueprint(), config.SkillId);
		if (TimerSystem.Instance.Has(TsGameplayBlueprintFunctionLibrary.FlyingFeatherHandle))
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[FlyingFeather] 存在异常的飞雷神羽毛定时器，移除定时器";
			string item = "HandleId";
			TimerHandle flyingFeatherHandle = TsGameplayBlueprintFunctionLibrary.FlyingFeatherHandle;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (flyingFeatherHandle != null) ? new int?(flyingFeatherHandle.Id) : null);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			TimerSystem.Instance.Remove(TsGameplayBlueprintFunctionLibrary.FlyingFeatherHandle);
			TsGameplayBlueprintFunctionLibrary.FlyingFeatherHandle = null;
		}
		if (config.BulletDelayTime > 20 && config.BulletDelayTime < 180000)
		{
			TsGameplayBlueprintFunctionLibrary.FlyingFeatherHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				TsGameplayBlueprintFunctionLibrary.FlyingFeatherHandle = null;
				TsGameplayBlueprintFunctionLibrary.EmitFeatherBullet(owner, initLocation, config, entityId, contextId);
			}, (float)config.BulletDelayTime, null, null, true, 1f);
			return;
		}
		TsGameplayBlueprintFunctionLibrary.EmitFeatherBullet(owner, initLocation, config, entityId, contextId);
	}

	// Token: 0x06019161 RID: 102753 RVA: 0x006779B4 File Offset: 0x00675BB4
	[NullableContext(1)]
	private static void EmitFeatherBullet(TsBaseCharacter owner, FVectorDouble initLocation, BP_FlyingFeatherConfig_C config, int entityId, long? contextId)
	{
		TsGameplayBlueprintFunctionLibrary.<>c__DisplayClass290_0 CS$<>8__locals1 = new TsGameplayBlueprintFunctionLibrary.<>c__DisplayClass290_0();
		CS$<>8__locals1.entityId = entityId;
		CS$<>8__locals1.owner = owner;
		if (CS$<>8__locals1.owner != null)
		{
			CharacterActorComponent characterActorComponent = CS$<>8__locals1.owner.CharacterActorComponent;
			if (characterActorComponent != null && characterActorComponent.Entity.Valid)
			{
				Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(CS$<>8__locals1.entityId, config.FeatherTarget);
				if (vectorValueByEntity != null)
				{
					MathUtils.Instance.CommonTempVector.Set((double)vectorValueByEntity.X, (double)vectorValueByEntity.Y, (double)vectorValueByEntity.Z);
				}
				else
				{
					MathUtils.Instance.CommonTempVector.DeepCopy(initLocation);
				}
				BulletController.BulletCreateParams bulletCreateParams = new BulletController.BulletCreateParams
				{
					SkillId = config.SkillId,
					SkillContextId = contextId,
					InitTargetLocation = new FVectorDouble?(MathUtils.Instance.CommonTempVector.ToUeVector(false))
				};
				BulletEntity bulletEntity = BulletController.Instance.CreateBulletCustomTarget(CS$<>8__locals1.owner, config.BulletId, new FTransformDouble?(CS$<>8__locals1.owner.D_GetTransform()), bulletCreateParams, contextId, global::EBulletCreateSource.Others);
				CS$<>8__locals1.bulletId = ((bulletEntity != null) ? new int?(bulletEntity.GetBulletInfo().BulletEntityId) : null);
				TsGameplayBlueprintFunctionLibrary.FlyingFeatherHandle = TimerSystem.Instance.Delay(delegate(float _)
				{
					TsGameplayBlueprintFunctionLibrary.FlyingFeatherHandle = null;
					TsGameplayBlueprintFunctionLibrary.ChangeFlyingFeatherMove(new int?(CS$<>8__locals1.entityId));
					CharacterActorComponent characterActorComponent2 = CS$<>8__locals1.owner.CharacterActorComponent;
					Entity entity = (characterActorComponent2 != null) ? characterActorComponent2.Entity : null;
					if (entity != null && EventSystem.Instance.HasWithTarget(entity, EEventName.BulletDestroy, new Action<BulletInfo>(base.<EmitFeatherBullet>g__bulletDestroy|0)))
					{
						EventSystem.Instance.RemoveWithTarget(entity, EEventName.BulletDestroy, new Action<BulletInfo>(base.<EmitFeatherBullet>g__bulletDestroy|0));
					}
				}, (float)MathUtils.Instance.Clamp(config.MaxChangeStateTime, 20, 180000), null, null, true, 1f);
				EventSystem.Instance.AddWithTarget(CS$<>8__locals1.owner.CharacterActorComponent.Entity, EEventName.BulletDestroy, new Action<BulletInfo>(CS$<>8__locals1.<EmitFeatherBullet>g__bulletDestroy|0));
				return;
			}
		}
	}

	// Token: 0x06019162 RID: 102754 RVA: 0x00677B3C File Offset: 0x00675D3C
	private static void ChangeFlyingFeatherMove(int? entityId)
	{
		if (entityId == null)
		{
			return;
		}
		BaseTagComponent component = EntitySystem.Instance.GetComponent<BaseTagComponent>(entityId.Value);
		BaseSceneInteractComponent component2 = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId.Value);
		if (component == null || (component2 == null || !component2.GetIsHooking()))
		{
			return;
		}
		if (!component.HasTag(GameplayTagDefine.EGameplayTagId["角色.FP_R2T1CalbrenaMd10011.技能.飞雷神移动中"]))
		{
			component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["角色.FP_R2T1CalbrenaMd10011.技能.飞雷神移动中"]));
		}
	}

	// Token: 0x06019163 RID: 102755 RVA: 0x00677BC0 File Offset: 0x00675DC0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	[return: Nullable(2)]
	public static string GetFlyingFeatherTargetId(TsBaseCharacter owner)
	{
		if (owner == null)
		{
			return null;
		}
		int entityId = owner.EntityId;
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		int? num;
		if (component == null)
		{
			num = null;
		}
		else
		{
			GrapplingHookPointComponent currentTarget = component.GetCurrentTarget();
			num = ((currentTarget != null) ? new int?(currentTarget.GetHookBindEntityConfig()) : null);
		}
		int? num2 = num;
		if (component == null || num2 == null)
		{
			return null;
		}
		CreatureModel instance = CreatureModel.Instance;
		EntityHandle entityHandle = (instance != null) ? instance.GetEntityByPbDataId(num2.Value) : null;
		if (entityHandle == null)
		{
			return null;
		}
		return entityHandle.Id.ToString();
	}

	// Token: 0x06019164 RID: 102756 RVA: 0x00677C4C File Offset: 0x00675E4C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	[return: Nullable(2)]
	public static AActor AddFlyingFeatherTargetTag(FGameplayTag tag, string entityId)
	{
		CreatureModel instance = CreatureModel.Instance;
		EntityHandle entityHandle = (instance != null) ? instance.GetEntityById(int.Parse(entityId)) : null;
		if (entityHandle == null)
		{
			return null;
		}
		WorldEntity entity = entityHandle.Entity;
		BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
		if ((baseTagComponent == null || !baseTagComponent.HasTag(tag.TagId())) && baseTagComponent != null)
		{
			baseTagComponent.AddTag(new int?(tag.TagId()));
		}
		WorldEntity entity2 = entityHandle.Entity;
		BaseActorComponent baseActorComponent = (entity2 != null) ? entity2.GetComponent<BaseActorComponent>() : null;
		if (baseActorComponent == null)
		{
			return null;
		}
		return baseActorComponent.Owner;
	}

	// Token: 0x06019165 RID: 102757 RVA: 0x00677CD4 File Offset: 0x00675ED4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FVectorDouble UpdateFlyingFeather(TsBaseCharacter owner, string target)
	{
		if (owner == null)
		{
			return default(FVectorDouble);
		}
		int entityId = owner.EntityId;
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		AActor aactor = (component != null) ? component.GetCurrentTargetActor() : null;
		if (component == null || aactor == null)
		{
			return default(FVectorDouble);
		}
		global::Vector actorLocationProxy = owner.CharacterActorComponent.ActorLocationProxy;
		FVectorDouble fvectorDouble = aactor.D_K2_GetActorLocation();
		BlackboardController.Instance.SetVectorValueByEntity(entityId, target, (double)((float)fvectorDouble.X), (double)((float)fvectorDouble.Y), (double)((float)fvectorDouble.Z));
		string flyingFeatherTargetId = TsGameplayBlueprintFunctionLibrary.GetFlyingFeatherTargetId(owner);
		if (flyingFeatherTargetId != null)
		{
			CreatureModel instance = CreatureModel.Instance;
			EntityHandle entityHandle = (instance != null) ? instance.GetEntityById(int.Parse(flyingFeatherTargetId)) : null;
			BaseActorComponent baseActorComponent;
			if (entityHandle == null)
			{
				baseActorComponent = null;
			}
			else
			{
				WorldEntity entity = entityHandle.Entity;
				baseActorComponent = ((entity != null) ? entity.GetComponent<BaseActorComponent>() : null);
			}
			BaseActorComponent baseActorComponent2 = baseActorComponent;
			if (baseActorComponent2 != null)
			{
				MathUtils.Instance.CommonTempVector.DeepCopy(baseActorComponent2.ActorLocationProxy);
				MathUtils.Instance.CommonTempVector.SubtractionEqual(actorLocationProxy);
				double num = MathUtils.Instance.CommonTempVector.Size();
				MathUtils.Instance.CommonTempVector.Normalize(9.99999993922529E-09);
				MathUtils.Instance.CommonTempVector.MultiplyEqual(Math.Max(0.0, num - (double)baseActorComponent2.GetRadius()));
				MathUtils.Instance.CommonTempVector.AdditionEqual(actorLocationProxy);
				return MathUtils.Instance.CommonTempVector.ToUeVector(false);
			}
		}
		return fvectorDouble;
	}

	// Token: 0x06019166 RID: 102758 RVA: 0x00677E3B File Offset: 0x0067603B
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EmitGlobalClientEvent(FGameplayTag eventNameTag)
	{
		EventSystem.Instance.Emit<FGameplayTag>(EEventName.CheckClientEvent, eventNameTag);
	}

	// Token: 0x06019167 RID: 102759 RVA: 0x00677E50 File Offset: 0x00676050
	[UFunction(EFunctionFlags.FUNC_None)]
	public static int GetDriverEntityId(int vehicleEntityId)
	{
		BaseVehiclePerformComponent component = EntitySystem.Instance.GetComponent<BaseVehiclePerformComponent>(vehicleEntityId);
		Entity entity = (component != null) ? component.Driver : null;
		if (entity == null)
		{
			return 0;
		}
		return entity.Id;
	}

	// Token: 0x06019168 RID: 102760 RVA: 0x00677E80 File Offset: 0x00676080
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void StartCableWayMove(int id, UKuroBooleanEventBinder eventBinder)
	{
		Entity entity = EntitySystem.Instance.Get(id);
		EntityHandle handleByEntity = CharacterModel.Instance.GetHandleByEntity(entity);
		if (handleByEntity == null || !handleByEntity.Valid)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.CH;
			string message = "开始索道移动失败，实体无效";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		int? num = (baseCharacter != null) ? new int?(baseCharacter.GetEntityIdNoBlueprint()) : null;
		if (num == null || id != num.Value)
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.CH;
			string message2 = "开始索道移动失败，实体为非主控角色";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("id", id);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(id);
		GrapplingHookPointComponent grapplingHookPointComponent = (component != null) ? component.GetCurrentTarget() : null;
		if (grapplingHookPointComponent == null || grapplingHookPointComponent.GetHookInteractType().GetValueOrDefault() != EHookInteractType.CableWay)
		{
			global::Log instance3 = global::Log.Instance;
			ELogModule module3 = ELogModule.Entity;
			ELogAuthor author3 = ELogAuthor.CH;
			string message3 = "开始索道移动失败，当前目标不是索道";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("id", id);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return;
		}
		int splineEntityId = (grapplingHookPointComponent.GetHookInteractConfig() as ICableWay).SplineEntityId;
		if (SplineMoveTaskController.Instance.GetEntityCurSplineMoveTask((long)id) != null)
		{
			global::Log instance4 = global::Log.Instance;
			ELogModule module4 = ELogModule.Entity;
			ELogAuthor author4 = ELogAuthor.CH;
			string message4 = "开始索道移动时，角色还有样条任务未结束，清理旧任务";
			ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("id", id);
			instance4.Warn(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
			SplineMoveTaskController.Instance.EndEntityTasks((long)id);
		}
		Entity entity4 = entity;
		if (entity4 != null)
		{
			BaseTagComponent component2 = entity4.GetComponent<BaseTagComponent>();
			if (component2 != null)
			{
				component2.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.关卡运动.关卡运动类型.滑轨UI.隐藏跳跃按键"]));
			}
		}
		Entity entity2 = entity;
		CharacterRailSlideComponent characterRailSlideComponent = (entity2 != null) ? entity2.GetComponent<CharacterRailSlideComponent>() : null;
		if (characterRailSlideComponent == null)
		{
			return;
		}
		characterRailSlideComponent.StartRailSlide(splineEntityId, "/Game/Aki/Data/Level/RailSlide/DA_Strop.DA_Strop", delegate(bool isInterrupt)
		{
			global::Log instance5 = global::Log.Instance;
			ELogModule module5 = ELogModule.Entity;
			ELogAuthor author5 = ELogAuthor.CH;
			string message5 = "索道移动结束";
			ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>("id", id);
			instance5.Info(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
			Entity entity3 = entity;
			if (entity3 != null)
			{
				BaseTagComponent component3 = entity3.GetComponent<BaseTagComponent>();
				if (component3 != null)
				{
					component3.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.关卡运动.关卡运动类型.滑轨UI.隐藏跳跃按键"]));
				}
			}
			eventBinder.Callback.Broadcast(isInterrupt);
		}, null);
	}

	// Token: 0x06019169 RID: 102761 RVA: 0x006780A0 File Offset: 0x006762A0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void StopCableWayMove(int id)
	{
		Entity entity = EntitySystem.Instance.Get(id);
		EntityHandle handleByEntity = CharacterModel.Instance.GetHandleByEntity(entity);
		if (handleByEntity == null || !handleByEntity.Valid)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.CH;
			string message = "结束索道移动失败，实体无效";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		int? num = (baseCharacter != null) ? new int?(baseCharacter.GetEntityIdNoBlueprint()) : null;
		if (num == null || id != num.Value)
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.CH;
			string message2 = "结束索道移动失败，实体为非主控角色";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("id", id);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		CharacterRailSlideComponent characterRailSlideComponent = (entity != null) ? entity.GetComponent<CharacterRailSlideComponent>() : null;
		if (characterRailSlideComponent == null)
		{
			return;
		}
		characterRailSlideComponent.SetExitSplineRailSlide("GA主动停止", true);
	}

	// Token: 0x0601916A RID: 102762 RVA: 0x00678180 File Offset: 0x00676380
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static int GetBuffInstigatorId(int entityId, int buffId, bool getInstigatorSummoner)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		ActiveBuffInternal activeBuffInternal = (baseBuffComponent != null) ? baseBuffComponent.GetBuffById((long)buffId) : null;
		Entity entity2 = (activeBuffInternal != null) ? activeBuffInternal.GetInstigator() : null;
		if (entity2 == null)
		{
			return -1;
		}
		if (!getInstigatorSummoner)
		{
			return entity2.Id;
		}
		CreatureDataComponent component = entity2.GetComponent<CreatureDataComponent>();
		long? num = (component != null) ? new long?(component.GetSummonerId()) : null;
		if (num != null)
		{
			EntityHandle entity3 = CreatureModel.Instance.GetEntity(num.Value);
			WorldEntity worldEntity = (entity3 != null) ? entity3.Entity : null;
			if (worldEntity != null)
			{
				return worldEntity.Id;
			}
		}
		return entity2.Id;
	}

	// Token: 0x0601916B RID: 102763 RVA: 0x00678228 File Offset: 0x00676428
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetSubMeshOrder(int entityId, string meshName, bool visible, [Nullable(2)] PD_CharacterControllerData_C charControllerData, [Nullable(new byte[]
	{
		2,
		1
	})] TSoftObjectPtr<UEffectModelBase> effectDataAssetRef, float delayTime)
	{
		SubMeshComponent component = EntitySystem.Instance.GetComponent<SubMeshComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SetSubMeshOrder(meshName, visible, charControllerData, effectDataAssetRef, delayTime * 1000f);
		}
	}

	// Token: 0x0601916C RID: 102764 RVA: 0x0067825F File Offset: 0x0067645F
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetPilotThrowSpeed()
	{
		return PilotThrowModel.Instance.LaunchSpeed;
	}

	// Token: 0x0601916D RID: 102765 RVA: 0x0067826B File Offset: 0x0067646B
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVectorDouble GetPilotThrowDirection()
	{
		return PilotThrowModel.Instance.LaunchDirection.ToUeVector(false);
	}

	// Token: 0x0601916E RID: 102766 RVA: 0x0067827D File Offset: 0x0067647D
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetPilotThrowGravity()
	{
		return PilotThrowModel.Instance.LaunchGravity;
	}

	// Token: 0x0601916F RID: 102767 RVA: 0x00678289 File Offset: 0x00676489
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetPilotThrowNeedMotorRide()
	{
		return PilotThrowModel.Instance.NeedMotorRide;
	}

	// Token: 0x06019170 RID: 102768 RVA: 0x00678295 File Offset: 0x00676495
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetPilotThrowIsDisableInterrupt()
	{
		return PilotThrowModel.Instance.DisableInterrupt;
	}

	// Token: 0x06019171 RID: 102769 RVA: 0x006782A4 File Offset: 0x006764A4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void OpenPilotThrowGameplayCamera(int targetEntityId)
	{
		GrapplingHookPointComponent component = EntitySystem.Instance.GetComponent<GrapplingHookPointComponent>(targetEntityId);
		if (component == null || !component.Valid)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelPlay;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[TsExploreComponentBlueprintFunctionLibrary]开启铁驭玩法相机失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TargetEntityId", targetEntityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		IHookInteractType hookInteractType = (component != null) ? component.GetHookInteractConfig() : null;
		if (hookInteractType == null || hookInteractType.Type != EHookInteractType.PilotThrow)
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.CH;
			string message2 = "开启铁驭玩法相机失败, 当前探索组件正在交互的目标交互类型不合法";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EHookInteractType", (hookInteractType != null) ? new EHookInteractType?(hookInteractType.Type) : null);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		IPilotThrow pilotThrow = hookInteractType as IPilotThrow;
		if (pilotThrow == null)
		{
			global::Log instance3 = global::Log.Instance;
			ELogModule module3 = ELogModule.Entity;
			ELogAuthor author3 = ELogAuthor.CH;
			string message3 = "开启铁驭玩法相机失败, PilotThrow配置无效";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("TargetEntityId", targetEntityId);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return;
		}
		PilotThrowController.Instance.EnterInteractHookPoint(component.EntityConfigId, pilotThrow.TitanEntityId, pilotThrow.TargetList);
		CameraController.Instance.MainModel.FightCamera.LogicComponent.EnterSpecialGameplayCamera(1);
	}

	// Token: 0x06019172 RID: 102770 RVA: 0x006783D4 File Offset: 0x006765D4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static USkeletalMeshComponent GetCurrentTargetPilotSkeletalMeshComponent(int entityId)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		EntityHandle handleByEntity = CharacterModel.Instance.GetHandleByEntity(entity);
		if (handleByEntity == null || !handleByEntity.Valid)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.CH;
			string message = "获取当前钩锁目标铁驭Actor失败，实体无效";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", entityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		GrapplingHookPointComponent grapplingHookPointComponent = (component != null) ? component.GetCurrentTarget() : null;
		if (grapplingHookPointComponent == null || grapplingHookPointComponent.GetHookInteractType().GetValueOrDefault() != EHookInteractType.PilotThrow)
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.CH;
			string message2 = "获取当前钩锁目标铁驭Actor失败，当前目标不是铁驭钩锁";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("id", entityId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		IPilotThrow pilotThrow = grapplingHookPointComponent.GetHookInteractConfig() as IPilotThrow;
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId((pilotThrow != null) ? pilotThrow.TitanEntityId : 0);
		WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
		if (worldEntity == null || !worldEntity.Valid)
		{
			global::Log instance3 = global::Log.Instance;
			ELogModule module3 = ELogModule.Entity;
			ELogAuthor author3 = ELogAuthor.CH;
			string message3 = "获取当前钩锁目标铁驭Actor失败，当前目标不是铁驭";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("id", entityId);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return null;
		}
		BaseActorComponent component2 = worldEntity.GetComponent<BaseActorComponent>();
		AActor aactor = (component2 != null) ? component2.Owner : null;
		if (aactor == null || !aactor.IsValid())
		{
			global::Log instance4 = global::Log.Instance;
			ELogModule module4 = ELogModule.Entity;
			ELogAuthor author4 = ELogAuthor.CH;
			string message4 = "获取当前钩锁目标铁驭Actor失败，铁驭Actor无效";
			ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("id", entityId);
			instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
			return null;
		}
		return ULGUIBPLibrary.GetComponentInChildren(aactor, USkeletalMeshComponent.StaticClass(), false) as USkeletalMeshComponent;
	}

	// Token: 0x06019173 RID: 102771 RVA: 0x00678561 File Offset: 0x00676761
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FVectorDouble GetPilotCurrentInRangePoint()
	{
		global::Vector currentInRangePoint = PilotThrowModel.Instance.CurrentInRangePoint;
		if (currentInRangePoint == null)
		{
			return global::Vector.ZeroVectorDouble;
		}
		return currentInRangePoint.ToUeVector(false);
	}

	// Token: 0x06019174 RID: 102772 RVA: 0x00678580 File Offset: 0x00676780
	[UFunction(EFunctionFlags.FUNC_None)]
	public static float GetVehicleCatapultUnitRisingTime(int entityId)
	{
		VehicleCatapultComponent component = EntitySystem.Instance.GetComponent<VehicleCatapultComponent>(entityId);
		BigJumpUnit bigJumpUnit = (component != null) ? component.GetCatapultUnit() : null;
		if (bigJumpUnit == null)
		{
			return 0f;
		}
		return bigJumpUnit.RisingTime;
	}

	// Token: 0x06019175 RID: 102773 RVA: 0x006785B4 File Offset: 0x006767B4
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void GuessJokerNpcTurnToIdlePerform()
	{
		GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
		if (instance == null || !instance.InGame)
		{
			return;
		}
		GuessJokerGamePlayModel.Instance.PushPlotActions(new GuessJokerPlotAction[]
		{
			new GuessJokerPlotAction(EGuessJokerPlayerType.Ai, EGuessJokerPlotTiming.AiIdlePerformance, null)
		});
	}

	// Token: 0x06019176 RID: 102774 RVA: 0x006785FB File Offset: 0x006767FB
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void LevelFlowDeadlySkeletonMeshCastToCharacter()
	{
		LevelFlowModel.Instance.ResetLevelFlow(false);
	}

	// Token: 0x06019177 RID: 102775 RVA: 0x00678608 File Offset: 0x00676808
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void LevelFlowAddBuff(int entityId, int buffId)
	{
		LevelFlowModel.Instance.PushDynamicAction(new LevelFlowAddBuffAction().Init(entityId, new List<long>
		{
			(long)buffId
		}));
	}

	// Token: 0x06019178 RID: 102776 RVA: 0x0067862C File Offset: 0x0067682C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void LevelFlowRemoveBuff(int entityId, int buffId)
	{
		LevelFlowModel.Instance.PushDynamicAction(new LevelFlowRemoveBuffAction().Init(entityId, new List<long>
		{
			(long)buffId
		}));
	}

	// Token: 0x06019179 RID: 102777 RVA: 0x00678650 File Offset: 0x00676850
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void LevelFlowCameraShake(string cameraShakeBp)
	{
		LevelFlowModel.Instance.PushDynamicAction(new LevelFlowCameraShake().Init(new TriggerCameraShake
		{
			CameraShakeConfig = new ICameraShakeConfig
			{
				Type = ECameraShakeType.Constant
			},
			CameraShakeBp = cameraShakeBp
		}));
	}

	// Token: 0x0601917A RID: 102778 RVA: 0x00678684 File Offset: 0x00676884
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void LevelFlowPlayLevelSequence(string path, string mark)
	{
		LevelFlowModel.Instance.PushDynamicAction(new LevelFlowPlayLevelSequence().Init(new PlayLevelSequence
		{
			LevelSequencePath = path,
			Mark = mark,
			IsEnableCenterOffset = new bool?(true),
			PlayMode = new TPlayMode?(TPlayMode.direct),
			KeepUI = new bool?(true)
		}));
	}

	// Token: 0x0601917B RID: 102779 RVA: 0x006786DC File Offset: 0x006768DC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FKuroCodeFunctionResult CallSpecialSkillCodeFunction(int entityId, string functionName, FKuroCodeFunctionPayload payload)
	{
		CharacterSpecialSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSpecialSkillComponent>(entityId);
		if (component == null || !component.Valid)
		{
			return CodeFunctionBase.CreateCodeFunctionFailureResult("实体不存在CharacterSpecialSkillComponent");
		}
		return component.ExecuteCodeFunction(functionName, payload);
	}

	// Token: 0x0601917C RID: 102780 RVA: 0x0067871C File Offset: 0x0067691C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static int XigelikaAddBean(int entityId, string bean)
	{
		CharacterSpecialSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSpecialSkillComponent>(entityId);
		if (component == null || !component.Valid || component.SpecialSkill == null)
		{
			return 0;
		}
		SpecialSkillXigelika specialSkillXigelika = component.SpecialSkill as SpecialSkillXigelika;
		if (specialSkillXigelika != null)
		{
			return specialSkillXigelika.AddBean(bean);
		}
		return 0;
	}

	// Token: 0x0601917D RID: 102781 RVA: 0x00678768 File Offset: 0x00676968
	[UFunction(EFunctionFlags.FUNC_None)]
	public static int XigelikaGetBeanResultant(int entityId)
	{
		CharacterSpecialSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSpecialSkillComponent>(entityId);
		if (component == null || !component.Valid || component.SpecialSkill == null)
		{
			return 0;
		}
		SpecialSkillXigelika specialSkillXigelika = component.SpecialSkill as SpecialSkillXigelika;
		if (specialSkillXigelika == null)
		{
			return 0;
		}
		return specialSkillXigelika.GetBeanResultant();
	}

	// Token: 0x0601917E RID: 102782 RVA: 0x006787B4 File Offset: 0x006769B4
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void XigelikaConsumeBean(int entityId)
	{
		CharacterSpecialSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSpecialSkillComponent>(entityId);
		if (component == null || !component.Valid || component.SpecialSkill == null)
		{
			return;
		}
		SpecialSkillXigelika specialSkillXigelika = component.SpecialSkill as SpecialSkillXigelika;
		if (specialSkillXigelika != null)
		{
			specialSkillXigelika.ConsumeBean();
		}
	}

	// Token: 0x0601917F RID: 102783 RVA: 0x006787FC File Offset: 0x006769FC
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void XigelikaResetBean(int entityId)
	{
		CharacterSpecialSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSpecialSkillComponent>(entityId);
		if (component == null || !component.Valid || component.SpecialSkill == null)
		{
			return;
		}
		SpecialSkillXigelika specialSkillXigelika = component.SpecialSkill as SpecialSkillXigelika;
		if (specialSkillXigelika != null)
		{
			specialSkillXigelika.ResetBean();
		}
	}

	// Token: 0x06019180 RID: 102784 RVA: 0x00678844 File Offset: 0x00676A44
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void OpenQuickHack(int deviceId, int ownerEntityId, bool closeWhenInteractFinish, FGameplayTag interactFinishGameplayEventTag)
	{
		QuickHackController.Instance.OpenQuickHack(deviceId, ownerEntityId, closeWhenInteractFinish, new FGameplayTag?(interactFinishGameplayEventTag), null);
	}

	// Token: 0x06019181 RID: 102785 RVA: 0x0067885A File Offset: 0x00676A5A
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void CloseQuickHack()
	{
		QuickHackController.Instance.CloseQuickHack();
	}

	// Token: 0x06019182 RID: 102786 RVA: 0x00678866 File Offset: 0x00676A66
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool FunctionOpen(int functionType)
	{
		return FunctionModel.Instance.IsOpen(functionType);
	}

	// Token: 0x06019183 RID: 102787 RVA: 0x00678873 File Offset: 0x00676A73
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06019184 RID: 102788 RVA: 0x00678875 File Offset: 0x00676A75
	public static void ResetStaticDefaultValue()
	{
		TsGameplayBlueprintFunctionLibrary.FlyingFeatherHandle = null;
	}

	// Token: 0x06019185 RID: 102789 RVA: 0x0067887D File Offset: 0x00676A7D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsGameplayBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsGameplayBlueprintFunctionLibrary.TsGameplayBlueprintFunctionLibrary_C");
		}
		return TsGameplayBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06019186 RID: 102790 RVA: 0x006788A4 File Offset: 0x00676AA4
	public TsGameplayBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsGameplayBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06019187 RID: 102791 RVA: 0x006788CC File Offset: 0x00676ACC
	[NullableContext(1)]
	public TsGameplayBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsGameplayBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06019188 RID: 102792 RVA: 0x006788FF File Offset: 0x00676AFF
	protected TsGameplayBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06019189 RID: 102793 RVA: 0x00678908 File Offset: 0x00676B08
	protected unsafe static void __CPPCALL_ContainsTag_Implementation(TsGameplayBlueprintFunctionLibrary.__ContainsTag_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.ContainsTag(__Params->entityId, __Params->tag);
	}

	// Token: 0x0601918A RID: 102794 RVA: 0x00678921 File Offset: 0x00676B21
	protected unsafe static void __CPPCALL_AddTag_Implementation(TsGameplayBlueprintFunctionLibrary.__AddTag_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.AddTag(__Params->entityId, __Params->tag);
	}

	// Token: 0x0601918B RID: 102795 RVA: 0x00678934 File Offset: 0x00676B34
	protected unsafe static void __CPPCALL_AddTagWithDuration_Implementation(TsGameplayBlueprintFunctionLibrary.__AddTagWithDuration_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.AddTagWithDuration(__Params->entityId, __Params->duration, __Params->tag);
	}

	// Token: 0x0601918C RID: 102796 RVA: 0x00678950 File Offset: 0x00676B50
	protected unsafe static void __CPPCALL_AddTagByName_Implementation(TsGameplayBlueprintFunctionLibrary.__AddTagByName_FunctionParams* __Params)
	{
		string tagName = FString.ToString((void*)(&__Params->tagName));
		TsGameplayBlueprintFunctionLibrary.AddTagByName(__Params->entityId, tagName);
	}

	// Token: 0x0601918D RID: 102797 RVA: 0x00678976 File Offset: 0x00676B76
	protected unsafe static void __CPPCALL_RemoveTag_Implementation(TsGameplayBlueprintFunctionLibrary.__RemoveTag_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.RemoveTag(__Params->entityId, __Params->tag);
	}

	// Token: 0x0601918E RID: 102798 RVA: 0x0067898C File Offset: 0x00676B8C
	protected unsafe static void __CPPCALL_RemoveTagByName_Implementation(TsGameplayBlueprintFunctionLibrary.__RemoveTagByName_FunctionParams* __Params)
	{
		string tagName = FString.ToString((void*)(&__Params->tagName));
		TsGameplayBlueprintFunctionLibrary.RemoveTagByName(__Params->entityId, tagName);
	}

	// Token: 0x0601918F RID: 102799 RVA: 0x006789B2 File Offset: 0x00676BB2
	protected unsafe static void __CPPCALL_AddCue_Implementation(TsGameplayBlueprintFunctionLibrary.__AddCue_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.AddCue(__Params->instigatorEntityId, __Params->targetEntityId, __Params->cueId);
	}

	// Token: 0x06019190 RID: 102800 RVA: 0x006789CB File Offset: 0x00676BCB
	protected unsafe static void __CPPCALL_RemoveCue_Implementation(TsGameplayBlueprintFunctionLibrary.__RemoveCue_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.RemoveCue(__Params->entityId, __Params->cueId);
	}

	// Token: 0x06019191 RID: 102801 RVA: 0x006789DE File Offset: 0x00676BDE
	protected unsafe static void __CPPCALL_SetGameplayCueEffectForceRecycle_Implementation(TsGameplayBlueprintFunctionLibrary.__SetGameplayCueEffectForceRecycle_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetGameplayCueEffectForceRecycle(__Params->entityId, __Params->cueId);
	}

	// Token: 0x06019192 RID: 102802 RVA: 0x006789F1 File Offset: 0x00676BF1
	protected unsafe static void __CPPCALL_IsLogicAutonomousProxy_Implementation(TsGameplayBlueprintFunctionLibrary.__IsLogicAutonomousProxy_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.IsLogicAutonomousProxy(__Params->entityId);
	}

	// Token: 0x06019193 RID: 102803 RVA: 0x00678A04 File Offset: 0x00676C04
	protected unsafe static void __CPPCALL_RemoveActiveGameplayEffect_Implementation(TsGameplayBlueprintFunctionLibrary.__RemoveActiveGameplayEffect_FunctionParams* __Params)
	{
		FActiveGameplayEffectHandle handle = new FActiveGameplayEffectHandle(&__Params->handle, true, true);
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.RemoveActiveGameplayEffect(__Params->entityId, handle, __Params->stacksToRemove);
	}

	// Token: 0x06019194 RID: 102804 RVA: 0x00678A38 File Offset: 0x00676C38
	protected unsafe static void __CPPCALL_RemoveBuffByTag_Implementation(TsGameplayBlueprintFunctionLibrary.__RemoveBuffByTag_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.RemoveBuffByTag(__Params->entityId, __Params->tag);
	}

	// Token: 0x06019195 RID: 102805 RVA: 0x00678A4B File Offset: 0x00676C4B
	protected unsafe static void __CPPCALL_AddPassiveSkill_Implementation(TsGameplayBlueprintFunctionLibrary.__AddPassiveSkill_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.AddPassiveSkill(__Params->entityId, __Params->passiveSkillId);
	}

	// Token: 0x06019196 RID: 102806 RVA: 0x00678A5E File Offset: 0x00676C5E
	protected unsafe static void __CPPCALL_RemovePassiveSkill_Implementation(TsGameplayBlueprintFunctionLibrary.__RemovePassiveSkill_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.RemovePassiveSkill(__Params->entityId, __Params->passiveSkillId);
	}

	// Token: 0x06019197 RID: 102807 RVA: 0x00678A74 File Offset: 0x00676C74
	protected unsafe static void __CPPCALL_SetPassiveGaSkillId_Implementation(TsGameplayBlueprintFunctionLibrary.__SetPassiveGaSkillId_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->callObject);
		TsGameplayBlueprintFunctionLibrary.SetPassiveGaSkillId(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06019198 RID: 102808 RVA: 0x00678A99 File Offset: 0x00676C99
	protected unsafe static void __CPPCALL_AddBuffForDebug_Implementation(TsGameplayBlueprintFunctionLibrary.__AddBuffForDebug_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.AddBuffForDebug(__Params->instigatorEntityId, __Params->targetEntityId, __Params->buffId);
	}

	// Token: 0x06019199 RID: 102809 RVA: 0x00678AB4 File Offset: 0x00676CB4
	protected unsafe static void __CPPCALL_SendCombatEventForDebug_Implementation(TsGameplayBlueprintFunctionLibrary.__SendCombatEventForDebug_FunctionParams* __Params)
	{
		string tagName = FString.ToString((void*)(&__Params->tagName));
		TsGameplayBlueprintFunctionLibrary.SendCombatEventForDebug(__Params->entityId, tagName, __Params->needSave, __Params->isMainState);
	}

	// Token: 0x0601919A RID: 102810 RVA: 0x00678AE8 File Offset: 0x00676CE8
	protected unsafe static void __CPPCALL_SendLevelEventForDebug_Implementation(TsGameplayBlueprintFunctionLibrary.__SendLevelEventForDebug_FunctionParams* __Params)
	{
		string tagName = FString.ToString((void*)(&__Params->tagName));
		TsGameplayBlueprintFunctionLibrary.SendLevelEventForDebug(__Params->entityId, tagName);
	}

	// Token: 0x0601919B RID: 102811 RVA: 0x00678B10 File Offset: 0x00676D10
	protected unsafe static void __CPPCALL_AddBuffFromGA_Implementation(TsGameplayBlueprintFunctionLibrary.__AddBuffFromGA_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->target);
		string skillId = FString.ToString((void*)(&__Params->skillId));
		TsGameplayBlueprintFunctionLibrary.AddBuffFromGA(__Params->entityId, orCreateUObjectByNativePointer, __Params->buffId, skillId, __Params->addCount);
	}

	// Token: 0x0601919C RID: 102812 RVA: 0x00678B4F File Offset: 0x00676D4F
	protected unsafe static void __CPPCALL_RemoveBuffById_Implementation(TsGameplayBlueprintFunctionLibrary.__RemoveBuffById_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.RemoveBuffById(__Params->entityId, __Params->buffId, __Params->stackCount);
	}

	// Token: 0x0601919D RID: 102813 RVA: 0x00678B68 File Offset: 0x00676D68
	protected unsafe static void __CPPCALL_GetBuffCountById_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffCountById_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBuffCountById(__Params->entityId, __Params->buffId, __Params->enforceOnGoingCheck);
	}

	// Token: 0x0601919E RID: 102814 RVA: 0x00678B87 File Offset: 0x00676D87
	protected unsafe static void __CPPCALL_AddGameplayCueLocal_Implementation(TsGameplayBlueprintFunctionLibrary.__AddGameplayCueLocal_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.AddGameplayCueLocal(__Params->entityId, __Params->duration, __Params->cueId);
	}

	// Token: 0x0601919F RID: 102815 RVA: 0x00678BA0 File Offset: 0x00676DA0
	protected unsafe static void __CPPCALL_GetGeDebugString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetGeDebugString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetGeDebugString(__Params->entityId));
	}

	// Token: 0x060191A0 RID: 102816 RVA: 0x00678BB9 File Offset: 0x00676DB9
	protected unsafe static void __CPPCALL_GetTagDebugStrings_Implementation(TsGameplayBlueprintFunctionLibrary.__GetTagDebugStrings_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetTagDebugStrings(__Params->entityId));
	}

	// Token: 0x060191A1 RID: 102817 RVA: 0x00678BD4 File Offset: 0x00676DD4
	protected unsafe static void __CPPCALL_GetBuffDebugStrings_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffDebugStrings_FunctionParams* __Params)
	{
		string buffStr = FString.ToString((void*)(&__Params->buffStr));
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetBuffDebugStrings(__Params->entityId, buffStr));
	}

	// Token: 0x060191A2 RID: 102818 RVA: 0x00678C08 File Offset: 0x00676E08
	protected unsafe static void __CPPCALL_GetShieldDebugString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetShieldDebugString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetShieldDebugString(__Params->entityId, filterStr));
	}

	// Token: 0x060191A3 RID: 102819 RVA: 0x00678C3A File Offset: 0x00676E3A
	protected unsafe static void __CPPCALL_GetPassiveSkillDebugString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPassiveSkillDebugString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetPassiveSkillDebugString(__Params->entityId));
	}

	// Token: 0x060191A4 RID: 102820 RVA: 0x00678C53 File Offset: 0x00676E53
	protected unsafe static void __CPPCALL_GetShieldValue_Implementation(TsGameplayBlueprintFunctionLibrary.__GetShieldValue_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetShieldValue(__Params->entityId, __Params->shieldCid);
	}

	// Token: 0x060191A5 RID: 102821 RVA: 0x00678C6C File Offset: 0x00676E6C
	protected unsafe static void __CPPCALL_GetAttributeDebugString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetAttributeDebugString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetAttributeDebugString(__Params->entityId));
	}

	// Token: 0x060191A6 RID: 102822 RVA: 0x00678C85 File Offset: 0x00676E85
	protected unsafe static void __CPPCALL_GetAllAttributeDebugStrings_Implementation(TsGameplayBlueprintFunctionLibrary.__GetAllAttributeDebugStrings_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetAllAttributeDebugStrings(__Params->entityId));
	}

	// Token: 0x060191A7 RID: 102823 RVA: 0x00678C9E File Offset: 0x00676E9E
	protected unsafe static void __CPPCALL_GetServerBuffString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetServerBuffString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetServerBuffString(__Params->entityId));
	}

	// Token: 0x060191A8 RID: 102824 RVA: 0x00678CB7 File Offset: 0x00676EB7
	protected unsafe static void __CPPCALL_GetServerTagString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetServerTagString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetServerTagString(__Params->entityId));
	}

	// Token: 0x060191A9 RID: 102825 RVA: 0x00678CD0 File Offset: 0x00676ED0
	protected unsafe static void __CPPCALL_GetServerAttributeString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetServerAttributeString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetServerAttributeString(__Params->entityId));
	}

	// Token: 0x060191AA RID: 102826 RVA: 0x00678CE9 File Offset: 0x00676EE9
	protected unsafe static void __CPPCALL_GetServerPartString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetServerPartString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetServerPartString(__Params->entityId));
	}

	// Token: 0x060191AB RID: 102827 RVA: 0x00678D02 File Offset: 0x00676F02
	protected unsafe static void __CPPCALL_GetServerHateString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetServerHateString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetServerHateString(__Params->entityId));
	}

	// Token: 0x060191AC RID: 102828 RVA: 0x00678D1B File Offset: 0x00676F1B
	protected unsafe static void __CPPCALL_GetServerShieldString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetServerShieldString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetServerShieldString(__Params->entityId));
	}

	// Token: 0x060191AD RID: 102829 RVA: 0x00678D34 File Offset: 0x00676F34
	protected unsafe static void __CPPCALL_ServerDebugInfoRequest_Implementation(TsGameplayBlueprintFunctionLibrary.__ServerDebugInfoRequest_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ServerDebugInfoRequest(__Params->entityId);
	}

	// Token: 0x060191AE RID: 102830 RVA: 0x00678D41 File Offset: 0x00676F41
	protected unsafe static void __CPPCALL_GetServerDebugInfoDirty_Implementation(TsGameplayBlueprintFunctionLibrary.__GetServerDebugInfoDirty_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetServerDebugInfoDirty(__Params->entityId);
	}

	// Token: 0x060191AF RID: 102831 RVA: 0x00678D54 File Offset: 0x00676F54
	protected unsafe static void __CPPCALL_SetServerDebugInfoDirty_Implementation(TsGameplayBlueprintFunctionLibrary.__SetServerDebugInfoDirty_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetServerDebugInfoDirty(__Params->entityId, __Params->val);
	}

	// Token: 0x060191B0 RID: 102832 RVA: 0x00678D67 File Offset: 0x00676F67
	protected unsafe static void __CPPCALL_DebugResetBaseVal_Implementation(TsGameplayBlueprintFunctionLibrary.__DebugResetBaseVal_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.DebugResetBaseVal(__Params->entityId, __Params->id, __Params->val);
	}

	// Token: 0x060191B1 RID: 102833 RVA: 0x00678D80 File Offset: 0x00676F80
	protected unsafe static void __CPPCALL_DebugResetFormationValue_Implementation(TsGameplayBlueprintFunctionLibrary.__DebugResetFormationValue_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.DebugResetFormationValue(__Params->id, __Params->val);
	}

	// Token: 0x060191B2 RID: 102834 RVA: 0x00678D93 File Offset: 0x00676F93
	protected unsafe static void __CPPCALL_Record_Implementation(TsGameplayBlueprintFunctionLibrary.__Record_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.Record(__Params->entityId, __Params->record));
	}

	// Token: 0x060191B3 RID: 102835 RVA: 0x00678DB2 File Offset: 0x00676FB2
	protected unsafe static void __CPPCALL_RefreshEntityListView_Implementation(TsGameplayBlueprintFunctionLibrary.__RefreshEntityListView_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.RefreshEntityListView(BuiltinUtils.GetOrCreateUObjectByNativePointer<UListView>(__Params->listView));
	}

	// Token: 0x060191B4 RID: 102836 RVA: 0x00678DC4 File Offset: 0x00676FC4
	protected unsafe static void __CPPCALL_RefreshEntityComboBox_Implementation(TsGameplayBlueprintFunctionLibrary.__RefreshEntityComboBox_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.RefreshEntityComboBox(BuiltinUtils.GetOrCreateUObjectByNativePointer<UComboBoxString>(__Params->comboBox));
	}

	// Token: 0x060191B5 RID: 102837 RVA: 0x00678DD6 File Offset: 0x00676FD6
	protected unsafe static void __CPPCALL_SetEntityComboBox_Implementation(TsGameplayBlueprintFunctionLibrary.__SetEntityComboBox_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetEntityComboBox(BuiltinUtils.GetOrCreateUObjectByNativePointer<UComboBoxString>(__Params->comboBox), __Params->entityId);
	}

	// Token: 0x060191B6 RID: 102838 RVA: 0x00678DEE File Offset: 0x00676FEE
	protected unsafe static void __CPPCALL_SetDebugEntityId_Implementation(TsGameplayBlueprintFunctionLibrary.__SetDebugEntityId_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetDebugEntityId(__Params->entityId);
	}

	// Token: 0x060191B7 RID: 102839 RVA: 0x00678DFB File Offset: 0x00676FFB
	protected unsafe static void __CPPCALL_GetDebugEntityId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetDebugEntityId_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetDebugEntityId();
	}

	// Token: 0x060191B8 RID: 102840 RVA: 0x00678E08 File Offset: 0x00677008
	protected unsafe static void __CPPCALL_RefreshBuffListView_Implementation(TsGameplayBlueprintFunctionLibrary.__RefreshBuffListView_FunctionParams* __Params)
	{
		UListView orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UListView>(__Params->listView);
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		TsGameplayBlueprintFunctionLibrary.RefreshBuffListView(__Params->entityId, orCreateUObjectByNativePointer, filterStr);
	}

	// Token: 0x060191B9 RID: 102841 RVA: 0x00678E3B File Offset: 0x0067703B
	protected unsafe static void __CPPCALL_GetBuffIdByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffIdByHandle_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBuffIdByHandle(__Params->entityId, __Params->handle);
	}

	// Token: 0x060191BA RID: 102842 RVA: 0x00678E54 File Offset: 0x00677054
	protected unsafe static void __CPPCALL_GetBuffServerIdByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffServerIdByHandle_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBuffServerIdByHandle(__Params->entityId, __Params->handle);
	}

	// Token: 0x060191BB RID: 102843 RVA: 0x00678E6D File Offset: 0x0067706D
	protected unsafe static void __CPPCALL_GetBuffDescByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffDescByHandle_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetBuffDescByHandle(__Params->entityId, __Params->handle));
	}

	// Token: 0x060191BC RID: 102844 RVA: 0x00678E8C File Offset: 0x0067708C
	protected unsafe static void __CPPCALL_GetBuffActivateByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffActivateByHandle_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBuffActivateByHandle(__Params->entityId, __Params->handle);
	}

	// Token: 0x060191BD RID: 102845 RVA: 0x00678EA5 File Offset: 0x006770A5
	protected unsafe static void __CPPCALL_GetBuffInstigatorStringByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffInstigatorStringByHandle_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetBuffInstigatorStringByHandle(__Params->entityId, __Params->handle));
	}

	// Token: 0x060191BE RID: 102846 RVA: 0x00678EC4 File Offset: 0x006770C4
	protected unsafe static void __CPPCALL_GetBuffPeriodStringByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffPeriodStringByHandle_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetBuffPeriodStringByHandle(__Params->entityId, __Params->handle));
	}

	// Token: 0x060191BF RID: 102847 RVA: 0x00678EE3 File Offset: 0x006770E3
	protected unsafe static void __CPPCALL_GetBuffDurationStringByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffDurationStringByHandle_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetBuffDurationStringByHandle(__Params->entityId, __Params->handle));
	}

	// Token: 0x060191C0 RID: 102848 RVA: 0x00678F02 File Offset: 0x00677102
	protected unsafe static void __CPPCALL_GetBuffDurationProgress_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffDurationProgress_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBuffDurationProgress(__Params->entityId, __Params->handle);
	}

	// Token: 0x060191C1 RID: 102849 RVA: 0x00678F1B File Offset: 0x0067711B
	protected unsafe static void __CPPCALL_GetBuffLivingStatusStringByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffLivingStatusStringByHandle_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetBuffLivingStatusStringByHandle(__Params->entityId, __Params->handle));
	}

	// Token: 0x060191C2 RID: 102850 RVA: 0x00678F3A File Offset: 0x0067713A
	protected unsafe static void __CPPCALL_GetBuffLevelStringByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffLevelStringByHandle_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetBuffLevelStringByHandle(__Params->entityId, __Params->handle));
	}

	// Token: 0x060191C3 RID: 102851 RVA: 0x00678F59 File Offset: 0x00677159
	protected unsafe static void __CPPCALL_GetBuffStackStringByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffStackStringByHandle_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetBuffStackStringByHandle(__Params->entityId, __Params->handle));
	}

	// Token: 0x060191C4 RID: 102852 RVA: 0x00678F78 File Offset: 0x00677178
	protected unsafe static void __CPPCALL_GetBuffDebugStringByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffDebugStringByHandle_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetBuffDebugStringByHandle(__Params->entityId, __Params->handle));
	}

	// Token: 0x060191C5 RID: 102853 RVA: 0x00678F97 File Offset: 0x00677197
	protected unsafe static void __CPPCALL_SetDistance_Implementation(TsGameplayBlueprintFunctionLibrary.__SetDistance_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetDistance(__Params->entityId, __Params->max);
	}

	// Token: 0x060191C6 RID: 102854 RVA: 0x00678FAA File Offset: 0x006771AA
	protected unsafe static void __CPPCALL_GetAllMovementHistory_Implementation(TsGameplayBlueprintFunctionLibrary.__GetAllMovementHistory_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetAllMovementHistory(__Params->entityId));
	}

	// Token: 0x060191C7 RID: 102855 RVA: 0x00678FC3 File Offset: 0x006771C3
	protected unsafe static void __CPPCALL_ResetBaseValueLocal_Implementation(TsGameplayBlueprintFunctionLibrary.__ResetBaseValueLocal_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ResetBaseValueLocal(__Params->entityId, __Params->id, __Params->val);
	}

	// Token: 0x060191C8 RID: 102856 RVA: 0x00678FDC File Offset: 0x006771DC
	protected unsafe static void __CPPCALL_GetAttributeCurrentValue_Implementation(TsGameplayBlueprintFunctionLibrary.__GetAttributeCurrentValue_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetAttributeCurrentValue(__Params->entityId, __Params->attributeId);
	}

	// Token: 0x060191C9 RID: 102857 RVA: 0x00678FF5 File Offset: 0x006771F5
	protected unsafe static void __CPPCALL_GetAttributeBaseValue_Implementation(TsGameplayBlueprintFunctionLibrary.__GetAttributeBaseValue_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetAttributeBaseValue(__Params->entityId, __Params->attributeId);
	}

	// Token: 0x060191CA RID: 102858 RVA: 0x0067900E File Offset: 0x0067720E
	protected unsafe static void __CPPCALL_SetRageModeId_Implementation(TsGameplayBlueprintFunctionLibrary.__SetRageModeId_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetRageModeId(__Params->entityId, __Params->id);
	}

	// Token: 0x060191CB RID: 102859 RVA: 0x00679021 File Offset: 0x00677221
	protected unsafe static void __CPPCALL_SetHardnessModeId_Implementation(TsGameplayBlueprintFunctionLibrary.__SetHardnessModeId_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetHardnessModeId(__Params->entityId, __Params->id);
	}

	// Token: 0x060191CC RID: 102860 RVA: 0x00679034 File Offset: 0x00677234
	protected unsafe static void __CPPCALL_OnHit_Implementation(TsGameplayBlueprintFunctionLibrary.__OnHit_FunctionParams* __Params)
	{
		SHitInformation hitData = new SHitInformation(&__Params->hitData, true, true);
		TsGameplayBlueprintFunctionLibrary.OnHit(__Params->entityId, hitData);
	}

	// Token: 0x060191CD RID: 102861 RVA: 0x0067905C File Offset: 0x0067725C
	protected unsafe static void __CPPCALL_SetBeHitIgnoreRotate_Implementation(TsGameplayBlueprintFunctionLibrary.__SetBeHitIgnoreRotate_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetBeHitIgnoreRotate(__Params->entityId, __Params->ignoreRotate);
	}

	// Token: 0x060191CE RID: 102862 RVA: 0x0067906F File Offset: 0x0067726F
	protected unsafe static void __CPPCALL_CheckHasPart_Implementation(TsGameplayBlueprintFunctionLibrary.__CheckHasPart_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.CheckHasPart(__Params->entityId);
	}

	// Token: 0x060191CF RID: 102863 RVA: 0x00679082 File Offset: 0x00677282
	protected unsafe static void __CPPCALL_GetPartRemainedLife_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPartRemainedLife_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetPartRemainedLife(__Params->entityId, __Params->tag);
	}

	// Token: 0x060191D0 RID: 102864 RVA: 0x0067909B File Offset: 0x0067729B
	protected unsafe static void __CPPCALL_ResetPartLife_Implementation(TsGameplayBlueprintFunctionLibrary.__ResetPartLife_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ResetPartLife(__Params->entityId, __Params->tag);
	}

	// Token: 0x060191D1 RID: 102865 RVA: 0x006790AE File Offset: 0x006772AE
	protected unsafe static void __CPPCALL_ActiveStiff_Implementation(TsGameplayBlueprintFunctionLibrary.__ActiveStiff_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ActiveStiff(__Params->entityId);
	}

	// Token: 0x060191D2 RID: 102866 RVA: 0x006790BB File Offset: 0x006772BB
	protected unsafe static void __CPPCALL_DeActiveStiff_Implementation(TsGameplayBlueprintFunctionLibrary.__DeActiveStiff_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.DeActiveStiff(__Params->entityId);
	}

	// Token: 0x060191D3 RID: 102867 RVA: 0x006790C8 File Offset: 0x006772C8
	protected unsafe static void __CPPCALL_GetAcceptedNewBeHitAndReset_Implementation(TsGameplayBlueprintFunctionLibrary.__GetAcceptedNewBeHitAndReset_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetAcceptedNewBeHitAndReset(__Params->entityId);
	}

	// Token: 0x060191D4 RID: 102868 RVA: 0x006790DB File Offset: 0x006772DB
	protected unsafe static void __CPPCALL_GetEnterFkAndReset_Implementation(TsGameplayBlueprintFunctionLibrary.__GetEnterFkAndReset_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetEnterFkAndReset(__Params->entityId);
	}

	// Token: 0x060191D5 RID: 102869 RVA: 0x006790EE File Offset: 0x006772EE
	protected unsafe static void __CPPCALL_IsStiff_Implementation(TsGameplayBlueprintFunctionLibrary.__IsStiff_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.IsStiff(__Params->entityId);
	}

	// Token: 0x060191D6 RID: 102870 RVA: 0x00679101 File Offset: 0x00677301
	protected unsafe static void __CPPCALL_GetRageModeId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetRageModeId_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetRageModeId(__Params->entityId);
	}

	// Token: 0x060191D7 RID: 102871 RVA: 0x00679114 File Offset: 0x00677314
	protected unsafe static void __CPPCALL_GetHardnessModeId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetHardnessModeId_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetHardnessModeId(__Params->entityId);
	}

	// Token: 0x060191D8 RID: 102872 RVA: 0x00679127 File Offset: 0x00677327
	protected unsafe static void __CPPCALL_GetBeHitBone_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBeHitBone_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBeHitBone(__Params->entityId);
	}

	// Token: 0x060191D9 RID: 102873 RVA: 0x0067913A File Offset: 0x0067733A
	protected unsafe static void __CPPCALL_GetToughDecreaseValue_Implementation(TsGameplayBlueprintFunctionLibrary.__GetToughDecreaseValue_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetToughDecreaseValue(__Params->entityId);
	}

	// Token: 0x060191DA RID: 102874 RVA: 0x0067914D File Offset: 0x0067734D
	protected unsafe static void __CPPCALL_GetCounterAttackInfoInternal_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCounterAttackInfoInternal_FunctionParams* __Params)
	{
		UScriptStructStackOnlyPtr nativeUStructPtr = SCounterAttack.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SCounterAttack counterAttackInfoInternal = TsGameplayBlueprintFunctionLibrary.GetCounterAttackInfoInternal(__Params->entityId);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (counterAttackInfoInternal != null) ? counterAttackInfoInternal.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x060191DB RID: 102875 RVA: 0x0067917A File Offset: 0x0067737A
	protected unsafe static void __CPPCALL_GetVisionCounterAttackInfoInternal_Implementation(TsGameplayBlueprintFunctionLibrary.__GetVisionCounterAttackInfoInternal_FunctionParams* __Params)
	{
		UScriptStructStackOnlyPtr nativeUStructPtr = SVisionCounterAttack.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SVisionCounterAttack visionCounterAttackInfoInternal = TsGameplayBlueprintFunctionLibrary.GetVisionCounterAttackInfoInternal(__Params->entityId);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (visionCounterAttackInfoInternal != null) ? visionCounterAttackInfoInternal.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x060191DC RID: 102876 RVA: 0x006791A7 File Offset: 0x006773A7
	protected unsafe static void __CPPCALL_GetBeHitTime_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBeHitTime_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBeHitTime(__Params->entityId);
	}

	// Token: 0x060191DD RID: 102877 RVA: 0x006791BA File Offset: 0x006773BA
	protected unsafe static void __CPPCALL_GetBeHitAnim_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBeHitAnim_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsGameplayBlueprintFunctionLibrary.GetBeHitAnim(__Params->entityId);
	}

	// Token: 0x060191DE RID: 102878 RVA: 0x006791CF File Offset: 0x006773CF
	protected unsafe static void __CPPCALL_GetEnterFk_Implementation(TsGameplayBlueprintFunctionLibrary.__GetEnterFk_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetEnterFk(__Params->entityId);
	}

	// Token: 0x060191DF RID: 102879 RVA: 0x006791E2 File Offset: 0x006773E2
	protected unsafe static void __CPPCALL_GetBeHitDirect_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBeHitDirect_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBeHitDirect(__Params->entityId);
	}

	// Token: 0x060191E0 RID: 102880 RVA: 0x006791F5 File Offset: 0x006773F5
	protected unsafe static void __CPPCALL_GetBeHitLocation_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBeHitLocation_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBeHitLocation(__Params->entityId);
	}

	// Token: 0x060191E1 RID: 102881 RVA: 0x00679208 File Offset: 0x00677408
	protected unsafe static void __CPPCALL_AddCheckBuffList_Implementation(TsGameplayBlueprintFunctionLibrary.__AddCheckBuffList_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.AddCheckBuffList(__Params->entityId, __Params->addValue);
	}

	// Token: 0x060191E2 RID: 102882 RVA: 0x0067921B File Offset: 0x0067741B
	protected unsafe static void __CPPCALL_ClearCheckBuffList_Implementation(TsGameplayBlueprintFunctionLibrary.__ClearCheckBuffList_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ClearCheckBuffList(__Params->entityId);
	}

	// Token: 0x060191E3 RID: 102883 RVA: 0x00679228 File Offset: 0x00677428
	protected unsafe static void __CPPCALL_CounterAttackEnd_Implementation(TsGameplayBlueprintFunctionLibrary.__CounterAttackEnd_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.CounterAttackEnd(__Params->entityId);
	}

	// Token: 0x060191E4 RID: 102884 RVA: 0x00679235 File Offset: 0x00677435
	protected unsafe static void __CPPCALL_VisionCounterAttackEnd_Implementation(TsGameplayBlueprintFunctionLibrary.__VisionCounterAttackEnd_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.VisionCounterAttackEnd(__Params->entityId);
	}

	// Token: 0x060191E5 RID: 102885 RVA: 0x00679242 File Offset: 0x00677442
	protected unsafe static void __CPPCALL_SetCounterAttackEndTime_Implementation(TsGameplayBlueprintFunctionLibrary.__SetCounterAttackEndTime_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetCounterAttackEndTime(__Params->entityId, __Params->baseTime);
	}

	// Token: 0x060191E6 RID: 102886 RVA: 0x00679255 File Offset: 0x00677455
	protected unsafe static void __CPPCALL_IsTriggerCounterAttack_Implementation(TsGameplayBlueprintFunctionLibrary.__IsTriggerCounterAttack_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.IsTriggerCounterAttack(__Params->entityId);
	}

	// Token: 0x060191E7 RID: 102887 RVA: 0x00679268 File Offset: 0x00677468
	protected unsafe static void __CPPCALL_ResetTarget_Implementation(TsGameplayBlueprintFunctionLibrary.__ResetTarget_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ResetTarget(__Params->entityId);
	}

	// Token: 0x060191E8 RID: 102888 RVA: 0x00679278 File Offset: 0x00677478
	protected unsafe static void __CPPCALL_SetShowTarget_Implementation(TsGameplayBlueprintFunctionLibrary.__SetShowTarget_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor);
		TsGameplayBlueprintFunctionLibrary.SetShowTarget(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x060191E9 RID: 102889 RVA: 0x0067929D File Offset: 0x0067749D
	protected unsafe static void __CPPCALL_ExitLockDirection_Implementation(TsGameplayBlueprintFunctionLibrary.__ExitLockDirection_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ExitLockDirection(__Params->entityId);
	}

	// Token: 0x060191EA RID: 102890 RVA: 0x006792AA File Offset: 0x006774AA
	protected unsafe static void __CPPCALL_EnterLockDirection_Implementation(TsGameplayBlueprintFunctionLibrary.__EnterLockDirection_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EnterLockDirection(__Params->entityId);
	}

	// Token: 0x060191EB RID: 102891 RVA: 0x006792B7 File Offset: 0x006774B7
	protected unsafe static void __CPPCALL_GetCurrentTarget_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCurrentTarget_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		TsBaseCharacter currentTarget = TsGameplayBlueprintFunctionLibrary.GetCurrentTarget(__Params->entityId);
		ptr = ((currentTarget != null) ? currentTarget.NativePtr : ((IntPtr)0));
	}

	// Token: 0x060191EC RID: 102892 RVA: 0x006792D9 File Offset: 0x006774D9
	protected unsafe static void __CPPCALL_SetLockOnDebugLine_Implementation(TsGameplayBlueprintFunctionLibrary.__SetLockOnDebugLine_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetLockOnDebugLine(__Params->entityId, __Params->isShow);
	}

	// Token: 0x060191ED RID: 102893 RVA: 0x006792EC File Offset: 0x006774EC
	protected unsafe static void __CPPCALL_ManipulateValid_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateValid_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.ManipulateValid(__Params->entityId);
	}

	// Token: 0x060191EE RID: 102894 RVA: 0x006792FF File Offset: 0x006774FF
	protected unsafe static void __CPPCALL_ManipulateGetDrawTarget_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateGetDrawTarget_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor aactor = TsGameplayBlueprintFunctionLibrary.ManipulateGetDrawTarget(__Params->entityId);
		ptr = ((aactor != null) ? aactor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x060191EF RID: 102895 RVA: 0x00679321 File Offset: 0x00677521
	protected unsafe static void __CPPCALL_ManipulateGetCastTarget_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateGetCastTarget_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor aactor = TsGameplayBlueprintFunctionLibrary.ManipulateGetCastTarget(__Params->entityId);
		ptr = ((aactor != null) ? aactor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x060191F0 RID: 102896 RVA: 0x00679343 File Offset: 0x00677543
	protected unsafe static void __CPPCALL_ManipulateGetDrawTargetChantTime_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateGetDrawTargetChantTime_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.ManipulateGetDrawTargetChantTime(__Params->entityId);
	}

	// Token: 0x060191F1 RID: 102897 RVA: 0x00679358 File Offset: 0x00677558
	protected unsafe static void __CPPCALL_ManipulateChant_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateChant_FunctionParams* __Params)
	{
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.ManipulateChant(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x060191F2 RID: 102898 RVA: 0x00679383 File Offset: 0x00677583
	protected unsafe static void __CPPCALL_ManipulateDraw_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateDraw_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.ManipulateDraw(__Params->entityId);
	}

	// Token: 0x060191F3 RID: 102899 RVA: 0x00679396 File Offset: 0x00677596
	protected unsafe static void __CPPCALL_ManipulateCast_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateCast_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.ManipulateCast(__Params->entityId, __Params->direction);
	}

	// Token: 0x060191F4 RID: 102900 RVA: 0x006793AF File Offset: 0x006775AF
	protected unsafe static void __CPPCALL_ManipulateReset_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateReset_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ManipulateReset(__Params->entityId);
	}

	// Token: 0x060191F5 RID: 102901 RVA: 0x006793BC File Offset: 0x006775BC
	protected unsafe static void __CPPCALL_ManipulateChangeToProjectileState_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateChangeToProjectileState_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.ManipulateChangeToProjectileState(__Params->entityId);
	}

	// Token: 0x060191F6 RID: 102902 RVA: 0x006793CF File Offset: 0x006775CF
	protected unsafe static void __CPPCALL_ManipulateChangeToNormalState_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateChangeToNormalState_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.ManipulateChangeToNormalState(__Params->entityId);
	}

	// Token: 0x060191F7 RID: 102903 RVA: 0x006793E2 File Offset: 0x006775E2
	protected unsafe static void __CPPCALL_GetHoldingActor_Implementation(TsGameplayBlueprintFunctionLibrary.__GetHoldingActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor holdingActor = TsGameplayBlueprintFunctionLibrary.GetHoldingActor(__Params->entityId);
		ptr = ((holdingActor != null) ? holdingActor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x060191F8 RID: 102904 RVA: 0x00679404 File Offset: 0x00677604
	protected unsafe static void __CPPCALL_HasHoldingActor_Implementation(TsGameplayBlueprintFunctionLibrary.__HasHoldingActor_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.HasHoldingActor(__Params->entityId);
	}

	// Token: 0x060191F9 RID: 102905 RVA: 0x00679417 File Offset: 0x00677617
	protected unsafe static void __CPPCALL_SetDebugDraw_Implementation(TsGameplayBlueprintFunctionLibrary.__SetDebugDraw_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetDebugDraw(__Params->entityId, __Params->isActive);
	}

	// Token: 0x060191FA RID: 102906 RVA: 0x0067942A File Offset: 0x0067762A
	protected unsafe static void __CPPCALL_ExtraAction_Implementation(TsGameplayBlueprintFunctionLibrary.__ExtraAction_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ExtraAction(__Params->entityId);
	}

	// Token: 0x060191FB RID: 102907 RVA: 0x00679437 File Offset: 0x00677637
	protected unsafe static void __CPPCALL_SetQtePosition_Implementation(TsGameplayBlueprintFunctionLibrary.__SetQtePosition_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetQtePosition(__Params->entityId, __Params->rotate, __Params->length, __Params->height, __Params->referenceTarget, __Params->adjustWithMonster, __Params->addHeight, __Params->qteType);
	}

	// Token: 0x060191FC RID: 102908 RVA: 0x0067946E File Offset: 0x0067766E
	protected unsafe static void __CPPCALL_GetGoBattleActor_Implementation(TsGameplayBlueprintFunctionLibrary.__GetGoBattleActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		TsBaseCharacter goBattleActor = TsGameplayBlueprintFunctionLibrary.GetGoBattleActor(__Params->entityId);
		ptr = ((goBattleActor != null) ? goBattleActor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x060191FD RID: 102909 RVA: 0x00679490 File Offset: 0x00677690
	protected unsafe static void __CPPCALL_GetDtSkillInfo_Implementation(TsGameplayBlueprintFunctionLibrary.__GetDtSkillInfo_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UDataTable dtSkillInfo = TsGameplayBlueprintFunctionLibrary.GetDtSkillInfo(__Params->entityId);
		ptr = ((dtSkillInfo != null) ? dtSkillInfo.NativePtr : ((IntPtr)0));
	}

	// Token: 0x060191FE RID: 102910 RVA: 0x006794B4 File Offset: 0x006776B4
	protected unsafe static void __CPPCALL_GetDtSkillInfoMapForDebug_Implementation(TsGameplayBlueprintFunctionLibrary.__GetDtSkillInfoMapForDebug_FunctionParams* __Params)
	{
		TMap<ECharacterLoadType, UDataTable> dtSkillInfoMapForDebug = TsGameplayBlueprintFunctionLibrary.GetDtSkillInfoMapForDebug(__Params->entityId);
		if (dtSkillInfoMapForDebug == null)
		{
			return;
		}
		dtSkillInfoMapForDebug.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x060191FF RID: 102911 RVA: 0x006794E6 File Offset: 0x006776E6
	protected unsafe static void __CPPCALL_GetLastActivateSkillTime_Implementation(TsGameplayBlueprintFunctionLibrary.__GetLastActivateSkillTime_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetLastActivateSkillTime(__Params->entityId);
	}

	// Token: 0x06019200 RID: 102912 RVA: 0x006794F9 File Offset: 0x006776F9
	protected unsafe static void __CPPCALL_SetLastActivateSkillTime_Implementation(TsGameplayBlueprintFunctionLibrary.__SetLastActivateSkillTime_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetLastActivateSkillTime(__Params->entityId, __Params->time);
	}

	// Token: 0x06019201 RID: 102913 RVA: 0x0067950C File Offset: 0x0067770C
	protected unsafe static void __CPPCALL_GetSkillElevationAngle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetSkillElevationAngle_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetSkillElevationAngle(__Params->entityId);
	}

	// Token: 0x06019202 RID: 102914 RVA: 0x0067951F File Offset: 0x0067771F
	protected unsafe static void __CPPCALL_SetSkillElevationAngle_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSkillElevationAngle_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetSkillElevationAngle(__Params->entityId, __Params->angle);
	}

	// Token: 0x06019203 RID: 102915 RVA: 0x00679532 File Offset: 0x00677732
	protected unsafe static void __CPPCALL_CurrentSkillId_Implementation(TsGameplayBlueprintFunctionLibrary.__CurrentSkillId_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.CurrentSkillId(__Params->entityId));
	}

	// Token: 0x06019204 RID: 102916 RVA: 0x0067954B File Offset: 0x0067774B
	protected unsafe static void __CPPCALL_CurrentPriority_Implementation(TsGameplayBlueprintFunctionLibrary.__CurrentPriority_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.CurrentPriority(__Params->entityId);
	}

	// Token: 0x06019205 RID: 102917 RVA: 0x0067955E File Offset: 0x0067775E
	protected unsafe static void __CPPCALL_SetCurrentPriority_Implementation(TsGameplayBlueprintFunctionLibrary.__SetCurrentPriority_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetCurrentPriority(__Params->entityId, __Params->priority);
	}

	// Token: 0x06019206 RID: 102918 RVA: 0x00679574 File Offset: 0x00677774
	protected unsafe static void __CPPCALL_HasAbility_Implementation(TsGameplayBlueprintFunctionLibrary.__HasAbility_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.HasAbility(__Params->entityId, skillId);
	}

	// Token: 0x06019207 RID: 102919 RVA: 0x006795A0 File Offset: 0x006777A0
	protected unsafe static void __CPPCALL_GetSkillInfo_Implementation(TsGameplayBlueprintFunctionLibrary.__GetSkillInfo_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		UScriptStructStackOnlyPtr nativeUStructPtr = SSkillInfo.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SSkillInfo skillInfo = TsGameplayBlueprintFunctionLibrary.GetSkillInfo(__Params->entityId, skillId);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (skillInfo != null) ? skillInfo.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x06019208 RID: 102920 RVA: 0x006795E8 File Offset: 0x006777E8
	protected unsafe static void __CPPCALL_SetSkillPriority_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSkillPriority_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		TsGameplayBlueprintFunctionLibrary.SetSkillPriority(__Params->entityId, skillId, __Params->priority);
	}

	// Token: 0x06019209 RID: 102921 RVA: 0x00679614 File Offset: 0x00677814
	protected unsafe static void __CPPCALL_EndSkill_Implementation(TsGameplayBlueprintFunctionLibrary.__EndSkill_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		TsGameplayBlueprintFunctionLibrary.EndSkill(__Params->entityId, skillId, __Params->isSyn, __Params->isNotEnd);
	}

	// Token: 0x0601920A RID: 102922 RVA: 0x00679648 File Offset: 0x00677848
	protected unsafe static void __CPPCALL_BeginSkill_Implementation(TsGameplayBlueprintFunctionLibrary.__BeginSkill_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->target);
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.BeginSkill(__Params->entityId, __Params->skillId, __Params->isSyn, orCreateUObjectByNativePointer, __Params->socketName);
	}

	// Token: 0x0601920B RID: 102923 RVA: 0x00679688 File Offset: 0x00677888
	protected unsafe static void __CPPCALL_BeginSkillAsync_Implementation(TsGameplayBlueprintFunctionLibrary.__BeginSkillAsync_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->target);
		UKuroBooleanEventBinder orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		TsGameplayBlueprintFunctionLibrary.BeginSkillAsync(__Params->entityId, __Params->skillId, orCreateUObjectByNativePointer, __Params->socketName, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601920C RID: 102924 RVA: 0x006796C8 File Offset: 0x006778C8
	protected unsafe static void __CPPCALL_SkillBehaviorBegin_Implementation(TsGameplayBlueprintFunctionLibrary.__SkillBehaviorBegin_FunctionParams* __Params)
	{
		GA_Base_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<GA_Base_C>(__Params->ga);
		SSkillBehaviorAction action = new SSkillBehaviorAction(&__Params->action, true, true);
		TsGameplayBlueprintFunctionLibrary.SkillBehaviorBegin(__Params->entityId, orCreateUObjectByNativePointer, action);
	}

	// Token: 0x0601920D RID: 102925 RVA: 0x00679700 File Offset: 0x00677900
	protected unsafe static void __CPPCALL_GetLocationByAction_Implementation(TsGameplayBlueprintFunctionLibrary.__GetLocationByAction_FunctionParams* __Params)
	{
		GA_Base_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<GA_Base_C>(__Params->ga);
		SSkillBehaviorAction action = new SSkillBehaviorAction(&__Params->action, true, true);
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetLocationByAction(__Params->entityId, orCreateUObjectByNativePointer, action);
	}

	// Token: 0x0601920E RID: 102926 RVA: 0x0067973C File Offset: 0x0067793C
	protected unsafe static void __CPPCALL_GetRotationByAction_Implementation(TsGameplayBlueprintFunctionLibrary.__GetRotationByAction_FunctionParams* __Params)
	{
		GA_Base_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<GA_Base_C>(__Params->ga);
		SSkillBehaviorAction action = new SSkillBehaviorAction(&__Params->action, true, true);
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetRotationByAction(__Params->entityId, orCreateUObjectByNativePointer, action);
	}

	// Token: 0x0601920F RID: 102927 RVA: 0x00679778 File Offset: 0x00677978
	protected unsafe static void __CPPCALL_SkillBehaviorSatisfy_Implementation(TsGameplayBlueprintFunctionLibrary.__SkillBehaviorSatisfy_FunctionParams* __Params)
	{
		GA_Base_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<GA_Base_C>(__Params->ga);
		SSkillBehaviorCondition condition = new SSkillBehaviorCondition(&__Params->condition, true, true);
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.SkillBehaviorSatisfy(__Params->entityId, orCreateUObjectByNativePointer, condition);
	}

	// Token: 0x06019210 RID: 102928 RVA: 0x006797B3 File Offset: 0x006779B3
	protected unsafe static void __CPPCALL_GetSkillTarget_Implementation(TsGameplayBlueprintFunctionLibrary.__GetSkillTarget_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor skillTarget = TsGameplayBlueprintFunctionLibrary.GetSkillTarget(__Params->entityId);
		ptr = ((skillTarget != null) ? skillTarget.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06019211 RID: 102929 RVA: 0x006797D8 File Offset: 0x006779D8
	protected unsafe static void __CPPCALL_SetSkillTarget_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSkillTarget_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->target);
		TsGameplayBlueprintFunctionLibrary.SetSkillTarget(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06019212 RID: 102930 RVA: 0x00679800 File Offset: 0x00677A00
	protected unsafe static void __CPPCALL_LockOnTargetAndSetShow_Implementation(TsGameplayBlueprintFunctionLibrary.__LockOnTargetAndSetShow_FunctionParams* __Params)
	{
		SSkillTarget config = new SSkillTarget(&__Params->config, true, true);
		TsGameplayBlueprintFunctionLibrary.LockOnTargetAndSetShow(__Params->entityId, config);
	}

	// Token: 0x06019213 RID: 102931 RVA: 0x00679828 File Offset: 0x00677A28
	protected unsafe static void __CPPCALL_IsHasInputDir_Implementation(TsGameplayBlueprintFunctionLibrary.__IsHasInputDir_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.IsHasInputDir(__Params->entityId);
	}

	// Token: 0x06019214 RID: 102932 RVA: 0x0067983B File Offset: 0x00677A3B
	protected unsafe static void __CPPCALL_GetSkillIdWithGroupId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetSkillIdWithGroupId_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetSkillIdWithGroupId(__Params->entityId, __Params->groupId));
	}

	// Token: 0x06019215 RID: 102933 RVA: 0x0067985A File Offset: 0x00677A5A
	protected unsafe static void __CPPCALL_GetSkillAcceptInput_Implementation(TsGameplayBlueprintFunctionLibrary.__GetSkillAcceptInput_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetSkillAcceptInput(__Params->entityId);
	}

	// Token: 0x06019216 RID: 102934 RVA: 0x0067986D File Offset: 0x00677A6D
	protected unsafe static void __CPPCALL_SetSkillAcceptInput_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSkillAcceptInput_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetSkillAcceptInput(__Params->entityId, __Params->skillAcceptInput);
	}

	// Token: 0x06019217 RID: 102935 RVA: 0x00679880 File Offset: 0x00677A80
	protected unsafe static void __CPPCALL_SetCommonSkillCanBeInterrupt_Implementation(TsGameplayBlueprintFunctionLibrary.__SetCommonSkillCanBeInterrupt_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetCommonSkillCanBeInterrupt(__Params->entityId, __Params->canBeInterrupt);
	}

	// Token: 0x06019218 RID: 102936 RVA: 0x00679893 File Offset: 0x00677A93
	protected unsafe static void __CPPCALL_GetCommonSkillCanBeInterrupt_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCommonSkillCanBeInterrupt_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetCommonSkillCanBeInterrupt(__Params->entityId);
	}

	// Token: 0x06019219 RID: 102937 RVA: 0x006798A8 File Offset: 0x00677AA8
	protected unsafe static void __CPPCALL_OnActivateAbility_Implementation(TsGameplayBlueprintFunctionLibrary.__OnActivateAbility_FunctionParams* __Params)
	{
		UGameplayAbility orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameplayAbility>(__Params->ga);
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.OnActivateAbility(__Params->entityId, orCreateUObjectByNativePointer, __Params->isCommitSuccess);
	}

	// Token: 0x0601921A RID: 102938 RVA: 0x006798DC File Offset: 0x00677ADC
	protected unsafe static void __CPPCALL_OnEndAbility_Implementation(TsGameplayBlueprintFunctionLibrary.__OnEndAbility_FunctionParams* __Params)
	{
		UGameplayAbility orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameplayAbility>(__Params->ga);
		TsGameplayBlueprintFunctionLibrary.OnEndAbility(__Params->entityId, orCreateUObjectByNativePointer, __Params->wasCancelled);
	}

	// Token: 0x0601921B RID: 102939 RVA: 0x00679908 File Offset: 0x00677B08
	protected unsafe static void __CPPCALL_GetPriority_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPriority_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetPriority(__Params->entityId, skillId);
	}

	// Token: 0x0601921C RID: 102940 RVA: 0x00679934 File Offset: 0x00677B34
	protected unsafe static void __CPPCALL_GetActivePriority_Implementation(TsGameplayBlueprintFunctionLibrary.__GetActivePriority_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetActivePriority(__Params->entityId, skillId);
	}

	// Token: 0x0601921D RID: 102941 RVA: 0x00679960 File Offset: 0x00677B60
	protected unsafe static void __CPPCALL_GetSkillMontageInstance_Implementation(TsGameplayBlueprintFunctionLibrary.__GetSkillMontageInstance_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		ref IntPtr ptr = ref *(&__Params->__Result);
		UAnimMontage skillMontageInstance = TsGameplayBlueprintFunctionLibrary.GetSkillMontageInstance(__Params->entityId, skillId, __Params->index);
		ptr = ((skillMontageInstance != null) ? skillMontageInstance.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601921E RID: 102942 RVA: 0x006799A4 File Offset: 0x00677BA4
	protected unsafe static void __CPPCALL_GetSkillNeedPlayMontageIndex_Implementation(TsGameplayBlueprintFunctionLibrary.__GetSkillNeedPlayMontageIndex_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetSkillNeedPlayMontageIndex(__Params->entityId, skillId);
	}

	// Token: 0x0601921F RID: 102943 RVA: 0x006799D0 File Offset: 0x00677BD0
	protected unsafe static void __CPPCALL_CreateSpecifiedTagPlayMontageAndWaitAbilityTask_Implementation(TsGameplayBlueprintFunctionLibrary.__CreateSpecifiedTagPlayMontageAndWaitAbilityTask_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.CreateSpecifiedTagPlayMontageAndWaitAbilityTask(BuiltinUtils.GetOrCreateUObjectByNativePointer<GA_Base_C>(__Params->gameplayAbility), __Params->checkHit, __Params->skeletalMeshComponentTag, __Params->montageIndex, __Params->startSection, __Params->startTimeSeconds, __Params->needTick, __Params->animRootMotionTranslationScale);
	}

	// Token: 0x06019220 RID: 102944 RVA: 0x00679A0C File Offset: 0x00677C0C
	protected unsafe static void __CPPCALL_SetSkillRotateLocation_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSkillRotateLocation_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetSkillRotateLocation(__Params->entityId, __Params->location);
	}

	// Token: 0x06019221 RID: 102945 RVA: 0x00679A1F File Offset: 0x00677C1F
	protected unsafe static void __CPPCALL_SetSkillRotateDirect_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSkillRotateDirect_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetSkillRotateDirect(__Params->entityId, __Params->direct);
	}

	// Token: 0x06019222 RID: 102946 RVA: 0x00679A32 File Offset: 0x00677C32
	protected unsafe static void __CPPCALL_CallAnimBreakPoint_Implementation(TsGameplayBlueprintFunctionLibrary.__CallAnimBreakPoint_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.CallAnimBreakPoint(__Params->entityId);
	}

	// Token: 0x06019223 RID: 102947 RVA: 0x00679A3F File Offset: 0x00677C3F
	protected unsafe static void __CPPCALL_RollingGround_Implementation(TsGameplayBlueprintFunctionLibrary.__RollingGround_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.RollingGround(__Params->entityId);
	}

	// Token: 0x06019224 RID: 102948 RVA: 0x00679A4C File Offset: 0x00677C4C
	protected unsafe static void __CPPCALL_ActivateAbilityVision_Implementation(TsGameplayBlueprintFunctionLibrary.__ActivateAbilityVision_FunctionParams* __Params)
	{
		EVisionType visionType = (EVisionType)__Params->visionType;
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.ActivateAbilityVision(__Params->entityId, visionType);
	}

	// Token: 0x06019225 RID: 102949 RVA: 0x00679A74 File Offset: 0x00677C74
	protected unsafe static void __CPPCALL_EndAbilityVision_Implementation(TsGameplayBlueprintFunctionLibrary.__EndAbilityVision_FunctionParams* __Params)
	{
		EVisionType visionType = (EVisionType)__Params->visionType;
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.EndAbilityVision(__Params->entityId, visionType);
	}

	// Token: 0x06019226 RID: 102950 RVA: 0x00679A9C File Offset: 0x00677C9C
	protected unsafe static void __CPPCALL_ActivateAbilityVisionPlayAudio_Implementation(TsGameplayBlueprintFunctionLibrary.__ActivateAbilityVisionPlayAudio_FunctionParams* __Params)
	{
		EVisionType visionType = (EVisionType)__Params->visionType;
		TsGameplayBlueprintFunctionLibrary.ActivateAbilityVisionPlayAudio(__Params->entityId, visionType);
	}

	// Token: 0x06019227 RID: 102951 RVA: 0x00679ABC File Offset: 0x00677CBC
	protected unsafe static void __CPPCALL_GetVisionIdList_Implementation(TsGameplayBlueprintFunctionLibrary.__GetVisionIdList_FunctionParams* __Params)
	{
		TArray<int> visionIdList = TsGameplayBlueprintFunctionLibrary.GetVisionIdList(__Params->entityId);
		if (visionIdList == null)
		{
			return;
		}
		visionIdList.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06019228 RID: 102952 RVA: 0x00679AEE File Offset: 0x00677CEE
	protected unsafe static void __CPPCALL_ExitMultiSkillStateOfMorphVision_Implementation(TsGameplayBlueprintFunctionLibrary.__ExitMultiSkillStateOfMorphVision_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ExitMultiSkillStateOfMorphVision(__Params->entityId);
	}

	// Token: 0x06019229 RID: 102953 RVA: 0x00679AFB File Offset: 0x00677CFB
	protected unsafe static void __CPPCALL_SetKeepMultiSkillState_Implementation(TsGameplayBlueprintFunctionLibrary.__SetKeepMultiSkillState_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetKeepMultiSkillState(__Params->entityId, __Params->keepOnMorphEnd, __Params->keepOnGoDown);
	}

	// Token: 0x0601922A RID: 102954 RVA: 0x00679B14 File Offset: 0x00677D14
	protected unsafe static void __CPPCALL_SetEnableAttackInputActionOfMorphVision_Implementation(TsGameplayBlueprintFunctionLibrary.__SetEnableAttackInputActionOfMorphVision_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetEnableAttackInputActionOfMorphVision(__Params->entityId, __Params->bEnable);
	}

	// Token: 0x0601922B RID: 102955 RVA: 0x00679B28 File Offset: 0x00677D28
	protected unsafe static void __CPPCALL_GetVisionLevelList_Implementation(TsGameplayBlueprintFunctionLibrary.__GetVisionLevelList_FunctionParams* __Params)
	{
		TArray<int> visionLevelList = TsGameplayBlueprintFunctionLibrary.GetVisionLevelList(__Params->entityId);
		if (visionLevelList == null)
		{
			return;
		}
		visionLevelList.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0601922C RID: 102956 RVA: 0x00679B5A File Offset: 0x00677D5A
	protected unsafe static void __CPPCALL_GetVisionSkillId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetVisionSkillId_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetVisionSkillId(__Params->entityId, __Params->visionId, __Params->level);
	}

	// Token: 0x0601922D RID: 102957 RVA: 0x00679B7C File Offset: 0x00677D7C
	protected unsafe static void __CPPCALL_InterruptSkill_Implementation(TsGameplayBlueprintFunctionLibrary.__InterruptSkill_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		TsGameplayBlueprintFunctionLibrary.InterruptSkill(__Params->entityId, skillId, __Params->isSyn);
	}

	// Token: 0x0601922E RID: 102958 RVA: 0x00679BA8 File Offset: 0x00677DA8
	protected unsafe static void __CPPCALL_DeleteSkills_Implementation(TsGameplayBlueprintFunctionLibrary.__DeleteSkills_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.DeleteSkills(__Params->entityId);
	}

	// Token: 0x0601922F RID: 102959 RVA: 0x00679BB5 File Offset: 0x00677DB5
	protected unsafe static void __CPPCALL_GetCurrentMontageCorrespondingSkillId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCurrentMontageCorrespondingSkillId_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetCurrentMontageCorrespondingSkillId(__Params->entityId));
	}

	// Token: 0x06019230 RID: 102960 RVA: 0x00679BD0 File Offset: 0x00677DD0
	protected unsafe static void __CPPCALL_SetSocketName_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSocketName_FunctionParams* __Params)
	{
		string socketName = FString.ToString((void*)(&__Params->socketName));
		TsGameplayBlueprintFunctionLibrary.SetSocketName(__Params->entityId, socketName);
	}

	// Token: 0x06019231 RID: 102961 RVA: 0x00679BF6 File Offset: 0x00677DF6
	protected unsafe static void __CPPCALL_GetSocketName_Implementation(TsGameplayBlueprintFunctionLibrary.__GetSocketName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetSocketName(__Params->entityId));
	}

	// Token: 0x06019232 RID: 102962 RVA: 0x00679C10 File Offset: 0x00677E10
	protected unsafe static void __CPPCALL_GetPointTransform_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPointTransform_FunctionParams* __Params)
	{
		string boneName = FString.ToString((void*)(&__Params->boneName));
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetPointTransform(__Params->entityId, boneName);
	}

	// Token: 0x06019233 RID: 102963 RVA: 0x00679C3C File Offset: 0x00677E3C
	protected unsafe static void __CPPCALL_PlaySkillMontage2Server_Implementation(TsGameplayBlueprintFunctionLibrary.__PlaySkillMontage2Server_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		string startSection = FString.ToString((void*)(&__Params->startSection));
		TsGameplayBlueprintFunctionLibrary.PlaySkillMontage2Server(__Params->entityId, skillId, __Params->montageIndex, __Params->rate, startSection, __Params->startTimeSeconds);
	}

	// Token: 0x06019234 RID: 102964 RVA: 0x00679C84 File Offset: 0x00677E84
	protected unsafe static void __CPPCALL_EndSkillMontage_Implementation(TsGameplayBlueprintFunctionLibrary.__EndSkillMontage_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		TsGameplayBlueprintFunctionLibrary.EndSkillMontage(__Params->entityId, skillId, __Params->montageIndex);
	}

	// Token: 0x06019235 RID: 102965 RVA: 0x00679CB0 File Offset: 0x00677EB0
	protected unsafe static void __CPPCALL_BeginAddMoveByInputDirect_Implementation(TsGameplayBlueprintFunctionLibrary.__BeginAddMoveByInputDirect_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.BeginAddMoveByInputDirect(__Params->entityId, __Params->maxSpeed, __Params->accelerationTime, __Params->decelerationTime, __Params->delayTime);
	}

	// Token: 0x06019236 RID: 102966 RVA: 0x00679CD5 File Offset: 0x00677ED5
	protected unsafe static void __CPPCALL_BeginAbsoluteTimeStop_Implementation(TsGameplayBlueprintFunctionLibrary.__BeginAbsoluteTimeStop_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.BeginAbsoluteTimeStop(__Params->entityId, __Params->duration, __Params->stopMove);
	}

	// Token: 0x06019237 RID: 102967 RVA: 0x00679CEE File Offset: 0x00677EEE
	protected unsafe static void __CPPCALL_EndAbsoluteTimeStop_Implementation(TsGameplayBlueprintFunctionLibrary.__EndAbsoluteTimeStop_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EndAbsoluteTimeStop(__Params->entityId);
	}

	// Token: 0x06019238 RID: 102968 RVA: 0x00679CFB File Offset: 0x00677EFB
	protected unsafe static void __CPPCALL_BeginTimeStopRequest_Implementation(TsGameplayBlueprintFunctionLibrary.__BeginTimeStopRequest_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.BeginTimeStopRequest(__Params->entityId, __Params->duration);
	}

	// Token: 0x06019239 RID: 102969 RVA: 0x00679D0E File Offset: 0x00677F0E
	protected unsafe static void __CPPCALL_EndTimeStopRequest_Implementation(TsGameplayBlueprintFunctionLibrary.__EndTimeStopRequest_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EndTimeStopRequest(__Params->entityId);
	}

	// Token: 0x0601923A RID: 102970 RVA: 0x00679D1B File Offset: 0x00677F1B
	protected unsafe static void __CPPCALL_EndAddMoveByInputDirect_Implementation(TsGameplayBlueprintFunctionLibrary.__EndAddMoveByInputDirect_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EndAddMoveByInputDirect(__Params->entityId);
	}

	// Token: 0x0601923B RID: 102971 RVA: 0x00679D28 File Offset: 0x00677F28
	protected unsafe static void __CPPCALL_CanActivateFixHook_Implementation(TsGameplayBlueprintFunctionLibrary.__CanActivateFixHook_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.CanActivateFixHook(__Params->entityId);
	}

	// Token: 0x0601923C RID: 102972 RVA: 0x00679D3B File Offset: 0x00677F3B
	protected unsafe static void __CPPCALL_FixHookTargetLocation_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookTargetLocation_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FixHookTargetLocation(__Params->entityId);
	}

	// Token: 0x0601923D RID: 102973 RVA: 0x00679D50 File Offset: 0x00677F50
	protected unsafe static void __CPPCALL_FixHookTargetPathways_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookTargetPathways_FunctionParams* __Params)
	{
		TArray<FVectorDouble> tarray = TsGameplayBlueprintFunctionLibrary.FixHookTargetPathways(__Params->entityId);
		if (tarray == null)
		{
			return;
		}
		tarray.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0601923E RID: 102974 RVA: 0x00679D82 File Offset: 0x00677F82
	protected unsafe static void __CPPCALL_FixHookTargetEnterPortalCapture_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookTargetEnterPortalCapture_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor aactor = TsGameplayBlueprintFunctionLibrary.FixHookTargetEnterPortalCapture(__Params->entityId);
		ptr = ((aactor != null) ? aactor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601923F RID: 102975 RVA: 0x00679DA4 File Offset: 0x00677FA4
	protected unsafe static void __CPPCALL_FixHookTargetActor_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookTargetActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor aactor = TsGameplayBlueprintFunctionLibrary.FixHookTargetActor(__Params->entityId);
		ptr = ((aactor != null) ? aactor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06019240 RID: 102976 RVA: 0x00679DC6 File Offset: 0x00677FC6
	protected unsafe static void __CPPCALL_FixHookTargetIsSuiGuangType_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookTargetIsSuiGuangType_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FixHookTargetIsSuiGuangType(__Params->entityId);
	}

	// Token: 0x06019241 RID: 102977 RVA: 0x00679DD9 File Offset: 0x00677FD9
	protected unsafe static void __CPPCALL_GetHookTargetType_Implementation(TsGameplayBlueprintFunctionLibrary.__GetHookTargetType_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsGameplayBlueprintFunctionLibrary.GetHookTargetType(__Params->entityId);
	}

	// Token: 0x06019242 RID: 102978 RVA: 0x00679DEE File Offset: 0x00677FEE
	protected unsafe static void __CPPCALL_FixHookTargetForward_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookTargetForward_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FixHookTargetForward(__Params->entityId);
	}

	// Token: 0x06019243 RID: 102979 RVA: 0x00679E01 File Offset: 0x00678001
	protected unsafe static void __CPPCALL_NextFixHookTargetLocation_Implementation(TsGameplayBlueprintFunctionLibrary.__NextFixHookTargetLocation_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.NextFixHookTargetLocation(__Params->entityId);
	}

	// Token: 0x06019244 RID: 102980 RVA: 0x00679E14 File Offset: 0x00678014
	protected unsafe static void __CPPCALL_FixHookTargetInheritSpeed_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookTargetInheritSpeed_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FixHookTargetInheritSpeed(__Params->entityId);
	}

	// Token: 0x06019245 RID: 102981 RVA: 0x00679E27 File Offset: 0x00678027
	protected unsafe static void __CPPCALL_FixHookTargetIsClimb_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookTargetIsClimb_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FixHookTargetIsClimb(__Params->entityId);
	}

	// Token: 0x06019246 RID: 102982 RVA: 0x00679E3A File Offset: 0x0067803A
	protected unsafe static void __CPPCALL_SetIsHookEndByInterrupt_Implementation(TsGameplayBlueprintFunctionLibrary.__SetIsHookEndByInterrupt_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetIsHookEndByInterrupt(__Params->entityId, __Params->isInterrupt);
	}

	// Token: 0x06019247 RID: 102983 RVA: 0x00679E4D File Offset: 0x0067804D
	protected unsafe static void __CPPCALL_FixHookIsSummitPoint_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookIsSummitPoint_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FixHookIsSummitPoint(__Params->entityId);
	}

	// Token: 0x06019248 RID: 102984 RVA: 0x00679E60 File Offset: 0x00678060
	protected unsafe static void __CPPCALL_FixHookIsNormalPoint_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookIsNormalPoint_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FixHookIsNormalPoint(__Params->entityId);
	}

	// Token: 0x06019249 RID: 102985 RVA: 0x00679E73 File Offset: 0x00678073
	protected unsafe static void __CPPCALL_GetHookOverrideSpeed_Implementation(TsGameplayBlueprintFunctionLibrary.__GetHookOverrideSpeed_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetHookOverrideSpeed(__Params->entityId);
	}

	// Token: 0x0601924A RID: 102986 RVA: 0x00679E86 File Offset: 0x00678086
	protected unsafe static void __CPPCALL_FixHookIsGravityPoint_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookIsGravityPoint_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FixHookIsGravityPoint(__Params->entityId);
	}

	// Token: 0x0601924B RID: 102987 RVA: 0x00679E99 File Offset: 0x00678099
	protected unsafe static void __CPPCALL_KiteHookSupportSwitchMidway_Implementation(TsGameplayBlueprintFunctionLibrary.__KiteHookSupportSwitchMidway_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.KiteHookSupportSwitchMidway(__Params->entityId);
	}

	// Token: 0x0601924C RID: 102988 RVA: 0x00679EAC File Offset: 0x006780AC
	protected unsafe static void __CPPCALL_FixHookTargetEntityId_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookTargetEntityId_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FixHookTargetEntityId(__Params->entityId);
	}

	// Token: 0x0601924D RID: 102989 RVA: 0x00679EBF File Offset: 0x006780BF
	protected unsafe static void __CPPCALL_SlashHookPointHasLookAtConfig_Implementation(TsGameplayBlueprintFunctionLibrary.__SlashHookPointHasLookAtConfig_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.SlashHookPointHasLookAtConfig(__Params->entityId);
	}

	// Token: 0x0601924E RID: 102990 RVA: 0x00679ED2 File Offset: 0x006780D2
	protected unsafe static void __CPPCALL_SlashHookPointCharacterLookAtPoint_Implementation(TsGameplayBlueprintFunctionLibrary.__SlashHookPointCharacterLookAtPoint_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.SlashHookPointCharacterLookAtPoint(__Params->entityId);
	}

	// Token: 0x0601924F RID: 102991 RVA: 0x00679EE5 File Offset: 0x006780E5
	protected unsafe static void __CPPCALL_SlashHookPointIsTakeOverCamera_Implementation(TsGameplayBlueprintFunctionLibrary.__SlashHookPointIsTakeOverCamera_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.SlashHookPointIsTakeOverCamera(__Params->entityId);
	}

	// Token: 0x06019250 RID: 102992 RVA: 0x00679EF8 File Offset: 0x006780F8
	protected unsafe static void __CPPCALL_SlashHookPointSafePointLoc_Implementation(TsGameplayBlueprintFunctionLibrary.__SlashHookPointSafePointLoc_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.SlashHookPointSafePointLoc(__Params->entityId);
	}

	// Token: 0x06019251 RID: 102993 RVA: 0x00679F0B File Offset: 0x0067810B
	protected unsafe static void __CPPCALL_SlashHookPointSafePointRot_Implementation(TsGameplayBlueprintFunctionLibrary.__SlashHookPointSafePointRot_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.SlashHookPointSafePointRot(__Params->entityId);
	}

	// Token: 0x06019252 RID: 102994 RVA: 0x00679F1E File Offset: 0x0067811E
	protected unsafe static void __CPPCALL_StartChargeSlash_Implementation(TsGameplayBlueprintFunctionLibrary.__StartChargeSlash_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.StartChargeSlash(__Params->entityId);
	}

	// Token: 0x06019253 RID: 102995 RVA: 0x00679F2B File Offset: 0x0067812B
	protected unsafe static void __CPPCALL_StopChargeSlash_Implementation(TsGameplayBlueprintFunctionLibrary.__StopChargeSlash_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.StopChargeSlash(__Params->entityId);
	}

	// Token: 0x06019254 RID: 102996 RVA: 0x00679F38 File Offset: 0x00678138
	protected unsafe static void __CPPCALL_IsSlashGameplayIsSuccess_Implementation(TsGameplayBlueprintFunctionLibrary.__IsSlashGameplayIsSuccess_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.IsSlashGameplayIsSuccess();
	}

	// Token: 0x06019255 RID: 102997 RVA: 0x00679F45 File Offset: 0x00678145
	protected unsafe static void __CPPCALL_GetGravityHookLockInfo_Implementation(TsGameplayBlueprintFunctionLibrary.__GetGravityHookLockInfo_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetGravityHookLockInfo(__Params->entityId);
	}

	// Token: 0x06019256 RID: 102998 RVA: 0x00679F58 File Offset: 0x00678158
	protected unsafe static void __CPPCALL_ChangeGravityByHook_Implementation(TsGameplayBlueprintFunctionLibrary.__ChangeGravityByHook_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ChangeGravityByHook(__Params->entityId, __Params->angleRangeMin, __Params->angleRangeMax, __Params->smoothSecondMin, __Params->smoothSecondMax, __Params->isLerpCamera);
	}

	// Token: 0x06019257 RID: 102999 RVA: 0x00679F84 File Offset: 0x00678184
	protected unsafe static void __CPPCALL_SetIgnoreSocketName_Implementation(TsGameplayBlueprintFunctionLibrary.__SetIgnoreSocketName_FunctionParams* __Params)
	{
		string socketName = FString.ToString((void*)(&__Params->socketName));
		TsGameplayBlueprintFunctionLibrary.SetIgnoreSocketName(__Params->entityId, socketName);
	}

	// Token: 0x06019258 RID: 103000 RVA: 0x00679FAC File Offset: 0x006781AC
	protected unsafe static void __CPPCALL_DeleteIgnoreSocketName_Implementation(TsGameplayBlueprintFunctionLibrary.__DeleteIgnoreSocketName_FunctionParams* __Params)
	{
		string socketName = FString.ToString((void*)(&__Params->socketName));
		TsGameplayBlueprintFunctionLibrary.DeleteIgnoreSocketName(__Params->entityId, socketName);
	}

	// Token: 0x06019259 RID: 103001 RVA: 0x00679FD2 File Offset: 0x006781D2
	protected unsafe static void __CPPCALL_GetToTargetSocketDistance_Implementation(TsGameplayBlueprintFunctionLibrary.__GetToTargetSocketDistance_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetToTargetSocketDistance(__Params->entityId);
	}

	// Token: 0x0601925A RID: 103002 RVA: 0x00679FE8 File Offset: 0x006781E8
	protected unsafe static void __CPPCALL_SetPredictProjectileInfo_Implementation(TsGameplayBlueprintFunctionLibrary.__SetPredictProjectileInfo_FunctionParams* __Params)
	{
		TArray<FVector> tarray = new TArray<FVector>(&__Params->outPathPosition, true, true);
		FHitResult outHit = new FHitResult(&__Params->outHit, true, true);
		TsGameplayBlueprintFunctionLibrary.SetPredictProjectileInfo(__Params->entityId, __Params->returnValue, ref tarray, __Params->outLastTraceDestination, outHit);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->outPathPosition, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x0601925B RID: 103003 RVA: 0x0067A046 File Offset: 0x00678246
	protected unsafe static void __CPPCALL_SetVisible_Implementation(TsGameplayBlueprintFunctionLibrary.__SetVisible_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetVisible(__Params->entityId, __Params->isShow);
	}

	// Token: 0x0601925C RID: 103004 RVA: 0x0067A059 File Offset: 0x00678259
	protected unsafe static void __CPPCALL_GetCharUnifiedMoveState_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCharUnifiedMoveState_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsGameplayBlueprintFunctionLibrary.GetCharUnifiedMoveState(__Params->entityId);
	}

	// Token: 0x0601925D RID: 103005 RVA: 0x0067A06E File Offset: 0x0067826E
	protected unsafe static void __CPPCALL_GetCharUnifiedPositionState_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCharUnifiedPositionState_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsGameplayBlueprintFunctionLibrary.GetCharUnifiedPositionState(__Params->entityId);
	}

	// Token: 0x0601925E RID: 103006 RVA: 0x0067A083 File Offset: 0x00678283
	protected unsafe static void __CPPCALL_ExitHitState_Implementation(TsGameplayBlueprintFunctionLibrary.__ExitHitState_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ExitHitState(__Params->entityId);
	}

	// Token: 0x0601925F RID: 103007 RVA: 0x0067A090 File Offset: 0x00678290
	protected unsafe static void __CPPCALL_SetDirectionState_Implementation(TsGameplayBlueprintFunctionLibrary.__SetDirectionState_FunctionParams* __Params)
	{
		ECharViewDirectionState newViewState = (ECharViewDirectionState)__Params->newViewState;
		TsGameplayBlueprintFunctionLibrary.SetDirectionState(__Params->entityId, newViewState);
	}

	// Token: 0x06019260 RID: 103008 RVA: 0x0067A0B0 File Offset: 0x006782B0
	protected unsafe static void __CPPCALL_GetDirectionState_Implementation(TsGameplayBlueprintFunctionLibrary.__GetDirectionState_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsGameplayBlueprintFunctionLibrary.GetDirectionState(__Params->entityId);
	}

	// Token: 0x06019261 RID: 103009 RVA: 0x0067A0C5 File Offset: 0x006782C5
	protected unsafe static void __CPPCALL_GetIsInGame_Implementation(TsGameplayBlueprintFunctionLibrary.__GetIsInGame_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetIsInGame(__Params->entityId);
	}

	// Token: 0x06019262 RID: 103010 RVA: 0x0067A0D8 File Offset: 0x006782D8
	protected unsafe static void __CPPCALL_SprintPress_Implementation(TsGameplayBlueprintFunctionLibrary.__SprintPress_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SprintPress(__Params->entityId);
	}

	// Token: 0x06019263 RID: 103011 RVA: 0x0067A0E5 File Offset: 0x006782E5
	protected unsafe static void __CPPCALL_SprintRelease_Implementation(TsGameplayBlueprintFunctionLibrary.__SprintRelease_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SprintRelease(__Params->entityId);
	}

	// Token: 0x06019264 RID: 103012 RVA: 0x0067A0F2 File Offset: 0x006782F2
	protected unsafe static void __CPPCALL_StandPress_Implementation(TsGameplayBlueprintFunctionLibrary.__StandPress_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.StandPress(__Params->entityId);
	}

	// Token: 0x06019265 RID: 103013 RVA: 0x0067A0FF File Offset: 0x006782FF
	protected unsafe static void __CPPCALL_SwingPress_Implementation(TsGameplayBlueprintFunctionLibrary.__SwingPress_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SwingPress(__Params->entityId);
	}

	// Token: 0x06019266 RID: 103014 RVA: 0x0067A10C File Offset: 0x0067830C
	protected unsafe static void __CPPCALL_SwingRelease_Implementation(TsGameplayBlueprintFunctionLibrary.__SwingRelease_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SwingRelease(__Params->entityId);
	}

	// Token: 0x06019267 RID: 103015 RVA: 0x0067A119 File Offset: 0x00678319
	protected unsafe static void __CPPCALL_CustomSetWalkOrRun_Implementation(TsGameplayBlueprintFunctionLibrary.__CustomSetWalkOrRun_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.CustomSetWalkOrRun(__Params->entityId, __Params->isWalk);
	}

	// Token: 0x06019268 RID: 103016 RVA: 0x0067A12C File Offset: 0x0067832C
	protected unsafe static void __CPPCALL_EnterAimStatus_Implementation(TsGameplayBlueprintFunctionLibrary.__EnterAimStatus_FunctionParams* __Params)
	{
		EAimViewState aimViewState = (EAimViewState)__Params->aimViewState;
		TsGameplayBlueprintFunctionLibrary.EnterAimStatus(__Params->entityId, aimViewState);
	}

	// Token: 0x06019269 RID: 103017 RVA: 0x0067A14C File Offset: 0x0067834C
	protected unsafe static void __CPPCALL_ExitAimStatus_Implementation(TsGameplayBlueprintFunctionLibrary.__ExitAimStatus_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ExitAimStatus(__Params->entityId);
	}

	// Token: 0x0601926A RID: 103018 RVA: 0x0067A159 File Offset: 0x00678359
	protected unsafe static void __CPPCALL_EnableEntity_Implementation(TsGameplayBlueprintFunctionLibrary.__EnableEntity_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EnableEntity(__Params->entityId, __Params->isEnable);
	}

	// Token: 0x0601926B RID: 103019 RVA: 0x0067A16C File Offset: 0x0067836C
	protected unsafe static void __CPPCALL_UpdateAnimInfoHit_Implementation(TsGameplayBlueprintFunctionLibrary.__UpdateAnimInfoHit_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsGameplayBlueprintFunctionLibrary.UpdateAnimInfoHit(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601926C RID: 103020 RVA: 0x0067A194 File Offset: 0x00678394
	protected unsafe static void __CPPCALL_UpdateAnimInfoFk_Implementation(TsGameplayBlueprintFunctionLibrary.__UpdateAnimInfoFk_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsGameplayBlueprintFunctionLibrary.UpdateAnimInfoFk(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601926D RID: 103021 RVA: 0x0067A1BC File Offset: 0x006783BC
	protected unsafe static void __CPPCALL_UpdateAnimInfoUnifiedState_Implementation(TsGameplayBlueprintFunctionLibrary.__UpdateAnimInfoUnifiedState_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsGameplayBlueprintFunctionLibrary.UpdateAnimInfoUnifiedState(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601926E RID: 103022 RVA: 0x0067A1E4 File Offset: 0x006783E4
	protected unsafe static void __CPPCALL_UpdateAnimInfoUnifiedStateRoleNpc_Implementation(TsGameplayBlueprintFunctionLibrary.__UpdateAnimInfoUnifiedStateRoleNpc_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsGameplayBlueprintFunctionLibrary.UpdateAnimInfoUnifiedStateRoleNpc(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601926F RID: 103023 RVA: 0x0067A209 File Offset: 0x00678409
	protected unsafe static void __CPPCALL_GetIsCharRotateWithCameraWhenManipulate_Implementation(TsGameplayBlueprintFunctionLibrary.__GetIsCharRotateWithCameraWhenManipulate_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetIsCharRotateWithCameraWhenManipulate(__Params->entityId);
	}

	// Token: 0x06019270 RID: 103024 RVA: 0x0067A21C File Offset: 0x0067841C
	protected unsafe static void __CPPCALL_GetIsUseCatapultUpAnim_Implementation(TsGameplayBlueprintFunctionLibrary.__GetIsUseCatapultUpAnim_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetIsUseCatapultUpAnim(__Params->entityId);
	}

	// Token: 0x06019271 RID: 103025 RVA: 0x0067A22F File Offset: 0x0067842F
	protected unsafe static void __CPPCALL_GetNextMultiSkillId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetNextMultiSkillId_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetNextMultiSkillId(__Params->entityId, __Params->skillId);
	}

	// Token: 0x06019272 RID: 103026 RVA: 0x0067A248 File Offset: 0x00678448
	protected unsafe static void __CPPCALL_GetNextMultiSkillIdNew_Implementation(TsGameplayBlueprintFunctionLibrary.__GetNextMultiSkillIdNew_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetNextMultiSkillIdNew(__Params->entityId, __Params->skillId);
	}

	// Token: 0x06019273 RID: 103027 RVA: 0x0067A261 File Offset: 0x00678461
	protected unsafe static void __CPPCALL_GetManipulateInteractTargetCanInteract_Implementation(TsGameplayBlueprintFunctionLibrary.__GetManipulateInteractTargetCanInteract_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetManipulateInteractTargetCanInteract(__Params->entityId);
	}

	// Token: 0x06019274 RID: 103028 RVA: 0x0067A274 File Offset: 0x00678474
	protected unsafe static void __CPPCALL_GetHookInteractTargetCanInteract_Implementation(TsGameplayBlueprintFunctionLibrary.__GetHookInteractTargetCanInteract_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetHookInteractTargetCanInteract(__Params->entityId);
	}

	// Token: 0x06019275 RID: 103029 RVA: 0x0067A287 File Offset: 0x00678487
	protected unsafe static void __CPPCALL_GetHookInteractTargetIsIgnorePlayerCollision_Implementation(TsGameplayBlueprintFunctionLibrary.__GetHookInteractTargetIsIgnorePlayerCollision_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetHookInteractTargetIsIgnorePlayerCollision(__Params->entityId);
	}

	// Token: 0x06019276 RID: 103030 RVA: 0x0067A29A File Offset: 0x0067849A
	protected unsafe static void __CPPCALL_StartManipulateInteract_Implementation(TsGameplayBlueprintFunctionLibrary.__StartManipulateInteract_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.StartManipulateInteract(__Params->entityId);
	}

	// Token: 0x06019277 RID: 103031 RVA: 0x0067A2AD File Offset: 0x006784AD
	protected unsafe static void __CPPCALL_EndManipulateInteract_Implementation(TsGameplayBlueprintFunctionLibrary.__EndManipulateInteract_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EndManipulateInteract(__Params->entityId);
	}

	// Token: 0x06019278 RID: 103032 RVA: 0x0067A2BA File Offset: 0x006784BA
	protected unsafe static void __CPPCALL_StartStatueInteract_Implementation(TsGameplayBlueprintFunctionLibrary.__StartStatueInteract_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.StartStatueInteract(__Params->entityId);
	}

	// Token: 0x06019279 RID: 103033 RVA: 0x0067A2CD File Offset: 0x006784CD
	protected unsafe static void __CPPCALL_EndStatueInteract_Implementation(TsGameplayBlueprintFunctionLibrary.__EndStatueInteract_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EndStatueInteract(__Params->entityId);
	}

	// Token: 0x0601927A RID: 103034 RVA: 0x0067A2DA File Offset: 0x006784DA
	protected unsafe static void __CPPCALL_StartCustomInteract_Implementation(TsGameplayBlueprintFunctionLibrary.__StartCustomInteract_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.StartCustomInteract(__Params->entityId);
	}

	// Token: 0x0601927B RID: 103035 RVA: 0x0067A2ED File Offset: 0x006784ED
	protected unsafe static void __CPPCALL_EndCustomInteract_Implementation(TsGameplayBlueprintFunctionLibrary.__EndCustomInteract_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EndCustomInteract(__Params->entityId);
	}

	// Token: 0x0601927C RID: 103036 RVA: 0x0067A2FA File Offset: 0x006784FA
	protected unsafe static void __CPPCALL_QuantumDiffusionInteract_Implementation(TsGameplayBlueprintFunctionLibrary.__QuantumDiffusionInteract_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.QuantumDiffusionInteract(__Params->entityId);
	}

	// Token: 0x0601927D RID: 103037 RVA: 0x0067A308 File Offset: 0x00678508
	protected unsafe static void __CPPCALL_GetShootSwordManipulateInteractActors_Implementation(TsGameplayBlueprintFunctionLibrary.__GetShootSwordManipulateInteractActors_FunctionParams* __Params)
	{
		TArray<AActor> shootSwordManipulateInteractActors = TsGameplayBlueprintFunctionLibrary.GetShootSwordManipulateInteractActors(__Params->entityId);
		if (shootSwordManipulateInteractActors == null)
		{
			return;
		}
		shootSwordManipulateInteractActors.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0601927E RID: 103038 RVA: 0x0067A33A File Offset: 0x0067853A
	protected unsafe static void __CPPCALL_GetManipulateInteractLocation_Implementation(TsGameplayBlueprintFunctionLibrary.__GetManipulateInteractLocation_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetManipulateInteractLocation(__Params->entityId);
	}

	// Token: 0x0601927F RID: 103039 RVA: 0x0067A34D File Offset: 0x0067854D
	protected unsafe static void __CPPCALL_EnvironmentInfoDetect_Implementation(TsGameplayBlueprintFunctionLibrary.__EnvironmentInfoDetect_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EnvironmentInfoDetect(__Params->entityId, __Params->location);
	}

	// Token: 0x06019280 RID: 103040 RVA: 0x0067A360 File Offset: 0x00678560
	protected unsafe static void __CPPCALL_LockOnSpecifyTarget_Implementation(TsGameplayBlueprintFunctionLibrary.__LockOnSpecifyTarget_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.LockOnSpecifyTarget(__Params->entityId, __Params->targetEntityId);
	}

	// Token: 0x06019281 RID: 103041 RVA: 0x0067A373 File Offset: 0x00678573
	protected unsafe static void __CPPCALL_IsSkillInCd_Implementation(TsGameplayBlueprintFunctionLibrary.__IsSkillInCd_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.IsSkillInCd(__Params->entityId, __Params->skillId);
	}

	// Token: 0x06019282 RID: 103042 RVA: 0x0067A38C File Offset: 0x0067858C
	protected unsafe static void __CPPCALL_SendHookSkillUseLogData_Implementation(TsGameplayBlueprintFunctionLibrary.__SendHookSkillUseLogData_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SendHookSkillUseLogData(__Params->entityId, __Params->hasTarget);
	}

	// Token: 0x06019283 RID: 103043 RVA: 0x0067A39F File Offset: 0x0067859F
	protected unsafe static void __CPPCALL_SendManipulateSkillUseLogData_Implementation(TsGameplayBlueprintFunctionLibrary.__SendManipulateSkillUseLogData_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SendManipulateSkillUseLogData(__Params->entityId, __Params->hasTarget);
	}

	// Token: 0x06019284 RID: 103044 RVA: 0x0067A3B2 File Offset: 0x006785B2
	protected unsafe static void __CPPCALL_SendScanSkillUseLogData_Implementation(TsGameplayBlueprintFunctionLibrary.__SendScanSkillUseLogData_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SendScanSkillUseLogData(__Params->entityId, __Params->hasTarget);
	}

	// Token: 0x06019285 RID: 103045 RVA: 0x0067A3C5 File Offset: 0x006785C5
	protected unsafe static void __CPPCALL_DynamicAttachEntityToActor_Implementation(TsGameplayBlueprintFunctionLibrary.__DynamicAttachEntityToActor_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.DynamicAttachEntityToActor(__Params->entityId, __Params->targetEntityId, __Params->socketName);
	}

	// Token: 0x06019286 RID: 103046 RVA: 0x0067A3E0 File Offset: 0x006785E0
	protected unsafe static void __CPPCALL_SetEntityEnable_Implementation(TsGameplayBlueprintFunctionLibrary.__SetEntityEnable_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->callObject);
		string reason = FString.ToString((void*)(&__Params->reason));
		TsGameplayBlueprintFunctionLibrary.SetEntityEnable(__Params->entityId, __Params->enable, orCreateUObjectByNativePointer, reason);
	}

	// Token: 0x06019287 RID: 103047 RVA: 0x0067A41C File Offset: 0x0067861C
	protected unsafe static void __CPPCALL_SetActorVisible_Implementation(TsGameplayBlueprintFunctionLibrary.__SetActorVisible_FunctionParams* __Params)
	{
		string reason = FString.ToString((void*)(&__Params->reason));
		TsGameplayBlueprintFunctionLibrary.SetActorVisible(__Params->entityId, __Params->visible, __Params->collision, __Params->movable, reason, __Params->sync);
	}

	// Token: 0x06019288 RID: 103048 RVA: 0x0067A45C File Offset: 0x0067865C
	protected unsafe static void __CPPCALL_SetSkillTargetDirection_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSkillTargetDirection_FunctionParams* __Params)
	{
		ESkillTargetDirection direction = (ESkillTargetDirection)__Params->direction;
		TsGameplayBlueprintFunctionLibrary.SetSkillTargetDirection(__Params->entityId, direction);
	}

	// Token: 0x06019289 RID: 103049 RVA: 0x0067A47C File Offset: 0x0067867C
	protected unsafe static void __CPPCALL_ChangeAiControllerDebugDraw_Implementation(TsGameplayBlueprintFunctionLibrary.__ChangeAiControllerDebugDraw_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ChangeAiControllerDebugDraw(__Params->entityId, __Params->debug);
	}

	// Token: 0x0601928A RID: 103050 RVA: 0x0067A48F File Offset: 0x0067868F
	protected unsafe static void __CPPCALL_GetBeHitAnimType_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBeHitAnimType_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsGameplayBlueprintFunctionLibrary.GetBeHitAnimType(__Params->typeId);
	}

	// Token: 0x0601928B RID: 103051 RVA: 0x0067A4A4 File Offset: 0x006786A4
	protected unsafe static void __CPPCALL_StartInhalation_Implementation(TsGameplayBlueprintFunctionLibrary.__StartInhalation_FunctionParams* __Params)
	{
		TArray<FGameplayTag> tarray = new TArray<FGameplayTag>(&__Params->tag, true, true);
		TsGameplayBlueprintFunctionLibrary.StartInhalation(__Params->entityId, __Params->strength, __Params->distance, __Params->isPowerfulMode, __Params->checkAngle, ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->tag, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x0601928C RID: 103052 RVA: 0x0067A4FE File Offset: 0x006786FE
	protected unsafe static void __CPPCALL_StopInhalation_Implementation(TsGameplayBlueprintFunctionLibrary.__StopInhalation_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.StopInhalation(__Params->entityId);
	}

	// Token: 0x0601928D RID: 103053 RVA: 0x0067A50C File Offset: 0x0067870C
	protected unsafe static void __CPPCALL_TryGetDebugMovementComp_Implementation(TsGameplayBlueprintFunctionLibrary.__TryGetDebugMovementComp_FunctionParams* __Params)
	{
		string pbDataId = FString.ToString((void*)(&__Params->pbDataId));
		ref IntPtr ptr = ref *(&__Params->__Result);
		UKuroDebugMovementComponent ukuroDebugMovementComponent = TsGameplayBlueprintFunctionLibrary.TryGetDebugMovementComp(pbDataId);
		ptr = ((ukuroDebugMovementComponent != null) ? ukuroDebugMovementComponent.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601928E RID: 103054 RVA: 0x0067A541 File Offset: 0x00678741
	protected unsafe static void __CPPCALL_TryPlayLinkAnim_Implementation(TsGameplayBlueprintFunctionLibrary.__TryPlayLinkAnim_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.TryPlayLinkAnim();
	}

	// Token: 0x0601928F RID: 103055 RVA: 0x0067A548 File Offset: 0x00678748
	protected unsafe static void __CPPCALL_TraceGround_Implementation(TsGameplayBlueprintFunctionLibrary.__TraceGround_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.TraceGround(__Params->entityId, __Params->start, __Params->end, __Params->draw);
	}

	// Token: 0x06019290 RID: 103056 RVA: 0x0067A570 File Offset: 0x00678770
	protected unsafe static void __CPPCALL_ChangePhantomTeam_Implementation(TsGameplayBlueprintFunctionLibrary.__ChangePhantomTeam_FunctionParams* __Params)
	{
		TArray<FGameplayTag> tarray = new TArray<FGameplayTag>(&__Params->skillTriggerTags, true, true);
		TsGameplayBlueprintFunctionLibrary.ChangePhantomTeam(__Params->phantomFormationId, ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->skillTriggerTags, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06019291 RID: 103057 RVA: 0x0067A5B2 File Offset: 0x006787B2
	protected unsafe static void __CPPCALL_RevertPhantomTeam_Implementation(TsGameplayBlueprintFunctionLibrary.__RevertPhantomTeam_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.RevertPhantomTeam();
	}

	// Token: 0x06019292 RID: 103058 RVA: 0x0067A5B9 File Offset: 0x006787B9
	protected unsafe static void __CPPCALL_GetFormationAttribute_Implementation(TsGameplayBlueprintFunctionLibrary.__GetFormationAttribute_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetFormationAttribute(__Params->type);
	}

	// Token: 0x06019293 RID: 103059 RVA: 0x0067A5CC File Offset: 0x006787CC
	protected unsafe static void __CPPCALL_GetEntityDeltaMillisecond_Implementation(TsGameplayBlueprintFunctionLibrary.__GetEntityDeltaMillisecond_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetEntityDeltaMillisecond(__Params->entityId);
	}

	// Token: 0x06019294 RID: 103060 RVA: 0x0067A5DF File Offset: 0x006787DF
	protected unsafe static void __CPPCALL_SyncTwoEntityLocationAndRotation_Implementation(TsGameplayBlueprintFunctionLibrary.__SyncTwoEntityLocationAndRotation_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SyncTwoEntityLocationAndRotation(__Params->fromEntityId, __Params->toEntityId);
	}

	// Token: 0x06019295 RID: 103061 RVA: 0x0067A5F2 File Offset: 0x006787F2
	protected unsafe static void __CPPCALL_GetFishingBoat_Implementation(TsGameplayBlueprintFunctionLibrary.__GetFishingBoat_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor fishingBoat = TsGameplayBlueprintFunctionLibrary.GetFishingBoat();
		ptr = ((fishingBoat != null) ? fishingBoat.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06019296 RID: 103062 RVA: 0x0067A60E File Offset: 0x0067880E
	protected unsafe static void __CPPCALL_FishingBoatSprint_Implementation(TsGameplayBlueprintFunctionLibrary.__FishingBoatSprint_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.FishingBoatSprint(__Params->entityId, __Params->maxSpeedRatio, __Params->exceedLimitDuration, __Params->duration);
	}

	// Token: 0x06019297 RID: 103063 RVA: 0x0067A62D File Offset: 0x0067882D
	protected unsafe static void __CPPCALL_FishingBoatSkill_Implementation(TsGameplayBlueprintFunctionLibrary.__FishingBoatSkill_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.FishingBoatSkill((EFishingSkillType)__Params->type);
	}

	// Token: 0x06019298 RID: 103064 RVA: 0x0067A63A File Offset: 0x0067883A
	protected unsafe static void __CPPCALL_GetCharacterMorphType_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCharacterMorphType_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsGameplayBlueprintFunctionLibrary.GetCharacterMorphType(__Params->entityId);
	}

	// Token: 0x06019299 RID: 103065 RVA: 0x0067A650 File Offset: 0x00678850
	protected unsafe static void __CPPCALL_SetCharacterMorphType_Implementation(TsGameplayBlueprintFunctionLibrary.__SetCharacterMorphType_FunctionParams* __Params)
	{
		EMorphType morphType = (EMorphType)__Params->morphType;
		TsGameplayBlueprintFunctionLibrary.SetCharacterMorphType(__Params->entityId, morphType);
	}

	// Token: 0x0601929A RID: 103066 RVA: 0x0067A670 File Offset: 0x00678870
	protected unsafe static void __CPPCALL_SetSpecialEnergyAttrValue_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSpecialEnergyAttrValue_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetSpecialEnergyAttrValue(__Params->entityId, __Params->attrId, __Params->value);
	}

	// Token: 0x0601929B RID: 103067 RVA: 0x0067A689 File Offset: 0x00678889
	protected unsafe static void __CPPCALL_GetFuLuoLuoSpecialEnergyType_Implementation(TsGameplayBlueprintFunctionLibrary.__GetFuLuoLuoSpecialEnergyType_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetFuLuoLuoSpecialEnergyType(__Params->entityId, __Params->index);
	}

	// Token: 0x0601929C RID: 103068 RVA: 0x0067A6A2 File Offset: 0x006788A2
	protected unsafe static void __CPPCALL_StartBattleQte_Implementation(TsGameplayBlueprintFunctionLibrary.__StartBattleQte_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.StartBattleQte(__Params->entityId, __Params->skillId, __Params->battleQteId);
	}

	// Token: 0x0601929D RID: 103069 RVA: 0x0067A6BC File Offset: 0x006788BC
	protected unsafe static void __CPPCALL_StopGroup1Skill_Implementation(TsGameplayBlueprintFunctionLibrary.__StopGroup1Skill_FunctionParams* __Params)
	{
		string reason = FString.ToString((void*)(&__Params->reason));
		TsGameplayBlueprintFunctionLibrary.StopGroup1Skill(__Params->entityId, reason);
	}

	// Token: 0x0601929E RID: 103070 RVA: 0x0067A6E2 File Offset: 0x006788E2
	protected unsafe static void __CPPCALL_GetCharactersLocationNearBy_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCharactersLocationNearBy_FunctionParams* __Params)
	{
		UScriptStructStackOnlyPtr nativeUStructPtr = SCharacterLocationsAndRadius.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SCharacterLocationsAndRadius charactersLocationNearBy = TsGameplayBlueprintFunctionLibrary.GetCharactersLocationNearBy(__Params->center, __Params->distance, __Params->maxCount);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (charactersLocationNearBy != null) ? charactersLocationNearBy.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x0601929F RID: 103071 RVA: 0x0067A71B File Offset: 0x0067891B
	protected unsafe static void __CPPCALL_GetCurrentPlayer_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCurrentPlayer_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		TsBaseCharacter currentPlayer = TsGameplayBlueprintFunctionLibrary.GetCurrentPlayer();
		ptr = ((currentPlayer != null) ? currentPlayer.NativePtr : ((IntPtr)0));
	}

	// Token: 0x060192A0 RID: 103072 RVA: 0x0067A738 File Offset: 0x00678938
	protected unsafe static void __CPPCALL_IsEnemy_Implementation(TsGameplayBlueprintFunctionLibrary.__IsEnemy_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->owner);
		TsBaseCharacter orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->other);
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.IsEnemy(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060192A1 RID: 103073 RVA: 0x0067A76A File Offset: 0x0067896A
	protected unsafe static void __CPPCALL_SetWalkOffLedge_Implementation(TsGameplayBlueprintFunctionLibrary.__SetWalkOffLedge_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetWalkOffLedge(__Params->entityId, __Params->walkOff);
	}

	// Token: 0x060192A2 RID: 103074 RVA: 0x0067A780 File Offset: 0x00678980
	protected unsafe static void __CPPCALL_StartFlyingFeather_Implementation(TsGameplayBlueprintFunctionLibrary.__StartFlyingFeather_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->owner);
		BP_FlyingFeatherConfig_C orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_FlyingFeatherConfig_C>(__Params->config);
		TsGameplayBlueprintFunctionLibrary.StartFlyingFeather(orCreateUObjectByNativePointer, __Params->initLocation, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060192A3 RID: 103075 RVA: 0x0067A7B0 File Offset: 0x006789B0
	protected unsafe static void __CPPCALL_GetFlyingFeatherTargetId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetFlyingFeatherTargetId_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->owner);
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetFlyingFeatherTargetId(orCreateUObjectByNativePointer));
	}

	// Token: 0x060192A4 RID: 103076 RVA: 0x0067A7DC File Offset: 0x006789DC
	protected unsafe static void __CPPCALL_AddFlyingFeatherTargetTag_Implementation(TsGameplayBlueprintFunctionLibrary.__AddFlyingFeatherTargetTag_FunctionParams* __Params)
	{
		string entityId = FString.ToString((void*)(&__Params->entityId));
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor aactor = TsGameplayBlueprintFunctionLibrary.AddFlyingFeatherTargetTag(__Params->tag, entityId);
		ptr = ((aactor != null) ? aactor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x060192A5 RID: 103077 RVA: 0x0067A818 File Offset: 0x00678A18
	protected unsafe static void __CPPCALL_UpdateFlyingFeather_Implementation(TsGameplayBlueprintFunctionLibrary.__UpdateFlyingFeather_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->owner);
		string target = FString.ToString((void*)(&__Params->target));
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.UpdateFlyingFeather(orCreateUObjectByNativePointer, target);
	}

	// Token: 0x060192A6 RID: 103078 RVA: 0x0067A84B File Offset: 0x00678A4B
	protected unsafe static void __CPPCALL_EmitGlobalClientEvent_Implementation(TsGameplayBlueprintFunctionLibrary.__EmitGlobalClientEvent_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EmitGlobalClientEvent(__Params->eventNameTag);
	}

	// Token: 0x060192A7 RID: 103079 RVA: 0x0067A858 File Offset: 0x00678A58
	protected unsafe static void __CPPCALL_GetDriverEntityId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetDriverEntityId_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetDriverEntityId(__Params->vehicleEntityId);
	}

	// Token: 0x060192A8 RID: 103080 RVA: 0x0067A86C File Offset: 0x00678A6C
	protected unsafe static void __CPPCALL_StartCableWayMove_Implementation(TsGameplayBlueprintFunctionLibrary.__StartCableWayMove_FunctionParams* __Params)
	{
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		TsGameplayBlueprintFunctionLibrary.StartCableWayMove(__Params->id, orCreateUObjectByNativePointer);
	}

	// Token: 0x060192A9 RID: 103081 RVA: 0x0067A891 File Offset: 0x00678A91
	protected unsafe static void __CPPCALL_StopCableWayMove_Implementation(TsGameplayBlueprintFunctionLibrary.__StopCableWayMove_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.StopCableWayMove(__Params->id);
	}

	// Token: 0x060192AA RID: 103082 RVA: 0x0067A89E File Offset: 0x00678A9E
	protected unsafe static void __CPPCALL_GetBuffInstigatorId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffInstigatorId_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBuffInstigatorId(__Params->entityId, __Params->buffId, __Params->getInstigatorSummoner);
	}

	// Token: 0x060192AB RID: 103083 RVA: 0x0067A8C0 File Offset: 0x00678AC0
	protected unsafe static void __CPPCALL_SetSubMeshOrder_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSubMeshOrder_FunctionParams* __Params)
	{
		string meshName = FString.ToString((void*)(&__Params->meshName));
		PD_CharacterControllerData_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<PD_CharacterControllerData_C>(__Params->charControllerData);
		TSoftObjectPtr<UEffectModelBase> effectDataAssetRef = new TSoftObjectPtr<UEffectModelBase>(&__Params->effectDataAssetRef, true, true);
		TsGameplayBlueprintFunctionLibrary.SetSubMeshOrder(__Params->entityId, meshName, __Params->visible, orCreateUObjectByNativePointer, effectDataAssetRef, __Params->delayTime);
	}

	// Token: 0x060192AC RID: 103084 RVA: 0x0067A90F File Offset: 0x00678B0F
	protected unsafe static void __CPPCALL_GetPilotThrowSpeed_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPilotThrowSpeed_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetPilotThrowSpeed();
	}

	// Token: 0x060192AD RID: 103085 RVA: 0x0067A91C File Offset: 0x00678B1C
	protected unsafe static void __CPPCALL_GetPilotThrowDirection_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPilotThrowDirection_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetPilotThrowDirection();
	}

	// Token: 0x060192AE RID: 103086 RVA: 0x0067A929 File Offset: 0x00678B29
	protected unsafe static void __CPPCALL_GetPilotThrowGravity_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPilotThrowGravity_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetPilotThrowGravity();
	}

	// Token: 0x060192AF RID: 103087 RVA: 0x0067A936 File Offset: 0x00678B36
	protected unsafe static void __CPPCALL_GetPilotThrowNeedMotorRide_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPilotThrowNeedMotorRide_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetPilotThrowNeedMotorRide();
	}

	// Token: 0x060192B0 RID: 103088 RVA: 0x0067A943 File Offset: 0x00678B43
	protected unsafe static void __CPPCALL_GetPilotThrowIsDisableInterrupt_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPilotThrowIsDisableInterrupt_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetPilotThrowIsDisableInterrupt();
	}

	// Token: 0x060192B1 RID: 103089 RVA: 0x0067A950 File Offset: 0x00678B50
	protected unsafe static void __CPPCALL_OpenPilotThrowGameplayCamera_Implementation(TsGameplayBlueprintFunctionLibrary.__OpenPilotThrowGameplayCamera_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.OpenPilotThrowGameplayCamera(__Params->targetEntityId);
	}

	// Token: 0x060192B2 RID: 103090 RVA: 0x0067A95D File Offset: 0x00678B5D
	protected unsafe static void __CPPCALL_GetCurrentTargetPilotSkeletalMeshComponent_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCurrentTargetPilotSkeletalMeshComponent_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		USkeletalMeshComponent currentTargetPilotSkeletalMeshComponent = TsGameplayBlueprintFunctionLibrary.GetCurrentTargetPilotSkeletalMeshComponent(__Params->entityId);
		ptr = ((currentTargetPilotSkeletalMeshComponent != null) ? currentTargetPilotSkeletalMeshComponent.NativePtr : ((IntPtr)0));
	}

	// Token: 0x060192B3 RID: 103091 RVA: 0x0067A97F File Offset: 0x00678B7F
	protected unsafe static void __CPPCALL_GetPilotCurrentInRangePoint_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPilotCurrentInRangePoint_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetPilotCurrentInRangePoint();
	}

	// Token: 0x060192B4 RID: 103092 RVA: 0x0067A98C File Offset: 0x00678B8C
	protected unsafe static void __CPPCALL_GetVehicleCatapultUnitRisingTime_Implementation(TsGameplayBlueprintFunctionLibrary.__GetVehicleCatapultUnitRisingTime_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetVehicleCatapultUnitRisingTime(__Params->entityId);
	}

	// Token: 0x060192B5 RID: 103093 RVA: 0x0067A99F File Offset: 0x00678B9F
	protected unsafe static void __CPPCALL_GuessJokerNpcTurnToIdlePerform_Implementation(TsGameplayBlueprintFunctionLibrary.__GuessJokerNpcTurnToIdlePerform_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.GuessJokerNpcTurnToIdlePerform();
	}

	// Token: 0x060192B6 RID: 103094 RVA: 0x0067A9A6 File Offset: 0x00678BA6
	protected unsafe static void __CPPCALL_LevelFlowDeadlySkeletonMeshCastToCharacter_Implementation(TsGameplayBlueprintFunctionLibrary.__LevelFlowDeadlySkeletonMeshCastToCharacter_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.LevelFlowDeadlySkeletonMeshCastToCharacter();
	}

	// Token: 0x060192B7 RID: 103095 RVA: 0x0067A9AD File Offset: 0x00678BAD
	protected unsafe static void __CPPCALL_LevelFlowAddBuff_Implementation(TsGameplayBlueprintFunctionLibrary.__LevelFlowAddBuff_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.LevelFlowAddBuff(__Params->entityId, __Params->buffId);
	}

	// Token: 0x060192B8 RID: 103096 RVA: 0x0067A9C0 File Offset: 0x00678BC0
	protected unsafe static void __CPPCALL_LevelFlowRemoveBuff_Implementation(TsGameplayBlueprintFunctionLibrary.__LevelFlowRemoveBuff_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.LevelFlowRemoveBuff(__Params->entityId, __Params->buffId);
	}

	// Token: 0x060192B9 RID: 103097 RVA: 0x0067A9D3 File Offset: 0x00678BD3
	protected unsafe static void __CPPCALL_LevelFlowCameraShake_Implementation(TsGameplayBlueprintFunctionLibrary.__LevelFlowCameraShake_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.LevelFlowCameraShake(FString.ToString((void*)(&__Params->cameraShakeBp)));
	}

	// Token: 0x060192BA RID: 103098 RVA: 0x0067A9E8 File Offset: 0x00678BE8
	protected unsafe static void __CPPCALL_LevelFlowPlayLevelSequence_Implementation(TsGameplayBlueprintFunctionLibrary.__LevelFlowPlayLevelSequence_FunctionParams* __Params)
	{
		string path = FString.ToString((void*)(&__Params->path));
		string mark = FString.ToString((void*)(&__Params->mark));
		TsGameplayBlueprintFunctionLibrary.LevelFlowPlayLevelSequence(path, mark);
	}

	// Token: 0x060192BB RID: 103099 RVA: 0x0067AA14 File Offset: 0x00678C14
	protected unsafe static void __CPPCALL_CallSpecialSkillCodeFunction_Implementation(TsGameplayBlueprintFunctionLibrary.__CallSpecialSkillCodeFunction_FunctionParams* __Params)
	{
		string functionName = FString.ToString((void*)(&__Params->functionName));
		FKuroCodeFunctionPayload payload = new FKuroCodeFunctionPayload(&__Params->payload, true, true);
		UScriptStructStackOnlyPtr nativeUStructPtr = FKuroCodeFunctionResult.StaticStruct();
		IntPtr dest = &__Params->__Result;
		FKuroCodeFunctionResult fkuroCodeFunctionResult = TsGameplayBlueprintFunctionLibrary.CallSpecialSkillCodeFunction(__Params->entityId, functionName, payload);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (fkuroCodeFunctionResult != null) ? fkuroCodeFunctionResult.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x060192BC RID: 103100 RVA: 0x0067AA6C File Offset: 0x00678C6C
	protected unsafe static void __CPPCALL_XigelikaAddBean_Implementation(TsGameplayBlueprintFunctionLibrary.__XigelikaAddBean_FunctionParams* __Params)
	{
		string bean = FString.ToString((void*)(&__Params->bean));
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.XigelikaAddBean(__Params->entityId, bean);
	}

	// Token: 0x060192BD RID: 103101 RVA: 0x0067AA98 File Offset: 0x00678C98
	protected unsafe static void __CPPCALL_XigelikaGetBeanResultant_Implementation(TsGameplayBlueprintFunctionLibrary.__XigelikaGetBeanResultant_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.XigelikaGetBeanResultant(__Params->entityId);
	}

	// Token: 0x060192BE RID: 103102 RVA: 0x0067AAAB File Offset: 0x00678CAB
	protected unsafe static void __CPPCALL_XigelikaConsumeBean_Implementation(TsGameplayBlueprintFunctionLibrary.__XigelikaConsumeBean_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.XigelikaConsumeBean(__Params->entityId);
	}

	// Token: 0x060192BF RID: 103103 RVA: 0x0067AAB8 File Offset: 0x00678CB8
	protected unsafe static void __CPPCALL_XigelikaResetBean_Implementation(TsGameplayBlueprintFunctionLibrary.__XigelikaResetBean_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.XigelikaResetBean(__Params->entityId);
	}

	// Token: 0x060192C0 RID: 103104 RVA: 0x0067AAC5 File Offset: 0x00678CC5
	protected unsafe static void __CPPCALL_OpenQuickHack_Implementation(TsGameplayBlueprintFunctionLibrary.__OpenQuickHack_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.OpenQuickHack(__Params->deviceId, __Params->ownerEntityId, __Params->closeWhenInteractFinish, __Params->interactFinishGameplayEventTag);
	}

	// Token: 0x060192C1 RID: 103105 RVA: 0x0067AAE4 File Offset: 0x00678CE4
	protected unsafe static void __CPPCALL_CloseQuickHack_Implementation(TsGameplayBlueprintFunctionLibrary.__CloseQuickHack_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.CloseQuickHack();
	}

	// Token: 0x060192C2 RID: 103106 RVA: 0x0067AAEB File Offset: 0x00678CEB
	protected unsafe static void __CPPCALL_FunctionOpen_Implementation(TsGameplayBlueprintFunctionLibrary.__FunctionOpen_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FunctionOpen(__Params->functionType);
	}

	// Token: 0x0400BB94 RID: 48020
	[Nullable(2)]
	private static TimerHandle FlyingFeatherHandle;

	// Token: 0x0400BB95 RID: 48021
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsGameplayBlueprintFunctionLibrary.TsGameplayBlueprintFunctionLibrary_C";

	// Token: 0x0400BB96 RID: 48022
	private static IntPtr _ClassPtr;

	// Token: 0x0400BB97 RID: 48023
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020093C1 RID: 37825
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ContainsTag_FunctionParams
	{
		// Token: 0x0402FA9C RID: 195228
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FA9D RID: 195229
		[FieldOffset(4)]
		public FGameplayTag tag;

		// Token: 0x0402FA9E RID: 195230
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA9F RID: 195231
		[FieldOffset(24)]
		public bool __Result;
	}

	// Token: 0x020093C2 RID: 37826
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __AddTag_FunctionParams
	{
		// Token: 0x0402FAA0 RID: 195232
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAA1 RID: 195233
		[FieldOffset(4)]
		public FGameplayTag tag;

		// Token: 0x0402FAA2 RID: 195234
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093C3 RID: 37827
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __AddTagWithDuration_FunctionParams
	{
		// Token: 0x0402FAA3 RID: 195235
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAA4 RID: 195236
		[FieldOffset(4)]
		public float duration;

		// Token: 0x0402FAA5 RID: 195237
		[FieldOffset(8)]
		public FGameplayTag tag;

		// Token: 0x0402FAA6 RID: 195238
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093C4 RID: 37828
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __AddTagByName_FunctionParams
	{
		// Token: 0x0402FAA7 RID: 195239
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAA8 RID: 195240
		[FieldOffset(8)]
		public FString tagName;

		// Token: 0x0402FAA9 RID: 195241
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093C5 RID: 37829
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __RemoveTag_FunctionParams
	{
		// Token: 0x0402FAAA RID: 195242
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAAB RID: 195243
		[FieldOffset(4)]
		public FGameplayTag tag;

		// Token: 0x0402FAAC RID: 195244
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093C6 RID: 37830
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __RemoveTagByName_FunctionParams
	{
		// Token: 0x0402FAAD RID: 195245
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAAE RID: 195246
		[FieldOffset(8)]
		public FString tagName;

		// Token: 0x0402FAAF RID: 195247
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093C7 RID: 37831
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __AddCue_FunctionParams
	{
		// Token: 0x0402FAB0 RID: 195248
		[FieldOffset(0)]
		public int instigatorEntityId;

		// Token: 0x0402FAB1 RID: 195249
		[FieldOffset(4)]
		public int targetEntityId;

		// Token: 0x0402FAB2 RID: 195250
		[FieldOffset(8)]
		public long cueId;

		// Token: 0x0402FAB3 RID: 195251
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093C8 RID: 37832
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __RemoveCue_FunctionParams
	{
		// Token: 0x0402FAB4 RID: 195252
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAB5 RID: 195253
		[FieldOffset(8)]
		public long cueId;

		// Token: 0x0402FAB6 RID: 195254
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093C9 RID: 37833
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetGameplayCueEffectForceRecycle_FunctionParams
	{
		// Token: 0x0402FAB7 RID: 195255
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAB8 RID: 195256
		[FieldOffset(8)]
		public long cueId;

		// Token: 0x0402FAB9 RID: 195257
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093CA RID: 37834
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsLogicAutonomousProxy_FunctionParams
	{
		// Token: 0x0402FABA RID: 195258
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FABB RID: 195259
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FABC RID: 195260
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020093CB RID: 37835
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __RemoveActiveGameplayEffect_FunctionParams
	{
		// Token: 0x0402FABD RID: 195261
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FABE RID: 195262
		[FieldOffset(4)]
		public byte handle;

		// Token: 0x0402FABF RID: 195263
		[FieldOffset(12)]
		public float stacksToRemove;

		// Token: 0x0402FAC0 RID: 195264
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402FAC1 RID: 195265
		[FieldOffset(24)]
		public bool __Result;
	}

	// Token: 0x020093CC RID: 37836
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __RemoveBuffByTag_FunctionParams
	{
		// Token: 0x0402FAC2 RID: 195266
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAC3 RID: 195267
		[FieldOffset(4)]
		public FGameplayTag tag;

		// Token: 0x0402FAC4 RID: 195268
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093CD RID: 37837
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __AddPassiveSkill_FunctionParams
	{
		// Token: 0x0402FAC5 RID: 195269
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAC6 RID: 195270
		[FieldOffset(8)]
		public long passiveSkillId;

		// Token: 0x0402FAC7 RID: 195271
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093CE RID: 37838
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __RemovePassiveSkill_FunctionParams
	{
		// Token: 0x0402FAC8 RID: 195272
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAC9 RID: 195273
		[FieldOffset(8)]
		public long passiveSkillId;

		// Token: 0x0402FACA RID: 195274
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093CF RID: 37839
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetPassiveGaSkillId_FunctionParams
	{
		// Token: 0x0402FACB RID: 195275
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FACC RID: 195276
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x0402FACD RID: 195277
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093D0 RID: 37840
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __AddBuffForDebug_FunctionParams
	{
		// Token: 0x0402FACE RID: 195278
		[FieldOffset(0)]
		public int instigatorEntityId;

		// Token: 0x0402FACF RID: 195279
		[FieldOffset(4)]
		public int targetEntityId;

		// Token: 0x0402FAD0 RID: 195280
		[FieldOffset(8)]
		public long buffId;

		// Token: 0x0402FAD1 RID: 195281
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093D1 RID: 37841
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SendCombatEventForDebug_FunctionParams
	{
		// Token: 0x0402FAD2 RID: 195282
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAD3 RID: 195283
		[FieldOffset(8)]
		public FString tagName;

		// Token: 0x0402FAD4 RID: 195284
		[FieldOffset(24)]
		public bool needSave;

		// Token: 0x0402FAD5 RID: 195285
		[FieldOffset(25)]
		public bool isMainState;

		// Token: 0x0402FAD6 RID: 195286
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093D2 RID: 37842
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SendLevelEventForDebug_FunctionParams
	{
		// Token: 0x0402FAD7 RID: 195287
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAD8 RID: 195288
		[FieldOffset(8)]
		public FString tagName;

		// Token: 0x0402FAD9 RID: 195289
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093D3 RID: 37843
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __AddBuffFromGA_FunctionParams
	{
		// Token: 0x0402FADA RID: 195290
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FADB RID: 195291
		[FieldOffset(8)]
		public IntPtr target;

		// Token: 0x0402FADC RID: 195292
		[FieldOffset(16)]
		public long buffId;

		// Token: 0x0402FADD RID: 195293
		[FieldOffset(24)]
		public FString skillId;

		// Token: 0x0402FADE RID: 195294
		[FieldOffset(40)]
		public int addCount;

		// Token: 0x0402FADF RID: 195295
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093D4 RID: 37844
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __RemoveBuffById_FunctionParams
	{
		// Token: 0x0402FAE0 RID: 195296
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAE1 RID: 195297
		[FieldOffset(8)]
		public long buffId;

		// Token: 0x0402FAE2 RID: 195298
		[FieldOffset(16)]
		public int stackCount;

		// Token: 0x0402FAE3 RID: 195299
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093D5 RID: 37845
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetBuffCountById_FunctionParams
	{
		// Token: 0x0402FAE4 RID: 195300
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAE5 RID: 195301
		[FieldOffset(8)]
		public long buffId;

		// Token: 0x0402FAE6 RID: 195302
		[FieldOffset(16)]
		public bool enforceOnGoingCheck;

		// Token: 0x0402FAE7 RID: 195303
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402FAE8 RID: 195304
		[FieldOffset(32)]
		public int __Result;
	}

	// Token: 0x020093D6 RID: 37846
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __AddGameplayCueLocal_FunctionParams
	{
		// Token: 0x0402FAE9 RID: 195305
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAEA RID: 195306
		[FieldOffset(4)]
		public float duration;

		// Token: 0x0402FAEB RID: 195307
		[FieldOffset(8)]
		public long cueId;

		// Token: 0x0402FAEC RID: 195308
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093D7 RID: 37847
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetGeDebugString_FunctionParams
	{
		// Token: 0x0402FAED RID: 195309
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAEE RID: 195310
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FAEF RID: 195311
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093D8 RID: 37848
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetTagDebugStrings_FunctionParams
	{
		// Token: 0x0402FAF0 RID: 195312
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAF1 RID: 195313
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FAF2 RID: 195314
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093D9 RID: 37849
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetBuffDebugStrings_FunctionParams
	{
		// Token: 0x0402FAF3 RID: 195315
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAF4 RID: 195316
		[FieldOffset(8)]
		public FString buffStr;

		// Token: 0x0402FAF5 RID: 195317
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402FAF6 RID: 195318
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x020093DA RID: 37850
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetShieldDebugString_FunctionParams
	{
		// Token: 0x0402FAF7 RID: 195319
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAF8 RID: 195320
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x0402FAF9 RID: 195321
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402FAFA RID: 195322
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x020093DB RID: 37851
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetPassiveSkillDebugString_FunctionParams
	{
		// Token: 0x0402FAFB RID: 195323
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAFC RID: 195324
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FAFD RID: 195325
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093DC RID: 37852
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetShieldValue_FunctionParams
	{
		// Token: 0x0402FAFE RID: 195326
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FAFF RID: 195327
		[FieldOffset(4)]
		public int shieldCid;

		// Token: 0x0402FB00 RID: 195328
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB01 RID: 195329
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020093DD RID: 37853
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetAttributeDebugString_FunctionParams
	{
		// Token: 0x0402FB02 RID: 195330
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB03 RID: 195331
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB04 RID: 195332
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093DE RID: 37854
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetAllAttributeDebugStrings_FunctionParams
	{
		// Token: 0x0402FB05 RID: 195333
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB06 RID: 195334
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB07 RID: 195335
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093DF RID: 37855
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetServerBuffString_FunctionParams
	{
		// Token: 0x0402FB08 RID: 195336
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB09 RID: 195337
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB0A RID: 195338
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093E0 RID: 37856
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetServerTagString_FunctionParams
	{
		// Token: 0x0402FB0B RID: 195339
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB0C RID: 195340
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB0D RID: 195341
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093E1 RID: 37857
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetServerAttributeString_FunctionParams
	{
		// Token: 0x0402FB0E RID: 195342
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB0F RID: 195343
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB10 RID: 195344
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093E2 RID: 37858
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetServerPartString_FunctionParams
	{
		// Token: 0x0402FB11 RID: 195345
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB12 RID: 195346
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB13 RID: 195347
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093E3 RID: 37859
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetServerHateString_FunctionParams
	{
		// Token: 0x0402FB14 RID: 195348
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB15 RID: 195349
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB16 RID: 195350
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093E4 RID: 37860
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetServerShieldString_FunctionParams
	{
		// Token: 0x0402FB17 RID: 195351
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB18 RID: 195352
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB19 RID: 195353
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093E5 RID: 37861
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ServerDebugInfoRequest_FunctionParams
	{
		// Token: 0x0402FB1A RID: 195354
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB1B RID: 195355
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093E6 RID: 37862
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetServerDebugInfoDirty_FunctionParams
	{
		// Token: 0x0402FB1C RID: 195356
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB1D RID: 195357
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB1E RID: 195358
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020093E7 RID: 37863
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetServerDebugInfoDirty_FunctionParams
	{
		// Token: 0x0402FB1F RID: 195359
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB20 RID: 195360
		[FieldOffset(4)]
		public bool val;

		// Token: 0x0402FB21 RID: 195361
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093E8 RID: 37864
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __DebugResetBaseVal_FunctionParams
	{
		// Token: 0x0402FB22 RID: 195362
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB23 RID: 195363
		[FieldOffset(4)]
		public float id;

		// Token: 0x0402FB24 RID: 195364
		[FieldOffset(8)]
		public float val;

		// Token: 0x0402FB25 RID: 195365
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093E9 RID: 37865
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DebugResetFormationValue_FunctionParams
	{
		// Token: 0x0402FB26 RID: 195366
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402FB27 RID: 195367
		[FieldOffset(4)]
		public float val;

		// Token: 0x0402FB28 RID: 195368
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093EA RID: 37866
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __Record_FunctionParams
	{
		// Token: 0x0402FB29 RID: 195369
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB2A RID: 195370
		[FieldOffset(4)]
		public bool record;

		// Token: 0x0402FB2B RID: 195371
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB2C RID: 195372
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093EB RID: 37867
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __RefreshEntityListView_FunctionParams
	{
		// Token: 0x0402FB2D RID: 195373
		[FieldOffset(0)]
		public IntPtr listView;

		// Token: 0x0402FB2E RID: 195374
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093EC RID: 37868
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __RefreshEntityComboBox_FunctionParams
	{
		// Token: 0x0402FB2F RID: 195375
		[FieldOffset(0)]
		public IntPtr comboBox;

		// Token: 0x0402FB30 RID: 195376
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093ED RID: 37869
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetEntityComboBox_FunctionParams
	{
		// Token: 0x0402FB31 RID: 195377
		[FieldOffset(0)]
		public IntPtr comboBox;

		// Token: 0x0402FB32 RID: 195378
		[FieldOffset(8)]
		public int entityId;

		// Token: 0x0402FB33 RID: 195379
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093EE RID: 37870
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDebugEntityId_FunctionParams
	{
		// Token: 0x0402FB34 RID: 195380
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB35 RID: 195381
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093EF RID: 37871
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetDebugEntityId_FunctionParams
	{
		// Token: 0x0402FB36 RID: 195382
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB37 RID: 195383
		[FieldOffset(8)]
		public int __Result;
	}

	// Token: 0x020093F0 RID: 37872
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __RefreshBuffListView_FunctionParams
	{
		// Token: 0x0402FB38 RID: 195384
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB39 RID: 195385
		[FieldOffset(8)]
		public IntPtr listView;

		// Token: 0x0402FB3A RID: 195386
		[FieldOffset(16)]
		public FString filterStr;

		// Token: 0x0402FB3B RID: 195387
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093F1 RID: 37873
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBuffIdByHandle_FunctionParams
	{
		// Token: 0x0402FB3C RID: 195388
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB3D RID: 195389
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402FB3E RID: 195390
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB3F RID: 195391
		[FieldOffset(16)]
		public long __Result;
	}

	// Token: 0x020093F2 RID: 37874
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBuffServerIdByHandle_FunctionParams
	{
		// Token: 0x0402FB40 RID: 195392
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB41 RID: 195393
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402FB42 RID: 195394
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB43 RID: 195395
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x020093F3 RID: 37875
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBuffDescByHandle_FunctionParams
	{
		// Token: 0x0402FB44 RID: 195396
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB45 RID: 195397
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402FB46 RID: 195398
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB47 RID: 195399
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093F4 RID: 37876
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBuffActivateByHandle_FunctionParams
	{
		// Token: 0x0402FB48 RID: 195400
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB49 RID: 195401
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402FB4A RID: 195402
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB4B RID: 195403
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020093F5 RID: 37877
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBuffInstigatorStringByHandle_FunctionParams
	{
		// Token: 0x0402FB4C RID: 195404
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB4D RID: 195405
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402FB4E RID: 195406
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB4F RID: 195407
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093F6 RID: 37878
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBuffPeriodStringByHandle_FunctionParams
	{
		// Token: 0x0402FB50 RID: 195408
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB51 RID: 195409
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402FB52 RID: 195410
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB53 RID: 195411
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093F7 RID: 37879
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBuffDurationStringByHandle_FunctionParams
	{
		// Token: 0x0402FB54 RID: 195412
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB55 RID: 195413
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402FB56 RID: 195414
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB57 RID: 195415
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093F8 RID: 37880
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBuffDurationProgress_FunctionParams
	{
		// Token: 0x0402FB58 RID: 195416
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB59 RID: 195417
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402FB5A RID: 195418
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB5B RID: 195419
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020093F9 RID: 37881
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBuffLivingStatusStringByHandle_FunctionParams
	{
		// Token: 0x0402FB5C RID: 195420
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB5D RID: 195421
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402FB5E RID: 195422
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB5F RID: 195423
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093FA RID: 37882
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBuffLevelStringByHandle_FunctionParams
	{
		// Token: 0x0402FB60 RID: 195424
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB61 RID: 195425
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402FB62 RID: 195426
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB63 RID: 195427
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093FB RID: 37883
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBuffStackStringByHandle_FunctionParams
	{
		// Token: 0x0402FB64 RID: 195428
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB65 RID: 195429
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402FB66 RID: 195430
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB67 RID: 195431
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093FC RID: 37884
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBuffDebugStringByHandle_FunctionParams
	{
		// Token: 0x0402FB68 RID: 195432
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB69 RID: 195433
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402FB6A RID: 195434
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB6B RID: 195435
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093FD RID: 37885
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDistance_FunctionParams
	{
		// Token: 0x0402FB6C RID: 195436
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB6D RID: 195437
		[FieldOffset(4)]
		public float max;

		// Token: 0x0402FB6E RID: 195438
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093FE RID: 37886
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetAllMovementHistory_FunctionParams
	{
		// Token: 0x0402FB6F RID: 195439
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB70 RID: 195440
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB71 RID: 195441
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020093FF RID: 37887
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ResetBaseValueLocal_FunctionParams
	{
		// Token: 0x0402FB72 RID: 195442
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB73 RID: 195443
		[FieldOffset(4)]
		public int id;

		// Token: 0x0402FB74 RID: 195444
		[FieldOffset(8)]
		public float val;

		// Token: 0x0402FB75 RID: 195445
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009400 RID: 37888
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAttributeCurrentValue_FunctionParams
	{
		// Token: 0x0402FB76 RID: 195446
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB77 RID: 195447
		[FieldOffset(4)]
		public int attributeId;

		// Token: 0x0402FB78 RID: 195448
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB79 RID: 195449
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009401 RID: 37889
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAttributeBaseValue_FunctionParams
	{
		// Token: 0x0402FB7A RID: 195450
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB7B RID: 195451
		[FieldOffset(4)]
		public int attributeId;

		// Token: 0x0402FB7C RID: 195452
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB7D RID: 195453
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009402 RID: 37890
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetRageModeId_FunctionParams
	{
		// Token: 0x0402FB7E RID: 195454
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB7F RID: 195455
		[FieldOffset(4)]
		public int id;

		// Token: 0x0402FB80 RID: 195456
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009403 RID: 37891
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetHardnessModeId_FunctionParams
	{
		// Token: 0x0402FB81 RID: 195457
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB82 RID: 195458
		[FieldOffset(4)]
		public int id;

		// Token: 0x0402FB83 RID: 195459
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009404 RID: 37892
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 2288)]
	protected ref struct __OnHit_FunctionParams
	{
		// Token: 0x0402FB84 RID: 195460
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB85 RID: 195461
		[FieldOffset(8)]
		public byte hitData;

		// Token: 0x0402FB86 RID: 195462
		[FieldOffset(2280)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009405 RID: 37893
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetBeHitIgnoreRotate_FunctionParams
	{
		// Token: 0x0402FB87 RID: 195463
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB88 RID: 195464
		[FieldOffset(4)]
		public bool ignoreRotate;

		// Token: 0x0402FB89 RID: 195465
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009406 RID: 37894
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CheckHasPart_FunctionParams
	{
		// Token: 0x0402FB8A RID: 195466
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB8B RID: 195467
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB8C RID: 195468
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009407 RID: 37895
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetPartRemainedLife_FunctionParams
	{
		// Token: 0x0402FB8D RID: 195469
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB8E RID: 195470
		[FieldOffset(4)]
		public FGameplayTag tag;

		// Token: 0x0402FB8F RID: 195471
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB90 RID: 195472
		[FieldOffset(24)]
		public float __Result;
	}

	// Token: 0x02009408 RID: 37896
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ResetPartLife_FunctionParams
	{
		// Token: 0x0402FB91 RID: 195473
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB92 RID: 195474
		[FieldOffset(4)]
		public FGameplayTag tag;

		// Token: 0x0402FB93 RID: 195475
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009409 RID: 37897
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ActiveStiff_FunctionParams
	{
		// Token: 0x0402FB94 RID: 195476
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB95 RID: 195477
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200940A RID: 37898
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DeActiveStiff_FunctionParams
	{
		// Token: 0x0402FB96 RID: 195478
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB97 RID: 195479
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200940B RID: 37899
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAcceptedNewBeHitAndReset_FunctionParams
	{
		// Token: 0x0402FB98 RID: 195480
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB99 RID: 195481
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB9A RID: 195482
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200940C RID: 37900
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetEnterFkAndReset_FunctionParams
	{
		// Token: 0x0402FB9B RID: 195483
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB9C RID: 195484
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FB9D RID: 195485
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200940D RID: 37901
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsStiff_FunctionParams
	{
		// Token: 0x0402FB9E RID: 195486
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FB9F RID: 195487
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBA0 RID: 195488
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200940E RID: 37902
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetRageModeId_FunctionParams
	{
		// Token: 0x0402FBA1 RID: 195489
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBA2 RID: 195490
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBA3 RID: 195491
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x0200940F RID: 37903
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHardnessModeId_FunctionParams
	{
		// Token: 0x0402FBA4 RID: 195492
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBA5 RID: 195493
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBA6 RID: 195494
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009410 RID: 37904
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBeHitBone_FunctionParams
	{
		// Token: 0x0402FBA7 RID: 195495
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBA8 RID: 195496
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBA9 RID: 195497
		[FieldOffset(16)]
		public FName __Result;
	}

	// Token: 0x02009411 RID: 37905
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetToughDecreaseValue_FunctionParams
	{
		// Token: 0x0402FBAA RID: 195498
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBAB RID: 195499
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBAC RID: 195500
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009412 RID: 37906
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1168)]
	protected ref struct __GetCounterAttackInfoInternal_FunctionParams
	{
		// Token: 0x0402FBAD RID: 195501
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBAE RID: 195502
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBAF RID: 195503
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x02009413 RID: 37907
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 568)]
	protected ref struct __GetVisionCounterAttackInfoInternal_FunctionParams
	{
		// Token: 0x0402FBB0 RID: 195504
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBB1 RID: 195505
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBB2 RID: 195506
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x02009414 RID: 37908
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBeHitTime_FunctionParams
	{
		// Token: 0x0402FBB3 RID: 195507
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBB4 RID: 195508
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBB5 RID: 195509
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009415 RID: 37909
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBeHitAnim_FunctionParams
	{
		// Token: 0x0402FBB6 RID: 195510
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBB7 RID: 195511
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBB8 RID: 195512
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x02009416 RID: 37910
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetEnterFk_FunctionParams
	{
		// Token: 0x0402FBB9 RID: 195513
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBBA RID: 195514
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBBB RID: 195515
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009417 RID: 37911
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetBeHitDirect_FunctionParams
	{
		// Token: 0x0402FBBC RID: 195516
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBBD RID: 195517
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBBE RID: 195518
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x02009418 RID: 37912
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetBeHitLocation_FunctionParams
	{
		// Token: 0x0402FBBF RID: 195519
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBC0 RID: 195520
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBC1 RID: 195521
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x02009419 RID: 37913
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __AddCheckBuffList_FunctionParams
	{
		// Token: 0x0402FBC2 RID: 195522
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBC3 RID: 195523
		[FieldOffset(8)]
		public SCounterAttackBuff addValue;

		// Token: 0x0402FBC4 RID: 195524
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200941A RID: 37914
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ClearCheckBuffList_FunctionParams
	{
		// Token: 0x0402FBC5 RID: 195525
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBC6 RID: 195526
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200941B RID: 37915
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __CounterAttackEnd_FunctionParams
	{
		// Token: 0x0402FBC7 RID: 195527
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBC8 RID: 195528
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200941C RID: 37916
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __VisionCounterAttackEnd_FunctionParams
	{
		// Token: 0x0402FBC9 RID: 195529
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBCA RID: 195530
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200941D RID: 37917
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCounterAttackEndTime_FunctionParams
	{
		// Token: 0x0402FBCB RID: 195531
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBCC RID: 195532
		[FieldOffset(4)]
		public float baseTime;

		// Token: 0x0402FBCD RID: 195533
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200941E RID: 37918
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsTriggerCounterAttack_FunctionParams
	{
		// Token: 0x0402FBCE RID: 195534
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBCF RID: 195535
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBD0 RID: 195536
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200941F RID: 37919
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ResetTarget_FunctionParams
	{
		// Token: 0x0402FBD1 RID: 195537
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBD2 RID: 195538
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009420 RID: 37920
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetShowTarget_FunctionParams
	{
		// Token: 0x0402FBD3 RID: 195539
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBD4 RID: 195540
		[FieldOffset(8)]
		public IntPtr actor;

		// Token: 0x0402FBD5 RID: 195541
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009421 RID: 37921
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ExitLockDirection_FunctionParams
	{
		// Token: 0x0402FBD6 RID: 195542
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBD7 RID: 195543
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009422 RID: 37922
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnterLockDirection_FunctionParams
	{
		// Token: 0x0402FBD8 RID: 195544
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBD9 RID: 195545
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009423 RID: 37923
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCurrentTarget_FunctionParams
	{
		// Token: 0x0402FBDA RID: 195546
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBDB RID: 195547
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBDC RID: 195548
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02009424 RID: 37924
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetLockOnDebugLine_FunctionParams
	{
		// Token: 0x0402FBDD RID: 195549
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBDE RID: 195550
		[FieldOffset(4)]
		public bool isShow;

		// Token: 0x0402FBDF RID: 195551
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009425 RID: 37925
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ManipulateValid_FunctionParams
	{
		// Token: 0x0402FBE0 RID: 195552
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBE1 RID: 195553
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBE2 RID: 195554
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009426 RID: 37926
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ManipulateGetDrawTarget_FunctionParams
	{
		// Token: 0x0402FBE3 RID: 195555
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBE4 RID: 195556
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBE5 RID: 195557
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02009427 RID: 37927
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ManipulateGetCastTarget_FunctionParams
	{
		// Token: 0x0402FBE6 RID: 195558
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBE7 RID: 195559
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBE8 RID: 195560
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02009428 RID: 37928
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ManipulateGetDrawTargetChantTime_FunctionParams
	{
		// Token: 0x0402FBE9 RID: 195561
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBEA RID: 195562
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBEB RID: 195563
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009429 RID: 37929
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ManipulateChant_FunctionParams
	{
		// Token: 0x0402FBEC RID: 195564
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBED RID: 195565
		[FieldOffset(8)]
		public IntPtr eventBinder;

		// Token: 0x0402FBEE RID: 195566
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBEF RID: 195567
		[FieldOffset(24)]
		public bool __Result;
	}

	// Token: 0x0200942A RID: 37930
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ManipulateDraw_FunctionParams
	{
		// Token: 0x0402FBF0 RID: 195568
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBF1 RID: 195569
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBF2 RID: 195570
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200942B RID: 37931
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ManipulateCast_FunctionParams
	{
		// Token: 0x0402FBF3 RID: 195571
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBF4 RID: 195572
		[FieldOffset(4)]
		public float direction;

		// Token: 0x0402FBF5 RID: 195573
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBF6 RID: 195574
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200942C RID: 37932
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ManipulateReset_FunctionParams
	{
		// Token: 0x0402FBF7 RID: 195575
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBF8 RID: 195576
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200942D RID: 37933
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ManipulateChangeToProjectileState_FunctionParams
	{
		// Token: 0x0402FBF9 RID: 195577
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBFA RID: 195578
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBFB RID: 195579
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200942E RID: 37934
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ManipulateChangeToNormalState_FunctionParams
	{
		// Token: 0x0402FBFC RID: 195580
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FBFD RID: 195581
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FBFE RID: 195582
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200942F RID: 37935
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHoldingActor_FunctionParams
	{
		// Token: 0x0402FBFF RID: 195583
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC00 RID: 195584
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC01 RID: 195585
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02009430 RID: 37936
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __HasHoldingActor_FunctionParams
	{
		// Token: 0x0402FC02 RID: 195586
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC03 RID: 195587
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC04 RID: 195588
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009431 RID: 37937
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDebugDraw_FunctionParams
	{
		// Token: 0x0402FC05 RID: 195589
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC06 RID: 195590
		[FieldOffset(4)]
		public bool isActive;

		// Token: 0x0402FC07 RID: 195591
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009432 RID: 37938
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ExtraAction_FunctionParams
	{
		// Token: 0x0402FC08 RID: 195592
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC09 RID: 195593
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009433 RID: 37939
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetQtePosition_FunctionParams
	{
		// Token: 0x0402FC0A RID: 195594
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC0B RID: 195595
		[FieldOffset(4)]
		public float rotate;

		// Token: 0x0402FC0C RID: 195596
		[FieldOffset(8)]
		public float length;

		// Token: 0x0402FC0D RID: 195597
		[FieldOffset(12)]
		public float height;

		// Token: 0x0402FC0E RID: 195598
		[FieldOffset(16)]
		public bool referenceTarget;

		// Token: 0x0402FC0F RID: 195599
		[FieldOffset(17)]
		public bool adjustWithMonster;

		// Token: 0x0402FC10 RID: 195600
		[FieldOffset(20)]
		public float addHeight;

		// Token: 0x0402FC11 RID: 195601
		[FieldOffset(24)]
		public int qteType;

		// Token: 0x0402FC12 RID: 195602
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009434 RID: 37940
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetGoBattleActor_FunctionParams
	{
		// Token: 0x0402FC13 RID: 195603
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC14 RID: 195604
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC15 RID: 195605
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02009435 RID: 37941
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetDtSkillInfo_FunctionParams
	{
		// Token: 0x0402FC16 RID: 195606
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC17 RID: 195607
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC18 RID: 195608
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02009436 RID: 37942
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __GetDtSkillInfoMapForDebug_FunctionParams
	{
		// Token: 0x0402FC19 RID: 195609
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC1A RID: 195610
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC1B RID: 195611
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x02009437 RID: 37943
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetLastActivateSkillTime_FunctionParams
	{
		// Token: 0x0402FC1C RID: 195612
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC1D RID: 195613
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC1E RID: 195614
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009438 RID: 37944
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetLastActivateSkillTime_FunctionParams
	{
		// Token: 0x0402FC1F RID: 195615
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC20 RID: 195616
		[FieldOffset(4)]
		public float time;

		// Token: 0x0402FC21 RID: 195617
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009439 RID: 37945
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetSkillElevationAngle_FunctionParams
	{
		// Token: 0x0402FC22 RID: 195618
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC23 RID: 195619
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC24 RID: 195620
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x0200943A RID: 37946
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetSkillElevationAngle_FunctionParams
	{
		// Token: 0x0402FC25 RID: 195621
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC26 RID: 195622
		[FieldOffset(4)]
		public float angle;

		// Token: 0x0402FC27 RID: 195623
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200943B RID: 37947
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __CurrentSkillId_FunctionParams
	{
		// Token: 0x0402FC28 RID: 195624
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC29 RID: 195625
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC2A RID: 195626
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x0200943C RID: 37948
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CurrentPriority_FunctionParams
	{
		// Token: 0x0402FC2B RID: 195627
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC2C RID: 195628
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC2D RID: 195629
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x0200943D RID: 37949
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCurrentPriority_FunctionParams
	{
		// Token: 0x0402FC2E RID: 195630
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC2F RID: 195631
		[FieldOffset(4)]
		public int priority;

		// Token: 0x0402FC30 RID: 195632
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200943E RID: 37950
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __HasAbility_FunctionParams
	{
		// Token: 0x0402FC31 RID: 195633
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC32 RID: 195634
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402FC33 RID: 195635
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC34 RID: 195636
		[FieldOffset(32)]
		public bool __Result;
	}

	// Token: 0x0200943F RID: 37951
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 520)]
	protected ref struct __GetSkillInfo_FunctionParams
	{
		// Token: 0x0402FC35 RID: 195637
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC36 RID: 195638
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402FC37 RID: 195639
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC38 RID: 195640
		[FieldOffset(32)]
		public byte __Result;
	}

	// Token: 0x02009440 RID: 37952
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetSkillPriority_FunctionParams
	{
		// Token: 0x0402FC39 RID: 195641
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC3A RID: 195642
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402FC3B RID: 195643
		[FieldOffset(24)]
		public float priority;

		// Token: 0x0402FC3C RID: 195644
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009441 RID: 37953
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __EndSkill_FunctionParams
	{
		// Token: 0x0402FC3D RID: 195645
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC3E RID: 195646
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402FC3F RID: 195647
		[FieldOffset(24)]
		public bool isSyn;

		// Token: 0x0402FC40 RID: 195648
		[FieldOffset(25)]
		public bool isNotEnd;

		// Token: 0x0402FC41 RID: 195649
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009442 RID: 37954
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __BeginSkill_FunctionParams
	{
		// Token: 0x0402FC42 RID: 195650
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC43 RID: 195651
		[FieldOffset(4)]
		public FName skillId;

		// Token: 0x0402FC44 RID: 195652
		[FieldOffset(16)]
		public bool isSyn;

		// Token: 0x0402FC45 RID: 195653
		[FieldOffset(24)]
		public IntPtr target;

		// Token: 0x0402FC46 RID: 195654
		[FieldOffset(32)]
		public FName socketName;

		// Token: 0x0402FC47 RID: 195655
		[FieldOffset(48)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC48 RID: 195656
		[FieldOffset(56)]
		public bool __Result;
	}

	// Token: 0x02009443 RID: 37955
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __BeginSkillAsync_FunctionParams
	{
		// Token: 0x0402FC49 RID: 195657
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC4A RID: 195658
		[FieldOffset(4)]
		public FName skillId;

		// Token: 0x0402FC4B RID: 195659
		[FieldOffset(16)]
		public IntPtr target;

		// Token: 0x0402FC4C RID: 195660
		[FieldOffset(24)]
		public FName socketName;

		// Token: 0x0402FC4D RID: 195661
		[FieldOffset(40)]
		public IntPtr eventBinder;

		// Token: 0x0402FC4E RID: 195662
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009444 RID: 37956
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 864)]
	protected ref struct __SkillBehaviorBegin_FunctionParams
	{
		// Token: 0x0402FC4F RID: 195663
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC50 RID: 195664
		[FieldOffset(8)]
		public IntPtr ga;

		// Token: 0x0402FC51 RID: 195665
		[FieldOffset(16)]
		public byte action;

		// Token: 0x0402FC52 RID: 195666
		[FieldOffset(856)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009445 RID: 37957
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 888)]
	protected ref struct __GetLocationByAction_FunctionParams
	{
		// Token: 0x0402FC53 RID: 195667
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC54 RID: 195668
		[FieldOffset(8)]
		public IntPtr ga;

		// Token: 0x0402FC55 RID: 195669
		[FieldOffset(16)]
		public byte action;

		// Token: 0x0402FC56 RID: 195670
		[FieldOffset(856)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC57 RID: 195671
		[FieldOffset(864)]
		public FVectorDouble __Result;
	}

	// Token: 0x02009446 RID: 37958
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 880)]
	protected ref struct __GetRotationByAction_FunctionParams
	{
		// Token: 0x0402FC58 RID: 195672
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC59 RID: 195673
		[FieldOffset(8)]
		public IntPtr ga;

		// Token: 0x0402FC5A RID: 195674
		[FieldOffset(16)]
		public byte action;

		// Token: 0x0402FC5B RID: 195675
		[FieldOffset(856)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC5C RID: 195676
		[FieldOffset(864)]
		public FRotator __Result;
	}

	// Token: 0x02009447 RID: 37959
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 104)]
	protected ref struct __SkillBehaviorSatisfy_FunctionParams
	{
		// Token: 0x0402FC5D RID: 195677
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC5E RID: 195678
		[FieldOffset(8)]
		public IntPtr ga;

		// Token: 0x0402FC5F RID: 195679
		[FieldOffset(16)]
		public byte condition;

		// Token: 0x0402FC60 RID: 195680
		[FieldOffset(88)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC61 RID: 195681
		[FieldOffset(96)]
		public bool __Result;
	}

	// Token: 0x02009448 RID: 37960
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetSkillTarget_FunctionParams
	{
		// Token: 0x0402FC62 RID: 195682
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC63 RID: 195683
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC64 RID: 195684
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02009449 RID: 37961
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetSkillTarget_FunctionParams
	{
		// Token: 0x0402FC65 RID: 195685
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC66 RID: 195686
		[FieldOffset(8)]
		public IntPtr target;

		// Token: 0x0402FC67 RID: 195687
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200944A RID: 37962
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __LockOnTargetAndSetShow_FunctionParams
	{
		// Token: 0x0402FC68 RID: 195688
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC69 RID: 195689
		[FieldOffset(8)]
		public byte config;

		// Token: 0x0402FC6A RID: 195690
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200944B RID: 37963
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsHasInputDir_FunctionParams
	{
		// Token: 0x0402FC6B RID: 195691
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC6C RID: 195692
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC6D RID: 195693
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200944C RID: 37964
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetSkillIdWithGroupId_FunctionParams
	{
		// Token: 0x0402FC6E RID: 195694
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC6F RID: 195695
		[FieldOffset(4)]
		public int groupId;

		// Token: 0x0402FC70 RID: 195696
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC71 RID: 195697
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x0200944D RID: 37965
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetSkillAcceptInput_FunctionParams
	{
		// Token: 0x0402FC72 RID: 195698
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC73 RID: 195699
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC74 RID: 195700
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200944E RID: 37966
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetSkillAcceptInput_FunctionParams
	{
		// Token: 0x0402FC75 RID: 195701
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC76 RID: 195702
		[FieldOffset(4)]
		public bool skillAcceptInput;

		// Token: 0x0402FC77 RID: 195703
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200944F RID: 37967
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCommonSkillCanBeInterrupt_FunctionParams
	{
		// Token: 0x0402FC78 RID: 195704
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC79 RID: 195705
		[FieldOffset(4)]
		public bool canBeInterrupt;

		// Token: 0x0402FC7A RID: 195706
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009450 RID: 37968
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCommonSkillCanBeInterrupt_FunctionParams
	{
		// Token: 0x0402FC7B RID: 195707
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC7C RID: 195708
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC7D RID: 195709
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009451 RID: 37969
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __OnActivateAbility_FunctionParams
	{
		// Token: 0x0402FC7E RID: 195710
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC7F RID: 195711
		[FieldOffset(8)]
		public IntPtr ga;

		// Token: 0x0402FC80 RID: 195712
		[FieldOffset(16)]
		public bool isCommitSuccess;

		// Token: 0x0402FC81 RID: 195713
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC82 RID: 195714
		[FieldOffset(32)]
		public float __Result;
	}

	// Token: 0x02009452 RID: 37970
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __OnEndAbility_FunctionParams
	{
		// Token: 0x0402FC83 RID: 195715
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC84 RID: 195716
		[FieldOffset(8)]
		public IntPtr ga;

		// Token: 0x0402FC85 RID: 195717
		[FieldOffset(16)]
		public bool wasCancelled;

		// Token: 0x0402FC86 RID: 195718
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009453 RID: 37971
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetPriority_FunctionParams
	{
		// Token: 0x0402FC87 RID: 195719
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC88 RID: 195720
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402FC89 RID: 195721
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC8A RID: 195722
		[FieldOffset(32)]
		public float __Result;
	}

	// Token: 0x02009454 RID: 37972
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetActivePriority_FunctionParams
	{
		// Token: 0x0402FC8B RID: 195723
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC8C RID: 195724
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402FC8D RID: 195725
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC8E RID: 195726
		[FieldOffset(32)]
		public float __Result;
	}

	// Token: 0x02009455 RID: 37973
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetSkillMontageInstance_FunctionParams
	{
		// Token: 0x0402FC8F RID: 195727
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC90 RID: 195728
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402FC91 RID: 195729
		[FieldOffset(24)]
		public int index;

		// Token: 0x0402FC92 RID: 195730
		[FieldOffset(32)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC93 RID: 195731
		[FieldOffset(40)]
		public IntPtr __Result;
	}

	// Token: 0x02009456 RID: 37974
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetSkillNeedPlayMontageIndex_FunctionParams
	{
		// Token: 0x0402FC94 RID: 195732
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FC95 RID: 195733
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402FC96 RID: 195734
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402FC97 RID: 195735
		[FieldOffset(32)]
		public int __Result;
	}

	// Token: 0x02009457 RID: 37975
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __CreateSpecifiedTagPlayMontageAndWaitAbilityTask_FunctionParams
	{
		// Token: 0x0402FC98 RID: 195736
		[FieldOffset(0)]
		public IntPtr gameplayAbility;

		// Token: 0x0402FC99 RID: 195737
		[FieldOffset(8)]
		public bool checkHit;

		// Token: 0x0402FC9A RID: 195738
		[FieldOffset(12)]
		public FGameplayTag skeletalMeshComponentTag;

		// Token: 0x0402FC9B RID: 195739
		[FieldOffset(24)]
		public int montageIndex;

		// Token: 0x0402FC9C RID: 195740
		[FieldOffset(28)]
		public FName startSection;

		// Token: 0x0402FC9D RID: 195741
		[FieldOffset(40)]
		public float startTimeSeconds;

		// Token: 0x0402FC9E RID: 195742
		[FieldOffset(44)]
		public bool needTick;

		// Token: 0x0402FC9F RID: 195743
		[FieldOffset(48)]
		public float animRootMotionTranslationScale;

		// Token: 0x0402FCA0 RID: 195744
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009458 RID: 37976
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetSkillRotateLocation_FunctionParams
	{
		// Token: 0x0402FCA1 RID: 195745
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCA2 RID: 195746
		[FieldOffset(8)]
		public FVectorDouble location;

		// Token: 0x0402FCA3 RID: 195747
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009459 RID: 37977
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetSkillRotateDirect_FunctionParams
	{
		// Token: 0x0402FCA4 RID: 195748
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCA5 RID: 195749
		[FieldOffset(8)]
		public FVectorDouble direct;

		// Token: 0x0402FCA6 RID: 195750
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200945A RID: 37978
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __CallAnimBreakPoint_FunctionParams
	{
		// Token: 0x0402FCA7 RID: 195751
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCA8 RID: 195752
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200945B RID: 37979
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __RollingGround_FunctionParams
	{
		// Token: 0x0402FCA9 RID: 195753
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCAA RID: 195754
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200945C RID: 37980
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ActivateAbilityVision_FunctionParams
	{
		// Token: 0x0402FCAB RID: 195755
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCAC RID: 195756
		[FieldOffset(4)]
		public byte visionType;

		// Token: 0x0402FCAD RID: 195757
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FCAE RID: 195758
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200945D RID: 37981
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __EndAbilityVision_FunctionParams
	{
		// Token: 0x0402FCAF RID: 195759
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCB0 RID: 195760
		[FieldOffset(4)]
		public byte visionType;

		// Token: 0x0402FCB1 RID: 195761
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FCB2 RID: 195762
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200945E RID: 37982
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ActivateAbilityVisionPlayAudio_FunctionParams
	{
		// Token: 0x0402FCB3 RID: 195763
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCB4 RID: 195764
		[FieldOffset(4)]
		public byte visionType;

		// Token: 0x0402FCB5 RID: 195765
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200945F RID: 37983
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetVisionIdList_FunctionParams
	{
		// Token: 0x0402FCB6 RID: 195766
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCB7 RID: 195767
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FCB8 RID: 195768
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x02009460 RID: 37984
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ExitMultiSkillStateOfMorphVision_FunctionParams
	{
		// Token: 0x0402FCB9 RID: 195769
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCBA RID: 195770
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009461 RID: 37985
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetKeepMultiSkillState_FunctionParams
	{
		// Token: 0x0402FCBB RID: 195771
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCBC RID: 195772
		[FieldOffset(4)]
		public bool keepOnMorphEnd;

		// Token: 0x0402FCBD RID: 195773
		[FieldOffset(5)]
		public bool keepOnGoDown;

		// Token: 0x0402FCBE RID: 195774
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009462 RID: 37986
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEnableAttackInputActionOfMorphVision_FunctionParams
	{
		// Token: 0x0402FCBF RID: 195775
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCC0 RID: 195776
		[FieldOffset(4)]
		public bool bEnable;

		// Token: 0x0402FCC1 RID: 195777
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009463 RID: 37987
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetVisionLevelList_FunctionParams
	{
		// Token: 0x0402FCC2 RID: 195778
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCC3 RID: 195779
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FCC4 RID: 195780
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x02009464 RID: 37988
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetVisionSkillId_FunctionParams
	{
		// Token: 0x0402FCC5 RID: 195781
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCC6 RID: 195782
		[FieldOffset(4)]
		public float visionId;

		// Token: 0x0402FCC7 RID: 195783
		[FieldOffset(8)]
		public float level;

		// Token: 0x0402FCC8 RID: 195784
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402FCC9 RID: 195785
		[FieldOffset(24)]
		public int __Result;
	}

	// Token: 0x02009465 RID: 37989
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __InterruptSkill_FunctionParams
	{
		// Token: 0x0402FCCA RID: 195786
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCCB RID: 195787
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402FCCC RID: 195788
		[FieldOffset(24)]
		public bool isSyn;

		// Token: 0x0402FCCD RID: 195789
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009466 RID: 37990
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DeleteSkills_FunctionParams
	{
		// Token: 0x0402FCCE RID: 195790
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCCF RID: 195791
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009467 RID: 37991
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetCurrentMontageCorrespondingSkillId_FunctionParams
	{
		// Token: 0x0402FCD0 RID: 195792
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCD1 RID: 195793
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FCD2 RID: 195794
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02009468 RID: 37992
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetSocketName_FunctionParams
	{
		// Token: 0x0402FCD3 RID: 195795
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCD4 RID: 195796
		[FieldOffset(8)]
		public FString socketName;

		// Token: 0x0402FCD5 RID: 195797
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009469 RID: 37993
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetSocketName_FunctionParams
	{
		// Token: 0x0402FCD6 RID: 195798
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCD7 RID: 195799
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FCD8 RID: 195800
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x0200946A RID: 37994
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __GetPointTransform_FunctionParams
	{
		// Token: 0x0402FCD9 RID: 195801
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCDA RID: 195802
		[FieldOffset(8)]
		public FString boneName;

		// Token: 0x0402FCDB RID: 195803
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402FCDC RID: 195804
		[FieldOffset(32)]
		public FTransformDouble __Result;
	}

	// Token: 0x0200946B RID: 37995
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __PlaySkillMontage2Server_FunctionParams
	{
		// Token: 0x0402FCDD RID: 195805
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCDE RID: 195806
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402FCDF RID: 195807
		[FieldOffset(24)]
		public float montageIndex;

		// Token: 0x0402FCE0 RID: 195808
		[FieldOffset(28)]
		public float rate;

		// Token: 0x0402FCE1 RID: 195809
		[FieldOffset(32)]
		public FString startSection;

		// Token: 0x0402FCE2 RID: 195810
		[FieldOffset(48)]
		public float startTimeSeconds;

		// Token: 0x0402FCE3 RID: 195811
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200946C RID: 37996
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __EndSkillMontage_FunctionParams
	{
		// Token: 0x0402FCE4 RID: 195812
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCE5 RID: 195813
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402FCE6 RID: 195814
		[FieldOffset(24)]
		public float montageIndex;

		// Token: 0x0402FCE7 RID: 195815
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200946D RID: 37997
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __BeginAddMoveByInputDirect_FunctionParams
	{
		// Token: 0x0402FCE8 RID: 195816
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCE9 RID: 195817
		[FieldOffset(4)]
		public float maxSpeed;

		// Token: 0x0402FCEA RID: 195818
		[FieldOffset(8)]
		public float accelerationTime;

		// Token: 0x0402FCEB RID: 195819
		[FieldOffset(12)]
		public float decelerationTime;

		// Token: 0x0402FCEC RID: 195820
		[FieldOffset(16)]
		public float delayTime;

		// Token: 0x0402FCED RID: 195821
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200946E RID: 37998
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __BeginAbsoluteTimeStop_FunctionParams
	{
		// Token: 0x0402FCEE RID: 195822
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCEF RID: 195823
		[FieldOffset(4)]
		public float duration;

		// Token: 0x0402FCF0 RID: 195824
		[FieldOffset(8)]
		public bool stopMove;

		// Token: 0x0402FCF1 RID: 195825
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200946F RID: 37999
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EndAbsoluteTimeStop_FunctionParams
	{
		// Token: 0x0402FCF2 RID: 195826
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCF3 RID: 195827
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009470 RID: 38000
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __BeginTimeStopRequest_FunctionParams
	{
		// Token: 0x0402FCF4 RID: 195828
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCF5 RID: 195829
		[FieldOffset(4)]
		public float duration;

		// Token: 0x0402FCF6 RID: 195830
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009471 RID: 38001
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EndTimeStopRequest_FunctionParams
	{
		// Token: 0x0402FCF7 RID: 195831
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCF8 RID: 195832
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009472 RID: 38002
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EndAddMoveByInputDirect_FunctionParams
	{
		// Token: 0x0402FCF9 RID: 195833
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCFA RID: 195834
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009473 RID: 38003
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CanActivateFixHook_FunctionParams
	{
		// Token: 0x0402FCFB RID: 195835
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCFC RID: 195836
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FCFD RID: 195837
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009474 RID: 38004
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __FixHookTargetLocation_FunctionParams
	{
		// Token: 0x0402FCFE RID: 195838
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FCFF RID: 195839
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD00 RID: 195840
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x02009475 RID: 38005
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __FixHookTargetPathways_FunctionParams
	{
		// Token: 0x0402FD01 RID: 195841
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD02 RID: 195842
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD03 RID: 195843
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x02009476 RID: 38006
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FixHookTargetEnterPortalCapture_FunctionParams
	{
		// Token: 0x0402FD04 RID: 195844
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD05 RID: 195845
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD06 RID: 195846
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02009477 RID: 38007
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FixHookTargetActor_FunctionParams
	{
		// Token: 0x0402FD07 RID: 195847
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD08 RID: 195848
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD09 RID: 195849
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02009478 RID: 38008
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FixHookTargetIsSuiGuangType_FunctionParams
	{
		// Token: 0x0402FD0A RID: 195850
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD0B RID: 195851
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD0C RID: 195852
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009479 RID: 38009
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHookTargetType_FunctionParams
	{
		// Token: 0x0402FD0D RID: 195853
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD0E RID: 195854
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD0F RID: 195855
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x0200947A RID: 38010
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __FixHookTargetForward_FunctionParams
	{
		// Token: 0x0402FD10 RID: 195856
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD11 RID: 195857
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD12 RID: 195858
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x0200947B RID: 38011
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __NextFixHookTargetLocation_FunctionParams
	{
		// Token: 0x0402FD13 RID: 195859
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD14 RID: 195860
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD15 RID: 195861
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x0200947C RID: 38012
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FixHookTargetInheritSpeed_FunctionParams
	{
		// Token: 0x0402FD16 RID: 195862
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD17 RID: 195863
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD18 RID: 195864
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200947D RID: 38013
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FixHookTargetIsClimb_FunctionParams
	{
		// Token: 0x0402FD19 RID: 195865
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD1A RID: 195866
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD1B RID: 195867
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200947E RID: 38014
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetIsHookEndByInterrupt_FunctionParams
	{
		// Token: 0x0402FD1C RID: 195868
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD1D RID: 195869
		[FieldOffset(4)]
		public bool isInterrupt;

		// Token: 0x0402FD1E RID: 195870
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200947F RID: 38015
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FixHookIsSummitPoint_FunctionParams
	{
		// Token: 0x0402FD1F RID: 195871
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD20 RID: 195872
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD21 RID: 195873
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009480 RID: 38016
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FixHookIsNormalPoint_FunctionParams
	{
		// Token: 0x0402FD22 RID: 195874
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD23 RID: 195875
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD24 RID: 195876
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009481 RID: 38017
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHookOverrideSpeed_FunctionParams
	{
		// Token: 0x0402FD25 RID: 195877
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD26 RID: 195878
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD27 RID: 195879
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x02009482 RID: 38018
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FixHookIsGravityPoint_FunctionParams
	{
		// Token: 0x0402FD28 RID: 195880
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD29 RID: 195881
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD2A RID: 195882
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009483 RID: 38019
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __KiteHookSupportSwitchMidway_FunctionParams
	{
		// Token: 0x0402FD2B RID: 195883
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD2C RID: 195884
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD2D RID: 195885
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009484 RID: 38020
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FixHookTargetEntityId_FunctionParams
	{
		// Token: 0x0402FD2E RID: 195886
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD2F RID: 195887
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD30 RID: 195888
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x02009485 RID: 38021
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SlashHookPointHasLookAtConfig_FunctionParams
	{
		// Token: 0x0402FD31 RID: 195889
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD32 RID: 195890
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD33 RID: 195891
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009486 RID: 38022
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SlashHookPointCharacterLookAtPoint_FunctionParams
	{
		// Token: 0x0402FD34 RID: 195892
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD35 RID: 195893
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD36 RID: 195894
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x02009487 RID: 38023
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SlashHookPointIsTakeOverCamera_FunctionParams
	{
		// Token: 0x0402FD37 RID: 195895
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD38 RID: 195896
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD39 RID: 195897
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009488 RID: 38024
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SlashHookPointSafePointLoc_FunctionParams
	{
		// Token: 0x0402FD3A RID: 195898
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD3B RID: 195899
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD3C RID: 195900
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x02009489 RID: 38025
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SlashHookPointSafePointRot_FunctionParams
	{
		// Token: 0x0402FD3D RID: 195901
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD3E RID: 195902
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD3F RID: 195903
		[FieldOffset(16)]
		public FRotator __Result;
	}

	// Token: 0x0200948A RID: 38026
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __StartChargeSlash_FunctionParams
	{
		// Token: 0x0402FD40 RID: 195904
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD41 RID: 195905
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200948B RID: 38027
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __StopChargeSlash_FunctionParams
	{
		// Token: 0x0402FD42 RID: 195906
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD43 RID: 195907
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200948C RID: 38028
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsSlashGameplayIsSuccess_FunctionParams
	{
		// Token: 0x0402FD44 RID: 195908
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD45 RID: 195909
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x0200948D RID: 38029
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetGravityHookLockInfo_FunctionParams
	{
		// Token: 0x0402FD46 RID: 195910
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD47 RID: 195911
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD48 RID: 195912
		[FieldOffset(16)]
		public SGravityHookLockInfo __Result;
	}

	// Token: 0x0200948E RID: 38030
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ChangeGravityByHook_FunctionParams
	{
		// Token: 0x0402FD49 RID: 195913
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD4A RID: 195914
		[FieldOffset(4)]
		public int angleRangeMin;

		// Token: 0x0402FD4B RID: 195915
		[FieldOffset(8)]
		public int angleRangeMax;

		// Token: 0x0402FD4C RID: 195916
		[FieldOffset(12)]
		public float smoothSecondMin;

		// Token: 0x0402FD4D RID: 195917
		[FieldOffset(16)]
		public float smoothSecondMax;

		// Token: 0x0402FD4E RID: 195918
		[FieldOffset(20)]
		public bool isLerpCamera;

		// Token: 0x0402FD4F RID: 195919
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200948F RID: 38031
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetIgnoreSocketName_FunctionParams
	{
		// Token: 0x0402FD50 RID: 195920
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD51 RID: 195921
		[FieldOffset(8)]
		public FString socketName;

		// Token: 0x0402FD52 RID: 195922
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009490 RID: 38032
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __DeleteIgnoreSocketName_FunctionParams
	{
		// Token: 0x0402FD53 RID: 195923
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD54 RID: 195924
		[FieldOffset(8)]
		public FString socketName;

		// Token: 0x0402FD55 RID: 195925
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009491 RID: 38033
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetToTargetSocketDistance_FunctionParams
	{
		// Token: 0x0402FD56 RID: 195926
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD57 RID: 195927
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD58 RID: 195928
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02009492 RID: 38034
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 192)]
	protected ref struct __SetPredictProjectileInfo_FunctionParams
	{
		// Token: 0x0402FD59 RID: 195929
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD5A RID: 195930
		[FieldOffset(4)]
		public bool returnValue;

		// Token: 0x0402FD5B RID: 195931
		[FieldOffset(8)]
		public byte outPathPosition;

		// Token: 0x0402FD5C RID: 195932
		[FieldOffset(24)]
		public FVector outLastTraceDestination;

		// Token: 0x0402FD5D RID: 195933
		[FieldOffset(36)]
		public byte outHit;

		// Token: 0x0402FD5E RID: 195934
		[FieldOffset(184)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009493 RID: 38035
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetVisible_FunctionParams
	{
		// Token: 0x0402FD5F RID: 195935
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD60 RID: 195936
		[FieldOffset(4)]
		public bool isShow;

		// Token: 0x0402FD61 RID: 195937
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009494 RID: 38036
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCharUnifiedMoveState_FunctionParams
	{
		// Token: 0x0402FD62 RID: 195938
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD63 RID: 195939
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD64 RID: 195940
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x02009495 RID: 38037
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCharUnifiedPositionState_FunctionParams
	{
		// Token: 0x0402FD65 RID: 195941
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD66 RID: 195942
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD67 RID: 195943
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x02009496 RID: 38038
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ExitHitState_FunctionParams
	{
		// Token: 0x0402FD68 RID: 195944
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD69 RID: 195945
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009497 RID: 38039
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDirectionState_FunctionParams
	{
		// Token: 0x0402FD6A RID: 195946
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD6B RID: 195947
		[FieldOffset(4)]
		public byte newViewState;

		// Token: 0x0402FD6C RID: 195948
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009498 RID: 38040
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetDirectionState_FunctionParams
	{
		// Token: 0x0402FD6D RID: 195949
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD6E RID: 195950
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD6F RID: 195951
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x02009499 RID: 38041
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetIsInGame_FunctionParams
	{
		// Token: 0x0402FD70 RID: 195952
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD71 RID: 195953
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD72 RID: 195954
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200949A RID: 38042
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SprintPress_FunctionParams
	{
		// Token: 0x0402FD73 RID: 195955
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD74 RID: 195956
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200949B RID: 38043
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SprintRelease_FunctionParams
	{
		// Token: 0x0402FD75 RID: 195957
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD76 RID: 195958
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200949C RID: 38044
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __StandPress_FunctionParams
	{
		// Token: 0x0402FD77 RID: 195959
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD78 RID: 195960
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200949D RID: 38045
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SwingPress_FunctionParams
	{
		// Token: 0x0402FD79 RID: 195961
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD7A RID: 195962
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200949E RID: 38046
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SwingRelease_FunctionParams
	{
		// Token: 0x0402FD7B RID: 195963
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD7C RID: 195964
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200949F RID: 38047
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __CustomSetWalkOrRun_FunctionParams
	{
		// Token: 0x0402FD7D RID: 195965
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD7E RID: 195966
		[FieldOffset(4)]
		public bool isWalk;

		// Token: 0x0402FD7F RID: 195967
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094A0 RID: 38048
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnterAimStatus_FunctionParams
	{
		// Token: 0x0402FD80 RID: 195968
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD81 RID: 195969
		[FieldOffset(4)]
		public byte aimViewState;

		// Token: 0x0402FD82 RID: 195970
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094A1 RID: 38049
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ExitAimStatus_FunctionParams
	{
		// Token: 0x0402FD83 RID: 195971
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD84 RID: 195972
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094A2 RID: 38050
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnableEntity_FunctionParams
	{
		// Token: 0x0402FD85 RID: 195973
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD86 RID: 195974
		[FieldOffset(4)]
		public bool isEnable;

		// Token: 0x0402FD87 RID: 195975
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094A3 RID: 38051
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoHit_FunctionParams
	{
		// Token: 0x0402FD88 RID: 195976
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD89 RID: 195977
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x0402FD8A RID: 195978
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094A4 RID: 38052
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoFk_FunctionParams
	{
		// Token: 0x0402FD8B RID: 195979
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD8C RID: 195980
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x0402FD8D RID: 195981
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094A5 RID: 38053
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoUnifiedState_FunctionParams
	{
		// Token: 0x0402FD8E RID: 195982
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD8F RID: 195983
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x0402FD90 RID: 195984
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094A6 RID: 38054
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoUnifiedStateRoleNpc_FunctionParams
	{
		// Token: 0x0402FD91 RID: 195985
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD92 RID: 195986
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x0402FD93 RID: 195987
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094A7 RID: 38055
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetIsCharRotateWithCameraWhenManipulate_FunctionParams
	{
		// Token: 0x0402FD94 RID: 195988
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD95 RID: 195989
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD96 RID: 195990
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020094A8 RID: 38056
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetIsUseCatapultUpAnim_FunctionParams
	{
		// Token: 0x0402FD97 RID: 195991
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD98 RID: 195992
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD99 RID: 195993
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020094A9 RID: 38057
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetNextMultiSkillId_FunctionParams
	{
		// Token: 0x0402FD9A RID: 195994
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD9B RID: 195995
		[FieldOffset(4)]
		public int skillId;

		// Token: 0x0402FD9C RID: 195996
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FD9D RID: 195997
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020094AA RID: 38058
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetNextMultiSkillIdNew_FunctionParams
	{
		// Token: 0x0402FD9E RID: 195998
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FD9F RID: 195999
		[FieldOffset(4)]
		public int skillId;

		// Token: 0x0402FDA0 RID: 196000
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FDA1 RID: 196001
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x020094AB RID: 38059
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetManipulateInteractTargetCanInteract_FunctionParams
	{
		// Token: 0x0402FDA2 RID: 196002
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDA3 RID: 196003
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FDA4 RID: 196004
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020094AC RID: 38060
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHookInteractTargetCanInteract_FunctionParams
	{
		// Token: 0x0402FDA5 RID: 196005
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDA6 RID: 196006
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FDA7 RID: 196007
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020094AD RID: 38061
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHookInteractTargetIsIgnorePlayerCollision_FunctionParams
	{
		// Token: 0x0402FDA8 RID: 196008
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDA9 RID: 196009
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FDAA RID: 196010
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020094AE RID: 38062
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __StartManipulateInteract_FunctionParams
	{
		// Token: 0x0402FDAB RID: 196011
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDAC RID: 196012
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FDAD RID: 196013
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020094AF RID: 38063
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EndManipulateInteract_FunctionParams
	{
		// Token: 0x0402FDAE RID: 196014
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDAF RID: 196015
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094B0 RID: 38064
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __StartStatueInteract_FunctionParams
	{
		// Token: 0x0402FDB0 RID: 196016
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDB1 RID: 196017
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FDB2 RID: 196018
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020094B1 RID: 38065
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EndStatueInteract_FunctionParams
	{
		// Token: 0x0402FDB3 RID: 196019
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDB4 RID: 196020
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094B2 RID: 38066
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __StartCustomInteract_FunctionParams
	{
		// Token: 0x0402FDB5 RID: 196021
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDB6 RID: 196022
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FDB7 RID: 196023
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020094B3 RID: 38067
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EndCustomInteract_FunctionParams
	{
		// Token: 0x0402FDB8 RID: 196024
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDB9 RID: 196025
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094B4 RID: 38068
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __QuantumDiffusionInteract_FunctionParams
	{
		// Token: 0x0402FDBA RID: 196026
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDBB RID: 196027
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094B5 RID: 38069
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetShootSwordManipulateInteractActors_FunctionParams
	{
		// Token: 0x0402FDBC RID: 196028
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDBD RID: 196029
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FDBE RID: 196030
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x020094B6 RID: 38070
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetManipulateInteractLocation_FunctionParams
	{
		// Token: 0x0402FDBF RID: 196031
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDC0 RID: 196032
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FDC1 RID: 196033
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x020094B7 RID: 38071
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __EnvironmentInfoDetect_FunctionParams
	{
		// Token: 0x0402FDC2 RID: 196034
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDC3 RID: 196035
		[FieldOffset(8)]
		public FVectorDouble location;

		// Token: 0x0402FDC4 RID: 196036
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094B8 RID: 38072
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __LockOnSpecifyTarget_FunctionParams
	{
		// Token: 0x0402FDC5 RID: 196037
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDC6 RID: 196038
		[FieldOffset(4)]
		public int targetEntityId;

		// Token: 0x0402FDC7 RID: 196039
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094B9 RID: 38073
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsSkillInCd_FunctionParams
	{
		// Token: 0x0402FDC8 RID: 196040
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDC9 RID: 196041
		[FieldOffset(4)]
		public int skillId;

		// Token: 0x0402FDCA RID: 196042
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FDCB RID: 196043
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020094BA RID: 38074
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SendHookSkillUseLogData_FunctionParams
	{
		// Token: 0x0402FDCC RID: 196044
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDCD RID: 196045
		[FieldOffset(4)]
		public bool hasTarget;

		// Token: 0x0402FDCE RID: 196046
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094BB RID: 38075
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SendManipulateSkillUseLogData_FunctionParams
	{
		// Token: 0x0402FDCF RID: 196047
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDD0 RID: 196048
		[FieldOffset(4)]
		public bool hasTarget;

		// Token: 0x0402FDD1 RID: 196049
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094BC RID: 38076
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SendScanSkillUseLogData_FunctionParams
	{
		// Token: 0x0402FDD2 RID: 196050
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDD3 RID: 196051
		[FieldOffset(4)]
		public bool hasTarget;

		// Token: 0x0402FDD4 RID: 196052
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094BD RID: 38077
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __DynamicAttachEntityToActor_FunctionParams
	{
		// Token: 0x0402FDD5 RID: 196053
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDD6 RID: 196054
		[FieldOffset(4)]
		public int targetEntityId;

		// Token: 0x0402FDD7 RID: 196055
		[FieldOffset(8)]
		public FName socketName;

		// Token: 0x0402FDD8 RID: 196056
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094BE RID: 38078
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetEntityEnable_FunctionParams
	{
		// Token: 0x0402FDD9 RID: 196057
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDDA RID: 196058
		[FieldOffset(4)]
		public bool enable;

		// Token: 0x0402FDDB RID: 196059
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x0402FDDC RID: 196060
		[FieldOffset(16)]
		public FString reason;

		// Token: 0x0402FDDD RID: 196061
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094BF RID: 38079
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetActorVisible_FunctionParams
	{
		// Token: 0x0402FDDE RID: 196062
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDDF RID: 196063
		[FieldOffset(4)]
		public bool visible;

		// Token: 0x0402FDE0 RID: 196064
		[FieldOffset(5)]
		public bool collision;

		// Token: 0x0402FDE1 RID: 196065
		[FieldOffset(6)]
		public bool movable;

		// Token: 0x0402FDE2 RID: 196066
		[FieldOffset(8)]
		public FString reason;

		// Token: 0x0402FDE3 RID: 196067
		[FieldOffset(24)]
		public bool sync;

		// Token: 0x0402FDE4 RID: 196068
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094C0 RID: 38080
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetSkillTargetDirection_FunctionParams
	{
		// Token: 0x0402FDE5 RID: 196069
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDE6 RID: 196070
		[FieldOffset(4)]
		public byte direction;

		// Token: 0x0402FDE7 RID: 196071
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094C1 RID: 38081
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ChangeAiControllerDebugDraw_FunctionParams
	{
		// Token: 0x0402FDE8 RID: 196072
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDE9 RID: 196073
		[FieldOffset(4)]
		public bool debug;

		// Token: 0x0402FDEA RID: 196074
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094C2 RID: 38082
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBeHitAnimType_FunctionParams
	{
		// Token: 0x0402FDEB RID: 196075
		[FieldOffset(0)]
		public int typeId;

		// Token: 0x0402FDEC RID: 196076
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FDED RID: 196077
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x020094C3 RID: 38083
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __StartInhalation_FunctionParams
	{
		// Token: 0x0402FDEE RID: 196078
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDEF RID: 196079
		[FieldOffset(4)]
		public float strength;

		// Token: 0x0402FDF0 RID: 196080
		[FieldOffset(8)]
		public float distance;

		// Token: 0x0402FDF1 RID: 196081
		[FieldOffset(12)]
		public bool isPowerfulMode;

		// Token: 0x0402FDF2 RID: 196082
		[FieldOffset(16)]
		public float checkAngle;

		// Token: 0x0402FDF3 RID: 196083
		[FieldOffset(24)]
		public byte tag;

		// Token: 0x0402FDF4 RID: 196084
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094C4 RID: 38084
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __StopInhalation_FunctionParams
	{
		// Token: 0x0402FDF5 RID: 196085
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDF6 RID: 196086
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094C5 RID: 38085
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __TryGetDebugMovementComp_FunctionParams
	{
		// Token: 0x0402FDF7 RID: 196087
		[FieldOffset(0)]
		public FString pbDataId;

		// Token: 0x0402FDF8 RID: 196088
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402FDF9 RID: 196089
		[FieldOffset(24)]
		public IntPtr __Result;
	}

	// Token: 0x020094C6 RID: 38086
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __TryPlayLinkAnim_FunctionParams
	{
		// Token: 0x0402FDFA RID: 196090
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094C7 RID: 38087
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __TraceGround_FunctionParams
	{
		// Token: 0x0402FDFB RID: 196091
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FDFC RID: 196092
		[FieldOffset(8)]
		public FVectorDouble start;

		// Token: 0x0402FDFD RID: 196093
		[FieldOffset(32)]
		public FVectorDouble end;

		// Token: 0x0402FDFE RID: 196094
		[FieldOffset(56)]
		public bool draw;

		// Token: 0x0402FDFF RID: 196095
		[FieldOffset(64)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE00 RID: 196096
		[FieldOffset(72)]
		public FVectorDouble __Result;
	}

	// Token: 0x020094C8 RID: 38088
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ChangePhantomTeam_FunctionParams
	{
		// Token: 0x0402FE01 RID: 196097
		[FieldOffset(0)]
		public int phantomFormationId;

		// Token: 0x0402FE02 RID: 196098
		[FieldOffset(8)]
		public byte skillTriggerTags;

		// Token: 0x0402FE03 RID: 196099
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094C9 RID: 38089
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __RevertPhantomTeam_FunctionParams
	{
		// Token: 0x0402FE04 RID: 196100
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094CA RID: 38090
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetFormationAttribute_FunctionParams
	{
		// Token: 0x0402FE05 RID: 196101
		[FieldOffset(0)]
		public int type;

		// Token: 0x0402FE06 RID: 196102
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE07 RID: 196103
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020094CB RID: 38091
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetEntityDeltaMillisecond_FunctionParams
	{
		// Token: 0x0402FE08 RID: 196104
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE09 RID: 196105
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE0A RID: 196106
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020094CC RID: 38092
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SyncTwoEntityLocationAndRotation_FunctionParams
	{
		// Token: 0x0402FE0B RID: 196107
		[FieldOffset(0)]
		public int fromEntityId;

		// Token: 0x0402FE0C RID: 196108
		[FieldOffset(4)]
		public int toEntityId;

		// Token: 0x0402FE0D RID: 196109
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094CD RID: 38093
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetFishingBoat_FunctionParams
	{
		// Token: 0x0402FE0E RID: 196110
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE0F RID: 196111
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x020094CE RID: 38094
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FishingBoatSprint_FunctionParams
	{
		// Token: 0x0402FE10 RID: 196112
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE11 RID: 196113
		[FieldOffset(4)]
		public float maxSpeedRatio;

		// Token: 0x0402FE12 RID: 196114
		[FieldOffset(8)]
		public int exceedLimitDuration;

		// Token: 0x0402FE13 RID: 196115
		[FieldOffset(12)]
		public int duration;

		// Token: 0x0402FE14 RID: 196116
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094CF RID: 38095
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __FishingBoatSkill_FunctionParams
	{
		// Token: 0x0402FE15 RID: 196117
		[FieldOffset(0)]
		public byte type;

		// Token: 0x0402FE16 RID: 196118
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094D0 RID: 38096
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCharacterMorphType_FunctionParams
	{
		// Token: 0x0402FE17 RID: 196119
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE18 RID: 196120
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE19 RID: 196121
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x020094D1 RID: 38097
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCharacterMorphType_FunctionParams
	{
		// Token: 0x0402FE1A RID: 196122
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE1B RID: 196123
		[FieldOffset(4)]
		public byte morphType;

		// Token: 0x0402FE1C RID: 196124
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094D2 RID: 38098
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetSpecialEnergyAttrValue_FunctionParams
	{
		// Token: 0x0402FE1D RID: 196125
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE1E RID: 196126
		[FieldOffset(4)]
		public int attrId;

		// Token: 0x0402FE1F RID: 196127
		[FieldOffset(8)]
		public int value;

		// Token: 0x0402FE20 RID: 196128
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094D3 RID: 38099
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetFuLuoLuoSpecialEnergyType_FunctionParams
	{
		// Token: 0x0402FE21 RID: 196129
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE22 RID: 196130
		[FieldOffset(4)]
		public int index;

		// Token: 0x0402FE23 RID: 196131
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE24 RID: 196132
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x020094D4 RID: 38100
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __StartBattleQte_FunctionParams
	{
		// Token: 0x0402FE25 RID: 196133
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE26 RID: 196134
		[FieldOffset(4)]
		public int skillId;

		// Token: 0x0402FE27 RID: 196135
		[FieldOffset(8)]
		public int battleQteId;

		// Token: 0x0402FE28 RID: 196136
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094D5 RID: 38101
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __StopGroup1Skill_FunctionParams
	{
		// Token: 0x0402FE29 RID: 196137
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE2A RID: 196138
		[FieldOffset(8)]
		public FString reason;

		// Token: 0x0402FE2B RID: 196139
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094D6 RID: 38102
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 88)]
	protected ref struct __GetCharactersLocationNearBy_FunctionParams
	{
		// Token: 0x0402FE2C RID: 196140
		[FieldOffset(0)]
		public FVectorDouble center;

		// Token: 0x0402FE2D RID: 196141
		[FieldOffset(24)]
		public float distance;

		// Token: 0x0402FE2E RID: 196142
		[FieldOffset(28)]
		public int maxCount;

		// Token: 0x0402FE2F RID: 196143
		[FieldOffset(32)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE30 RID: 196144
		[FieldOffset(40)]
		public byte __Result;
	}

	// Token: 0x020094D7 RID: 38103
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetCurrentPlayer_FunctionParams
	{
		// Token: 0x0402FE31 RID: 196145
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE32 RID: 196146
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x020094D8 RID: 38104
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __IsEnemy_FunctionParams
	{
		// Token: 0x0402FE33 RID: 196147
		[FieldOffset(0)]
		public IntPtr owner;

		// Token: 0x0402FE34 RID: 196148
		[FieldOffset(8)]
		public IntPtr other;

		// Token: 0x0402FE35 RID: 196149
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE36 RID: 196150
		[FieldOffset(24)]
		public bool __Result;
	}

	// Token: 0x020094D9 RID: 38105
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetWalkOffLedge_FunctionParams
	{
		// Token: 0x0402FE37 RID: 196151
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE38 RID: 196152
		[FieldOffset(4)]
		public bool walkOff;

		// Token: 0x0402FE39 RID: 196153
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094DA RID: 38106
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __StartFlyingFeather_FunctionParams
	{
		// Token: 0x0402FE3A RID: 196154
		[FieldOffset(0)]
		public IntPtr owner;

		// Token: 0x0402FE3B RID: 196155
		[FieldOffset(8)]
		public FVectorDouble initLocation;

		// Token: 0x0402FE3C RID: 196156
		[FieldOffset(32)]
		public IntPtr config;

		// Token: 0x0402FE3D RID: 196157
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094DB RID: 38107
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetFlyingFeatherTargetId_FunctionParams
	{
		// Token: 0x0402FE3E RID: 196158
		[FieldOffset(0)]
		public IntPtr owner;

		// Token: 0x0402FE3F RID: 196159
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE40 RID: 196160
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020094DC RID: 38108
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __AddFlyingFeatherTargetTag_FunctionParams
	{
		// Token: 0x0402FE41 RID: 196161
		[FieldOffset(0)]
		public FGameplayTag tag;

		// Token: 0x0402FE42 RID: 196162
		[FieldOffset(16)]
		public FString entityId;

		// Token: 0x0402FE43 RID: 196163
		[FieldOffset(32)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE44 RID: 196164
		[FieldOffset(40)]
		public IntPtr __Result;
	}

	// Token: 0x020094DD RID: 38109
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __UpdateFlyingFeather_FunctionParams
	{
		// Token: 0x0402FE45 RID: 196165
		[FieldOffset(0)]
		public IntPtr owner;

		// Token: 0x0402FE46 RID: 196166
		[FieldOffset(8)]
		public FString target;

		// Token: 0x0402FE47 RID: 196167
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE48 RID: 196168
		[FieldOffset(32)]
		public FVectorDouble __Result;
	}

	// Token: 0x020094DE RID: 38110
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __EmitGlobalClientEvent_FunctionParams
	{
		// Token: 0x0402FE49 RID: 196169
		[FieldOffset(0)]
		public FGameplayTag eventNameTag;

		// Token: 0x0402FE4A RID: 196170
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094DF RID: 38111
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetDriverEntityId_FunctionParams
	{
		// Token: 0x0402FE4B RID: 196171
		[FieldOffset(0)]
		public int vehicleEntityId;

		// Token: 0x0402FE4C RID: 196172
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE4D RID: 196173
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x020094E0 RID: 38112
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __StartCableWayMove_FunctionParams
	{
		// Token: 0x0402FE4E RID: 196174
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402FE4F RID: 196175
		[FieldOffset(8)]
		public IntPtr eventBinder;

		// Token: 0x0402FE50 RID: 196176
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094E1 RID: 38113
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __StopCableWayMove_FunctionParams
	{
		// Token: 0x0402FE51 RID: 196177
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402FE52 RID: 196178
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094E2 RID: 38114
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBuffInstigatorId_FunctionParams
	{
		// Token: 0x0402FE53 RID: 196179
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE54 RID: 196180
		[FieldOffset(4)]
		public int buffId;

		// Token: 0x0402FE55 RID: 196181
		[FieldOffset(8)]
		public bool getInstigatorSummoner;

		// Token: 0x0402FE56 RID: 196182
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE57 RID: 196183
		[FieldOffset(24)]
		public int __Result;
	}

	// Token: 0x020094E3 RID: 38115
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 104)]
	protected ref struct __SetSubMeshOrder_FunctionParams
	{
		// Token: 0x0402FE58 RID: 196184
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE59 RID: 196185
		[FieldOffset(8)]
		public FString meshName;

		// Token: 0x0402FE5A RID: 196186
		[FieldOffset(24)]
		public bool visible;

		// Token: 0x0402FE5B RID: 196187
		[FieldOffset(32)]
		public IntPtr charControllerData;

		// Token: 0x0402FE5C RID: 196188
		[FieldOffset(40)]
		public byte effectDataAssetRef;

		// Token: 0x0402FE5D RID: 196189
		[FieldOffset(88)]
		public float delayTime;

		// Token: 0x0402FE5E RID: 196190
		[FieldOffset(96)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094E4 RID: 38116
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetPilotThrowSpeed_FunctionParams
	{
		// Token: 0x0402FE5F RID: 196191
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE60 RID: 196192
		[FieldOffset(8)]
		public float __Result;
	}

	// Token: 0x020094E5 RID: 38117
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetPilotThrowDirection_FunctionParams
	{
		// Token: 0x0402FE61 RID: 196193
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE62 RID: 196194
		[FieldOffset(8)]
		public FVectorDouble __Result;
	}

	// Token: 0x020094E6 RID: 38118
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetPilotThrowGravity_FunctionParams
	{
		// Token: 0x0402FE63 RID: 196195
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE64 RID: 196196
		[FieldOffset(8)]
		public float __Result;
	}

	// Token: 0x020094E7 RID: 38119
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetPilotThrowNeedMotorRide_FunctionParams
	{
		// Token: 0x0402FE65 RID: 196197
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE66 RID: 196198
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x020094E8 RID: 38120
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetPilotThrowIsDisableInterrupt_FunctionParams
	{
		// Token: 0x0402FE67 RID: 196199
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE68 RID: 196200
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x020094E9 RID: 38121
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __OpenPilotThrowGameplayCamera_FunctionParams
	{
		// Token: 0x0402FE69 RID: 196201
		[FieldOffset(0)]
		public int targetEntityId;

		// Token: 0x0402FE6A RID: 196202
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094EA RID: 38122
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCurrentTargetPilotSkeletalMeshComponent_FunctionParams
	{
		// Token: 0x0402FE6B RID: 196203
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE6C RID: 196204
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE6D RID: 196205
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x020094EB RID: 38123
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetPilotCurrentInRangePoint_FunctionParams
	{
		// Token: 0x0402FE6E RID: 196206
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE6F RID: 196207
		[FieldOffset(8)]
		public FVectorDouble __Result;
	}

	// Token: 0x020094EC RID: 38124
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetVehicleCatapultUnitRisingTime_FunctionParams
	{
		// Token: 0x0402FE70 RID: 196208
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE71 RID: 196209
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE72 RID: 196210
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020094ED RID: 38125
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __GuessJokerNpcTurnToIdlePerform_FunctionParams
	{
		// Token: 0x0402FE73 RID: 196211
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094EE RID: 38126
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __LevelFlowDeadlySkeletonMeshCastToCharacter_FunctionParams
	{
		// Token: 0x0402FE74 RID: 196212
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094EF RID: 38127
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __LevelFlowAddBuff_FunctionParams
	{
		// Token: 0x0402FE75 RID: 196213
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE76 RID: 196214
		[FieldOffset(4)]
		public int buffId;

		// Token: 0x0402FE77 RID: 196215
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094F0 RID: 38128
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __LevelFlowRemoveBuff_FunctionParams
	{
		// Token: 0x0402FE78 RID: 196216
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE79 RID: 196217
		[FieldOffset(4)]
		public int buffId;

		// Token: 0x0402FE7A RID: 196218
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094F1 RID: 38129
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __LevelFlowCameraShake_FunctionParams
	{
		// Token: 0x0402FE7B RID: 196219
		[FieldOffset(0)]
		public FString cameraShakeBp;

		// Token: 0x0402FE7C RID: 196220
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094F2 RID: 38130
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __LevelFlowPlayLevelSequence_FunctionParams
	{
		// Token: 0x0402FE7D RID: 196221
		[FieldOffset(0)]
		public FString path;

		// Token: 0x0402FE7E RID: 196222
		[FieldOffset(16)]
		public FString mark;

		// Token: 0x0402FE7F RID: 196223
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094F3 RID: 38131
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1816)]
	protected ref struct __CallSpecialSkillCodeFunction_FunctionParams
	{
		// Token: 0x0402FE80 RID: 196224
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE81 RID: 196225
		[FieldOffset(8)]
		public FString functionName;

		// Token: 0x0402FE82 RID: 196226
		[FieldOffset(24)]
		public byte payload;

		// Token: 0x0402FE83 RID: 196227
		[FieldOffset(904)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE84 RID: 196228
		[FieldOffset(912)]
		public byte __Result;
	}

	// Token: 0x020094F4 RID: 38132
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __XigelikaAddBean_FunctionParams
	{
		// Token: 0x0402FE85 RID: 196229
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE86 RID: 196230
		[FieldOffset(8)]
		public FString bean;

		// Token: 0x0402FE87 RID: 196231
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE88 RID: 196232
		[FieldOffset(32)]
		public int __Result;
	}

	// Token: 0x020094F5 RID: 38133
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __XigelikaGetBeanResultant_FunctionParams
	{
		// Token: 0x0402FE89 RID: 196233
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE8A RID: 196234
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE8B RID: 196235
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x020094F6 RID: 38134
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __XigelikaConsumeBean_FunctionParams
	{
		// Token: 0x0402FE8C RID: 196236
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE8D RID: 196237
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094F7 RID: 38135
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __XigelikaResetBean_FunctionParams
	{
		// Token: 0x0402FE8E RID: 196238
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FE8F RID: 196239
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094F8 RID: 38136
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __OpenQuickHack_FunctionParams
	{
		// Token: 0x0402FE90 RID: 196240
		[FieldOffset(0)]
		public int deviceId;

		// Token: 0x0402FE91 RID: 196241
		[FieldOffset(4)]
		public int ownerEntityId;

		// Token: 0x0402FE92 RID: 196242
		[FieldOffset(8)]
		public bool closeWhenInteractFinish;

		// Token: 0x0402FE93 RID: 196243
		[FieldOffset(12)]
		public FGameplayTag interactFinishGameplayEventTag;

		// Token: 0x0402FE94 RID: 196244
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094F9 RID: 38137
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __CloseQuickHack_FunctionParams
	{
		// Token: 0x0402FE95 RID: 196245
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020094FA RID: 38138
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FunctionOpen_FunctionParams
	{
		// Token: 0x0402FE96 RID: 196246
		[FieldOffset(0)]
		public int functionType;

		// Token: 0x0402FE97 RID: 196247
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FE98 RID: 196248
		[FieldOffset(16)]
		public bool __Result;
	}
}
