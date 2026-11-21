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
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelFlow;
using CSharpScript.Game.LevelFlow.Action;
using CSharpScript.Game.LevelGamePlay.SplineMoveTask;
using CSharpScript.Game.LevelGamePlay.TempActorManager;
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

// Token: 0x0200239C RID: 9116
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsGameplayBlueprintFunctionLibrary.TsGameplayBlueprintFunctionLibrary_C")]
public class TsGameplayBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601690D RID: 92429 RVA: 0x00698777 File Offset: 0x00696977
	static TsGameplayBlueprintFunctionLibrary()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsGameplayBlueprintFunctionLibrary.CreateStaticDefaultValue), new Action(TsGameplayBlueprintFunctionLibrary.ResetStaticDefaultValue));
	}

	// Token: 0x0601690E RID: 92430 RVA: 0x00698798 File Offset: 0x00696998
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool ContainsTag(int entityId, FGameplayTag tag)
	{
		BaseTagComponent component = EntitySystem.Instance.GetComponent<BaseTagComponent>(entityId);
		return component != null && component.Valid && component.HasTag(tag.TagId());
	}

	// Token: 0x0601690F RID: 92431 RVA: 0x006987D0 File Offset: 0x006969D0
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

	// Token: 0x06016910 RID: 92432 RVA: 0x0069880C File Offset: 0x00696A0C
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

	// Token: 0x06016911 RID: 92433 RVA: 0x00698858 File Offset: 0x00696A58
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

	// Token: 0x06016912 RID: 92434 RVA: 0x006988DC File Offset: 0x00696ADC
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

	// Token: 0x06016913 RID: 92435 RVA: 0x0069891C File Offset: 0x00696B1C
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

	// Token: 0x06016914 RID: 92436 RVA: 0x006989A0 File Offset: 0x00696BA0
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

	// Token: 0x06016915 RID: 92437 RVA: 0x006989FC File Offset: 0x00696BFC
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

	// Token: 0x06016916 RID: 92438 RVA: 0x00698A30 File Offset: 0x00696C30
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

	// Token: 0x06016917 RID: 92439 RVA: 0x00698A72 File Offset: 0x00696C72
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsLogicAutonomousProxy(int entityId)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		return component != null && component.IsAutonomousProxy;
	}

	// Token: 0x06016918 RID: 92440 RVA: 0x00698A8C File Offset: 0x00696C8C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool RemoveActiveGameplayEffect(int entityId, FActiveGameplayEffectHandle handle, float stacksToRemove = -1f)
	{
		CharacterBuffComponent component = EntitySystem.Instance.GetComponent<CharacterBuffComponent>(entityId);
		return component != null && component.Valid && component.RemoveBuffByHandle(handle.Handle, (int)stacksToRemove, null, null, null, null) > 0;
	}

	// Token: 0x06016919 RID: 92441 RVA: 0x00698AE8 File Offset: 0x00696CE8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void RemoveBuffByTag(int entityId, FGameplayTag tag)
	{
		CharacterBuffComponent component = EntitySystem.Instance.GetComponent<CharacterBuffComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.RemoveBuffByTag(new int?(tag.TagId()), "蓝图通过Tag移除Buff", null);
		}
	}

	// Token: 0x0601691A RID: 92442 RVA: 0x00698B2C File Offset: 0x00696D2C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void AddPassiveSkill(int entityId, long passiveSkillId)
	{
		global::Log.Instance.Error(ELogModule.Battle, ELogAuthor.ZQR, "废弃接口已无效", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0601691B RID: 92443 RVA: 0x00698B58 File Offset: 0x00696D58
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void RemovePassiveSkill(int entityId, long passiveSkillId)
	{
		CharacterPassiveSkillComponent component = EntitySystem.Instance.GetComponent<CharacterPassiveSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.ForgetPassiveSkill(passiveSkillId, false);
		}
	}

	// Token: 0x0601691C RID: 92444 RVA: 0x00698B84 File Offset: 0x00696D84
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetPassiveGaSkillId(int entityId, UObject callObject)
	{
	}

	// Token: 0x0601691D RID: 92445 RVA: 0x00698B88 File Offset: 0x00696D88
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

	// Token: 0x0601691E RID: 92446 RVA: 0x00698C2C File Offset: 0x00696E2C
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

	// Token: 0x0601691F RID: 92447 RVA: 0x00698CA8 File Offset: 0x00696EA8
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

	// Token: 0x06016920 RID: 92448 RVA: 0x00698D00 File Offset: 0x00696F00
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

	// Token: 0x06016921 RID: 92449 RVA: 0x00698D38 File Offset: 0x00696F38
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

	// Token: 0x06016922 RID: 92450 RVA: 0x00698D84 File Offset: 0x00696F84
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

	// Token: 0x06016923 RID: 92451 RVA: 0x00698DB4 File Offset: 0x00696FB4
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

	// Token: 0x06016924 RID: 92452 RVA: 0x00699064 File Offset: 0x00697264
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

	// Token: 0x06016925 RID: 92453 RVA: 0x006990B8 File Offset: 0x006972B8
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

	// Token: 0x06016926 RID: 92454 RVA: 0x006990EC File Offset: 0x006972EC
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

	// Token: 0x06016927 RID: 92455 RVA: 0x00699130 File Offset: 0x00697330
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetGeDebugString(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		return ((component != null) ? component.GetGeDebugStrings() : null) ?? "";
	}

	// Token: 0x06016928 RID: 92456 RVA: 0x00699152 File Offset: 0x00697352
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetTagDebugStrings(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		return ((component != null) ? component.GetTagDebugStrings() : null) ?? "";
	}

	// Token: 0x06016929 RID: 92457 RVA: 0x00699174 File Offset: 0x00697374
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetBuffDebugStrings(int entityId, string buffStr)
	{
		return TsGameplayBlueprintFunctionLibrary.GetBuffDebugStringsNoBlueprint(entityId, buffStr);
	}

	// Token: 0x0601692A RID: 92458 RVA: 0x0069917D File Offset: 0x0069737D
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetShieldDebugString(int entityId, string filterStr = "")
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		return ((component != null) ? component.GetShieldDebugString(filterStr).Trim() : null) ?? "";
	}

	// Token: 0x0601692B RID: 92459 RVA: 0x006991A5 File Offset: 0x006973A5
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetPassiveSkillDebugString(int entityId)
	{
		return "";
	}

	// Token: 0x0601692C RID: 92460 RVA: 0x006991AC File Offset: 0x006973AC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetShieldValue(int entityId, int shieldCid)
	{
		CharacterShieldComponent component = EntitySystem.Instance.GetComponent<CharacterShieldComponent>(entityId);
		return (float)((int)((component != null) ? component.GetShieldValue(shieldCid) : 0f));
	}

	// Token: 0x0601692D RID: 92461 RVA: 0x006991CC File Offset: 0x006973CC
	[NullableContext(1)]
	public static string GetBuffDebugStringsNoBlueprint(int entityId, string buffStr = "")
	{
		CharacterBuffComponent component = EntitySystem.Instance.GetComponent<CharacterBuffComponent>(entityId);
		CharacterGasDebugComponent component2 = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		return (((component != null) ? component.GetDebugBuffString(buffStr) : null) ?? "未找到buff组件") + "\n" + ((component2 != null) ? component2.GetShieldDebugString("") : null);
	}

	// Token: 0x0601692E RID: 92462 RVA: 0x00699221 File Offset: 0x00697421
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetAttributeDebugString(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		return ((component != null) ? component.GetAttributeDebugStrings() : null) ?? "";
	}

	// Token: 0x0601692F RID: 92463 RVA: 0x00699243 File Offset: 0x00697443
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetAllAttributeDebugStrings(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		return ((component != null) ? component.GetAllAttributeDebugStrings() : null) ?? "";
	}

	// Token: 0x06016930 RID: 92464 RVA: 0x00699265 File Offset: 0x00697465
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

	// Token: 0x06016931 RID: 92465 RVA: 0x0069927D File Offset: 0x0069747D
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

	// Token: 0x06016932 RID: 92466 RVA: 0x00699295 File Offset: 0x00697495
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

	// Token: 0x06016933 RID: 92467 RVA: 0x006992AD File Offset: 0x006974AD
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

	// Token: 0x06016934 RID: 92468 RVA: 0x006992C5 File Offset: 0x006974C5
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

	// Token: 0x06016935 RID: 92469 RVA: 0x006992DD File Offset: 0x006974DD
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

	// Token: 0x06016936 RID: 92470 RVA: 0x006992F5 File Offset: 0x006974F5
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

	// Token: 0x06016937 RID: 92471 RVA: 0x0069930C File Offset: 0x0069750C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetServerDebugInfoDirty(int entityId)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		return component != null && component.ServerDebugInfoDirty;
	}

	// Token: 0x06016938 RID: 92472 RVA: 0x00699324 File Offset: 0x00697524
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetServerDebugInfoDirty(int entityId, bool val)
	{
		CharacterGasDebugComponent component = EntitySystem.Instance.GetComponent<CharacterGasDebugComponent>(entityId);
		if (component != null)
		{
			component.ServerDebugInfoDirty = val;
		}
	}

	// Token: 0x06016939 RID: 92473 RVA: 0x00699348 File Offset: 0x00697548
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

	// Token: 0x0601693A RID: 92474 RVA: 0x006993BF File Offset: 0x006975BF
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void DebugResetFormationValue(int id, float val)
	{
		FormationAttributeController.Instance.SetValue((EFormationAttributeId)id, val);
	}

	// Token: 0x0601693B RID: 92475 RVA: 0x006993CD File Offset: 0x006975CD
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string Record(int entityId, bool record)
	{
		return "";
	}

	// Token: 0x0601693C RID: 92476 RVA: 0x006993D4 File Offset: 0x006975D4
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

	// Token: 0x0601693D RID: 92477 RVA: 0x006995BC File Offset: 0x006977BC
	[NullableContext(2)]
	private static string GetEntityActorName(Entity entity)
	{
		if (entity == null)
		{
			return null;
		}
		if (entity.GetComponent<BaseBuffComponent>() == null || entity.GetComponent<BaseSkillComponent>() == null || entity.GetComponent<BaseActorComponent>() == null)
		{
			return null;
		}
		BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
		if (component == null)
		{
			return null;
		}
		AActor owner = component.Owner;
		if (owner == null)
		{
			return null;
		}
		return owner.GetName();
	}

	// Token: 0x0601693E RID: 92478 RVA: 0x006995FC File Offset: 0x006977FC
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

	// Token: 0x0601693F RID: 92479 RVA: 0x006997B8 File Offset: 0x006979B8
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

	// Token: 0x06016940 RID: 92480 RVA: 0x00699897 File Offset: 0x00697A97
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetDebugEntityId(int entityId)
	{
		CombatDebugController.Instance.DebugEntityId = ((CombatDebugController.Instance.DebugEntityId == entityId) ? 0 : entityId);
	}

	// Token: 0x06016941 RID: 92481 RVA: 0x006998B4 File Offset: 0x00697AB4
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

	// Token: 0x06016942 RID: 92482 RVA: 0x006998C8 File Offset: 0x00697AC8
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

	// Token: 0x06016943 RID: 92483 RVA: 0x00699C78 File Offset: 0x00697E78
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

	// Token: 0x06016944 RID: 92484 RVA: 0x00699CDC File Offset: 0x00697EDC
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

	// Token: 0x06016945 RID: 92485 RVA: 0x00699D06 File Offset: 0x00697F06
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

	// Token: 0x06016946 RID: 92486 RVA: 0x00699D1C File Offset: 0x00697F1C
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

	// Token: 0x06016947 RID: 92487 RVA: 0x00699D73 File Offset: 0x00697F73
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetBuffActivateByHandle(int entityId, int handle)
	{
		ActiveBuffInternal debugBuff = TsGameplayBlueprintFunctionLibrary.GetDebugBuff(entityId, handle);
		return debugBuff != null && debugBuff.IsActive();
	}

	// Token: 0x06016948 RID: 92488 RVA: 0x00699D87 File Offset: 0x00697F87
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

	// Token: 0x06016949 RID: 92489 RVA: 0x00699DB8 File Offset: 0x00697FB8
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

	// Token: 0x0601694A RID: 92490 RVA: 0x00699E2C File Offset: 0x0069802C
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

	// Token: 0x0601694B RID: 92491 RVA: 0x00699E98 File Offset: 0x00698098
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

	// Token: 0x0601694C RID: 92492 RVA: 0x00699ED0 File Offset: 0x006980D0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetBuffLivingStatusStringByHandle(int entityId, int handle)
	{
		ActiveBuffInternal debugBuff = TsGameplayBlueprintFunctionLibrary.GetDebugBuff(entityId, handle);
		return ((debugBuff == null || !debugBuff.IsValid()) ? "销毁" : (debugBuff.IsActive() ? "激活" : "失效")) ?? "";
	}

	// Token: 0x0601694D RID: 92493 RVA: 0x00699F1C File Offset: 0x0069811C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetBuffLevelStringByHandle(int entityId, int handle)
	{
		ActiveBuffInternal debugBuff = TsGameplayBlueprintFunctionLibrary.GetDebugBuff(entityId, handle);
		return (((debugBuff != null) ? debugBuff.Level.ToString() : null) ?? "Invalid") ?? "";
	}

	// Token: 0x0601694E RID: 92494 RVA: 0x00699F58 File Offset: 0x00698158
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetBuffStackStringByHandle(int entityId, int handle)
	{
		ActiveBuffInternal debugBuff = TsGameplayBlueprintFunctionLibrary.GetDebugBuff(entityId, handle);
		return (((debugBuff != null) ? debugBuff.StackCount.ToString() : null) ?? "Invalid") ?? "";
	}

	// Token: 0x0601694F RID: 92495 RVA: 0x00699F94 File Offset: 0x00698194
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

	// Token: 0x06016950 RID: 92496 RVA: 0x0069A644 File Offset: 0x00698844
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetDistance(int entityId, float max)
	{
		CharacterGasDebugComponent.SetDistanceMax(max);
	}

	// Token: 0x06016951 RID: 92497 RVA: 0x0069A64C File Offset: 0x0069884C
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

	// Token: 0x06016952 RID: 92498 RVA: 0x0069A664 File Offset: 0x00698864
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

	// Token: 0x06016953 RID: 92499 RVA: 0x0069A67D File Offset: 0x0069887D
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

	// Token: 0x06016954 RID: 92500 RVA: 0x0069A69A File Offset: 0x0069889A
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

	// Token: 0x06016955 RID: 92501 RVA: 0x0069A6B7 File Offset: 0x006988B7
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

	// Token: 0x06016956 RID: 92502 RVA: 0x0069A6CF File Offset: 0x006988CF
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

	// Token: 0x06016957 RID: 92503 RVA: 0x0069A6E8 File Offset: 0x006988E8
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

	// Token: 0x06016958 RID: 92504 RVA: 0x0069A71A File Offset: 0x0069891A
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

	// Token: 0x06016959 RID: 92505 RVA: 0x0069A732 File Offset: 0x00698932
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool CheckHasPart(int entityId)
	{
		CharacterPartComponent component = EntitySystem.Instance.GetComponent<CharacterPartComponent>(entityId);
		return component != null && component.IsMultiPart;
	}

	// Token: 0x0601695A RID: 92506 RVA: 0x0069A74C File Offset: 0x0069894C
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

	// Token: 0x0601695B RID: 92507 RVA: 0x0069A784 File Offset: 0x00698984
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ResetPartLife(int entityId, FGameplayTag tag)
	{
		CharacterPartComponent component = EntitySystem.Instance.GetComponent<CharacterPartComponent>(entityId);
		if (component != null && component.IsMultiPart)
		{
			component.GetPartByTag(tag).ResetLife();
		}
	}

	// Token: 0x0601695C RID: 92508 RVA: 0x0069A7B4 File Offset: 0x006989B4
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

	// Token: 0x0601695D RID: 92509 RVA: 0x0069A7D0 File Offset: 0x006989D0
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

	// Token: 0x0601695E RID: 92510 RVA: 0x0069A7EC File Offset: 0x006989EC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetAcceptedNewBeHitAndReset(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		return component != null && component.GetAcceptedNewBeHitAndReset();
	}

	// Token: 0x0601695F RID: 92511 RVA: 0x0069A804 File Offset: 0x00698A04
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetEnterFkAndReset(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		return component != null && component.GetEnterFkAndReset();
	}

	// Token: 0x06016960 RID: 92512 RVA: 0x0069A81C File Offset: 0x00698A1C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsStiff(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		return component != null && component.IsStiff();
	}

	// Token: 0x06016961 RID: 92513 RVA: 0x0069A834 File Offset: 0x00698A34
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetRageModeId(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		return (float)((component != null) ? component.RageModeId : 0);
	}

	// Token: 0x06016962 RID: 92514 RVA: 0x0069A84E File Offset: 0x00698A4E
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetHardnessModeId(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		return (float)((component != null) ? component.HardnessModeId : 0);
	}

	// Token: 0x06016963 RID: 92515 RVA: 0x0069A868 File Offset: 0x00698A68
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

	// Token: 0x06016964 RID: 92516 RVA: 0x0069A8AA File Offset: 0x00698AAA
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

	// Token: 0x06016965 RID: 92517 RVA: 0x0069A8C6 File Offset: 0x00698AC6
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

	// Token: 0x06016966 RID: 92518 RVA: 0x0069A8DE File Offset: 0x00698ADE
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

	// Token: 0x06016967 RID: 92519 RVA: 0x0069A8F6 File Offset: 0x00698AF6
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

	// Token: 0x06016968 RID: 92520 RVA: 0x0069A914 File Offset: 0x00698B14
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

	// Token: 0x06016969 RID: 92521 RVA: 0x0069A938 File Offset: 0x00698B38
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetEnterFk(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		return component != null && component.EnterFk;
	}

	// Token: 0x0601696A RID: 92522 RVA: 0x0069A950 File Offset: 0x00698B50
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

	// Token: 0x0601696B RID: 92523 RVA: 0x0069A984 File Offset: 0x00698B84
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

	// Token: 0x0601696C RID: 92524 RVA: 0x0069A9B5 File Offset: 0x00698BB5
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void AddCheckBuffList(int entityId, SCounterAttackBuff addValue)
	{
	}

	// Token: 0x0601696D RID: 92525 RVA: 0x0069A9B7 File Offset: 0x00698BB7
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ClearCheckBuffList(int entityId)
	{
	}

	// Token: 0x0601696E RID: 92526 RVA: 0x0069A9B9 File Offset: 0x00698BB9
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

	// Token: 0x0601696F RID: 92527 RVA: 0x0069A9D0 File Offset: 0x00698BD0
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

	// Token: 0x06016970 RID: 92528 RVA: 0x0069A9E7 File Offset: 0x00698BE7
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

	// Token: 0x06016971 RID: 92529 RVA: 0x0069A9FF File Offset: 0x00698BFF
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsTriggerCounterAttack(int entityId)
	{
		CharacterHitComponent component = EntitySystem.Instance.GetComponent<CharacterHitComponent>(entityId);
		return component != null && component.IsTriggerCounterAttack;
	}

	// Token: 0x06016972 RID: 92530 RVA: 0x0069AA17 File Offset: 0x00698C17
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

	// Token: 0x06016973 RID: 92531 RVA: 0x0069AA30 File Offset: 0x00698C30
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

	// Token: 0x06016974 RID: 92532 RVA: 0x0069AA90 File Offset: 0x00698C90
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ExitLockDirection(int entityId)
	{
		CharacterLockOnComponent component = EntitySystem.Instance.GetComponent<CharacterLockOnComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.ExitLockDirection();
		}
	}

	// Token: 0x06016975 RID: 92533 RVA: 0x0069AABC File Offset: 0x00698CBC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EnterLockDirection(int entityId)
	{
		CharacterLockOnComponent component = EntitySystem.Instance.GetComponent<CharacterLockOnComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.EnterLockDirection();
		}
	}

	// Token: 0x06016976 RID: 92534 RVA: 0x0069AAE8 File Offset: 0x00698CE8
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

	// Token: 0x06016977 RID: 92535 RVA: 0x0069AB3D File Offset: 0x00698D3D
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetLockOnDebugLine(int entityId, bool isShow)
	{
		LockOnDebug.IsShowDebugLine = isShow;
	}

	// Token: 0x06016978 RID: 92536 RVA: 0x0069AB45 File Offset: 0x00698D45
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool ManipulateValid(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		return component != null && component.Valid;
	}

	// Token: 0x06016979 RID: 92537 RVA: 0x0069AB60 File Offset: 0x00698D60
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

	// Token: 0x0601697A RID: 92538 RVA: 0x0069AB8C File Offset: 0x00698D8C
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

	// Token: 0x0601697B RID: 92539 RVA: 0x0069ABB8 File Offset: 0x00698DB8
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

	// Token: 0x0601697C RID: 92540 RVA: 0x0069ABE8 File Offset: 0x00698DE8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool ManipulateChant(int entityId, UKuroBooleanEventBinder eventBinder)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		return component != null && component.Valid && component.Chant(eventBinder);
	}

	// Token: 0x0601697D RID: 92541 RVA: 0x0069AC18 File Offset: 0x00698E18
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool ManipulateDraw(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		return component != null && component.Valid && component.Draw();
	}

	// Token: 0x0601697E RID: 92542 RVA: 0x0069AC44 File Offset: 0x00698E44
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool ManipulateCast(int entityId, float direction)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		return component != null && component.Valid && component.Precast((int)direction);
	}

	// Token: 0x0601697F RID: 92543 RVA: 0x0069AC74 File Offset: 0x00698E74
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ManipulateReset(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.Reset();
		}
	}

	// Token: 0x06016980 RID: 92544 RVA: 0x0069ACA0 File Offset: 0x00698EA0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool ManipulateChangeToProjectileState(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		return component != null && component.Valid && component.ChangeToProjectileState();
	}

	// Token: 0x06016981 RID: 92545 RVA: 0x0069ACCC File Offset: 0x00698ECC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool ManipulateChangeToNormalState(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		return component != null && component.Valid && component.ChangeToNormalState();
	}

	// Token: 0x06016982 RID: 92546 RVA: 0x0069ACF8 File Offset: 0x00698EF8
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

	// Token: 0x06016983 RID: 92547 RVA: 0x0069AD24 File Offset: 0x00698F24
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool HasHoldingActor(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		return component != null && component.Valid && component.HasHoldingActor();
	}

	// Token: 0x06016984 RID: 92548 RVA: 0x0069AD50 File Offset: 0x00698F50
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetDebugDraw(int entityId, bool isActive)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.DebugDrawSphereAndArrow = isActive;
		}
	}

	// Token: 0x06016985 RID: 92549 RVA: 0x0069AD7C File Offset: 0x00698F7C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ExtraAction(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.ExtraAction();
		}
	}

	// Token: 0x06016986 RID: 92550 RVA: 0x0069ADA8 File Offset: 0x00698FA8
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

	// Token: 0x06016987 RID: 92551 RVA: 0x0069ADFD File Offset: 0x00698FFD
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

	// Token: 0x06016988 RID: 92552 RVA: 0x0069AE18 File Offset: 0x00699018
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

	// Token: 0x06016989 RID: 92553 RVA: 0x0069AE48 File Offset: 0x00699048
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

	// Token: 0x0601698A RID: 92554 RVA: 0x0069AECC File Offset: 0x006990CC
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

	// Token: 0x0601698B RID: 92555 RVA: 0x0069AEFC File Offset: 0x006990FC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetLastActivateSkillTime(int entityId, float time)
	{
		CharacterSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SetLastActivateSkillTime(time);
		}
	}

	// Token: 0x0601698C RID: 92556 RVA: 0x0069AF28 File Offset: 0x00699128
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

	// Token: 0x0601698D RID: 92557 RVA: 0x0069AF58 File Offset: 0x00699158
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetSkillElevationAngle(int entityId, float angle)
	{
		CharacterSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SetSkillElevationAngle(angle);
		}
	}

	// Token: 0x0601698E RID: 92558 RVA: 0x0069AF84 File Offset: 0x00699184
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

	// Token: 0x0601698F RID: 92559 RVA: 0x0069AFC8 File Offset: 0x006991C8
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

	// Token: 0x06016990 RID: 92560 RVA: 0x0069AFF4 File Offset: 0x006991F4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetCurrentPriority(int entityId, int priority)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SetCurrentPriority(priority);
		}
	}

	// Token: 0x06016991 RID: 92561 RVA: 0x0069B020 File Offset: 0x00699220
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool HasAbility(int entityId, string skillId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		int skillId2;
		return component != null && component.Valid && int.TryParse(skillId, out skillId2) && component.HasAbility(skillId2);
	}

	// Token: 0x06016992 RID: 92562 RVA: 0x0069B058 File Offset: 0x00699258
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

	// Token: 0x06016993 RID: 92563 RVA: 0x0069B090 File Offset: 0x00699290
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

	// Token: 0x06016994 RID: 92564 RVA: 0x0069B0C8 File Offset: 0x006992C8
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

	// Token: 0x06016995 RID: 92565 RVA: 0x0069B104 File Offset: 0x00699304
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

	// Token: 0x06016996 RID: 92566 RVA: 0x0069B174 File Offset: 0x00699374
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

	// Token: 0x06016997 RID: 92567 RVA: 0x0069B2BC File Offset: 0x006994BC
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

	// Token: 0x06016998 RID: 92568 RVA: 0x0069B328 File Offset: 0x00699528
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

	// Token: 0x06016999 RID: 92569 RVA: 0x0069B39C File Offset: 0x0069959C
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

	// Token: 0x0601699A RID: 92570 RVA: 0x0069B410 File Offset: 0x00699610
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

	// Token: 0x0601699B RID: 92571 RVA: 0x0069B480 File Offset: 0x00699680
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

	// Token: 0x0601699C RID: 92572 RVA: 0x0069B4E8 File Offset: 0x006996E8
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

	// Token: 0x0601699D RID: 92573 RVA: 0x0069B53C File Offset: 0x0069973C
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

	// Token: 0x0601699E RID: 92574 RVA: 0x0069B568 File Offset: 0x00699768
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsHasInputDir(int entityId)
	{
		CharacterSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSkillComponent>(entityId);
		return component != null && component.Valid && component.IsHasInputDir();
	}

	// Token: 0x0601699F RID: 92575 RVA: 0x0069B594 File Offset: 0x00699794
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

	// Token: 0x060169A0 RID: 92576 RVA: 0x0069B5D0 File Offset: 0x006997D0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetSkillAcceptInput(int entityId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		return component != null && component.Valid && component.SkillAcceptInput;
	}

	// Token: 0x060169A1 RID: 92577 RVA: 0x0069B5FC File Offset: 0x006997FC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetSkillAcceptInput(int entityId, bool skillAcceptInput)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SetSkillAcceptInput(skillAcceptInput);
		}
	}

	// Token: 0x060169A2 RID: 92578 RVA: 0x0069B628 File Offset: 0x00699828
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetCommonSkillCanBeInterrupt(int entityId, bool canBeInterrupt)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.IsMainSkillReadyEnd = canBeInterrupt;
		}
	}

	// Token: 0x060169A3 RID: 92579 RVA: 0x0069B654 File Offset: 0x00699854
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetCommonSkillCanBeInterrupt(int entityId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		return component != null && component.Valid && component.IsMainSkillReadyEnd;
	}

	// Token: 0x060169A4 RID: 92580 RVA: 0x0069B680 File Offset: 0x00699880
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

	// Token: 0x060169A5 RID: 92581 RVA: 0x0069B6B4 File Offset: 0x006998B4
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

	// Token: 0x060169A6 RID: 92582 RVA: 0x0069B6E0 File Offset: 0x006998E0
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

	// Token: 0x060169A7 RID: 92583 RVA: 0x0069B71C File Offset: 0x0069991C
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

	// Token: 0x060169A8 RID: 92584 RVA: 0x0069B758 File Offset: 0x00699958
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

	// Token: 0x060169A9 RID: 92585 RVA: 0x0069B790 File Offset: 0x00699990
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

	// Token: 0x060169AA RID: 92586 RVA: 0x0069B7C8 File Offset: 0x006999C8
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

	// Token: 0x060169AB RID: 92587 RVA: 0x0069B8A4 File Offset: 0x00699AA4
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

	// Token: 0x060169AC RID: 92588 RVA: 0x0069B8DC File Offset: 0x00699ADC
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

	// Token: 0x060169AD RID: 92589 RVA: 0x0069B914 File Offset: 0x00699B14
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void CallAnimBreakPoint(int entityId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.CallAnimBreakPoint();
		}
	}

	// Token: 0x060169AE RID: 92590 RVA: 0x0069B940 File Offset: 0x00699B40
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void RollingGround(int entityId)
	{
		CharacterSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.RollingGrounded();
		}
	}

	// Token: 0x060169AF RID: 92591 RVA: 0x0069B96C File Offset: 0x00699B6C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool ActivateAbilityVision(int entityId, EVisionType visionType)
	{
		CharacterVisionComponent component = EntitySystem.Instance.GetComponent<CharacterVisionComponent>(entityId);
		return component != null && component.Valid && component.ActivateAbilityVision(visionType);
	}

	// Token: 0x060169B0 RID: 92592 RVA: 0x0069B99C File Offset: 0x00699B9C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool EndAbilityVision(int entityId, EVisionType visionType)
	{
		CharacterVisionComponent component = EntitySystem.Instance.GetComponent<CharacterVisionComponent>(entityId);
		return component != null && component.Valid && component.EndAbilityVision(visionType);
	}

	// Token: 0x060169B1 RID: 92593 RVA: 0x0069B9CC File Offset: 0x00699BCC
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

	// Token: 0x060169B2 RID: 92594 RVA: 0x0069BA28 File Offset: 0x00699C28
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

	// Token: 0x060169B3 RID: 92595 RVA: 0x0069BA6D File Offset: 0x00699C6D
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

	// Token: 0x060169B4 RID: 92596 RVA: 0x0069BA92 File Offset: 0x00699C92
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

	// Token: 0x060169B5 RID: 92597 RVA: 0x0069BAB9 File Offset: 0x00699CB9
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

	// Token: 0x060169B6 RID: 92598 RVA: 0x0069BADF File Offset: 0x00699CDF
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static TArray<int> GetVisionLevelList(int entityId)
	{
		return new TArray<int>();
	}

	// Token: 0x060169B7 RID: 92599 RVA: 0x0069BAE6 File Offset: 0x00699CE6
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static int GetVisionSkillId(int entityId, float visionId, float level)
	{
		return PhantomUtil.GetEntityVisionSkillId(entityId, (int)visionId);
	}

	// Token: 0x060169B8 RID: 92600 RVA: 0x0069BAF0 File Offset: 0x00699CF0
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

	// Token: 0x060169B9 RID: 92601 RVA: 0x0069BB2C File Offset: 0x00699D2C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void DeleteSkills(int entityId)
	{
		BaseSkillComponent component = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.StopAllSkills("TsGameplayBlueprintFunctionLibrary.DeleteSkills");
		}
	}

	// Token: 0x060169BA RID: 92602 RVA: 0x0069BB5C File Offset: 0x00699D5C
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

	// Token: 0x060169BB RID: 92603 RVA: 0x0069BB94 File Offset: 0x00699D94
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

	// Token: 0x060169BC RID: 92604 RVA: 0x0069BBC0 File Offset: 0x00699DC0
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

	// Token: 0x060169BD RID: 92605 RVA: 0x0069BBF0 File Offset: 0x00699DF0
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

	// Token: 0x060169BE RID: 92606 RVA: 0x0069BC78 File Offset: 0x00699E78
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

	// Token: 0x060169BF RID: 92607 RVA: 0x0069BCB4 File Offset: 0x00699EB4
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

	// Token: 0x060169C0 RID: 92608 RVA: 0x0069BCEC File Offset: 0x00699EEC
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

	// Token: 0x060169C1 RID: 92609 RVA: 0x0069BD24 File Offset: 0x00699F24
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void BeginAbsoluteTimeStop(int entityId, float duration, bool stopMove = true)
	{
		SkillUtils.BeginAbsoluteTimeStop(entityId, duration, stopMove, 0f);
	}

	// Token: 0x060169C2 RID: 92610 RVA: 0x0069BD33 File Offset: 0x00699F33
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EndAbsoluteTimeStop(int entityId)
	{
		SkillUtils.EndAbsoluteTimeStop(entityId);
	}

	// Token: 0x060169C3 RID: 92611 RVA: 0x0069BD3B File Offset: 0x00699F3B
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void BeginTimeStopRequest(int entityId, float duration)
	{
		SkillUtils.BeginTimeStopRequest(entityId, duration, 0f);
	}

	// Token: 0x060169C4 RID: 92612 RVA: 0x0069BD49 File Offset: 0x00699F49
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EndTimeStopRequest(int entityId)
	{
		SkillUtils.EndTimeStopRequest(entityId);
	}

	// Token: 0x060169C5 RID: 92613 RVA: 0x0069BD51 File Offset: 0x00699F51
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

	// Token: 0x060169C6 RID: 92614 RVA: 0x0069BD74 File Offset: 0x00699F74
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool CanActivateFixHook(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		return component != null && component.Valid && component.CanActivateFixHook();
	}

	// Token: 0x060169C7 RID: 92615 RVA: 0x0069BDA0 File Offset: 0x00699FA0
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

	// Token: 0x060169C8 RID: 92616 RVA: 0x0069BDDC File Offset: 0x00699FDC
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

	// Token: 0x060169C9 RID: 92617 RVA: 0x0069BEB0 File Offset: 0x0069A0B0
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

	// Token: 0x060169CA RID: 92618 RVA: 0x0069BEDC File Offset: 0x0069A0DC
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

	// Token: 0x060169CB RID: 92619 RVA: 0x0069BF08 File Offset: 0x0069A108
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool FixHookTargetIsSuiGuangType(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		return component != null && component.Valid && component.GetTargetIsSuiGuangType();
	}

	// Token: 0x060169CC RID: 92620 RVA: 0x0069BF34 File Offset: 0x0069A134
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

	// Token: 0x060169CD RID: 92621 RVA: 0x0069BF60 File Offset: 0x0069A160
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

	// Token: 0x060169CE RID: 92622 RVA: 0x0069BF94 File Offset: 0x0069A194
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

	// Token: 0x060169CF RID: 92623 RVA: 0x0069BFC8 File Offset: 0x0069A1C8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool FixHookTargetInheritSpeed(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		return component != null && component.Valid && component.GetInheritSpeed();
	}

	// Token: 0x060169D0 RID: 92624 RVA: 0x0069BFF4 File Offset: 0x0069A1F4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool FixHookTargetIsClimb(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		return component != null && component.Valid && component.GetIsClimb();
	}

	// Token: 0x060169D1 RID: 92625 RVA: 0x0069C020 File Offset: 0x0069A220
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetIsHookEndByInterrupt(int entityId, bool isInterrupt)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SetIsHookEndByInterrupt(isInterrupt);
		}
	}

	// Token: 0x060169D2 RID: 92626 RVA: 0x0069C04C File Offset: 0x0069A24C
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

	// Token: 0x060169D3 RID: 92627 RVA: 0x0069C084 File Offset: 0x0069A284
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

	// Token: 0x060169D4 RID: 92628 RVA: 0x0069C0BC File Offset: 0x0069A2BC
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

	// Token: 0x060169D5 RID: 92629 RVA: 0x0069C0FC File Offset: 0x0069A2FC
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

	// Token: 0x060169D6 RID: 92630 RVA: 0x0069C134 File Offset: 0x0069A334
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

	// Token: 0x060169D7 RID: 92631 RVA: 0x0069C16C File Offset: 0x0069A36C
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

	// Token: 0x060169D8 RID: 92632 RVA: 0x0069C1A8 File Offset: 0x0069A3A8
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

	// Token: 0x060169D9 RID: 92633 RVA: 0x0069C1E4 File Offset: 0x0069A3E4
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

	// Token: 0x060169DA RID: 92634 RVA: 0x0069C230 File Offset: 0x0069A430
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

	// Token: 0x060169DB RID: 92635 RVA: 0x0069C268 File Offset: 0x0069A468
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

	// Token: 0x060169DC RID: 92636 RVA: 0x0069C2CC File Offset: 0x0069A4CC
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

	// Token: 0x060169DD RID: 92637 RVA: 0x0069C330 File Offset: 0x0069A530
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void StartChargeSlash(int entityId)
	{
		GrapplingHookPointComponent component = EntitySystem.Instance.GetComponent<GrapplingHookPointComponent>(entityId);
		if (component != null && component.Valid)
		{
			ChargeSlashGameplayController.Instance.StartChargeSlash(component);
		}
	}

	// Token: 0x060169DE RID: 92638 RVA: 0x0069C360 File Offset: 0x0069A560
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void StopChargeSlash(int entityId)
	{
		GrapplingHookPointComponent component = EntitySystem.Instance.GetComponent<GrapplingHookPointComponent>(entityId);
		if (component != null && component.Valid)
		{
			ChargeSlashGameplayController.Instance.StopChargeSlash(component);
		}
	}

	// Token: 0x060169DF RID: 92639 RVA: 0x0069C38F File Offset: 0x0069A58F
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsSlashGameplayIsSuccess()
	{
		return SlashGameplayController.Instance.CheckGroups();
	}

	// Token: 0x060169E0 RID: 92640 RVA: 0x0069C39B File Offset: 0x0069A59B
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static SGravityHookLockInfo GetGravityHookLockInfo(int entityId)
	{
		return GravityHookController.Instance.GetGravityHookLockInfo(entityId);
	}

	// Token: 0x060169E1 RID: 92641 RVA: 0x0069C3A8 File Offset: 0x0069A5A8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void ChangeGravityByHook(int entityId, int angleRangeMin, int angleRangeMax, float smoothSecondMin, float smoothSecondMax, bool isLerpCamera)
	{
		GravityHookController.Instance.ChangeGravity(entityId, (float)angleRangeMin, (float)angleRangeMax, smoothSecondMin, smoothSecondMax, isLerpCamera);
	}

	// Token: 0x060169E2 RID: 92642 RVA: 0x0069C3C0 File Offset: 0x0069A5C0
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

	// Token: 0x060169E3 RID: 92643 RVA: 0x0069C3F8 File Offset: 0x0069A5F8
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

	// Token: 0x060169E4 RID: 92644 RVA: 0x0069C430 File Offset: 0x0069A630
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

	// Token: 0x060169E5 RID: 92645 RVA: 0x0069C464 File Offset: 0x0069A664
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

	// Token: 0x060169E6 RID: 92646 RVA: 0x0069C49C File Offset: 0x0069A69C
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

	// Token: 0x060169E7 RID: 92647 RVA: 0x0069C4CE File Offset: 0x0069A6CE
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static ECharState GetCharUnifiedMoveState(int entityId)
	{
		BaseUnifiedStateComponent component = EntitySystem.Instance.GetComponent<BaseUnifiedStateComponent>(entityId);
		return (ECharState)((component != null) ? component.MoveState : global::ECharMoveState.Other);
	}

	// Token: 0x060169E8 RID: 92648 RVA: 0x0069C4E8 File Offset: 0x0069A6E8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static ECharParentMoveState GetCharUnifiedPositionState(int entityId)
	{
		BaseUnifiedStateComponent component = EntitySystem.Instance.GetComponent<BaseUnifiedStateComponent>(entityId);
		return (ECharParentMoveState)((component != null) ? component.PositionState : global::ECharPositionState.Ground);
	}

	// Token: 0x060169E9 RID: 92649 RVA: 0x0069C502 File Offset: 0x0069A702
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

	// Token: 0x060169EA RID: 92650 RVA: 0x0069C51E File Offset: 0x0069A71E
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

	// Token: 0x060169EB RID: 92651 RVA: 0x0069C536 File Offset: 0x0069A736
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static ECharViewDirectionState GetDirectionState(int entityId)
	{
		BaseUnifiedStateComponent component = EntitySystem.Instance.GetComponent<BaseUnifiedStateComponent>(entityId);
		return (ECharViewDirectionState)((component != null) ? component.DirectionState : ECharDirectionState.LockDirection);
	}

	// Token: 0x060169EC RID: 92652 RVA: 0x0069C550 File Offset: 0x0069A750
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetIsInGame(int entityId)
	{
		BaseUnifiedStateComponent component = EntitySystem.Instance.GetComponent<BaseUnifiedStateComponent>(entityId);
		return ((component != null) ? component.IsInGame : null).GetValueOrDefault();
	}

	// Token: 0x060169ED RID: 92653 RVA: 0x0069C584 File Offset: 0x0069A784
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

	// Token: 0x060169EE RID: 92654 RVA: 0x0069C59B File Offset: 0x0069A79B
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

	// Token: 0x060169EF RID: 92655 RVA: 0x0069C5B4 File Offset: 0x0069A7B4
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

	// Token: 0x060169F0 RID: 92656 RVA: 0x0069C5FD File Offset: 0x0069A7FD
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

	// Token: 0x060169F1 RID: 92657 RVA: 0x0069C614 File Offset: 0x0069A814
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

	// Token: 0x060169F2 RID: 92658 RVA: 0x0069C62B File Offset: 0x0069A82B
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

	// Token: 0x060169F3 RID: 92659 RVA: 0x0069C644 File Offset: 0x0069A844
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

	// Token: 0x060169F4 RID: 92660 RVA: 0x0069C65C File Offset: 0x0069A85C
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

	// Token: 0x060169F5 RID: 92661 RVA: 0x0069C673 File Offset: 0x0069A873
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EnableEntity(int entityId, bool isEnable)
	{
	}

	// Token: 0x060169F6 RID: 92662 RVA: 0x0069C678 File Offset: 0x0069A878
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

	// Token: 0x060169F7 RID: 92663 RVA: 0x0069C74C File Offset: 0x0069A94C
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

	// Token: 0x060169F8 RID: 92664 RVA: 0x0069C804 File Offset: 0x0069AA04
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

	// Token: 0x060169F9 RID: 92665 RVA: 0x0069C8C0 File Offset: 0x0069AAC0
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

	// Token: 0x060169FA RID: 92666 RVA: 0x0069C92C File Offset: 0x0069AB2C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetIsCharRotateWithCameraWhenManipulate(int entityId)
	{
		CharacterManipulateComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateComponent>(entityId);
		return component != null && component.Valid && component.GetIsCharRotateWithCameraWhenManipulate();
	}

	// Token: 0x060169FB RID: 92667 RVA: 0x0069C958 File Offset: 0x0069AB58
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetIsUseCatapultUpAnim(int entityId)
	{
		CharacterActionComponent component = EntitySystem.Instance.GetComponent<CharacterActionComponent>(entityId);
		return component != null && component.Valid && component.IsUseCatapultUpAnim;
	}

	// Token: 0x060169FC RID: 92668 RVA: 0x0069C984 File Offset: 0x0069AB84
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

	// Token: 0x060169FD RID: 92669 RVA: 0x0069C9B8 File Offset: 0x0069ABB8
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

	// Token: 0x060169FE RID: 92670 RVA: 0x0069C9E8 File Offset: 0x0069ABE8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetManipulateInteractTargetCanInteract(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		return component == null || component.CheckCurrentTargetCanInteract();
	}

	// Token: 0x060169FF RID: 92671 RVA: 0x0069CA0C File Offset: 0x0069AC0C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetHookInteractTargetCanInteract(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		return component == null || component.CheckNextTargetCanInteract();
	}

	// Token: 0x06016A00 RID: 92672 RVA: 0x0069CA30 File Offset: 0x0069AC30
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetHookInteractTargetIsIgnorePlayerCollision(int entityId)
	{
		BaseSceneInteractComponent component = EntitySystem.Instance.GetComponent<BaseSceneInteractComponent>(entityId);
		return component != null && component.GetNextTargetIsIgnorePlayerCollision();
	}

	// Token: 0x06016A01 RID: 92673 RVA: 0x0069CA54 File Offset: 0x0069AC54
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool StartManipulateInteract(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		return component != null && component.StartPullGiantInteract();
	}

	// Token: 0x06016A02 RID: 92674 RVA: 0x0069CA78 File Offset: 0x0069AC78
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EndManipulateInteract(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		if (component != null)
		{
			component.EndPullGiantInteract();
		}
	}

	// Token: 0x06016A03 RID: 92675 RVA: 0x0069CA9C File Offset: 0x0069AC9C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool StartStatueInteract(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		return component != null && component.StartStatueInteract();
	}

	// Token: 0x06016A04 RID: 92676 RVA: 0x0069CAC0 File Offset: 0x0069ACC0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EndStatueInteract(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		if (component != null)
		{
			component.EndStatueInteract();
		}
	}

	// Token: 0x06016A05 RID: 92677 RVA: 0x0069CAE4 File Offset: 0x0069ACE4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool StartCustomInteract(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		return component != null && component.StartCustomInteract();
	}

	// Token: 0x06016A06 RID: 92678 RVA: 0x0069CB08 File Offset: 0x0069AD08
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EndCustomInteract(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		if (component != null)
		{
			component.EndCustomInteract();
		}
	}

	// Token: 0x06016A07 RID: 92679 RVA: 0x0069CB2C File Offset: 0x0069AD2C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void QuantumDiffusionInteract(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		if (component != null)
		{
			component.QuantumDiffusionInteract();
		}
	}

	// Token: 0x06016A08 RID: 92680 RVA: 0x0069CB50 File Offset: 0x0069AD50
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

	// Token: 0x06016A09 RID: 92681 RVA: 0x0069CB7C File Offset: 0x0069AD7C
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

	// Token: 0x06016A0A RID: 92682 RVA: 0x0069CBB0 File Offset: 0x0069ADB0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EnvironmentInfoDetect(int entityId, FVectorDouble location)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component != null)
		{
			WorldController.Instance.EnvironmentInfoUpdate(location, component.IsRoleAndCtrlByMe, false);
		}
	}

	// Token: 0x06016A0B RID: 92683 RVA: 0x0069CBE0 File Offset: 0x0069ADE0
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

	// Token: 0x06016A0C RID: 92684 RVA: 0x0069CC2C File Offset: 0x0069AE2C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsSkillInCd(int entityId, int skillId)
	{
		CharacterSkillCdComponent component = EntitySystem.Instance.GetComponent<CharacterSkillCdComponent>(entityId);
		return component != null && component.Valid && component.IsSkillInCd(skillId, true);
	}

	// Token: 0x06016A0D RID: 92685 RVA: 0x0069CC5C File Offset: 0x0069AE5C
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

	// Token: 0x06016A0E RID: 92686 RVA: 0x0069CCFC File Offset: 0x0069AEFC
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

	// Token: 0x06016A0F RID: 92687 RVA: 0x0069CD9C File Offset: 0x0069AF9C
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

	// Token: 0x06016A10 RID: 92688 RVA: 0x0069CE3C File Offset: 0x0069B03C
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

	// Token: 0x06016A11 RID: 92689 RVA: 0x0069CF74 File Offset: 0x0069B174
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

	// Token: 0x06016A12 RID: 92690 RVA: 0x0069CFEC File Offset: 0x0069B1EC
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

	// Token: 0x06016A13 RID: 92691 RVA: 0x0069D024 File Offset: 0x0069B224
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetSkillTargetDirection(int entityId, ESkillTargetDirection direction)
	{
		CharacterSkillComponent component = EntitySystem.Instance.GetComponent<CharacterSkillComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SetSkillTargetDirection(direction, ESkillTargetPriority.摇杆方向优先);
		}
	}

	// Token: 0x06016A14 RID: 92692 RVA: 0x0069D050 File Offset: 0x0069B250
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

	// Token: 0x06016A15 RID: 92693 RVA: 0x0069D0A8 File Offset: 0x0069B2A8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static EHitAnim GetBeHitAnimType(int typeId)
	{
		return (EHitAnim)typeId;
	}

	// Token: 0x06016A16 RID: 92694 RVA: 0x0069D0AC File Offset: 0x0069B2AC
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

	// Token: 0x06016A17 RID: 92695 RVA: 0x0069D12C File Offset: 0x0069B32C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void StopInhalation(int entityId)
	{
		RoleInhalationComponent component = EntitySystem.Instance.GetComponent<RoleInhalationComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.StopInhalation();
		}
	}

	// Token: 0x06016A18 RID: 92696 RVA: 0x0069D158 File Offset: 0x0069B358
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

	// Token: 0x06016A19 RID: 92697 RVA: 0x0069D288 File Offset: 0x0069B488
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void TryPlayLinkAnim()
	{
		BattleLinkController.Instance.TryPlaySplitScreen();
	}

	// Token: 0x06016A1A RID: 92698 RVA: 0x0069D294 File Offset: 0x0069B494
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

	// Token: 0x06016A1B RID: 92699 RVA: 0x0069D314 File Offset: 0x0069B514
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

	// Token: 0x06016A1C RID: 92700 RVA: 0x0069D358 File Offset: 0x0069B558
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void RevertPhantomTeam()
	{
		SceneTeamController.Instance.RevertPhantomTeam();
	}

	// Token: 0x06016A1D RID: 92701 RVA: 0x0069D364 File Offset: 0x0069B564
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

	// Token: 0x06016A1E RID: 92702 RVA: 0x0069D37C File Offset: 0x0069B57C
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

	// Token: 0x06016A1F RID: 92703 RVA: 0x0069D3C8 File Offset: 0x0069B5C8
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

	// Token: 0x06016A20 RID: 92704 RVA: 0x0069D460 File Offset: 0x0069B660
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

	// Token: 0x06016A21 RID: 92705 RVA: 0x0069D4A8 File Offset: 0x0069B6A8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void FishingBoatSprint(int entityId, float maxSpeedRatio, int exceedLimitDuration, int duration)
	{
		FishingBoatPerformComponent component = EntitySystem.Instance.GetComponent<FishingBoatPerformComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.FishingBoatEnterSprint(maxSpeedRatio, (float)exceedLimitDuration, (float)duration);
		}
	}

	// Token: 0x06016A22 RID: 92706 RVA: 0x0069D4D7 File Offset: 0x0069B6D7
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void FishingBoatSkill(EFishingSkillType type)
	{
		FishingController.Instance.BeginFishingSkill(type);
	}

	// Token: 0x06016A23 RID: 92707 RVA: 0x0069D4E4 File Offset: 0x0069B6E4
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

	// Token: 0x06016A24 RID: 92708 RVA: 0x0069D4FC File Offset: 0x0069B6FC
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

	// Token: 0x06016A25 RID: 92709 RVA: 0x0069D514 File Offset: 0x0069B714
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetSpecialEnergyAttrValue(int entityId, int attrId, int value)
	{
		AbilityUtils.SetSpecialEnergyAttrValue(entityId, attrId, (float)value);
	}

	// Token: 0x06016A26 RID: 92710 RVA: 0x0069D520 File Offset: 0x0069B720
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

	// Token: 0x06016A27 RID: 92711 RVA: 0x0069D550 File Offset: 0x0069B750
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

	// Token: 0x06016A28 RID: 92712 RVA: 0x0069D5C0 File Offset: 0x0069B7C0
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

	// Token: 0x06016A29 RID: 92713 RVA: 0x0069D5EB File Offset: 0x0069B7EB
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static SCharacterLocationsAndRadius GetCharactersLocationNearBy(FVectorDouble center, float distance, int maxCount)
	{
		return CreatureController.Instance.GetCharactersLocationNearBy(center, distance, maxCount);
	}

	// Token: 0x06016A2A RID: 92714 RVA: 0x0069D5FA File Offset: 0x0069B7FA
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static TsBaseCharacter GetCurrentPlayer()
	{
		return Global.BaseCharacter;
	}

	// Token: 0x06016A2B RID: 92715 RVA: 0x0069D604 File Offset: 0x0069B804
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

	// Token: 0x06016A2C RID: 92716 RVA: 0x0069D6B8 File Offset: 0x0069B8B8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetWalkOffLedge(int entityId, bool walkOff)
	{
		BaseMoveComponent component = EntitySystem.Instance.GetComponent<BaseMoveComponent>(entityId);
		if (component != null && component.Valid)
		{
			component.SetWalkOffLedgeRecord(walkOff);
		}
	}

	// Token: 0x06016A2D RID: 92717 RVA: 0x0069D6E4 File Offset: 0x0069B8E4
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

	// Token: 0x06016A2E RID: 92718 RVA: 0x0069D82C File Offset: 0x0069BA2C
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

	// Token: 0x06016A2F RID: 92719 RVA: 0x0069D9B4 File Offset: 0x0069BBB4
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

	// Token: 0x06016A30 RID: 92720 RVA: 0x0069DA38 File Offset: 0x0069BC38
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

	// Token: 0x06016A31 RID: 92721 RVA: 0x0069DAC4 File Offset: 0x0069BCC4
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

	// Token: 0x06016A32 RID: 92722 RVA: 0x0069DB4C File Offset: 0x0069BD4C
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

	// Token: 0x06016A33 RID: 92723 RVA: 0x0069DCB3 File Offset: 0x0069BEB3
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EmitGlobalClientEvent(FGameplayTag eventNameTag)
	{
		EventSystem.Instance.Emit<FGameplayTag>(EEventName.CheckClientEvent, eventNameTag);
	}

	// Token: 0x06016A34 RID: 92724 RVA: 0x0069DCC8 File Offset: 0x0069BEC8
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

	// Token: 0x06016A35 RID: 92725 RVA: 0x0069DCF8 File Offset: 0x0069BEF8
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

	// Token: 0x06016A36 RID: 92726 RVA: 0x0069DF18 File Offset: 0x0069C118
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

	// Token: 0x06016A37 RID: 92727 RVA: 0x0069DFF8 File Offset: 0x0069C1F8
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

	// Token: 0x06016A38 RID: 92728 RVA: 0x0069E0A0 File Offset: 0x0069C2A0
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

	// Token: 0x06016A39 RID: 92729 RVA: 0x0069E0D7 File Offset: 0x0069C2D7
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetPilotThrowSpeed()
	{
		return PilotThrowModel.Instance.LaunchSpeed;
	}

	// Token: 0x06016A3A RID: 92730 RVA: 0x0069E0E3 File Offset: 0x0069C2E3
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVectorDouble GetPilotThrowDirection()
	{
		return PilotThrowModel.Instance.LaunchDirection.ToUeVector(false);
	}

	// Token: 0x06016A3B RID: 92731 RVA: 0x0069E0F5 File Offset: 0x0069C2F5
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetPilotThrowGravity()
	{
		return PilotThrowModel.Instance.LaunchGravity;
	}

	// Token: 0x06016A3C RID: 92732 RVA: 0x0069E101 File Offset: 0x0069C301
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetPilotThrowNeedMotorRide()
	{
		return PilotThrowModel.Instance.NeedMotorRide;
	}

	// Token: 0x06016A3D RID: 92733 RVA: 0x0069E10D File Offset: 0x0069C30D
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetPilotThrowIsDisableInterrupt()
	{
		return PilotThrowModel.Instance.DisableInterrupt;
	}

	// Token: 0x06016A3E RID: 92734 RVA: 0x0069E11C File Offset: 0x0069C31C
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

	// Token: 0x06016A3F RID: 92735 RVA: 0x0069E24C File Offset: 0x0069C44C
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

	// Token: 0x06016A40 RID: 92736 RVA: 0x0069E3D9 File Offset: 0x0069C5D9
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

	// Token: 0x06016A41 RID: 92737 RVA: 0x0069E3F8 File Offset: 0x0069C5F8
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

	// Token: 0x06016A42 RID: 92738 RVA: 0x0069E42C File Offset: 0x0069C62C
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

	// Token: 0x06016A43 RID: 92739 RVA: 0x0069E473 File Offset: 0x0069C673
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void LevelFlowDeadlySkeletonMeshCastToCharacter()
	{
		LevelFlowModel.Instance.ResetLevelFlow(false);
	}

	// Token: 0x06016A44 RID: 92740 RVA: 0x0069E480 File Offset: 0x0069C680
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void LevelFlowAddBuff(int entityId, int buffId)
	{
		LevelFlowModel.Instance.PushDynamicAction(new LevelFlowAddBuffAction().Init(entityId, new List<long>
		{
			(long)buffId
		}));
	}

	// Token: 0x06016A45 RID: 92741 RVA: 0x0069E4A4 File Offset: 0x0069C6A4
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void LevelFlowRemoveBuff(int entityId, int buffId)
	{
		LevelFlowModel.Instance.PushDynamicAction(new LevelFlowRemoveBuffAction().Init(entityId, new List<long>
		{
			(long)buffId
		}));
	}

	// Token: 0x06016A46 RID: 92742 RVA: 0x0069E4C8 File Offset: 0x0069C6C8
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

	// Token: 0x06016A47 RID: 92743 RVA: 0x0069E4FC File Offset: 0x0069C6FC
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

	// Token: 0x06016A48 RID: 92744 RVA: 0x0069E554 File Offset: 0x0069C754
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

	// Token: 0x06016A49 RID: 92745 RVA: 0x0069E594 File Offset: 0x0069C794
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

	// Token: 0x06016A4A RID: 92746 RVA: 0x0069E5E0 File Offset: 0x0069C7E0
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

	// Token: 0x06016A4B RID: 92747 RVA: 0x0069E62C File Offset: 0x0069C82C
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

	// Token: 0x06016A4C RID: 92748 RVA: 0x0069E674 File Offset: 0x0069C874
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

	// Token: 0x06016A4D RID: 92749 RVA: 0x0069E6BC File Offset: 0x0069C8BC
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void OpenQuickHack(int deviceId, int ownerEntityId, bool closeWhenInteractFinish, FGameplayTag interactFinishGameplayEventTag)
	{
		QuickHackController.Instance.OpenQuickHack(deviceId, ownerEntityId, closeWhenInteractFinish, new FGameplayTag?(interactFinishGameplayEventTag), null);
	}

	// Token: 0x06016A4E RID: 92750 RVA: 0x0069E6D2 File Offset: 0x0069C8D2
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void CloseQuickHack()
	{
		QuickHackController.Instance.CloseQuickHack();
	}

	// Token: 0x06016A4F RID: 92751 RVA: 0x0069E6DE File Offset: 0x0069C8DE
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool FunctionOpen(int functionType)
	{
		return FunctionModel.Instance.IsOpen(functionType);
	}

	// Token: 0x06016A50 RID: 92752 RVA: 0x0069E6EB File Offset: 0x0069C8EB
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool CreateTempActor(int playerId, [Nullable(new byte[]
	{
		0,
		1
	})] TSubclassOf<AActor> actorClass, FTransformDouble transform)
	{
		TempActorController instance = TempActorController.Instance;
		return instance != null && instance.Create(playerId, actorClass, new FTransformDouble?(transform), null);
	}

	// Token: 0x06016A51 RID: 92753 RVA: 0x0069E706 File Offset: 0x0069C906
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool DestroyTempActor(int playerId)
	{
		TempActorController instance = TempActorController.Instance;
		return instance != null && instance.Destroy(playerId);
	}

	// Token: 0x06016A52 RID: 92754 RVA: 0x0069E719 File Offset: 0x0069C919
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016A53 RID: 92755 RVA: 0x0069E71B File Offset: 0x0069C91B
	public static void ResetStaticDefaultValue()
	{
		TsGameplayBlueprintFunctionLibrary.FlyingFeatherHandle = null;
	}

	// Token: 0x06016A54 RID: 92756 RVA: 0x0069E723 File Offset: 0x0069C923
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsGameplayBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsGameplayBlueprintFunctionLibrary.TsGameplayBlueprintFunctionLibrary_C");
		}
		return TsGameplayBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06016A55 RID: 92757 RVA: 0x0069E748 File Offset: 0x0069C948
	public TsGameplayBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsGameplayBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06016A56 RID: 92758 RVA: 0x0069E770 File Offset: 0x0069C970
	[NullableContext(1)]
	public TsGameplayBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsGameplayBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016A57 RID: 92759 RVA: 0x0069E7A3 File Offset: 0x0069C9A3
	protected TsGameplayBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06016A58 RID: 92760 RVA: 0x0069E7AC File Offset: 0x0069C9AC
	protected unsafe static void __CPPCALL_ContainsTag_Implementation(TsGameplayBlueprintFunctionLibrary.__ContainsTag_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.ContainsTag(__Params->entityId, __Params->tag);
	}

	// Token: 0x06016A59 RID: 92761 RVA: 0x0069E7C5 File Offset: 0x0069C9C5
	protected unsafe static void __CPPCALL_AddTag_Implementation(TsGameplayBlueprintFunctionLibrary.__AddTag_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.AddTag(__Params->entityId, __Params->tag);
	}

	// Token: 0x06016A5A RID: 92762 RVA: 0x0069E7D8 File Offset: 0x0069C9D8
	protected unsafe static void __CPPCALL_AddTagWithDuration_Implementation(TsGameplayBlueprintFunctionLibrary.__AddTagWithDuration_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.AddTagWithDuration(__Params->entityId, __Params->duration, __Params->tag);
	}

	// Token: 0x06016A5B RID: 92763 RVA: 0x0069E7F4 File Offset: 0x0069C9F4
	protected unsafe static void __CPPCALL_AddTagByName_Implementation(TsGameplayBlueprintFunctionLibrary.__AddTagByName_FunctionParams* __Params)
	{
		string tagName = FString.ToString((void*)(&__Params->tagName));
		TsGameplayBlueprintFunctionLibrary.AddTagByName(__Params->entityId, tagName);
	}

	// Token: 0x06016A5C RID: 92764 RVA: 0x0069E81A File Offset: 0x0069CA1A
	protected unsafe static void __CPPCALL_RemoveTag_Implementation(TsGameplayBlueprintFunctionLibrary.__RemoveTag_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.RemoveTag(__Params->entityId, __Params->tag);
	}

	// Token: 0x06016A5D RID: 92765 RVA: 0x0069E830 File Offset: 0x0069CA30
	protected unsafe static void __CPPCALL_RemoveTagByName_Implementation(TsGameplayBlueprintFunctionLibrary.__RemoveTagByName_FunctionParams* __Params)
	{
		string tagName = FString.ToString((void*)(&__Params->tagName));
		TsGameplayBlueprintFunctionLibrary.RemoveTagByName(__Params->entityId, tagName);
	}

	// Token: 0x06016A5E RID: 92766 RVA: 0x0069E856 File Offset: 0x0069CA56
	protected unsafe static void __CPPCALL_AddCue_Implementation(TsGameplayBlueprintFunctionLibrary.__AddCue_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.AddCue(__Params->instigatorEntityId, __Params->targetEntityId, __Params->cueId);
	}

	// Token: 0x06016A5F RID: 92767 RVA: 0x0069E86F File Offset: 0x0069CA6F
	protected unsafe static void __CPPCALL_RemoveCue_Implementation(TsGameplayBlueprintFunctionLibrary.__RemoveCue_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.RemoveCue(__Params->entityId, __Params->cueId);
	}

	// Token: 0x06016A60 RID: 92768 RVA: 0x0069E882 File Offset: 0x0069CA82
	protected unsafe static void __CPPCALL_SetGameplayCueEffectForceRecycle_Implementation(TsGameplayBlueprintFunctionLibrary.__SetGameplayCueEffectForceRecycle_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetGameplayCueEffectForceRecycle(__Params->entityId, __Params->cueId);
	}

	// Token: 0x06016A61 RID: 92769 RVA: 0x0069E895 File Offset: 0x0069CA95
	protected unsafe static void __CPPCALL_IsLogicAutonomousProxy_Implementation(TsGameplayBlueprintFunctionLibrary.__IsLogicAutonomousProxy_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.IsLogicAutonomousProxy(__Params->entityId);
	}

	// Token: 0x06016A62 RID: 92770 RVA: 0x0069E8A8 File Offset: 0x0069CAA8
	protected unsafe static void __CPPCALL_RemoveActiveGameplayEffect_Implementation(TsGameplayBlueprintFunctionLibrary.__RemoveActiveGameplayEffect_FunctionParams* __Params)
	{
		FActiveGameplayEffectHandle handle = new FActiveGameplayEffectHandle(&__Params->handle, true, true);
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.RemoveActiveGameplayEffect(__Params->entityId, handle, __Params->stacksToRemove);
	}

	// Token: 0x06016A63 RID: 92771 RVA: 0x0069E8DC File Offset: 0x0069CADC
	protected unsafe static void __CPPCALL_RemoveBuffByTag_Implementation(TsGameplayBlueprintFunctionLibrary.__RemoveBuffByTag_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.RemoveBuffByTag(__Params->entityId, __Params->tag);
	}

	// Token: 0x06016A64 RID: 92772 RVA: 0x0069E8EF File Offset: 0x0069CAEF
	protected unsafe static void __CPPCALL_AddPassiveSkill_Implementation(TsGameplayBlueprintFunctionLibrary.__AddPassiveSkill_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.AddPassiveSkill(__Params->entityId, __Params->passiveSkillId);
	}

	// Token: 0x06016A65 RID: 92773 RVA: 0x0069E902 File Offset: 0x0069CB02
	protected unsafe static void __CPPCALL_RemovePassiveSkill_Implementation(TsGameplayBlueprintFunctionLibrary.__RemovePassiveSkill_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.RemovePassiveSkill(__Params->entityId, __Params->passiveSkillId);
	}

	// Token: 0x06016A66 RID: 92774 RVA: 0x0069E918 File Offset: 0x0069CB18
	protected unsafe static void __CPPCALL_SetPassiveGaSkillId_Implementation(TsGameplayBlueprintFunctionLibrary.__SetPassiveGaSkillId_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->callObject);
		TsGameplayBlueprintFunctionLibrary.SetPassiveGaSkillId(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06016A67 RID: 92775 RVA: 0x0069E93D File Offset: 0x0069CB3D
	protected unsafe static void __CPPCALL_AddBuffForDebug_Implementation(TsGameplayBlueprintFunctionLibrary.__AddBuffForDebug_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.AddBuffForDebug(__Params->instigatorEntityId, __Params->targetEntityId, __Params->buffId);
	}

	// Token: 0x06016A68 RID: 92776 RVA: 0x0069E958 File Offset: 0x0069CB58
	protected unsafe static void __CPPCALL_SendCombatEventForDebug_Implementation(TsGameplayBlueprintFunctionLibrary.__SendCombatEventForDebug_FunctionParams* __Params)
	{
		string tagName = FString.ToString((void*)(&__Params->tagName));
		TsGameplayBlueprintFunctionLibrary.SendCombatEventForDebug(__Params->entityId, tagName, __Params->needSave, __Params->isMainState);
	}

	// Token: 0x06016A69 RID: 92777 RVA: 0x0069E98C File Offset: 0x0069CB8C
	protected unsafe static void __CPPCALL_SendLevelEventForDebug_Implementation(TsGameplayBlueprintFunctionLibrary.__SendLevelEventForDebug_FunctionParams* __Params)
	{
		string tagName = FString.ToString((void*)(&__Params->tagName));
		TsGameplayBlueprintFunctionLibrary.SendLevelEventForDebug(__Params->entityId, tagName);
	}

	// Token: 0x06016A6A RID: 92778 RVA: 0x0069E9B4 File Offset: 0x0069CBB4
	protected unsafe static void __CPPCALL_AddBuffFromGA_Implementation(TsGameplayBlueprintFunctionLibrary.__AddBuffFromGA_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->target);
		string skillId = FString.ToString((void*)(&__Params->skillId));
		TsGameplayBlueprintFunctionLibrary.AddBuffFromGA(__Params->entityId, orCreateUObjectByNativePointer, __Params->buffId, skillId, __Params->addCount);
	}

	// Token: 0x06016A6B RID: 92779 RVA: 0x0069E9F3 File Offset: 0x0069CBF3
	protected unsafe static void __CPPCALL_RemoveBuffById_Implementation(TsGameplayBlueprintFunctionLibrary.__RemoveBuffById_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.RemoveBuffById(__Params->entityId, __Params->buffId, __Params->stackCount);
	}

	// Token: 0x06016A6C RID: 92780 RVA: 0x0069EA0C File Offset: 0x0069CC0C
	protected unsafe static void __CPPCALL_GetBuffCountById_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffCountById_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBuffCountById(__Params->entityId, __Params->buffId, __Params->enforceOnGoingCheck);
	}

	// Token: 0x06016A6D RID: 92781 RVA: 0x0069EA2B File Offset: 0x0069CC2B
	protected unsafe static void __CPPCALL_AddGameplayCueLocal_Implementation(TsGameplayBlueprintFunctionLibrary.__AddGameplayCueLocal_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.AddGameplayCueLocal(__Params->entityId, __Params->duration, __Params->cueId);
	}

	// Token: 0x06016A6E RID: 92782 RVA: 0x0069EA44 File Offset: 0x0069CC44
	protected unsafe static void __CPPCALL_GetGeDebugString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetGeDebugString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetGeDebugString(__Params->entityId));
	}

	// Token: 0x06016A6F RID: 92783 RVA: 0x0069EA5D File Offset: 0x0069CC5D
	protected unsafe static void __CPPCALL_GetTagDebugStrings_Implementation(TsGameplayBlueprintFunctionLibrary.__GetTagDebugStrings_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetTagDebugStrings(__Params->entityId));
	}

	// Token: 0x06016A70 RID: 92784 RVA: 0x0069EA78 File Offset: 0x0069CC78
	protected unsafe static void __CPPCALL_GetBuffDebugStrings_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffDebugStrings_FunctionParams* __Params)
	{
		string buffStr = FString.ToString((void*)(&__Params->buffStr));
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetBuffDebugStrings(__Params->entityId, buffStr));
	}

	// Token: 0x06016A71 RID: 92785 RVA: 0x0069EAAC File Offset: 0x0069CCAC
	protected unsafe static void __CPPCALL_GetShieldDebugString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetShieldDebugString_FunctionParams* __Params)
	{
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetShieldDebugString(__Params->entityId, filterStr));
	}

	// Token: 0x06016A72 RID: 92786 RVA: 0x0069EADE File Offset: 0x0069CCDE
	protected unsafe static void __CPPCALL_GetPassiveSkillDebugString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPassiveSkillDebugString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetPassiveSkillDebugString(__Params->entityId));
	}

	// Token: 0x06016A73 RID: 92787 RVA: 0x0069EAF7 File Offset: 0x0069CCF7
	protected unsafe static void __CPPCALL_GetShieldValue_Implementation(TsGameplayBlueprintFunctionLibrary.__GetShieldValue_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetShieldValue(__Params->entityId, __Params->shieldCid);
	}

	// Token: 0x06016A74 RID: 92788 RVA: 0x0069EB10 File Offset: 0x0069CD10
	protected unsafe static void __CPPCALL_GetAttributeDebugString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetAttributeDebugString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetAttributeDebugString(__Params->entityId));
	}

	// Token: 0x06016A75 RID: 92789 RVA: 0x0069EB29 File Offset: 0x0069CD29
	protected unsafe static void __CPPCALL_GetAllAttributeDebugStrings_Implementation(TsGameplayBlueprintFunctionLibrary.__GetAllAttributeDebugStrings_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetAllAttributeDebugStrings(__Params->entityId));
	}

	// Token: 0x06016A76 RID: 92790 RVA: 0x0069EB42 File Offset: 0x0069CD42
	protected unsafe static void __CPPCALL_GetServerBuffString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetServerBuffString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetServerBuffString(__Params->entityId));
	}

	// Token: 0x06016A77 RID: 92791 RVA: 0x0069EB5B File Offset: 0x0069CD5B
	protected unsafe static void __CPPCALL_GetServerTagString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetServerTagString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetServerTagString(__Params->entityId));
	}

	// Token: 0x06016A78 RID: 92792 RVA: 0x0069EB74 File Offset: 0x0069CD74
	protected unsafe static void __CPPCALL_GetServerAttributeString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetServerAttributeString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetServerAttributeString(__Params->entityId));
	}

	// Token: 0x06016A79 RID: 92793 RVA: 0x0069EB8D File Offset: 0x0069CD8D
	protected unsafe static void __CPPCALL_GetServerPartString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetServerPartString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetServerPartString(__Params->entityId));
	}

	// Token: 0x06016A7A RID: 92794 RVA: 0x0069EBA6 File Offset: 0x0069CDA6
	protected unsafe static void __CPPCALL_GetServerHateString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetServerHateString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetServerHateString(__Params->entityId));
	}

	// Token: 0x06016A7B RID: 92795 RVA: 0x0069EBBF File Offset: 0x0069CDBF
	protected unsafe static void __CPPCALL_GetServerShieldString_Implementation(TsGameplayBlueprintFunctionLibrary.__GetServerShieldString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetServerShieldString(__Params->entityId));
	}

	// Token: 0x06016A7C RID: 92796 RVA: 0x0069EBD8 File Offset: 0x0069CDD8
	protected unsafe static void __CPPCALL_ServerDebugInfoRequest_Implementation(TsGameplayBlueprintFunctionLibrary.__ServerDebugInfoRequest_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ServerDebugInfoRequest(__Params->entityId);
	}

	// Token: 0x06016A7D RID: 92797 RVA: 0x0069EBE5 File Offset: 0x0069CDE5
	protected unsafe static void __CPPCALL_GetServerDebugInfoDirty_Implementation(TsGameplayBlueprintFunctionLibrary.__GetServerDebugInfoDirty_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetServerDebugInfoDirty(__Params->entityId);
	}

	// Token: 0x06016A7E RID: 92798 RVA: 0x0069EBF8 File Offset: 0x0069CDF8
	protected unsafe static void __CPPCALL_SetServerDebugInfoDirty_Implementation(TsGameplayBlueprintFunctionLibrary.__SetServerDebugInfoDirty_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetServerDebugInfoDirty(__Params->entityId, __Params->val);
	}

	// Token: 0x06016A7F RID: 92799 RVA: 0x0069EC0B File Offset: 0x0069CE0B
	protected unsafe static void __CPPCALL_DebugResetBaseVal_Implementation(TsGameplayBlueprintFunctionLibrary.__DebugResetBaseVal_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.DebugResetBaseVal(__Params->entityId, __Params->id, __Params->val);
	}

	// Token: 0x06016A80 RID: 92800 RVA: 0x0069EC24 File Offset: 0x0069CE24
	protected unsafe static void __CPPCALL_DebugResetFormationValue_Implementation(TsGameplayBlueprintFunctionLibrary.__DebugResetFormationValue_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.DebugResetFormationValue(__Params->id, __Params->val);
	}

	// Token: 0x06016A81 RID: 92801 RVA: 0x0069EC37 File Offset: 0x0069CE37
	protected unsafe static void __CPPCALL_Record_Implementation(TsGameplayBlueprintFunctionLibrary.__Record_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.Record(__Params->entityId, __Params->record));
	}

	// Token: 0x06016A82 RID: 92802 RVA: 0x0069EC56 File Offset: 0x0069CE56
	protected unsafe static void __CPPCALL_RefreshEntityListView_Implementation(TsGameplayBlueprintFunctionLibrary.__RefreshEntityListView_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.RefreshEntityListView(BuiltinUtils.GetOrCreateUObjectByNativePointer<UListView>(__Params->listView));
	}

	// Token: 0x06016A83 RID: 92803 RVA: 0x0069EC68 File Offset: 0x0069CE68
	protected unsafe static void __CPPCALL_RefreshEntityComboBox_Implementation(TsGameplayBlueprintFunctionLibrary.__RefreshEntityComboBox_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.RefreshEntityComboBox(BuiltinUtils.GetOrCreateUObjectByNativePointer<UComboBoxString>(__Params->comboBox));
	}

	// Token: 0x06016A84 RID: 92804 RVA: 0x0069EC7A File Offset: 0x0069CE7A
	protected unsafe static void __CPPCALL_SetEntityComboBox_Implementation(TsGameplayBlueprintFunctionLibrary.__SetEntityComboBox_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetEntityComboBox(BuiltinUtils.GetOrCreateUObjectByNativePointer<UComboBoxString>(__Params->comboBox), __Params->entityId);
	}

	// Token: 0x06016A85 RID: 92805 RVA: 0x0069EC92 File Offset: 0x0069CE92
	protected unsafe static void __CPPCALL_SetDebugEntityId_Implementation(TsGameplayBlueprintFunctionLibrary.__SetDebugEntityId_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetDebugEntityId(__Params->entityId);
	}

	// Token: 0x06016A86 RID: 92806 RVA: 0x0069EC9F File Offset: 0x0069CE9F
	protected unsafe static void __CPPCALL_GetDebugEntityId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetDebugEntityId_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetDebugEntityId();
	}

	// Token: 0x06016A87 RID: 92807 RVA: 0x0069ECAC File Offset: 0x0069CEAC
	protected unsafe static void __CPPCALL_RefreshBuffListView_Implementation(TsGameplayBlueprintFunctionLibrary.__RefreshBuffListView_FunctionParams* __Params)
	{
		UListView orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UListView>(__Params->listView);
		string filterStr = FString.ToString((void*)(&__Params->filterStr));
		TsGameplayBlueprintFunctionLibrary.RefreshBuffListView(__Params->entityId, orCreateUObjectByNativePointer, filterStr);
	}

	// Token: 0x06016A88 RID: 92808 RVA: 0x0069ECDF File Offset: 0x0069CEDF
	protected unsafe static void __CPPCALL_GetBuffIdByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffIdByHandle_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBuffIdByHandle(__Params->entityId, __Params->handle);
	}

	// Token: 0x06016A89 RID: 92809 RVA: 0x0069ECF8 File Offset: 0x0069CEF8
	protected unsafe static void __CPPCALL_GetBuffServerIdByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffServerIdByHandle_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBuffServerIdByHandle(__Params->entityId, __Params->handle);
	}

	// Token: 0x06016A8A RID: 92810 RVA: 0x0069ED11 File Offset: 0x0069CF11
	protected unsafe static void __CPPCALL_GetBuffDescByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffDescByHandle_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetBuffDescByHandle(__Params->entityId, __Params->handle));
	}

	// Token: 0x06016A8B RID: 92811 RVA: 0x0069ED30 File Offset: 0x0069CF30
	protected unsafe static void __CPPCALL_GetBuffActivateByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffActivateByHandle_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBuffActivateByHandle(__Params->entityId, __Params->handle);
	}

	// Token: 0x06016A8C RID: 92812 RVA: 0x0069ED49 File Offset: 0x0069CF49
	protected unsafe static void __CPPCALL_GetBuffInstigatorStringByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffInstigatorStringByHandle_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetBuffInstigatorStringByHandle(__Params->entityId, __Params->handle));
	}

	// Token: 0x06016A8D RID: 92813 RVA: 0x0069ED68 File Offset: 0x0069CF68
	protected unsafe static void __CPPCALL_GetBuffPeriodStringByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffPeriodStringByHandle_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetBuffPeriodStringByHandle(__Params->entityId, __Params->handle));
	}

	// Token: 0x06016A8E RID: 92814 RVA: 0x0069ED87 File Offset: 0x0069CF87
	protected unsafe static void __CPPCALL_GetBuffDurationStringByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffDurationStringByHandle_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetBuffDurationStringByHandle(__Params->entityId, __Params->handle));
	}

	// Token: 0x06016A8F RID: 92815 RVA: 0x0069EDA6 File Offset: 0x0069CFA6
	protected unsafe static void __CPPCALL_GetBuffDurationProgress_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffDurationProgress_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBuffDurationProgress(__Params->entityId, __Params->handle);
	}

	// Token: 0x06016A90 RID: 92816 RVA: 0x0069EDBF File Offset: 0x0069CFBF
	protected unsafe static void __CPPCALL_GetBuffLivingStatusStringByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffLivingStatusStringByHandle_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetBuffLivingStatusStringByHandle(__Params->entityId, __Params->handle));
	}

	// Token: 0x06016A91 RID: 92817 RVA: 0x0069EDDE File Offset: 0x0069CFDE
	protected unsafe static void __CPPCALL_GetBuffLevelStringByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffLevelStringByHandle_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetBuffLevelStringByHandle(__Params->entityId, __Params->handle));
	}

	// Token: 0x06016A92 RID: 92818 RVA: 0x0069EDFD File Offset: 0x0069CFFD
	protected unsafe static void __CPPCALL_GetBuffStackStringByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffStackStringByHandle_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetBuffStackStringByHandle(__Params->entityId, __Params->handle));
	}

	// Token: 0x06016A93 RID: 92819 RVA: 0x0069EE1C File Offset: 0x0069D01C
	protected unsafe static void __CPPCALL_GetBuffDebugStringByHandle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffDebugStringByHandle_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetBuffDebugStringByHandle(__Params->entityId, __Params->handle));
	}

	// Token: 0x06016A94 RID: 92820 RVA: 0x0069EE3B File Offset: 0x0069D03B
	protected unsafe static void __CPPCALL_SetDistance_Implementation(TsGameplayBlueprintFunctionLibrary.__SetDistance_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetDistance(__Params->entityId, __Params->max);
	}

	// Token: 0x06016A95 RID: 92821 RVA: 0x0069EE4E File Offset: 0x0069D04E
	protected unsafe static void __CPPCALL_GetAllMovementHistory_Implementation(TsGameplayBlueprintFunctionLibrary.__GetAllMovementHistory_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetAllMovementHistory(__Params->entityId));
	}

	// Token: 0x06016A96 RID: 92822 RVA: 0x0069EE67 File Offset: 0x0069D067
	protected unsafe static void __CPPCALL_ResetBaseValueLocal_Implementation(TsGameplayBlueprintFunctionLibrary.__ResetBaseValueLocal_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ResetBaseValueLocal(__Params->entityId, __Params->id, __Params->val);
	}

	// Token: 0x06016A97 RID: 92823 RVA: 0x0069EE80 File Offset: 0x0069D080
	protected unsafe static void __CPPCALL_GetAttributeCurrentValue_Implementation(TsGameplayBlueprintFunctionLibrary.__GetAttributeCurrentValue_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetAttributeCurrentValue(__Params->entityId, __Params->attributeId);
	}

	// Token: 0x06016A98 RID: 92824 RVA: 0x0069EE99 File Offset: 0x0069D099
	protected unsafe static void __CPPCALL_GetAttributeBaseValue_Implementation(TsGameplayBlueprintFunctionLibrary.__GetAttributeBaseValue_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetAttributeBaseValue(__Params->entityId, __Params->attributeId);
	}

	// Token: 0x06016A99 RID: 92825 RVA: 0x0069EEB2 File Offset: 0x0069D0B2
	protected unsafe static void __CPPCALL_SetRageModeId_Implementation(TsGameplayBlueprintFunctionLibrary.__SetRageModeId_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetRageModeId(__Params->entityId, __Params->id);
	}

	// Token: 0x06016A9A RID: 92826 RVA: 0x0069EEC5 File Offset: 0x0069D0C5
	protected unsafe static void __CPPCALL_SetHardnessModeId_Implementation(TsGameplayBlueprintFunctionLibrary.__SetHardnessModeId_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetHardnessModeId(__Params->entityId, __Params->id);
	}

	// Token: 0x06016A9B RID: 92827 RVA: 0x0069EED8 File Offset: 0x0069D0D8
	protected unsafe static void __CPPCALL_OnHit_Implementation(TsGameplayBlueprintFunctionLibrary.__OnHit_FunctionParams* __Params)
	{
		SHitInformation hitData = new SHitInformation(&__Params->hitData, true, true);
		TsGameplayBlueprintFunctionLibrary.OnHit(__Params->entityId, hitData);
	}

	// Token: 0x06016A9C RID: 92828 RVA: 0x0069EF00 File Offset: 0x0069D100
	protected unsafe static void __CPPCALL_SetBeHitIgnoreRotate_Implementation(TsGameplayBlueprintFunctionLibrary.__SetBeHitIgnoreRotate_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetBeHitIgnoreRotate(__Params->entityId, __Params->ignoreRotate);
	}

	// Token: 0x06016A9D RID: 92829 RVA: 0x0069EF13 File Offset: 0x0069D113
	protected unsafe static void __CPPCALL_CheckHasPart_Implementation(TsGameplayBlueprintFunctionLibrary.__CheckHasPart_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.CheckHasPart(__Params->entityId);
	}

	// Token: 0x06016A9E RID: 92830 RVA: 0x0069EF26 File Offset: 0x0069D126
	protected unsafe static void __CPPCALL_GetPartRemainedLife_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPartRemainedLife_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetPartRemainedLife(__Params->entityId, __Params->tag);
	}

	// Token: 0x06016A9F RID: 92831 RVA: 0x0069EF3F File Offset: 0x0069D13F
	protected unsafe static void __CPPCALL_ResetPartLife_Implementation(TsGameplayBlueprintFunctionLibrary.__ResetPartLife_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ResetPartLife(__Params->entityId, __Params->tag);
	}

	// Token: 0x06016AA0 RID: 92832 RVA: 0x0069EF52 File Offset: 0x0069D152
	protected unsafe static void __CPPCALL_ActiveStiff_Implementation(TsGameplayBlueprintFunctionLibrary.__ActiveStiff_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ActiveStiff(__Params->entityId);
	}

	// Token: 0x06016AA1 RID: 92833 RVA: 0x0069EF5F File Offset: 0x0069D15F
	protected unsafe static void __CPPCALL_DeActiveStiff_Implementation(TsGameplayBlueprintFunctionLibrary.__DeActiveStiff_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.DeActiveStiff(__Params->entityId);
	}

	// Token: 0x06016AA2 RID: 92834 RVA: 0x0069EF6C File Offset: 0x0069D16C
	protected unsafe static void __CPPCALL_GetAcceptedNewBeHitAndReset_Implementation(TsGameplayBlueprintFunctionLibrary.__GetAcceptedNewBeHitAndReset_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetAcceptedNewBeHitAndReset(__Params->entityId);
	}

	// Token: 0x06016AA3 RID: 92835 RVA: 0x0069EF7F File Offset: 0x0069D17F
	protected unsafe static void __CPPCALL_GetEnterFkAndReset_Implementation(TsGameplayBlueprintFunctionLibrary.__GetEnterFkAndReset_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetEnterFkAndReset(__Params->entityId);
	}

	// Token: 0x06016AA4 RID: 92836 RVA: 0x0069EF92 File Offset: 0x0069D192
	protected unsafe static void __CPPCALL_IsStiff_Implementation(TsGameplayBlueprintFunctionLibrary.__IsStiff_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.IsStiff(__Params->entityId);
	}

	// Token: 0x06016AA5 RID: 92837 RVA: 0x0069EFA5 File Offset: 0x0069D1A5
	protected unsafe static void __CPPCALL_GetRageModeId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetRageModeId_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetRageModeId(__Params->entityId);
	}

	// Token: 0x06016AA6 RID: 92838 RVA: 0x0069EFB8 File Offset: 0x0069D1B8
	protected unsafe static void __CPPCALL_GetHardnessModeId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetHardnessModeId_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetHardnessModeId(__Params->entityId);
	}

	// Token: 0x06016AA7 RID: 92839 RVA: 0x0069EFCB File Offset: 0x0069D1CB
	protected unsafe static void __CPPCALL_GetBeHitBone_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBeHitBone_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBeHitBone(__Params->entityId);
	}

	// Token: 0x06016AA8 RID: 92840 RVA: 0x0069EFDE File Offset: 0x0069D1DE
	protected unsafe static void __CPPCALL_GetToughDecreaseValue_Implementation(TsGameplayBlueprintFunctionLibrary.__GetToughDecreaseValue_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetToughDecreaseValue(__Params->entityId);
	}

	// Token: 0x06016AA9 RID: 92841 RVA: 0x0069EFF1 File Offset: 0x0069D1F1
	protected unsafe static void __CPPCALL_GetCounterAttackInfoInternal_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCounterAttackInfoInternal_FunctionParams* __Params)
	{
		UScriptStructStackOnlyPtr nativeUStructPtr = SCounterAttack.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SCounterAttack counterAttackInfoInternal = TsGameplayBlueprintFunctionLibrary.GetCounterAttackInfoInternal(__Params->entityId);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (counterAttackInfoInternal != null) ? counterAttackInfoInternal.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x06016AAA RID: 92842 RVA: 0x0069F01E File Offset: 0x0069D21E
	protected unsafe static void __CPPCALL_GetVisionCounterAttackInfoInternal_Implementation(TsGameplayBlueprintFunctionLibrary.__GetVisionCounterAttackInfoInternal_FunctionParams* __Params)
	{
		UScriptStructStackOnlyPtr nativeUStructPtr = SVisionCounterAttack.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SVisionCounterAttack visionCounterAttackInfoInternal = TsGameplayBlueprintFunctionLibrary.GetVisionCounterAttackInfoInternal(__Params->entityId);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (visionCounterAttackInfoInternal != null) ? visionCounterAttackInfoInternal.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x06016AAB RID: 92843 RVA: 0x0069F04B File Offset: 0x0069D24B
	protected unsafe static void __CPPCALL_GetBeHitTime_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBeHitTime_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBeHitTime(__Params->entityId);
	}

	// Token: 0x06016AAC RID: 92844 RVA: 0x0069F05E File Offset: 0x0069D25E
	protected unsafe static void __CPPCALL_GetBeHitAnim_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBeHitAnim_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsGameplayBlueprintFunctionLibrary.GetBeHitAnim(__Params->entityId);
	}

	// Token: 0x06016AAD RID: 92845 RVA: 0x0069F073 File Offset: 0x0069D273
	protected unsafe static void __CPPCALL_GetEnterFk_Implementation(TsGameplayBlueprintFunctionLibrary.__GetEnterFk_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetEnterFk(__Params->entityId);
	}

	// Token: 0x06016AAE RID: 92846 RVA: 0x0069F086 File Offset: 0x0069D286
	protected unsafe static void __CPPCALL_GetBeHitDirect_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBeHitDirect_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBeHitDirect(__Params->entityId);
	}

	// Token: 0x06016AAF RID: 92847 RVA: 0x0069F099 File Offset: 0x0069D299
	protected unsafe static void __CPPCALL_GetBeHitLocation_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBeHitLocation_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBeHitLocation(__Params->entityId);
	}

	// Token: 0x06016AB0 RID: 92848 RVA: 0x0069F0AC File Offset: 0x0069D2AC
	protected unsafe static void __CPPCALL_AddCheckBuffList_Implementation(TsGameplayBlueprintFunctionLibrary.__AddCheckBuffList_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.AddCheckBuffList(__Params->entityId, __Params->addValue);
	}

	// Token: 0x06016AB1 RID: 92849 RVA: 0x0069F0BF File Offset: 0x0069D2BF
	protected unsafe static void __CPPCALL_ClearCheckBuffList_Implementation(TsGameplayBlueprintFunctionLibrary.__ClearCheckBuffList_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ClearCheckBuffList(__Params->entityId);
	}

	// Token: 0x06016AB2 RID: 92850 RVA: 0x0069F0CC File Offset: 0x0069D2CC
	protected unsafe static void __CPPCALL_CounterAttackEnd_Implementation(TsGameplayBlueprintFunctionLibrary.__CounterAttackEnd_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.CounterAttackEnd(__Params->entityId);
	}

	// Token: 0x06016AB3 RID: 92851 RVA: 0x0069F0D9 File Offset: 0x0069D2D9
	protected unsafe static void __CPPCALL_VisionCounterAttackEnd_Implementation(TsGameplayBlueprintFunctionLibrary.__VisionCounterAttackEnd_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.VisionCounterAttackEnd(__Params->entityId);
	}

	// Token: 0x06016AB4 RID: 92852 RVA: 0x0069F0E6 File Offset: 0x0069D2E6
	protected unsafe static void __CPPCALL_SetCounterAttackEndTime_Implementation(TsGameplayBlueprintFunctionLibrary.__SetCounterAttackEndTime_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetCounterAttackEndTime(__Params->entityId, __Params->baseTime);
	}

	// Token: 0x06016AB5 RID: 92853 RVA: 0x0069F0F9 File Offset: 0x0069D2F9
	protected unsafe static void __CPPCALL_IsTriggerCounterAttack_Implementation(TsGameplayBlueprintFunctionLibrary.__IsTriggerCounterAttack_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.IsTriggerCounterAttack(__Params->entityId);
	}

	// Token: 0x06016AB6 RID: 92854 RVA: 0x0069F10C File Offset: 0x0069D30C
	protected unsafe static void __CPPCALL_ResetTarget_Implementation(TsGameplayBlueprintFunctionLibrary.__ResetTarget_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ResetTarget(__Params->entityId);
	}

	// Token: 0x06016AB7 RID: 92855 RVA: 0x0069F11C File Offset: 0x0069D31C
	protected unsafe static void __CPPCALL_SetShowTarget_Implementation(TsGameplayBlueprintFunctionLibrary.__SetShowTarget_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor);
		TsGameplayBlueprintFunctionLibrary.SetShowTarget(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06016AB8 RID: 92856 RVA: 0x0069F141 File Offset: 0x0069D341
	protected unsafe static void __CPPCALL_ExitLockDirection_Implementation(TsGameplayBlueprintFunctionLibrary.__ExitLockDirection_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ExitLockDirection(__Params->entityId);
	}

	// Token: 0x06016AB9 RID: 92857 RVA: 0x0069F14E File Offset: 0x0069D34E
	protected unsafe static void __CPPCALL_EnterLockDirection_Implementation(TsGameplayBlueprintFunctionLibrary.__EnterLockDirection_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EnterLockDirection(__Params->entityId);
	}

	// Token: 0x06016ABA RID: 92858 RVA: 0x0069F15B File Offset: 0x0069D35B
	protected unsafe static void __CPPCALL_GetCurrentTarget_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCurrentTarget_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		TsBaseCharacter currentTarget = TsGameplayBlueprintFunctionLibrary.GetCurrentTarget(__Params->entityId);
		ptr = ((currentTarget != null) ? currentTarget.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016ABB RID: 92859 RVA: 0x0069F17D File Offset: 0x0069D37D
	protected unsafe static void __CPPCALL_SetLockOnDebugLine_Implementation(TsGameplayBlueprintFunctionLibrary.__SetLockOnDebugLine_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetLockOnDebugLine(__Params->entityId, __Params->isShow);
	}

	// Token: 0x06016ABC RID: 92860 RVA: 0x0069F190 File Offset: 0x0069D390
	protected unsafe static void __CPPCALL_ManipulateValid_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateValid_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.ManipulateValid(__Params->entityId);
	}

	// Token: 0x06016ABD RID: 92861 RVA: 0x0069F1A3 File Offset: 0x0069D3A3
	protected unsafe static void __CPPCALL_ManipulateGetDrawTarget_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateGetDrawTarget_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor aactor = TsGameplayBlueprintFunctionLibrary.ManipulateGetDrawTarget(__Params->entityId);
		ptr = ((aactor != null) ? aactor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016ABE RID: 92862 RVA: 0x0069F1C5 File Offset: 0x0069D3C5
	protected unsafe static void __CPPCALL_ManipulateGetCastTarget_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateGetCastTarget_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor aactor = TsGameplayBlueprintFunctionLibrary.ManipulateGetCastTarget(__Params->entityId);
		ptr = ((aactor != null) ? aactor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016ABF RID: 92863 RVA: 0x0069F1E7 File Offset: 0x0069D3E7
	protected unsafe static void __CPPCALL_ManipulateGetDrawTargetChantTime_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateGetDrawTargetChantTime_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.ManipulateGetDrawTargetChantTime(__Params->entityId);
	}

	// Token: 0x06016AC0 RID: 92864 RVA: 0x0069F1FC File Offset: 0x0069D3FC
	protected unsafe static void __CPPCALL_ManipulateChant_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateChant_FunctionParams* __Params)
	{
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.ManipulateChant(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06016AC1 RID: 92865 RVA: 0x0069F227 File Offset: 0x0069D427
	protected unsafe static void __CPPCALL_ManipulateDraw_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateDraw_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.ManipulateDraw(__Params->entityId);
	}

	// Token: 0x06016AC2 RID: 92866 RVA: 0x0069F23A File Offset: 0x0069D43A
	protected unsafe static void __CPPCALL_ManipulateCast_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateCast_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.ManipulateCast(__Params->entityId, __Params->direction);
	}

	// Token: 0x06016AC3 RID: 92867 RVA: 0x0069F253 File Offset: 0x0069D453
	protected unsafe static void __CPPCALL_ManipulateReset_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateReset_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ManipulateReset(__Params->entityId);
	}

	// Token: 0x06016AC4 RID: 92868 RVA: 0x0069F260 File Offset: 0x0069D460
	protected unsafe static void __CPPCALL_ManipulateChangeToProjectileState_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateChangeToProjectileState_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.ManipulateChangeToProjectileState(__Params->entityId);
	}

	// Token: 0x06016AC5 RID: 92869 RVA: 0x0069F273 File Offset: 0x0069D473
	protected unsafe static void __CPPCALL_ManipulateChangeToNormalState_Implementation(TsGameplayBlueprintFunctionLibrary.__ManipulateChangeToNormalState_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.ManipulateChangeToNormalState(__Params->entityId);
	}

	// Token: 0x06016AC6 RID: 92870 RVA: 0x0069F286 File Offset: 0x0069D486
	protected unsafe static void __CPPCALL_GetHoldingActor_Implementation(TsGameplayBlueprintFunctionLibrary.__GetHoldingActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor holdingActor = TsGameplayBlueprintFunctionLibrary.GetHoldingActor(__Params->entityId);
		ptr = ((holdingActor != null) ? holdingActor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016AC7 RID: 92871 RVA: 0x0069F2A8 File Offset: 0x0069D4A8
	protected unsafe static void __CPPCALL_HasHoldingActor_Implementation(TsGameplayBlueprintFunctionLibrary.__HasHoldingActor_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.HasHoldingActor(__Params->entityId);
	}

	// Token: 0x06016AC8 RID: 92872 RVA: 0x0069F2BB File Offset: 0x0069D4BB
	protected unsafe static void __CPPCALL_SetDebugDraw_Implementation(TsGameplayBlueprintFunctionLibrary.__SetDebugDraw_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetDebugDraw(__Params->entityId, __Params->isActive);
	}

	// Token: 0x06016AC9 RID: 92873 RVA: 0x0069F2CE File Offset: 0x0069D4CE
	protected unsafe static void __CPPCALL_ExtraAction_Implementation(TsGameplayBlueprintFunctionLibrary.__ExtraAction_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ExtraAction(__Params->entityId);
	}

	// Token: 0x06016ACA RID: 92874 RVA: 0x0069F2DB File Offset: 0x0069D4DB
	protected unsafe static void __CPPCALL_SetQtePosition_Implementation(TsGameplayBlueprintFunctionLibrary.__SetQtePosition_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetQtePosition(__Params->entityId, __Params->rotate, __Params->length, __Params->height, __Params->referenceTarget, __Params->adjustWithMonster, __Params->addHeight, __Params->qteType);
	}

	// Token: 0x06016ACB RID: 92875 RVA: 0x0069F312 File Offset: 0x0069D512
	protected unsafe static void __CPPCALL_GetGoBattleActor_Implementation(TsGameplayBlueprintFunctionLibrary.__GetGoBattleActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		TsBaseCharacter goBattleActor = TsGameplayBlueprintFunctionLibrary.GetGoBattleActor(__Params->entityId);
		ptr = ((goBattleActor != null) ? goBattleActor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016ACC RID: 92876 RVA: 0x0069F334 File Offset: 0x0069D534
	protected unsafe static void __CPPCALL_GetDtSkillInfo_Implementation(TsGameplayBlueprintFunctionLibrary.__GetDtSkillInfo_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UDataTable dtSkillInfo = TsGameplayBlueprintFunctionLibrary.GetDtSkillInfo(__Params->entityId);
		ptr = ((dtSkillInfo != null) ? dtSkillInfo.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016ACD RID: 92877 RVA: 0x0069F358 File Offset: 0x0069D558
	protected unsafe static void __CPPCALL_GetDtSkillInfoMapForDebug_Implementation(TsGameplayBlueprintFunctionLibrary.__GetDtSkillInfoMapForDebug_FunctionParams* __Params)
	{
		TMap<ECharacterLoadType, UDataTable> dtSkillInfoMapForDebug = TsGameplayBlueprintFunctionLibrary.GetDtSkillInfoMapForDebug(__Params->entityId);
		if (dtSkillInfoMapForDebug == null)
		{
			return;
		}
		dtSkillInfoMapForDebug.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06016ACE RID: 92878 RVA: 0x0069F38A File Offset: 0x0069D58A
	protected unsafe static void __CPPCALL_GetLastActivateSkillTime_Implementation(TsGameplayBlueprintFunctionLibrary.__GetLastActivateSkillTime_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetLastActivateSkillTime(__Params->entityId);
	}

	// Token: 0x06016ACF RID: 92879 RVA: 0x0069F39D File Offset: 0x0069D59D
	protected unsafe static void __CPPCALL_SetLastActivateSkillTime_Implementation(TsGameplayBlueprintFunctionLibrary.__SetLastActivateSkillTime_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetLastActivateSkillTime(__Params->entityId, __Params->time);
	}

	// Token: 0x06016AD0 RID: 92880 RVA: 0x0069F3B0 File Offset: 0x0069D5B0
	protected unsafe static void __CPPCALL_GetSkillElevationAngle_Implementation(TsGameplayBlueprintFunctionLibrary.__GetSkillElevationAngle_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetSkillElevationAngle(__Params->entityId);
	}

	// Token: 0x06016AD1 RID: 92881 RVA: 0x0069F3C3 File Offset: 0x0069D5C3
	protected unsafe static void __CPPCALL_SetSkillElevationAngle_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSkillElevationAngle_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetSkillElevationAngle(__Params->entityId, __Params->angle);
	}

	// Token: 0x06016AD2 RID: 92882 RVA: 0x0069F3D6 File Offset: 0x0069D5D6
	protected unsafe static void __CPPCALL_CurrentSkillId_Implementation(TsGameplayBlueprintFunctionLibrary.__CurrentSkillId_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.CurrentSkillId(__Params->entityId));
	}

	// Token: 0x06016AD3 RID: 92883 RVA: 0x0069F3EF File Offset: 0x0069D5EF
	protected unsafe static void __CPPCALL_CurrentPriority_Implementation(TsGameplayBlueprintFunctionLibrary.__CurrentPriority_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.CurrentPriority(__Params->entityId);
	}

	// Token: 0x06016AD4 RID: 92884 RVA: 0x0069F402 File Offset: 0x0069D602
	protected unsafe static void __CPPCALL_SetCurrentPriority_Implementation(TsGameplayBlueprintFunctionLibrary.__SetCurrentPriority_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetCurrentPriority(__Params->entityId, __Params->priority);
	}

	// Token: 0x06016AD5 RID: 92885 RVA: 0x0069F418 File Offset: 0x0069D618
	protected unsafe static void __CPPCALL_HasAbility_Implementation(TsGameplayBlueprintFunctionLibrary.__HasAbility_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.HasAbility(__Params->entityId, skillId);
	}

	// Token: 0x06016AD6 RID: 92886 RVA: 0x0069F444 File Offset: 0x0069D644
	protected unsafe static void __CPPCALL_GetSkillInfo_Implementation(TsGameplayBlueprintFunctionLibrary.__GetSkillInfo_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		UScriptStructStackOnlyPtr nativeUStructPtr = SSkillInfo.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SSkillInfo skillInfo = TsGameplayBlueprintFunctionLibrary.GetSkillInfo(__Params->entityId, skillId);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (skillInfo != null) ? skillInfo.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x06016AD7 RID: 92887 RVA: 0x0069F48C File Offset: 0x0069D68C
	protected unsafe static void __CPPCALL_SetSkillPriority_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSkillPriority_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		TsGameplayBlueprintFunctionLibrary.SetSkillPriority(__Params->entityId, skillId, __Params->priority);
	}

	// Token: 0x06016AD8 RID: 92888 RVA: 0x0069F4B8 File Offset: 0x0069D6B8
	protected unsafe static void __CPPCALL_EndSkill_Implementation(TsGameplayBlueprintFunctionLibrary.__EndSkill_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		TsGameplayBlueprintFunctionLibrary.EndSkill(__Params->entityId, skillId, __Params->isSyn, __Params->isNotEnd);
	}

	// Token: 0x06016AD9 RID: 92889 RVA: 0x0069F4EC File Offset: 0x0069D6EC
	protected unsafe static void __CPPCALL_BeginSkill_Implementation(TsGameplayBlueprintFunctionLibrary.__BeginSkill_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->target);
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.BeginSkill(__Params->entityId, __Params->skillId, __Params->isSyn, orCreateUObjectByNativePointer, __Params->socketName);
	}

	// Token: 0x06016ADA RID: 92890 RVA: 0x0069F52C File Offset: 0x0069D72C
	protected unsafe static void __CPPCALL_BeginSkillAsync_Implementation(TsGameplayBlueprintFunctionLibrary.__BeginSkillAsync_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->target);
		UKuroBooleanEventBinder orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		TsGameplayBlueprintFunctionLibrary.BeginSkillAsync(__Params->entityId, __Params->skillId, orCreateUObjectByNativePointer, __Params->socketName, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06016ADB RID: 92891 RVA: 0x0069F56C File Offset: 0x0069D76C
	protected unsafe static void __CPPCALL_SkillBehaviorBegin_Implementation(TsGameplayBlueprintFunctionLibrary.__SkillBehaviorBegin_FunctionParams* __Params)
	{
		GA_Base_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<GA_Base_C>(__Params->ga);
		SSkillBehaviorAction action = new SSkillBehaviorAction(&__Params->action, true, true);
		TsGameplayBlueprintFunctionLibrary.SkillBehaviorBegin(__Params->entityId, orCreateUObjectByNativePointer, action);
	}

	// Token: 0x06016ADC RID: 92892 RVA: 0x0069F5A4 File Offset: 0x0069D7A4
	protected unsafe static void __CPPCALL_GetLocationByAction_Implementation(TsGameplayBlueprintFunctionLibrary.__GetLocationByAction_FunctionParams* __Params)
	{
		GA_Base_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<GA_Base_C>(__Params->ga);
		SSkillBehaviorAction action = new SSkillBehaviorAction(&__Params->action, true, true);
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetLocationByAction(__Params->entityId, orCreateUObjectByNativePointer, action);
	}

	// Token: 0x06016ADD RID: 92893 RVA: 0x0069F5E0 File Offset: 0x0069D7E0
	protected unsafe static void __CPPCALL_GetRotationByAction_Implementation(TsGameplayBlueprintFunctionLibrary.__GetRotationByAction_FunctionParams* __Params)
	{
		GA_Base_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<GA_Base_C>(__Params->ga);
		SSkillBehaviorAction action = new SSkillBehaviorAction(&__Params->action, true, true);
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetRotationByAction(__Params->entityId, orCreateUObjectByNativePointer, action);
	}

	// Token: 0x06016ADE RID: 92894 RVA: 0x0069F61C File Offset: 0x0069D81C
	protected unsafe static void __CPPCALL_SkillBehaviorSatisfy_Implementation(TsGameplayBlueprintFunctionLibrary.__SkillBehaviorSatisfy_FunctionParams* __Params)
	{
		GA_Base_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<GA_Base_C>(__Params->ga);
		SSkillBehaviorCondition condition = new SSkillBehaviorCondition(&__Params->condition, true, true);
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.SkillBehaviorSatisfy(__Params->entityId, orCreateUObjectByNativePointer, condition);
	}

	// Token: 0x06016ADF RID: 92895 RVA: 0x0069F657 File Offset: 0x0069D857
	protected unsafe static void __CPPCALL_GetSkillTarget_Implementation(TsGameplayBlueprintFunctionLibrary.__GetSkillTarget_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor skillTarget = TsGameplayBlueprintFunctionLibrary.GetSkillTarget(__Params->entityId);
		ptr = ((skillTarget != null) ? skillTarget.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016AE0 RID: 92896 RVA: 0x0069F67C File Offset: 0x0069D87C
	protected unsafe static void __CPPCALL_SetSkillTarget_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSkillTarget_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->target);
		TsGameplayBlueprintFunctionLibrary.SetSkillTarget(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06016AE1 RID: 92897 RVA: 0x0069F6A4 File Offset: 0x0069D8A4
	protected unsafe static void __CPPCALL_LockOnTargetAndSetShow_Implementation(TsGameplayBlueprintFunctionLibrary.__LockOnTargetAndSetShow_FunctionParams* __Params)
	{
		SSkillTarget config = new SSkillTarget(&__Params->config, true, true);
		TsGameplayBlueprintFunctionLibrary.LockOnTargetAndSetShow(__Params->entityId, config);
	}

	// Token: 0x06016AE2 RID: 92898 RVA: 0x0069F6CC File Offset: 0x0069D8CC
	protected unsafe static void __CPPCALL_IsHasInputDir_Implementation(TsGameplayBlueprintFunctionLibrary.__IsHasInputDir_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.IsHasInputDir(__Params->entityId);
	}

	// Token: 0x06016AE3 RID: 92899 RVA: 0x0069F6DF File Offset: 0x0069D8DF
	protected unsafe static void __CPPCALL_GetSkillIdWithGroupId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetSkillIdWithGroupId_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetSkillIdWithGroupId(__Params->entityId, __Params->groupId));
	}

	// Token: 0x06016AE4 RID: 92900 RVA: 0x0069F6FE File Offset: 0x0069D8FE
	protected unsafe static void __CPPCALL_GetSkillAcceptInput_Implementation(TsGameplayBlueprintFunctionLibrary.__GetSkillAcceptInput_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetSkillAcceptInput(__Params->entityId);
	}

	// Token: 0x06016AE5 RID: 92901 RVA: 0x0069F711 File Offset: 0x0069D911
	protected unsafe static void __CPPCALL_SetSkillAcceptInput_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSkillAcceptInput_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetSkillAcceptInput(__Params->entityId, __Params->skillAcceptInput);
	}

	// Token: 0x06016AE6 RID: 92902 RVA: 0x0069F724 File Offset: 0x0069D924
	protected unsafe static void __CPPCALL_SetCommonSkillCanBeInterrupt_Implementation(TsGameplayBlueprintFunctionLibrary.__SetCommonSkillCanBeInterrupt_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetCommonSkillCanBeInterrupt(__Params->entityId, __Params->canBeInterrupt);
	}

	// Token: 0x06016AE7 RID: 92903 RVA: 0x0069F737 File Offset: 0x0069D937
	protected unsafe static void __CPPCALL_GetCommonSkillCanBeInterrupt_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCommonSkillCanBeInterrupt_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetCommonSkillCanBeInterrupt(__Params->entityId);
	}

	// Token: 0x06016AE8 RID: 92904 RVA: 0x0069F74C File Offset: 0x0069D94C
	protected unsafe static void __CPPCALL_OnActivateAbility_Implementation(TsGameplayBlueprintFunctionLibrary.__OnActivateAbility_FunctionParams* __Params)
	{
		UGameplayAbility orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameplayAbility>(__Params->ga);
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.OnActivateAbility(__Params->entityId, orCreateUObjectByNativePointer, __Params->isCommitSuccess);
	}

	// Token: 0x06016AE9 RID: 92905 RVA: 0x0069F780 File Offset: 0x0069D980
	protected unsafe static void __CPPCALL_OnEndAbility_Implementation(TsGameplayBlueprintFunctionLibrary.__OnEndAbility_FunctionParams* __Params)
	{
		UGameplayAbility orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameplayAbility>(__Params->ga);
		TsGameplayBlueprintFunctionLibrary.OnEndAbility(__Params->entityId, orCreateUObjectByNativePointer, __Params->wasCancelled);
	}

	// Token: 0x06016AEA RID: 92906 RVA: 0x0069F7AC File Offset: 0x0069D9AC
	protected unsafe static void __CPPCALL_GetPriority_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPriority_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetPriority(__Params->entityId, skillId);
	}

	// Token: 0x06016AEB RID: 92907 RVA: 0x0069F7D8 File Offset: 0x0069D9D8
	protected unsafe static void __CPPCALL_GetActivePriority_Implementation(TsGameplayBlueprintFunctionLibrary.__GetActivePriority_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetActivePriority(__Params->entityId, skillId);
	}

	// Token: 0x06016AEC RID: 92908 RVA: 0x0069F804 File Offset: 0x0069DA04
	protected unsafe static void __CPPCALL_GetSkillMontageInstance_Implementation(TsGameplayBlueprintFunctionLibrary.__GetSkillMontageInstance_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		ref IntPtr ptr = ref *(&__Params->__Result);
		UAnimMontage skillMontageInstance = TsGameplayBlueprintFunctionLibrary.GetSkillMontageInstance(__Params->entityId, skillId, __Params->index);
		ptr = ((skillMontageInstance != null) ? skillMontageInstance.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016AED RID: 92909 RVA: 0x0069F848 File Offset: 0x0069DA48
	protected unsafe static void __CPPCALL_GetSkillNeedPlayMontageIndex_Implementation(TsGameplayBlueprintFunctionLibrary.__GetSkillNeedPlayMontageIndex_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetSkillNeedPlayMontageIndex(__Params->entityId, skillId);
	}

	// Token: 0x06016AEE RID: 92910 RVA: 0x0069F874 File Offset: 0x0069DA74
	protected unsafe static void __CPPCALL_CreateSpecifiedTagPlayMontageAndWaitAbilityTask_Implementation(TsGameplayBlueprintFunctionLibrary.__CreateSpecifiedTagPlayMontageAndWaitAbilityTask_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.CreateSpecifiedTagPlayMontageAndWaitAbilityTask(BuiltinUtils.GetOrCreateUObjectByNativePointer<GA_Base_C>(__Params->gameplayAbility), __Params->checkHit, __Params->skeletalMeshComponentTag, __Params->montageIndex, __Params->startSection, __Params->startTimeSeconds, __Params->needTick, __Params->animRootMotionTranslationScale);
	}

	// Token: 0x06016AEF RID: 92911 RVA: 0x0069F8B0 File Offset: 0x0069DAB0
	protected unsafe static void __CPPCALL_SetSkillRotateLocation_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSkillRotateLocation_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetSkillRotateLocation(__Params->entityId, __Params->location);
	}

	// Token: 0x06016AF0 RID: 92912 RVA: 0x0069F8C3 File Offset: 0x0069DAC3
	protected unsafe static void __CPPCALL_SetSkillRotateDirect_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSkillRotateDirect_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetSkillRotateDirect(__Params->entityId, __Params->direct);
	}

	// Token: 0x06016AF1 RID: 92913 RVA: 0x0069F8D6 File Offset: 0x0069DAD6
	protected unsafe static void __CPPCALL_CallAnimBreakPoint_Implementation(TsGameplayBlueprintFunctionLibrary.__CallAnimBreakPoint_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.CallAnimBreakPoint(__Params->entityId);
	}

	// Token: 0x06016AF2 RID: 92914 RVA: 0x0069F8E3 File Offset: 0x0069DAE3
	protected unsafe static void __CPPCALL_RollingGround_Implementation(TsGameplayBlueprintFunctionLibrary.__RollingGround_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.RollingGround(__Params->entityId);
	}

	// Token: 0x06016AF3 RID: 92915 RVA: 0x0069F8F0 File Offset: 0x0069DAF0
	protected unsafe static void __CPPCALL_ActivateAbilityVision_Implementation(TsGameplayBlueprintFunctionLibrary.__ActivateAbilityVision_FunctionParams* __Params)
	{
		EVisionType visionType = (EVisionType)__Params->visionType;
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.ActivateAbilityVision(__Params->entityId, visionType);
	}

	// Token: 0x06016AF4 RID: 92916 RVA: 0x0069F918 File Offset: 0x0069DB18
	protected unsafe static void __CPPCALL_EndAbilityVision_Implementation(TsGameplayBlueprintFunctionLibrary.__EndAbilityVision_FunctionParams* __Params)
	{
		EVisionType visionType = (EVisionType)__Params->visionType;
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.EndAbilityVision(__Params->entityId, visionType);
	}

	// Token: 0x06016AF5 RID: 92917 RVA: 0x0069F940 File Offset: 0x0069DB40
	protected unsafe static void __CPPCALL_ActivateAbilityVisionPlayAudio_Implementation(TsGameplayBlueprintFunctionLibrary.__ActivateAbilityVisionPlayAudio_FunctionParams* __Params)
	{
		EVisionType visionType = (EVisionType)__Params->visionType;
		TsGameplayBlueprintFunctionLibrary.ActivateAbilityVisionPlayAudio(__Params->entityId, visionType);
	}

	// Token: 0x06016AF6 RID: 92918 RVA: 0x0069F960 File Offset: 0x0069DB60
	protected unsafe static void __CPPCALL_GetVisionIdList_Implementation(TsGameplayBlueprintFunctionLibrary.__GetVisionIdList_FunctionParams* __Params)
	{
		TArray<int> visionIdList = TsGameplayBlueprintFunctionLibrary.GetVisionIdList(__Params->entityId);
		if (visionIdList == null)
		{
			return;
		}
		visionIdList.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06016AF7 RID: 92919 RVA: 0x0069F992 File Offset: 0x0069DB92
	protected unsafe static void __CPPCALL_ExitMultiSkillStateOfMorphVision_Implementation(TsGameplayBlueprintFunctionLibrary.__ExitMultiSkillStateOfMorphVision_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ExitMultiSkillStateOfMorphVision(__Params->entityId);
	}

	// Token: 0x06016AF8 RID: 92920 RVA: 0x0069F99F File Offset: 0x0069DB9F
	protected unsafe static void __CPPCALL_SetKeepMultiSkillState_Implementation(TsGameplayBlueprintFunctionLibrary.__SetKeepMultiSkillState_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetKeepMultiSkillState(__Params->entityId, __Params->keepOnMorphEnd, __Params->keepOnGoDown);
	}

	// Token: 0x06016AF9 RID: 92921 RVA: 0x0069F9B8 File Offset: 0x0069DBB8
	protected unsafe static void __CPPCALL_SetEnableAttackInputActionOfMorphVision_Implementation(TsGameplayBlueprintFunctionLibrary.__SetEnableAttackInputActionOfMorphVision_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetEnableAttackInputActionOfMorphVision(__Params->entityId, __Params->bEnable);
	}

	// Token: 0x06016AFA RID: 92922 RVA: 0x0069F9CC File Offset: 0x0069DBCC
	protected unsafe static void __CPPCALL_GetVisionLevelList_Implementation(TsGameplayBlueprintFunctionLibrary.__GetVisionLevelList_FunctionParams* __Params)
	{
		TArray<int> visionLevelList = TsGameplayBlueprintFunctionLibrary.GetVisionLevelList(__Params->entityId);
		if (visionLevelList == null)
		{
			return;
		}
		visionLevelList.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06016AFB RID: 92923 RVA: 0x0069F9FE File Offset: 0x0069DBFE
	protected unsafe static void __CPPCALL_GetVisionSkillId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetVisionSkillId_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetVisionSkillId(__Params->entityId, __Params->visionId, __Params->level);
	}

	// Token: 0x06016AFC RID: 92924 RVA: 0x0069FA20 File Offset: 0x0069DC20
	protected unsafe static void __CPPCALL_InterruptSkill_Implementation(TsGameplayBlueprintFunctionLibrary.__InterruptSkill_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		TsGameplayBlueprintFunctionLibrary.InterruptSkill(__Params->entityId, skillId, __Params->isSyn);
	}

	// Token: 0x06016AFD RID: 92925 RVA: 0x0069FA4C File Offset: 0x0069DC4C
	protected unsafe static void __CPPCALL_DeleteSkills_Implementation(TsGameplayBlueprintFunctionLibrary.__DeleteSkills_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.DeleteSkills(__Params->entityId);
	}

	// Token: 0x06016AFE RID: 92926 RVA: 0x0069FA59 File Offset: 0x0069DC59
	protected unsafe static void __CPPCALL_GetCurrentMontageCorrespondingSkillId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCurrentMontageCorrespondingSkillId_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetCurrentMontageCorrespondingSkillId(__Params->entityId));
	}

	// Token: 0x06016AFF RID: 92927 RVA: 0x0069FA74 File Offset: 0x0069DC74
	protected unsafe static void __CPPCALL_SetSocketName_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSocketName_FunctionParams* __Params)
	{
		string socketName = FString.ToString((void*)(&__Params->socketName));
		TsGameplayBlueprintFunctionLibrary.SetSocketName(__Params->entityId, socketName);
	}

	// Token: 0x06016B00 RID: 92928 RVA: 0x0069FA9A File Offset: 0x0069DC9A
	protected unsafe static void __CPPCALL_GetSocketName_Implementation(TsGameplayBlueprintFunctionLibrary.__GetSocketName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetSocketName(__Params->entityId));
	}

	// Token: 0x06016B01 RID: 92929 RVA: 0x0069FAB4 File Offset: 0x0069DCB4
	protected unsafe static void __CPPCALL_GetPointTransform_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPointTransform_FunctionParams* __Params)
	{
		string boneName = FString.ToString((void*)(&__Params->boneName));
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetPointTransform(__Params->entityId, boneName);
	}

	// Token: 0x06016B02 RID: 92930 RVA: 0x0069FAE0 File Offset: 0x0069DCE0
	protected unsafe static void __CPPCALL_PlaySkillMontage2Server_Implementation(TsGameplayBlueprintFunctionLibrary.__PlaySkillMontage2Server_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		string startSection = FString.ToString((void*)(&__Params->startSection));
		TsGameplayBlueprintFunctionLibrary.PlaySkillMontage2Server(__Params->entityId, skillId, __Params->montageIndex, __Params->rate, startSection, __Params->startTimeSeconds);
	}

	// Token: 0x06016B03 RID: 92931 RVA: 0x0069FB28 File Offset: 0x0069DD28
	protected unsafe static void __CPPCALL_EndSkillMontage_Implementation(TsGameplayBlueprintFunctionLibrary.__EndSkillMontage_FunctionParams* __Params)
	{
		string skillId = FString.ToString((void*)(&__Params->skillId));
		TsGameplayBlueprintFunctionLibrary.EndSkillMontage(__Params->entityId, skillId, __Params->montageIndex);
	}

	// Token: 0x06016B04 RID: 92932 RVA: 0x0069FB54 File Offset: 0x0069DD54
	protected unsafe static void __CPPCALL_BeginAddMoveByInputDirect_Implementation(TsGameplayBlueprintFunctionLibrary.__BeginAddMoveByInputDirect_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.BeginAddMoveByInputDirect(__Params->entityId, __Params->maxSpeed, __Params->accelerationTime, __Params->decelerationTime, __Params->delayTime);
	}

	// Token: 0x06016B05 RID: 92933 RVA: 0x0069FB79 File Offset: 0x0069DD79
	protected unsafe static void __CPPCALL_BeginAbsoluteTimeStop_Implementation(TsGameplayBlueprintFunctionLibrary.__BeginAbsoluteTimeStop_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.BeginAbsoluteTimeStop(__Params->entityId, __Params->duration, __Params->stopMove);
	}

	// Token: 0x06016B06 RID: 92934 RVA: 0x0069FB92 File Offset: 0x0069DD92
	protected unsafe static void __CPPCALL_EndAbsoluteTimeStop_Implementation(TsGameplayBlueprintFunctionLibrary.__EndAbsoluteTimeStop_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EndAbsoluteTimeStop(__Params->entityId);
	}

	// Token: 0x06016B07 RID: 92935 RVA: 0x0069FB9F File Offset: 0x0069DD9F
	protected unsafe static void __CPPCALL_BeginTimeStopRequest_Implementation(TsGameplayBlueprintFunctionLibrary.__BeginTimeStopRequest_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.BeginTimeStopRequest(__Params->entityId, __Params->duration);
	}

	// Token: 0x06016B08 RID: 92936 RVA: 0x0069FBB2 File Offset: 0x0069DDB2
	protected unsafe static void __CPPCALL_EndTimeStopRequest_Implementation(TsGameplayBlueprintFunctionLibrary.__EndTimeStopRequest_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EndTimeStopRequest(__Params->entityId);
	}

	// Token: 0x06016B09 RID: 92937 RVA: 0x0069FBBF File Offset: 0x0069DDBF
	protected unsafe static void __CPPCALL_EndAddMoveByInputDirect_Implementation(TsGameplayBlueprintFunctionLibrary.__EndAddMoveByInputDirect_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EndAddMoveByInputDirect(__Params->entityId);
	}

	// Token: 0x06016B0A RID: 92938 RVA: 0x0069FBCC File Offset: 0x0069DDCC
	protected unsafe static void __CPPCALL_CanActivateFixHook_Implementation(TsGameplayBlueprintFunctionLibrary.__CanActivateFixHook_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.CanActivateFixHook(__Params->entityId);
	}

	// Token: 0x06016B0B RID: 92939 RVA: 0x0069FBDF File Offset: 0x0069DDDF
	protected unsafe static void __CPPCALL_FixHookTargetLocation_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookTargetLocation_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FixHookTargetLocation(__Params->entityId);
	}

	// Token: 0x06016B0C RID: 92940 RVA: 0x0069FBF4 File Offset: 0x0069DDF4
	protected unsafe static void __CPPCALL_FixHookTargetPathways_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookTargetPathways_FunctionParams* __Params)
	{
		TArray<FVectorDouble> tarray = TsGameplayBlueprintFunctionLibrary.FixHookTargetPathways(__Params->entityId);
		if (tarray == null)
		{
			return;
		}
		tarray.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06016B0D RID: 92941 RVA: 0x0069FC26 File Offset: 0x0069DE26
	protected unsafe static void __CPPCALL_FixHookTargetEnterPortalCapture_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookTargetEnterPortalCapture_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor aactor = TsGameplayBlueprintFunctionLibrary.FixHookTargetEnterPortalCapture(__Params->entityId);
		ptr = ((aactor != null) ? aactor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016B0E RID: 92942 RVA: 0x0069FC48 File Offset: 0x0069DE48
	protected unsafe static void __CPPCALL_FixHookTargetActor_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookTargetActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor aactor = TsGameplayBlueprintFunctionLibrary.FixHookTargetActor(__Params->entityId);
		ptr = ((aactor != null) ? aactor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016B0F RID: 92943 RVA: 0x0069FC6A File Offset: 0x0069DE6A
	protected unsafe static void __CPPCALL_FixHookTargetIsSuiGuangType_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookTargetIsSuiGuangType_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FixHookTargetIsSuiGuangType(__Params->entityId);
	}

	// Token: 0x06016B10 RID: 92944 RVA: 0x0069FC7D File Offset: 0x0069DE7D
	protected unsafe static void __CPPCALL_GetHookTargetType_Implementation(TsGameplayBlueprintFunctionLibrary.__GetHookTargetType_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsGameplayBlueprintFunctionLibrary.GetHookTargetType(__Params->entityId);
	}

	// Token: 0x06016B11 RID: 92945 RVA: 0x0069FC92 File Offset: 0x0069DE92
	protected unsafe static void __CPPCALL_FixHookTargetForward_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookTargetForward_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FixHookTargetForward(__Params->entityId);
	}

	// Token: 0x06016B12 RID: 92946 RVA: 0x0069FCA5 File Offset: 0x0069DEA5
	protected unsafe static void __CPPCALL_NextFixHookTargetLocation_Implementation(TsGameplayBlueprintFunctionLibrary.__NextFixHookTargetLocation_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.NextFixHookTargetLocation(__Params->entityId);
	}

	// Token: 0x06016B13 RID: 92947 RVA: 0x0069FCB8 File Offset: 0x0069DEB8
	protected unsafe static void __CPPCALL_FixHookTargetInheritSpeed_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookTargetInheritSpeed_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FixHookTargetInheritSpeed(__Params->entityId);
	}

	// Token: 0x06016B14 RID: 92948 RVA: 0x0069FCCB File Offset: 0x0069DECB
	protected unsafe static void __CPPCALL_FixHookTargetIsClimb_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookTargetIsClimb_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FixHookTargetIsClimb(__Params->entityId);
	}

	// Token: 0x06016B15 RID: 92949 RVA: 0x0069FCDE File Offset: 0x0069DEDE
	protected unsafe static void __CPPCALL_SetIsHookEndByInterrupt_Implementation(TsGameplayBlueprintFunctionLibrary.__SetIsHookEndByInterrupt_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetIsHookEndByInterrupt(__Params->entityId, __Params->isInterrupt);
	}

	// Token: 0x06016B16 RID: 92950 RVA: 0x0069FCF1 File Offset: 0x0069DEF1
	protected unsafe static void __CPPCALL_FixHookIsSummitPoint_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookIsSummitPoint_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FixHookIsSummitPoint(__Params->entityId);
	}

	// Token: 0x06016B17 RID: 92951 RVA: 0x0069FD04 File Offset: 0x0069DF04
	protected unsafe static void __CPPCALL_FixHookIsNormalPoint_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookIsNormalPoint_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FixHookIsNormalPoint(__Params->entityId);
	}

	// Token: 0x06016B18 RID: 92952 RVA: 0x0069FD17 File Offset: 0x0069DF17
	protected unsafe static void __CPPCALL_GetHookOverrideSpeed_Implementation(TsGameplayBlueprintFunctionLibrary.__GetHookOverrideSpeed_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetHookOverrideSpeed(__Params->entityId);
	}

	// Token: 0x06016B19 RID: 92953 RVA: 0x0069FD2A File Offset: 0x0069DF2A
	protected unsafe static void __CPPCALL_FixHookIsGravityPoint_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookIsGravityPoint_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FixHookIsGravityPoint(__Params->entityId);
	}

	// Token: 0x06016B1A RID: 92954 RVA: 0x0069FD3D File Offset: 0x0069DF3D
	protected unsafe static void __CPPCALL_KiteHookSupportSwitchMidway_Implementation(TsGameplayBlueprintFunctionLibrary.__KiteHookSupportSwitchMidway_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.KiteHookSupportSwitchMidway(__Params->entityId);
	}

	// Token: 0x06016B1B RID: 92955 RVA: 0x0069FD50 File Offset: 0x0069DF50
	protected unsafe static void __CPPCALL_FixHookTargetEntityId_Implementation(TsGameplayBlueprintFunctionLibrary.__FixHookTargetEntityId_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FixHookTargetEntityId(__Params->entityId);
	}

	// Token: 0x06016B1C RID: 92956 RVA: 0x0069FD63 File Offset: 0x0069DF63
	protected unsafe static void __CPPCALL_SlashHookPointHasLookAtConfig_Implementation(TsGameplayBlueprintFunctionLibrary.__SlashHookPointHasLookAtConfig_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.SlashHookPointHasLookAtConfig(__Params->entityId);
	}

	// Token: 0x06016B1D RID: 92957 RVA: 0x0069FD76 File Offset: 0x0069DF76
	protected unsafe static void __CPPCALL_SlashHookPointCharacterLookAtPoint_Implementation(TsGameplayBlueprintFunctionLibrary.__SlashHookPointCharacterLookAtPoint_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.SlashHookPointCharacterLookAtPoint(__Params->entityId);
	}

	// Token: 0x06016B1E RID: 92958 RVA: 0x0069FD89 File Offset: 0x0069DF89
	protected unsafe static void __CPPCALL_SlashHookPointIsTakeOverCamera_Implementation(TsGameplayBlueprintFunctionLibrary.__SlashHookPointIsTakeOverCamera_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.SlashHookPointIsTakeOverCamera(__Params->entityId);
	}

	// Token: 0x06016B1F RID: 92959 RVA: 0x0069FD9C File Offset: 0x0069DF9C
	protected unsafe static void __CPPCALL_SlashHookPointSafePointLoc_Implementation(TsGameplayBlueprintFunctionLibrary.__SlashHookPointSafePointLoc_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.SlashHookPointSafePointLoc(__Params->entityId);
	}

	// Token: 0x06016B20 RID: 92960 RVA: 0x0069FDAF File Offset: 0x0069DFAF
	protected unsafe static void __CPPCALL_SlashHookPointSafePointRot_Implementation(TsGameplayBlueprintFunctionLibrary.__SlashHookPointSafePointRot_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.SlashHookPointSafePointRot(__Params->entityId);
	}

	// Token: 0x06016B21 RID: 92961 RVA: 0x0069FDC2 File Offset: 0x0069DFC2
	protected unsafe static void __CPPCALL_StartChargeSlash_Implementation(TsGameplayBlueprintFunctionLibrary.__StartChargeSlash_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.StartChargeSlash(__Params->entityId);
	}

	// Token: 0x06016B22 RID: 92962 RVA: 0x0069FDCF File Offset: 0x0069DFCF
	protected unsafe static void __CPPCALL_StopChargeSlash_Implementation(TsGameplayBlueprintFunctionLibrary.__StopChargeSlash_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.StopChargeSlash(__Params->entityId);
	}

	// Token: 0x06016B23 RID: 92963 RVA: 0x0069FDDC File Offset: 0x0069DFDC
	protected unsafe static void __CPPCALL_IsSlashGameplayIsSuccess_Implementation(TsGameplayBlueprintFunctionLibrary.__IsSlashGameplayIsSuccess_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.IsSlashGameplayIsSuccess();
	}

	// Token: 0x06016B24 RID: 92964 RVA: 0x0069FDE9 File Offset: 0x0069DFE9
	protected unsafe static void __CPPCALL_GetGravityHookLockInfo_Implementation(TsGameplayBlueprintFunctionLibrary.__GetGravityHookLockInfo_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetGravityHookLockInfo(__Params->entityId);
	}

	// Token: 0x06016B25 RID: 92965 RVA: 0x0069FDFC File Offset: 0x0069DFFC
	protected unsafe static void __CPPCALL_ChangeGravityByHook_Implementation(TsGameplayBlueprintFunctionLibrary.__ChangeGravityByHook_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ChangeGravityByHook(__Params->entityId, __Params->angleRangeMin, __Params->angleRangeMax, __Params->smoothSecondMin, __Params->smoothSecondMax, __Params->isLerpCamera);
	}

	// Token: 0x06016B26 RID: 92966 RVA: 0x0069FE28 File Offset: 0x0069E028
	protected unsafe static void __CPPCALL_SetIgnoreSocketName_Implementation(TsGameplayBlueprintFunctionLibrary.__SetIgnoreSocketName_FunctionParams* __Params)
	{
		string socketName = FString.ToString((void*)(&__Params->socketName));
		TsGameplayBlueprintFunctionLibrary.SetIgnoreSocketName(__Params->entityId, socketName);
	}

	// Token: 0x06016B27 RID: 92967 RVA: 0x0069FE50 File Offset: 0x0069E050
	protected unsafe static void __CPPCALL_DeleteIgnoreSocketName_Implementation(TsGameplayBlueprintFunctionLibrary.__DeleteIgnoreSocketName_FunctionParams* __Params)
	{
		string socketName = FString.ToString((void*)(&__Params->socketName));
		TsGameplayBlueprintFunctionLibrary.DeleteIgnoreSocketName(__Params->entityId, socketName);
	}

	// Token: 0x06016B28 RID: 92968 RVA: 0x0069FE76 File Offset: 0x0069E076
	protected unsafe static void __CPPCALL_GetToTargetSocketDistance_Implementation(TsGameplayBlueprintFunctionLibrary.__GetToTargetSocketDistance_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetToTargetSocketDistance(__Params->entityId);
	}

	// Token: 0x06016B29 RID: 92969 RVA: 0x0069FE8C File Offset: 0x0069E08C
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

	// Token: 0x06016B2A RID: 92970 RVA: 0x0069FEEA File Offset: 0x0069E0EA
	protected unsafe static void __CPPCALL_SetVisible_Implementation(TsGameplayBlueprintFunctionLibrary.__SetVisible_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetVisible(__Params->entityId, __Params->isShow);
	}

	// Token: 0x06016B2B RID: 92971 RVA: 0x0069FEFD File Offset: 0x0069E0FD
	protected unsafe static void __CPPCALL_GetCharUnifiedMoveState_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCharUnifiedMoveState_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsGameplayBlueprintFunctionLibrary.GetCharUnifiedMoveState(__Params->entityId);
	}

	// Token: 0x06016B2C RID: 92972 RVA: 0x0069FF12 File Offset: 0x0069E112
	protected unsafe static void __CPPCALL_GetCharUnifiedPositionState_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCharUnifiedPositionState_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsGameplayBlueprintFunctionLibrary.GetCharUnifiedPositionState(__Params->entityId);
	}

	// Token: 0x06016B2D RID: 92973 RVA: 0x0069FF27 File Offset: 0x0069E127
	protected unsafe static void __CPPCALL_ExitHitState_Implementation(TsGameplayBlueprintFunctionLibrary.__ExitHitState_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ExitHitState(__Params->entityId);
	}

	// Token: 0x06016B2E RID: 92974 RVA: 0x0069FF34 File Offset: 0x0069E134
	protected unsafe static void __CPPCALL_SetDirectionState_Implementation(TsGameplayBlueprintFunctionLibrary.__SetDirectionState_FunctionParams* __Params)
	{
		ECharViewDirectionState newViewState = (ECharViewDirectionState)__Params->newViewState;
		TsGameplayBlueprintFunctionLibrary.SetDirectionState(__Params->entityId, newViewState);
	}

	// Token: 0x06016B2F RID: 92975 RVA: 0x0069FF54 File Offset: 0x0069E154
	protected unsafe static void __CPPCALL_GetDirectionState_Implementation(TsGameplayBlueprintFunctionLibrary.__GetDirectionState_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsGameplayBlueprintFunctionLibrary.GetDirectionState(__Params->entityId);
	}

	// Token: 0x06016B30 RID: 92976 RVA: 0x0069FF69 File Offset: 0x0069E169
	protected unsafe static void __CPPCALL_GetIsInGame_Implementation(TsGameplayBlueprintFunctionLibrary.__GetIsInGame_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetIsInGame(__Params->entityId);
	}

	// Token: 0x06016B31 RID: 92977 RVA: 0x0069FF7C File Offset: 0x0069E17C
	protected unsafe static void __CPPCALL_SprintPress_Implementation(TsGameplayBlueprintFunctionLibrary.__SprintPress_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SprintPress(__Params->entityId);
	}

	// Token: 0x06016B32 RID: 92978 RVA: 0x0069FF89 File Offset: 0x0069E189
	protected unsafe static void __CPPCALL_SprintRelease_Implementation(TsGameplayBlueprintFunctionLibrary.__SprintRelease_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SprintRelease(__Params->entityId);
	}

	// Token: 0x06016B33 RID: 92979 RVA: 0x0069FF96 File Offset: 0x0069E196
	protected unsafe static void __CPPCALL_StandPress_Implementation(TsGameplayBlueprintFunctionLibrary.__StandPress_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.StandPress(__Params->entityId);
	}

	// Token: 0x06016B34 RID: 92980 RVA: 0x0069FFA3 File Offset: 0x0069E1A3
	protected unsafe static void __CPPCALL_SwingPress_Implementation(TsGameplayBlueprintFunctionLibrary.__SwingPress_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SwingPress(__Params->entityId);
	}

	// Token: 0x06016B35 RID: 92981 RVA: 0x0069FFB0 File Offset: 0x0069E1B0
	protected unsafe static void __CPPCALL_SwingRelease_Implementation(TsGameplayBlueprintFunctionLibrary.__SwingRelease_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SwingRelease(__Params->entityId);
	}

	// Token: 0x06016B36 RID: 92982 RVA: 0x0069FFBD File Offset: 0x0069E1BD
	protected unsafe static void __CPPCALL_CustomSetWalkOrRun_Implementation(TsGameplayBlueprintFunctionLibrary.__CustomSetWalkOrRun_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.CustomSetWalkOrRun(__Params->entityId, __Params->isWalk);
	}

	// Token: 0x06016B37 RID: 92983 RVA: 0x0069FFD0 File Offset: 0x0069E1D0
	protected unsafe static void __CPPCALL_EnterAimStatus_Implementation(TsGameplayBlueprintFunctionLibrary.__EnterAimStatus_FunctionParams* __Params)
	{
		EAimViewState aimViewState = (EAimViewState)__Params->aimViewState;
		TsGameplayBlueprintFunctionLibrary.EnterAimStatus(__Params->entityId, aimViewState);
	}

	// Token: 0x06016B38 RID: 92984 RVA: 0x0069FFF0 File Offset: 0x0069E1F0
	protected unsafe static void __CPPCALL_ExitAimStatus_Implementation(TsGameplayBlueprintFunctionLibrary.__ExitAimStatus_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ExitAimStatus(__Params->entityId);
	}

	// Token: 0x06016B39 RID: 92985 RVA: 0x0069FFFD File Offset: 0x0069E1FD
	protected unsafe static void __CPPCALL_EnableEntity_Implementation(TsGameplayBlueprintFunctionLibrary.__EnableEntity_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EnableEntity(__Params->entityId, __Params->isEnable);
	}

	// Token: 0x06016B3A RID: 92986 RVA: 0x006A0010 File Offset: 0x0069E210
	protected unsafe static void __CPPCALL_UpdateAnimInfoHit_Implementation(TsGameplayBlueprintFunctionLibrary.__UpdateAnimInfoHit_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsGameplayBlueprintFunctionLibrary.UpdateAnimInfoHit(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06016B3B RID: 92987 RVA: 0x006A0038 File Offset: 0x0069E238
	protected unsafe static void __CPPCALL_UpdateAnimInfoFk_Implementation(TsGameplayBlueprintFunctionLibrary.__UpdateAnimInfoFk_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsGameplayBlueprintFunctionLibrary.UpdateAnimInfoFk(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06016B3C RID: 92988 RVA: 0x006A0060 File Offset: 0x0069E260
	protected unsafe static void __CPPCALL_UpdateAnimInfoUnifiedState_Implementation(TsGameplayBlueprintFunctionLibrary.__UpdateAnimInfoUnifiedState_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsGameplayBlueprintFunctionLibrary.UpdateAnimInfoUnifiedState(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06016B3D RID: 92989 RVA: 0x006A0088 File Offset: 0x0069E288
	protected unsafe static void __CPPCALL_UpdateAnimInfoUnifiedStateRoleNpc_Implementation(TsGameplayBlueprintFunctionLibrary.__UpdateAnimInfoUnifiedStateRoleNpc_FunctionParams* __Params)
	{
		BP_ABPLogicParams_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_ABPLogicParams_C>(__Params->animLogicParams);
		TsGameplayBlueprintFunctionLibrary.UpdateAnimInfoUnifiedStateRoleNpc(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06016B3E RID: 92990 RVA: 0x006A00AD File Offset: 0x0069E2AD
	protected unsafe static void __CPPCALL_GetIsCharRotateWithCameraWhenManipulate_Implementation(TsGameplayBlueprintFunctionLibrary.__GetIsCharRotateWithCameraWhenManipulate_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetIsCharRotateWithCameraWhenManipulate(__Params->entityId);
	}

	// Token: 0x06016B3F RID: 92991 RVA: 0x006A00C0 File Offset: 0x0069E2C0
	protected unsafe static void __CPPCALL_GetIsUseCatapultUpAnim_Implementation(TsGameplayBlueprintFunctionLibrary.__GetIsUseCatapultUpAnim_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetIsUseCatapultUpAnim(__Params->entityId);
	}

	// Token: 0x06016B40 RID: 92992 RVA: 0x006A00D3 File Offset: 0x0069E2D3
	protected unsafe static void __CPPCALL_GetNextMultiSkillId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetNextMultiSkillId_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetNextMultiSkillId(__Params->entityId, __Params->skillId);
	}

	// Token: 0x06016B41 RID: 92993 RVA: 0x006A00EC File Offset: 0x0069E2EC
	protected unsafe static void __CPPCALL_GetNextMultiSkillIdNew_Implementation(TsGameplayBlueprintFunctionLibrary.__GetNextMultiSkillIdNew_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetNextMultiSkillIdNew(__Params->entityId, __Params->skillId);
	}

	// Token: 0x06016B42 RID: 92994 RVA: 0x006A0105 File Offset: 0x0069E305
	protected unsafe static void __CPPCALL_GetManipulateInteractTargetCanInteract_Implementation(TsGameplayBlueprintFunctionLibrary.__GetManipulateInteractTargetCanInteract_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetManipulateInteractTargetCanInteract(__Params->entityId);
	}

	// Token: 0x06016B43 RID: 92995 RVA: 0x006A0118 File Offset: 0x0069E318
	protected unsafe static void __CPPCALL_GetHookInteractTargetCanInteract_Implementation(TsGameplayBlueprintFunctionLibrary.__GetHookInteractTargetCanInteract_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetHookInteractTargetCanInteract(__Params->entityId);
	}

	// Token: 0x06016B44 RID: 92996 RVA: 0x006A012B File Offset: 0x0069E32B
	protected unsafe static void __CPPCALL_GetHookInteractTargetIsIgnorePlayerCollision_Implementation(TsGameplayBlueprintFunctionLibrary.__GetHookInteractTargetIsIgnorePlayerCollision_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetHookInteractTargetIsIgnorePlayerCollision(__Params->entityId);
	}

	// Token: 0x06016B45 RID: 92997 RVA: 0x006A013E File Offset: 0x0069E33E
	protected unsafe static void __CPPCALL_StartManipulateInteract_Implementation(TsGameplayBlueprintFunctionLibrary.__StartManipulateInteract_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.StartManipulateInteract(__Params->entityId);
	}

	// Token: 0x06016B46 RID: 92998 RVA: 0x006A0151 File Offset: 0x0069E351
	protected unsafe static void __CPPCALL_EndManipulateInteract_Implementation(TsGameplayBlueprintFunctionLibrary.__EndManipulateInteract_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EndManipulateInteract(__Params->entityId);
	}

	// Token: 0x06016B47 RID: 92999 RVA: 0x006A015E File Offset: 0x0069E35E
	protected unsafe static void __CPPCALL_StartStatueInteract_Implementation(TsGameplayBlueprintFunctionLibrary.__StartStatueInteract_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.StartStatueInteract(__Params->entityId);
	}

	// Token: 0x06016B48 RID: 93000 RVA: 0x006A0171 File Offset: 0x0069E371
	protected unsafe static void __CPPCALL_EndStatueInteract_Implementation(TsGameplayBlueprintFunctionLibrary.__EndStatueInteract_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EndStatueInteract(__Params->entityId);
	}

	// Token: 0x06016B49 RID: 93001 RVA: 0x006A017E File Offset: 0x0069E37E
	protected unsafe static void __CPPCALL_StartCustomInteract_Implementation(TsGameplayBlueprintFunctionLibrary.__StartCustomInteract_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.StartCustomInteract(__Params->entityId);
	}

	// Token: 0x06016B4A RID: 93002 RVA: 0x006A0191 File Offset: 0x0069E391
	protected unsafe static void __CPPCALL_EndCustomInteract_Implementation(TsGameplayBlueprintFunctionLibrary.__EndCustomInteract_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EndCustomInteract(__Params->entityId);
	}

	// Token: 0x06016B4B RID: 93003 RVA: 0x006A019E File Offset: 0x0069E39E
	protected unsafe static void __CPPCALL_QuantumDiffusionInteract_Implementation(TsGameplayBlueprintFunctionLibrary.__QuantumDiffusionInteract_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.QuantumDiffusionInteract(__Params->entityId);
	}

	// Token: 0x06016B4C RID: 93004 RVA: 0x006A01AC File Offset: 0x0069E3AC
	protected unsafe static void __CPPCALL_GetShootSwordManipulateInteractActors_Implementation(TsGameplayBlueprintFunctionLibrary.__GetShootSwordManipulateInteractActors_FunctionParams* __Params)
	{
		TArray<AActor> shootSwordManipulateInteractActors = TsGameplayBlueprintFunctionLibrary.GetShootSwordManipulateInteractActors(__Params->entityId);
		if (shootSwordManipulateInteractActors == null)
		{
			return;
		}
		shootSwordManipulateInteractActors.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06016B4D RID: 93005 RVA: 0x006A01DE File Offset: 0x0069E3DE
	protected unsafe static void __CPPCALL_GetManipulateInteractLocation_Implementation(TsGameplayBlueprintFunctionLibrary.__GetManipulateInteractLocation_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetManipulateInteractLocation(__Params->entityId);
	}

	// Token: 0x06016B4E RID: 93006 RVA: 0x006A01F1 File Offset: 0x0069E3F1
	protected unsafe static void __CPPCALL_EnvironmentInfoDetect_Implementation(TsGameplayBlueprintFunctionLibrary.__EnvironmentInfoDetect_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EnvironmentInfoDetect(__Params->entityId, __Params->location);
	}

	// Token: 0x06016B4F RID: 93007 RVA: 0x006A0204 File Offset: 0x0069E404
	protected unsafe static void __CPPCALL_LockOnSpecifyTarget_Implementation(TsGameplayBlueprintFunctionLibrary.__LockOnSpecifyTarget_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.LockOnSpecifyTarget(__Params->entityId, __Params->targetEntityId);
	}

	// Token: 0x06016B50 RID: 93008 RVA: 0x006A0217 File Offset: 0x0069E417
	protected unsafe static void __CPPCALL_IsSkillInCd_Implementation(TsGameplayBlueprintFunctionLibrary.__IsSkillInCd_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.IsSkillInCd(__Params->entityId, __Params->skillId);
	}

	// Token: 0x06016B51 RID: 93009 RVA: 0x006A0230 File Offset: 0x0069E430
	protected unsafe static void __CPPCALL_SendHookSkillUseLogData_Implementation(TsGameplayBlueprintFunctionLibrary.__SendHookSkillUseLogData_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SendHookSkillUseLogData(__Params->entityId, __Params->hasTarget);
	}

	// Token: 0x06016B52 RID: 93010 RVA: 0x006A0243 File Offset: 0x0069E443
	protected unsafe static void __CPPCALL_SendManipulateSkillUseLogData_Implementation(TsGameplayBlueprintFunctionLibrary.__SendManipulateSkillUseLogData_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SendManipulateSkillUseLogData(__Params->entityId, __Params->hasTarget);
	}

	// Token: 0x06016B53 RID: 93011 RVA: 0x006A0256 File Offset: 0x0069E456
	protected unsafe static void __CPPCALL_SendScanSkillUseLogData_Implementation(TsGameplayBlueprintFunctionLibrary.__SendScanSkillUseLogData_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SendScanSkillUseLogData(__Params->entityId, __Params->hasTarget);
	}

	// Token: 0x06016B54 RID: 93012 RVA: 0x006A0269 File Offset: 0x0069E469
	protected unsafe static void __CPPCALL_DynamicAttachEntityToActor_Implementation(TsGameplayBlueprintFunctionLibrary.__DynamicAttachEntityToActor_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.DynamicAttachEntityToActor(__Params->entityId, __Params->targetEntityId, __Params->socketName);
	}

	// Token: 0x06016B55 RID: 93013 RVA: 0x006A0284 File Offset: 0x0069E484
	protected unsafe static void __CPPCALL_SetEntityEnable_Implementation(TsGameplayBlueprintFunctionLibrary.__SetEntityEnable_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->callObject);
		string reason = FString.ToString((void*)(&__Params->reason));
		TsGameplayBlueprintFunctionLibrary.SetEntityEnable(__Params->entityId, __Params->enable, orCreateUObjectByNativePointer, reason);
	}

	// Token: 0x06016B56 RID: 93014 RVA: 0x006A02C0 File Offset: 0x0069E4C0
	protected unsafe static void __CPPCALL_SetActorVisible_Implementation(TsGameplayBlueprintFunctionLibrary.__SetActorVisible_FunctionParams* __Params)
	{
		string reason = FString.ToString((void*)(&__Params->reason));
		TsGameplayBlueprintFunctionLibrary.SetActorVisible(__Params->entityId, __Params->visible, __Params->collision, __Params->movable, reason, __Params->sync);
	}

	// Token: 0x06016B57 RID: 93015 RVA: 0x006A0300 File Offset: 0x0069E500
	protected unsafe static void __CPPCALL_SetSkillTargetDirection_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSkillTargetDirection_FunctionParams* __Params)
	{
		ESkillTargetDirection direction = (ESkillTargetDirection)__Params->direction;
		TsGameplayBlueprintFunctionLibrary.SetSkillTargetDirection(__Params->entityId, direction);
	}

	// Token: 0x06016B58 RID: 93016 RVA: 0x006A0320 File Offset: 0x0069E520
	protected unsafe static void __CPPCALL_ChangeAiControllerDebugDraw_Implementation(TsGameplayBlueprintFunctionLibrary.__ChangeAiControllerDebugDraw_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.ChangeAiControllerDebugDraw(__Params->entityId, __Params->debug);
	}

	// Token: 0x06016B59 RID: 93017 RVA: 0x006A0333 File Offset: 0x0069E533
	protected unsafe static void __CPPCALL_GetBeHitAnimType_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBeHitAnimType_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsGameplayBlueprintFunctionLibrary.GetBeHitAnimType(__Params->typeId);
	}

	// Token: 0x06016B5A RID: 93018 RVA: 0x006A0348 File Offset: 0x0069E548
	protected unsafe static void __CPPCALL_StartInhalation_Implementation(TsGameplayBlueprintFunctionLibrary.__StartInhalation_FunctionParams* __Params)
	{
		TArray<FGameplayTag> tarray = new TArray<FGameplayTag>(&__Params->tag, true, true);
		TsGameplayBlueprintFunctionLibrary.StartInhalation(__Params->entityId, __Params->strength, __Params->distance, __Params->isPowerfulMode, __Params->checkAngle, ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->tag, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06016B5B RID: 93019 RVA: 0x006A03A2 File Offset: 0x0069E5A2
	protected unsafe static void __CPPCALL_StopInhalation_Implementation(TsGameplayBlueprintFunctionLibrary.__StopInhalation_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.StopInhalation(__Params->entityId);
	}

	// Token: 0x06016B5C RID: 93020 RVA: 0x006A03B0 File Offset: 0x0069E5B0
	protected unsafe static void __CPPCALL_TryGetDebugMovementComp_Implementation(TsGameplayBlueprintFunctionLibrary.__TryGetDebugMovementComp_FunctionParams* __Params)
	{
		string pbDataId = FString.ToString((void*)(&__Params->pbDataId));
		ref IntPtr ptr = ref *(&__Params->__Result);
		UKuroDebugMovementComponent ukuroDebugMovementComponent = TsGameplayBlueprintFunctionLibrary.TryGetDebugMovementComp(pbDataId);
		ptr = ((ukuroDebugMovementComponent != null) ? ukuroDebugMovementComponent.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016B5D RID: 93021 RVA: 0x006A03E5 File Offset: 0x0069E5E5
	protected unsafe static void __CPPCALL_TryPlayLinkAnim_Implementation(TsGameplayBlueprintFunctionLibrary.__TryPlayLinkAnim_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.TryPlayLinkAnim();
	}

	// Token: 0x06016B5E RID: 93022 RVA: 0x006A03EC File Offset: 0x0069E5EC
	protected unsafe static void __CPPCALL_TraceGround_Implementation(TsGameplayBlueprintFunctionLibrary.__TraceGround_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.TraceGround(__Params->entityId, __Params->start, __Params->end, __Params->draw);
	}

	// Token: 0x06016B5F RID: 93023 RVA: 0x006A0414 File Offset: 0x0069E614
	protected unsafe static void __CPPCALL_ChangePhantomTeam_Implementation(TsGameplayBlueprintFunctionLibrary.__ChangePhantomTeam_FunctionParams* __Params)
	{
		TArray<FGameplayTag> tarray = new TArray<FGameplayTag>(&__Params->skillTriggerTags, true, true);
		TsGameplayBlueprintFunctionLibrary.ChangePhantomTeam(__Params->phantomFormationId, ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->skillTriggerTags, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06016B60 RID: 93024 RVA: 0x006A0456 File Offset: 0x0069E656
	protected unsafe static void __CPPCALL_RevertPhantomTeam_Implementation(TsGameplayBlueprintFunctionLibrary.__RevertPhantomTeam_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.RevertPhantomTeam();
	}

	// Token: 0x06016B61 RID: 93025 RVA: 0x006A045D File Offset: 0x0069E65D
	protected unsafe static void __CPPCALL_GetFormationAttribute_Implementation(TsGameplayBlueprintFunctionLibrary.__GetFormationAttribute_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetFormationAttribute(__Params->type);
	}

	// Token: 0x06016B62 RID: 93026 RVA: 0x006A0470 File Offset: 0x0069E670
	protected unsafe static void __CPPCALL_GetEntityDeltaMillisecond_Implementation(TsGameplayBlueprintFunctionLibrary.__GetEntityDeltaMillisecond_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetEntityDeltaMillisecond(__Params->entityId);
	}

	// Token: 0x06016B63 RID: 93027 RVA: 0x006A0483 File Offset: 0x0069E683
	protected unsafe static void __CPPCALL_SyncTwoEntityLocationAndRotation_Implementation(TsGameplayBlueprintFunctionLibrary.__SyncTwoEntityLocationAndRotation_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SyncTwoEntityLocationAndRotation(__Params->fromEntityId, __Params->toEntityId);
	}

	// Token: 0x06016B64 RID: 93028 RVA: 0x006A0496 File Offset: 0x0069E696
	protected unsafe static void __CPPCALL_GetFishingBoat_Implementation(TsGameplayBlueprintFunctionLibrary.__GetFishingBoat_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor fishingBoat = TsGameplayBlueprintFunctionLibrary.GetFishingBoat();
		ptr = ((fishingBoat != null) ? fishingBoat.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016B65 RID: 93029 RVA: 0x006A04B2 File Offset: 0x0069E6B2
	protected unsafe static void __CPPCALL_FishingBoatSprint_Implementation(TsGameplayBlueprintFunctionLibrary.__FishingBoatSprint_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.FishingBoatSprint(__Params->entityId, __Params->maxSpeedRatio, __Params->exceedLimitDuration, __Params->duration);
	}

	// Token: 0x06016B66 RID: 93030 RVA: 0x006A04D1 File Offset: 0x0069E6D1
	protected unsafe static void __CPPCALL_FishingBoatSkill_Implementation(TsGameplayBlueprintFunctionLibrary.__FishingBoatSkill_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.FishingBoatSkill((EFishingSkillType)__Params->type);
	}

	// Token: 0x06016B67 RID: 93031 RVA: 0x006A04DE File Offset: 0x0069E6DE
	protected unsafe static void __CPPCALL_GetCharacterMorphType_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCharacterMorphType_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsGameplayBlueprintFunctionLibrary.GetCharacterMorphType(__Params->entityId);
	}

	// Token: 0x06016B68 RID: 93032 RVA: 0x006A04F4 File Offset: 0x0069E6F4
	protected unsafe static void __CPPCALL_SetCharacterMorphType_Implementation(TsGameplayBlueprintFunctionLibrary.__SetCharacterMorphType_FunctionParams* __Params)
	{
		EMorphType morphType = (EMorphType)__Params->morphType;
		TsGameplayBlueprintFunctionLibrary.SetCharacterMorphType(__Params->entityId, morphType);
	}

	// Token: 0x06016B69 RID: 93033 RVA: 0x006A0514 File Offset: 0x0069E714
	protected unsafe static void __CPPCALL_SetSpecialEnergyAttrValue_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSpecialEnergyAttrValue_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetSpecialEnergyAttrValue(__Params->entityId, __Params->attrId, __Params->value);
	}

	// Token: 0x06016B6A RID: 93034 RVA: 0x006A052D File Offset: 0x0069E72D
	protected unsafe static void __CPPCALL_GetFuLuoLuoSpecialEnergyType_Implementation(TsGameplayBlueprintFunctionLibrary.__GetFuLuoLuoSpecialEnergyType_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetFuLuoLuoSpecialEnergyType(__Params->entityId, __Params->index);
	}

	// Token: 0x06016B6B RID: 93035 RVA: 0x006A0546 File Offset: 0x0069E746
	protected unsafe static void __CPPCALL_StartBattleQte_Implementation(TsGameplayBlueprintFunctionLibrary.__StartBattleQte_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.StartBattleQte(__Params->entityId, __Params->skillId, __Params->battleQteId);
	}

	// Token: 0x06016B6C RID: 93036 RVA: 0x006A0560 File Offset: 0x0069E760
	protected unsafe static void __CPPCALL_StopGroup1Skill_Implementation(TsGameplayBlueprintFunctionLibrary.__StopGroup1Skill_FunctionParams* __Params)
	{
		string reason = FString.ToString((void*)(&__Params->reason));
		TsGameplayBlueprintFunctionLibrary.StopGroup1Skill(__Params->entityId, reason);
	}

	// Token: 0x06016B6D RID: 93037 RVA: 0x006A0586 File Offset: 0x0069E786
	protected unsafe static void __CPPCALL_GetCharactersLocationNearBy_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCharactersLocationNearBy_FunctionParams* __Params)
	{
		UScriptStructStackOnlyPtr nativeUStructPtr = SCharacterLocationsAndRadius.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SCharacterLocationsAndRadius charactersLocationNearBy = TsGameplayBlueprintFunctionLibrary.GetCharactersLocationNearBy(__Params->center, __Params->distance, __Params->maxCount);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (charactersLocationNearBy != null) ? charactersLocationNearBy.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x06016B6E RID: 93038 RVA: 0x006A05BF File Offset: 0x0069E7BF
	protected unsafe static void __CPPCALL_GetCurrentPlayer_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCurrentPlayer_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		TsBaseCharacter currentPlayer = TsGameplayBlueprintFunctionLibrary.GetCurrentPlayer();
		ptr = ((currentPlayer != null) ? currentPlayer.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016B6F RID: 93039 RVA: 0x006A05DC File Offset: 0x0069E7DC
	protected unsafe static void __CPPCALL_IsEnemy_Implementation(TsGameplayBlueprintFunctionLibrary.__IsEnemy_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->owner);
		TsBaseCharacter orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->other);
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.IsEnemy(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06016B70 RID: 93040 RVA: 0x006A060E File Offset: 0x0069E80E
	protected unsafe static void __CPPCALL_SetWalkOffLedge_Implementation(TsGameplayBlueprintFunctionLibrary.__SetWalkOffLedge_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.SetWalkOffLedge(__Params->entityId, __Params->walkOff);
	}

	// Token: 0x06016B71 RID: 93041 RVA: 0x006A0624 File Offset: 0x0069E824
	protected unsafe static void __CPPCALL_StartFlyingFeather_Implementation(TsGameplayBlueprintFunctionLibrary.__StartFlyingFeather_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->owner);
		BP_FlyingFeatherConfig_C orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_FlyingFeatherConfig_C>(__Params->config);
		TsGameplayBlueprintFunctionLibrary.StartFlyingFeather(orCreateUObjectByNativePointer, __Params->initLocation, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06016B72 RID: 93042 RVA: 0x006A0654 File Offset: 0x0069E854
	protected unsafe static void __CPPCALL_GetFlyingFeatherTargetId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetFlyingFeatherTargetId_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->owner);
		FString.CopyFrom((void*)(&__Params->__Result), TsGameplayBlueprintFunctionLibrary.GetFlyingFeatherTargetId(orCreateUObjectByNativePointer));
	}

	// Token: 0x06016B73 RID: 93043 RVA: 0x006A0680 File Offset: 0x0069E880
	protected unsafe static void __CPPCALL_AddFlyingFeatherTargetTag_Implementation(TsGameplayBlueprintFunctionLibrary.__AddFlyingFeatherTargetTag_FunctionParams* __Params)
	{
		string entityId = FString.ToString((void*)(&__Params->entityId));
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor aactor = TsGameplayBlueprintFunctionLibrary.AddFlyingFeatherTargetTag(__Params->tag, entityId);
		ptr = ((aactor != null) ? aactor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016B74 RID: 93044 RVA: 0x006A06BC File Offset: 0x0069E8BC
	protected unsafe static void __CPPCALL_UpdateFlyingFeather_Implementation(TsGameplayBlueprintFunctionLibrary.__UpdateFlyingFeather_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->owner);
		string target = FString.ToString((void*)(&__Params->target));
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.UpdateFlyingFeather(orCreateUObjectByNativePointer, target);
	}

	// Token: 0x06016B75 RID: 93045 RVA: 0x006A06EF File Offset: 0x0069E8EF
	protected unsafe static void __CPPCALL_EmitGlobalClientEvent_Implementation(TsGameplayBlueprintFunctionLibrary.__EmitGlobalClientEvent_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.EmitGlobalClientEvent(__Params->eventNameTag);
	}

	// Token: 0x06016B76 RID: 93046 RVA: 0x006A06FC File Offset: 0x0069E8FC
	protected unsafe static void __CPPCALL_GetDriverEntityId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetDriverEntityId_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetDriverEntityId(__Params->vehicleEntityId);
	}

	// Token: 0x06016B77 RID: 93047 RVA: 0x006A0710 File Offset: 0x0069E910
	protected unsafe static void __CPPCALL_StartCableWayMove_Implementation(TsGameplayBlueprintFunctionLibrary.__StartCableWayMove_FunctionParams* __Params)
	{
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		TsGameplayBlueprintFunctionLibrary.StartCableWayMove(__Params->id, orCreateUObjectByNativePointer);
	}

	// Token: 0x06016B78 RID: 93048 RVA: 0x006A0735 File Offset: 0x0069E935
	protected unsafe static void __CPPCALL_StopCableWayMove_Implementation(TsGameplayBlueprintFunctionLibrary.__StopCableWayMove_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.StopCableWayMove(__Params->id);
	}

	// Token: 0x06016B79 RID: 93049 RVA: 0x006A0742 File Offset: 0x0069E942
	protected unsafe static void __CPPCALL_GetBuffInstigatorId_Implementation(TsGameplayBlueprintFunctionLibrary.__GetBuffInstigatorId_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetBuffInstigatorId(__Params->entityId, __Params->buffId, __Params->getInstigatorSummoner);
	}

	// Token: 0x06016B7A RID: 93050 RVA: 0x006A0764 File Offset: 0x0069E964
	protected unsafe static void __CPPCALL_SetSubMeshOrder_Implementation(TsGameplayBlueprintFunctionLibrary.__SetSubMeshOrder_FunctionParams* __Params)
	{
		string meshName = FString.ToString((void*)(&__Params->meshName));
		PD_CharacterControllerData_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<PD_CharacterControllerData_C>(__Params->charControllerData);
		TSoftObjectPtr<UEffectModelBase> effectDataAssetRef = new TSoftObjectPtr<UEffectModelBase>(&__Params->effectDataAssetRef, true, true);
		TsGameplayBlueprintFunctionLibrary.SetSubMeshOrder(__Params->entityId, meshName, __Params->visible, orCreateUObjectByNativePointer, effectDataAssetRef, __Params->delayTime);
	}

	// Token: 0x06016B7B RID: 93051 RVA: 0x006A07B3 File Offset: 0x0069E9B3
	protected unsafe static void __CPPCALL_GetPilotThrowSpeed_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPilotThrowSpeed_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetPilotThrowSpeed();
	}

	// Token: 0x06016B7C RID: 93052 RVA: 0x006A07C0 File Offset: 0x0069E9C0
	protected unsafe static void __CPPCALL_GetPilotThrowDirection_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPilotThrowDirection_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetPilotThrowDirection();
	}

	// Token: 0x06016B7D RID: 93053 RVA: 0x006A07CD File Offset: 0x0069E9CD
	protected unsafe static void __CPPCALL_GetPilotThrowGravity_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPilotThrowGravity_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetPilotThrowGravity();
	}

	// Token: 0x06016B7E RID: 93054 RVA: 0x006A07DA File Offset: 0x0069E9DA
	protected unsafe static void __CPPCALL_GetPilotThrowNeedMotorRide_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPilotThrowNeedMotorRide_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetPilotThrowNeedMotorRide();
	}

	// Token: 0x06016B7F RID: 93055 RVA: 0x006A07E7 File Offset: 0x0069E9E7
	protected unsafe static void __CPPCALL_GetPilotThrowIsDisableInterrupt_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPilotThrowIsDisableInterrupt_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetPilotThrowIsDisableInterrupt();
	}

	// Token: 0x06016B80 RID: 93056 RVA: 0x006A07F4 File Offset: 0x0069E9F4
	protected unsafe static void __CPPCALL_OpenPilotThrowGameplayCamera_Implementation(TsGameplayBlueprintFunctionLibrary.__OpenPilotThrowGameplayCamera_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.OpenPilotThrowGameplayCamera(__Params->targetEntityId);
	}

	// Token: 0x06016B81 RID: 93057 RVA: 0x006A0801 File Offset: 0x0069EA01
	protected unsafe static void __CPPCALL_GetCurrentTargetPilotSkeletalMeshComponent_Implementation(TsGameplayBlueprintFunctionLibrary.__GetCurrentTargetPilotSkeletalMeshComponent_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		USkeletalMeshComponent currentTargetPilotSkeletalMeshComponent = TsGameplayBlueprintFunctionLibrary.GetCurrentTargetPilotSkeletalMeshComponent(__Params->entityId);
		ptr = ((currentTargetPilotSkeletalMeshComponent != null) ? currentTargetPilotSkeletalMeshComponent.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016B82 RID: 93058 RVA: 0x006A0823 File Offset: 0x0069EA23
	protected unsafe static void __CPPCALL_GetPilotCurrentInRangePoint_Implementation(TsGameplayBlueprintFunctionLibrary.__GetPilotCurrentInRangePoint_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetPilotCurrentInRangePoint();
	}

	// Token: 0x06016B83 RID: 93059 RVA: 0x006A0830 File Offset: 0x0069EA30
	protected unsafe static void __CPPCALL_GetVehicleCatapultUnitRisingTime_Implementation(TsGameplayBlueprintFunctionLibrary.__GetVehicleCatapultUnitRisingTime_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.GetVehicleCatapultUnitRisingTime(__Params->entityId);
	}

	// Token: 0x06016B84 RID: 93060 RVA: 0x006A0843 File Offset: 0x0069EA43
	protected unsafe static void __CPPCALL_GuessJokerNpcTurnToIdlePerform_Implementation(TsGameplayBlueprintFunctionLibrary.__GuessJokerNpcTurnToIdlePerform_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.GuessJokerNpcTurnToIdlePerform();
	}

	// Token: 0x06016B85 RID: 93061 RVA: 0x006A084A File Offset: 0x0069EA4A
	protected unsafe static void __CPPCALL_LevelFlowDeadlySkeletonMeshCastToCharacter_Implementation(TsGameplayBlueprintFunctionLibrary.__LevelFlowDeadlySkeletonMeshCastToCharacter_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.LevelFlowDeadlySkeletonMeshCastToCharacter();
	}

	// Token: 0x06016B86 RID: 93062 RVA: 0x006A0851 File Offset: 0x0069EA51
	protected unsafe static void __CPPCALL_LevelFlowAddBuff_Implementation(TsGameplayBlueprintFunctionLibrary.__LevelFlowAddBuff_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.LevelFlowAddBuff(__Params->entityId, __Params->buffId);
	}

	// Token: 0x06016B87 RID: 93063 RVA: 0x006A0864 File Offset: 0x0069EA64
	protected unsafe static void __CPPCALL_LevelFlowRemoveBuff_Implementation(TsGameplayBlueprintFunctionLibrary.__LevelFlowRemoveBuff_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.LevelFlowRemoveBuff(__Params->entityId, __Params->buffId);
	}

	// Token: 0x06016B88 RID: 93064 RVA: 0x006A0877 File Offset: 0x0069EA77
	protected unsafe static void __CPPCALL_LevelFlowCameraShake_Implementation(TsGameplayBlueprintFunctionLibrary.__LevelFlowCameraShake_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.LevelFlowCameraShake(FString.ToString((void*)(&__Params->cameraShakeBp)));
	}

	// Token: 0x06016B89 RID: 93065 RVA: 0x006A088C File Offset: 0x0069EA8C
	protected unsafe static void __CPPCALL_LevelFlowPlayLevelSequence_Implementation(TsGameplayBlueprintFunctionLibrary.__LevelFlowPlayLevelSequence_FunctionParams* __Params)
	{
		string path = FString.ToString((void*)(&__Params->path));
		string mark = FString.ToString((void*)(&__Params->mark));
		TsGameplayBlueprintFunctionLibrary.LevelFlowPlayLevelSequence(path, mark);
	}

	// Token: 0x06016B8A RID: 93066 RVA: 0x006A08B8 File Offset: 0x0069EAB8
	protected unsafe static void __CPPCALL_CallSpecialSkillCodeFunction_Implementation(TsGameplayBlueprintFunctionLibrary.__CallSpecialSkillCodeFunction_FunctionParams* __Params)
	{
		string functionName = FString.ToString((void*)(&__Params->functionName));
		FKuroCodeFunctionPayload payload = new FKuroCodeFunctionPayload(&__Params->payload, true, true);
		UScriptStructStackOnlyPtr nativeUStructPtr = FKuroCodeFunctionResult.StaticStruct();
		IntPtr dest = &__Params->__Result;
		FKuroCodeFunctionResult fkuroCodeFunctionResult = TsGameplayBlueprintFunctionLibrary.CallSpecialSkillCodeFunction(__Params->entityId, functionName, payload);
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (fkuroCodeFunctionResult != null) ? fkuroCodeFunctionResult.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x06016B8B RID: 93067 RVA: 0x006A0910 File Offset: 0x0069EB10
	protected unsafe static void __CPPCALL_XigelikaAddBean_Implementation(TsGameplayBlueprintFunctionLibrary.__XigelikaAddBean_FunctionParams* __Params)
	{
		string bean = FString.ToString((void*)(&__Params->bean));
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.XigelikaAddBean(__Params->entityId, bean);
	}

	// Token: 0x06016B8C RID: 93068 RVA: 0x006A093C File Offset: 0x0069EB3C
	protected unsafe static void __CPPCALL_XigelikaGetBeanResultant_Implementation(TsGameplayBlueprintFunctionLibrary.__XigelikaGetBeanResultant_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.XigelikaGetBeanResultant(__Params->entityId);
	}

	// Token: 0x06016B8D RID: 93069 RVA: 0x006A094F File Offset: 0x0069EB4F
	protected unsafe static void __CPPCALL_XigelikaConsumeBean_Implementation(TsGameplayBlueprintFunctionLibrary.__XigelikaConsumeBean_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.XigelikaConsumeBean(__Params->entityId);
	}

	// Token: 0x06016B8E RID: 93070 RVA: 0x006A095C File Offset: 0x0069EB5C
	protected unsafe static void __CPPCALL_XigelikaResetBean_Implementation(TsGameplayBlueprintFunctionLibrary.__XigelikaResetBean_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.XigelikaResetBean(__Params->entityId);
	}

	// Token: 0x06016B8F RID: 93071 RVA: 0x006A0969 File Offset: 0x0069EB69
	protected unsafe static void __CPPCALL_OpenQuickHack_Implementation(TsGameplayBlueprintFunctionLibrary.__OpenQuickHack_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.OpenQuickHack(__Params->deviceId, __Params->ownerEntityId, __Params->closeWhenInteractFinish, __Params->interactFinishGameplayEventTag);
	}

	// Token: 0x06016B90 RID: 93072 RVA: 0x006A0988 File Offset: 0x0069EB88
	protected unsafe static void __CPPCALL_CloseQuickHack_Implementation(TsGameplayBlueprintFunctionLibrary.__CloseQuickHack_FunctionParams* __Params)
	{
		TsGameplayBlueprintFunctionLibrary.CloseQuickHack();
	}

	// Token: 0x06016B91 RID: 93073 RVA: 0x006A098F File Offset: 0x0069EB8F
	protected unsafe static void __CPPCALL_FunctionOpen_Implementation(TsGameplayBlueprintFunctionLibrary.__FunctionOpen_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.FunctionOpen(__Params->functionType);
	}

	// Token: 0x06016B92 RID: 93074 RVA: 0x006A09A2 File Offset: 0x0069EBA2
	protected unsafe static void __CPPCALL_CreateTempActor_Implementation(TsGameplayBlueprintFunctionLibrary.__CreateTempActor_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.CreateTempActor(__Params->playerId, __Params->actorClass, __Params->transform);
	}

	// Token: 0x06016B93 RID: 93075 RVA: 0x006A09C1 File Offset: 0x0069EBC1
	protected unsafe static void __CPPCALL_DestroyTempActor_Implementation(TsGameplayBlueprintFunctionLibrary.__DestroyTempActor_FunctionParams* __Params)
	{
		__Params->__Result = TsGameplayBlueprintFunctionLibrary.DestroyTempActor(__Params->playerId);
	}

	// Token: 0x0400BF22 RID: 48930
	[Nullable(2)]
	private static TimerHandle FlyingFeatherHandle;

	// Token: 0x0400BF23 RID: 48931
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsGameplayBlueprintFunctionLibrary.TsGameplayBlueprintFunctionLibrary_C";

	// Token: 0x0400BF24 RID: 48932
	private static IntPtr _ClassPtr;

	// Token: 0x0400BF25 RID: 48933
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020085E7 RID: 34279
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ContainsTag_FunctionParams
	{
		// Token: 0x0402B122 RID: 176418
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B123 RID: 176419
		[FieldOffset(4)]
		public FGameplayTag tag;

		// Token: 0x0402B124 RID: 176420
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402B125 RID: 176421
		[FieldOffset(24)]
		public bool __Result;
	}

	// Token: 0x020085E8 RID: 34280
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __AddTag_FunctionParams
	{
		// Token: 0x0402B126 RID: 176422
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B127 RID: 176423
		[FieldOffset(4)]
		public FGameplayTag tag;

		// Token: 0x0402B128 RID: 176424
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085E9 RID: 34281
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __AddTagWithDuration_FunctionParams
	{
		// Token: 0x0402B129 RID: 176425
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B12A RID: 176426
		[FieldOffset(4)]
		public float duration;

		// Token: 0x0402B12B RID: 176427
		[FieldOffset(8)]
		public FGameplayTag tag;

		// Token: 0x0402B12C RID: 176428
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085EA RID: 34282
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __AddTagByName_FunctionParams
	{
		// Token: 0x0402B12D RID: 176429
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B12E RID: 176430
		[FieldOffset(8)]
		public FString tagName;

		// Token: 0x0402B12F RID: 176431
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085EB RID: 34283
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __RemoveTag_FunctionParams
	{
		// Token: 0x0402B130 RID: 176432
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B131 RID: 176433
		[FieldOffset(4)]
		public FGameplayTag tag;

		// Token: 0x0402B132 RID: 176434
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085EC RID: 34284
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __RemoveTagByName_FunctionParams
	{
		// Token: 0x0402B133 RID: 176435
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B134 RID: 176436
		[FieldOffset(8)]
		public FString tagName;

		// Token: 0x0402B135 RID: 176437
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085ED RID: 34285
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __AddCue_FunctionParams
	{
		// Token: 0x0402B136 RID: 176438
		[FieldOffset(0)]
		public int instigatorEntityId;

		// Token: 0x0402B137 RID: 176439
		[FieldOffset(4)]
		public int targetEntityId;

		// Token: 0x0402B138 RID: 176440
		[FieldOffset(8)]
		public long cueId;

		// Token: 0x0402B139 RID: 176441
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085EE RID: 34286
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __RemoveCue_FunctionParams
	{
		// Token: 0x0402B13A RID: 176442
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B13B RID: 176443
		[FieldOffset(8)]
		public long cueId;

		// Token: 0x0402B13C RID: 176444
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085EF RID: 34287
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetGameplayCueEffectForceRecycle_FunctionParams
	{
		// Token: 0x0402B13D RID: 176445
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B13E RID: 176446
		[FieldOffset(8)]
		public long cueId;

		// Token: 0x0402B13F RID: 176447
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085F0 RID: 34288
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsLogicAutonomousProxy_FunctionParams
	{
		// Token: 0x0402B140 RID: 176448
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B141 RID: 176449
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B142 RID: 176450
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020085F1 RID: 34289
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __RemoveActiveGameplayEffect_FunctionParams
	{
		// Token: 0x0402B143 RID: 176451
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B144 RID: 176452
		[FieldOffset(4)]
		public byte handle;

		// Token: 0x0402B145 RID: 176453
		[FieldOffset(12)]
		public float stacksToRemove;

		// Token: 0x0402B146 RID: 176454
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402B147 RID: 176455
		[FieldOffset(24)]
		public bool __Result;
	}

	// Token: 0x020085F2 RID: 34290
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __RemoveBuffByTag_FunctionParams
	{
		// Token: 0x0402B148 RID: 176456
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B149 RID: 176457
		[FieldOffset(4)]
		public FGameplayTag tag;

		// Token: 0x0402B14A RID: 176458
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085F3 RID: 34291
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __AddPassiveSkill_FunctionParams
	{
		// Token: 0x0402B14B RID: 176459
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B14C RID: 176460
		[FieldOffset(8)]
		public long passiveSkillId;

		// Token: 0x0402B14D RID: 176461
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085F4 RID: 34292
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __RemovePassiveSkill_FunctionParams
	{
		// Token: 0x0402B14E RID: 176462
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B14F RID: 176463
		[FieldOffset(8)]
		public long passiveSkillId;

		// Token: 0x0402B150 RID: 176464
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085F5 RID: 34293
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetPassiveGaSkillId_FunctionParams
	{
		// Token: 0x0402B151 RID: 176465
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B152 RID: 176466
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x0402B153 RID: 176467
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085F6 RID: 34294
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __AddBuffForDebug_FunctionParams
	{
		// Token: 0x0402B154 RID: 176468
		[FieldOffset(0)]
		public int instigatorEntityId;

		// Token: 0x0402B155 RID: 176469
		[FieldOffset(4)]
		public int targetEntityId;

		// Token: 0x0402B156 RID: 176470
		[FieldOffset(8)]
		public long buffId;

		// Token: 0x0402B157 RID: 176471
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085F7 RID: 34295
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SendCombatEventForDebug_FunctionParams
	{
		// Token: 0x0402B158 RID: 176472
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B159 RID: 176473
		[FieldOffset(8)]
		public FString tagName;

		// Token: 0x0402B15A RID: 176474
		[FieldOffset(24)]
		public bool needSave;

		// Token: 0x0402B15B RID: 176475
		[FieldOffset(25)]
		public bool isMainState;

		// Token: 0x0402B15C RID: 176476
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085F8 RID: 34296
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SendLevelEventForDebug_FunctionParams
	{
		// Token: 0x0402B15D RID: 176477
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B15E RID: 176478
		[FieldOffset(8)]
		public FString tagName;

		// Token: 0x0402B15F RID: 176479
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085F9 RID: 34297
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __AddBuffFromGA_FunctionParams
	{
		// Token: 0x0402B160 RID: 176480
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B161 RID: 176481
		[FieldOffset(8)]
		public IntPtr target;

		// Token: 0x0402B162 RID: 176482
		[FieldOffset(16)]
		public long buffId;

		// Token: 0x0402B163 RID: 176483
		[FieldOffset(24)]
		public FString skillId;

		// Token: 0x0402B164 RID: 176484
		[FieldOffset(40)]
		public int addCount;

		// Token: 0x0402B165 RID: 176485
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085FA RID: 34298
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __RemoveBuffById_FunctionParams
	{
		// Token: 0x0402B166 RID: 176486
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B167 RID: 176487
		[FieldOffset(8)]
		public long buffId;

		// Token: 0x0402B168 RID: 176488
		[FieldOffset(16)]
		public int stackCount;

		// Token: 0x0402B169 RID: 176489
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085FB RID: 34299
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetBuffCountById_FunctionParams
	{
		// Token: 0x0402B16A RID: 176490
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B16B RID: 176491
		[FieldOffset(8)]
		public long buffId;

		// Token: 0x0402B16C RID: 176492
		[FieldOffset(16)]
		public bool enforceOnGoingCheck;

		// Token: 0x0402B16D RID: 176493
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402B16E RID: 176494
		[FieldOffset(32)]
		public int __Result;
	}

	// Token: 0x020085FC RID: 34300
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __AddGameplayCueLocal_FunctionParams
	{
		// Token: 0x0402B16F RID: 176495
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B170 RID: 176496
		[FieldOffset(4)]
		public float duration;

		// Token: 0x0402B171 RID: 176497
		[FieldOffset(8)]
		public long cueId;

		// Token: 0x0402B172 RID: 176498
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085FD RID: 34301
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetGeDebugString_FunctionParams
	{
		// Token: 0x0402B173 RID: 176499
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B174 RID: 176500
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B175 RID: 176501
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020085FE RID: 34302
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetTagDebugStrings_FunctionParams
	{
		// Token: 0x0402B176 RID: 176502
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B177 RID: 176503
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B178 RID: 176504
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x020085FF RID: 34303
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetBuffDebugStrings_FunctionParams
	{
		// Token: 0x0402B179 RID: 176505
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B17A RID: 176506
		[FieldOffset(8)]
		public FString buffStr;

		// Token: 0x0402B17B RID: 176507
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402B17C RID: 176508
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x02008600 RID: 34304
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetShieldDebugString_FunctionParams
	{
		// Token: 0x0402B17D RID: 176509
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B17E RID: 176510
		[FieldOffset(8)]
		public FString filterStr;

		// Token: 0x0402B17F RID: 176511
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402B180 RID: 176512
		[FieldOffset(32)]
		public FString __Result;
	}

	// Token: 0x02008601 RID: 34305
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetPassiveSkillDebugString_FunctionParams
	{
		// Token: 0x0402B181 RID: 176513
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B182 RID: 176514
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B183 RID: 176515
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008602 RID: 34306
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetShieldValue_FunctionParams
	{
		// Token: 0x0402B184 RID: 176516
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B185 RID: 176517
		[FieldOffset(4)]
		public int shieldCid;

		// Token: 0x0402B186 RID: 176518
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B187 RID: 176519
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02008603 RID: 34307
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetAttributeDebugString_FunctionParams
	{
		// Token: 0x0402B188 RID: 176520
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B189 RID: 176521
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B18A RID: 176522
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008604 RID: 34308
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetAllAttributeDebugStrings_FunctionParams
	{
		// Token: 0x0402B18B RID: 176523
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B18C RID: 176524
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B18D RID: 176525
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008605 RID: 34309
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetServerBuffString_FunctionParams
	{
		// Token: 0x0402B18E RID: 176526
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B18F RID: 176527
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B190 RID: 176528
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008606 RID: 34310
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetServerTagString_FunctionParams
	{
		// Token: 0x0402B191 RID: 176529
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B192 RID: 176530
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B193 RID: 176531
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008607 RID: 34311
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetServerAttributeString_FunctionParams
	{
		// Token: 0x0402B194 RID: 176532
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B195 RID: 176533
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B196 RID: 176534
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008608 RID: 34312
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetServerPartString_FunctionParams
	{
		// Token: 0x0402B197 RID: 176535
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B198 RID: 176536
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B199 RID: 176537
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008609 RID: 34313
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetServerHateString_FunctionParams
	{
		// Token: 0x0402B19A RID: 176538
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B19B RID: 176539
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B19C RID: 176540
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x0200860A RID: 34314
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetServerShieldString_FunctionParams
	{
		// Token: 0x0402B19D RID: 176541
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B19E RID: 176542
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B19F RID: 176543
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x0200860B RID: 34315
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ServerDebugInfoRequest_FunctionParams
	{
		// Token: 0x0402B1A0 RID: 176544
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1A1 RID: 176545
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200860C RID: 34316
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetServerDebugInfoDirty_FunctionParams
	{
		// Token: 0x0402B1A2 RID: 176546
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1A3 RID: 176547
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B1A4 RID: 176548
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200860D RID: 34317
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetServerDebugInfoDirty_FunctionParams
	{
		// Token: 0x0402B1A5 RID: 176549
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1A6 RID: 176550
		[FieldOffset(4)]
		public bool val;

		// Token: 0x0402B1A7 RID: 176551
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200860E RID: 34318
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __DebugResetBaseVal_FunctionParams
	{
		// Token: 0x0402B1A8 RID: 176552
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1A9 RID: 176553
		[FieldOffset(4)]
		public float id;

		// Token: 0x0402B1AA RID: 176554
		[FieldOffset(8)]
		public float val;

		// Token: 0x0402B1AB RID: 176555
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200860F RID: 34319
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DebugResetFormationValue_FunctionParams
	{
		// Token: 0x0402B1AC RID: 176556
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402B1AD RID: 176557
		[FieldOffset(4)]
		public float val;

		// Token: 0x0402B1AE RID: 176558
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008610 RID: 34320
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __Record_FunctionParams
	{
		// Token: 0x0402B1AF RID: 176559
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1B0 RID: 176560
		[FieldOffset(4)]
		public bool record;

		// Token: 0x0402B1B1 RID: 176561
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B1B2 RID: 176562
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008611 RID: 34321
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __RefreshEntityListView_FunctionParams
	{
		// Token: 0x0402B1B3 RID: 176563
		[FieldOffset(0)]
		public IntPtr listView;

		// Token: 0x0402B1B4 RID: 176564
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008612 RID: 34322
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __RefreshEntityComboBox_FunctionParams
	{
		// Token: 0x0402B1B5 RID: 176565
		[FieldOffset(0)]
		public IntPtr comboBox;

		// Token: 0x0402B1B6 RID: 176566
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008613 RID: 34323
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetEntityComboBox_FunctionParams
	{
		// Token: 0x0402B1B7 RID: 176567
		[FieldOffset(0)]
		public IntPtr comboBox;

		// Token: 0x0402B1B8 RID: 176568
		[FieldOffset(8)]
		public int entityId;

		// Token: 0x0402B1B9 RID: 176569
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008614 RID: 34324
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDebugEntityId_FunctionParams
	{
		// Token: 0x0402B1BA RID: 176570
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1BB RID: 176571
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008615 RID: 34325
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetDebugEntityId_FunctionParams
	{
		// Token: 0x0402B1BC RID: 176572
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B1BD RID: 176573
		[FieldOffset(8)]
		public int __Result;
	}

	// Token: 0x02008616 RID: 34326
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __RefreshBuffListView_FunctionParams
	{
		// Token: 0x0402B1BE RID: 176574
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1BF RID: 176575
		[FieldOffset(8)]
		public IntPtr listView;

		// Token: 0x0402B1C0 RID: 176576
		[FieldOffset(16)]
		public FString filterStr;

		// Token: 0x0402B1C1 RID: 176577
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008617 RID: 34327
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBuffIdByHandle_FunctionParams
	{
		// Token: 0x0402B1C2 RID: 176578
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1C3 RID: 176579
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402B1C4 RID: 176580
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B1C5 RID: 176581
		[FieldOffset(16)]
		public long __Result;
	}

	// Token: 0x02008618 RID: 34328
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBuffServerIdByHandle_FunctionParams
	{
		// Token: 0x0402B1C6 RID: 176582
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1C7 RID: 176583
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402B1C8 RID: 176584
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B1C9 RID: 176585
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x02008619 RID: 34329
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBuffDescByHandle_FunctionParams
	{
		// Token: 0x0402B1CA RID: 176586
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1CB RID: 176587
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402B1CC RID: 176588
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B1CD RID: 176589
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x0200861A RID: 34330
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBuffActivateByHandle_FunctionParams
	{
		// Token: 0x0402B1CE RID: 176590
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1CF RID: 176591
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402B1D0 RID: 176592
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B1D1 RID: 176593
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200861B RID: 34331
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBuffInstigatorStringByHandle_FunctionParams
	{
		// Token: 0x0402B1D2 RID: 176594
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1D3 RID: 176595
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402B1D4 RID: 176596
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B1D5 RID: 176597
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x0200861C RID: 34332
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBuffPeriodStringByHandle_FunctionParams
	{
		// Token: 0x0402B1D6 RID: 176598
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1D7 RID: 176599
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402B1D8 RID: 176600
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B1D9 RID: 176601
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x0200861D RID: 34333
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBuffDurationStringByHandle_FunctionParams
	{
		// Token: 0x0402B1DA RID: 176602
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1DB RID: 176603
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402B1DC RID: 176604
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B1DD RID: 176605
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x0200861E RID: 34334
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBuffDurationProgress_FunctionParams
	{
		// Token: 0x0402B1DE RID: 176606
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1DF RID: 176607
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402B1E0 RID: 176608
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B1E1 RID: 176609
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x0200861F RID: 34335
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBuffLivingStatusStringByHandle_FunctionParams
	{
		// Token: 0x0402B1E2 RID: 176610
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1E3 RID: 176611
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402B1E4 RID: 176612
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B1E5 RID: 176613
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008620 RID: 34336
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBuffLevelStringByHandle_FunctionParams
	{
		// Token: 0x0402B1E6 RID: 176614
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1E7 RID: 176615
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402B1E8 RID: 176616
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B1E9 RID: 176617
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008621 RID: 34337
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBuffStackStringByHandle_FunctionParams
	{
		// Token: 0x0402B1EA RID: 176618
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1EB RID: 176619
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402B1EC RID: 176620
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B1ED RID: 176621
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008622 RID: 34338
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBuffDebugStringByHandle_FunctionParams
	{
		// Token: 0x0402B1EE RID: 176622
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1EF RID: 176623
		[FieldOffset(4)]
		public int handle;

		// Token: 0x0402B1F0 RID: 176624
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B1F1 RID: 176625
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008623 RID: 34339
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDistance_FunctionParams
	{
		// Token: 0x0402B1F2 RID: 176626
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1F3 RID: 176627
		[FieldOffset(4)]
		public float max;

		// Token: 0x0402B1F4 RID: 176628
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008624 RID: 34340
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetAllMovementHistory_FunctionParams
	{
		// Token: 0x0402B1F5 RID: 176629
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1F6 RID: 176630
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B1F7 RID: 176631
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008625 RID: 34341
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ResetBaseValueLocal_FunctionParams
	{
		// Token: 0x0402B1F8 RID: 176632
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1F9 RID: 176633
		[FieldOffset(4)]
		public int id;

		// Token: 0x0402B1FA RID: 176634
		[FieldOffset(8)]
		public float val;

		// Token: 0x0402B1FB RID: 176635
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008626 RID: 34342
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAttributeCurrentValue_FunctionParams
	{
		// Token: 0x0402B1FC RID: 176636
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B1FD RID: 176637
		[FieldOffset(4)]
		public int attributeId;

		// Token: 0x0402B1FE RID: 176638
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B1FF RID: 176639
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02008627 RID: 34343
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAttributeBaseValue_FunctionParams
	{
		// Token: 0x0402B200 RID: 176640
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B201 RID: 176641
		[FieldOffset(4)]
		public int attributeId;

		// Token: 0x0402B202 RID: 176642
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B203 RID: 176643
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02008628 RID: 34344
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetRageModeId_FunctionParams
	{
		// Token: 0x0402B204 RID: 176644
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B205 RID: 176645
		[FieldOffset(4)]
		public int id;

		// Token: 0x0402B206 RID: 176646
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008629 RID: 34345
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetHardnessModeId_FunctionParams
	{
		// Token: 0x0402B207 RID: 176647
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B208 RID: 176648
		[FieldOffset(4)]
		public int id;

		// Token: 0x0402B209 RID: 176649
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200862A RID: 34346
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 2288)]
	protected ref struct __OnHit_FunctionParams
	{
		// Token: 0x0402B20A RID: 176650
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B20B RID: 176651
		[FieldOffset(8)]
		public byte hitData;

		// Token: 0x0402B20C RID: 176652
		[FieldOffset(2280)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200862B RID: 34347
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetBeHitIgnoreRotate_FunctionParams
	{
		// Token: 0x0402B20D RID: 176653
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B20E RID: 176654
		[FieldOffset(4)]
		public bool ignoreRotate;

		// Token: 0x0402B20F RID: 176655
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200862C RID: 34348
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CheckHasPart_FunctionParams
	{
		// Token: 0x0402B210 RID: 176656
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B211 RID: 176657
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B212 RID: 176658
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200862D RID: 34349
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetPartRemainedLife_FunctionParams
	{
		// Token: 0x0402B213 RID: 176659
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B214 RID: 176660
		[FieldOffset(4)]
		public FGameplayTag tag;

		// Token: 0x0402B215 RID: 176661
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402B216 RID: 176662
		[FieldOffset(24)]
		public float __Result;
	}

	// Token: 0x0200862E RID: 34350
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ResetPartLife_FunctionParams
	{
		// Token: 0x0402B217 RID: 176663
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B218 RID: 176664
		[FieldOffset(4)]
		public FGameplayTag tag;

		// Token: 0x0402B219 RID: 176665
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200862F RID: 34351
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ActiveStiff_FunctionParams
	{
		// Token: 0x0402B21A RID: 176666
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B21B RID: 176667
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008630 RID: 34352
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DeActiveStiff_FunctionParams
	{
		// Token: 0x0402B21C RID: 176668
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B21D RID: 176669
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008631 RID: 34353
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAcceptedNewBeHitAndReset_FunctionParams
	{
		// Token: 0x0402B21E RID: 176670
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B21F RID: 176671
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B220 RID: 176672
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008632 RID: 34354
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetEnterFkAndReset_FunctionParams
	{
		// Token: 0x0402B221 RID: 176673
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B222 RID: 176674
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B223 RID: 176675
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008633 RID: 34355
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsStiff_FunctionParams
	{
		// Token: 0x0402B224 RID: 176676
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B225 RID: 176677
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B226 RID: 176678
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008634 RID: 34356
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetRageModeId_FunctionParams
	{
		// Token: 0x0402B227 RID: 176679
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B228 RID: 176680
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B229 RID: 176681
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02008635 RID: 34357
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHardnessModeId_FunctionParams
	{
		// Token: 0x0402B22A RID: 176682
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B22B RID: 176683
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B22C RID: 176684
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02008636 RID: 34358
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBeHitBone_FunctionParams
	{
		// Token: 0x0402B22D RID: 176685
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B22E RID: 176686
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B22F RID: 176687
		[FieldOffset(16)]
		public FName __Result;
	}

	// Token: 0x02008637 RID: 34359
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetToughDecreaseValue_FunctionParams
	{
		// Token: 0x0402B230 RID: 176688
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B231 RID: 176689
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B232 RID: 176690
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02008638 RID: 34360
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1168)]
	protected ref struct __GetCounterAttackInfoInternal_FunctionParams
	{
		// Token: 0x0402B233 RID: 176691
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B234 RID: 176692
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B235 RID: 176693
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x02008639 RID: 34361
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 568)]
	protected ref struct __GetVisionCounterAttackInfoInternal_FunctionParams
	{
		// Token: 0x0402B236 RID: 176694
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B237 RID: 176695
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B238 RID: 176696
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x0200863A RID: 34362
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBeHitTime_FunctionParams
	{
		// Token: 0x0402B239 RID: 176697
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B23A RID: 176698
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B23B RID: 176699
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x0200863B RID: 34363
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBeHitAnim_FunctionParams
	{
		// Token: 0x0402B23C RID: 176700
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B23D RID: 176701
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B23E RID: 176702
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x0200863C RID: 34364
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetEnterFk_FunctionParams
	{
		// Token: 0x0402B23F RID: 176703
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B240 RID: 176704
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B241 RID: 176705
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200863D RID: 34365
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetBeHitDirect_FunctionParams
	{
		// Token: 0x0402B242 RID: 176706
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B243 RID: 176707
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B244 RID: 176708
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x0200863E RID: 34366
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetBeHitLocation_FunctionParams
	{
		// Token: 0x0402B245 RID: 176709
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B246 RID: 176710
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B247 RID: 176711
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x0200863F RID: 34367
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __AddCheckBuffList_FunctionParams
	{
		// Token: 0x0402B248 RID: 176712
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B249 RID: 176713
		[FieldOffset(8)]
		public SCounterAttackBuff addValue;

		// Token: 0x0402B24A RID: 176714
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008640 RID: 34368
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ClearCheckBuffList_FunctionParams
	{
		// Token: 0x0402B24B RID: 176715
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B24C RID: 176716
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008641 RID: 34369
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __CounterAttackEnd_FunctionParams
	{
		// Token: 0x0402B24D RID: 176717
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B24E RID: 176718
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008642 RID: 34370
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __VisionCounterAttackEnd_FunctionParams
	{
		// Token: 0x0402B24F RID: 176719
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B250 RID: 176720
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008643 RID: 34371
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCounterAttackEndTime_FunctionParams
	{
		// Token: 0x0402B251 RID: 176721
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B252 RID: 176722
		[FieldOffset(4)]
		public float baseTime;

		// Token: 0x0402B253 RID: 176723
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008644 RID: 34372
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsTriggerCounterAttack_FunctionParams
	{
		// Token: 0x0402B254 RID: 176724
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B255 RID: 176725
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B256 RID: 176726
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008645 RID: 34373
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ResetTarget_FunctionParams
	{
		// Token: 0x0402B257 RID: 176727
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B258 RID: 176728
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008646 RID: 34374
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetShowTarget_FunctionParams
	{
		// Token: 0x0402B259 RID: 176729
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B25A RID: 176730
		[FieldOffset(8)]
		public IntPtr actor;

		// Token: 0x0402B25B RID: 176731
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008647 RID: 34375
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ExitLockDirection_FunctionParams
	{
		// Token: 0x0402B25C RID: 176732
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B25D RID: 176733
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008648 RID: 34376
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnterLockDirection_FunctionParams
	{
		// Token: 0x0402B25E RID: 176734
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B25F RID: 176735
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008649 RID: 34377
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCurrentTarget_FunctionParams
	{
		// Token: 0x0402B260 RID: 176736
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B261 RID: 176737
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B262 RID: 176738
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x0200864A RID: 34378
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetLockOnDebugLine_FunctionParams
	{
		// Token: 0x0402B263 RID: 176739
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B264 RID: 176740
		[FieldOffset(4)]
		public bool isShow;

		// Token: 0x0402B265 RID: 176741
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200864B RID: 34379
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ManipulateValid_FunctionParams
	{
		// Token: 0x0402B266 RID: 176742
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B267 RID: 176743
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B268 RID: 176744
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200864C RID: 34380
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ManipulateGetDrawTarget_FunctionParams
	{
		// Token: 0x0402B269 RID: 176745
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B26A RID: 176746
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B26B RID: 176747
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x0200864D RID: 34381
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ManipulateGetCastTarget_FunctionParams
	{
		// Token: 0x0402B26C RID: 176748
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B26D RID: 176749
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B26E RID: 176750
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x0200864E RID: 34382
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ManipulateGetDrawTargetChantTime_FunctionParams
	{
		// Token: 0x0402B26F RID: 176751
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B270 RID: 176752
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B271 RID: 176753
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x0200864F RID: 34383
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ManipulateChant_FunctionParams
	{
		// Token: 0x0402B272 RID: 176754
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B273 RID: 176755
		[FieldOffset(8)]
		public IntPtr eventBinder;

		// Token: 0x0402B274 RID: 176756
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402B275 RID: 176757
		[FieldOffset(24)]
		public bool __Result;
	}

	// Token: 0x02008650 RID: 34384
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ManipulateDraw_FunctionParams
	{
		// Token: 0x0402B276 RID: 176758
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B277 RID: 176759
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B278 RID: 176760
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008651 RID: 34385
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ManipulateCast_FunctionParams
	{
		// Token: 0x0402B279 RID: 176761
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B27A RID: 176762
		[FieldOffset(4)]
		public float direction;

		// Token: 0x0402B27B RID: 176763
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B27C RID: 176764
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008652 RID: 34386
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ManipulateReset_FunctionParams
	{
		// Token: 0x0402B27D RID: 176765
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B27E RID: 176766
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008653 RID: 34387
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ManipulateChangeToProjectileState_FunctionParams
	{
		// Token: 0x0402B27F RID: 176767
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B280 RID: 176768
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B281 RID: 176769
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008654 RID: 34388
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ManipulateChangeToNormalState_FunctionParams
	{
		// Token: 0x0402B282 RID: 176770
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B283 RID: 176771
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B284 RID: 176772
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008655 RID: 34389
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHoldingActor_FunctionParams
	{
		// Token: 0x0402B285 RID: 176773
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B286 RID: 176774
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B287 RID: 176775
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02008656 RID: 34390
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __HasHoldingActor_FunctionParams
	{
		// Token: 0x0402B288 RID: 176776
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B289 RID: 176777
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B28A RID: 176778
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008657 RID: 34391
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDebugDraw_FunctionParams
	{
		// Token: 0x0402B28B RID: 176779
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B28C RID: 176780
		[FieldOffset(4)]
		public bool isActive;

		// Token: 0x0402B28D RID: 176781
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008658 RID: 34392
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ExtraAction_FunctionParams
	{
		// Token: 0x0402B28E RID: 176782
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B28F RID: 176783
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008659 RID: 34393
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetQtePosition_FunctionParams
	{
		// Token: 0x0402B290 RID: 176784
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B291 RID: 176785
		[FieldOffset(4)]
		public float rotate;

		// Token: 0x0402B292 RID: 176786
		[FieldOffset(8)]
		public float length;

		// Token: 0x0402B293 RID: 176787
		[FieldOffset(12)]
		public float height;

		// Token: 0x0402B294 RID: 176788
		[FieldOffset(16)]
		public bool referenceTarget;

		// Token: 0x0402B295 RID: 176789
		[FieldOffset(17)]
		public bool adjustWithMonster;

		// Token: 0x0402B296 RID: 176790
		[FieldOffset(20)]
		public float addHeight;

		// Token: 0x0402B297 RID: 176791
		[FieldOffset(24)]
		public int qteType;

		// Token: 0x0402B298 RID: 176792
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200865A RID: 34394
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetGoBattleActor_FunctionParams
	{
		// Token: 0x0402B299 RID: 176793
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B29A RID: 176794
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B29B RID: 176795
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x0200865B RID: 34395
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetDtSkillInfo_FunctionParams
	{
		// Token: 0x0402B29C RID: 176796
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B29D RID: 176797
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B29E RID: 176798
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x0200865C RID: 34396
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __GetDtSkillInfoMapForDebug_FunctionParams
	{
		// Token: 0x0402B29F RID: 176799
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2A0 RID: 176800
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B2A1 RID: 176801
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x0200865D RID: 34397
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetLastActivateSkillTime_FunctionParams
	{
		// Token: 0x0402B2A2 RID: 176802
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2A3 RID: 176803
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B2A4 RID: 176804
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x0200865E RID: 34398
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetLastActivateSkillTime_FunctionParams
	{
		// Token: 0x0402B2A5 RID: 176805
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2A6 RID: 176806
		[FieldOffset(4)]
		public float time;

		// Token: 0x0402B2A7 RID: 176807
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200865F RID: 34399
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetSkillElevationAngle_FunctionParams
	{
		// Token: 0x0402B2A8 RID: 176808
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2A9 RID: 176809
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B2AA RID: 176810
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02008660 RID: 34400
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetSkillElevationAngle_FunctionParams
	{
		// Token: 0x0402B2AB RID: 176811
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2AC RID: 176812
		[FieldOffset(4)]
		public float angle;

		// Token: 0x0402B2AD RID: 176813
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008661 RID: 34401
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __CurrentSkillId_FunctionParams
	{
		// Token: 0x0402B2AE RID: 176814
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2AF RID: 176815
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B2B0 RID: 176816
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008662 RID: 34402
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CurrentPriority_FunctionParams
	{
		// Token: 0x0402B2B1 RID: 176817
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2B2 RID: 176818
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B2B3 RID: 176819
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x02008663 RID: 34403
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCurrentPriority_FunctionParams
	{
		// Token: 0x0402B2B4 RID: 176820
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2B5 RID: 176821
		[FieldOffset(4)]
		public int priority;

		// Token: 0x0402B2B6 RID: 176822
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008664 RID: 34404
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __HasAbility_FunctionParams
	{
		// Token: 0x0402B2B7 RID: 176823
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2B8 RID: 176824
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402B2B9 RID: 176825
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402B2BA RID: 176826
		[FieldOffset(32)]
		public bool __Result;
	}

	// Token: 0x02008665 RID: 34405
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 520)]
	protected ref struct __GetSkillInfo_FunctionParams
	{
		// Token: 0x0402B2BB RID: 176827
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2BC RID: 176828
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402B2BD RID: 176829
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402B2BE RID: 176830
		[FieldOffset(32)]
		public byte __Result;
	}

	// Token: 0x02008666 RID: 34406
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetSkillPriority_FunctionParams
	{
		// Token: 0x0402B2BF RID: 176831
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2C0 RID: 176832
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402B2C1 RID: 176833
		[FieldOffset(24)]
		public float priority;

		// Token: 0x0402B2C2 RID: 176834
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008667 RID: 34407
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __EndSkill_FunctionParams
	{
		// Token: 0x0402B2C3 RID: 176835
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2C4 RID: 176836
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402B2C5 RID: 176837
		[FieldOffset(24)]
		public bool isSyn;

		// Token: 0x0402B2C6 RID: 176838
		[FieldOffset(25)]
		public bool isNotEnd;

		// Token: 0x0402B2C7 RID: 176839
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008668 RID: 34408
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __BeginSkill_FunctionParams
	{
		// Token: 0x0402B2C8 RID: 176840
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2C9 RID: 176841
		[FieldOffset(4)]
		public FName skillId;

		// Token: 0x0402B2CA RID: 176842
		[FieldOffset(16)]
		public bool isSyn;

		// Token: 0x0402B2CB RID: 176843
		[FieldOffset(24)]
		public IntPtr target;

		// Token: 0x0402B2CC RID: 176844
		[FieldOffset(32)]
		public FName socketName;

		// Token: 0x0402B2CD RID: 176845
		[FieldOffset(48)]
		public IntPtr __WorldContext;

		// Token: 0x0402B2CE RID: 176846
		[FieldOffset(56)]
		public bool __Result;
	}

	// Token: 0x02008669 RID: 34409
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __BeginSkillAsync_FunctionParams
	{
		// Token: 0x0402B2CF RID: 176847
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2D0 RID: 176848
		[FieldOffset(4)]
		public FName skillId;

		// Token: 0x0402B2D1 RID: 176849
		[FieldOffset(16)]
		public IntPtr target;

		// Token: 0x0402B2D2 RID: 176850
		[FieldOffset(24)]
		public FName socketName;

		// Token: 0x0402B2D3 RID: 176851
		[FieldOffset(40)]
		public IntPtr eventBinder;

		// Token: 0x0402B2D4 RID: 176852
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200866A RID: 34410
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 864)]
	protected ref struct __SkillBehaviorBegin_FunctionParams
	{
		// Token: 0x0402B2D5 RID: 176853
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2D6 RID: 176854
		[FieldOffset(8)]
		public IntPtr ga;

		// Token: 0x0402B2D7 RID: 176855
		[FieldOffset(16)]
		public byte action;

		// Token: 0x0402B2D8 RID: 176856
		[FieldOffset(856)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200866B RID: 34411
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 888)]
	protected ref struct __GetLocationByAction_FunctionParams
	{
		// Token: 0x0402B2D9 RID: 176857
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2DA RID: 176858
		[FieldOffset(8)]
		public IntPtr ga;

		// Token: 0x0402B2DB RID: 176859
		[FieldOffset(16)]
		public byte action;

		// Token: 0x0402B2DC RID: 176860
		[FieldOffset(856)]
		public IntPtr __WorldContext;

		// Token: 0x0402B2DD RID: 176861
		[FieldOffset(864)]
		public FVectorDouble __Result;
	}

	// Token: 0x0200866C RID: 34412
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 880)]
	protected ref struct __GetRotationByAction_FunctionParams
	{
		// Token: 0x0402B2DE RID: 176862
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2DF RID: 176863
		[FieldOffset(8)]
		public IntPtr ga;

		// Token: 0x0402B2E0 RID: 176864
		[FieldOffset(16)]
		public byte action;

		// Token: 0x0402B2E1 RID: 176865
		[FieldOffset(856)]
		public IntPtr __WorldContext;

		// Token: 0x0402B2E2 RID: 176866
		[FieldOffset(864)]
		public FRotator __Result;
	}

	// Token: 0x0200866D RID: 34413
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 104)]
	protected ref struct __SkillBehaviorSatisfy_FunctionParams
	{
		// Token: 0x0402B2E3 RID: 176867
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2E4 RID: 176868
		[FieldOffset(8)]
		public IntPtr ga;

		// Token: 0x0402B2E5 RID: 176869
		[FieldOffset(16)]
		public byte condition;

		// Token: 0x0402B2E6 RID: 176870
		[FieldOffset(88)]
		public IntPtr __WorldContext;

		// Token: 0x0402B2E7 RID: 176871
		[FieldOffset(96)]
		public bool __Result;
	}

	// Token: 0x0200866E RID: 34414
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetSkillTarget_FunctionParams
	{
		// Token: 0x0402B2E8 RID: 176872
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2E9 RID: 176873
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B2EA RID: 176874
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x0200866F RID: 34415
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetSkillTarget_FunctionParams
	{
		// Token: 0x0402B2EB RID: 176875
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2EC RID: 176876
		[FieldOffset(8)]
		public IntPtr target;

		// Token: 0x0402B2ED RID: 176877
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008670 RID: 34416
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __LockOnTargetAndSetShow_FunctionParams
	{
		// Token: 0x0402B2EE RID: 176878
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2EF RID: 176879
		[FieldOffset(8)]
		public byte config;

		// Token: 0x0402B2F0 RID: 176880
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008671 RID: 34417
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsHasInputDir_FunctionParams
	{
		// Token: 0x0402B2F1 RID: 176881
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2F2 RID: 176882
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B2F3 RID: 176883
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008672 RID: 34418
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetSkillIdWithGroupId_FunctionParams
	{
		// Token: 0x0402B2F4 RID: 176884
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2F5 RID: 176885
		[FieldOffset(4)]
		public int groupId;

		// Token: 0x0402B2F6 RID: 176886
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B2F7 RID: 176887
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008673 RID: 34419
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetSkillAcceptInput_FunctionParams
	{
		// Token: 0x0402B2F8 RID: 176888
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2F9 RID: 176889
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B2FA RID: 176890
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008674 RID: 34420
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetSkillAcceptInput_FunctionParams
	{
		// Token: 0x0402B2FB RID: 176891
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2FC RID: 176892
		[FieldOffset(4)]
		public bool skillAcceptInput;

		// Token: 0x0402B2FD RID: 176893
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008675 RID: 34421
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCommonSkillCanBeInterrupt_FunctionParams
	{
		// Token: 0x0402B2FE RID: 176894
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B2FF RID: 176895
		[FieldOffset(4)]
		public bool canBeInterrupt;

		// Token: 0x0402B300 RID: 176896
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008676 RID: 34422
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCommonSkillCanBeInterrupt_FunctionParams
	{
		// Token: 0x0402B301 RID: 176897
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B302 RID: 176898
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B303 RID: 176899
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008677 RID: 34423
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __OnActivateAbility_FunctionParams
	{
		// Token: 0x0402B304 RID: 176900
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B305 RID: 176901
		[FieldOffset(8)]
		public IntPtr ga;

		// Token: 0x0402B306 RID: 176902
		[FieldOffset(16)]
		public bool isCommitSuccess;

		// Token: 0x0402B307 RID: 176903
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402B308 RID: 176904
		[FieldOffset(32)]
		public float __Result;
	}

	// Token: 0x02008678 RID: 34424
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __OnEndAbility_FunctionParams
	{
		// Token: 0x0402B309 RID: 176905
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B30A RID: 176906
		[FieldOffset(8)]
		public IntPtr ga;

		// Token: 0x0402B30B RID: 176907
		[FieldOffset(16)]
		public bool wasCancelled;

		// Token: 0x0402B30C RID: 176908
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008679 RID: 34425
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetPriority_FunctionParams
	{
		// Token: 0x0402B30D RID: 176909
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B30E RID: 176910
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402B30F RID: 176911
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402B310 RID: 176912
		[FieldOffset(32)]
		public float __Result;
	}

	// Token: 0x0200867A RID: 34426
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetActivePriority_FunctionParams
	{
		// Token: 0x0402B311 RID: 176913
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B312 RID: 176914
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402B313 RID: 176915
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402B314 RID: 176916
		[FieldOffset(32)]
		public float __Result;
	}

	// Token: 0x0200867B RID: 34427
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetSkillMontageInstance_FunctionParams
	{
		// Token: 0x0402B315 RID: 176917
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B316 RID: 176918
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402B317 RID: 176919
		[FieldOffset(24)]
		public int index;

		// Token: 0x0402B318 RID: 176920
		[FieldOffset(32)]
		public IntPtr __WorldContext;

		// Token: 0x0402B319 RID: 176921
		[FieldOffset(40)]
		public IntPtr __Result;
	}

	// Token: 0x0200867C RID: 34428
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetSkillNeedPlayMontageIndex_FunctionParams
	{
		// Token: 0x0402B31A RID: 176922
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B31B RID: 176923
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402B31C RID: 176924
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402B31D RID: 176925
		[FieldOffset(32)]
		public int __Result;
	}

	// Token: 0x0200867D RID: 34429
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __CreateSpecifiedTagPlayMontageAndWaitAbilityTask_FunctionParams
	{
		// Token: 0x0402B31E RID: 176926
		[FieldOffset(0)]
		public IntPtr gameplayAbility;

		// Token: 0x0402B31F RID: 176927
		[FieldOffset(8)]
		public bool checkHit;

		// Token: 0x0402B320 RID: 176928
		[FieldOffset(12)]
		public FGameplayTag skeletalMeshComponentTag;

		// Token: 0x0402B321 RID: 176929
		[FieldOffset(24)]
		public int montageIndex;

		// Token: 0x0402B322 RID: 176930
		[FieldOffset(28)]
		public FName startSection;

		// Token: 0x0402B323 RID: 176931
		[FieldOffset(40)]
		public float startTimeSeconds;

		// Token: 0x0402B324 RID: 176932
		[FieldOffset(44)]
		public bool needTick;

		// Token: 0x0402B325 RID: 176933
		[FieldOffset(48)]
		public float animRootMotionTranslationScale;

		// Token: 0x0402B326 RID: 176934
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200867E RID: 34430
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetSkillRotateLocation_FunctionParams
	{
		// Token: 0x0402B327 RID: 176935
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B328 RID: 176936
		[FieldOffset(8)]
		public FVectorDouble location;

		// Token: 0x0402B329 RID: 176937
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200867F RID: 34431
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetSkillRotateDirect_FunctionParams
	{
		// Token: 0x0402B32A RID: 176938
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B32B RID: 176939
		[FieldOffset(8)]
		public FVectorDouble direct;

		// Token: 0x0402B32C RID: 176940
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008680 RID: 34432
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __CallAnimBreakPoint_FunctionParams
	{
		// Token: 0x0402B32D RID: 176941
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B32E RID: 176942
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008681 RID: 34433
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __RollingGround_FunctionParams
	{
		// Token: 0x0402B32F RID: 176943
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B330 RID: 176944
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008682 RID: 34434
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ActivateAbilityVision_FunctionParams
	{
		// Token: 0x0402B331 RID: 176945
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B332 RID: 176946
		[FieldOffset(4)]
		public byte visionType;

		// Token: 0x0402B333 RID: 176947
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B334 RID: 176948
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008683 RID: 34435
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __EndAbilityVision_FunctionParams
	{
		// Token: 0x0402B335 RID: 176949
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B336 RID: 176950
		[FieldOffset(4)]
		public byte visionType;

		// Token: 0x0402B337 RID: 176951
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B338 RID: 176952
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008684 RID: 34436
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ActivateAbilityVisionPlayAudio_FunctionParams
	{
		// Token: 0x0402B339 RID: 176953
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B33A RID: 176954
		[FieldOffset(4)]
		public byte visionType;

		// Token: 0x0402B33B RID: 176955
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008685 RID: 34437
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetVisionIdList_FunctionParams
	{
		// Token: 0x0402B33C RID: 176956
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B33D RID: 176957
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B33E RID: 176958
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x02008686 RID: 34438
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ExitMultiSkillStateOfMorphVision_FunctionParams
	{
		// Token: 0x0402B33F RID: 176959
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B340 RID: 176960
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008687 RID: 34439
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetKeepMultiSkillState_FunctionParams
	{
		// Token: 0x0402B341 RID: 176961
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B342 RID: 176962
		[FieldOffset(4)]
		public bool keepOnMorphEnd;

		// Token: 0x0402B343 RID: 176963
		[FieldOffset(5)]
		public bool keepOnGoDown;

		// Token: 0x0402B344 RID: 176964
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008688 RID: 34440
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetEnableAttackInputActionOfMorphVision_FunctionParams
	{
		// Token: 0x0402B345 RID: 176965
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B346 RID: 176966
		[FieldOffset(4)]
		public bool bEnable;

		// Token: 0x0402B347 RID: 176967
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008689 RID: 34441
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetVisionLevelList_FunctionParams
	{
		// Token: 0x0402B348 RID: 176968
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B349 RID: 176969
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B34A RID: 176970
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x0200868A RID: 34442
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetVisionSkillId_FunctionParams
	{
		// Token: 0x0402B34B RID: 176971
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B34C RID: 176972
		[FieldOffset(4)]
		public float visionId;

		// Token: 0x0402B34D RID: 176973
		[FieldOffset(8)]
		public float level;

		// Token: 0x0402B34E RID: 176974
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402B34F RID: 176975
		[FieldOffset(24)]
		public int __Result;
	}

	// Token: 0x0200868B RID: 34443
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __InterruptSkill_FunctionParams
	{
		// Token: 0x0402B350 RID: 176976
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B351 RID: 176977
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402B352 RID: 176978
		[FieldOffset(24)]
		public bool isSyn;

		// Token: 0x0402B353 RID: 176979
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200868C RID: 34444
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DeleteSkills_FunctionParams
	{
		// Token: 0x0402B354 RID: 176980
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B355 RID: 176981
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200868D RID: 34445
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetCurrentMontageCorrespondingSkillId_FunctionParams
	{
		// Token: 0x0402B356 RID: 176982
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B357 RID: 176983
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B358 RID: 176984
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x0200868E RID: 34446
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetSocketName_FunctionParams
	{
		// Token: 0x0402B359 RID: 176985
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B35A RID: 176986
		[FieldOffset(8)]
		public FString socketName;

		// Token: 0x0402B35B RID: 176987
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200868F RID: 34447
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetSocketName_FunctionParams
	{
		// Token: 0x0402B35C RID: 176988
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B35D RID: 176989
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B35E RID: 176990
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008690 RID: 34448
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __GetPointTransform_FunctionParams
	{
		// Token: 0x0402B35F RID: 176991
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B360 RID: 176992
		[FieldOffset(8)]
		public FString boneName;

		// Token: 0x0402B361 RID: 176993
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402B362 RID: 176994
		[FieldOffset(32)]
		public FTransformDouble __Result;
	}

	// Token: 0x02008691 RID: 34449
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __PlaySkillMontage2Server_FunctionParams
	{
		// Token: 0x0402B363 RID: 176995
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B364 RID: 176996
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402B365 RID: 176997
		[FieldOffset(24)]
		public float montageIndex;

		// Token: 0x0402B366 RID: 176998
		[FieldOffset(28)]
		public float rate;

		// Token: 0x0402B367 RID: 176999
		[FieldOffset(32)]
		public FString startSection;

		// Token: 0x0402B368 RID: 177000
		[FieldOffset(48)]
		public float startTimeSeconds;

		// Token: 0x0402B369 RID: 177001
		[FieldOffset(56)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008692 RID: 34450
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __EndSkillMontage_FunctionParams
	{
		// Token: 0x0402B36A RID: 177002
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B36B RID: 177003
		[FieldOffset(8)]
		public FString skillId;

		// Token: 0x0402B36C RID: 177004
		[FieldOffset(24)]
		public float montageIndex;

		// Token: 0x0402B36D RID: 177005
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008693 RID: 34451
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __BeginAddMoveByInputDirect_FunctionParams
	{
		// Token: 0x0402B36E RID: 177006
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B36F RID: 177007
		[FieldOffset(4)]
		public float maxSpeed;

		// Token: 0x0402B370 RID: 177008
		[FieldOffset(8)]
		public float accelerationTime;

		// Token: 0x0402B371 RID: 177009
		[FieldOffset(12)]
		public float decelerationTime;

		// Token: 0x0402B372 RID: 177010
		[FieldOffset(16)]
		public float delayTime;

		// Token: 0x0402B373 RID: 177011
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008694 RID: 34452
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __BeginAbsoluteTimeStop_FunctionParams
	{
		// Token: 0x0402B374 RID: 177012
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B375 RID: 177013
		[FieldOffset(4)]
		public float duration;

		// Token: 0x0402B376 RID: 177014
		[FieldOffset(8)]
		public bool stopMove;

		// Token: 0x0402B377 RID: 177015
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008695 RID: 34453
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EndAbsoluteTimeStop_FunctionParams
	{
		// Token: 0x0402B378 RID: 177016
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B379 RID: 177017
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008696 RID: 34454
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __BeginTimeStopRequest_FunctionParams
	{
		// Token: 0x0402B37A RID: 177018
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B37B RID: 177019
		[FieldOffset(4)]
		public float duration;

		// Token: 0x0402B37C RID: 177020
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008697 RID: 34455
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EndTimeStopRequest_FunctionParams
	{
		// Token: 0x0402B37D RID: 177021
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B37E RID: 177022
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008698 RID: 34456
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EndAddMoveByInputDirect_FunctionParams
	{
		// Token: 0x0402B37F RID: 177023
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B380 RID: 177024
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008699 RID: 34457
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CanActivateFixHook_FunctionParams
	{
		// Token: 0x0402B381 RID: 177025
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B382 RID: 177026
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B383 RID: 177027
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200869A RID: 34458
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __FixHookTargetLocation_FunctionParams
	{
		// Token: 0x0402B384 RID: 177028
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B385 RID: 177029
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B386 RID: 177030
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x0200869B RID: 34459
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __FixHookTargetPathways_FunctionParams
	{
		// Token: 0x0402B387 RID: 177031
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B388 RID: 177032
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B389 RID: 177033
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x0200869C RID: 34460
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FixHookTargetEnterPortalCapture_FunctionParams
	{
		// Token: 0x0402B38A RID: 177034
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B38B RID: 177035
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B38C RID: 177036
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x0200869D RID: 34461
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FixHookTargetActor_FunctionParams
	{
		// Token: 0x0402B38D RID: 177037
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B38E RID: 177038
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B38F RID: 177039
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x0200869E RID: 34462
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FixHookTargetIsSuiGuangType_FunctionParams
	{
		// Token: 0x0402B390 RID: 177040
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B391 RID: 177041
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B392 RID: 177042
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200869F RID: 34463
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHookTargetType_FunctionParams
	{
		// Token: 0x0402B393 RID: 177043
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B394 RID: 177044
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B395 RID: 177045
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x020086A0 RID: 34464
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __FixHookTargetForward_FunctionParams
	{
		// Token: 0x0402B396 RID: 177046
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B397 RID: 177047
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B398 RID: 177048
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x020086A1 RID: 34465
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __NextFixHookTargetLocation_FunctionParams
	{
		// Token: 0x0402B399 RID: 177049
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B39A RID: 177050
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B39B RID: 177051
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x020086A2 RID: 34466
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FixHookTargetInheritSpeed_FunctionParams
	{
		// Token: 0x0402B39C RID: 177052
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B39D RID: 177053
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B39E RID: 177054
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020086A3 RID: 34467
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FixHookTargetIsClimb_FunctionParams
	{
		// Token: 0x0402B39F RID: 177055
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3A0 RID: 177056
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B3A1 RID: 177057
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020086A4 RID: 34468
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetIsHookEndByInterrupt_FunctionParams
	{
		// Token: 0x0402B3A2 RID: 177058
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3A3 RID: 177059
		[FieldOffset(4)]
		public bool isInterrupt;

		// Token: 0x0402B3A4 RID: 177060
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086A5 RID: 34469
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FixHookIsSummitPoint_FunctionParams
	{
		// Token: 0x0402B3A5 RID: 177061
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3A6 RID: 177062
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B3A7 RID: 177063
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020086A6 RID: 34470
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FixHookIsNormalPoint_FunctionParams
	{
		// Token: 0x0402B3A8 RID: 177064
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3A9 RID: 177065
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B3AA RID: 177066
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020086A7 RID: 34471
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHookOverrideSpeed_FunctionParams
	{
		// Token: 0x0402B3AB RID: 177067
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3AC RID: 177068
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B3AD RID: 177069
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x020086A8 RID: 34472
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FixHookIsGravityPoint_FunctionParams
	{
		// Token: 0x0402B3AE RID: 177070
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3AF RID: 177071
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B3B0 RID: 177072
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020086A9 RID: 34473
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __KiteHookSupportSwitchMidway_FunctionParams
	{
		// Token: 0x0402B3B1 RID: 177073
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3B2 RID: 177074
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B3B3 RID: 177075
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020086AA RID: 34474
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FixHookTargetEntityId_FunctionParams
	{
		// Token: 0x0402B3B4 RID: 177076
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3B5 RID: 177077
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B3B6 RID: 177078
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x020086AB RID: 34475
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SlashHookPointHasLookAtConfig_FunctionParams
	{
		// Token: 0x0402B3B7 RID: 177079
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3B8 RID: 177080
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B3B9 RID: 177081
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020086AC RID: 34476
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SlashHookPointCharacterLookAtPoint_FunctionParams
	{
		// Token: 0x0402B3BA RID: 177082
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3BB RID: 177083
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B3BC RID: 177084
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x020086AD RID: 34477
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SlashHookPointIsTakeOverCamera_FunctionParams
	{
		// Token: 0x0402B3BD RID: 177085
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3BE RID: 177086
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B3BF RID: 177087
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020086AE RID: 34478
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SlashHookPointSafePointLoc_FunctionParams
	{
		// Token: 0x0402B3C0 RID: 177088
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3C1 RID: 177089
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B3C2 RID: 177090
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x020086AF RID: 34479
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SlashHookPointSafePointRot_FunctionParams
	{
		// Token: 0x0402B3C3 RID: 177091
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3C4 RID: 177092
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B3C5 RID: 177093
		[FieldOffset(16)]
		public FRotator __Result;
	}

	// Token: 0x020086B0 RID: 34480
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __StartChargeSlash_FunctionParams
	{
		// Token: 0x0402B3C6 RID: 177094
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3C7 RID: 177095
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086B1 RID: 34481
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __StopChargeSlash_FunctionParams
	{
		// Token: 0x0402B3C8 RID: 177096
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3C9 RID: 177097
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086B2 RID: 34482
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsSlashGameplayIsSuccess_FunctionParams
	{
		// Token: 0x0402B3CA RID: 177098
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B3CB RID: 177099
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x020086B3 RID: 34483
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __GetGravityHookLockInfo_FunctionParams
	{
		// Token: 0x0402B3CC RID: 177100
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3CD RID: 177101
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B3CE RID: 177102
		[FieldOffset(16)]
		public SGravityHookLockInfo __Result;
	}

	// Token: 0x020086B4 RID: 34484
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ChangeGravityByHook_FunctionParams
	{
		// Token: 0x0402B3CF RID: 177103
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3D0 RID: 177104
		[FieldOffset(4)]
		public int angleRangeMin;

		// Token: 0x0402B3D1 RID: 177105
		[FieldOffset(8)]
		public int angleRangeMax;

		// Token: 0x0402B3D2 RID: 177106
		[FieldOffset(12)]
		public float smoothSecondMin;

		// Token: 0x0402B3D3 RID: 177107
		[FieldOffset(16)]
		public float smoothSecondMax;

		// Token: 0x0402B3D4 RID: 177108
		[FieldOffset(20)]
		public bool isLerpCamera;

		// Token: 0x0402B3D5 RID: 177109
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086B5 RID: 34485
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetIgnoreSocketName_FunctionParams
	{
		// Token: 0x0402B3D6 RID: 177110
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3D7 RID: 177111
		[FieldOffset(8)]
		public FString socketName;

		// Token: 0x0402B3D8 RID: 177112
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086B6 RID: 34486
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __DeleteIgnoreSocketName_FunctionParams
	{
		// Token: 0x0402B3D9 RID: 177113
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3DA RID: 177114
		[FieldOffset(8)]
		public FString socketName;

		// Token: 0x0402B3DB RID: 177115
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086B7 RID: 34487
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetToTargetSocketDistance_FunctionParams
	{
		// Token: 0x0402B3DC RID: 177116
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3DD RID: 177117
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B3DE RID: 177118
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020086B8 RID: 34488
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 192)]
	protected ref struct __SetPredictProjectileInfo_FunctionParams
	{
		// Token: 0x0402B3DF RID: 177119
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3E0 RID: 177120
		[FieldOffset(4)]
		public bool returnValue;

		// Token: 0x0402B3E1 RID: 177121
		[FieldOffset(8)]
		public byte outPathPosition;

		// Token: 0x0402B3E2 RID: 177122
		[FieldOffset(24)]
		public FVector outLastTraceDestination;

		// Token: 0x0402B3E3 RID: 177123
		[FieldOffset(36)]
		public byte outHit;

		// Token: 0x0402B3E4 RID: 177124
		[FieldOffset(184)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086B9 RID: 34489
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetVisible_FunctionParams
	{
		// Token: 0x0402B3E5 RID: 177125
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3E6 RID: 177126
		[FieldOffset(4)]
		public bool isShow;

		// Token: 0x0402B3E7 RID: 177127
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086BA RID: 34490
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCharUnifiedMoveState_FunctionParams
	{
		// Token: 0x0402B3E8 RID: 177128
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3E9 RID: 177129
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B3EA RID: 177130
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x020086BB RID: 34491
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCharUnifiedPositionState_FunctionParams
	{
		// Token: 0x0402B3EB RID: 177131
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3EC RID: 177132
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B3ED RID: 177133
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x020086BC RID: 34492
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ExitHitState_FunctionParams
	{
		// Token: 0x0402B3EE RID: 177134
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3EF RID: 177135
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086BD RID: 34493
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDirectionState_FunctionParams
	{
		// Token: 0x0402B3F0 RID: 177136
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3F1 RID: 177137
		[FieldOffset(4)]
		public byte newViewState;

		// Token: 0x0402B3F2 RID: 177138
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086BE RID: 34494
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetDirectionState_FunctionParams
	{
		// Token: 0x0402B3F3 RID: 177139
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3F4 RID: 177140
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B3F5 RID: 177141
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x020086BF RID: 34495
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetIsInGame_FunctionParams
	{
		// Token: 0x0402B3F6 RID: 177142
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3F7 RID: 177143
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B3F8 RID: 177144
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020086C0 RID: 34496
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SprintPress_FunctionParams
	{
		// Token: 0x0402B3F9 RID: 177145
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3FA RID: 177146
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086C1 RID: 34497
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SprintRelease_FunctionParams
	{
		// Token: 0x0402B3FB RID: 177147
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3FC RID: 177148
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086C2 RID: 34498
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __StandPress_FunctionParams
	{
		// Token: 0x0402B3FD RID: 177149
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B3FE RID: 177150
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086C3 RID: 34499
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SwingPress_FunctionParams
	{
		// Token: 0x0402B3FF RID: 177151
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B400 RID: 177152
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086C4 RID: 34500
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SwingRelease_FunctionParams
	{
		// Token: 0x0402B401 RID: 177153
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B402 RID: 177154
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086C5 RID: 34501
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __CustomSetWalkOrRun_FunctionParams
	{
		// Token: 0x0402B403 RID: 177155
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B404 RID: 177156
		[FieldOffset(4)]
		public bool isWalk;

		// Token: 0x0402B405 RID: 177157
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086C6 RID: 34502
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnterAimStatus_FunctionParams
	{
		// Token: 0x0402B406 RID: 177158
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B407 RID: 177159
		[FieldOffset(4)]
		public byte aimViewState;

		// Token: 0x0402B408 RID: 177160
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086C7 RID: 34503
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ExitAimStatus_FunctionParams
	{
		// Token: 0x0402B409 RID: 177161
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B40A RID: 177162
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086C8 RID: 34504
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnableEntity_FunctionParams
	{
		// Token: 0x0402B40B RID: 177163
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B40C RID: 177164
		[FieldOffset(4)]
		public bool isEnable;

		// Token: 0x0402B40D RID: 177165
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086C9 RID: 34505
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoHit_FunctionParams
	{
		// Token: 0x0402B40E RID: 177166
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B40F RID: 177167
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x0402B410 RID: 177168
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086CA RID: 34506
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoFk_FunctionParams
	{
		// Token: 0x0402B411 RID: 177169
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B412 RID: 177170
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x0402B413 RID: 177171
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086CB RID: 34507
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoUnifiedState_FunctionParams
	{
		// Token: 0x0402B414 RID: 177172
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B415 RID: 177173
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x0402B416 RID: 177174
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086CC RID: 34508
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __UpdateAnimInfoUnifiedStateRoleNpc_FunctionParams
	{
		// Token: 0x0402B417 RID: 177175
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B418 RID: 177176
		[FieldOffset(8)]
		public IntPtr animLogicParams;

		// Token: 0x0402B419 RID: 177177
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086CD RID: 34509
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetIsCharRotateWithCameraWhenManipulate_FunctionParams
	{
		// Token: 0x0402B41A RID: 177178
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B41B RID: 177179
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B41C RID: 177180
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020086CE RID: 34510
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetIsUseCatapultUpAnim_FunctionParams
	{
		// Token: 0x0402B41D RID: 177181
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B41E RID: 177182
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B41F RID: 177183
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020086CF RID: 34511
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetNextMultiSkillId_FunctionParams
	{
		// Token: 0x0402B420 RID: 177184
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B421 RID: 177185
		[FieldOffset(4)]
		public int skillId;

		// Token: 0x0402B422 RID: 177186
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B423 RID: 177187
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020086D0 RID: 34512
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetNextMultiSkillIdNew_FunctionParams
	{
		// Token: 0x0402B424 RID: 177188
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B425 RID: 177189
		[FieldOffset(4)]
		public int skillId;

		// Token: 0x0402B426 RID: 177190
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B427 RID: 177191
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x020086D1 RID: 34513
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetManipulateInteractTargetCanInteract_FunctionParams
	{
		// Token: 0x0402B428 RID: 177192
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B429 RID: 177193
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B42A RID: 177194
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020086D2 RID: 34514
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHookInteractTargetCanInteract_FunctionParams
	{
		// Token: 0x0402B42B RID: 177195
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B42C RID: 177196
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B42D RID: 177197
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020086D3 RID: 34515
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetHookInteractTargetIsIgnorePlayerCollision_FunctionParams
	{
		// Token: 0x0402B42E RID: 177198
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B42F RID: 177199
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B430 RID: 177200
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020086D4 RID: 34516
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __StartManipulateInteract_FunctionParams
	{
		// Token: 0x0402B431 RID: 177201
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B432 RID: 177202
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B433 RID: 177203
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020086D5 RID: 34517
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EndManipulateInteract_FunctionParams
	{
		// Token: 0x0402B434 RID: 177204
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B435 RID: 177205
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086D6 RID: 34518
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __StartStatueInteract_FunctionParams
	{
		// Token: 0x0402B436 RID: 177206
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B437 RID: 177207
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B438 RID: 177208
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020086D7 RID: 34519
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EndStatueInteract_FunctionParams
	{
		// Token: 0x0402B439 RID: 177209
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B43A RID: 177210
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086D8 RID: 34520
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __StartCustomInteract_FunctionParams
	{
		// Token: 0x0402B43B RID: 177211
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B43C RID: 177212
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B43D RID: 177213
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020086D9 RID: 34521
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EndCustomInteract_FunctionParams
	{
		// Token: 0x0402B43E RID: 177214
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B43F RID: 177215
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086DA RID: 34522
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __QuantumDiffusionInteract_FunctionParams
	{
		// Token: 0x0402B440 RID: 177216
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B441 RID: 177217
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086DB RID: 34523
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetShootSwordManipulateInteractActors_FunctionParams
	{
		// Token: 0x0402B442 RID: 177218
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B443 RID: 177219
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B444 RID: 177220
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x020086DC RID: 34524
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetManipulateInteractLocation_FunctionParams
	{
		// Token: 0x0402B445 RID: 177221
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B446 RID: 177222
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B447 RID: 177223
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x020086DD RID: 34525
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __EnvironmentInfoDetect_FunctionParams
	{
		// Token: 0x0402B448 RID: 177224
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B449 RID: 177225
		[FieldOffset(8)]
		public FVectorDouble location;

		// Token: 0x0402B44A RID: 177226
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086DE RID: 34526
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __LockOnSpecifyTarget_FunctionParams
	{
		// Token: 0x0402B44B RID: 177227
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B44C RID: 177228
		[FieldOffset(4)]
		public int targetEntityId;

		// Token: 0x0402B44D RID: 177229
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086DF RID: 34527
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsSkillInCd_FunctionParams
	{
		// Token: 0x0402B44E RID: 177230
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B44F RID: 177231
		[FieldOffset(4)]
		public int skillId;

		// Token: 0x0402B450 RID: 177232
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B451 RID: 177233
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020086E0 RID: 34528
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SendHookSkillUseLogData_FunctionParams
	{
		// Token: 0x0402B452 RID: 177234
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B453 RID: 177235
		[FieldOffset(4)]
		public bool hasTarget;

		// Token: 0x0402B454 RID: 177236
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086E1 RID: 34529
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SendManipulateSkillUseLogData_FunctionParams
	{
		// Token: 0x0402B455 RID: 177237
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B456 RID: 177238
		[FieldOffset(4)]
		public bool hasTarget;

		// Token: 0x0402B457 RID: 177239
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086E2 RID: 34530
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SendScanSkillUseLogData_FunctionParams
	{
		// Token: 0x0402B458 RID: 177240
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B459 RID: 177241
		[FieldOffset(4)]
		public bool hasTarget;

		// Token: 0x0402B45A RID: 177242
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086E3 RID: 34531
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __DynamicAttachEntityToActor_FunctionParams
	{
		// Token: 0x0402B45B RID: 177243
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B45C RID: 177244
		[FieldOffset(4)]
		public int targetEntityId;

		// Token: 0x0402B45D RID: 177245
		[FieldOffset(8)]
		public FName socketName;

		// Token: 0x0402B45E RID: 177246
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086E4 RID: 34532
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetEntityEnable_FunctionParams
	{
		// Token: 0x0402B45F RID: 177247
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B460 RID: 177248
		[FieldOffset(4)]
		public bool enable;

		// Token: 0x0402B461 RID: 177249
		[FieldOffset(8)]
		public IntPtr callObject;

		// Token: 0x0402B462 RID: 177250
		[FieldOffset(16)]
		public FString reason;

		// Token: 0x0402B463 RID: 177251
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086E5 RID: 34533
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetActorVisible_FunctionParams
	{
		// Token: 0x0402B464 RID: 177252
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B465 RID: 177253
		[FieldOffset(4)]
		public bool visible;

		// Token: 0x0402B466 RID: 177254
		[FieldOffset(5)]
		public bool collision;

		// Token: 0x0402B467 RID: 177255
		[FieldOffset(6)]
		public bool movable;

		// Token: 0x0402B468 RID: 177256
		[FieldOffset(8)]
		public FString reason;

		// Token: 0x0402B469 RID: 177257
		[FieldOffset(24)]
		public bool sync;

		// Token: 0x0402B46A RID: 177258
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086E6 RID: 34534
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetSkillTargetDirection_FunctionParams
	{
		// Token: 0x0402B46B RID: 177259
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B46C RID: 177260
		[FieldOffset(4)]
		public byte direction;

		// Token: 0x0402B46D RID: 177261
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086E7 RID: 34535
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ChangeAiControllerDebugDraw_FunctionParams
	{
		// Token: 0x0402B46E RID: 177262
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B46F RID: 177263
		[FieldOffset(4)]
		public bool debug;

		// Token: 0x0402B470 RID: 177264
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086E8 RID: 34536
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBeHitAnimType_FunctionParams
	{
		// Token: 0x0402B471 RID: 177265
		[FieldOffset(0)]
		public int typeId;

		// Token: 0x0402B472 RID: 177266
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B473 RID: 177267
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x020086E9 RID: 34537
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __StartInhalation_FunctionParams
	{
		// Token: 0x0402B474 RID: 177268
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B475 RID: 177269
		[FieldOffset(4)]
		public float strength;

		// Token: 0x0402B476 RID: 177270
		[FieldOffset(8)]
		public float distance;

		// Token: 0x0402B477 RID: 177271
		[FieldOffset(12)]
		public bool isPowerfulMode;

		// Token: 0x0402B478 RID: 177272
		[FieldOffset(16)]
		public float checkAngle;

		// Token: 0x0402B479 RID: 177273
		[FieldOffset(24)]
		public byte tag;

		// Token: 0x0402B47A RID: 177274
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086EA RID: 34538
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __StopInhalation_FunctionParams
	{
		// Token: 0x0402B47B RID: 177275
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B47C RID: 177276
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086EB RID: 34539
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __TryGetDebugMovementComp_FunctionParams
	{
		// Token: 0x0402B47D RID: 177277
		[FieldOffset(0)]
		public FString pbDataId;

		// Token: 0x0402B47E RID: 177278
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402B47F RID: 177279
		[FieldOffset(24)]
		public IntPtr __Result;
	}

	// Token: 0x020086EC RID: 34540
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __TryPlayLinkAnim_FunctionParams
	{
		// Token: 0x0402B480 RID: 177280
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086ED RID: 34541
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __TraceGround_FunctionParams
	{
		// Token: 0x0402B481 RID: 177281
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B482 RID: 177282
		[FieldOffset(8)]
		public FVectorDouble start;

		// Token: 0x0402B483 RID: 177283
		[FieldOffset(32)]
		public FVectorDouble end;

		// Token: 0x0402B484 RID: 177284
		[FieldOffset(56)]
		public bool draw;

		// Token: 0x0402B485 RID: 177285
		[FieldOffset(64)]
		public IntPtr __WorldContext;

		// Token: 0x0402B486 RID: 177286
		[FieldOffset(72)]
		public FVectorDouble __Result;
	}

	// Token: 0x020086EE RID: 34542
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __ChangePhantomTeam_FunctionParams
	{
		// Token: 0x0402B487 RID: 177287
		[FieldOffset(0)]
		public int phantomFormationId;

		// Token: 0x0402B488 RID: 177288
		[FieldOffset(8)]
		public byte skillTriggerTags;

		// Token: 0x0402B489 RID: 177289
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086EF RID: 34543
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __RevertPhantomTeam_FunctionParams
	{
		// Token: 0x0402B48A RID: 177290
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086F0 RID: 34544
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetFormationAttribute_FunctionParams
	{
		// Token: 0x0402B48B RID: 177291
		[FieldOffset(0)]
		public int type;

		// Token: 0x0402B48C RID: 177292
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B48D RID: 177293
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020086F1 RID: 34545
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetEntityDeltaMillisecond_FunctionParams
	{
		// Token: 0x0402B48E RID: 177294
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B48F RID: 177295
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B490 RID: 177296
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020086F2 RID: 34546
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SyncTwoEntityLocationAndRotation_FunctionParams
	{
		// Token: 0x0402B491 RID: 177297
		[FieldOffset(0)]
		public int fromEntityId;

		// Token: 0x0402B492 RID: 177298
		[FieldOffset(4)]
		public int toEntityId;

		// Token: 0x0402B493 RID: 177299
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086F3 RID: 34547
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetFishingBoat_FunctionParams
	{
		// Token: 0x0402B494 RID: 177300
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B495 RID: 177301
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x020086F4 RID: 34548
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FishingBoatSprint_FunctionParams
	{
		// Token: 0x0402B496 RID: 177302
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B497 RID: 177303
		[FieldOffset(4)]
		public float maxSpeedRatio;

		// Token: 0x0402B498 RID: 177304
		[FieldOffset(8)]
		public int exceedLimitDuration;

		// Token: 0x0402B499 RID: 177305
		[FieldOffset(12)]
		public int duration;

		// Token: 0x0402B49A RID: 177306
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086F5 RID: 34549
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __FishingBoatSkill_FunctionParams
	{
		// Token: 0x0402B49B RID: 177307
		[FieldOffset(0)]
		public byte type;

		// Token: 0x0402B49C RID: 177308
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086F6 RID: 34550
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCharacterMorphType_FunctionParams
	{
		// Token: 0x0402B49D RID: 177309
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B49E RID: 177310
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B49F RID: 177311
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x020086F7 RID: 34551
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCharacterMorphType_FunctionParams
	{
		// Token: 0x0402B4A0 RID: 177312
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B4A1 RID: 177313
		[FieldOffset(4)]
		public byte morphType;

		// Token: 0x0402B4A2 RID: 177314
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086F8 RID: 34552
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetSpecialEnergyAttrValue_FunctionParams
	{
		// Token: 0x0402B4A3 RID: 177315
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B4A4 RID: 177316
		[FieldOffset(4)]
		public int attrId;

		// Token: 0x0402B4A5 RID: 177317
		[FieldOffset(8)]
		public int value;

		// Token: 0x0402B4A6 RID: 177318
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086F9 RID: 34553
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetFuLuoLuoSpecialEnergyType_FunctionParams
	{
		// Token: 0x0402B4A7 RID: 177319
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B4A8 RID: 177320
		[FieldOffset(4)]
		public int index;

		// Token: 0x0402B4A9 RID: 177321
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B4AA RID: 177322
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x020086FA RID: 34554
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __StartBattleQte_FunctionParams
	{
		// Token: 0x0402B4AB RID: 177323
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B4AC RID: 177324
		[FieldOffset(4)]
		public int skillId;

		// Token: 0x0402B4AD RID: 177325
		[FieldOffset(8)]
		public int battleQteId;

		// Token: 0x0402B4AE RID: 177326
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086FB RID: 34555
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __StopGroup1Skill_FunctionParams
	{
		// Token: 0x0402B4AF RID: 177327
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B4B0 RID: 177328
		[FieldOffset(8)]
		public FString reason;

		// Token: 0x0402B4B1 RID: 177329
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020086FC RID: 34556
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 88)]
	protected ref struct __GetCharactersLocationNearBy_FunctionParams
	{
		// Token: 0x0402B4B2 RID: 177330
		[FieldOffset(0)]
		public FVectorDouble center;

		// Token: 0x0402B4B3 RID: 177331
		[FieldOffset(24)]
		public float distance;

		// Token: 0x0402B4B4 RID: 177332
		[FieldOffset(28)]
		public int maxCount;

		// Token: 0x0402B4B5 RID: 177333
		[FieldOffset(32)]
		public IntPtr __WorldContext;

		// Token: 0x0402B4B6 RID: 177334
		[FieldOffset(40)]
		public byte __Result;
	}

	// Token: 0x020086FD RID: 34557
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetCurrentPlayer_FunctionParams
	{
		// Token: 0x0402B4B7 RID: 177335
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B4B8 RID: 177336
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x020086FE RID: 34558
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __IsEnemy_FunctionParams
	{
		// Token: 0x0402B4B9 RID: 177337
		[FieldOffset(0)]
		public IntPtr owner;

		// Token: 0x0402B4BA RID: 177338
		[FieldOffset(8)]
		public IntPtr other;

		// Token: 0x0402B4BB RID: 177339
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402B4BC RID: 177340
		[FieldOffset(24)]
		public bool __Result;
	}

	// Token: 0x020086FF RID: 34559
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetWalkOffLedge_FunctionParams
	{
		// Token: 0x0402B4BD RID: 177341
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B4BE RID: 177342
		[FieldOffset(4)]
		public bool walkOff;

		// Token: 0x0402B4BF RID: 177343
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008700 RID: 34560
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __StartFlyingFeather_FunctionParams
	{
		// Token: 0x0402B4C0 RID: 177344
		[FieldOffset(0)]
		public IntPtr owner;

		// Token: 0x0402B4C1 RID: 177345
		[FieldOffset(8)]
		public FVectorDouble initLocation;

		// Token: 0x0402B4C2 RID: 177346
		[FieldOffset(32)]
		public IntPtr config;

		// Token: 0x0402B4C3 RID: 177347
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008701 RID: 34561
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetFlyingFeatherTargetId_FunctionParams
	{
		// Token: 0x0402B4C4 RID: 177348
		[FieldOffset(0)]
		public IntPtr owner;

		// Token: 0x0402B4C5 RID: 177349
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B4C6 RID: 177350
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008702 RID: 34562
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __AddFlyingFeatherTargetTag_FunctionParams
	{
		// Token: 0x0402B4C7 RID: 177351
		[FieldOffset(0)]
		public FGameplayTag tag;

		// Token: 0x0402B4C8 RID: 177352
		[FieldOffset(16)]
		public FString entityId;

		// Token: 0x0402B4C9 RID: 177353
		[FieldOffset(32)]
		public IntPtr __WorldContext;

		// Token: 0x0402B4CA RID: 177354
		[FieldOffset(40)]
		public IntPtr __Result;
	}

	// Token: 0x02008703 RID: 34563
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __UpdateFlyingFeather_FunctionParams
	{
		// Token: 0x0402B4CB RID: 177355
		[FieldOffset(0)]
		public IntPtr owner;

		// Token: 0x0402B4CC RID: 177356
		[FieldOffset(8)]
		public FString target;

		// Token: 0x0402B4CD RID: 177357
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402B4CE RID: 177358
		[FieldOffset(32)]
		public FVectorDouble __Result;
	}

	// Token: 0x02008704 RID: 34564
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __EmitGlobalClientEvent_FunctionParams
	{
		// Token: 0x0402B4CF RID: 177359
		[FieldOffset(0)]
		public FGameplayTag eventNameTag;

		// Token: 0x0402B4D0 RID: 177360
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008705 RID: 34565
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetDriverEntityId_FunctionParams
	{
		// Token: 0x0402B4D1 RID: 177361
		[FieldOffset(0)]
		public int vehicleEntityId;

		// Token: 0x0402B4D2 RID: 177362
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B4D3 RID: 177363
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x02008706 RID: 34566
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __StartCableWayMove_FunctionParams
	{
		// Token: 0x0402B4D4 RID: 177364
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402B4D5 RID: 177365
		[FieldOffset(8)]
		public IntPtr eventBinder;

		// Token: 0x0402B4D6 RID: 177366
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008707 RID: 34567
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __StopCableWayMove_FunctionParams
	{
		// Token: 0x0402B4D7 RID: 177367
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402B4D8 RID: 177368
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008708 RID: 34568
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBuffInstigatorId_FunctionParams
	{
		// Token: 0x0402B4D9 RID: 177369
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B4DA RID: 177370
		[FieldOffset(4)]
		public int buffId;

		// Token: 0x0402B4DB RID: 177371
		[FieldOffset(8)]
		public bool getInstigatorSummoner;

		// Token: 0x0402B4DC RID: 177372
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402B4DD RID: 177373
		[FieldOffset(24)]
		public int __Result;
	}

	// Token: 0x02008709 RID: 34569
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 104)]
	protected ref struct __SetSubMeshOrder_FunctionParams
	{
		// Token: 0x0402B4DE RID: 177374
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B4DF RID: 177375
		[FieldOffset(8)]
		public FString meshName;

		// Token: 0x0402B4E0 RID: 177376
		[FieldOffset(24)]
		public bool visible;

		// Token: 0x0402B4E1 RID: 177377
		[FieldOffset(32)]
		public IntPtr charControllerData;

		// Token: 0x0402B4E2 RID: 177378
		[FieldOffset(40)]
		public byte effectDataAssetRef;

		// Token: 0x0402B4E3 RID: 177379
		[FieldOffset(88)]
		public float delayTime;

		// Token: 0x0402B4E4 RID: 177380
		[FieldOffset(96)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200870A RID: 34570
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetPilotThrowSpeed_FunctionParams
	{
		// Token: 0x0402B4E5 RID: 177381
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B4E6 RID: 177382
		[FieldOffset(8)]
		public float __Result;
	}

	// Token: 0x0200870B RID: 34571
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetPilotThrowDirection_FunctionParams
	{
		// Token: 0x0402B4E7 RID: 177383
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B4E8 RID: 177384
		[FieldOffset(8)]
		public FVectorDouble __Result;
	}

	// Token: 0x0200870C RID: 34572
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetPilotThrowGravity_FunctionParams
	{
		// Token: 0x0402B4E9 RID: 177385
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B4EA RID: 177386
		[FieldOffset(8)]
		public float __Result;
	}

	// Token: 0x0200870D RID: 34573
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetPilotThrowNeedMotorRide_FunctionParams
	{
		// Token: 0x0402B4EB RID: 177387
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B4EC RID: 177388
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x0200870E RID: 34574
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetPilotThrowIsDisableInterrupt_FunctionParams
	{
		// Token: 0x0402B4ED RID: 177389
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B4EE RID: 177390
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x0200870F RID: 34575
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __OpenPilotThrowGameplayCamera_FunctionParams
	{
		// Token: 0x0402B4EF RID: 177391
		[FieldOffset(0)]
		public int targetEntityId;

		// Token: 0x0402B4F0 RID: 177392
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008710 RID: 34576
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCurrentTargetPilotSkeletalMeshComponent_FunctionParams
	{
		// Token: 0x0402B4F1 RID: 177393
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B4F2 RID: 177394
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B4F3 RID: 177395
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02008711 RID: 34577
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetPilotCurrentInRangePoint_FunctionParams
	{
		// Token: 0x0402B4F4 RID: 177396
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402B4F5 RID: 177397
		[FieldOffset(8)]
		public FVectorDouble __Result;
	}

	// Token: 0x02008712 RID: 34578
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetVehicleCatapultUnitRisingTime_FunctionParams
	{
		// Token: 0x0402B4F6 RID: 177398
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B4F7 RID: 177399
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B4F8 RID: 177400
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02008713 RID: 34579
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __GuessJokerNpcTurnToIdlePerform_FunctionParams
	{
		// Token: 0x0402B4F9 RID: 177401
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008714 RID: 34580
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __LevelFlowDeadlySkeletonMeshCastToCharacter_FunctionParams
	{
		// Token: 0x0402B4FA RID: 177402
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008715 RID: 34581
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __LevelFlowAddBuff_FunctionParams
	{
		// Token: 0x0402B4FB RID: 177403
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B4FC RID: 177404
		[FieldOffset(4)]
		public int buffId;

		// Token: 0x0402B4FD RID: 177405
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008716 RID: 34582
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __LevelFlowRemoveBuff_FunctionParams
	{
		// Token: 0x0402B4FE RID: 177406
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B4FF RID: 177407
		[FieldOffset(4)]
		public int buffId;

		// Token: 0x0402B500 RID: 177408
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008717 RID: 34583
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __LevelFlowCameraShake_FunctionParams
	{
		// Token: 0x0402B501 RID: 177409
		[FieldOffset(0)]
		public FString cameraShakeBp;

		// Token: 0x0402B502 RID: 177410
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008718 RID: 34584
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __LevelFlowPlayLevelSequence_FunctionParams
	{
		// Token: 0x0402B503 RID: 177411
		[FieldOffset(0)]
		public FString path;

		// Token: 0x0402B504 RID: 177412
		[FieldOffset(16)]
		public FString mark;

		// Token: 0x0402B505 RID: 177413
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008719 RID: 34585
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1816)]
	protected ref struct __CallSpecialSkillCodeFunction_FunctionParams
	{
		// Token: 0x0402B506 RID: 177414
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B507 RID: 177415
		[FieldOffset(8)]
		public FString functionName;

		// Token: 0x0402B508 RID: 177416
		[FieldOffset(24)]
		public byte payload;

		// Token: 0x0402B509 RID: 177417
		[FieldOffset(904)]
		public IntPtr __WorldContext;

		// Token: 0x0402B50A RID: 177418
		[FieldOffset(912)]
		public byte __Result;
	}

	// Token: 0x0200871A RID: 34586
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __XigelikaAddBean_FunctionParams
	{
		// Token: 0x0402B50B RID: 177419
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B50C RID: 177420
		[FieldOffset(8)]
		public FString bean;

		// Token: 0x0402B50D RID: 177421
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402B50E RID: 177422
		[FieldOffset(32)]
		public int __Result;
	}

	// Token: 0x0200871B RID: 34587
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __XigelikaGetBeanResultant_FunctionParams
	{
		// Token: 0x0402B50F RID: 177423
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B510 RID: 177424
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B511 RID: 177425
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x0200871C RID: 34588
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __XigelikaConsumeBean_FunctionParams
	{
		// Token: 0x0402B512 RID: 177426
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B513 RID: 177427
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200871D RID: 34589
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __XigelikaResetBean_FunctionParams
	{
		// Token: 0x0402B514 RID: 177428
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B515 RID: 177429
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200871E RID: 34590
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __OpenQuickHack_FunctionParams
	{
		// Token: 0x0402B516 RID: 177430
		[FieldOffset(0)]
		public int deviceId;

		// Token: 0x0402B517 RID: 177431
		[FieldOffset(4)]
		public int ownerEntityId;

		// Token: 0x0402B518 RID: 177432
		[FieldOffset(8)]
		public bool closeWhenInteractFinish;

		// Token: 0x0402B519 RID: 177433
		[FieldOffset(12)]
		public FGameplayTag interactFinishGameplayEventTag;

		// Token: 0x0402B51A RID: 177434
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200871F RID: 34591
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __CloseQuickHack_FunctionParams
	{
		// Token: 0x0402B51B RID: 177435
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008720 RID: 34592
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __FunctionOpen_FunctionParams
	{
		// Token: 0x0402B51C RID: 177436
		[FieldOffset(0)]
		public int functionType;

		// Token: 0x0402B51D RID: 177437
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B51E RID: 177438
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008721 RID: 34593
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __CreateTempActor_FunctionParams
	{
		// Token: 0x0402B51F RID: 177439
		[FieldOffset(0)]
		public int playerId;

		// Token: 0x0402B520 RID: 177440
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[FieldOffset(8)]
		public TSubclassOf<AActor> actorClass;

		// Token: 0x0402B521 RID: 177441
		[FieldOffset(16)]
		public FTransformDouble transform;

		// Token: 0x0402B522 RID: 177442
		[FieldOffset(80)]
		public IntPtr __WorldContext;

		// Token: 0x0402B523 RID: 177443
		[FieldOffset(88)]
		public bool __Result;
	}

	// Token: 0x02008722 RID: 34594
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __DestroyTempActor_FunctionParams
	{
		// Token: 0x0402B524 RID: 177444
		[FieldOffset(0)]
		public int playerId;

		// Token: 0x0402B525 RID: 177445
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B526 RID: 177446
		[FieldOffset(16)]
		public bool __Result;
	}
}
