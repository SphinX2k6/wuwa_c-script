using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.Qte;
using UnrealEngine;

// Token: 0x02001AE9 RID: 6889
[NullableContext(2)]
[Nullable(0)]
public class BattleQteContext
{
	// Token: 0x060111A0 RID: 70048 RVA: 0x00505D01 File Offset: 0x00503F01
	public void QteSuccess()
	{
		this.HandleAction(true);
	}

	// Token: 0x060111A1 RID: 70049 RVA: 0x00505D0A File Offset: 0x00503F0A
	public void QteFail()
	{
		this.HandleAction(false);
	}

	// Token: 0x060111A2 RID: 70050 RVA: 0x00505D14 File Offset: 0x00503F14
	private void HandleAction(bool isSuccess)
	{
		SBattleQte battleQteConfig = BattleQteModel.Instance.GetBattleQteConfig(this.BattleQteId);
		if (battleQteConfig == null)
		{
			return;
		}
		EntityHandle entityHandle = this.EntityHandle;
		WorldEntity inEntity = (entityHandle != null) ? entityHandle.Entity : null;
		TArray<SBattleQteAction> actions = isSuccess ? battleQteConfig.SuccessActions : battleQteConfig.FailActions;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
		defaultInterpolatedStringHandler.AppendLiteral("HandleId:");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.BattleQteHandleId);
		defaultInterpolatedStringHandler.AppendLiteral(" BattleQteId:");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.BattleQteId);
		string tips = defaultInterpolatedStringHandler.ToStringAndClear();
		BattleQteContext.HandleActionTest(actions, inEntity, this.MessageId, tips);
	}

	// Token: 0x060111A3 RID: 70051 RVA: 0x00505DB4 File Offset: 0x00503FB4
	public static void HandleActionTest([Nullable(1)] TArray<SBattleQteAction> actions, Entity inEntity = null, long? messageId = null, string tips = null)
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
		for (int i = 0; i < actions.Num(); i++)
		{
			SBattleQteAction sbattleQteAction = actions.Get(i);
			Entity entity;
			if (sbattleQteAction.Target == 0)
			{
				entity = inEntity;
			}
			else if (sbattleQteAction.Target == 1)
			{
				entity = worldEntity;
			}
			else
			{
				entity = null;
			}
			if (entity != null)
			{
				BattleQteContext.HandleActionInternal(entity, sbattleQteAction, messageId, tips);
			}
		}
	}

	// Token: 0x060111A4 RID: 70052 RVA: 0x00505E20 File Offset: 0x00504020
	[NullableContext(1)]
	private static void HandleActionInternal(Entity entity, SBattleQteAction action, long? messageId = null, [Nullable(2)] string tips = null)
	{
		if (messageId == null || messageId.Value == 0L)
		{
			return;
		}
		BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
		bool flag = true;
		if (component != null)
		{
			TArray<FGameplayTag> tagConditions = action.TagConditions;
			int num = tagConditions.Num();
			for (int i = 0; i < num; i++)
			{
				FGameplayTag tag = tagConditions.Get(i);
				if (!component.HasTag(tag.TagId()))
				{
					flag = false;
					break;
				}
			}
		}
		if (component == null || !flag)
		{
			return;
		}
		TArray<FGameplayTag> addTags = action.AddTags;
		int num2 = addTags.Num();
		for (int j = 0; j < num2; j++)
		{
			component.AddTag(new int?(addTags.Get(j).TagId()));
		}
		TArray<FGameplayTag> removeTags = action.RemoveTags;
		int num3 = removeTags.Num();
		for (int k = 0; k < num3; k++)
		{
			component.RemoveTag(new int?(removeTags.Get(k).TagId()));
		}
		CharacterBuffComponent characterBuffComponent = null;
		TArray<long> addBuffs = action.AddBuffs;
		int num4 = addBuffs.Num();
		if (num4 > 0)
		{
			if (characterBuffComponent == null)
			{
				characterBuffComponent = entity.GetComponent<CharacterBuffComponent>();
			}
			if (characterBuffComponent != null)
			{
				for (int l = 0; l < num4; l++)
				{
					long buffId = addBuffs.Get(l);
					characterBuffComponent.AddBuff(buffId, new AddBuffParam
					{
						InstigatorId = characterBuffComponent.CreatureDataId,
						Reason = "战斗Qte结束时添加buff",
						PreMessageId = new long?(messageId.Value)
					});
				}
			}
		}
		TArray<long> removeBuffs = action.RemoveBuffs;
		int num5 = removeBuffs.Num();
		if (num5 > 0)
		{
			if (characterBuffComponent == null)
			{
				characterBuffComponent = entity.GetComponent<CharacterBuffComponent>();
			}
			if (characterBuffComponent != null)
			{
				for (int m = 0; m < num5; m++)
				{
					long buffId2 = removeBuffs.Get(m);
					characterBuffComponent.RemoveBuff(buffId2, -1, "战斗Qte结束时移除buff", new long?(messageId.Value), null, null);
				}
			}
		}
		TArray<long> addBullets = action.AddBullets;
		int num6 = addBullets.Num();
		for (int n = 0; n < num6; n++)
		{
			long num7 = addBullets.Get(n);
			BulletController.Instance.CreateBulletCustomTarget(entity, num7.ToString(), null, new BulletController.BulletCreateParams(), new long?(messageId.Value), EBulletCreateSource.Others);
		}
		int useSkillId = action.UseSkillId;
		if (useSkillId != 0)
		{
			CharacterSkillComponent component2 = entity.GetComponent<CharacterSkillComponent>();
			if (component2 != null)
			{
				if (action.ChangeMainSkillPriority != -1)
				{
					Skill currentSkill = component2.CurrentSkill;
					if (currentSkill != null)
					{
						bool flag2 = false;
						using (IEnumerator<ESkillGenre> enumerator = currentSkill.SkillGenres.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (enumerator.Current == ESkillGenre.大招3)
								{
									flag2 = true;
									break;
								}
							}
						}
						if (!flag2)
						{
							component2.SetSkillPriority(currentSkill.SkillId, action.ChangeMainSkillPriority);
						}
					}
				}
				component2.BeginSkill(useSkillId, new SkillParam
				{
					Reason = "BattleQteContext.HandleActionInternal"
				});
			}
		}
		EBattleQteCustomAction ebattleQteCustomAction = action.CustomAction;
		if (ebattleQteCustomAction > EBattleQteCustomAction.无)
		{
			if (ebattleQteCustomAction == EBattleQteCustomAction.切换角色)
			{
				BattleQteCustomAction.battleQteChangeRole(null);
				return;
			}
			if (ebattleQteCustomAction != EBattleQteCustomAction.切换到指定角色)
			{
				return;
			}
			int num8;
			if (int.TryParse(action.CustomActionParam, out num8) && num8 != 0)
			{
				BattleQteCustomAction.battleQteChangeRole(new int?(num8));
			}
		}
	}

	// Token: 0x0400967D RID: 38525
	private const int TARGET_QTE_SOURCER = 0;

	// Token: 0x0400967E RID: 38526
	private const int TARGET_PLAYER_SELF = 1;

	// Token: 0x0400967F RID: 38527
	public int BattleQteHandleId = -1;

	// Token: 0x04009680 RID: 38528
	public int BattleQteId;

	// Token: 0x04009681 RID: 38529
	public int CommonQteHandleId = -1;

	// Token: 0x04009682 RID: 38530
	public int CommonQteId;

	// Token: 0x04009683 RID: 38531
	public EBattleQteSource? BattleQteSource;

	// Token: 0x04009684 RID: 38532
	public long? MessageId;

	// Token: 0x04009685 RID: 38533
	public EntityHandle EntityHandle;
}
